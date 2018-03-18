using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Diagnostics;
using Solution.Timer;

namespace Tasks.Tests.Task3Tests
{
    [TestFixture]
    class GetLeadTimeFindNextBiggerNumberTest
    {
        [Test]
        [TestCase(1234321)]
        [TestCase(1234126)]
        [TestCase(3456432)]
        public void GetLeadTime_FindNextBiggerNumberTest(int number)
        {
            Stopwatch timeLead;

            timeLead = Timer.GetLeadTimeFindNextBiggerNumber(number);

            Assert.Pass($"Time taked for executing : { timeLead.Elapsed.ToString()}");
        }
    }
}