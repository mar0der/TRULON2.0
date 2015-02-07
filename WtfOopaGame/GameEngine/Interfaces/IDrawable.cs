using System.Windows.Controls;

namespace GameEngine.Interfaces
{
    /// <summary>
    /// Interface that ensures that Game Object can be displayed in WPF
    /// </summary>
    public interface IDrawable
    {
        /// <summary>
        /// The image to be displayed
        /// </summary>
        Image ObjectImage { set; get; }
    }
}