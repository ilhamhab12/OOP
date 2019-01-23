using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class Segitiga : Banggun2D
    {
        private double alas;
        private double tinggi;

        public Segitiga(double a, double t)
        {
            this.alas = a;
            this.tinggi = t;
        }

        public override double HitungLuas()
        {
            return (alas * tinggi /2);
        }
    }
}
