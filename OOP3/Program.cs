using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            //tasıtKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); // veya IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); 
            //ihtiyacKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager);
        }
    }
}
