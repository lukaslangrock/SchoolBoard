# SchoolBoard 🖥️
Digital Signage WebApp which shows current information about missing classes and other events about our school.
If you want to use something like this, feel free to fork it and make your own version to suit your needs.
As this project is for [our school](https://www.pelizaeus.de/) in Germany, the entire UI is in German too.

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
*The web interface is currently in very early stages and does not allow you to edit all settings. Please edit the config.json file instead for the time being.*

1.  Start the WebApp using a method outline earlier.
2.  Navigate to the WebApp in a browser of your choice and append `/Settings` to the URL *(eg: `localhost:5000/Settings`)*.
3.  Change the values as needed and save using the blue button at the bottom.

### Config.json for development
*This includes Visual Studio's IIS server as well as `dotnet run`.*

1.  Open the project folder (`WebApp/SchoolBoard/`).
2.  Edit the `config.json` file in any text editor.
    Make sure to use the correct formatting. The app will crash if you store non-valid json code in there.
3.  Save and just refresh the page (or wait 5 minutes and let the auto refresh to it's thing). All settings can be updated during runtime and do not require a restart.

### Config.json for production
*This only applies if you have compiled the project using `dotnet build` and execute it by running `dotnet ./SchoolBoard.dll`.*

1.  Open the binary folder for the compiled project. This is usually located in `WebApp/SchoolBoard/bin/Debug/netcoreapp3.1/`.
2.  Edit the `config.json` file in any text editor.
    Make sure to use the correct formatting. The app will crash if you store non-valid json code in there.
3.  Save and just refresh the page (or wait 5 minutes and let the auto refresh to it's thing). All settings can be updated during runtime and do not require a restart.

# Personal usage & Contributions 🧩

Feel free to build something yourself upon this project to suit your needs.
Pull requests are always welcome too.
