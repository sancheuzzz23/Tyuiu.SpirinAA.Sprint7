using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.SpirinAA.Sprint7.Project.V1.Lib
{
    public class DataService
    {
        public string[,] LoadFromFileData(string filePath)
        {
            string fileDta = File.ReadAllText(filePath);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows, cols;
            rows = lines.Length;
            cols = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    arrayValues[i, j] = Convert.ToString(line_r[j]);
                }
            }
            return arrayValues;
        }
        public double SummEnergy(double[] array)
        {
            double res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                res = res + array[i];
            }
            return Math.Round(res, 3);
        }

        public double MinEnergy(double[] array)
        {
            double res = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < res)
                {
                    res = array[i];
                }
            }
            return Math.Round(res, 3);
        }

        public double MaxEnergy(double[] array)
        {
            double res = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > res)
                {
                    res = array[i];
                }
            }
            return Math.Round(res, 3);
        }

        public double AverageValue(double[] array)
        {
            double res = 0;
            double result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                res = res + array[i];
            }
            result = res / array.Length;
            return Math.Round(result, 3);
        }

        public int CountDocument(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count++;
            }
            return count;
        }
    }
}
