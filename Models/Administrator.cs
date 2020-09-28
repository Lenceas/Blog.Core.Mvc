using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Core.Mvc.Models
{
    public class Administrator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MinLength(5), MaxLength(50), Required]
        public string UserName { get; set; }
        [MinLength(6), MaxLength(50), Required]
        public string UserPwd { get; set; }
        [Range(-1, 1), Required]
        public int Status { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EditTime { get; set; }
    }
}
