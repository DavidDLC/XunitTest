using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.Test
{
    public class PasswordTests
    {
        [Fact]
        public void validate_GivenLongerThan8Chars_ReturnsTrue()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = MakeString(9);
            var validationResult = testTarget.validate(password);

            Assert.True(validationResult);
        }

        [Fact]
        public void validate_GivenShorterThan8Chars_ReturnsFalse()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = MakeString(7);
            var validationResult = testTarget.validate(password);

            Assert.False(validationResult);
        }

        [Fact]
        public void validate_GivenNoUpperCase_ReturnsFalse()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = "asd";
            var validationResult = testTarget.validate(password);

            Assert.False(validationResult);
        }

        [Fact]
        public void validate_GivenUpperCase_ReturnsTrue()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = "aSd";
            var validationResult = testTarget.validate(password);

            Assert.True(validationResult);
        }

        private string MakeString(int length)
        {
            string result = string.Empty;
            for (int i = 1; i < length; i++)
            {
                result += "a";
            }

            return result;
        }
    }
}
