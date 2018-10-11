using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleIdentity.Models
{
    public class Pengambilan
    {
        public int PengambilanID { get; set; }
        public string Nim { get; set; }
        public string MatakuliahID { get; set; }
        public string Nilai { get; set; }

        public Mahasiswa Mahasiswa { get; set; }
        public Matakuliah Matakuliah { get; set; }
    }
}
