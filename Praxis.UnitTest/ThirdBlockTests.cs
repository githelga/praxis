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
    }
}