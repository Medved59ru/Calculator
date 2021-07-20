using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Calculator
{
    public class FileHandler
    {
        public void GetResult()
        {
            string path = GetPath();
            var tempArray = GetDataFromFileBy(path);
            WriteToFile(tempArray, path);
            Console.WriteLine("\n Файл с результатами размещен в указанном каталоге (рядом с исходным файлом) \n ");
        }


        private string GetPath()
        {
            string path = ReadPathFromConsole();

            if (!string.IsNullOrEmpty(path))
            {
                path = CheckThe(path);
            }
            return path;
        }

        private string CheckThe(string path)
        {
            while (!File.Exists(path))
            {
                path = ReadPathFromConsole();
            }
            return path;
        }
             
        private string ReadPathFromConsole()
        {
            Console.Write("Введите путь к файлу: ");
            return Console.ReadLine();
        }

        private string [] GetDataFromFileBy(string path)
        {
            List<string> textByLines = new List<string>();

            using (StreamReader file = new StreamReader(path))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    textByLines.Add(line);
                }
                file.Close();
            }

            string[] resultArray = new string[textByLines.Count];
                                   
            for(int i = 0; i<textByLines.Count;i++)
            {
                resultArray[i] = textByLines[i].ToString() + " = " + StringToFormulaAdapter.CheckAnswerOf(textByLines[i]);
            }

            return resultArray;
            
        }

        private void WriteToFile(string [] resultArray, string path)
        {
            var pathOfResult = CreateNewPathFrom(path);

            File.WriteAllLines(pathOfResult, resultArray);
        }

        private string CreateNewPathFrom(string path)
        {
            StringBuilder temPath = new StringBuilder(path);
            
            return temPath.Insert(path.Length - 4, "_calculation_result").ToString();
                     
        }
    }
}
