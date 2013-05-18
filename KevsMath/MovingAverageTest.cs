using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KevsMath
{
    using NUnit.Framework;
    [TestFixture]
    class MovingAverageTest
    {
        MovingAverage movingAverage;
        [SetUp]
        public void init()
        {
            movingAverage = new MovingAverage();
        }

        [TestCase(3, new double[] { 1, 2, 3 }, Result = 2)]
        [TestCase(3, new double[] { 2, 3, 4 }, Result = 3)]
        [TestCase(3, new double[] { 1, 2, 3, 4 }, Result = 3)]
        [TestCase(3, new double[] { 3, 4 }, Result = 3.5)]
        public double testMovingAverage(int n, double[] list)
        {
            movingAverage.setSubSetSize(n);

            addItemsToMovingAverage(list);

            return movingAverage.calculate();
        }


        [TestCase(new double[] { 1, 2, 3, 4 }, Result = 3)]
        public double testMovingAverageWithSubSetSizeSetInConstructor(double[] list)
        {
            movingAverage = new MovingAverage(3);
            addItemsToMovingAverage(list);
            return movingAverage.calculate();
        }

        [TestCase(3, new double[] { }, Result = 0)]
        public double testMovingAverageWithEmptyList(int n, double[] list)
        {
            movingAverage.setSubSetSize(n);
            addItemsToMovingAverage(list);
            return movingAverage.calculate();
        }

        [TestCase(0, new double[] {1,2,3 }, Result = 0)]
        public double testMovingAverageWith0SubSetSize(int n, double[] list)
        {
            movingAverage.setSubSetSize(n);
            addItemsToMovingAverage(list);
            return movingAverage.calculate();
        }

        private void addItemsToMovingAverage(double[] list)
        {
            foreach (var item in list)
            {
                movingAverage.add(item);
            }
        }
    }
}
