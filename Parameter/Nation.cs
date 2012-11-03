using System.Collections.Generic;

namespace UltimateTeam.Toolkit.Parameter
{
    public class Nation : SearchParameterBase<uint>
    {
        public const uint Norway = 36;

        private Nation(string description, uint value)
        {
            Description = description;
            Value = value;
        }

        public static IEnumerable<Nation> GetAll()
        {
            yield return new Nation("Norway", Norway);
        }
    }
}