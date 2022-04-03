using System;
using System.IO;

namespace _01_DosyaOkumaYazma
{
    class Program
    {
        static void Main(string[] args)
        {
            
            File.WriteAllText(@"C:\Users\iyazici\Desktop\New folder\asd1.json", "ilk dosya işlemim v1");          



            Console.WriteLine("Hello World!");

            string dosyadanOkunanDeger = File.ReadAllText(@"C:\Users\iyazici\Desktop\New folder\asd2.txt");
            Console.WriteLine(dosyadanOkunanDeger);
        }

        
    }
}
