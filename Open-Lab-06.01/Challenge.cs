using System;

namespace Open_Lab_06._01
{
    public class Challenge
    {
        public string MysteryFunc(string str)
        { 
            string new_string = String.Empty;
            char[] characters = str.ToCharArray();

            for (int i = 0; i <= characters.Length - 1; i += 1)
            {
                if (int.TryParse(characters[i].ToString(), out int not_needed) == false)
                {
                    bool successfullyParsed = int.TryParse(characters[i + 1].ToString(), out int Length_Of_Letter);
                    for (int a = 1; a <= Length_Of_Letter; a++)
                    {
                        new_string += characters[i].ToString();
                    }
                }
            }
            return new_string;
        }
    }
}
