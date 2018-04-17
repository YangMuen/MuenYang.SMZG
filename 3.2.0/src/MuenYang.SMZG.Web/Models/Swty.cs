using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuenYang.SMZG.Web.Models
{
    public class Swty
    {
        /// <summary>
        /// 专辑名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 专辑介绍
        /// </summary>
        public string Introduce { get; set; }
        /// <summary>
        /// 主持人
        /// </summary>
        public string Compere { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string Picture { get; set; }
        /// <summary>
        /// 节目列表
        /// </summary>
        public List<ItemListItem> ItemList { get; set; }
    }

    public class ItemListItem
    {
        /// <summary>
        /// 节目时间 2017-01-10
        /// </summary>
        public string date { get; set; }
        /// <summary>
        /// 节目名称 
        /// </summary>
        public string title { get; set; }
    }
}