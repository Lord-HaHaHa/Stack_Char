using System.Diagnostics;

namespace Stack_Char
{
    public partial class MainWindow
    {
        public class Stack
        {
            // Attribute
            private char[] Elemente;

            private int Max = 0;
            private int CurrLength = 0;

            // Konstruktor
            public Stack(int length)
            {
                Elemente = new char[length];
                Max = length;
            }

            //Methoden
            public bool IsEmpty()
            {
                if(CurrLength == 0)
                    return true;
                return false;
            }

            public bool Push(char value)
            {
                if (CurrLength < Max)
                {
                    Elemente[CurrLength++] = value;
                }
                if (CurrLength == Max)
                    return false;
                return true;
            }

            public char Pop()
            {
                char Char;
                if (CurrLength == 0)
                    return ' ';
                CurrLength--;
                Char = Elemente[CurrLength];
                Elemente[CurrLength] = ' ';
                return Char;
            }
        }
    }
}
