using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261014_w02
{
    class Building
    {
        private string buildingCode;
        private string buildingName;
        private string buildingLatitude;
        private string buildingLongtitude;
        public string BuildingCode
        {
            get { return buildingCode; }
            set { buildingCode = value; }
        }
        public string BuildingName
        {
            get { return buildingName; }
            set { buildingName = value; }
        }
        public string BuildingLatitude
        {
            get { return buildingLatitude; }
            set { buildingLatitude = value; }
        }
        public string BuildingLongtitude
        {
            get { return buildingLongtitude; }
            set { buildingLongtitude = value; }
        }
       

        public Building() { }
        public Building(string rc, string rn, string rla, string rlo)
        {
            this.buildingCode = rc;
            this.buildingName = rn;
            this.buildingLatitude = rla;
            this.buildingLongtitude = rlo;
        }

        public override string ToString()
        {
            return this.buildingCode +
                   this.buildingLatitude +
                   this.buildingLongtitude ;
        }

    }
}