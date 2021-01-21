using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro // Calisacagimiz ozel bir type olacagini belirtiyoruz
{
    class MyList<T>   // T -> type
    {
        // string[] items;
        T[] items;
        //constructor  -- ctor 2 tab olusuyor
        //constructor -> bir class new lendiginde calisan method
        public MyList()
        {
            items = new T[0];
        }
        

        public void Add(T item)  //(string item) gibi tanimladik
        {
            T[] tempArray = items;    // tempArray - gecici array
            items = new T[items.Length+1];
        }
    }
}
