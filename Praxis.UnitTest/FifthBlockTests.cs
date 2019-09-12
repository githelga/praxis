using Microsoft.VisualStudio.TestTools.UnitTesting;
using Praxis.Main;
using Praxis.Main.Tasks;

namespace Praxis.UnitTest
{
    [TestClass]
    public class FifthBlockTests
    {
        [TestMethod]
        public void Test1493()
        {
            var task = Constants.Tasks[1493];
            Assert.AreEqual(TaskBlock.Task1493(task.Item1), task.Item2);
        }
    }
}