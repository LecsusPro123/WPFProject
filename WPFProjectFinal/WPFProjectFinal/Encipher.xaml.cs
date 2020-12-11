using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows;

namespace WPFProjectFinal
{
    /// <summary>
    /// Логика взаимодействия для Encipher.xaml
    /// </summary>
    public partial class Encipher : Window
    {
        delegate string Del(string startStr, string key);
        Del del = null;
        public Encipher()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void ToCipher_Checked(object sender, RoutedEventArgs e)
        {
            FromCipher.IsChecked = false;
            del += VigenereCipher.Encipher;
        }
        private void ToCipher_Unchecked(object sender, RoutedEventArgs e)
        {
            del -= VigenereCipher.Encipher;
        }
        private void FromCipher_Checked(object sender, RoutedEventArgs e)
        {
            ToCipher.IsChecked = false;
            del += VigenereCipher.Decipher;
        }
        private void FromCipher_Unchecked(object sender, RoutedEventArgs e)
        {
            del -= VigenereCipher.Decipher;
        }
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
                Sourse.Text = File.ReadAllText(openFileDialog.FileName, Encoding.Default);
        }
        private void Solve_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                afterCipher.Text = del(Sourse.Text, Key.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void SaveAsFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, afterCipher.Text, Encoding.GetEncoding(1251));
            }
        }
        private void ClosingWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
