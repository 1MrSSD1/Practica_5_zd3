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

namespace WpfApp36
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bustton_Click(object sender, RoutedEventArgs e)
        {
            {
                int a = int.Parse(Boxa.Text);
                int b = int.Parse(Boxb.Text);
                int x = 0;
                for (int i = a; i <= b; i++)
                {
                    x += i * i;
                }
                txtOtv.Text = $"Сумма квадратов от {a} до {b} = {x}";
            }
        }
    }
}
