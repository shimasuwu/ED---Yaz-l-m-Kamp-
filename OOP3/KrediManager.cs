using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP3
{
    internal interface IKrediManager //diger classlarda kullanilacak olan metotlari sablon olarak bu inferface'de belirliyoruz.
    {
        void Calculate();
        void DoSth();
    }
}
