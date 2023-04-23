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
            file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            Assert.IsTrue(txt.Length >= 1000);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string file_name = "TextByWords.txt";
            file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            string[] words = txt.Split(' ');
            Assert.IsTrue(words.Length >= 1000);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string file_name = "TextByWordPairs.txt";
            file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
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
            file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            for(int i = 0; i < txt.Length-1; i++)
            {
                if(txt[i]=='�'&& txt[i+1] == '�')
                {
                    mark = false;
                } else if (txt[i] == '�' && txt[i + 1] == '�')
                {
                    mark = false;
                }
                else if (txt[i] == '�' && txt[i + 1] == '�')
                {
                    mark = false;
                }
                else if (txt[i] == '�' && txt[i + 1] == '�')
                {
                    mark = false;
                }
                else if (txt[i] == '�' && txt[i + 1] == '�')
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
            file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            string[] words = txt.Split(' ');
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == "�")
                    count1++;
                if (words[i] == "�����")
                    count2++;
                if (words[i] == "�����")
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
            file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            string[] words = txt.Split(' ');
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == "�" && words[i+1]=="��")
                    count1++;
                else if (words[i] == "�" && words[i + 1] == "��")
                    count2++;
            }
            Assert.IsTrue(count1 > count2);

        }

        [TestMethod]
        public void TestMethod7()
        {
            string file_name = "TextByWords.txt";
            file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            string[] words = txt.Split(' ');
            int count = 0;

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == "���")
                    count++;
            }
            Assert.AreEqual(9, count);
        }

        [TestMethod]
        public void TestMethod8()
        {
            string file_name = "TextByWords.txt";
            file_name = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"..\\..\\..\\"), file_name);
            StreamReader file = new StreamReader(file_name, false);

            string txt = file.ReadToEnd();
            string[] words = txt.Split(' ');
            int count = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == "�" && words[i + 1] == "�")
                    count++;
            }
            Assert.AreEqual(5, count);
        }
    }
}

