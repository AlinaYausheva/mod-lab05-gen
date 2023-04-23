using System;
using System.IO;

namespace generator
{
    public class GeneratorWordPairs
    {
        private string[] data;
        int[] weights;
        private int size;

        private Random random = new Random();

        public GeneratorWordPairs()
        {
            size = 100;
            data = new string[size];
            weights = new int[size];
            string file_name = "FrequenciesOfWordPairs.txt";
            file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);
            int i = 0;
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] numbers = line.Split('|');
                data[i] = numbers[0];
                weights[i] = int.Parse(numbers[1]);
                i++;
            }
        }

        public string getSym()
        {
            int summa = 0;
            int[] np = new int[size];
            int index;
            for (int i = 0; i < size; i++)
            {
                summa += weights[i];
                np[i] = summa;
            }                    
            int m = random.Next(0, summa);
            for (index = 0; index < size; index++)
            {
                if (m < np[index])
                    break;
            }
            return data[index];
        }
    }
}
