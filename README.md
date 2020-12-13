# IB.CSharpApiClient

## Description
IB.CSharpApiClient is a wrapper library on top of [TWS API](https://interactivebrokers.github.io/tws-api/introduction.html).  
It provides a simplified client with events and nice async/await methods.

## Installation
Please note due to Interactive Brokers license restriction, you need to manually download and copy TWS API source to `packages` folder.

1. Clone `git clone https://github.com/mathpaquette/IB.CSharpApiClient.git` 
2. Accept [TWS API license](https://interactivebrokers.github.io/) 
3. Download and Install [TWS API v9.81](https://interactivebrokers.github.io/downloads/TWS%20API%20Install%20981.01.msi) 
4. Copy `<TWS API install folder>\source\CSharpClient\client` to `IB.CSharpApiClient\packages`
5. Build IB.CSharpApiClient
   
## Features
- .NET Standard
- Events
- Async/Await
- Automatic reconnection (WIP)

## Support
For support request, you can create an issue on GitHub.

## Contributing
Pull requests are welcome! Don't hesitate to open an issue if something goes wrong.