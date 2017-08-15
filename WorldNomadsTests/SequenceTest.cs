using System;
using WorldNomads.Helpers;
using Xunit;

namespace WorldNomadsTests
{
    public class SequenceTest
    {
        [Fact]
        public void All_numbers_count_should_match_the_passed_number()
        {
            int number = 5;
            var response = NumericSequenceHelper.GenerateNumericSequence(number);
            Assert.Equal(response.AllNumbers.Count,number);
        }

        [Fact]
        public void Odd_numbers_count()
        {
            int number = 5;
            int oddNumberCount = 3; // 1,3,5
            var response = NumericSequenceHelper.GenerateNumericSequence(number);
            Assert.Equal(response.OddNumbers.Count, oddNumberCount);
        }

        [Fact]
        public void Even_numbers_count()
        {
            int number = 5;
            int evenNumberCount = 2; // 2,4
            var response = NumericSequenceHelper.GenerateNumericSequence(number);
            Assert.Equal(response.EvenNumbers.Count, evenNumberCount);
        }

        [Fact]
        public void All_numbers_except_count()
        {
            int number = 5;
            var response = NumericSequenceHelper.GenerateNumericSequence(number);
            Assert.Equal(response.AllNumbersExcept.Count,number);
        }

        [Fact]
        public void All_numbers_except_contains_letters()
        {
            int number = 15;
            var response = NumericSequenceHelper.GenerateNumericSequence(number);
            Assert.True(response.AllNumbersExcept.Contains("C"));
            Assert.True(response.AllNumbersExcept.Contains("E"));
            Assert.True(response.AllNumbersExcept.Contains("Z"));
        }
    }
}
