using Abstracts.Mobilya;
using System;

namespace Abstracts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kanepe istikbal = new Kanepe();
            istikbal.bazalimi = true;
            istikbal.Renk= "beyaz";
            istikbal.kumasrengi = "tay tuyu";
            istikbal.OzellikleriYaz();
            Console.WriteLine("Hello World!");
        }
    }
}
