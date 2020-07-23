using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DigiturkCase.Entities;
using DigiturkCase.Models;

namespace DigiturkCase.Helpers
{
    public class AutoMapperHelper :Profile
    {
        public AutoMapperHelper()
        {
            CreateMap<Article, ArticleModel>();
            CreateMap<ArticleModel, Article>();
        }
    }
}
