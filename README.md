# Tripoint.Test.StockBalance

Welcome, potential candidate! For this test, we want you to build a simple API that supports retrieving the stock balance for a given article name. This repository contains some boilerplate to get you going, so simply clone the code and add the necessary implementation to the code in order to support the requirements listed below.

## Prerequisites

In order to develop and run the project in this repository, you need to have .NET Core SDK version 3.1 (or higher) installed. The SDK can be found here: https://dotnet.microsoft.com/download.

## Requirements

Once you're done with this test, we want your solution to:

- Support retrieving the total stock balance for a given article name, e.g.:  
   Sending a request: HTTP GET `/stock-balance/Speedster%20Gravel%2030`  
   Should return: `Total stock balance (Speedster Gravel 30): 3`
- Return the total stock balance as the sum of the local stock balance + the remote stock balance.
- Return status code 404 if the article name is unknown in _both_ the local and the remote stock.
- Not be case-sensitive when it comes to article names. In other words, the same stock balance should be returned no matter if you use `Trek Checkpoint ALR 4` or `trEk chEckPoinT aLr 4` in the request.
- Utilize dependency injection.

## Additional notes

We will review both the functionality as well as the code quality of your solution. Good luck!
