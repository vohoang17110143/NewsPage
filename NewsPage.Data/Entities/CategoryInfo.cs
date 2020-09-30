using NewsPage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.Entities
{
    public class CategoryInfo
    {
        public int Id { set; get; }
        public int CategoryId { set; get; }
        public string Name { set; get; }

        public Category Category { get; set; }
    }
}