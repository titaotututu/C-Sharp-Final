using Microsoft.AspNetCore.Mvc;
using TravelApi.Services;
using TravelApi.Models;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JournalController : ControllerBase
    {
        private readonly IJournalService _JournalService;

        public JournalController(IJournalService journalService)
        {
            this._JournalService = journalService;
        }
       
        [HttpPost]
        public ActionResult<Journal> AddJournal(Journal journal)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyyMMdd");
                var query = _JournalService.GetJournalByDate(date);
                if (query.Count() == 0)
                {
                    journal.JournalId = System.Convert.ToInt64(date + "0000");
                }
                else
                {
                    journal.JournalId = query.First().JournalId + 1;
                }
                _JournalService.Add(journal);
                return journal;
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

        [HttpGet("get")]
        public ActionResult<Journal> GetJournal(long journalId)
        {
            var journal = _JournalService.GetJournalById(journalId);
            if (journal != null)
            {
                return journal;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("update")]
        public ActionResult<Journal> UpdateJournal(long journalId, Journal journal)
        {
            if (!journalId.Equals(journal.JournalId))
            {
                return BadRequest("The Journal cannot be modified.");
            }
            try
            {
                _JournalService.Update(journal);
                return NoContent();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
        }

        [HttpDelete("delete")]
        public ActionResult DeleteJournal(long journalId)
        {
            try
            {
                var journal = _JournalService.GetJournalById(journalId);
                if (journal != null)
                {
                    _JournalService.Delete(journal);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
