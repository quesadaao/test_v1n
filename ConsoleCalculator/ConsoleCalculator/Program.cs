using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Add(int a, int b) { return a + b; }
    }

    public class Logger
    {
        public void Log(string message) { Console.WriteLine(message); }
    }

    public class Validator
    {
        public bool validateInteger(Object variable)
        {
            return (variable != null ? (variable.GetType() == typeof(int)) : false);
        }

        public Object isValid(Object variable)
        {
            Regex objNotIntPattern = new Regex("[^0-9-]");            
            if (string.IsNullOrEmpty((string)variable) || objNotIntPattern.IsMatch((string)variable))
            {
                Console.WriteLine("The value should be an integer");
                Console.WriteLine("Insert the value");
                variable = Console.ReadLine();
                return isValid(variable);
            }
            else { return variable; }
            
        }

        public void Process(int aux1, int aux2)
        {
            Calculator cal = new Calculator();
            Logger log = new Logger();
            log.Log("Result: " + cal.Add(aux1, aux2));
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");            
            Validator val = new Validator();

            Console.WriteLine("Insert the first value");
            object aux1 = (Object)Console.ReadLine();
            aux1 = val.isValid(aux1);
            Console.WriteLine("Insert the second value");
            object aux2 = Console.ReadLine();
            aux2 = val.isValid(aux2);

            val.Process(Convert.ToInt32(aux1), Convert.ToInt32(aux2));
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ReadLine();
        }

        

        
    }
}
