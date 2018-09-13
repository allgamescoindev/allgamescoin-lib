// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

namespace AllGamesCoinLib.Responses
{
    public class ListReceivedByAccountResponse
    {
        public string Account { get; set; }
        public double Amount { get; set; }
        public int Confirmations { get; set; }
    }
}