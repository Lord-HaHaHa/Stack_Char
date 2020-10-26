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
            stack.Push();
        }

        private void btn_Pop_Click(object sender, RoutedEventArgs e)
        {
            stack.Pop();
        }
        public class Stack
        {

            char[] elemente;

            public Stack(int length)
            {
                elemente = new char[length];
            }

            public bool Push()
            {
                return true;
            }
            public string Pop()
            {
                return  "";
            }
        }
    }
}
