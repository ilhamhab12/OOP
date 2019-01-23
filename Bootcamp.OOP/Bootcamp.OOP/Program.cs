using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Banggun2D panggil;
            Console.WriteLine("=============Perhitungan Luas===============");
            Console.WriteLine("1. Lingkaran");
            Console.WriteLine("2. Segitiga");
            Console.WriteLine("3. Persegi");
            Console.WriteLine("4. Persegi Panjang");
            Console.WriteLine("============================================");
            Console.Write("Your Choice = ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("============================================");
                    Console.WriteLine("Menghitung Luas Lingkaran");
                    Console.Write("Masukkan nilai jari-jari = ");
                    double jari = Convert.ToDouble(Console.ReadLine());
                    panggil = new Lingkaran(jari);
                    panggil.CetakLuas("Lingkaran");
                    /*
                    double phi = 3.14;
                    double luaslingkaran = phi * (jari*jari);
                    Console.WriteLine("Luas : " + luaslingkaran);
                    */
                    Console.Read();
                    break;
                case 2:
                    Console.WriteLine("============================================");
                    Console.WriteLine("Menghitung Luas Segitiga");
                    Console.Write("Masukkan nilai alas = ");
                    double alas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan nilai tinggi = ");
                    double tinggi = Convert.ToDouble(Console.ReadLine());
                    panggil = new Segitiga(alas, tinggi);
                    panggil.CetakLuas("Segitiga");
                    /*
                    double luas = alas * tinggi / 2;
                    Console.WriteLine("Luas : " + luas);
                    */
                    Console.Read();
                    break;
                case 3:
                    Console.WriteLine("============================================");
                    Console.WriteLine("Menghitung Luas Persegi");
                    Console.Write("Masukkan nilai sisi = ");
                    double sisi = Convert.ToDouble(Console.ReadLine());
                    panggil = new Persegi(sisi);
                    panggil.CetakLuas("Persegi");
                    /*
                    double luasp = sisi * sisi ;
                    Console.WriteLine("Luas : " + luasp);
                    */
                    Console.Read();
                    break;
                case 4:
                    Console.WriteLine("============================================");
                    Console.WriteLine("Menghitung Luas Persegi Panjang");
                    Console.Write("Masukkan nilai panjang = ");
                    double panjang = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan nilai tinggi = ");
                    double lebar = Convert.ToDouble(Console.ReadLine());
                    panggil = new Persegi_Panjang(panjang, lebar);
                    panggil.CetakLuas("Persegi_Panjang");
                    /*
                    double luaspp = panjangp * tinggipp;
                    Console.WriteLine("Luas : " + luaspp);
                    */
                    Console.Read();
                    break;
                default:
                    Console.Write("Your choice is not found, try again");
                    Console.Read();
                    break;
            }
            Console.WriteLine("============================================");
            Console.ReadLine();
        }
    }
}
