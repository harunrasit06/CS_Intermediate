using System;
using static CSIntermediate.Association.Inheritance;

namespace CSIntermediate.Association
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }

        public string FontName { get; set; }



        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to : " + url);
        }

    }
}
