using System.Collections.Generic;

namespace UltimateTeam.Toolkit.Model
{
    public class League : SearchParameterBase<uint>
    {
        public const uint BarclaysPremierLeague = 13;

        private League(string description, uint value)
        {
            Description = description;
            Value = value;
        }

        public static IEnumerable<League> GetAll()
        {
            yield return new League("Barclays Premier League", BarclaysPremierLeague);
        }
    }
}