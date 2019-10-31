//Sergio Gumpert

using System;

class TextWithoutA
{
    static void Main()
    {
        string text;
        bool haveA = false;
        Console.WriteLine("Write text");
        do
        {
            haveA = false;
            text = Console.ReadLine();
            foreach (char letter in text)
            {
                if (letter == 'a' || letter == 'A')
                    haveA = true;
                else if (haveA == false)
                    haveA = false;
            }
        }
        while (haveA != false);
    }
}
