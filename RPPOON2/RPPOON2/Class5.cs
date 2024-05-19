using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 5 REFA
class Zadatak
{
    public List<string> DetectPalindromes(List<string> strings)
    {
        List<string> palindromes = new List<string>();
        if (strings == null) return palindromes;
        foreach (string str in strings)
        {
            //Palindrome
            if (IsPalndorme(str))
            {
                palindromes.Add(str);
            }
        }
        return palindromes;
    }
    private bool IsPalndorme(string str)
    {
        string temp1 = str.Replace(" ", "").ToLower();
        string temp2 = new string(temp1.Reverse().ToArray());
        return temp1.Equals(temp2);
    }
}
