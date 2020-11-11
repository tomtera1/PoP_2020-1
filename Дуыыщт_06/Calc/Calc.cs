using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_06.Calculator
{
    public class Calculator
    {
        public float ValueA { get; set; }

        public float ValueB { get; set; }

        public string Operation { get; set; }

        public string Calculate()
        {
            double calcResult = 0;

            switch (Operation)
            {
                case "+":
                    calcResult = ValueA + ValueB;
                    break;

                case "/":
                    if (ValueB == 0)
                    {
                        throw new DivideByZeroException("Value B cannot be 0.");
                    }
                    calcResult = ValueA / ValueB;
                    break;

                default:

                    return "Unknown operation";
            }

            return $"{ValueA} {Operation} {ValueB} = {calcResult}";
        }
    }
}