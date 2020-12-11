using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace WPFProjectFinal
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();

            DoubleAnimation dblAnim = new DoubleAnimation();

            dblAnim.Completed += (sender, eArgs) =>
            {
                Encipher еncipher = new Encipher();
                this.Close();
                еncipher.Show();
            };

            dblAnim.From = 0.0;
            dblAnim.To = 1.0;
            dblAnim.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            img.BeginAnimation(Image.OpacityProperty, dblAnim);
        }
    }
}
