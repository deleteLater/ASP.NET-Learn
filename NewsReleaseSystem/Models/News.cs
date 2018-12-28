using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NewsReleaseSystem.Models
{
    public class News
    {
        /// <summary>
        /// 新闻ID
        /// </summary>
        public int NewsId { get; set; }

        /// <summary>
        /// 新闻标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 新闻正文
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 发布人
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime ReleaseTime { get; set; }

        /// <summary>
        /// 新闻图片
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// 新闻 : 新闻评论 = 1 : *
        /// </summary>
        public virtual ICollection<Comments> Comments { get; set; }
    }
}