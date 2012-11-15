namespace UltimateTeam.Toolkit.Extension
{
    public static class LongExtensions
    {
        public static long CalculateBaseId(this long resourceId)
        {
            var baseId = resourceId;
            var version = 0;

            while (baseId > 16777216)
            {
                version++;
                switch (version)
                {
                    case 1:
                        baseId -= 1342177280;
                        break;
                    case 2:
                        baseId -= 50331648;
                        break;
                    default:
                        baseId -= 16777216;
                        break;
                }
            }

            return baseId;
        }

        public static uint CalculateBid(this uint currentPrice)
        {
            if (currentPrice < 1000)
                return currentPrice + 50;

            if (currentPrice < 10000)
                return currentPrice + 100;

            if (currentPrice < 50000)
                return currentPrice + 250;

            if (currentPrice < 100000)
                return currentPrice + 500;

            return currentPrice + 1000;
        }
    }
}