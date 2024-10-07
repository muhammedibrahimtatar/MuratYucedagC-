using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz:");
            //string password;
            //password=Console.ReadLine();
            //if(password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //string capital, country;
            //Console.Write("Başkenti giriniz:");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi giriniz:");
            //country= Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi");
            //}


            //int number;
            //Console.Write("Sayıyı giriniz:");
            //number=int.Parse(Console.ReadLine());
            //if ( number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}


            //int exam1, exam2, exam3, average;
            //string result="Hata!";
            //Console.Write("Sınav 1:");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2:");
            //exam2 = int.Parse(Console.ReadLine());            
            //Console.Write("Sınav 3:");
            //exam3=int.Parse(Console.ReadLine());
            //average=(exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması:" + average);
            //if (average >0 & average<=50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average>50 & average <=70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average>70 & average <= 85)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average>85 & average <= 100)
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city=Console.ReadLine();
            //if (city == "adana" | city=="ankara" | city=="bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir listededir.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir listede yok");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin") 
            //{
            //    Console.WriteLine("Kullanıcı adı yanlış");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}

            #endregion

            #region Mod
            //İki sayının birbirine bölümünden kalanına Mod denir.

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine("Kalan deger: " +result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2=int.Parse(Console.ReadLine());
            //int result = number1%number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan değer:" + result);

            //Console.Write("Lütfen sayıyı giriniz:");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}







            #endregion

            #region Char ile Karar Yapıları

            //Klavyeden girilen değere göre takım yazdırmak
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' | team=='G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması



            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------");

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menüyü seçin: ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine("-------- Ana Yemekler ---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızarma Tabağı");
            //    Console.WriteLine("3-Fasülye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");

            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("-------- Çorbalar ---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine("-------- Pizzalar ---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Karışık Pizza");
            //    Console.WriteLine("2-Akdeniz Pizza");
            //    Console.WriteLine("3-Margarita Pizza");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine("-------- İçecekler ---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine("-------- Tatlılar ---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Baklava");

            //    Console.WriteLine();
            //}
            #endregion

            #region Switch-Case

            //Console.Write("Lütfen ay girişi yapınız:");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default:Console.WriteLine("Hatalı veri girişi");break;

            //}


            #endregion

            #region Switch Case Hesap Makinası

            int number1, number2, result;
            char symbol;
            Console.Write("1.Sayıyı giriniz:");
            number1=int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı giriniz:");
            number2=int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz:");
            symbol=char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result=number1 + number2;
                    Console.WriteLine("Toplam:" + result);
                    break;
                case '-':
                    result=number1 - number2;
                    Console.WriteLine("Çıkarma:" + result);
                    break;
                case '*':
                    result=number1 * number2;
                    Console.WriteLine("Çarpım:" + result);
                    break;
                case '/':
                    result=number1 / number2;
                    Console.WriteLine("Bölüm:" + result);
                    break;
                default:
                    Console.WriteLine("Hatalı Giriş");
                    break;
            }


            #endregion

            Console.Read();
        }
    }
}
