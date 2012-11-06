using System.Runtime.Serialization;

namespace UltimateTeam.Toolkit.Model
{
    [DataContract]
    public class Item
    {
        /*
        * Players - Defender
        * ------------------
        * Attribute1 = Pace
        * Attribute2 = Shooting
        * Attribute3 = Passing
        * Attribute4 = Dribbling
        * Attribute5 = Defending
        * Attribute6 = Heading
        */

        [DataMember]
        public byte Attribute1 { get; set; }

        [DataMember]
        public byte Attribute2 { get; set; }

        [DataMember]
        public byte Attribute3 { get; set; }

        [DataMember]
        public byte Attribute4 { get; set; }

        [DataMember]
        public byte Attribute5 { get; set; }

        [DataMember]
        public byte Attribute6 { get; set; }

        [DataMember]
        public uint ClubId { get; set; }

        [DataMember]
        public string CommonName { get; set; }

        [DataMember]
        public DateOfBirth DateOfBirth { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public byte Height { get; set; }

        [DataMember]
        public string ItemType { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public uint LeagueId { get; set; }

        [DataMember]
        public uint NationId { get; set; }

        [DataMember]
        public string PreferredFoot { get; set; }

        [DataMember]
        public RareType Rare { get; set; }

        [DataMember]
        public byte Rating { get; set; }
    }
}