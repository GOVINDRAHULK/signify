using System;
using System.IO;
using System.Xml.Schema;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of students : ");

            int n = Convert.ToInt32(Console.ReadLine());
            string[] name = new string[n];
            string[] course = new string[n];
            string[] regno = new string[n];
            int[] os = new int[n];
            int[] ds = new int[n];


            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\RAHUL\\Desktop\\input.txt");

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter the Name of the student : ");
                    name[i] = Console.ReadLine();
                    sw.Write($"{name[i]}-");
                    Console.Write($"Enter the Regno of {name[i]} : ");
                    course[i] = Console.ReadLine();
                    sw.Write($"{course[i]}-");
                    Console.Write($"Enter the Course of {name[i]} : ");
                    regno[i] = Console.ReadLine();
                    sw.Write($"{regno[i]}-");
                    Console.Write($"Enter the OS marks of {name[i]} : ");
                    os[i] = Convert.ToInt32(Console.ReadLine());
                    sw.Write($"{os[i]}-");
                    Console.Write($"Enter the DS marks of {name[i]} : ");
                    ds[i] = Convert.ToInt32(Console.ReadLine());
                    sw.Write($"{ds[i]}\n");
                    Console.Write("\n\n");
                }
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                StreamWriter ss = new StreamWriter("C:\\Users\\RAHUL\\Desktop\\output.txt");
                StreamReader sr = new StreamReader("C:\\Users\\RAHUL\\Desktop\\input.txt");
                string line;
                ss.WriteLine("Name | Regno | Total | Grade");
                while((line = sr.ReadLine())!=null)
                {   //Spliting the string for segreating the data.
                    String[] xx = line.Substring(0, line.Length).Split("-");
                    //Considering only the first character of our name.
                    String[] myName = xx[0].Split(" ");
                    for (int i = 0; i < myName.Length; i++)
                    {
                        String s = myName[i];
                        ss.Write(s[0]);
                    }
                    ss.Write(" | ");
                    ss.Write($"{xx[1]} | ");
                    int total = Convert.ToInt32(xx[3]) + Convert.ToInt32(xx[4]);
                    int avg = total / 2;
                    ss.Write($"{total} | ");
                    if (avg >= 90) ss.Write("S\n");
                    else if (avg >= 80) ss.Write("A\n");
                    else if (avg >= 70) ss.Write("B\n");
                    else if (avg >= 60) ss.Write("C\n");
                    else if (avg >= 50) ss.Write("D\n");
                    else ss.Write("F\n");
                }

                Console.WriteLine("Check the ouput file : Result has been generated");
                sr.Close();
                ss.Close();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
