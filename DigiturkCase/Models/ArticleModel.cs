using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiturkCase.Models
{
    public class ArticleModel
    {
        public Guid ArticleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
