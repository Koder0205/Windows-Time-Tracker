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

namespace WinTimeTracker
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Left = SystemParameters.WorkArea.Width  - this.Width;
            this.Top  = SystemParameters.WorkArea.Height - this.Height;
        }

        private void Exit(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        
        private void Drag(object sender, MouseButtonEventArgs e)
        {
            Cursor = Cursors.SizeAll;
            this.DragMove();
            Cursor = Cursors.Arrow;
        }

        private void ToGithub(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Koder0205/Windows-Time-Tracker");
        }

        private void ToBlog(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.koderpark.dev");
        }

        private void CursorChangeStart(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void CursorChangeEnd(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

    }
}
