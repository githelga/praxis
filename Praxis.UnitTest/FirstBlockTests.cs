using Microsoft.VisualStudio.TestTools.UnitTesting;
using Praxis.Main;
using Praxis.Main.Tasks;

namespace Praxis.UnitTest
{
    [TestClass]
    public class FirstBlockTests
    {
        [TestMethod]
        public void Test1000()
        {
            var task = Constants.Tasks[1000];
            Assert.AreEqual(TaskBlock.Task1000(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1001()
        {
            var task = Constants.Tasks[1001];
            Assert.AreEqual(TaskBlock.Task1001(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1002()
        {
            var task = Constants.Tasks[1002];
            Assert.AreEqual(TaskBlock.Task1002(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1003()
        {
            var task = Constants.Tasks[1003];
            Assert.AreEqual(TaskBlock.Task1003(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1004()
        {
            var task = Constants.Tasks[1004];
            Assert.AreEqual(TaskBlock.Task1004(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1005()
        {
            var task = Constants.Tasks[1005];
            Assert.AreEqual(TaskBlock.Task1005(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1068()
        {
            var task = Constants.Tasks[1068];
            Assert.AreEqual(TaskBlock.Task1068(task.Item1), task.Item2);
        }
    }
}
