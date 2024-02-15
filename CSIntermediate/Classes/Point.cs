using System;

namespace CSIntermediate
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.y = y;
            this.x = x;
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(Point newLocation) 
        {
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }
            Move(newLocation.x, newLocation.y); 
           
        }
    }
}
