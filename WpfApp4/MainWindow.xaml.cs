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

namespace LabWpfApp4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateE = Convert.ToDouble(rate1.Text);
            double sumE = Convert.ToDouble(sum1.Text);
            double resE = rateE * sumE;
            resSum1.Text = resE.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateG = Convert.ToDouble(rate2.Text);
            double sumG = Convert.ToDouble(sum2.Text);
            double resG = rateG * sumG;
            resSum2.Text = resG.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateD = Convert.ToDouble(rate3.Text);
            double sumD = Convert.ToDouble(sum3.Text);
            double resD = rateD * sumD;
            resSum3.Text = resD.ToString();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double rateDuim = Convert.ToDouble(r.Text);
            double resDuim = rateDuim * 0.0254;
            res.Text = resDuim.ToString();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double ratF = Convert.ToDouble(r1.Text);
            double resF = ratF * 0.305;
            res1.Text = resF.ToString();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double ratM = Convert.ToDouble(r2.Text);
            double resM = ratM * 1609.344;
            res2.Text = resM.ToString();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double ratV = Convert.ToDouble(r3.Text);
            double resV = ratV * 1066.8;
            res3.Text = resV.ToString();
        }
    }
}