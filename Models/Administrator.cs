using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Core.Mvc.Models
{
    /// <summary>
    /// 管理员类
    /// </summary>
    public class Administrator
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("编号")]
        public int Id { get; set; }
        /// <summary>
        /// Guid
        /// </summary>
        [Description("Guid")]
        public string Guid { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        [MinLength(5), MaxLength(50), Required]
        [Description("账号")]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [DataType(DataType.Password)]
        [MinLength(6), MaxLength(50), Required]
        [Description("密码")]
        public string UserPwd { get; set; }
        /// <summary>
        /// 状态(-1:逻辑删除;0:锁定;1:正常)
        /// </summary>
        [Range(-1, 1), Required]
        [Description("状态")]
        public int Status { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [Description("排序")]
        public int SortId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("创建时间")]
        public DateTime CreatTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Description("更新时间")]
        public DateTime UpdateTime { get; set; }
    }
}
