namespace UltimateTeam.Toolkit.Model
{
    public abstract class SearchParameterBase<TValue>
    {
        public string Description { get; set; }

        public TValue Value { get; set; }
    }
}