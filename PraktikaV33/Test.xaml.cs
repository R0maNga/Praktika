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
using System.Windows.Shapes;

namespace PraktikaV33
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {

        private int MEGAINT = 1;
        private int mark = 0;



        public Test()
        {

            InitializeComponent();

            quantions();



        }

        public void otv1 (object sender, RoutedEventArgs e)
        {
            var first = 1;
            var two = 2;
            var seven = 7;
            var nine = 9;
            if (MEGAINT == first || MEGAINT == seven||MEGAINT==two)
            {
                mark++;
            }

            MEGAINT++;
            quantions();

        }
        public void otv2(object sender, RoutedEventArgs e)
        {
            var three = 3;
            var five = 5;
            var eight = 8;
            if (MEGAINT == three || MEGAINT == five)
            {
                mark++;
            }
            MEGAINT++;
            quantions();

        }
        public void otv3(object sender, RoutedEventArgs e)
        {
            
            var three = 4;
            var ten = 10;
            if (MEGAINT == three)
            {
                mark++;
            }
            MEGAINT++;
            quantions();

        }
        public void otv4(object sender, RoutedEventArgs e)
        {
            
            var six = 6;
            if (MEGAINT == six)
            {
                mark++;
            }
            MEGAINT++;
            quantions();

        }

        public void quantions()
        {



            switch (MEGAINT)
            {
                case 1:
                    {
                        qua.Text = "Какой сигнал используется для передачи и получения данных?:";
                        
                        otvet1.Content = "Аналоговый";
                        otvet2.Content = "Цифровой";
                        otvet3.Content = "Цифро-аналоговый";
                        otvet4.Content = "Аналогово-цифровой";

                        break;
                    }
                case 2:
                    {
                        qua.Text = "Что изображено на картинке?:";
                        otvet3.Visibility = Visibility.Visible;
                        otvet1.Content = "Несущая частота";
                        otvet2.Content = "Сигнал";
                        otvet3.Content = "Частотная модуляция";
                        otvet4.Content = "Синусоидальная модуляция";
                        Image.Source = new BitmapImage(new Uri("C:\\Users\\R0maNga\\Desktop\\TRASH\\kart1.png"));
                        break;
                    }
                case 3:
                    {
                        qua.Text = "Что изображено на картинке?:";
                        otvet1.Content = "Несущая частота";
                        otvet2.Content = "Сигнал";
                        otvet3.Content = "Частотная модуляция";
                        otvet4.Content = "Синусоидальная модуляция";
                        Image.Source = new BitmapImage(new Uri("C:\\Users\\R0maNga\\Desktop\\TRASH\\kart2.png"));
                        break;
                    }
                case 4:
                    {
                        qua.Text = "Что изображено на картинке?:";
                        otvet1.Content = "Несущая частота";
                        otvet2.Content = "Сигнал";
                        otvet3.Content = "Частотная модуляция";
                        otvet4.Content = "Синусоидальная модуляция";
                        Image.Source = new BitmapImage(new Uri("C:\\Users\\R0maNga\\Desktop\\TRASH\\kart3.png"));
                        break;
                    }
                case 5:
                    {
                        qua.Text = "Что изображено на картинке?:";
                        otvet4.Content = "Квантовый сигнал по площади";
                        otvet2.Content = "Дискретизация";
                        otvet1.Content = "Квантовый сигнал по уровню";
                        otvet3.Content = "Многомодульный сигнал";
                        Image.Source = new BitmapImage(new Uri("C:\\Users\\R0maNga\\Desktop\\TRASH\\kart4.png"));

                        break;
                    }
                case 6:
                    {

                        qua.Text = "Какой вид модуляции используется в передаче файлов?:";
                        otvet3.Visibility = Visibility.Visible;
                        otvet4.Visibility = Visibility.Visible;
                        otvet2.Content = "АИМ";
                        otvet1.Content = "ФИМ";
                        otvet3.Content = "ШИМ";
                        otvet4.Content = "ЧИМ";
                        Image.Visibility = Visibility.Hidden;

                        break;
                    }
                case 7:
                    {
                        qua.Text = "Что в первую очередь происходит перед передачей данных?:";
                        otvet2.Content = "Десериализация";
                        otvet1.Content = "Сериализация";
                        otvet3.Content = "Парсиболизация";
                        otvet4.Content = "Депарсилизация";
                        break;
                    }
                case 11:
                {
                    otvet4.Visibility = Visibility.Hidden;
                    otvet3.Visibility = Visibility.Hidden;
                    otvet2.Visibility = Visibility.Hidden;
                    otvet1.Visibility = Visibility.Hidden;
                    qua.Text = $"Ваш резульат:{mark}/10";
                    break;
                    
                }
                case 8:
                {
                    qua.Text = "Что называют шумом квантования?";
                    otvet2.Content = "Большие ошибки квантования";
                    otvet1.Content = "Увеличение периода аудиосигнала";
                    otvet3.Content = "Минимальные искажения аудиосигнала";
                    otvet4.Content = "Разрушение квантования";
                        break;
                }
                case 9:
                {
                    qua.Text = "Формула нахождения количества уровней квантования?";
                    otvet2.Content = "N=0.5^n";
                    otvet1.Content = "N=2^n";
                    otvet3.Content = "N=(2/3)^n";
                    otvet4.Content = "N=(n/2)^3";
                    break;
                }
                case 10:
                {
                    qua.Text = "Чем является F в формуле дискретизации F=1/T?";
                    otvet2.Content = "Сила дискретизации";
                    otvet1.Content = "Период дискретизации";
                    otvet3.Content = "Частота дискретизации";
                    otvet4.Content = "Фокус дискретизации";
                    break;
                    //как выбирается нули и еденицы каждому физ уровню принципы и подходы 
                }
            }
        }
    }
}
