using Microsoft.VisualStudio.TestTools.UnitTesting;
using Praxis.Main;
using Praxis.Main.Tasks;

namespace Praxis.UnitTest
{
    [TestClass]
    public class FourthBlockTests
    {
        [TestMethod]
        public void Test1313()
        {
            var task = Constants.Tasks[1313];
            Assert.AreEqual(TaskBlock.Task1313(task.Item1), task.Item2);
        }

        [TestMethod]
        public void Test1319()
        {
            var task = Constants.Tasks[1319];
            Assert.AreEqual(TaskBlock.Task1319(task.Item1), task.Item2);
        }
    }
}