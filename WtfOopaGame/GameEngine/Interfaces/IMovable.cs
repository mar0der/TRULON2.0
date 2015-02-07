using System.Windows;
using GameEngine.Enums;

namespace GameEngine.Interfaces
{
    /// <summary>
    /// Ensures that Game Object can move trough the field
    /// </summary>
    public interface IMovable
    {
        /// <summary>
        /// Updates the current object position
        /// </summary>
        void Update(Direction direction);
    }
}