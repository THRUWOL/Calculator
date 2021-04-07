using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MyException : Exception
    {
        public string type;
    }
    public class NegativeFactorialException : MyException
    {
        public NegativeFactorialException(int x)
        {
            this.type = "NEGATIVE_FACTORIAL";
            //MessageBox.Show("Факториал(" + x + ") не существует");
            ErrorMessage errorMessage = new ErrorMessage();
            errorMessage.MessageLabel.Content = "Ошибка в работе факториала.\nФакториал(" + x + ") не существует";
            errorMessage.TypeMessage.Content = type;
            errorMessage.ShowDialog();
        }
    }
    public class TgException : MyException
    {
        public TgException(double x)
        {
            this.type = "TG_ERROR";
            //MessageBox.Show("Tg(" + x + ") не существует");
            ErrorMessage errorMessage = new ErrorMessage();
            errorMessage.MessageLabel.Content = "Ошибка в работе тангенса.\nTg(" + x + ") не существует";
            errorMessage.TypeMessage.Content = type;
            errorMessage.ShowDialog();
        }
    }
    public class SqrtException : MyException
    {
        public SqrtException(double x)
        {
            this.type = "SQRT_ERROR";
            //MessageBox.Show("Sqrt(" + x + ") не существует");
            ErrorMessage errorMessage = new ErrorMessage();
            errorMessage.MessageLabel.Content = "Ошибка в работе квадратного корня.\nSqrt(" + x + ") не существует";
            errorMessage.TypeMessage.Content = type;
            errorMessage.ShowDialog();
        }
    }
    public class DividedByZeroException : MyException
    {
        public DividedByZeroException()
        {
            this.type = "Divided_by_Zero";
            //MessageBox.Show("Деление на ноль невозможно.");
            ErrorMessage errorMessage = new ErrorMessage();
            errorMessage.MessageLabel.Content = "Деление на ноль невозможно";
            errorMessage.TypeMessage.Content = type;
            errorMessage.ShowDialog();

        }
    }
    public class LogException : MyException
    {
        public LogException(double x)
        {
            this.type = "LOG_ERROR";
            //MessageBox.Show("Log(" + x + ") не существует");
            ErrorMessage errorMessage = new ErrorMessage();
            errorMessage.MessageLabel.Content = "Ошибка в работе логарифма.\nLog(" + x + ") не существует";
            errorMessage.TypeMessage.Content = type;
            errorMessage.ShowDialog();
        }
    }
    public class SyntaxException : MyException
    {
        public SyntaxException()
        {
            this.type = "SYNTAX_ERROR";
            //MessageBox.Show("Синтаксическая ошибка. Неккоректные значение в вычислениях.");
            ErrorMessage errorMessage = new ErrorMessage();
            errorMessage.MessageLabel.Content = "Синтаксическая ошибка.\nНеккоректные значение в вычислениях";
            errorMessage.TypeMessage.Content = type;
            errorMessage.ShowDialog();
        }
    }
    public class ArcSinCosException : MyException
    {
        public ArcSinCosException(double x)
        {
            this.type = "Acos/Asin_ERROR";
            //MessageBox.Show("Acos(or Asin) (" + x + ") не существует");
            ErrorMessage errorMessage = new ErrorMessage();
            errorMessage.MessageLabel.Content = "Ошибка в работе арксинуса/арккосинуса.\nAcos(or Asin) (" + x + ") не существует";
            errorMessage.TypeMessage.Content = type;
            errorMessage.ShowDialog();
        }
    }
}
