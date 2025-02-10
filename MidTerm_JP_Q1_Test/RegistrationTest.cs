using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MidTerm_JP_Q1;
using System.Runtime.Remoting.Messaging;
using NUnit.Framework.Constraints;
using System.Text.RegularExpressions;

namespace MidTerm_JP_Q1_Test
{
    [TestFixture]
    public class RegistrationTest
    {
        

        [Test]
        public void ValidName_InputJoy_OutputValidName()
        {
            Registration registration=new Registration();
            string validName = "Joy";

            string actual = registration.RegisterName(validName);

            Assert.That(validName, Is.EqualTo(actual));
        }


        


        [Test]
        public void ValidAge_Input45_OutputValidAge()
        {
            Registration registration = new Registration();
            int validAge = 45;

            int actual = registration.RegisterAge(validAge);

            Assert.That(validAge, Is.EqualTo(actual));
        }

        

        [Test]
        public void ValidGroupSize_Input15_OutputValidGroupSize()
        {
            Registration registration = new Registration();
            int validGroupSize = 15;

            int actual = registration.RegisterGroupSize(validGroupSize);

            Assert.That(validGroupSize, Is.EqualTo(actual));
        }

        [Test]
        public void InValidName_InputEmptyString_OutputErrorInvalidName()
        {
            Registration registration = new Registration();
            string validName = "";
            string expected = "Name cannot be null or empty.";

            var actual = Assert.Throws<InvalidOperationException>(() => registration.RegisterName(validName));

            Assert.That(actual.Message, Is.EqualTo(expected));
        }
        [Test]
        public void InValidAge_InputMinus18_OutputInValidAge()
        {
            Registration registration = new Registration();
            int invalidAge = -18;

            string expected = "Age cannot be negative.";

            var actual = Assert.Throws<InvalidOperationException>(() => registration.RegisterAge(invalidAge));

            Assert.That(actual.Message, Is.EqualTo(expected));
        }

        [Test]
        public void InValidGroupSize_Input0_OutputInValidGroupSize()
        {
            Registration registration = new Registration();
            int invalidGroupSize = 15;

            string expected = "Group size must be greater than zero.";

            var actual = Assert.Throws<InvalidOperationException>(() => registration.RegisterGroupSize(invalidGroupSize));

            Assert.That(actual.Message, Is.EqualTo(expected));
        }











    }
}
