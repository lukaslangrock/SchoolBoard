# SchoolBoard 🖥️
Digital Signage WebApp which shows current information about missing classes and other events about our school.
If you want to use something like this, feel free to fork it and make your own version to suit your needs.
As this project is for [our school](https://www.pelizaeus.de/) in Germany, the entire UI is in German too.

Please visit the [wiki](https://github.com/Lukas34/SchoolBoard/wiki) for detailed guides, instructions and other resources.

# Development Server 🌐
See a preview with demo content of the current build on [schoolboarddev.azurewebsites.net](https://schoolboarddev.azurewebsites.net).

The development server follows the master branch and automatically updates once commits are pushed. Because it's just a free server, it may take up to 20 seconds for it to respond if it has not been accessed recently.

# Build and Develop 🧪
The WebApp is written in C# and is dotnet core based so make sure you have the .NET Core SDK installed. You can get it [here](https://dotnet.microsoft.com/download).

### Terminal
1.  Open your favourite terminal.
2.  Clone the repo and navigate into the projects root folder.
2.  Run `dotnet run --project WebApp/SchoolBoard/SchoolBoard.csproj`.
3.  The project should now get compiled and will run on a local server at `localhost:5000`.

### Visual Studio
*The project was created using Visual Studio 2019 Community so all tutorials and instructions are based on on VS 2019 and might vary for older versions.*

1. Clone the repo using your favourite client *(like GitHub Desktop or Git for Windows)*.
2. Open Visual Studio and click on `Open a project or solution`.
3. Naviagte to the repo and select the `SchoolBoard.sln` solution file inside the `WebApp` folder and wait for it to load.
4. Click on the button with the green run icon which should say `IIS Express`.

# Configuration ⚙

### Web Interface
The web interface is currently disabled and might be added later down the line.

### Configuration file
1.  Open the project folder `WebApp/SchoolBoard/`.
2.  Edit the `appsettings.json` file in any text editor. Make sure to use the correct formatting. The app might crash if you store non-valid json code in there.
3.  Save and just refresh the page (or wait 5 minutes and let the auto refresh to it's thing). All settings can be updated during runtime and do not require a restart.

[How to configure the appsettings.json file](https://github.com/Lukas34/SchoolBoard/wiki/Configure-appsettings.json).

*If you are starting the compiled project from the command line using `dotnet ./SchoolBoard.dll`, your `appsettings.json` file is located in `\WebApp\SchoolBoard\bin\Debug\netcoreapp3.1` or `\WebApp\SchoolBoard\bin\Release\netcoreapp3.1`, depending on your build configuration.*

Btw: Since the configuration is [managed by ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-3.1), you can use the [JSON configuration provider](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-3.1#jcp) for different production and development coonfigurations by creating a new appsettings.`Environment`.json file (e.g. `appsettings.Development.json`) and put in the configuration changes. You can also use environmental variables for the config which override `appsettings.json`.

# Personal usage & Contributions 🧩

Feel free to build something yourself upon this project to suit your needs.
Pull requests are always welcome too.
