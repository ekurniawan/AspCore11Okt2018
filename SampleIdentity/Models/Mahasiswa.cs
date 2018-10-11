using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleIdentity.Models
{
    public class Mahasiswa
    {
        [Key]
        public string Nim { get; set; }
        public string Nama { get; set; }
        public double IPK { get; set; }
    }
}
