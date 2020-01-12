using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuotesApi.Models;

namespace QuotesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        static List<Quote> _quotos = new List<Quote>()
        {
            new Quote() { Id = 0, Author = "İsmail Çadır", Description = "DENEMe CORE APİ ", Title = "Sadece Deneme " },
            new Quote() { Id = 1, Author = "Fatih Çadır", Description = "DENEMe CORE APİ Fatih ", Title = "Sadece Deneme " },
        };

        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return _quotos;
        }

        [HttpPost]
        public void Post([FromBody]Quote qoute)
        {
            _quotos.Add(qoute);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Quote qoute)
        {
            _quotos[id] = qoute;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _quotos.RemoveAt(id);
        }
    }
}