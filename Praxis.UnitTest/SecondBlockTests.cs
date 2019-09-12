using Microsoft.VisualStudio.TestTools.UnitTesting;
using Praxis.Main;
using Praxis.Main.Tasks;

namespace Praxis.UnitTest
{
    [TestClass]
    public class SecondBlockTests
    {
        [TestMethod]
        public void Test1100()
        {
            var task = Constants.Tasks[1100];
            Assert.AreEqual(TaskBlock.Task1100(task.Item1), task.Item2);
        }
    }
}