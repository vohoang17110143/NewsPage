using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.Entities
{
    public class NewsSave
    {
        public int Id { set; get; }
        public DateTime DateRead { set; get; }
        public Guid UserId { set; get; }

        public List<NewsSaveDetail> NewsSaveDetails { get; set; }
        public AppUser AppUser { get; set; }
    }
}