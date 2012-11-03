using System;

namespace UltimateTeam.Toolkit.Model
{
    public class PlayerSearchParameters : SearchParameters
    {
        public uint League { get; set; }

        public Level Level { get; set; }

        public string Position { get; set; }

        public uint Nation { get; set; }

        public string Formation { get; set; }

        public uint Team { get; set; }

        public PlayerSearchParameters()
            : base(ResourceType.Player)
        {
        }

        internal override string BuildUriString(ref string uriString)
        {
            if (League > 0)
                uriString += "&leag=" + League;

            SetLevel(ref uriString);

            if (Nation > 0)
                uriString += "&nat=" + Nation;

            if (!string.IsNullOrEmpty(Formation))
                uriString += "&form=" + Formation;

            if (Team > 0)
                uriString += "&team=" + Team;

            SetPosition(ref uriString);

            uriString += "&type=" + Type.ToString().ToLower();

            return uriString;
        }

        private void SetLevel(ref string uriString)
        {
            switch (Level)
            {
                case Level.All:
                    break;
                case Level.Bronze:
                case Level.Silver:
                case Level.Gold:
                    uriString += "&lev=" + Level.ToString().ToLower();
                    break;
                default:
                    throw new ArgumentException("Level");
            }
        }

        private void SetPosition(ref string uriString)
        {
            if (!string.IsNullOrEmpty(Position))
                uriString +=
                    Position == Model.Position.Defenders ||
                    Position == Model.Position.Midfielders ||
                    Position == Model.Position.Attackers ?
                    "&zone=" :
                    "&pos="
                    + Position;
        }
    }
}