namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Müşteri Enes Bolat
            /*  Musteri_Önerilmeyen_Yöntem_ musteri1 = new Musteri_Önerilmeyen_Yöntem_();
                musteri1.Adi = "Enes";
                musteri1.Soyadi = "Bolat";      // Bu neden Yanlıştır ?
                musteri1.Id = 1;                //   Burada Gerçek müşteri ile Tüzel(şirket) müşterinin verileri karıştırılır ve veriler yanlış
                musteri1.TcNo = "2222222222";   //yerlere import edilir. Şirket adına Gerçek müşterinin adı, Müşteri adınada Şirket adı yazılabilir.
                musteri1.MusteriNo = "2222"; 
                musteri1.SirketAdi = "?";  */
            //Gerçek Müşteri - Tüzel Müşteri
            // Bu teknik SOLID prensiplerinin L harifini simgeler.

            GercekMusteri gercekmusteri1 = new GercekMusteri();
            gercekmusteri1.MusteriNo = "12345";
            gercekmusteri1.Id = 126465;
            gercekmusteri1.Adi = "Enes";
            gercekmusteri1.Soyadi = "Bolat";
            gercekmusteri1.TcNo = "12345678911";


            TuzelMusteri tuzelmusteri1 = new TuzelMusteri();
            tuzelmusteri1.MusteriNo = "54321";
            tuzelmusteri1.Id = 54321;
            tuzelmusteri1.SirketAdi = "Bolatlar Yıkama";
            tuzelmusteri1.VergiNo = "1554as2154dsa315";

            Musteri musteri3 = new GercekMusteri();  //  new görürsen şöyle oku ; Bellek referansı. Müsteri hem bellek hemde tüzel
            Musteri musteri4 = new TuzelMusteri();   //kişiyi bellekte tutabiliyor. Yukardaki şekillede tutabilir. 

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.ekle(tuzelmusteri1);
            musteriManager.ekle(gercekmusteri1);
            musteriManager.ekle(musteri4);
            musteriManager.ekle(musteri3);







        }
    }
}
