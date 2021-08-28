using System;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string Transform(int input)
        {
            StringBuilder sb =  new StringBuilder();
            if (input % 3 == 0)
                sb.Append("Fizz");
            if (input % 5 == 0)
                sb.Append("Buzz");
            return sb.Length > 0 ? sb.ToString() : input.ToString();
        }
    }
}
