using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // MyList isimler = new MyList();
            // Class type turu verilerek kullanilacagi icin type vererek calistik

            MyList<string> isimler = new MyList<string>();

            isimler.Add("Es");

            Console.WriteLine(isimler.Length);

            isimler.Add("Oz");

            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items) {

                Console.WriteLine(isim);
            }


        }
    }
}
