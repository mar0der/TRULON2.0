using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const int MoveSpeed = 2;
        public const int ElementQty = 1000;
        public static string strUri2 = String.Format(@"pack://application:,,,/{0}", "images.jpg");

        public MainWindow()
        {
            var dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

            InitializeComponent();

            for (int i = 0; i < ElementQty; i++)
            {
                var image = new Image
                {
                    Source = new BitmapImage(new Uri(strUri2)),
                    Margin = new Thickness { Top = i * 2, Left = 0 },
                    Width = 50,
                    Height = 50
                };

                GameGrid.Children.Add(image);
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            // Updating the Label which displays the current second
            lblFrames.Content = frameCounter;

            // Forcing the CommandManager to raise the RequerySuggested event
            CommandManager.InvalidateRequerySuggested();
        }

        readonly List<Key> _pressedKeys = new List<Key>();
        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        public static int frameCounter = 0;
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_pressedKeys.Contains(e.Key))
            {
                _pressedKeys.Add(e.Key);
            }

            frameCounter++;
            lblFrames.Content = frameCounter;
            UpdateField();
        }

        private void UpdateField()
        {
            var images = FindVisualChildren<Image>(GameGrid).ToList();

            foreach (var image in images)
            {
                MoveElement(image);
                //gameobject.update
            }
        }

        private void MoveElement(Image image)
        {
            if (_pressedKeys.Contains(Key.Up))
            {
                var m = image.Margin;
                m.Top -= MoveSpeed;

                image.Margin = m;
            }

            if (_pressedKeys.Contains(Key.Left))
            {
                var m = image.Margin;
                m.Left -= MoveSpeed;

                image.Margin = m;
            }

            if (_pressedKeys.Contains(Key.Down))
            {
                var m = image.Margin;
                m.Top += MoveSpeed;

                image.Margin = m;
            }

            if (_pressedKeys.Contains(Key.Right))
            {
                var m = image.Margin;
                m.Left += MoveSpeed;

                image.Margin = m;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            _pressedKeys.Remove(e.Key);
        }

        private void MovePlayer()
        {
            
        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            MovePlayer();
        }
    }
}
