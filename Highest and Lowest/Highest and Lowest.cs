using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
    public static void Main()
    {
        string str = "-1 2 3 4 45";
        Console.WriteLine(HighAndLow(str));
    }

   
    public static string HighAndLow(string numbers)
    {

        string[] allParts = numbers.Split(' ');

        int num = int.Parse(allParts[0]);
        int maxNum = num, minNum = num;

        for (int i = 1; i < allParts.Length; i++)
        {
            num = int.Parse(allParts[i]);

            if (minNum < num)
                minNum = num;

            if (maxNum > num)
                maxNum = num;
        }

        string strMaxNum = maxNum.ToString();
        string strMinNum = minNum.ToString();

        string res = minNum.ToString() + " " + maxNum.ToString();

        return res;

    }

}