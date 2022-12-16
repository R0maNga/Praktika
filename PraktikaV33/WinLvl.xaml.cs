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
    /// Логика взаимодействия для WinLvl.xaml
    /// </summary>
    public partial class WinLvl : Window
    {
        public WinLvl()
        {
            InitializeComponent();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var qwe = openFileDialog.InitialDirectory = @"c:\qwe\Ocifrovka.txt";
            var sr = new StreamReader(qwe, Encoding.UTF8);
            cifrovka.Text = sr.ReadToEnd();
        }
    }
}
