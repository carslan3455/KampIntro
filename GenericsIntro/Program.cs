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

            isimler.Add("Esma");




        }
    }
}
