using DigiturkCase.Core.DataAccess.EntityFramework;
using DigiturkCase.Dal.Abstract;
using DigiturkCase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiturkCase.Dal.Concrate.EntityFramework
{
    public class EfArticleDal :EfEntityRepositoryBase<Article,AppDbContext>,IArticleDal
    {

    }
}
