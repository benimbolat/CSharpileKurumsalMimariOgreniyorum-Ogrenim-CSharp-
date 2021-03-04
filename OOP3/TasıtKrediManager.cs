using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasıtKrediManager : IKrediManager  //Alttaki satırı kızınca ampulden ekledim.
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }
    }
}
