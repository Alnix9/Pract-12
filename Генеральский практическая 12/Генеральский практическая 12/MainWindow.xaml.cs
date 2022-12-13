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
using System.Windows.Threading;

namespace Генеральский_практическая_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void FindVolume(object sender, RoutedEventArgs e)
        {
            tbSideA.Focus();
            if (int.TryParse(tbSideA.Text, out int A) & int.TryParse(tbSideB.Text, out int B) & int.TryParse(tbSideC.Text, out int C))
            {
                int Volume = A * B * C;//Объём
                tbVolume.Text = Volume.ToString();
            }
        }
        private void Clear1(object sender, RoutedEventArgs e)
        {
            tbSideA.Clear();
            tbSideB.Clear();
            tbSideC.Clear();
            tbVolume.Clear();
        }
        private void FindSumAndMultiply(object sender, RoutedEventArgs e)
        {
            tbTwoDigitNumber.Focus();
            if (int.TryParse(tbTwoDigitNumber.Text, out int Number))
            {
                tbTwoDigitNumber.Focus();
                int a = Number / 10;//Первая цифра из нашего двухзначного числа
                int b = Number % 10;//Вторая цифра из нашего двухзначного числа
                tbSum.Text = Convert.ToString(a + b);//Сумма

                tbMultiply.Text = Convert.ToString(a*b);//Произведение
            }
            else MessageBox.Show("Введите число");
        }
        private void Clear2(object sender, RoutedEventArgs e)
        {
            tbTwoDigitNumber.Clear();
            tbSum.Clear();
            tbMultiply.Clear();
        }
        DispatcherTimer timer;//описываем таймер
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();//добавляем таймер
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;//Создаём объект
            tbTime.Text = d.ToString("hh:mm");//часы минуты секунды
            tbData.Text = d.ToString("dd.MM.yyyy");//дни месяцы года
        }

        private void AboutProgramm1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Даны длины ребер a, b, c прямоугольного параллелепипеда. " +
                "Найти его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c).");
        }

        private void AboutProgramm2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дано двузначное число. Найти сумму и произведение его цифр");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void NumberChange(object sender, TextChangedEventArgs e)
        {

        }
    }
}
