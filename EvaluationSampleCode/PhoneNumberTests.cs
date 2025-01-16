using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationSampleCode;
using System;

namespace EvaluationSampleCodeTests
{
    [TestClass]
    public class PhoneNumberTests
    {
        [TestMethod]
        public void Parse_ValidPhoneNumber_ReturnsPhoneNumberInstance()
        {

            string phoneNumber = "0123456789";

           
            var result = PhoneNumber.Parse(phoneNumber);

           
            Assert.IsNotNull(result);
            Assert.AreEqual("012", result.Area);
            Assert.AreEqual("345", result.Major);
            Assert.AreEqual("6789", result.Minor);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Parse_EmptyPhoneNumber_ThrowsArgumentException()
        {
         
            string phoneNumber = "";

         
            PhoneNumber.Parse(phoneNumber);

       
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Parse_InvalidLengthPhoneNumber_ThrowsArgumentException()
        {
            string phoneNumber = "123";
            PhoneNumber.Parse(phoneNumber);
        }

        [TestMethod]
        public void ToString_ValidPhoneNumber_ReturnsFormattedString()
        {
       
            string phoneNumber = "0123456789";
            var result = PhoneNumber.Parse(phoneNumber);

     
            string formattedNumber = result.ToString();

            Assert.AreEqual("(012)345-6789", formattedNumber);
        }
    }
}
