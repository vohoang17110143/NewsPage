using NewsPage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.Entities
{
    public class NewsImage
    {
        public int Id { get; set; }

        public int NewsId { get; set; }

        public string ImagePath { get; set; }

        public string Caption { get; set; }

        public bool IsDefault { get; set; }

        public DateTime DateCreated { get; set; }

        public int SortOrder { get; set; }

        public long FileSize { get; set; }

        public New New { get; set; }
    }
}