using System;

namespace CSharpDersleriEnginDemirog
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            //Yazım Tekniği 1
            personManager.ekle(new Students
            {
                OgrenciNo = 542,
                Ad = "Enes",
                Soyad = "Bolat",
                TCNo = "12345678910"
            });
            //Yazım Tekniği 2
            Students students = new Students
            {
                OgrenciNo = 542,
                Ad = "Fatih",
                Soyad = "Olay",
                TCNo = "8797987987"
            };
            personManager.ekle(students); //Her ikisinide yazdırır.

            Students student = new Students //IPerson'dan çekti aslında.
            {
                TCNo = "12345687",
                Ad = "Elif",
                Soyad = "Atay",
            };
            personManager.ekleinterface(student);
        }
    }
}
