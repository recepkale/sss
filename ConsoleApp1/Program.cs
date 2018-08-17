//15253054
//Bora Sezgin

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaplubagaTavsan
{
    class Test
    {
        static void Main(string[] args)
        {


           
            Random rNesne = new Random();
            int count_tavsan = 0;
            int count_kaplumbaga = 0;
            int yaris_sonu = 1;
            int ran = rNesne.Next(10) + 1;
            Console.Write("Tavşan Sayısını Giriniz:");
            int tavsan_sayi = Int32.Parse(Console.ReadLine());
            Console.Write("Kaplumbağa Sayısını Giriniz:");
            int kaplumbaga_sayi = Int32.Parse(Console.ReadLine());
            int[] T = new int[tavsan_sayi];
            int[] K = new int[kaplumbaga_sayi];
            int bitis = 70;
            int [] kazanan_kaplumbaga=new int [kaplumbaga_sayi] ;
            int[] kazanan_tavsan=new int [tavsan_sayi];
            int tavsank;
            int kaplumbagak;
            for (int i = 0; i < K.Length; i++)
            {
                K[i] = 0;
            }
            for (int i = 0; i < T.Length; i++)
            {
                T[i] = 0;
            }
            while (yaris_sonu==1)
            {

               

                for (int i = 0; i < K.Length; i++)
                {
                    ran = rNesne.Next(10) + 1; // Bu adım için rastgele sayı ürettik
                    Console.WriteLine("Üretilen Rastgele sayı " + ran);
                    //Kap. İçin
                    int kAdim = 0;
                    if (ran >= 1 && ran <= 5)
                        kAdim = 3;
                    else if (ran > 5 && ran <= 7)
                        kAdim = -6;
                    else if (ran > 7 && ran <= 10)
                        kAdim = 1;

                    // Kap. için yeni yer
                        K[i] = K[i] + kAdim;
                        if (K[i] < 0)
                            K[i] = 0;
                        if (K[i] > bitis)
                        {
                            yaris_sonu = 0;
                         kazanan_kaplumbaga[i] = i;
                        }
                    
                }

                for (int i = 0; i < T.Length; i++)
                {
                    ran = rNesne.Next(10) + 1; // Bu adım için rastgele sayı ürettik
                    Console.WriteLine("Üretilen Rastgele sayı " + ran);
                    // Tavşan
                    int tAdim = 0;
                    if (ran >= 1 && ran <= 2)
                        tAdim = 0;
                    else if (ran > 2 && ran <= 4)
                        tAdim = 9;
                    else if (ran == 5)
                        tAdim = -12;
                    else if (ran > 5 && ran <= 8)
                        tAdim = 1;
                    else if (ran > 8 && ran <= 10)
                        tAdim = -2;

                    // Tavsan için

                        T[i] = T[i] + tAdim;
                        if (T[i] < 0)
                            T[i] = 0;
                        if (T[i] > bitis)
                        {
                        yaris_sonu = 0;
                        kazanan_tavsan[i] = i;

                        }
                    
                }
                

               

               

                ///
                for (int j = 0; j < K.Length; j++)
                {
                    for (int i = 0; i < bitis; i++)
                    {

                        if (K[j] == i)
                            Console.Write("K");
                        else
                            Console.Write("-");

                    }
                    Console.WriteLine("    ");
                }

                for (int j = 0; j < T.Length; j++)
                {
                    for (int i = 0; i < bitis; i++)
                    {

                        if (T[j] == i)
                            Console.Write("T");
                        else
                            Console.Write("-");

                    }
                    Console.WriteLine("    ");
                }



                Console.Write("\n");
            }


            for (int i = 0; i < kazanan_kaplumbaga.Length; i++)
            {
                if (kazanan_kaplumbaga[i]!=0)
                {
                    count_kaplumbaga++;
                }
            }
            for (int i = 0; i < kazanan_tavsan.Length; i++)
            {
                if (kazanan_tavsan[i] != 0)
                {
                    count_tavsan++;
                }
            }
            if (count_kaplumbaga != 0 && count_tavsan != 0)
            {
                Console.Write("Beraberlik ");
                for (int i = 0; i < kazanan_kaplumbaga.Length; i++)
                {
                    if (kazanan_kaplumbaga[i]!=0)
                    {
                        kaplumbagak = kazanan_kaplumbaga[i] + 1;
                        Console.Write("Tortoise " + kaplumbagak.ToString());
                    }
                   
                }
                for (int i = 0; i < kazanan_tavsan.Length; i++)
                {
                    if (kazanan_tavsan[i]!=0)
                    {
                        tavsank = kazanan_tavsan[i] + 1;
                        Console.Write("Rabbit " + tavsank.ToString());
                    }
                    
                }
                Console.WriteLine();
            }
            else if (count_kaplumbaga == 0 && count_tavsan != 0 && count_tavsan != 1)
            {
                Console.Write("Beraberlik ");
                for (int i = 0; i < kazanan_tavsan.Length; i++)
                {
                    if (kazanan_tavsan[i]!=0)
                    {
                        tavsank = kazanan_tavsan[i] + 1;
                        Console.Write("Rabbit " + tavsank.ToString());
                    }
                    
                }
            }
            else if (count_kaplumbaga != 0 && count_kaplumbaga != 1 && count_tavsan == 0)
            {
                Console.Write("Beraberlik ");
                for (int i = 0; i < kazanan_kaplumbaga.Length; i++)
                {
                    if (kazanan_kaplumbaga[i]!=0)
                    {
                        kaplumbagak = kazanan_kaplumbaga[i] + 1;
                        Console.Write("Tortoise " + kaplumbagak.ToString());
                    }
                    
                }
            }
            else if (count_kaplumbaga==1 && count_tavsan==0)
            {
                for (int i = 0; i < kazanan_kaplumbaga.Length; i++)
                {
                    if (kazanan_kaplumbaga[i]!=0)
                    {
                        kaplumbagak = kazanan_kaplumbaga[i] + 1;
                        Console.WriteLine("Tortoise " + kaplumbagak.ToString() + " wins!");
                    }
                    
                }
            }
            else if (count_tavsan == 1 && count_kaplumbaga == 0)
            {
                for (int i = 0; i < kazanan_tavsan.Length; i++)
                {
                    if (kazanan_tavsan[i]!=0)
                    {
                        tavsank = kazanan_tavsan[i] + 1;
                        Console.WriteLine("Rabbit " + tavsank.ToString() + " wins!");
                    }
                    
                }
            }
            
            Console.Read();


            // TODO code application logic here
        }

    }

}


