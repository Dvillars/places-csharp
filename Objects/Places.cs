using System.Collections.Generic;

namespace Places.Objects
{
    public class Place
    {
        private string _name;
        private string _description;

        private static List<Place> PlacesList = new List<Place> { };

        public Place (string name, string description)
        {
            SetName(name);
            SetDescription(description);
            PlacesList.Add(this);
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }

        public static List<Place> GetAll()
        {
            return PlacesList;
        }

    }
}