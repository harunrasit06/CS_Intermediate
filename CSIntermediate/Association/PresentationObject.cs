using System;

namespace CSIntermediate.Association
{
    
        public class PresentationObject
        {
            public int Width { get; set; }
            public string Height { get; set; }

            public void Copy()
            {
                Console.WriteLine("Object copied!");
            }

            public void Duplicate()
            {
                Console.WriteLine("Object was duplicated!");

            }
        
    }
}
