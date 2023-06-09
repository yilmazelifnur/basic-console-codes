
Elifnur Yılmaz<yilmazelifnur979@gmail.com>
25 Şubat Cmt 08:24
Alıcı: Hikmet

 /*temelde 3 veri vardır. sitring sözel veri
             * mat verisi
             * mantık verisi ( dogru veya yanlıs ) */

/* string sözel ifadelerde kullandıgımız komut
 * matematik islemleri icin kullandıgımızkomut ise int
 double noktalı sayı deisken türü */

            string adaminAdi = "elif";
string adaminSoyadi = "sahin";

Console.WriteLine(adaminAdi);
Console.WriteLine(adaminSoyadi);
// console.writeline = ekranda göster demek//

adaminAdi = adaminSoyadi;
Console.WriteLine(adaminAdi);
string adiSoyadi = adaminAdi + " " + adaminSoyadi;
Console.WriteLine(adiSoyadi);
//burada iki kelimeyi yanyana getiriyor. " " ise boşluk olusmasını saglıyor//

string sayi1 = "1";
string sayi2 = "2";
string toplamSayi = sayi1 + sayi2;
Console.WriteLine(toplamSayi);

int say1 = 1;
int say2 = 2;
int toplamsay = say1 + say2;
Console.WriteLine(toplamsay);
Console.ReadLine();

Console.WriteLine("Dik Kenar Giriniz");
// üstteki kod yazı yazdırmak için ekranda yazıyı görebilmek için yazıyoruz

string GirilenDeger = Console.ReadLine();
// ekrandan yanıt almak için readline kodunu kullanıyoruz
double Dikkenar = Convert.ToDouble(GirilenDeger);
// ondalıklı sayı olması halinde double kullanıyoruz
// convert dönüştür demek neye dönüşmesini istiyorsak
// burdaki en önemli nokta string ifadesini matematiksel veriye dönüştürmek


Console.WriteLine("Yukseklik Giriniz");
GirilenDeger = Console.ReadLine();
double yükseklik = Convert.ToDouble(GirilenDeger);

double sonuc = (Dikkenar * yükseklik) / 2;
Console.WriteLine(sonuc);
Console.ReadLine();

//değişken türleri //

int yas =
Console.WriteLine(yas);
/* bu derleme calısmaz hata verir. çünkü atama yapılmak zorunda.
 * Definite Assignment Rule olarak adlandırılıyor.*/

long indirimtutarı = //tanım
indirimtutarı = 75 * 250 / 2; //işlem
/* aritmetik işleçleri 4 işlem yüzde hesaplama yapılacagı zaman kullanılır. bundan dolayı
 * işlec olarak adlandırılmıstır.
 * long console komutu ise 64 bit e kadar olan sayıları barındırır.
 * long,double,int,float,byte,sbyte vb. matematiksel veri işleçleri dersen
 * interneten rahat bulursun. */

int[] sayilar = { 10, -3, 5, 0, 33, -2, -60, 0, -20, -10 };
int sifirSay = 0, pozitifSay = 0, negatifSay = 0;
for (int x = 0; x < sayilar.Count(); x++) ;
/* yukarıdaki kod COUNT örneğidir. cok yaygın kullanılan bir kod. sayıyı  arttırmak için
 * ++ sayıyı  arttırmak için
 * - ise sayıyı bir azaltmak için kullanılır.
 * onek ve sonek vardır. bunlar ıslevden önce veya sonra icindir.
 * onek(prefix) oncesi , sonek(postfix) ise sonrası için */

string a = "viki", b = "pedia";
Console.WriteLine(a + b);
/* string olarak ifade edilen sözdizimlerini yanyana getirir. */

string a;
a = Console.ReadLine();
Console.WriteLine(a + "metnini yazdınız");
/* bu kodda yazıyı karsıya bırakıyoruz. ekran acıldıgın a değiskeni
 * metin istiyoruz. metin yazılıp enter a basılınca metin+bizim kodda belirdeğimiz
 * yazı sonuna eklenip konsola yansıyor. */


const int a = 5;
/* const anahtar sözcüğü sabit değişken tanımlarken kullanırız.
 * pi , planck sabiti gibi.
 * sabit değişkeni değiştirmeye calısmamalıyız. derleyeci hata verebilir.
 * değeri aynı satırda atamalıyız yoksa hata verir.*/

const int a = 750 * 25 / 2;
/*işlemlerde sabitlenebilir.  
int a = 5; const int b = a + 8; bu hatalı bir koddur.*/

int b = 100; // Sizce ne olur?
byte i = (byte)b;
Console.WriteLine(i);
Console.ReadLine();
/* iki tür arasında değişimyapmak istediğimizde yukardaki gibi
 * convert komutu da yazılabilir ya da hedef türü parantez içine yazıp da
 * değiştirebiliriz.
 * önce int değeri tanımlanmıs daha sonra byte türüne i diye isimlendirilip  b tanımının
 türünü  int ten byte dönüştürülmüş.
bu tür dönüşümlerde veri kaybı olmaması için tür boyutuna ayrıca dikkat edilmesi gerekmektedir.*/


int x = 250;
int y = 150;
byte z, t;

checked
{
    z = (byte)x;
}
unchecked
{

    t = (byte)y;
}
Console.WriteLine(t);
/* dönüştürülen deger matematikselveri içinde boyut farkı var ise derleyici hata verecektir
 * veri kaybı yasanacaktır. bu durumda 2 şeye dikkat edilir. veri kaybı kontrol edilmeli mi yoksa edilmemeli mi ?
 * bunun için checked ve unchecked komutları kullanılır.
 * komut baslangıcı  ve bitisi  {} ile yapılır.
 * z de kontrol edilmiş fakat t de kontrol edilmemiş ve edilmesine gerek yoktur anlamı tasır. */

bool dogru = true;
bool yanlis = false;
int a = 10;

bool sonuc = a > 25;

Console.WriteLine(dogru);
Console.WriteLine(yanlis);
Console.WriteLine(sonuc);
/* boolean verisi diğer adı ile Mantık Verisi bize sadece dogru veya yanlıs sonucunu verir. bunun icin bool isim yazıyoruz dogru yahut yanlıs degiskenini atıyoruz.
 * bir sayı degeri giriyoruz illa sayı olmasına gerke yok herhangi string int double vs değeri girebiliriz. sonra kosul ekliyoruz. bunun için dönüştürücü ifadelerini
 * kullanıyoruz. en son ekranda göstermek için hepsine console.writeline komutu atıyoruz (komutan içine isimi yazıyoruz) */

/*   Boolean kullanım örneği
Boolean değerleri, aşağıda tartışıldığı gibi koşullu testlerde ve çok daha fazlasında kullanılır.

E - posta adresinin geçerli olup olmadığını kontrol eder.
Parolanın en az 6 karakter uzunluğunda olup olmadığını kontrol eder.
Her iki alanın da doğru doldurulup doldurulmadığını kontrol eder.*/

string a = "hello world";
int uzunlugu = a.Length;
// yazdıgım söz diziminde kaç harf var onu söylüyor
Console.WriteLine(uzunlugu);




string degiskenadi = "hello world i am learning develop";
string[] kelimeler = degiskenadi.Split(',');
// birleştirilmiş programları birbirinden ayırmak için kullanılır.
Console.WriteLine(degiskenadi[3]);
Console.WriteLine(kelimeler.Length);
Console.WriteLine(degiskenadi[2]);
Console.ReadLine();




string isim, soyisim;
Console.WriteLine("İsim Giriniz.");
isim = Console.ReadLine();
Console.WriteLine("Soyisim Giriniz");
soyisim = Console.ReadLine();


Console.WriteLine(isim + " " + soyisim);
Console.ReadLine();
/*
 * string ifadeler arasında boşluğu farklı yöntemlerle kullanabiliriz.
 * ya bir değişken atarız bunun içine /n koyarız ya da writelien bölmesine içi boş tırnak ifadesi
 * koyarız
 */


bool kontrol = true;
bool kontrol2 = false;

bool sonuc = 10 > 5;
Console.WriteLine(sonuc);
Console.ReadLine()
                /*
                 * en basit bool verisidir. bool sorusunun cevabı iki ihtimal olan verilerde kullanılır. sorunun cevabı ya true ya da falsetur
                 * bool verisiin içine herhangi başka bir değer atanamaz.(string,int,sbyte) gibi.
                 * ekranda yine sonuc göstermek için console.writeline yazılır.
                 */



                double mod = 19.5 % 4.5;
Console.WriteLine(mod);

int sayi = 5;
sayi = sayi + 1;

sayi++;
Console.WriteLine(sayi);
Console.ReadLine();

/*
 * Burada ise olay girilen sayi değerini 1 aarttırmak veya azaltmaktır. 2 farklı şekilde yapabiliriz.
 * 1. sayi değişkenine değer tanımladıktan sonra toplama işlemi yaptırırız
 * 2. adım ise sayiya ++ emiri girerek sadece 1 arttırmasını sağlayabiliriz.
 */

bool bl = true;
bl = 10 == 20;
Console.Write(bl);
Console.ReadLine();



bool fb = true;
fb = 12 >= 15;
Console.WriteLine(fb);

/*
 * bool verisine değişten türü ataması kıyaslama yaptırabiliyoruz.
 */


bool bl = true;
bl = 10 != 4 && 5 == 5;
Console.WriteLine(bl);
Console.ReadLine();

/*
 * burada iki farklı kontrol sağlanmasını ve tek sonuc cıkartmasını istedik.
 * burada != eşit değildir anlamındadır.
 * && ve anlamında kullanılır. biri bile yanlıssa sonuc uanlıs cıkacaktır.
 */

bool bl;
string otogeldi;
Console.WriteLine("otobüs geldi mi?");

string kull = Console.ReadLine();
bl = "geldi" == kull;
bl = true;

Console.WriteLine(bl);
Console.ReadLine();


/*
 * öncelikle bu veri tipinde bool kullanacagımı basında belli ediyorum.
 * string ifade için kullanıcaz bu sefer o yuzden bu verinin string olacagını söylüyorum ve sorumu yazıyorum.
 * ekranda gözükmesi içinde sorumu console.writelien oalrak belirliyorum.
 * kullanıcı string değer gireceği için cevabımı string değerinden alması gerektiğibi söylüyorum.
 * sonra girdiği değer ile true olan değeri karsılastıroyorum.
 * sonucu da ekranda göstermesi komutu giriyorum.
 * */

if (bl)
{
    bl = true;
    Console.WriteLine("damak tadınız iyiymiş!");
    Console.ReadLine();

}
else
{

    Console.WriteLine("çomar");
    Console.ReadLine();

}

/* devamına if else ekleyebiliriz. mesela bu örnekte şunu dedik eğer sonuc doğru ise
 * ekranda xxx yazısı yazsın . devamındaki else komutu ise değilse anlamı taşıdığından
 * olmama durumunda ne yapılması gerektiğini beyan ediyor.
 */


int ögrencinotu;
Console.WriteLine("öğrenci notunu giriniz");
ögrencinotu = Convert.ToInt16(Console.ReadLine());

if (75 > ögrencinotu)
{
    Console.WriteLine("öğrencinin başarı durumu ortalama üzerinde");
    Console.ReadLine();


}
if (50 > ögrencinotu)
{

    Console.WriteLine("öğrencinin başarı durumu ortalama altında.");
    Console.ReadLine();


}
if (10 > ögrencinotu)
{
    Console.WriteLine("bok gibi öğrenci");
    Console.ReadLine();
}

/*
 * öğrenci notuna göre karsımıza veri cıkartsın istedik fakat bu veride fazladans ecenek durumu var.
 * taban paunı75 olarak belirledik. ve bu 75 i 3 farklı basarı durumuna böldük
 * hepsinde if kullandık. sınırsız sayıda if emiri verebiliriz.
 *
 */

Console.WriteLine("ekrana sayı giriniz.");
int sayi1 = Convert.ToInt16(Console.ReadLine());

int sonuc = sayi1 % 2;



if (sayi1 % 2 == 0)
{

    Console.WriteLine("çift sayı");
    Console.ReadLine();

}
else
{

    Console.WriteLine("tek sayı");
    Console.ReadLine();

}
/*
 * burada girilen saynın tek mi çift olduğunu söylemek için yazıldı.
 * % kullanıldı cunku kalan sayının degeri üzerinden işlem yapılması gerekiyordu
 * dedik ki eger kalan 0 ise ekrana cift sayı yaz.
 * kalan 0 dan farklı ise tek sayı yaz dedik ve ekranda gösterdik.
 * */


Console.WriteLine("ekrana sayıyı giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());

if (sayi1 % 2 == 0 && sayi1 % 3 == 0)
{
    Console.WriteLine("OKAYYYYY ");
    Console.ReadLine();

}
else
{
    Console.WriteLine("hata");
    Console.ReadLine();

}

/*
 * baska bir if else console örneği burada ise if emrine 2 farklı şart girildi.
 * ikisini de karsılıyorsa true karsılamıyorsa false için acıklamalar girdik.
 *
 */

Console.WriteLine("ekrana bir sayı giriniz");
int sayi1 = Convert.ToInt16(Console.ReadLine());


if (sayi1 % 2 == 0 && sayi1 % 3 == 0)
{

    Console.WriteLine("sayı hem 2 hem 3 e bölünür.");
    Console.ReadLine();



}

if (sayi1 % 2 == 0 && sayi1 % 3 != 0)
{
    Console.WriteLine("sayı sadece 2ye bölünüyor");
    Console.ReadLine();


}

if (sayi1 % 3 == 0 && sayi1 % 2 != 0)
{
    Console.WriteLine("sadece 3e bölünüyor");
    Console.ReadLine();

}
/*
 *
 * burada 3 farklı output istedik 3 farklı if komutu girdik.
 *  you go giiiiiirllll
 */


if (sayi1 % 3 == 0 && sayi1 % 2 != 0)
{
    Console.WriteLine("sadece 3e bölünüyor");
    Console.ReadLine();

}

Console.WriteLine("ekrana sayı giriniz.");
int say1 = Convert.ToInt16(Console.ReadLine());

if (say1 % 4 == 0)
{
    Console.WriteLine("sayı uygun");
    Console.ReadLine();


}
if (say1 % 5 == 0)
{
    Console.WriteLine("sayı uygun");
    Console.ReadLine();

}
if (say1 % 6 == 0)
{
    Console.WriteLine("sayı uygun");
    Console.ReadLine();
}

if (say1 % 4 != 0 && say1 % 5 != 0 && say1 % 6 != 0)
{

    Console.WriteLine("sayı uygun değil");
    Console.ReadLine();
}

/*burada ise dedik ki 4 5 6 bölünyorsa uygun 1 tanesine bile bölünmüyorsa uygun değil yaz. */


int bakiye = 1000;
int tutar;

Console.WriteLine("islmeler" + " " + "para cekme");
Console.WriteLine("islemler için 1'e basınız");
Console.WriteLine("para cekmek icin 2'ye basınız");
Console.WriteLine("bakiye sorgulamak için 3'e basınız");
int islem = Convert.ToInt32(Console.ReadLine());



switch (islem)
{
    case 1: Console.WriteLine("işlemler : 2 para cekmek 3 bakiye sorgulamak "); break;
    case 2: Console.WriteLine("para çekme "); break;
    case 3: Console.WriteLine(bakiye); break;
    case 4: Console.WriteLine(" böyle bir işlem yok"); break;
}

/* bu bizim ilk swich-case örneğimiz burada direkt tuş atama yapıyoruz tercihi kullanıcya bırakıyorum.
 * olası durumlar göz önnde if else göre bulunuyor.
 * her caseden sonra mutlaka  ; break ; yazmalıyız.
 * en sona bu örnekte yer almıyor fakat ihtimallerin hiçbiri olmazsa eğer default bir sonuc yazılması gerkeiyor.
 */

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
    Console.ReadLine();

}
/* for döngülerinde fordan sonraparantezin içine;
 * eger int türünde işlem yapılacaksa
 * 1 değişken atarız ;
 * 2 koşul belirleriz ;
 * değişim varsa yazarız
 */

string[] isimler = { "elif", "hikmet", "paşa", "saye" };
Console.WriteLine(isimler[0]);
Console.ReadLine();
/*
 * array aslında bir dizidemek. bir küme içerisine  eleman alınıyor bu eleman kümesine bir isim veriliyor.
 * kmede toplam kac eleman oldugunu yine köseli parantez içine yazdıgımı sayı ile ifade ediyoruz.
 * string double ya da char tanımı yapbilir
 */

int a = 1;
do
{
    Console.WriteLine(a);
    a++;
}
while (a <= 10);

Console.ReadLine();

/* burada do-while döngüsü bulunmaktadır. bu döngü önce işlem sonra kosul demektir.
 * imlec gelir yukardan asagı tek tek işlemleri yapar en son sartı saglayanları ekrana gönderir
 * sartı saglamayanları göndermez. while döngüsü ile arasındakı fark budur. */

int[] sayılar = { 1, 2, 3 };
Console.WriteLine(sayılar[0]);
Console.WriteLine(sayılar.Length - 1);
Console.ReadLine();
int x = sayılar.Length - 1; (uzun yoldan)

            int[] sayılar = { 1, 2, 3, 40 };
Console.WriteLine(sayılar[0]);
Console.WriteLine(sayılar[sayılar.Length - 1]);
//eleman sayısından 1 önceki sayıyı yazar
int y = 40;
int index = Array.IndexOf(sayılar, y);
Console.WriteLine(index);
// index yazdıgımız elemanıgit dizide bul kacıncı eleman oldugunu yaz
Console.WriteLine(sayılar[index]);
Console.ReadLine();



Console.WriteLine("Adın ne ?");
string ad = Console.ReadLine();
Console.WriteLine("yaşın kaç?");
int yas = Convert.ToInt32(Console.ReadLine());
if (yas >= 18)
{
    Console.WriteLine($" {ad} : kahveye hosgeldiniz");

}
else
{
    int kalan = 18 - yas;
    Console.WriteLine($"{ad} kahveye giremen guzum daha {18 - yas} yılın var");
}

// dolar işareti + yerine geçiyor bu sefer değişkenleri süslü parantez içinde yazıyoruz.
// aynı zamanda int değerinden hesabıda yine süslü parantez içinden yapıyor.