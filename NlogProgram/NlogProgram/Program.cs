using System;
using NLog;

namespace NlogProgram
{
    class Program
    {
        public class NLog
        {
            private static readonly Logger logger = LogManager.GetCurrentClassLogger();
            public void LogDebug(string message)
            {
                logger.Debug(message);
            }
            public void LogError(string message)
            {
                logger.Error(message);
            }
            public void LogInfo(string message)
            {
                logger.Info(message);
            }
            public void LogWarn(string message)
            {
                logger.Warn(message);
            }

        }

        public class AddNumbers
        {
            private readonly NLog nLog = new NLog();

            public int Sum(int firstNumber, int secondNumber)
            {
                { if (firstNumber == 0 || secondNumber == 0)
                {
                    nLog.LogDebug("Debug Unsuccessfull : Sum()");
                    nLog.LogError("Expecting Null values");
                    nLog.LogWarn("firstNumber or secondNumber should not equal to 0");
                }
                int result = firstNumber + secondNumber;
                nLog.LogDebug("Debug Successfull : Sum()");
                nLog.LogInfo("Sum Method Passed, Result :" + result);
                return result;
                    }
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Enter the Firstnum: ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Secondnum: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                AddNumbers add = new AddNumbers();

                Console.WriteLine("\nThe sum of two numbers is :" + " " + add.Sum(n1, n2));
            }  
        }
    }
}
