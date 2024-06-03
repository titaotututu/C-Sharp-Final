using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Configuration;
using TravelApi.Services;
using TravelApi.Utils;
using TravelApi.Filter;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Consumes("multipart/form-data")]
    public class FileController : ControllerBase
    {
        private readonly IJournalService _JournalService;
        private readonly long _fileSizeLimit;
        private readonly string[] _permittedExtensions = { ".jpg", ".gif", ".jpeg", ".png" };
        private readonly string _rootPath;
        private static readonly FormOptions _defaultFormOptions = new FormOptions();

        public FileController(IJournalService journalService, IConfiguration config)
        {
            this._JournalService = journalService;
            string storedFileFolder = config.GetValue<string>("StoredFileFolder");
            this._rootPath = storedFileFolder != null ? Path.Combine(Environment.CurrentDirectory, storedFileFolder) : "";
            this._fileSizeLimit = config.GetValue<long>("fileSizeLimit");
        }

        [HttpPost("upload")]
        [DisableRequestSizeLimit]
        [DisableFormValueModelBinding]
        public async Task<IActionResult> Upload(long journalId)
        {
            if (!MultipartRequestHelper.IsMultipartContentType(Request.ContentType))
            {
                ModelState.AddModelError("File", $"The request couldn't be processed (Error 1).");
                return BadRequest(ModelState);
            }
            var fileName = "";
            var journal = _JournalService.GetJournalById(journalId);
            if (journal == null)
            {
                return BadRequest("The journal is not existed.");
            }
            var boundary = MultipartRequestHelper.GetBoundary(MediaTypeHeaderValue.Parse(Request.ContentType),
                    _defaultFormOptions.MultipartBoundaryLengthLimit);
            var reader = new MultipartReader(boundary, HttpContext.Request.Body);
            var section = await reader.ReadNextSectionAsync();

            while (section != null)
            {
                var hasContentDispositionHeader = ContentDispositionHeaderValue.TryParse(
                        section.ContentDisposition, out var contentDisposition);

                if (hasContentDispositionHeader)
                {
                    if (!MultipartRequestHelper
                        .HasFileContentDisposition(contentDisposition))
                    {
                        ModelState.AddModelError("File",
                            $"The request couldn't be processed (Error 2).");
                        return BadRequest(ModelState);
                    }
                    else
                    {
                        fileName = Path.GetRandomFileName();
                        var streamedFileContent = await FileHelper.ProcessStreamedFile(
                            section, contentDisposition, ModelState,
                            _permittedExtensions, _fileSizeLimit);

                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }

                        using (var targetStream = System.IO.File.Create(Path.Combine(_rootPath, fileName)))
                        {
                            await targetStream.WriteAsync(streamedFileContent);
                        }
                    }
                }
                // Drain any remaining section body that hasn't been consumed and
                // read the headers for the next section.
                journal.Picture = String.Join(" ", new string[] { journal.Picture, fileName });
                _JournalService.Update(journal);
                section = await reader.ReadNextSectionAsync();
            }
            return Ok();
        }


        [HttpGet("download")]
        public async Task<IActionResult> Download(string fileName)
        {
            if (!Directory.Exists(_rootPath))
            {
                Directory.CreateDirectory("static");
            }

            var filePath = Path.Combine(_rootPath, fileName);
            try
            {
                if (!System.IO.File.Exists(filePath))
                {
                    return NotFound();
                }
                var fileStream = new FileStream(filePath, FileMode.Open);
                var header = new MediaTypeHeaderValue("application/octet-stream");
                return new FileStreamResult(fileStream, header);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

        [HttpDelete("delete")]
        public IActionResult Delete(long journalId, string fileName)
        {
            var journal = _JournalService.GetJournalById(journalId);
            if (journal == null)
            {
                return NotFound();
            }
            if (!journal.Picture.Contains(fileName))
            {
                return NotFound();
            }
            journal.Picture = journal.Picture.Replace(" " + fileName, "");
            _JournalService.Update(journal);
            return Ok();
        }
    }
}
