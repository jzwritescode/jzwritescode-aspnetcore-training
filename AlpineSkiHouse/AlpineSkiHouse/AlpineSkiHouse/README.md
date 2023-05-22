# Explore the project structure
You've created an ASP.NET Core web app in Visual Studio, and now you'll need to edit and customize your website. Let's explore the project structure to see what Visual Studio has created.

# Dependencies
The dependencies folder contains the ASP.NET Core internals to get your app up and running. Unless you're adding specific third-party packages, you won't need to spend much time in this folder.

# Properties
The properties folder contains configuration data for where you're hosting your web app. If you expand the PublishProfiles folder now, you should see the URL for the Alpine Ski Hill site. Each publishing profile is an .xml file containing publishing configuration information, such as the Azure address that Visual Studio uses to upload your files.

# wwwroot
The wwwroot file contains all of your static assets for your site, such as the css, js, images, and lib files. When you are ready to style and add more functionality to your site, you will work in here.

# Pages
The Pages folder has Razor templates for the pages of your site. Razor is a markup syntax for embedding server code into ASP.NET web pages. It includes HTML, and has special conventions for displaying data and executing logic on your site.

Each page in your site is represented with two code files:

* A .cshtml file, which is the Razor markup file. This file contains your display HTML and some C# logic.

* A .cs file, which is the C# code-behind that inherits from the PageModel class. This file allows you to intercept HTTP requests and do some processing on that request before passing any data to the Razor file.

# appsetting.json
This is a configuration file for ASP.NET Core.

# Program.cs
The Program.cs file configures and launches the web host for your site.