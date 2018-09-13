using AllGamesCoinLib.CoinParameters.Base;

namespace AllGamesCoinLib.CoinParameters.AllGamesCoin
{
    public static class AllGamesCoinConstants
    {
        public sealed class Constants : CoinConstants<Constants>
        {
            public readonly ushort CoinReleaseHalfsEveryXInYears = 7;
            public readonly ushort DifficultyIncreasesEveryXInBlocks = 34560;
            public readonly uint OneAllGamesCoinInDuffs = 100000000;
            public readonly decimal OneDuffInAllGamesCoin = 0.00000001M;
            public readonly decimal OneMicroAllGamesCoinInAllGamesCoin = 0.000001M;
            public readonly decimal OneMilliAllGamesCoinInAllGamesCoin = 0.001M;
            public readonly string Symbol = "XAGC";
        }
    }
}
