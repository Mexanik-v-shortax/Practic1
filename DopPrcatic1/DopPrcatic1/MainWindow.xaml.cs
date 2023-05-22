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

namespace DopPrcatic1
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

            int a1 = Convert.ToInt32(TbNumberA1.Text);
            int b1 = Convert.ToInt32(TbNumberB1.Text);
            int c1 = Convert.ToInt32(TbNumberC1.Text);
            int a2 = Convert.ToInt32(TbNumberA2.Text);
            int b2 = Convert.ToInt32(TbNumberB2.Text);
            int c2 = Convert.ToInt32(TbNumberC2.Text);
            int D = a1 * b2 - a2 * b1;
            double x = (c1 * b2 - c2 * b1) / D;
            double y = (a1 * c2 - a2 * c1) / D;
            TextBlockAnswer.Text = $"x = {x}\ny = {y}\nD = {D}";





        }
    }
}
