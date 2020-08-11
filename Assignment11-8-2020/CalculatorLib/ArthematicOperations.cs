using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    [Serializable]
    public class ArthematicOperations
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int Add()
        {
            return num1 + num2;
        }
        public int Subtract()
        {
            return num1 - num2;
        }
        public int Multiply()
        {
            return num1 * num2;
        }
        public float Divide()
        {
            return num1 / num2;
        }
        
    }
}
