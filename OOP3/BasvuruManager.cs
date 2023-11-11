using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager Ikm, ILoggerService logger) 
        {
            //Basvuran bilgilerini degerlendirme
            //
            Ikm.Calculate();
            logger.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //hespalanacak olan deger miktari belirsiz oldugu icin gelen argumanlar liste olarak tutulacak.
        {
            foreach (var item in krediler)
            {
                item.Calculate();
            }
        }
    }
}
