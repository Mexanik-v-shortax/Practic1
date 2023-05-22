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

namespace Zadanie4Practic1
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
            double y, y1;
            double a = Convert.ToDouble(TbNumberA.Text);
            double b = Convert.ToDouble(TbNumberB.Text);
            double x = Convert.ToDouble(TbNumberC.Text);
            y = Math.Pow(-a, 5) * x + Math.Pow(Math.Cos(Math.Pow(x, 2)), 4) + b * x;
            y1 = (Math.Sqrt(Math.Abs(-a * x + y))) / (Math.Log(Math.Abs(x + y * y)));
            TextBlockAnswer.Text = $"{y1}";




        }
    }
}
