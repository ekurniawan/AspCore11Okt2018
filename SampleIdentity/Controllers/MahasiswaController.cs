using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleIdentity.DAL;
using SampleIdentity.Models;

namespace SampleIdentity.Controllers
{
    //jwt http://jasonwatmore.com/post/2018/08/14/aspnet-core-21-jwt-authentication-tutorial-with-example-api

    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private IMahasiswa _mhs;
        public MahasiswaController(IMahasiswa mhs)
        {
            _mhs = mhs;
        }
        // GET: api/Mahasiswa
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return _mhs.GetAll();
        }

        // GET: api/Mahasiswa/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Mahasiswa
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Mahasiswa/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
