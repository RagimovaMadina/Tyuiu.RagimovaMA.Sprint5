using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RagimovaMA.Sprint5.Task5.V24.Lib
{
    public class DataService : ISprint5Task5V24
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double x = Convert.ToDouble(line);
                    if (((Math.Truncate(x)) % 100 == x) && (9 < x) && (x < 100))
                    {
                        res += x;
                    }
                }
            }
            return res;
        }
    }
}
