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
using GameEngine;

namespace FrontEnd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// Contains all pressed keys at given time
        /// </summary>
        private readonly List<Key> PressedKeys = new List<Key>();

        public MainWindow()
        {
            InitializeComponent();

            //GameBoard is a canvas comming from the xaml
            Engine engine = new Engine(this.GameBoard);
            engine.Init();
            CompositionTarget.Rendering += (sender, args) => engine.Update(PlayButton);

        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            PlayButton.Visibility = Visibility.Hidden;   
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (!PressedKeys.Contains(e.Key))
            {
                PressedKeys.Add(e.Key);
            }

            //SetDirection();
        }

    }
}
