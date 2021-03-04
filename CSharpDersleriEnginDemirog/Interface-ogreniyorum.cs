using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDersleriEnginDemirog
{
    interface IPerson
    {
        string TCNo { get; set; }
        string Ad { get; set; }
        string Soyad { get; set; }
    }
    class Students : IPerson
    {
        public string TCNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int OgrenciNo { get; set; }

    }
    class Teachers : IPerson
    {
        public string TCNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public String IlgiliBolumu { get; set; }

    }
    class PersonManager
    {
        public void ekle(Students students)  // Öğrenci bilgilerini buradan yazabilirsin ama orta bilgileri her ikisindede yazdırmak istiyorsan Alttakini yap.
        {
            Console.WriteLine(students.Ad);
            Console.WriteLine(students.Soyad);
            Console.WriteLine(students.TCNo);
            Console.WriteLine(students.OgrenciNo);
            Console.WriteLine("**************************");
        }
        public void ekleinterface(IPerson person)  // İnterface sadece ortak değerleri yazar. Unutma :D
        {
            Console.WriteLine(person.Ad);
            Console.WriteLine(person.Soyad);
            Console.WriteLine(person.TCNo);
            // Console.WriteLine(person.OgrenciNo);   // Kızardı, peki neden? İnterface sadece kendi içerisindeki değeri yollar. İç değerler için üsttekini yap.
            Console.WriteLine("**************************");
        }
    }

}


