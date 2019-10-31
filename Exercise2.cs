//Sergio Gumpert

using System;

class TextWithoutA
{
    static void Main()
    {
        string text;
        byte haveA;
        Console.WriteLine("Write text");
        do
        {
            haveA = 0;
            text = Console.ReadLine();
            foreach (char letter in text)
            {
                if (letter == 'a' || letter == 'A')
                    haveA = 1;
                else if (haveA == 0)
                    haveA = 0;
            }
        }
        while (haveA != 0);
    }
}
