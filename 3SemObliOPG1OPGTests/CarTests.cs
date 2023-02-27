using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3SemObliOPG1OPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SemObliOPG1OPG.Tests
{
        [TestClass()]
        public class CarTests
        {
            private Car DenOptimaleBil = new() { Id = 1, Model = "FantasiModel", Licenseplate = "BA3336", Price = 100 };
            private Car DenFejlerModelBil = new() { Id = 2, Model = "UIO", Licenseplate = "BA3336", Price = 100 };
            private Car DenFejlerPrisBil = new() { Id = 3, Model = "FantasiModelV2", Licenseplate = "BA3336", Price = -100 };
            private Car DenFejlerNummerPladeBil = new() { Id = 4, Model = "FantasiModelV3", Licenseplate = "B", Price = 100 };

            [TestMethod()]
            public void ToStringTest()
            {
                string str = DenOptimaleBil.ToString();
                Assert.AreEqual("1 FantasiModel 100 BA3336", str);
            }


            [TestMethod()]
            public void ModelValideringTest()
            {
                DenOptimaleBil.ModelValidering();
                Assert.ThrowsException<ArgumentException>(() => DenFejlerModelBil.ModelValidering());
            }

            [TestMethod()]
            public void PriceValideringTest()
            {
                DenOptimaleBil.PriceValidering();
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => DenFejlerPrisBil.PriceValidering());
            }

            [TestMethod()]
            public void LicensePlateValideringTest()
            {
                DenOptimaleBil.LicensePlateValidering();
                Assert.ThrowsException<ArgumentException>(() => DenFejlerNummerPladeBil.LicensePlateValidering());
            }

            [TestMethod()]
            public void ValidateTest()
            {
                DenOptimaleBil.Validate();
                Assert.ThrowsException<ArgumentException>(() => DenFejlerModelBil.ModelValidering());
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => DenFejlerPrisBil.PriceValidering());
                Assert.ThrowsException<ArgumentException>(() => DenFejlerNummerPladeBil.LicensePlateValidering());
            }
        }
}