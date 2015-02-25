using Microsoft.Xna.Framework;
using Trulon.Enums;

namespace Trulon.Models
{
    using Structs;
    using Microsoft.Xna.Framework.Graphics;

    public class Map : GameObject
    {
        private Obsticle[][] obsticles = 
        {
        new[]{ //Level 1
                //new Obsticle(0, 346, 360, 20, Direction.Up),
                //new Obsticle(310, 390, 20, 15, Direction.Left),
                //new Obsticle(350, 311, 200, 20, Direction.Up),
                //HUD
                new Obsticle(0, 280, 10, 350, Direction.Left),
                new Obsticle(1270, 250, 10, 250, Direction.Right),
                new Obsticle(0, 450, 130, 100, Direction.Down),
                new Obsticle(115, 450, 30, 120, Direction.Left),
                new Obsticle(115, 560, 1100, 50, Direction.Down) 
                
                },
        new[]{  //Level 2
                new Obsticle(0, 280, 10, 350, Direction.Left),
                new Obsticle(1270, 250, 10, 250, Direction.Right),
                //new Obsticle(0, 346, 360, 20, Direction.Up),
                //new Obsticle(310, 390, 20, 15, Direction.Left),
                //new Obsticle(350, 311, 200, 20, Direction.Up),
                //HUD
                new Obsticle(0, 450, 130, 100, Direction.Down),
                new Obsticle(115, 450, 30, 120, Direction.Left),
                new Obsticle(115, 560, 1100, 50, Direction.Down) 
                 
            },
        new[]{  //Level 3
                new Obsticle(0, 280, 10, 350, Direction.Left),
                new Obsticle(1270, 250, 10, 250, Direction.Right),
                //new Obsticle(0, 346, 360, 20, Direction.Up),
                //new Obsticle(310, 390, 20, 15, Direction.Left),
                //new Obsticle(350, 311, 200, 20, Direction.Up),
                //HUD
                new Obsticle(0, 450, 130, 100, Direction.Down),
                new Obsticle(115, 450, 30, 120, Direction.Left),
                new Obsticle(115, 560, 1100, 50, Direction.Down) 
                 
            },
        new[]{  //Level 4
                new Obsticle(0, 280, 10, 350, Direction.Left),
                new Obsticle(1270, 250, 10, 250, Direction.Right),
                //new Obsticle(0, 346, 360, 20, Direction.Up),
                //new Obsticle(310, 390, 20, 15, Direction.Left),
                //new Obsticle(350, 311, 200, 20, Direction.Up),
                //HUD
                new Obsticle(0, 450, 130, 100, Direction.Down),
                new Obsticle(115, 450, 30, 120, Direction.Left),
                new Obsticle(115, 560, 1100, 50, Direction.Down) 
                
            },
        new[]{
                new Obsticle(0, 280, 10, 350, Direction.Left),
                new Obsticle(1270, 250, 10, 250, Direction.Right),
                //new Obsticle(0, 346, 360, 20, Direction.Up),
                //new Obsticle(310, 390, 20, 15, Direction.Left),
                //new Obsticle(350, 311, 200, 20, Direction.Up),
                //HUD
                new Obsticle(0, 450, 130, 100, Direction.Down),
                new Obsticle(115, 450, 30, 120, Direction.Left),
                new Obsticle(115, 560, 1100, 50, Direction.Down)
                
            }
        };

        public Map(int levelNumber, Texture2D image)
        {
            this.Image = image;
            this.LevelNumber = levelNumber;

        }

        public Vector2 PlayerEntryPloint
        {
            get
            {
                return new Vector2(this.obsticles[LevelNumber][0].ObsticleBox.Min.X+10,
                    this.obsticles[LevelNumber][0].ObsticleBox.Min.Y);
            }
        }
        public Vector2 PlayerExitPloint
        {
            get
            {
                return new Vector2(this.obsticles[LevelNumber][1].ObsticleBox.Min.X - 100,
                                    this.obsticles[LevelNumber][1].ObsticleBox.Min.Y);
            }
        }
        public int LevelNumber { get; set; }

        public Obsticle[] Obsticles
        {
            get { return obsticles[LevelNumber]; }
        }
    }
}
