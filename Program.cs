using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {                                    
            int[] dizi = {1,3,2,11,5,22 };
            int temp;
            
            for (int i = 0; i <dizi.Length; i++)
            {
                for (int j = 1; j <dizi.Length; j++)
                {
                    if (dizi[j]<dizi[j-1] && dizi[j-1]<dizi[j-2] )
                    {
                        temp = dizi[j - 2];
                        dizi[j - 2] = dizi[j];
                        dizi[j] = temp;


                    }else if (dizi[j]<dizi[j-1] )
                    {
                        temp = dizi[j-1];
                        dizi[j-1] = dizi[j];
                        dizi[j] = temp;
                    }
                    
                }
            }

            foreach (var dd in dizi)
            {
                Console.WriteLine(dd);
            }
        }
    }
}
