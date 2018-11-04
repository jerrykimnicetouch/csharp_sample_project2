using System;

namespace PlayerClubClassLibrary
{
    public class Player
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Team { get; set; }

        public Player(string id, string name, string dob, string height, string weight, string pob, string team)
        {
            ID = id;
            Name = name;
            DOB = dob;
            Height = height;
            Weight = weight;
            PlaceOfBirth = pob;
            Team = team;
     
        }
        
    }
}
