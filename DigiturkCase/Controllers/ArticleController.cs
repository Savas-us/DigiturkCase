using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DigiturkCase.Dal.Abstract;
using DigiturkCase.Entities;
using DigiturkCase.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigiturkCase.Controllers
{
    [Route("api/Article")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleDal _articleDal;
        private readonly IMapper _mapper;
        public ArticleController(IArticleDal articleDal,IMapper mapper)
        {
            _articleDal = articleDal;
            _mapper = mapper;
        }

        // GET api/Article
        [HttpGet]
        public IEnumerable<ArticleModel> Get()
        {
            return _mapper.Map<IEnumerable<ArticleModel>>(_articleDal.GetList(x=>x.IsActive));
        }

        // GET api/Article/5
        [HttpGet("{id}")]
        public ActionResult<ArticleModel> Get(Guid id)
        {
            return _mapper.Map<ArticleModel>(_articleDal.GetT(x => x.ArticleId == id && x.IsActive));
        }

        // POST api/Article
        [HttpPost]
        public IActionResult Post([FromBody] ArticleModel value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            value.CreatedDate = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy hh:mm"));
            _articleDal.Add(_mapper.Map<Article>(value));

            return Ok(_mapper.Map<ArticleModel>(value));
        }

        // PUT api/Article/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] ArticleModel value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            var article = _articleDal.GetT(x=>x.ArticleId == id);

            if (article == null)
            {
                return NotFound();
            }
            else
            {
                article = _mapper.Map<Article>(value);
                article.ArticleId = id;
                article.ModifiedDate = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy hh:mm"));
                _articleDal.Update(article);

                return Ok(_mapper.Map<ArticleModel>(article));
            }
        }

        // DELETE api/Article/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var article = _articleDal.GetT(x => x.ArticleId == id);
            if (article != null)
            {
                article.IsActive = false;
                _articleDal.Update(article);

                return Ok(_mapper.Map<ArticleModel>(article));
            }
            else
            {
                return NotFound();
            }
        }
    }
}