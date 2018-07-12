using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientationMiniProject
{

    class Deck
    {
        public int deckSize;
        public string mainColor;
        public string offColor;
        public string splashColor;
        public int deckCount = 0;


        public Deck(string primaryColor, string secondaryColor)
        {
            deckSize = 0;
            mainColor = primaryColor;
            offColor = secondaryColor;
            deckCount += 1;
        }

        public Deck(string primaryColor, string secondaryColor, string tertiaryColor)
        {
            mainColor = primaryColor;
            offColor = secondaryColor;
            splashColor = tertiaryColor;
            deckCount += 1;
        }

    }

    class Limited : Deck
    {

        public Limited(string primaryColor, string secondaryColor) : base(primaryColor, secondaryColor)
        {
            deckSize = 40;
        }
        public Limited(string primaryColor, string secondaryColor, string tertiaryColor) : base(primaryColor, secondaryColor, tertiaryColor)
        {
           deckSize = 40;
        }
    }

    class Constructed : Deck
    {
        public Constructed(string primaryColor, string secondaryColor) : base(primaryColor, secondaryColor)
        {
            deckSize = 60;
        }
        public Constructed(string primaryColor, string secondaryColor, string tertiaryColor) : base(primaryColor, secondaryColor, tertiaryColor)
        {
            deckSize = 60;
        }
    }

    class Commander : Deck
    {
        public Commander(string primaryColor, string secondaryColor) : base(primaryColor, secondaryColor)
        {
            deckSize = 100;
        }
        public Commander(string primaryColor, string secondaryColor, string tertiaryColor) : base(primaryColor, secondaryColor, tertiaryColor)
        {
            deckSize = 100;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
