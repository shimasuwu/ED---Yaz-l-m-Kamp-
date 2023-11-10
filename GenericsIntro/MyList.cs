using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T> // <> isareti  bir class'i liste haline donusturur. T = tip'i ifade  eder. disarida icerisine alacagi tip ne olursa(int, string, vs.) listenin tipi de o olur.
    {
        T[] items;
        public MyList() //main'de MyList class'i instancelandiginda calisacak olan metot.
        {
            items = new T[0];
        }
        public void Add(T item) //listenin turu main metodunda ne olarak belirlenirse, parametrenin icerisine  alacagi degerlerin  turunun de o olmasi icin "item" isimli degiskenin turu "T" olarak belirlendi.
        {
            T[] tempArray = items; //dizi sayisi artip, ref degeri deismeden once items'in icindeki degerler geceici diziye atanir.
            items = new T[items.Length + 1]; //metot her calistiginda dizi sayisi 1 artacak ve icindeki degerler sifirlanip, ref degeri degisecek.
           
            //tempArray'de tutulan degerler yeni olusturulan items dizisine geri aktarilacak.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }
}
