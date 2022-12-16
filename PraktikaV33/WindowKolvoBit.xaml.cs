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
    /// Логика взаимодействия для WindowKolvoBit.xaml
    /// </summary>
    public partial class WindowKolvoBit : Window
    {
        public WindowKolvoBit()
        {
            InitializeComponent();
            this.ResizeMode = System.Windows.ResizeMode.CanMinimize;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var qwe =openFileDialog.InitialDirectory = @"c:\qwe\Bit.txt";
            var sr = new StreamReader(qwe, Encoding.UTF8);
            zal.Text = sr.ReadToEnd();
           



        }
        /*private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                zal.Text = File.ReadAllText(openFileDialog.FileName);
        }*/
    }
}
