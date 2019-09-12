using Microsoft.VisualStudio.TestTools.UnitTesting;
using Praxis.Main;
using Praxis.Main.Tasks;

namespace Praxis.UnitTest
{
    [TestClass]
    public class TwelvethBlockTests
    {
        [TestMethod]
        public void Test2100()
        {
            var task = Constants.Tasks[2100];
            Assert.AreEqual(TaskBlock.Task2100(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test2101()
        {
            var task = Constants.Tasks[2101];
            Assert.AreEqual(TaskBlock.Task2101(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test2102()
        {
            var task = Constants.Tasks[2102];
            Assert.AreEqual(TaskBlock.Task2102(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test2103()
        {
            var task = Constants.Tasks[2103];
            Assert.AreEqual(TaskBlock.Task2103(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test2104()
        {
            var task = Constants.Tasks[2104];
            Assert.AreEqual(TaskBlock.Task2104(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test2105()
        {
            var task = Constants.Tasks[2105];
            Assert.AreEqual(TaskBlock.Task2105(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test2106()
        {
            var task = Constants.Tasks[2106];
            Assert.AreEqual(TaskBlock.Task2106(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test2107()
        {
            var task = Constants.Tasks[2107];
            Assert.AreEqual(TaskBlock.Task2107(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test2108()
        {
            var task = Constants.Tasks[2108];
            Assert.AreEqual(TaskBlock.Task2108(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test2109()
        {
            var task = Constants.Tasks[2109];
            Assert.AreEqual(TaskBlock.Task2109(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test2110()
        {
            var task = Constants.Tasks[2110];
            Assert.AreEqual(TaskBlock.Task2110(task.Item1), task.Item2);
        }
    }
}
