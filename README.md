# Interactive Brokers - TWS API v9.72+ (Client) #

[![Build status](https://ci.appveyor.com/api/projects/status/f9iy8amej2jc6mco/branch/master?svg=true)](https://ci.appveyor.com/project/mathpaquette/ib-csharpapiclient/branch/master) [![NuGet Version and Downloads count](https://buildstats.info/nuget/IB.CSharpApiClient)](https://www.nuget.org/packages/IB.CSharpApiClient)  

#### Description
Easy to use Event-driven + Async/Await API Client on top of the famous [IB.CSharpApi](https://github.com/mathpaquette/IB.CSharpApi) (TWS API) official code.

#### Why use?
TWS API is a feature rich and very powerful market data API. It has been adapted in many languages such as C#, Java and Python in a plain way. 
For example, the C# API code doesn't come with events, async/await pattern and doesn't handle reconnection.
The aim of this client is to provide those basic functionalities in order to let you focus on your business logic rather than boilerplate code.

#### How to use? *(lazy readers)*
1. `Install-Package IB.CSharpApiClient`  
2. Create a new class and inherit from ApiClient
3. Expose and implement your events and methods from the new class
4. (optional) Create your own ApiEventDispatcher
5. Instantiate the new class and connect using the public methods

Check the IB.CSharpApiClient.Example for more details.

#### How to use?
First off, get the dependencies installed: `Install-Package IB.CSharpApiClient`  

IB.CSharpApiClient comes with an abstract ApiClient that you need to inherit.  This class provides connection and automatic reconnection functionality (WIP), provides many awaitable methods (WIP), allows you to register/unregister to events and gives you access to the TWS ClientSocket.  

Typically, your application won't need all standard events and provided methods. It could be a nice thing to expose functionnalities more specific to your domain needs.  

Let's take the example app. RealTimeDataProviderExample inherit from ApiClient and IRealTimeDataProviderExample:  
```
public class RealTimeDataProviderExample : ApiClient, IRealTimeDataProviderExample
{
    
}
```

By default, ApiClient only expose connect/disconnect and all other facilities are protected.

How the IRealTimeDataProviderExample looks like:  
```
public interface IRealTimeDataProviderExample : IApiClient
    {
        event EventHandler<Level1MarketData> MarketData;
        Task<Scanner[]> GetScannerAsync(ScannerSubscription scannerSubscription, List<TagValue> scannerSubscriptionOptions = null);
        void SubscribeMarketData(string symbol);
        void UnsubscribeMarketData(string symbol);
    }
```
As mentioned, IRealTimeDataProviderExample is domain specific. It provides MarketData event, one awaitable method for fetching scanners and allows you to register/unregister to level 1 market data. All the inner working is hidden to the consumer.

By default, level 1 market update events aren't exposed that way from TWS API and in our hypothetical example, it makes more sense to combine all fields together.

It's also possible to create your own ApiEventDispatcher implementation to adapt to any specific needs. The one provided blindly fires events from TWS callbacks.

#### TODOs
1. Complete the awaitable methods
2. Finish the automatic reconnection feature
3. Increase the unit test coverage
4. Contributing guidelines
