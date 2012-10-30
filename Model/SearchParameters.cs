namespace UltimateTeam.Toolkit.Model
{
    public abstract class SearchParameters
    {
        protected ResourceType Type { get; private set; }

        public uint Page { get; set; }

        protected SearchParameters(ResourceType type)
        {
            Type = type;
        }

        internal abstract string BuildUriString(ref string uriString);
    }
}