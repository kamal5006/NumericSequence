using System.Collections.Generic;

namespace WorldNomads.ViewModels
{
    public class NumericSequenceResponse
    {
        public NumericSequenceResponse()
        {
            AllNumbers = new List<int>();
            OddNumbers = new List<int>();
            EvenNumbers = new List<int>();
            AllNumbersExcept = new List<string>();
            FibonacciNumbers = new List<int>();

        }
        public IList<int> AllNumbers { get; set; }
        public IList<int> OddNumbers { get; set; }
        public IList<int> EvenNumbers { get; set; }
        public IList<string> AllNumbersExcept { get; set; }
        public IList<int> FibonacciNumbers { get; set; }

    }
}