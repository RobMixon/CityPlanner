using System;
using System.Collections.Generic;

namespace Planner {
    class Building {
        private string _designer { get; set; }
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume {
            get {
                return Width * Depth * (3 * Stories);
            }
        }

        public void Print () {
            Console.WriteLine ($"{_address}");
            Console.WriteLine ("--------------------------");
            Console.WriteLine ($" Designed by ${_designer}");
            Console.WriteLine ($"Constructed on {_dateConstructed}");
            Console.WriteLine ($"Owned by {_owner}");
            Console.WriteLine ($"{Volume} cubic meters in space");
            Console.WriteLine ();
        }
        public Building (string address) {
            _address = address;
        }

        public string getAddress () {
            return _address;
        }

        public Building (string address, string owner, int stories, double width, double depth) {
            _address = address;
            _owner = owner;
            Stories = stories;
            Width = width;
            Depth = depth;
        }
        public void Construct () {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase (string buyer) {
            _owner = buyer;
        }

        public void setDimensions (int Stories, double Width, double Depth) {
            this.Stories = Stories;
            this.Width = Width;
            this.Depth = Depth;
        }

        public string address { get; set; }

    }

}