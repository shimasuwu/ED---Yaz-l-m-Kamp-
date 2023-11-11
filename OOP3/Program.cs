using OOP3;
using System.Collections.Generic;

//interfaceler'de kendisini implament eden classin ref degerini tutabiliyor.
IKrediManager ikm = new IhtiyacKrediManager(); 
IKrediManager tkm = new TasitKrediManager();
IKrediManager kkm =  new KonutKrediManager();

BasvuruManager bm = new BasvuruManager();
ILoggerService fileLoggerService = new FileLoggerService();

bm.BasvuruYap(tkm, new DatabaseLoggerService());


List<IKrediManager> krediler = new List<IKrediManager>() {tkm,ikm};

//bm.KrediOnBilgilendirmesiYap(krediler);