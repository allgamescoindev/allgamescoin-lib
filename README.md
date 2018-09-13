# allgamescoin-lib-.netcore
AllGamesCoin development tools

## Building

To build BitcoinLib from source, you will need either the
[.NET Core SDK or Visual Studio](https://www.microsoft.com/net/download/).

## AllGamesCoin Wallet

- Locate your `allgamescoin.conf` file
and add these lines:
  ```
  rpcuser = MyRpcUsername
  rpcpassword = MyRpcPassword
  server=1
  txindex=1
  ```
- Edit the `app.config` file in the Console test client to best fit your needs. Make sure you also update the `allgamescoin.conf` file when you alter the `AllGamesCoin_RpcUsername` and `AllGamesCoin_RpcPassword` parameters.
