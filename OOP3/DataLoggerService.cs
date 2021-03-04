using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DataLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanı loglandı.");
        }
    }
}
