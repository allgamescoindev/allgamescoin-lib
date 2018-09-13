using AllGamesCoinLib.CoinParameters.AllGamesCoin;
using AllGamesCoinLib.RPC.Specifications;

namespace AllGamesCoinLib.Services.Coins.AllGamesCoin
{
    public class AllGamesCoinService : CoinService, IAllGamesCoinConstants
    {
        public AllGamesCoinService(bool useTestnet = false) : base(useTestnet)
        {
        }

        public AllGamesCoinService(string daemonUrl, string rpcUsername, string rpcPassword, string walletPassword)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword)
        {
        }

        public AllGamesCoinService(string daemonUrl, string rpcUsername, string rpcPassword, string walletPassword,
            short rpcRequestTimeoutInSeconds)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword, rpcRequestTimeoutInSeconds)
        {
        }

        /// <inheritdoc />
        public string SendToAddress(string allgamescoinAddress, decimal amount, string comment = null, string commentTo = null,
            bool subtractFeeFromAmount = false, bool useInstantSend = false, bool usePrivateSend = false)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.sendtoaddress, allgamescoinAddress, amount, comment, commentTo,
                subtractFeeFromAmount, useInstantSend, usePrivateSend);
        }

        public AllGamesCoinConstants.Constants Constants => AllGamesCoinConstants.Constants.Instance;
    }
}