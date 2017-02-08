using System.Collections.Generic;

namespace Places.Objects
{
    public class Place
    {
        private string _name;
        private string _description;

        private static List<Place> PlacesList = new List<Places> { };

        public string GetName()
        {
            return _name;
        }

        public void SetName(newName)
        {
            _name = newName;
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(newDescription)
        {
            _description = newDescription;
        }

        public void AddPlace(Place newPlace)
        {
            PlacesList.Add(newPlace);
        }

        public static List<Place> GetAll()
        {
            return PlacesList;
        }

    }
}