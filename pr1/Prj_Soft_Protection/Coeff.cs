using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Prj_Soft_Protection
{
    class Coefficient
    {
        static public Dictionary<double, double> Student6 = GetCoeff(@"C:\Users\Микита\OneDrive\Рабочий стол\00\Pr1\StudentsCoefficient.txt", 6);
        static public Dictionary<double, double> Student7 = GetCoeff(@"C:\Users\Микита\OneDrive\Рабочий стол\00\Pr1\StudentsCoefficient.txt", 7);
        static public Dictionary<double, double> Fisher7 = GetCoeff(@"C:\Users\Микита\OneDrive\Рабочий стол\00\Pr1\FisherCoefficient.txt", 7);

        public const string IdentifPhrase = "qwertyui";
        
        static private Dictionary<double, double> GetCoeff(string source, double n)
        {
            Dictionary<double, double> Coef = new Dictionary<double, double>();
            StreamReader File = new StreamReader(source);
            bool counter = false;
            while (!File.EndOfStream)
            {
                try
                {
                    string[] Line = File.ReadLine().Split(' ');
                    if (counter && (n + 1).ToString() != Line[0])
                    {
                        if (Line[0] != "\n")
                            Coef.Add(Double.Parse(Line[0]), Double.Parse(Line[1]));
                    }
                    else if ((n + 1).ToString() == Line[0])
                    {
                        return Coef;
                    }
                    else
                    {
                        if (n.ToString() == Line[0])
                        {
                            counter = true;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Файл не відкривається!");
                };
            }
            return Coef;
        }
    }
}
