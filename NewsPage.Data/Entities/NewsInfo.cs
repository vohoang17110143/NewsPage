using NewsPage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.Entities
{
    public class NewsInfo
    {
        public int Id { set; get; }
        public int NewsId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }

        public string Content { set; get; }

        public New New { set; get; }
    }
}