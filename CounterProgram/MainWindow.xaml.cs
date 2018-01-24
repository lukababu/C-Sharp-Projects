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

namespace CounterProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Counter counter = new Counter();
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            this.incButton.Click += IncButton_Click;
            this.decButton.Click += DecButton_Click;
            // Set an interval at 300ms
            timer.Interval = TimeSpan.FromMilliseconds(300);
 
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.counter.IncrementCount();
            this.countLabel.Content = this.counter.Count.ToString();
            this.timer.Start();
        }

        private void DecButton_Click(object sender, RoutedEventArgs e)
        {
            this.counter.DecrementCount();
            this.countLabel.Content = this.counter.Count.ToString();
        }

        private void IncButton_Click(object sender, RoutedEventArgs e)
        {
            this.counter.IncrementCount();
            this.countLabel.Content = this.counter.Count.ToString();
        }

        private void stopTimer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
