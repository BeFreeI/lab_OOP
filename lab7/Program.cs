using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace lab7
{
    class Program
    {
        public static string[] StrangeTask(string path)
        {
            string[] text = Regex.Split(File.ReadAllText(path), @"\s+");
            string word;
            for (int i = 0; i < text.Length - 1; i += 2)
            {
                word = text[i];
                text[i] = text[i + 1];
                text[i + 1] = word;
            }
            return text;
        }
        static void Main(string[] args)
        {
            string[] rez = StrangeTask(@"./../../../str.txt");
            foreach(string i in rez)
            {
                Console.WriteLine(i);
            }
        }
    }
}
