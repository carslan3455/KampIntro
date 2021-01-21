using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro // Calisacagimiz ozel bir type olacagini belirtiyoruz
{
    class MyList<T>   // T -> type
    {
        // string[] items;
        T[] items;
        //constructor  -- ctor 2 tab olusuyor  -- class ile ayni isimde olur
        //constructor -> bir class new lendiginde calisan method
        public MyList()
        {
            items = new T[0];
        }
        

        public void Add(T item)  //(string item) gibi tanimladik
        {
            T[] tempArray = items;    // tempArray - gecici array
            items = new T[items.Length+1];

            
            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i];   
               // tempArray icindeki elemanlari items geri vermek icin for dongusu yaptik
            }

            items[items.Length - 1] = item;

        }

        public int Length 
        {
            get { return items.Length; }
        }

        public T[] Items 
        {
            get { return items; }
        }
    }
}
