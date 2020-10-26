using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Stack_Char
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack stack = new Stack(3);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Push_Click(object sender, RoutedEventArgs e)
        {
            stack.Push(txt_Push.Text.ToCharArray()[0]);
            txt_Push.Clear();
        }

        private void btn_Pop_Click(object sender, RoutedEventArgs e)
        {
            txt_Pop.Text = stack.Pop().ToString();
        }
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
                Trace.WriteLine(CurrLength);
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
                Trace.WriteLine(Elemente[CurrLength]);
                return Char;
            }
        }
    }
}
