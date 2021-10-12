using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BirimTestiOdevler
{
    public class BucketSort
    {
        public int[] bucketSort(int[] dizi)
        {
            int minValue = dizi[0];
            int maxValue = dizi[0];

            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > maxValue)
                    maxValue = dizi[i];
                if (dizi[i] < minValue)
                    minValue = dizi[i];
            }

            int m = maxValue - minValue + 1;//Kova sayısı

            List<int>[] bucket = new List<int>[m];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                bucket[dizi[i] - minValue].Add(dizi[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        dizi[k] = bucket[i][j];
                        k++;
                    }
                }
            }
            return dizi;
        }
    }
    public class MergeSort
    {
        void merge(int[] dizi, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;
            for (i = 0; i < n1; ++i)
                L[i] = dizi[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = dizi[m + 1 + j];
            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    dizi[k] = L[i];
                    i++;
                }
                else
                {
                    dizi[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                dizi[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                dizi[k] = R[j];
                j++;
                k++;
            }

        }
        public int[] mergeSort(int[] dizi, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                mergeSort(dizi, l, m);
                mergeSort(dizi, m + 1, r);
                merge(dizi, l, m, r);
            }
            return dizi;
        }
    }
    public class LibraryISBN {
        Dictionary<string, string> kutuphane = new Dictionary<string, string>();
        public LibraryISBN()
        {
            kutuphane.Add("Yüzüklerin Efendisi: Yüzük Kardeşliği","9789753425");
            kutuphane.Add("Yüzüklerin Efendisi: İki Kule", "9753421818");
            kutuphane.Add("Yüzüklerin Efendisi: Kralın Dönüşü", "9753422024");
            kutuphane.Add("Dune", "605375479X");
            kutuphane.Add("Dune Çocukları", "6053756024");
            kutuphane.Add("Drizzt Efsanesi 1: Anayurt", "6053755575");
            kutuphane.Add("Drizzt Efsanesi 2: Sürgün", "6059958133");
            kutuphane.Add("Zaman Çarkı 1: Dünyanın Gözü", "9758725718");
            kutuphane.Add("Zaman Çarkı 2: Büyük Av", "9758725726");
        }

        public string LibrarySearchIf(string text)
        {
            string sonuc = "";
            if (text == "Yüzüklerin Efendisi: Yüzük Kardeşliği") sonuc = "9789753425";
            else if (text == "Yüzüklerin Efendisi: İki Kule") sonuc = "9753421818";
            else if (text == "Yüzüklerin Efendisi: Kralın Dönüşü") sonuc = "9753422024";
            else if (text == "Dune") sonuc = "605375479X";
            else if (text == "Dune Çocukları") sonuc = "6053756024";
            else if (text == "Drizzt Efsanesi 1: Anayurt") sonuc = "6053755575";
            else if (text == "Drizzt Efsanesi 2: Sürgün") sonuc = "6059958133";
            else if (text == "Zaman Çarkı 1: Dünyanın Gözü") sonuc = "9758725718";
            else if (text == "Zaman Çarkı 2: Büyük Av") sonuc = "9758725726";
            else sonuc = "Böyle Bir Kitap Yoktur.";
            return sonuc;
        }

        public string LibrarySearchSwitch(string text)
        {
            string sonuc = "";
            switch(text)
            {
                case "Yüzüklerin Efendisi: Yüzük Kardeşliği":
                    sonuc = "9789753425";
                    break;
                case "Yüzüklerin Efendisi: İki Kule":
                    sonuc = "9753421818";
                    break;
                case "Yüzüklerin Efendisi: Kralın Dönüşü":
                    sonuc = "9753422024";
                    break;
                case "Dune":
                    sonuc = "605375479X";
                    break;
                case "Dune Çocukları":
                    sonuc = "6053756024";
                    break;
                case "Drizzt Efsanesi 1: Anayurt":
                    sonuc = "6053755575";
                    break;
                case "Drizzt Efsanesi 2: Sürgün":
                    sonuc = "6059958133";
                    break;
                case "Zaman Çarkı 1: Dünyanın Gözü":
                    sonuc = "9758725718";
                    break;
                case "Zaman Çarkı 2: Büyük Av":
                    sonuc = "9758725726";
                    break;
                default:
                    sonuc = (sonuc == "") ? "Böyle Bir Kitap Yoktur." : sonuc;
                    break;
            }

            return sonuc;
        }

    }

    public class Alfabe
    {
        public enum AlfabeTR { A=1, B, C, Ç, D, E, F, G, Ğ, H, I, İ, J, K, L, M, N, O,Ö, P, R, S, Ş, T, U, Ü, V, Y, Z };

        public byte AlfabeSearchIf(char harf)
        {
            byte sonuc = 0;
            if (harf == 'A') sonuc = (byte)AlfabeTR.A;
            else if (harf == 'B') sonuc = (byte)AlfabeTR.B;
            else if (harf == 'C') sonuc = (byte)AlfabeTR.C;
            else if (harf == 'Ç') sonuc = (byte)AlfabeTR.Ç;
            else if (harf == 'D') sonuc = (byte)AlfabeTR.D;
            else if (harf == 'E') sonuc = (byte)AlfabeTR.E;
            else if (harf == 'F') sonuc = (byte)AlfabeTR.F;
            else if (harf == 'G') sonuc = (byte)AlfabeTR.G;
            else if (harf == 'Ğ') sonuc = (byte)AlfabeTR.Ğ;
            else if (harf == 'H') sonuc = (byte)AlfabeTR.H;
            else if (harf == 'I') sonuc = (byte)AlfabeTR.I;
            else if (harf == 'İ') sonuc = (byte)AlfabeTR.İ;
            else if (harf == 'J') sonuc = (byte)AlfabeTR.J;
            else if (harf == 'K') sonuc = (byte)AlfabeTR.K;
            else if (harf == 'L') sonuc = (byte)AlfabeTR.L;
            else if (harf == 'M') sonuc = (byte)AlfabeTR.M;
            else if (harf == 'N') sonuc = (byte)AlfabeTR.N; 
            else if (harf == 'O') sonuc = (byte)AlfabeTR.O;
            else if (harf == 'Ö') sonuc = (byte)AlfabeTR.Ö;
            else if (harf == 'P') sonuc = (byte)AlfabeTR.P;
            else if (harf == 'R') sonuc = (byte)AlfabeTR.R;
            else if (harf == 'S') sonuc = (byte)AlfabeTR.S;
            else if (harf == 'Ş') sonuc = (byte)AlfabeTR.Ş;
            else if (harf == 'T') sonuc = (byte)AlfabeTR.T;
            else if (harf == 'U') sonuc = (byte)AlfabeTR.U; 
            else if (harf == 'Ü') sonuc = (byte)AlfabeTR.Ü;
            else if (harf == 'V') sonuc = (byte)AlfabeTR.V; 
            else if (harf == 'Y') sonuc = (byte)AlfabeTR.Y; 
            else if (harf == 'Z') sonuc = (byte)AlfabeTR.Z;
            return sonuc;
        }

        public byte AlfabeSearchSwitch(char harf)
        {
            byte sonuc = 0;
            switch (harf)
            {
                case 'A':
                    sonuc = (byte)AlfabeTR.A;
                    break;
                case 'B':
                    sonuc = (byte)AlfabeTR.B;
                    break;
                case 'C':
                    sonuc = (byte)AlfabeTR.C;
                    break;
                case 'Ç':
                    sonuc = (byte)AlfabeTR.Ç;
                    break;
                case 'D':
                    sonuc = (byte)AlfabeTR.D;
                    break;
                case 'E':
                    sonuc = (byte)AlfabeTR.E;
                    break;
                case 'F':
                    sonuc = (byte)AlfabeTR.F;
                    break;
                case 'G':
                    sonuc = (byte)AlfabeTR.G;
                    break;
                case 'Ğ':
                    sonuc = (byte)AlfabeTR.Ğ;
                    break;
                case 'H':
                    sonuc = (byte)AlfabeTR.H;
                    break;
                case 'I':
                    sonuc = (byte)AlfabeTR.I;
                    break;
                case 'İ':
                    sonuc = (byte)AlfabeTR.İ;
                    break;
                case 'J':
                    sonuc = (byte)AlfabeTR.J;
                    break;
                case 'K':
                    sonuc = (byte)AlfabeTR.K;
                    break;
                case 'L':
                    sonuc = (byte)AlfabeTR.L;
                    break;
                case 'M':
                    sonuc = (byte)AlfabeTR.M;
                    break;
                case 'N':
                    sonuc = (byte)AlfabeTR.N;
                    break;
                case 'O':
                    sonuc = (byte)AlfabeTR.O;
                    break;
                case 'Ö':
                    sonuc = (byte)AlfabeTR.Ö;
                    break;
                case 'P':
                    sonuc = (byte)AlfabeTR.P;
                    break;
                case 'R':
                    sonuc = (byte)AlfabeTR.R;
                    break;
                case 'S':
                    sonuc = (byte)AlfabeTR.S;
                    break;
                case 'Ş':
                    sonuc = (byte)AlfabeTR.Ş;
                    break;
                case 'T':
                    sonuc = (byte)AlfabeTR.T;
                    break;
                case 'U':
                    sonuc = (byte)AlfabeTR.U;
                    break;
                case 'Ü':
                    sonuc = (byte)AlfabeTR.Ü;
                    break;
                case 'V':
                    sonuc = (byte)AlfabeTR.V;
                    break;
                case 'Y':
                    sonuc = (byte)AlfabeTR.Y;
                    break;
                case 'Z':
                    sonuc = (byte)AlfabeTR.Z;
                    break;
            }
            return sonuc;
        }
    }

    public class Program
    {
        public static int fibonacciFor(int n)// Dinamik Programlamaya Göre Algoritma
        {
            int sonuc = 1;
            if (n > 1)
            {
                int son = 1;
                int son2 = 1;
                int cevap = 1;
                for (int i = 2; i < n; i++)
                {
                    cevap = son + son2;
                    son2 = son;
                    son = cevap;
                }
                sonuc = cevap;
            }

            return sonuc;
        }

        public static int fibonacciDoWhile(int n)// Dinamik Programlamaya Göre Algoritma
        {
            int sonuc = 1;
            if (n > 1)
            {
                int son = 1;
                int son2 = 1;
                int cevap = 1;
                int i = 2;
                do
                {
                    cevap = son + son2;
                    son2 = son;
                    son = cevap;
                    i++;
                } while (i < n);
                sonuc = cevap;
            }

            return sonuc;
        }

        public static int fibonacciWhile(int n)// Dinamik Programlamaya Göre Algoritma
        {
            int sonuc = 1;
            if (n > 1)
            {
                int son = 1;
                int son2 = 1;
                int cevap = 1;
                int i = 2;
                while (i < n) 
                {
                    cevap = son + son2;
                    son2 = son;
                    son = cevap;
                    i++;
                }
                sonuc = cevap;
            }
            return sonuc;
        }

        public static double UsAl(double sayi1, double sayi2)
        {
            if (sayi2 == 0) return 1;
            return UsAl(sayi1, sayi2 - 1) * sayi1;
        }


        public static void Main(string[] args)
        {
            Stopwatch stp = new Stopwatch();
            stp.Start();
            int sonuc = fibonacciFor(20);
            stp.Stop();
            Console.WriteLine("Fibo(20)(for):" + sonuc + " - Time: " + stp.Elapsed);

            stp.Start();
            sonuc = fibonacciDoWhile(20);
            stp.Stop();
            Console.WriteLine("Fibo(20)(do):" + sonuc + " - Time: " + stp.Elapsed);

            stp.Start();
            sonuc = fibonacciWhile(20);
            stp.Stop();
            Console.WriteLine("Fibo(20)(while):" + sonuc + " - Time: " + stp.Elapsed);
            Console.WriteLine("\n");
            double sonuc2 = 0;
            stp.Start();
            sonuc2 = UsAl(2, 16);
            stp.Stop();
            Console.WriteLine("UsAlmak(2,16):" + sonuc2 + " - Time: " + stp.Elapsed);
            stp.Start();
            sonuc2 = Math.Pow(2,16);
            stp.Stop();
            Console.WriteLine("Pow(2,16):" + sonuc2 + " - Time: " + stp.Elapsed);
            Console.WriteLine("\n");

            BucketSort bs = new BucketSort();
            MergeSort ms = new MergeSort();

            int[] dizi = {15,25,35,55,49,85,6,65,44,556,55,4,4,5,54,54,54,23,1,6545};
            int[] sonuc3;
            stp.Start();
            sonuc3 = bs.bucketSort(dizi);
            stp.Stop();
            Console.WriteLine("BucketSort:" + sonuc3 + " - Time: " + stp.Elapsed);
            Console.WriteLine("");
            stp.Start();
            sonuc3 = ms.mergeSort(dizi, 0, dizi.Length - 1);
            stp.Stop();
            Console.WriteLine("MergeSort:" + sonuc3 + " - Time: " + stp.Elapsed);


            LibraryISBN lb = new LibraryISBN();
            Console.WriteLine("\n");
            stp.Start();
            string sonuc4 = lb.LibrarySearchIf("Zaman Çarkı 2: Büyük Av");
            stp.Stop();
            Console.WriteLine("Library(IF):" + sonuc4 + " - Time: " + stp.Elapsed);

            Console.WriteLine("\n");
            stp.Start();
            sonuc4 = lb.LibrarySearchSwitch("Zaman Çarkı 2: Büyük Av");
            stp.Stop();
            Console.WriteLine("Library(Switch):" + sonuc4 + " - Time: " + stp.Elapsed);


            Alfabe alf = new Alfabe();
            Console.WriteLine("\n");
            stp.Start();
            byte sonuc5 = alf.AlfabeSearchIf('Z');
            stp.Stop();
            Console.WriteLine("Alfabe(IF):" + sonuc5 + " - Time: " + stp.Elapsed);

            Console.WriteLine("\n");
            stp.Start();
            sonuc5 = alf.AlfabeSearchSwitch('Z');
            stp.Stop();
            Console.WriteLine("Alfabe(Switch):" + sonuc5 + " - Time: " + stp.Elapsed);


            Console.ReadKey();

        }
    }
}
