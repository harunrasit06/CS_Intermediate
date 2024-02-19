using System;

namespace CSIntermediate.Polymorphism
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public abstract void Draw();

        public void Copy() {
            Console.WriteLine("Copy shape into Clipboard");
        }

        public void Select() { Console.WriteLine("Copy to shape"); }
        //public virtual void Draw()
        //{
        //    // Muss leer sein!
        //}
        
    }
}
