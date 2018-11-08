using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace RunningQRClock
{
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer1 = new DispatcherTimer();
        Stopwatch stopWatch1 = new Stopwatch();
        string currentTime1 = string.Empty;

        DispatcherTimer dispatcherTimer2 = new DispatcherTimer();
        Stopwatch stopWatch2 = new Stopwatch();
        string currentTime2 = string.Empty;

        DispatcherTimer dispatcherTimer3 = new DispatcherTimer();
        Stopwatch stopWatch3 = new Stopwatch();
        string currentTime3 = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer1.Tick += new EventHandler(dt1_Tick);
            dispatcherTimer1.Interval = new TimeSpan(0, 0, 0, 0, 1);

            dispatcherTimer2.Tick += new EventHandler(dt2_Tick);
            dispatcherTimer2.Interval = new TimeSpan(0, 0, 0, 0, 1);

            dispatcherTimer3.Tick += new EventHandler(dt3_Tick);
            dispatcherTimer3.Interval = new TimeSpan(0, 0, 0, 0, 1);
        }

        #region 1
        void dt1_Tick(object sender, EventArgs e)
        {
            if (stopWatch1.IsRunning)
            {
                TimeSpan ts = stopWatch1.Elapsed;
                currentTime1 = String.Format("{0:00}:{1:00}:{2:00}:{3:000}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                textClock1.Text = currentTime1;
            }
        }

        private void startbtn1_Click(object sender, RoutedEventArgs e)
        {
            stopWatch1.Start();
            dispatcherTimer1.Start();
        }

        private void stopbtn1_Click(object sender, RoutedEventArgs e)
        {
            if (stopWatch1.IsRunning)
            {
                stopWatch1.Stop();
            }
            //elapsedtimeitem.Items.Add(currentTime);
        }

        private void resetbtn1_Click(object sender, RoutedEventArgs e)
        {
            stopWatch1.Reset();
            textClock1.Text = "00:00:00:000";
        }
        #endregion

        #region 2
        void dt2_Tick(object sender, EventArgs e)
        {
            if (stopWatch2.IsRunning)
            {
                TimeSpan ts = stopWatch2.Elapsed;
                currentTime2 = String.Format("{0:00}:{1:00}:{2:00}:{3:000}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                textClock2.Text = currentTime2;
            }
        }

        private void startbtn2_Click(object sender, RoutedEventArgs e)
        {
            stopWatch2.Start();
            dispatcherTimer2.Start();
        }

        private void stopbtn2_Click(object sender, RoutedEventArgs e)
        {
            if (stopWatch2.IsRunning)
            {
                stopWatch2.Stop();
            }
            //elapsedtimeitem.Items.Add(currentTime);
        }

        private void resetbtn2_Click(object sender, RoutedEventArgs e)
        {
            stopWatch2.Reset();
            textClock2.Text = "00:00:00:000";
        }
        #endregion

        #region 3
        void dt3_Tick(object sender, EventArgs e)
        {
            if (stopWatch3.IsRunning)
            {
                TimeSpan ts = stopWatch3.Elapsed;
                currentTime3 = String.Format("{0:00}:{1:00}:{2:00}:{3:000}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                textClock3.Text = currentTime1;
            }
        }

        private void startbtn3_Click(object sender, RoutedEventArgs e)
        {
            stopWatch3.Start();
            dispatcherTimer3.Start();
        }

        private void stopbtn3_Click(object sender, RoutedEventArgs e)
        {
            if (stopWatch3.IsRunning)
            {
                stopWatch3.Stop();
            }
        }

        private void resetbtn3_Click(object sender, RoutedEventArgs e)
        {
            stopWatch3.Reset();
            textClock3.Text = "00:00:00:000";
        }
        #endregion
    }
}