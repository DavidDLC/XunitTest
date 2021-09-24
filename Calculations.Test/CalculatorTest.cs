﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Test
{
    public class CalculatorFixture
    {
        public Calculator calc => new Calculator();
    }
    public class CalculatorTest : IClassFixture<CalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CalculatorFixture _calculatorFixture;
        private readonly MemoryStream memoryStream;

        public CalculatorTest(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculatorFixture = calculatorFixture;
            _testOutputHelper.WriteLine("constructor");

            memoryStream = new MemoryStream();
        }
        [Fact]
        public void Add_givenTwoIntValues()
        {
            //arrange
            var cal = new Calculator();

            //act
            var result = cal.Add(1, 1);

            //asserts
            Assert.Equal(2, result);
        }

        [Fact]
        public void Add_givenTwoDoubleValues_ReturnsDouble()
        {
            //arrange
            var cal = new Calculator();

            //act
            var result = cal.AddDouble(1.2, 3.5);

            //asserts
            Assert.Equal(4.7, result, 1);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            var cal = new Calculator();

            Assert.All(cal.FiboNumbers, n => Assert.NotEqual(0, n)); // collections
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboInclude13()
        {
            var cal = new Calculator();

            Assert.Contains(13, cal.FiboNumbers); //collectins
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotInclude4()
        {
            var cal = new Calculator();
            Assert.DoesNotContain(4, cal.FiboNumbers); //collections
        }

        [Fact]
        public void CheckCollection()
        {
            var exprectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            var cal = new Calculator();

            Assert.Equal(exprectedCollection, cal.FiboNumbers);

        }
    }
}
