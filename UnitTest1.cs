using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace Tester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> expected = new List<string>();
            var expectedResult = File.ReadAllLines("sorted-names-list.txt");
            foreach(string line in expectedResult)
            {
                expected.Add(line);
            }
            var testResult = NameSorter.Sorts();

            for(int x=0; x < testResult.Count; x++)
            {
                Assert.AreEqual(testResult[x], expected[x], false, "Result is Equal");
            }

        }
    }
}