using System;
using System.Collections.Generic;
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

namespace Zadanie3Practic1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void BtnOK_Click(object sender, EventArgs e)
        {

            double x1, x2;
            Console.WriteLine("a=");
            double a = Convert.ToDouble(TbNumberA.Text);
            Console.WriteLine("b=");
            double b = Convert.ToDouble(TbNumberB.Text);
            Console.WriteLine("c=");
            double c = Convert.ToDouble(TbNumberC.Text);
            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                if (x1 > x2) { TextBlockAnswer.Text = ($"x2={x2},x1={x1}"); }
                else if (x2 > x1) { TextBlockAnswer.Text = ($"x1={x1},x2={x2}"); }
                else { TextBlockAnswer.Text = ($"корни равны {x1}"); }
            }

            else { TextBlockAnswer.Text = "дискриминант отрицательный"; }



        }
    }
}
