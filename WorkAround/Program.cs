


using Business.Concrete;
using Entities.Concrete;

Vatandas vatandas = new Vatandas();

SelamVer("Mahmut");
SelamVer("Elif");
SelamVer("İrem");
SelamVer();


int sonuc = Topla(4,5);

//Diziler /Arrays

string ogrenci1 = "O1";
string ogrenci2 = "O2";
string ogrenci3 = "O3";

string[] ogrenciler = new string[3];
ogrenciler[0] = "Can";
ogrenciler[1] = "Mehmet";
ogrenciler[2] = "Ali";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = { "Bursa", "Corum", "Antalya" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";

Console.WriteLine(sehirler2[0]);

List<string> yeniSehirler1 = new List<string> { "Ankara","İstanbul","İzmir"};

Person person1 = new Person();
person1.FirstName = "MAHMUT CAN";
person1.LastName = "SARIBAL";
person1.DateOfBirthYear = 2000;
person1.NationalIdentity = 123;




foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);



static void SelamVer(string isim="İsimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1,int sayi2)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : "+sonuc);
    return sonuc;
}



//Degiskenler();

Console.ReadLine();
static void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000;
    int sayi = 100;

    bool girisYapmisMi = false;

    string isim = "Mahmut Can";
    string soyAd = "Saribal";
    int dogumYili = 2000;
    long tcNo = 12345678910;

    Console.WriteLine(tutar * 1.18);
}



public class Vatandas
{
    public string Ad { get; set; }
    public string SoyAd { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}

