using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Unleisure;

namespace UnlesisureUnitTest
{
    [TestClass]
    public class InFixToPostFixTest
    {
        [TestMethod]
        public void PostFixCalculationTest()
        {
            List<string> postFix = new List<string>()
            { "1", "2", "+", "3", "*", "6", "+", "2", "3", "+", "/" };
            var infixToPostFix = new InfixToPostFix();
            Console.WriteLine(infixToPostFix.Calculate(postFix));
            postFix = new List<string>()
            { "5", "1", "2", "+", "4", "*", "+","3", "-"};
            Console.WriteLine(infixToPostFix.Calculate(postFix));
        }
        [TestMethod]
        public void PostFixConversionTest()
        {
            List<string> inFix = new List<string>()
            { "(", "1", "+", "2", ")", "*", "3"};
            var infixToPostFix = new InfixToPostFix();
            List<string> postFix = infixToPostFix.ConvertToPostFix(inFix);
            Console.WriteLine(String.Join(" " , infixToPostFix.Calculate(postFix)));

            inFix = new List<string>()
            { "(", "(", "(" , "1", "+","2",")","*","3",")","+","6",")","/","(","2","+","3",")"};
            postFix = infixToPostFix.ConvertToPostFix(inFix);
            Console.WriteLine(String.Join(" ", infixToPostFix.Calculate(postFix)));
        }
    }
}
