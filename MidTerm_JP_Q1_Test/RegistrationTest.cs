using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MidTerm_JP_Q1;
using System.Runtime.Remoting.Messaging;
using NUnit.Framework.Constraints;

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
        public void InvalidName_InputEmptyStringName_OutputError()
        {
            Registration registration = new Registration();
            string validName = "";

            var actual = Assert.Throws<ArgumentException>(() => registration.RegisterName(validName));

            Assert.That(validName, Is.EqualTo(actual.ToString()));
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











    }
}
