using System;
using System.Collections.Generic;
using System.Text;

namespace DictonaryClass
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary yapısı içindeki bir keye bağlı olarak veri tutan bir sözlük olarak düşünebiliriz
           //Dictionary Çalışma Yapısı
           /*-----------------------------*/
            Dictionary<String, int> adYas = new Dictionary<string, int>();
            adYas.Add("sefa", 21);
            adYas.Add("ali", 22);
            adYas.Add("veli", 23);
            foreach(var degeroku in adYas)
            {
                Console.WriteLine(degeroku);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Kendi Çalışmamız
            /*-----------------------------*/
            MyDictonary<string, int> yasAd2 = new MyDictonary<string, int>();
            yasAd2.Add("sefa", 24);
            yasAd2.Add("ali", 25);
            string[] Key = new string[yasAd2.Length];
            int[] Value = new int[yasAd2.Length];
            int x = 0,y=0;

            foreach(var deger in yasAd2.Keys )   { Key[x]   =deger;   x++;}
            foreach (var deger2 in yasAd2.Values){ Value[y] =deger2;  y++;}
          
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("["+ Key[i] + "," + Value[i]+"]");
            }
        }
    }
}
