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
    public class User
    {
        [Key]
        public long UserId { get; set; }
    }
}
