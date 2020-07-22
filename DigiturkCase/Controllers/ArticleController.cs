﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiturkCase.Dal.Abstract;
using DigiturkCase.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigiturkCase.Controllers
{
    [Route("api/Article")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleDal _articleDal;
        public ArticleController(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        // GET api/Article
        [HttpGet]
        public ActionResult<IEnumerable<Article>> Get()
        {
            return _articleDal.GetList();
        }

        // GET api/Article/5
        [HttpGet("{id}")]
        public ActionResult<Article> Get(Guid id)
        {
            return _articleDal.GetT(x => x.ArticleId == id);
        }
        // POST api/Article
        [HttpPost]
        public IActionResult Post([FromBody] Article value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            value.CreatedDate = DateTime.Now;
            _articleDal.Add(value);
            return Ok();
        }

        // PUT api/Article/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Article value)
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
                value.ModifiedDate = DateTime.Now;
                _articleDal.Update(value);
                return Ok();
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
                _articleDal.Delete(article);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}