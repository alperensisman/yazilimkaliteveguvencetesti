using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimguvencetestodev4
{
    public class QuickSort
    {

        public int[] quickSort(int[] dizi, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(dizi, low, high);
                quickSort(dizi, low, pi - 1);
                quickSort(dizi, pi + 1, high);
            }
            return dizi;
        }

        public int partition(int[] dizi, int low, int high)
        {
            int pivot = dizi[high];
            int i = (low - 1);
            int temp = 0;
            for (int j = low; j < high; j++)
            {
                if (dizi[j] < pivot)
                {
                    i++;
                    temp = dizi[i];
                    dizi[i] = dizi[j];
                    dizi[j] = temp;
                }
            }
            temp = dizi[i + 1];
            dizi[i + 1] = dizi[high];
            dizi[high] = temp;
            return i + 1;
        }
    }
    public class Program
    {
        public static string ConvertBinaryText(int sayi)
        {
            if (sayi == 0) return "0";
            StringBuilder sb = new StringBuilder();
            int kalan = 0;
            while(true)
            {
                if(sayi<2) { break; }
                kalan = sayi % 2;
                sayi = (sayi - kalan) / 2;
                sb.Insert(0, kalan.ToString());
            }
            sb.Insert(0, sayi.ToString());
            return sb.ToString();
            //return Convert.ToString(Convert.ToInt32(sayi), 2);
        }

        static void Main(string[] args)
        {

            //int[] dizi = { 9, 5 };
            //QuickSort qs = new QuickSort();
            //dizi = qs.quickSort(dizi, 0, dizi.Length - 1);

            string binary = ConvertBinaryText(7);
            Console.WriteLine(binary);

            Console.ReadKey();
        }
    }
}
