namespace OOP2
{
    class Musteri
    {
        //public int Id { get; set; }
        //public string MusteriNo { get; set; } // NOT: Eğer bir nesnede bir değeri kullanmak zorunda gibi görüyorsan demekki orada soyutlama hatası yapıyorsun.
        //public string Adi { get; set; }
        //public string Soyadi { get; set; }
        //public string SirketAdi { get; set; }
        //public string TcNo { get; set; }   //Neden String değer kullandım ? İşlem yapmayacağım için İnt, bool... yerine String kullanmam diller arası tutarlılığı artıracaktır.
        //public string VergiNo { get; set; }


        //*********** ÖNERİLEN YÖNTEM ************************************* 
        //inferitance'a miras bırakılacaklar. 
        public int Id { get; set; }
        public string MusteriNo { get; set; }


    }
}
