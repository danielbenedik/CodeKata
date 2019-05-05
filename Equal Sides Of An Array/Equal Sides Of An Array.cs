using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
    public static void Main()
    {
        int[] arr2 = { 20, 10, 30, 10, 10, 15, 35 };
        Console.WriteLine(FindEvenIndex(arr2));
    }

    public static int FindEvenIndex(int[] arr)
    {
        
        int countLeft = 0;
        int countRight = arr.Sum();

        for (int i=0; i < arr.Length; i++)
        {


            countLeft += arr[i];
            if (i > 0)
                countRight -= arr[i - 1];

            if (countLeft == countRight)
                return (i);

        }
            return (-1);

    }
}
