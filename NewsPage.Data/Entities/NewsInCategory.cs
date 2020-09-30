using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPage.Models.Entities
{
    public class NewsInCategory
    {
        public int NewsId { get; set; }

        public New News { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}