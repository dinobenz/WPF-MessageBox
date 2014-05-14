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
using Dinobenz.Wpf.MessageBox.View;

namespace Dinobenz.Wpf.MessageBox
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

        private void Message_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxWindow.Show(this, "Put your message here.");
        }

        private void Message_Caption_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxWindow.Show(this, "Put your message here.", "Put your caption here");
        }

        private void Message_Caption_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgResult = MessageBoxWindow.Show(this, "Put your message here.", "Put your caption here", MessageBoxButton.YesNo);
        }

        private void Message_Caption_Button_Icon_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxWindow.Show(this, "Put your message here.", "Put your caption here", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
