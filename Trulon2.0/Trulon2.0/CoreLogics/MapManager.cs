namespace Trulon.CoreLogics
{
    using System;

    public class MapManager
    {
        public event EventHandler MapUp;

        protected void OnMapUp()
        {
            if (MapUp != null)
            {
                MapUp(this, new EventArgs());
            }
        }

        public void FireMapUp()
        {
            OnMapUp();
        }
    }

}