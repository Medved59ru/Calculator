using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class StringToFormulaAdapter 
    {
        public static string CheckAnswerOf(string formula)
        {
            StringToFormula expression = new StringToFormula();
            double result;
            string stringResult;

            try
            {
                result = expression.Eval(formula);
                if (Double.IsInfinity(result))
                {
                    stringResult = " ОШИБКА ДЕЛЕНИЕ НА НОЛЬ ";
                }
                else
                {
                    stringResult = result.ToString();
                }


            }
            catch
            {
                stringResult = " ОШИБКА ";
            }
            return stringResult;
        }

    }
}
