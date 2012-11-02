using System.Collections.Generic;

namespace UltimateTeam.Toolkit.Model
{
    public class Formation : SearchParameterBase<string>
    {
        public const string FourThreeThree = "f433";

        public const string FourFourTwo = "f422";

        private Formation(string description, string value)
        {
            Description = description;
            Value = value;
        }

        public static IEnumerable<Formation> GetAll()
        {
            yield return new Formation("4-3-3", FourThreeThree);
            yield return new Formation("4-4-2", FourFourTwo);
        }
    }
}