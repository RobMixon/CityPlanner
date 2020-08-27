using System;
using System.Collections.Generic;

namespace Planner {
    class City {
        public string name { get; set; }
        public string mayor { get; set; }
        public int year { get; set; }
        public Dictionary<string, Building> buildingList = new Dictionary<string, Building> ();

        public void addBuilding (Building newbuilding) {
            buildingList.Add (newbuilding.getAddress (), newbuilding);
        }

        public City (string name, string mayor, int year) {
            this.name = name;
            this.mayor = mayor;
            this.year = year;

        }

        public void listOfBuildings () {
            foreach (KeyValuePair<string, Building> building in buildingList) {
                building.Value.Print ();
            }
        }
    }
}