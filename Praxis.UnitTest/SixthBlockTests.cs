using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Praxis.Main;
using Praxis.Main.Tasks;

namespace Praxis.UnitTest
{
    [TestClass]
    public class SixthBlockTests
    {
        [TestMethod]
        public void Test1545()
        {
            var task = Constants.Tasks[1545];
            Assert.AreEqual(TaskBlock.Task1545(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1563()
        {
            var task = Constants.Tasks[1563];
            Assert.AreEqual(TaskBlock.Task1563(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1567()
        {
            var task = Constants.Tasks[1567];
            Assert.AreEqual(TaskBlock.Task1567(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1581()
        {
            var task = Constants.Tasks[1581];
            Assert.AreEqual(TaskBlock.Task1581(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1585()
        {
            var task = Constants.Tasks[1585];
            Assert.AreEqual(TaskBlock.Task1585(task.Item1), task.Item2);
        }
    }
}