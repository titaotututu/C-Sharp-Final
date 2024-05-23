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
    public class Travel
    {
        [Key]
        public long TravelId { get; set; }
        public string TravelTitle { get; set; }
        public string TravelCity { get; set; }
        public List<TodoItem> TodoItems { get; set; }
        public DateTime? TravelTime { get; set; }// 行程开始时间
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
