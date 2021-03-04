namespace OOP2
{
    class GercekMusteri : Musteri //inheritance yani miras. Nasıl okunur ? gerçek müşteride bir(:) müşteridir
                                  // Müşteride olan herşey GerçekMüşteride'de var olarak kabul edilir.
    {

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}
