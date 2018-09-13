// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

using AllGamesCoinLib.CoinParameters.Base;
using AllGamesCoinLib.Services.RpcServices.RpcExtenderService;
using AllGamesCoinLib.Services.RpcServices.RpcService;

namespace AllGamesCoinLib.Services.Coins.Base
{
    public interface ICoinService : IRpcService, IRpcExtenderService, ICoinParameters
    {
    }
}