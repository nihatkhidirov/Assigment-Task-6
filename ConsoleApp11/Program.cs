using System.Linq.Expressions;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            //    Console.Write(" A- Massivinde Nece Index-si Oldugunu Daxil Edin:");
            //    int say = Convert.ToInt32(Console.ReadLine());
            //    int[] a = new int[say];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        Console.Write($" {i + 1}. Ededinizi Daxil Edin: ");
            //        a[i] = Convert.ToInt32(Console.ReadLine());
            //    }

            //    Console.WriteLine(" ###############");
            //    int c;
            //l2:
            //    Console.WriteLine("C- Deyisenin Qiymetini Daxil Edin:");
            //    if (!int.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine(" Eded Duzgun Daxil Edilmemisdir! ");
            //        goto l2;
            //    }
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] < c)
            //        {
            //            Console.WriteLine($"C-den Kicik Olan Massivin Elementleri: {a[i]}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Massivin Bu Elementi C-den Kicik Deyildir!");
            //        }

            //    }

            //}
            #endregion
            #region Task2
            //2.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementlerinin ededi ortasini tapmaq
            //l1:
            //    int uzunlug1, c;
            //    Console.Write(" A- Massivinin Uzunlugunu Daxil Edin:");
            //    if (!int.TryParse(Console.ReadLine(), out uzunlug1))
            //    {
            //        Console.WriteLine(" Massivin Uzunlugu Duzgun Daxil Edilmemisdir! ");
            //        goto l1;
            //    }
            //    double[] a = new double[uzunlug1];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        Console.Write($"{i + 1}.Indexdeki Eded:");
            //        a[i] = Convert.ToDouble(Console.ReadLine());
            //    }

            //    Console.WriteLine("#####################");

            // l2:
            //    Console.WriteLine("C- Deyisenin Qiymetini Daxil Edin:");
            //    if (!int.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine(" Eded Duzgun Daxil Edilmemisdir! ");
            //        goto l2;
            //    }
            //    int counter = 0;
            //    double cem = 0;
            //    double edediorta;
            //    double eded;
            //    for(int i=0; i<a.Length; i++)
            //    {
            //        if (a[i]<c)
            //        {
            //            counter++;
            //            cem = cem + a[i];
            //        }                    

            //    }
            //    Console.WriteLine($"Ededi Orta: {cem/counter}");

            #endregion
            #region Task3
            //3.  a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen elementlerinin hendesi ortasini tapmaq
            //l1:
            //    int uzunlug1, c;
            //    Console.Write(" A- Massivinin Uzunlugunu Daxil Edin:");
            //    if (!int.TryParse(Console.ReadLine(), out uzunlug1))
            //    {
            //        Console.WriteLine(" Massivin Uzunlugu Duzgun Daxil Edilmemisdir! ");
            //        goto l1;
            //    }
            //    double[] a = new double[uzunlug1];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        Console.Write($"{i + 1}.Indexdeki Eded:");
            //        a[i] = Convert.ToDouble(Console.ReadLine());
            //    }

            //    Console.WriteLine("#####################");

            //l2:
            //    Console.WriteLine("C- Deyisenin Qiymetini Daxil Edin:");
            //    if (!int.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine(" Eded Duzgun Daxil Edilmemisdir! ");
            //        goto l2;
            //    }
            //    double counter = 0;
            //    double hasil = 1;
            //    double edediorta;
            //    double eded;
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] > c)
            //        {
            //            counter++;
            //            hasil = hasil * a[i];

            //        }

            //    }
            //    double hendesiorta = Math.Pow(hasil, 1 / counter);
            //    Console.WriteLine($"Hendesi Orta: {hendesiorta}");
            #endregion
            #region Task4
            //4.  a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen elementlerini coxdan aza dogru siralamaq
            //l1:
            //    int uzunlug1, c;
            //    Console.Write(" A- Massivinin Uzunlugunu Daxil Edin:");
            //    if (!int.TryParse(Console.ReadLine(), out uzunlug1))
            //    {
            //        Console.WriteLine(" Massivin Uzunlugu Duzgun Daxil Edilmemisdir! ");
            //        goto l1;
            //    }
            //    double[] a = new double[uzunlug1];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        Console.Write($"{i + 1}.Indexdeki Eded:");
            //        a[i] = Convert.ToDouble(Console.ReadLine());
            //    }

            //    Console.WriteLine("#####################");

            //l2:
            //    Console.WriteLine("C- Deyisenin Qiymetini Daxil Edin:");
            //    if (!int.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine(" Eded Duzgun Daxil Edilmemisdir! ");
            //        goto l2;
            //    }
            //    double counter = 0;
            //    double hasil = 1;
            //    double edediorta;
            //    double eded;
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] > c)
            //        {
            //            counter++;
            //            Array.Sort(a);
            //            Array.Reverse(a);
            //            Console.WriteLine(a[i]);

            //        }

            //    }
            #endregion
            #region Task5
            //a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementler icinden maximum elementi tapmaq
            //l1:
            //    int uzunlug1, c;
            //    Console.Write(" A- Massivinin Uzunlugunu Daxil Edin:");
            //    if (!int.TryParse(Console.ReadLine(), out uzunlug1))
            //    {
            //        Console.WriteLine(" Massivin Uzunlugu Duzgun Daxil Edilmemisdir! ");
            //        goto l1;
            //    }
            //    int[] a = new int[uzunlug1];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        Console.Write($"{i + 1}.Indexdeki Eded:");
            //        a[i] = Convert.ToInt32(Console.ReadLine());
            //    }

            //    Console.WriteLine("#####################");

            //l2:
            //    Console.WriteLine("C- Deyisenin Qiymetini Daxil Edin:");
            //    if (!int.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine(" Eded Duzgun Daxil Edilmemisdir! ");
            //        goto l2;
            //    }
            //    int max = a[0];
            //    double counter = 0;
            //    double hasil = 1;
            //    double edediorta;
            //    double eded;
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] < c)
            //        {
            //            if (a[i] > max)
            //            {
            //                max = a[i];

            //            }
            //        }

            //    }
            //    Console.WriteLine($"Massivde Serti Odeyen En Boyuk Eded: {max}");
            #endregion
            #region Task6
            //l1:
            //    int uzunlug1, c;
            //    Console.Write(" Y- Massivinin Uzunlugunu Daxil Edin:");
            //    if (!int.TryParse(Console.ReadLine(), out uzunlug1))
            //    {
            //        Console.WriteLine(" Massivin Uzunlugu Duzgun Daxil Edilmemisdir! ");
            //        goto l1;
            //    }
            //    int[] y = new int[uzunlug1];
            //    for (int i = 0; i < y.Length; i++)
            //    {
            //        Console.Write($"{i + 1}.Indexdeki Eded:");
            //        y[i] = Convert.ToInt32(Console.ReadLine());
            //    }

            //    Console.WriteLine("#####################");
            //    int uzunlug2 = uzunlug1;
            //    int[] x = new int[uzunlug2];
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //        if (y[i] > 0)
            //        {
            //            x[i] = (int)Math.Pow(y[i], 2);

            //         }
            //            Console.WriteLine($"X-Massivinin Elementleri: {x[i]}");

            //    }
            #endregion
            #region Task7          
            // int uzunlug;
            //l1: Console.Write("A- Massivinin Uzunlugunu Daxil Edin:");
            // if(!int.TryParse(Console.ReadLine(),out uzunlug))
            // {
            //     Console.WriteLine("Edediniz Duzgun Daxil Edilmemisdir!");
            //     goto l1;
            // }
            // int[] a = new int[uzunlug];
            // for(int i=0; i<a.Length;i++)
            // {
            //     Console.WriteLine($"{i + 1}. Index Eded:");
            //     a[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // double counter = 2;

            // double max = a[0];
            // double min = a[0];
            // for(int i=0;i<a.Length;i++)
            // {
            //     if (a[i]>max)
            //     {
            //         max = a[i];
            //     }
            //     if (a[i]<min)
            //     {
            //         min= a[i];
            //     }            

            // }


            // double hasil = min * max;
            // double hendesiorta = (double)Math.Pow(hasil, 1.0 / counter);

            // Console.WriteLine($"Massivde En Kicik Ve En Boyuk Ededlerin Ededi Ortasi: {(min+max)/2}");
            // Console.WriteLine($"Massivdeki En Kicik Ve En Boyuk Ededlerin Hendesi Ortasi: {hendesiorta}");
            #endregion
            #region Task8
            //int[] massiv1 = new int[14];
            //for (int i = 0; i < 14; i++)
            //{
            //    Console.WriteLine($"{i + 1}. Indexdeki Edediniz:");
            //    massiv1[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //int 
            //int[] massiv2 = new int[14];
            //Console.WriteLine("###############");

            //for (int i = 0; i < 14; i++)
            //{
            //    Console.WriteLine($"{i + 1}. Indexdeki Edediniz:");
            //    massiv2[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("###############");
            //int[] massiv3 = new int[14];
            //for (int i = 0; i < 14; i++)
            //{
            //    massiv3[i] = massiv1[i] * massiv2[i];
            //    Console.WriteLine($"{i+1}. Indexdeki massiv3[i]");
            //}
            #endregion
            #region Task9
            //int[] massiv = new int[25];
            //int eded;
            //for(int i=0;i<25;i++)
            //{
            //    Console.WriteLine($"{i+1} Indexdeki Edediniz: ");
            //    massiv[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("#################################################################");
            //int[] massiv1 = new int[8];
            //for(int i=0;i<8;i++)
            //{
            //    massiv1[i] = massiv[i] * massiv[i];
            //    Console.WriteLine(massiv1[i]);
            //}
            //Console.WriteLine("##############################################################");
            //int[] massiv2 = new int[25];
            //for(int i=8; i<25; i++)
            //{
            //    massiv2[i] = massiv[i] / 4;
            //    Console.WriteLine(massiv2[i]);
            //}
            #endregion
            #region Task10
            // int uzunlug;
            //l1: Console.Write("Massivin Uzunlugunu Daxil Edin:");
            // if(!int.TryParse(Console.ReadLine(),out uzunlug))
            // {
            //     Console.WriteLine("Edediniz Duzgun Daxil Edilmemisdir!");
            //     goto l1;

            // }
            // int[] X = new int[uzunlug];
            // for(int i=0;i<X.Length;i++)
            // {
            //     Console.Write($"{i+1}. Indexdeki Ededinizi Daxil Edin;");
            //     X[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // int max = X[0];
            // for(int i=0; i<X.Length;i++)
            // {
            //     if (X[i]<0)
            //     {
            //         if (X[i]>max)
            //         {
            //             max = X[i];
            //         }
            //     }
            // }
            // Console.WriteLine($"X(n)- Massvinden Ancaq Menfi Elementlerin Maximumu: {max}");
            #endregion
            #region Task11
            //    int uzunlug;
            //l1: Console.Write("Massivin Uzunlugunu Daxil Edin:");
            //    if (!int.TryParse(Console.ReadLine(), out uzunlug))
            //    {
            //        Console.WriteLine("Edediniz Duzgun Daxil Edilmemisdir!");
            //        goto l1;
            //    }
            //    int[] x = new int[uzunlug];
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //     l2:   Console.WriteLine($"{i + 1}.Indexdeki Ededinizi Daxil Edin: ");
            //        x[i] = Convert.ToInt32(Console.ReadLine());
            //        if (x[i]>100)
            //        {
            //            Console.WriteLine("Edediniz 100 Den Boyukdur!");
            //            goto l2;
            //        }

            //    }
            //    for (int i = 0; i < x.Length; i++)
            //    {

            //        Array.Sort(x);
            //        Array.Reverse(x);
            //        Console.WriteLine($" Azalma Sirasina gore {i + 1}. {x[i]}");

            //    }
            #endregion
            #region Task12
            //int[] x = new int[20];

            //for(int i=0; i<x.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. Indexdeki Ededinizi Daxil Edin:");
            //    x[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //int counter = 0;
            //double sum = 0;
            //Console.WriteLine("#######################################################");

            //for(int i=0; i<10;i++)
            //{
            //    counter++;
            //    sum = sum + x[i];

            //}
            //double ededorta = sum /counter;
            //Console.WriteLine(counter);
            //Console.WriteLine($"Massivin Ilk Yarisinin Ededi Ortasi: {ededorta}");
            //Console.WriteLine("#######################################################");
            //double hasil = 1;
            //double counter1 = 0;
            //for(int i=10; i<20;i++)
            //{
            //    counter1++;
            //    hasil = hasil * x[i];

            //}
            //double hendesiorta =(double) Math.Pow(hasil, 1 / counter1);
            //Console.WriteLine(counter1);
            //Console.WriteLine($"Massivin Ikinci Yarisinin Hendesi Ortasi: {hendesiorta}");
            //Console.WriteLine("#################################################");
            #endregion

        }
    }
}



