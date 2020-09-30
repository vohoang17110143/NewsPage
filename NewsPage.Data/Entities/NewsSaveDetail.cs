using NewsPage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.Entities
{
    public class NewsSaveDetail
    {
        public int NewsSaveId { set; get; }
        public int NewsId { set; get; }

        public string NewsName { get; set; }
        public NewsSave NewsSave { get; set; }

        public New News { get; set; }
    }
}