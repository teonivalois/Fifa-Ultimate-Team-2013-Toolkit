using System.Collections.Generic;
using System.Runtime.Serialization;

namespace UltimateTeam.Toolkit.Model
{
    [DataContract]
    internal class Persona
    {
        [DataMember(Name = "personaId")]
        public long PersonaId { get; set; }

        [DataMember(Name = "personaName")]
        public string PersonaName { get; set; }

        [DataMember(Name = "userClubList")]
        public List<UserClub> UserClubList { get; set; }
    }
}