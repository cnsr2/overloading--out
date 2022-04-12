using System;

namespace overloading__out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen integer'a dönüştürmek istediğiniz şeyi giriniz");
            bool sonuc = int.TryParse(Console.ReadLine(), out int read);
            if (sonuc)
            {
                Console.Write("başarılı!, değeriniz:"+ " " + read);
                
            }
            else 
                Console.WriteLine("başarısız");
        
            }

        }
    }