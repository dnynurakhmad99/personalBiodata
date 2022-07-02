using System;

namespace UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|                       Biodata Lengkap                      |");
            Console.WriteLine("|------------------------------------------------------------|");
            Biodata biodata = new Biodata(new BiodataLengkap());
            biodata.isiData();
        }
    }

    class BiodataLengkap
    {
        public void namaLengkap(string message)
        {
            Console.WriteLine(message);
        }

        public void ttLahir(string message)
        {
            Console.WriteLine(message);
        }

        public void alamatRumah(string message)
        {
            Console.WriteLine(message);
        }

        public void namaKampus()
        {
            Console.WriteLine(" + Kampus               : Universitas Amikom Yogyakarta");
        }

        public void namaProdi()
        {
            Console.WriteLine(" + Prodi                : BC-Informatics");
        }

        public void nomorInduk()
        {
            Console.WriteLine(" + NIM                  : 19.61.0158");
        }
    }
}
