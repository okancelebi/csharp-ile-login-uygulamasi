using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ile_login_uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //Kullanıcı giriş sayfası uygulaması yapacağız.
                //Kullanıcı adı ve şifresini doğru girerse, Tebrikler başarılı bir şekilde giriş yaptınız.
                //Yanlış girerse hata verelim ve 3 hak tanımlayalım. Kullanıcı yanlış girdiği sürece döngü devam etsin.
                int hak_sayisi = 3;
                while (true)
                {
                    Console.WriteLine("Kullanıcı adınızı giriniz :");
                    string kullanıcı_adi = Console.ReadLine();
                    Console.WriteLine("Lütfen şifrenizi giriniz.");
                    string sifre = Console.ReadLine();
                    if (kullanıcı_adi == "okan" && sifre == "123")
                    {
                        Console.WriteLine("Tebrikler, başarılı şekilde giriş yaptınız.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı adınızı veya şifrenizi yanlış girdiniz, lütfen tekrar deneyiniz.");
                        if (hak_sayisi > 0)
                        {
                            hak_sayisi -= 1;
                        }
                        if (hak_sayisi == 0)
                        {
                            Console.WriteLine("Hak sayınız dolmuştur. Daha giriş yapamazsınız.");
                            break;
                        }
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
