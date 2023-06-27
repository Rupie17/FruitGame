using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitGame
{
    class Game : SuperGame
    {
        public new static void UpdatePosition(string key, out int xChange, out int yChange)
        {
            xChange = 0;
            yChange = 0;

            switch (key)
            {
                case "UpArrow":
                    xChange += 0;
                    yChange -= 1;
                    break;

                case "DownArrow":
                    xChange += 0;
                    yChange += 1;
                    break;

                case "LeftArrow":
                    xChange -= 1;
                    yChange += 0;
                    break;

                case "RightArrow":
                    xChange += 1;
                    yChange += 0;
                    break;


            }

        }

        public new static char UpdateCursor(string key)
        {
            switch (key)
            {

                case "LeftArrow":
                    return '<';

                case "RightArrow":
                    return '>';

                case "UpArrow":
                    return '^';

                case "DownArrow":
                    return 'v';

                default:
                    return ' ';

            }

        }

        public new static int KeepInBounds(int coord, int max)
        {
            if (coord >= max)
            {
                return coord = 0;
            }
            else if (coord <= 0)
            {
                return coord = max-1;
            }
            else
                return coord;
        }

        public new static bool DidScore(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2 && y1 == y2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    } //end class
}
