using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChugunovEM.Sprint0.Tusk2.V0.Lib;

namespace Tyuiu.ChugunovEM.Sprint0.Tusk2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            //Область создания методов тестирования, методов из библиотеки
            var name = "Егор";
            var res = Lib.DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Егор", res);
        }
    }
}
