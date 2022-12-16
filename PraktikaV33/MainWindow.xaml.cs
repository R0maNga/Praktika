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

namespace PraktikaV33
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.ResizeMode = System.Windows.ResizeMode.CanMinimize;
        }
        public void Click(object sender, RoutedEventArgs e)
        {
            Peredacha.Visibility = Visibility.Visible;
            s1.Visibility = Visibility.Visible;
            s2.Visibility = Visibility.Visible;
            s3.Visibility = Visibility.Visible;
            s4.Visibility = Visibility.Visible;
            s5.Visibility = Visibility.Visible;
            b4.Visibility = Visibility.Visible;
            b3.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Visible;
            b1.Visibility = Visibility.Visible;
            nes.Visibility = Visibility.Visible;
            per.Visibility = Visibility.Visible;
            fsk.Visibility = Visibility.Visible;
            btest.Visibility = Visibility.Visible;
            lvlqvant.Visibility = Visibility.Visible;
            kolvobit.Visibility = Visibility.Visible;
            formula.Visibility = Visibility.Visible;
            shym.Visibility = Visibility.Visible;

        }
        public void Click4(object sender, RoutedEventArgs e)
        {
            p4.Visibility = Visibility.Visible;
        }
        public void ClickTest(object sender, RoutedEventArgs e)
        {
            Test test = new Test();
            test.Show();
        }
        public void Click3(object sender, RoutedEventArgs e)
        {
            p3.Visibility = Visibility.Visible;
        }
        public void Click2(object sender, RoutedEventArgs e)
        {
            p2.Visibility = Visibility.Visible;
        }
        public void Click1(object sender, RoutedEventArgs e)
        {
            p1.Visibility = Visibility.Visible;
        }
        public void Nes(object sender, RoutedEventArgs e)
        {
            NesWindow nes = new NesWindow();
            nes.Show();
        }
        public void Per(object sender, RoutedEventArgs e)
        {
            Quant quant = new Quant();
            quant.Show();
        }
        public void Fsk(object sender, RoutedEventArgs e)
        {
            FskWindow fsk = new FskWindow();
            fsk.Show();
        }

        public void Shym(object sender, RoutedEventArgs e)
        {
            winShym shym = new winShym();
            shym.Show();
        }
        public void Formula(object sender, RoutedEventArgs e)
        {
            WindowFormul shym = new WindowFormul();
            shym.Show();
        }
        public void Kolvobit(object sender, RoutedEventArgs e)
        {
            WindowKolvoBit shym = new WindowKolvoBit();
            shym.Show();
        }
        public void Lvlqvant(object sender, RoutedEventArgs e)
        {
            WinLvl shym = new WinLvl();
            shym.Show();
        }

    }
}
