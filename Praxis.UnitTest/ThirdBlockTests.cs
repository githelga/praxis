using Microsoft.VisualStudio.TestTools.UnitTesting;
using Praxis.Main;
using Praxis.Main.Tasks;

namespace Praxis.UnitTest
{
    [TestClass]
    public class ThirdBlockTests
    {
        [TestMethod]
        public void Test1293()
        {
            var task = Constants.Tasks[1293];
            Assert.AreEqual(TaskBlock.Task1293(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test2001()
        {
            var task = Constants.Tasks[2001];
            Assert.AreEqual(TaskBlock.Task2001(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test2012()
        {
            var task = Constants.Tasks[2012];
            Assert.AreEqual(TaskBlock.Task2012(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test2056()
        {
            var task = Constants.Tasks[2056];
            Assert.AreEqual(TaskBlock.Task2056(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test2066()
        {
            var task = Constants.Tasks[2066];
            Assert.AreEqual(TaskBlock.Task2066(task.Item1), task.Item2);
        }
    }
}