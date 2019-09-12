using Microsoft.VisualStudio.TestTools.UnitTesting;
using Praxis.Main;
using Praxis.Main.Tasks;

namespace Praxis.UnitTest
{
    [TestClass]
    public class EighthBlockTests
    {
        [TestMethod]
        public void Test1700()
        {
            var task = Constants.Tasks[1700];
            Assert.AreEqual(TaskBlock.Task1700(task.Item1), task.Item2);
        }
    }
}