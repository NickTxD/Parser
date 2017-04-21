using System;
using System.Collections.Generic;
using NUnit.Framework;
using Parser.BLL;
using Parser.BLL.Implementations;
using Parser.DAL;

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

        [Test]
        public void Parse()
        {
            var repository = new Repository();
            var liquidBLL = new LiquidBLL(repository);
            var liquids = liquidBLL.GetAll();
            int x = 5;
        }
    }
}
