using SampleIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleIdentity.Services
{
    public interface IMahasiswaService
    {
        IEnumerable<Mahasiswa> GetAll();
    }
}
