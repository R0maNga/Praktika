using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace PraktikaV33
{
    /// <summary>
    /// Логика взаимодействия для Quant.xaml
    /// </summary>
    public partial class Quant : Window
    {
        public Quant()
        {
            InitializeComponent();
            this.ResizeMode = System.Windows.ResizeMode.CanMinimize;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var qwe = openFileDialog.InitialDirectory = @"c:\qwe\Discretizacia.txt";
            var sr = new StreamReader(qwe, Encoding.UTF8);
            Discret.Text = sr.ReadToEnd();
            var qwe1 = openFileDialog.InitialDirectory = @"c:\qwe\Quantovanie.txt";
            var sr1 = new StreamReader(qwe1, Encoding.UTF8);
            Quantovanie.Text = sr1.ReadToEnd();
        }
    }
}
