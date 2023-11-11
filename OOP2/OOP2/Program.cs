using OOP2;

GercekMusteri m1 = new GercekMusteri();
m1.MusteriNo = "1";
m1.Adi = "chirs";
m1.Soyadi = "bumstead";
m1.TcNo = "1111111111";

TuzelMusteri m2 = new TuzelMusteri();
m2.MusteriNo = "123123";
m2.Id = 2;
m2.SirketAdi = "olympia";
m2.VergiNo = "4444";

Musteri m3 = new GercekMusteri();
Musteri m4 = new TuzelMusteri();

MusteriManager mm = new MusteriManager();
mm.Add(m1); //m1(GercekMusteri) Musteri class'indan inherit aldigi icin mm.Add() metodunun parametresine arguman olarak girilebiliyor.