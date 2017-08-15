using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldNomads.ViewModels;

namespace WorldNomads.Helpers
{
    public static class NumericSequenceHelper
    {
        public static NumericSequenceResponse GenerateNumericSequence(int number)
        {
            NumericSequenceResponse numericSequenceResponse = new NumericSequenceResponse();
            numericSequenceResponse.FibonacciNumbers.Add(0);
            numericSequenceResponse.FibonacciNumbers.Add(1);
            int[] fibonacci = GenerateFibonacci(number + 2);

            for (int i = 1; i <= number; i++)
            {
                numericSequenceResponse.AllNumbers.Add(i);
                if (i % 2 == 1)
                {
                    numericSequenceResponse.OddNumbers.Add(i);
                }
                else
                {
                    numericSequenceResponse.EvenNumbers.Add(i);
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    numericSequenceResponse.AllNumbersExcept.Add("Z");
                }
                else if (i % 3 == 0)
                {
                    numericSequenceResponse.AllNumbersExcept.Add("C");
                }
                else if (i % 5 == 0)
                {
                    numericSequenceResponse.AllNumbersExcept.Add("E");
                }
                else
                {
                    numericSequenceResponse.AllNumbersExcept.Add(i.ToString());
                }

                if (fibonacci.Contains(i))
                {
                    numericSequenceResponse.FibonacciNumbers.Add(i);
                }
            }
            return numericSequenceResponse;
        }

        private static int[] GenerateFibonacci(int number)
        {
            List<int> result = new List<int>();
            int firstNumber = 0, secondNumber = 1;
            for (int i = 0; i <= number; i++)
            {
                result.Add(firstNumber);
                var fibResult = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = fibResult;
            }

            return result.ToArray();

        }
    }
}
