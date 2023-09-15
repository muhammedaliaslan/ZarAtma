using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtma
{
    internal class Program
    {

        static void Main(string[] args)
        {
        baslangic:
            try
            {
                Console.WriteLine("Zar Atma Oyunu");
                Console.WriteLine("");



                int oyuncuBirZar = 0;
                int oyuncuIkiZar = 0;

                int oyuncuBirGuncelSkor = 0;
                int oyuncuIkiGuncelSkor = 0;

                while (oyuncuBirGuncelSkor < 10)
                {
                    Random rastgele = new Random();



                    Console.WriteLine("1.Oyuncu Güncel Skor : " + oyuncuBirGuncelSkor + " 2.Oyuncu Güncel Skor : " + oyuncuIkiGuncelSkor);
                    Console.WriteLine(" ");
                    Console.WriteLine("1.Oyuncu Zar Atmak İçin 1 Tuşuna Basın");
                    Console.WriteLine(" ");
                    //Console.WriteLine("2.Oyuncu Zar Atmak İçin 2 Tuşuna Basın");
                    //Console.WriteLine(" ");


                    int oyuncuBirKomut = 0;
                    int oyuncuIkiKomut = 0;

                    oyuncuBirKomut = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ---------------------------------------------------------");




                    if (oyuncuBirKomut == 1 || oyuncuIkiKomut == 2)
                    {

                        if (oyuncuBirKomut == 1)
                        {

                            oyuncuBirZar = rastgele.Next(1, 1);
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Gelen Sayı : " + oyuncuBirZar);
                            Console.WriteLine(" ");
                            oyuncuBirGuncelSkor = oyuncuBirGuncelSkor + oyuncuBirZar;

                            if (oyuncuBirZar == 1)
                            {
                                oyuncuBirGuncelSkor = 0;
                                Console.WriteLine("2.Oyuncu Zar Atmak İçin 2 Tuşuna Basın");
                                oyuncuIkiKomut = Convert.ToInt32(Console.ReadLine());
                                if (oyuncuIkiKomut == 2)
                                {
                                    oyuncuIkiZar = rastgele.Next(1, 7);
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Gelen Sayı : " + oyuncuIkiZar);
                                    Console.WriteLine(" ");
                                    oyuncuIkiGuncelSkor = oyuncuIkiGuncelSkor + oyuncuIkiZar;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Tuşlama");
                                }

                            }

                        }
                        else if (oyuncuIkiKomut == 2)
                        {
                            oyuncuIkiZar = rastgele.Next(1, 7);
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Gelen Sayı : " + oyuncuIkiZar);
                            Console.WriteLine(" ");
                            oyuncuIkiGuncelSkor = oyuncuIkiGuncelSkor + oyuncuIkiZar;

                            if (oyuncuIkiZar == 1)
                            {
                                oyuncuIkiGuncelSkor = 0;
                                Console.WriteLine("1.Oyuncu Zar Atmak İçin 1 Tuşuna Basın");
                                oyuncuBirKomut = Convert.ToInt32(Console.ReadLine());
                            }


                        }
                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Hatalı Tuşlama");
                    }
                }

                Console.WriteLine("1.Oyuncu Güncel Skor : " + oyuncuBirGuncelSkor + " 2.Oyuncu Güncel Skor : " + oyuncuIkiGuncelSkor);
                Console.WriteLine(" ");
                if (oyuncuBirGuncelSkor > 9)
                {
                    Console.WriteLine(" ---------------------------------------------------------");
                    Console.WriteLine("KAZANAN 1.OYUNCU !");
                }
                else
                {
                    Console.WriteLine(" ---------------------------------------------------------");
                    Console.WriteLine("KAZANAN 2.OYUNCU !");
                }
            }

            catch
            {
                Console.WriteLine("Hatalı Tuşlama");

                goto baslangic;
            }
            Console.ReadLine();




        }
    }
}
