using NewsPage.Data.Entities;
using NewsPage.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPage.Models.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }

        public List<NewsInCategory> NewsInCategories { get; set; }
        public List<CategoryInfo> CategoryInfos { get; set; }
    }
}