using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //read file
            string file = "Files/grades.txt";
            if (File.Exists(file))
            {
                StreamReader sr = new StreamReader(file);
                string line = sr.ReadLine();
                line.Split(',');


                while (!sr.EndOfStream) //test

                while (!sr.EndOfStream)

                {
                    line = sr.ReadLine();
                    var column = line.Split(',');

                    Console.WriteLine("Name {0}, Class {1}, Grade {2}", column[0], column[1], column[2]);
                }



                sr.Close();
                //write file
                StreamWriter sw = new StreamWriter(file, true);

                sw.Close();
            }

            //not a big change
            //not a big change 2



            
        }
    }
}