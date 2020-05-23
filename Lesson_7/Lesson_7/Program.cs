using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lesson_6;

namespace Lesson_7
{
    public class Program
    {
        #region Task 1
        public delegate double MyDel1(int[] a);

        public static MyDel1 myDelegate1 = delegate (int[] a)
        {
            int sum = 0;
            double result = 0;
            for (int i = 0; i < a.Length; i++)
                sum += i;
            result = (sum * 1.0) / a.Length;
            return result;
        };
        #endregion

        #region Task 2
        public delegate int MyDel2(int x, int y, string oper);

        public static MyDel2 myDelegate2 = delegate (int x, int y, string oper)
        {
            switch (oper)
            {
                case "+": return x + y;
                case "-": return x - y;
                default: Console.WriteLine("Введён неверный оператор"); return int.MinValue+1;
            }
            
        };
        #endregion

        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.UserAdded += delegate
            {
                if (computer.UserList.Contains("admin"))
                    computer.UserList.Remove("admin");
            };
            computer.InvokeEvents();
        }
    }
}
