using System;
using System.ComponentModel.DataAnnotations;

namespace NewsReleaseSystem.Models
{
    public class Comments
    {
        /// <summary>
        /// 对应的新闻ID
        /// </summary>
        public int NewsId { get; set; }

        /// <summary>
        /// 对应的新闻
        /// </summary>
        public virtual News News { get; set; }

        /// <summary>
        /// 评论Id
        /// </summary>
        public int CommentsId { get; set; }

        /// <summary>
        /// 评论正文
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 评论Id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 评论 : 评论者 = 1 : 1
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// 评论时间
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime Time { get; set; }
    }
}