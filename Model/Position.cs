using System.Collections.Generic;

namespace UltimateTeam.Toolkit.Model
{
    public class Position : SearchParameterBase<string>
    {
        public const string Striker = "ST";

        private Position(string descripton, string value)
        {
            Description = descripton;
            Value = value;
        }

        public static IEnumerable<Position> GetAll()
        {
            yield return new Position("Striker", Striker);
        }
    }
}