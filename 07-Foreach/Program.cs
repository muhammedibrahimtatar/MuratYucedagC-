using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            /*Foreach(1;2;3;4)
            1-Degisken türü
            2-Degisken adi
            3-In
            4-Liste,Koleksiyon,Dizi
            */

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string city in cities) 
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 3, 5, 7, 8, 22, 241, 1414, 25125, 211, 2556, 896 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //int[] numbers = { 1, 3, 5, 7, 8, 22, 241, 1414, 25125, 211, 2556, 896 };
            //foreach(int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 1, 3, 5, 7, 8, 22, 241, 1414, 25125, 211, 2556, 896 };
            //int total = 0;
            //foreach(int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //};

            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}





            #endregion

            #region Sınav Sistem uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.Write("Sınıfınızda kaç öğrenci var:");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------");

            string[] studentNames=new string[studentCount];
            double[] studentExamAvg=new double[studentCount];

            for(int i=0;i<studentCount; i++)
            {
                Console.Write($"{i+1}.öğrencinin ismini giriniz:");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for(int j=0;j<3;j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                studentExamAvg[i] = totalExamResult / 3;
                
            }
            Console.WriteLine();
            Console.WriteLine("------------------");
            for (int i=0;i<studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması:{studentExamAvg[i]}");
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("------------------");

            }





            #endregion


            Console.Read();
        }
    }
}
