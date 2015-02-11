using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using GameEngine.CoreLogic;
using GameEngine.Enums;

namespace WtfOopaGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        /// <summary>
        /// Contains all pressed keys at given time
        /// </summary>
        private readonly List<Key> PressedKeys = new List<Key>();

        public MainWindow()
        {
            InitializeComponent();

            var engine = new Engine(OopaGameGrid);
            CompositionTarget.Rendering += (sender, args) => engine.Run();
        }

        /// <summary>
        /// Setups the GameGrid direction
        /// </summary>
        private void SetDirection()
        {
            var westIsPressed = PressedKeys.Contains(Key.Left);
            var eastIsPressed = PressedKeys.Contains(Key.Right);
            var northIsPressed = PressedKeys.Contains(Key.Up);
            var southIsPressed = PressedKeys.Contains(Key.Down);
            var northWestIsPressed = westIsPressed && northIsPressed;
            var northEastIsPressed = eastIsPressed && northIsPressed;
            var southWestIsPressed = westIsPressed && southIsPressed;
            var southEastIsPressed = eastIsPressed && southIsPressed;

            var haveDirection = westIsPressed
                                || eastIsPressed
                                || northIsPressed
                                || southIsPressed;

            if (haveDirection)
            {
                var hasSimpleDirection = !(northWestIsPressed
                                    || northEastIsPressed
                                    || southWestIsPressed
                                    || southEastIsPressed);

                if (hasSimpleDirection)
                {
                    if (westIsPressed)
                    {
                        OopaGameGrid.Direction = Direction.West;
                    }

                    if (northIsPressed)
                    {
                        OopaGameGrid.Direction = Direction.Nort;
                    }

                    if (eastIsPressed)
                    {
                        OopaGameGrid.Direction = Direction.East;
                    }

                    if (southIsPressed)
                    {
                        OopaGameGrid.Direction = Direction.South;
                    }
                }
                else
                {

                    if (northWestIsPressed)
                    {
                        OopaGameGrid.Direction = Direction.NorthWest;
                    }

                    if (northEastIsPressed)
                    {
                        OopaGameGrid.Direction = Direction.NorthEast;
                    }

                    if (southWestIsPressed)
                    {
                        OopaGameGrid.Direction = Direction.SouthWest;
                    }

                    if (southEastIsPressed)
                    {
                        OopaGameGrid.Direction = Direction.SouthEast;
                    }
                }
            }
            else
            {
                OopaGameGrid.Direction = Direction.None;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (!PressedKeys.Contains(e.Key))
            {
                PressedKeys.Add(e.Key);
            }

            SetDirection();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            PressedKeys.Remove(e.Key);
            SetDirection();
        }

        private void OopaGameGrid_Loaded(object sender, RoutedEventArgs e)
        {

        }


    }
}
