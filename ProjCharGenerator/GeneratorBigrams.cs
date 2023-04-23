using System;
using System.IO;

namespace generator
{
    public class GeneratorBigrams
    {
        private string syms = "абвгдежзийклмнопрстуфхцчшщыьэюя";
        private char[] data;
        int[,] weights;
        private int size;

        private Random random = new Random();
        private int index = 0;
        public GeneratorBigrams()
        {
            size = syms.Length;
            data = syms.ToCharArray();
            weights = new int[size, size];
            string file_name = "Bigrams.txt";
            file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);
            int i = 0;
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] num = line.Split(' ');
                for (int j = 0; j < size; j++)
                {
                    weights[i, j] = int.Parse(num[j]);
                }
                i++;
            }
            file.Close();
        }

        public char getSym()
        {
            int summa = 0;
            int[] np = new int[size];
            int[] letterWeights = new int[size];
            for (int i = 0; i < size; i++)
            {
                letterWeights[i] = weights[index, i];
                summa += weights[index, i];
                np[i] = summa;
            }

            int m = random.Next(0, summa);
            int index2;

            for (index2 = 0; index2 < size; index2++)
            {
                if (m < np[index2])
                    break;
            }

            index = index2;
            return data[index2];
        }
    }
}

