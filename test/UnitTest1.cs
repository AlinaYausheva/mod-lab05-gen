using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using generator;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string file_name = "TextByBigrams.txt";
            //file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            Assert.IsTrue(txt.Length >= 1000);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string file_name = "TextByWords.txt";
            //file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            string[] words = txt.Split(' ');
            Assert.IsTrue(words.Length >= 1000);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string file_name = "TextByWordPairs.txt";
            //file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            string[] words = txt.Split(' ');
            Assert.IsTrue(words.Length >= 1000);
        }

        [TestMethod]
        public void TestMethod4()
        {
            bool mark = true;
            string file_name = "TextByBigrams.txt";
            //file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            for(int i = 0; i < txt.Length-1; i++)
            {
                if(txt[i]=='ô'&& txt[i+1] == 'ý')
                {
                    mark = false;
                } else if (txt[i] == 'ï' && txt[i + 1] == 'ê')
                {
                    mark = false;
                }
                else if (txt[i] == 'æ' && txt[i + 1] == 'û')
                {
                    mark = false;
                }
                else if (txt[i] == 'ë' && txt[i + 1] == 'ù')
                {
                    mark = false;
                }
                else if (txt[i] == '÷' && txt[i + 1] == 'ç')
                {
                    mark = false;
                }
            }
            Assert.IsTrue(mark);
        }

        [TestMethod]
        public void TestMethod5()
        {
            bool mark = true;
            string file_name = "TextByWords.txt";
            //file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            string[] words = txt.Split(' ');
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == "è")
                    count1++;
                if (words[i] == "æèçíü")
                    count2++;
                if (words[i] == "ìåñòî")
                    count3++;
            }
            Assert.IsTrue(count1 > count2);
            Assert.IsTrue(count1 > count3);
        }

        [TestMethod]
        public void TestMethod6()
        {
            bool mark = true;
            string file_name = "TextByWords.txt";
            //file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            string[] words = txt.Split(' ');
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == "è" && words[i+1]=="íå")
                    count1++;
                else if (words[i] == "è" && words[i + 1] == "íà")
                    count2++;
            }
            Assert.IsTrue(count1 > count2);

        }

        [TestMethod]
        public void TestMethod7()
        {
            string file_name = "TextByWords.txt";
            //file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            string[] words = txt.Split(' ');
            int count = 0;

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == "åùå")
                    count++;
            }
            Assert.AreEqual(9, count);
        }

        [TestMethod]
        public void TestMethod8()
        {
            string file_name = "TextByWords.txt";
            //file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            string[] words = txt.Split(' ');
            int count = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == "я" && words[i + 1] == "и")
                    count++;
            }
            Assert.AreEqual(5, count);
        }
    }
}

