using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //string input = "<html><head><title></title></head><body><h1>Intro</h1><ul><li>Item01</li><li>Item02</li><li>Item03</li></ul><p>jura qevivat va jrg fyvccrel fabjl</p><div><button>Click me, baby!</button></div><p> pbaqvgvbaf fabj  qpunvaf ner nofbyhgryl rffragvny sbe fnsr unaqyvat nygubhtu fabj punvaf znl ybbx </p><span>This manual is false, do not trust it! The illuminati wrote it down to trick you!</span><p>vagvzvqngvat gur onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir sbejneq fybjyl naq gvtugra gurz hc va pbyq jrg</p><p> pbaqvgvbaf guvf vf rnfvre fnvq guna qbar ohg vs lbh chg ba lbhe gverf</p></body>";
            //string input = "<p>AA ykBj    12  asd adad adad </p> <p> briEEE^^$%jkls  z</p>";

            string pattern = @"(?<=(<p>)).+?(?=(<\/p>))";
            var texts = Regex.Matches(input, pattern);
            List<string> text= new List<string>();

            foreach (Match match in texts)
            {
                text.Add(match.Value);
            }

            
            for (int i = 0; i < text.Count; i++)
            {
                //text[i] = Regex.Replace(text[i], @"[^a-z0-9]", " ");
                
                string tmp = string.Empty;
                for (int a = 0; a < text[i].Length; a++)
                {
                    int kuku = 0;
                    if (text[i][a] >= 97 && text[i][a] <= 109)
                    {
                        kuku =  text[i][a] + 13;
                    }
                    else if (text[i][a] >= 110 && text[i][a] <= 122)
                    {
                        kuku = text[i][a] - 13;;
                    }
                    else if (text[i][a] >= 48 && text[i][a] <= 57)
                    {
                        kuku = text[i][a];
                    }
                    else
                    {
                        kuku = 32;
                    }
                    
                    tmp = tmp + Convert.ToChar(kuku);
                }

                text[i] = tmp;
                
                text[i] = Regex.Replace(text[i], @"\s+", " ");
                if(i == 0) text[i] = text[i].TrimStart();
                if(i == text[i].Length-1) text[i] = text[i].TrimEnd();
            }

            Console.WriteLine(string.Join("", text));
        }
    }
}

