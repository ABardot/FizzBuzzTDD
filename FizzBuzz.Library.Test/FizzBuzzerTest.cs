using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library.Test
{
    [TestFixture]
    public class FizzBuzzerTest
    {

        //[Test]
        //public void Buzzer_When1_Returns1()
        //{
        //    // Arrange
        //    int input = 1;

        //    // Act
        //    string output = FizzBuzzer.GetValue(input);

        //    // Assert
        //    Assert.AreEqual("1", output);
        //}

        [Test]
        public void Buzzer_WhenDefualt_ReturnsInput([Values(1, 2, 4)]int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_When3_ReturnsFizz()
        {
            int input = 3;
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_When5_ReturnsBuzz()
        {
            int input = 5;
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

    }
}
