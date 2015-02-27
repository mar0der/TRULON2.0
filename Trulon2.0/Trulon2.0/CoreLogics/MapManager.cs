namespace Trulon.CoreLogics
{
    using System;

    public class MapManager
    {
        public event EventHandler MapUp;

        public void FireMapUp()
        {
            this.OnMapUp();
        }

        protected void OnMapUp()
        {
            if (this.MapUp != null)
            {
                this.MapUp(this, new EventArgs());
            }
        }
    }
}