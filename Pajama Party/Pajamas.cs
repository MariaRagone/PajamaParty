using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pajama_Party
{
    ////Implement a catalog of different pajama sets that users can choose from.
    ////Each pajama set should have attributes such as style, size, and color
    internal class Pajamas
    {
        public string style { get; set; } //onesie, nightgown, flannel, nighty
        public int size { get; set; }
        public string color { get; set; }
        public bool hasPattern { get; set; }

    public Pajamas(string _style, int _size, string _color, bool _hasPattern)
    {
            style = _style;
            size = _size;
            color = _color;
            hasPattern = _hasPattern;
    }

        //defaults
    public Pajamas()
        {
            style = "onesie";
            size = 0;
            color = "white";
            hasPattern = false;
        }

        //methods
        //display properties
        public string ToString()
        {
            return String.Format("{0,20} {1,20} {2,20} {3,20}", style, size, color, hasPattern);
        }
    }
}
