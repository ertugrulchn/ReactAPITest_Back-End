using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReactAPITest_Back_End.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        public string firstName { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        public string lastName { get; set; }
        public int age { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string city { get; set; }
    }
}
