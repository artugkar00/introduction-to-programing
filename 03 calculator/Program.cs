using System;

namespace _03_calculator
{
    class Program
    {
       public struct islem
       {
           public byte s1,s2;
           public float tpl;
           public string operant;
       }
        static void Main(string[] args)
        {
             islem deneme = new islem();
             Console.WriteLine("Birinci Sayıyı Giriniz: ");
             deneme.s1 = Convert.ToByte(Console.ReadLine());
             Console.WriteLine("İkinci Sayıyı Giriniz: ");
              deneme.s2 = Convert.ToByte(Console.ReadLine());
             Console.WriteLine("İşlem Türünü Seçiniz (+),(-),(*),(/)");
             deneme.operant = Console.ReadLine();
             if(deneme.operant=="+")
            {
             deneme.tpl = deneme.s1 + deneme.s2;
            }   
             if(deneme.operant=="-")
            {
             deneme.tpl = deneme.s1 - deneme.s2;
            }
             if(deneme.operant=="*")
            {
             deneme.tpl = deneme.s1 * deneme.s2;
            }
             if(deneme.operant=="/")
            {
             deneme.tpl = deneme.s1 / deneme.s2;
            }
             Console.WriteLine(deneme.tpl);
             Console.ReadKey();
            }
        }
    }
