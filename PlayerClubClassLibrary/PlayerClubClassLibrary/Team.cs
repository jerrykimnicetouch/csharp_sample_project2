using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerClubClassLibrary
{
    public class Team
    {
        public string Name { get; set; }
        public string Coach { get; set; }
        public string Founded { get; set; }
        public string Region { get; set; }

        //public List<Player> thisTeamsPlayers { get; set; }
        //team object  will have a List<Player> object with the name 'thisTeamsPlayers' which is accessible
        //via team.thisTeamsPlayers

        public Team(string name, string coach, string founded, string region)
        {
            Name = name;
            Coach = coach;
            Founded = founded;
            Region = region;
        }

        

    }
}
