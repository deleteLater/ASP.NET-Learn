using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NewsReleaseSystem.Models
{
    public class User
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }
        
        /// <summary>
        /// 用户名称
        /// </summary>
        [Required(ErrorMessage = "用户名不能为空")]
        [MaxLength(20, ErrorMessage = "用户名不能超过20个字符")]
        public string Name { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        [Required(ErrorMessage = "邮箱不能为空")]
        [DataType(DataType.EmailAddress, ErrorMessage = "非法的邮箱,请重试")]
        public string Email { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        [Required(ErrorMessage = "密码不能为空")]
        [MaxLength(15, ErrorMessage = "密码长度不能超过15个字符")]
        public string Password { get; set; }

        /// <summary>
        /// 用户头像路径
        /// </summary>
        public string AvatarPath { get; set; }

        /// <summary>
        /// 用户 : 用户评论 = 1 : *
        /// </summary>
        public ICollection<Comments> Comments { get; set; }
    }
}