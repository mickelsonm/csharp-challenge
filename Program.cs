using System;

namespace csharp_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ScrambleOne("tester"));
            Console.WriteLine(ScrambleTwo("tester"));
            Console.WriteLine(ScrambleThree("tester"));
        }

        private static string ScrambleOne(string input){
          string result = "";
          int rndpos;
          Random rnd = new Random();

          //create character set using copy of provided input string
          string charset = String.Copy(input);

          while(charset.Length > 0){
            //pick a random position given provided characters
            rndpos = rnd.Next(0, charset.Length);
            //append selected position's character to our result
            result += charset[rndpos];
            //remove selected position so it's not repeated
            charset = charset.Remove(rndpos, 1);
          }

          return result;
        }

        private static string ScrambleTwo(string input){
          int rndpos;
          Random rnd = new Random();
          char current;
          char[] chars = input.ToCharArray();

          for(int i=0; i < chars.Length; i++){
            //pick a random position from available characters
            rndpos = rnd.Next(0, chars.Length);
            //store current character
            current = chars[i];
            //swap current and randomly picked character
            chars[i] = chars[rndpos];
            chars[rndpos] = current;
          }
          
          return new string(chars);
        }

        private static string ScrambleThree(string input){
          string result = "";
          return result;
        }
    }
}
