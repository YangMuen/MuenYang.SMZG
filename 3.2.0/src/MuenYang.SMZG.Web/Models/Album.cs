using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuenYang.SMZG.Web.Models
{
    public class Album
    {
        /// <summary>
        /// 2017年1月节目
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 这是2017年1月份的节目，测试使用
        /// </summary>
        public string Introduce { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Picture { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ItemListItem> ItemList { get; set; }
    }

    public class ItemListItem
    {
        /// <summary>
        /// 2017-01-02[文]
        /// </summary>
        public string date { get; set; }
        /// <summary>
        /// 山外天园特约稿：以色列的小使女(001)转机记
        /// </summary>
        public string title { get; set; }
    }
}