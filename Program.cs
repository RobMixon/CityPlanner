using System;
using System.Collections.Generic;

namespace Planner {
    class Program {
        static void Main (string [] args) {
            Building Kroger = new Building ("800 8th Street");
            Building wallyWorld = new Building ("123 Main st.");
            Building publix = new Building ("1 kool vill", "Rob", 3, 12.2, 7.5);
            Kroger.Construct ();
            wallyWorld.Construct ();
            publix.Construct ();
            Kroger.setDimensions (6, 12.2, 27.1);
            Kroger.Purchase ("Chad");
            wallyWorld.Purchase ("Dan");
            wallyWorld.setDimensions (2, 12312.2, 12312.24);
            // Kroger.Print ();
            // wallyWorld.Print ();
            // publix.Print ();

            City Atlanta = new City ("Atl", "Bob", 1992);
            City charlotte = new City ("Charlotte", "Tim", 2020);
            Atlanta.addBuilding (Kroger);
            Atlanta.addBuilding (wallyWorld);
            Atlanta.addBuilding (publix);
            Atlanta.listOfBuildings ();
        }
    }
}