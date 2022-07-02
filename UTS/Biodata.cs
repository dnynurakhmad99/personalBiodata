using System;
using System.Threading;

namespace UTS
{
    class Biodata
    {
        private BiodataLengkap lengkap;
        public Biodata(BiodataLengkap lengkap)
        {
            this.lengkap = lengkap;
        }

        public void isiData()
        {
            Thread t1 = new Thread(dataUmum);
            Thread t2 = new Thread(dataKampus);
            t1.Start();
            t2.Start();
        }

        private void dataUmum()
        {
            this.lengkap.namaLengkap(" + Nama Lengkap         : Danny Nurakhmad");
            this.lengkap.ttLahir(" + Tempat Tanggal Lahir : Yogyakarta, 25 Oktober 1999");
            this.lengkap.alamatRumah(" + Alamat Rumah         : Demblaksari, RT. 05, Baturetno,\n" + 
                "                          Banguntapan, Bantul, D.I Yogyakarta");
        }

        private void dataKampus()
        {
            this.lengkap.namaKampus();
            this.lengkap.namaProdi();
            this.lengkap.nomorInduk();
        }
    }
}
