using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
    public static void Main()
    {
        string str1 = "aliujfuykjbb";
        string str2 = "cc";


        Console.WriteLine(Longest(str1, str2));
    }

    public static string Longest(string s1, string s2)
    {
        char[] allTheABC = new char[26];

        int count = 0;
        count += Update_the_array(ref s1, ref allTheABC);
        count += Update_the_array(ref s2, ref allTheABC);

        
        char[] resCharArry = new char[count];

        int k = 0; // k is for running index for the res string

        for (int i = 0; i < allTheABC.Length; i++)
        {
            if(allTheABC[i] != '\0')
            {
                resCharArry[k] = allTheABC[i];
                    k++;
            }

        }

        return (new string(resCharArry));
    }
    public static int Update_the_array(ref string str, ref char[] allTheABC)
    {

        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (allTheABC[str[i] - 'a'] == '\0')
            {
                allTheABC[str[i] - 'a'] = str[i];
                count++;
            }
        }
        return count;

    }


}
