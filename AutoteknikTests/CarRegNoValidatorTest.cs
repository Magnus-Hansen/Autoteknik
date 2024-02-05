using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik.Tests
{
    [TestClass]
    public class CarRegNoValidatorTest
    {
        [TestMethod]
        public void Test_CarRegNoValidator_IsValid()
        {
            // Arrange
            IValidator carValidator = new CarRegNoValidator();
            string gyldigtRegistreringsnummer = "AB12546";

            // Act
            bool resultat = carValidator.Validate(gyldigtRegistreringsnummer);

            // Assert
            Assert.IsTrue(resultat);
        }

        [TestMethod]
        public void Test_CarRegNoValidator_IsInValid()
        {
            IValidator carValidator = new CarRegNoValidator();
            string ugyldigtRegistreringsnummer = "Lute";

            // Act
            bool resultat = carValidator.Validate(ugyldigtRegistreringsnummer);

            // Assert
            Assert.IsFalse(resultat);
        }
    }
}
