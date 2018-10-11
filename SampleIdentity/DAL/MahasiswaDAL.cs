using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleIdentity.Data;
using SampleIdentity.Models;

namespace SampleIdentity.DAL
{
    public class MahasiswaDAL : IMahasiswa
    {
        private ApplicationDbContext _db;
        public MahasiswaDAL(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Create(Mahasiswa mhs)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Mahasiswa> GetAll()
        {
            var results = _db.Mahasiswa.OrderBy(m => m.Nama);
            return results;
        }

        public Mahasiswa GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
