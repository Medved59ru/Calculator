using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class ConsoleHandler
    {        
        public string formula;
        public string stringResult;
        
        public ConsoleHandler(string userExpression)
        {
            formula = userExpression;
            stringResult = StringToFormulaAdapter.CheckAnswerOf(userExpression);
        }
     
    }
}
