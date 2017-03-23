using System.Collections.Generic;
using NUnit.Framework;
using Parser.DAL;
using Parser.Implementations;

namespace Parser.Integration.Tests
{
    [TestFixture]
    public class LiquidBLLTest
    {
        [Test]
        public void CreateLiquid()
        {
            var repository = new Repository();
            var liquidBLL = new LiquidBLL(repository);
            var liquid = liquidBLL.CreateNew(555, true, false, "http://ya.ru", "somename", true, 3200,
                new List<double>() {1.5, 2}, new List<int>() {10, 30});
            var result = repository.GetLiquidByGuid(liquid.Id);
        }
    }
}
