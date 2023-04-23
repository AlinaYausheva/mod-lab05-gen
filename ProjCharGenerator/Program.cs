using System;
using System.IO;

namespace generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_name;

            GeneratorBigrams gen1 = new GeneratorBigrams();
            file_name = "TextByBigrams.txt";
            file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamWriter file1 = new StreamWriter(file_name, false);
            int i = 0;
            while (i < 1000)
            {
                char sym = gen1.getSym();
                i ++;

                file1.Write(sym);
            }
            file1.Close();

            GeneratorWords gen2 = new GeneratorWords();
            file_name = "TextByWords.txt";
            file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamWriter file2 = new StreamWriter(file_name, false);
            i = 0;
            while (i < 1000)
            {
                string sym = gen2.getSym();
                i ++;

                file2.Write(sym + " ");
            }
            file2.Close();

            GeneratorWordPairs gen3 = new GeneratorWordPairs();
            file_name = "TextByWordPairs.txt";
            file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamWriter file3 = new StreamWriter(file_name, false);
            i = 0;
            while (i < 1000)
            {
                string ch = gen3.getSym();
                i +=2;

                file3.Write(ch + " ");
            }
            file3.Close();
        }   
    }
}
