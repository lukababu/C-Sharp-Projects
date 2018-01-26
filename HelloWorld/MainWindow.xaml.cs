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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Assignment 2 | Hello World WPF
    /// Name: Luke D Iremadze
    /// UCID: 10163614
    /// Tutorial: T03
    /// Version: 2018-01-26
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.displayButton.Click += DisplayButton_Click;
        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            this.helloWorld.Content = "Hello World!";
        }
    }
}
