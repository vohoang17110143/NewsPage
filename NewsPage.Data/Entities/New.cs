using NewsPage.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPage.Models.Entities
{
    public class New
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public DateTime DateCreated { set; get; }
        public string Creator { get; set; }
        public int ViewCount { get; set; }

        public string Description { set; get; }

        public string Content { set; get; }

        public bool IsShowOnHome { set; get; }

        public List<NewsInCategory> NewsInCategories { get; set; }
        public bool IsHotNews { get; set; }

        public List<Comment> Comments { get; set; }

        //Ảnh bìa
        public List<NewsImage> NewsImages { get; set; }

        public List<NewsSaveDetail> NewsSaveDetails { get; set; }
    }
}