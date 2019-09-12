using Microsoft.VisualStudio.TestTools.UnitTesting;
using Praxis.Main;
using Praxis.Main.Tasks;

namespace Praxis.UnitTest
{
    [TestClass]
    public class ThirdBlockTests
    {
        [TestMethod]
        public void Test1209()
        {
            var task = Constants.Tasks[1209];
            Assert.AreEqual(TaskBlock.Task1209(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1225()
        {
            var task = Constants.Tasks[1225];
            Assert.AreEqual(TaskBlock.Task1225(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1226()
        {
            var task = Constants.Tasks[1226];
            Assert.AreEqual(TaskBlock.Task1226(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1243()
        {
            var task = Constants.Tasks[1243];
            Assert.AreEqual(TaskBlock.Task1243(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1263()
        {
            var task = Constants.Tasks[1263];
            Assert.AreEqual(TaskBlock.Task1263(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1264()
        {
            var task = Constants.Tasks[1264];
            Assert.AreEqual(TaskBlock.Task1264(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1293()
        {
            var task = Constants.Tasks[1293];
            Assert.AreEqual(TaskBlock.Task1293(task.Item1), task.Item2);
        }
    }
}