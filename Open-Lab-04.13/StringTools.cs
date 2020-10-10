using System;

namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            int[,] a = new int[str1.Length + 1, str2.Length + 1];
            int index1 = 0;
            int index2 = 0;

            for (int i = 0; i < str1.Length; i++)
                for (int k = 0; k < str2.Length; k++)
                    if (str1[i] == str2[k])
                    {
                        int len = a[i + 1, k + 1] = a[i, k] + 1;
                        if (len > a[index1, index2])
                        {
                            index1 = i + 1;
                            index2 = k + 1;
                        }
                    }

            return str1.Substring(index1 - a[index1, index2], a[index1, index2]);
        }
    }
}
