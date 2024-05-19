using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//4 REFA
class DrugiZadatak
{
    public static List<char> CountUniqueChars(string text)
    {
        List<char> characters = new List<char>();
        for (int i = 0; i < text.Length; i++)
        {
            
            if (CountCharacter(text, text[i]) == 1)
            {
                characters.Add(text[i]);
            }
        }
        return characters;
    }
    public static int CountCharacter(string text, char character)
    {
        int Count = 0;
        for (int j = 0; j < text.Length; j++)
        {
            if (character == text[j])
            {
                Count++;
            }
            
        }
        return Count;
    }
}
