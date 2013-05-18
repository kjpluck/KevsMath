using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevsMath
{
    public class MovingAverage
    {
        private int subSetSize = 1;
        private List<double> list;

        public MovingAverage()
        {
            list = new List<double>();
        }

        public MovingAverage(int subSetSize)
            : this()
        {
            this.subSetSize = subSetSize;
        }

        public void add(double item)
        {
            list.Add(item);
            if (list.Count > subSetSize) list.RemoveRange(0, 1);
        }

        public void setSubSetSize(int n)
        {
            subSetSize = n;
        }

        public double calculate()
        {
            if (list.Count == 0) return 0;

            double sum = 0;

            foreach (double item in list)
            {
                sum += item;
            }

            return sum / list.Count;
        }
    }
}
