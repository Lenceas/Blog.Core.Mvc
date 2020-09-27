using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Core.Mvc.Models
{
    public class Administrator
    {
        [Key]
        public int Id { get; set; }
        [MinLength(5)]
        public string UserName { get; set; }
        [MinLength(6)]
        public string UserPwd { get; set; }
        [Range(-1, 1)]
        public int Status { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EditTime { get; set; }
    }
}
