using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
namespace TravelApi.Models
{
    public class TodoItem
    {
        [Key]
        public long ItemId { get; set; }
        public DateTime Time { get; set; }// 时间
        public string Place {  get; set; }
        public string Description { get; set; }// 设置待办的时候写的“要做什么事情”
        public string? ComplicationNote { get; set; }// 完成待办时的记录
        public string? Picture { get; set; } //上传的照片
        public bool IsCompleted { get; set; }// 是否完成

        public long TravelId { get; set; }
        [ForeignKey("TravelId")]
        public Travel? Travel { get; set; }

    }
}
