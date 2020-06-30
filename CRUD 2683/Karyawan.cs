using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_2683
{
    abstract class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }

        public abstract double Gaji();
    }
}