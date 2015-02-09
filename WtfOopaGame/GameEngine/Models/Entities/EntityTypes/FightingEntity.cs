using GameEngine.Enums;
using GameEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace GameEngine.Models.Entities.EntityTypes
{
    public abstract class FightingEntity : Entity
    {
        private readonly Dictionary<Direction, BitmapImage[]> Sprites = new Dictionary<Direction, BitmapImage[]>();

        protected FightingEntity()
        {
            var baseUri = new Uri(@"pack://application:,,,/Ressoruces/Images/PlayerDefault/");

            var northUri = new Uri(baseUri + "North.png");
            Sprites.Add(Direction.Nort, new[] { new BitmapImage(northUri) });

            var northEastUri = new Uri(baseUri + "NorthEast.png");
            Sprites.Add(Direction.NorthEast, new[] { new BitmapImage(northEastUri) });

            var eastUri = new Uri(baseUri + "East.png");
            Sprites.Add(Direction.East, new[] { new BitmapImage(eastUri) });

            var southEastUri = new Uri(baseUri + "SouthEast.png");
            Sprites.Add(Direction.SouthEast, new[] { new BitmapImage(southEastUri) });

            var soutWesthUri = new Uri(baseUri + "SouthWest.png");
            Sprites.Add(Direction.SouthWest, new[] { new BitmapImage(soutWesthUri) });

            var westUri = new Uri(baseUri + "West.png");
            Sprites.Add(Direction.West, new[] { new BitmapImage(westUri) });

            var northWestUri = new Uri(baseUri + "NorthWest.png");
            Sprites.Add(Direction.NorthWest, new[] { new BitmapImage(northWestUri) });

            var southUri = new Uri(baseUri + "South.png");
            Sprites.Add(Direction.South, new[] { new BitmapImage(southUri) });

            var none = new Image();
            var noneUri = new Uri(baseUri + "None.png");
            none.Source = new BitmapImage(noneUri);
            Sprites.Add(Direction.None, new[] { new BitmapImage(noneUri) });

            this.ObjectImage = none;
        }

        public int Range { get; set; }

        public int AttackPoints { get; set; }

        public int DefensePoints { get; set; }

        public int HealthPoints { get; set; }

        public int AttackSpeed { get; set; }

        public int Level { get; set; }

        public bool IsAlive { get; set; }

        public void Attack(FightingEntity defender)
        {
            throw new NotImplementedException();
        }

        public abstract void Die();

        public override void Update(Direction direction)
        {
            this.ObjectImage.Source = Sprites[direction][0];
        }
    }
}
