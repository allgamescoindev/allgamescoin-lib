// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

using AllGamesCoinLib.Services;

namespace AllGamesCoinLib.CoinParameters.Base
{
    public interface ICoinParameters
    {
        CoinService.CoinParameters Parameters { get; }
    }
}