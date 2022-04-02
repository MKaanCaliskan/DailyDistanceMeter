using BilgeAdam.DailyRunningMeter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectKosuOlcer
{
    [TestFixture]
    internal class CalculateRunningDistance
    {
        [TestCase(5, 30, 90, 135)]
        [TestCase(40, 20, 195, 1560)]
        [TestCase(20, 47, 70, 658)]

        public void Calculate_distance_tree_variable(int stepSizeCm, int stepNumber, int timeTotalMinute, double expected)
        {
            var sample = Program.CalculateDistance(stepSizeCm, stepNumber, timeTotalMinute);
            Assert.AreEqual(sample, expected);
        }
    }
}
