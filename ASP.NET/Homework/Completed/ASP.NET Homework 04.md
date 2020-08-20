# <center>ASP.NET Homework 04</center>
			
**Question 1**
*What are the .NET SDK command line tools used for? Is their use required? Why or why not?*

**Answer**
*NET Core SDK is a set of libraries and tools that allow developers to create . NET Core applications and libraries. It contains the following components that are used to build and run applications: ... NET Core libraries and runtime.*



**Question 2**
*What kind of applications do the following templates create? Run these commands and read the documentation. A brief summary of each template is sufficient.*

**Answer**
***dotnet new console --help***
*console application
Options:
  -h, --help          Displays help for this command.
  -l, --list          Lists templates containing the specified name. If no name is specified, lists all templates.
  -n, --name          The name for the output being created. If no name is specified, the name of the current directory is used.
  -o, --output        Location to place the generated output.
  -i, --install       Installs a source or a template pack.
  -u, --uninstall     Uninstalls a source or a template pack.
  --nuget-source      Specifies a NuGet source to use during install.
  --type              Filters templates based on available types. Predefined values are "project", "item" or "other".
  --dry-run           Displays a summary of what would happen if the given command line were run if it would result in a template creation.
  --force             Forces content to be generated even if it would change existing files.
  -lang, --language   Filters templates based on language and specifies the language of the template to create.
  --update-check      Check the currently installed template packs for updates.
  --update-apply      Check the currently installed template packs for update, and install the updates.*

***dotnet new mvc --help***
*Model View Controller
Options:
  -h, --help          Displays help for this command.
  -l, --list          Lists templates containing the specified name. If no name is specified, lists all templates.
  -n, --name          The name for the output being created. If no name is specified, the name of the current directory is used.
  -o, --output        Location to place the generated output.
  -i, --install       Installs a source or a template pack.
  -u, --uninstall     Uninstalls a source or a template pack.
  --nuget-source      Specifies a NuGet source to use during install.
  --type              Filters templates based on available types. Predefined values are "project", "item" or "other".
  --dry-run           Displays a summary of what would happen if the given command line were run if it would result in a template creation.
  --force             Forces content to be generated even if it would change existing files.
  -lang, --language   Filters templates based on language and specifies the language of the template to create.
  --update-check      Check the currently installed template packs for updates.
  --update-apply      Check the currently installed template packs for update, and install the updates.*

***dotnet new web --help***
*for creating asp.net it doesnt have mvc
Options:
  -h, --help          Displays help for this command.
  -l, --list          Lists templates containing the specified name. If no name is specified, lists all templates.
  -n, --name          The name for the output being created. If no name is specified, the name of the current directory is used.
  -o, --output        Location to place the generated output.
  -i, --install       Installs a source or a template pack.
  -u, --uninstall     Uninstalls a source or a template pack.
  --nuget-source      Specifies a NuGet source to use during install.
  --type              Filters templates based on available types. Predefined values are "project", "item" or "other".
  --dry-run           Displays a summary of what would happen if the given command line were run if it would result in a template creation.
  --force             Forces content to be generated even if it would change existing files.
  -lang, --language   Filters templates based on language and specifies the language of the template to create.
  --update-check      Check the currently installed template packs for updates.
  --update-apply      Check the currently installed template packs for update, and install the updates.*



**Question 3**
*What is the purpose of the global.json file?*

**Answer**
*It allows you to define which .NET Core SDK version is used when you run .NET Core CLI commands.*



**Question 4**
*What does the method app.UseStaticFiles() do?*

**Answer**
*Add support for http request and the static content folder (wwroot)*



**Question 5**
*What do the following two commands do?*

**Answer**
***dotnet build***
*Builds it source code turn it into byte code*
***dotnet run***
*Byte code into machine code then sends it to compiler then pc to run it*



**Question 6**
*(Not in book) You cah manage pacakges using the NuGet package manager and the command line tool dotnet add package. What are packages and what are they used for.*

**Answer**
*.NET packages are added to a project with the dotnet add package command. Most projects require additional features beyond those set up by the project templates, such as support for accessing databases or for making HTTP requests, neither of which is included in the standard ASP.NET Core packages added to the project by the template used to create the example project. In the sections that follow, I describe the tools available to manage the different types of packages that are used in ASP.NET Core development.*



**Question 7**
*What are tool packages and what are they used for?*

**Answer**
*Tool packages install command that can be used from the command line to perform operation on .NET Core porjects. Common example is the Entity Framework core tools package that installs commands that are used to manage databases in ASP.NET Core projects. They are managed using the dotnet tool command*




**Question 8**
*What are server side packages and what are they used for?*

*Answer**
*It allows us to instead store the information in a database and dynamically contruct and return HTML and other types of files. It is also possible to simply return data.*



**Question 9**
*What are client side packages and what are they used for?*

**Answer**
*Client-side packages contain content that is delivered to the client, such as images, CSS stylesheets, JavaScript files, and static HTML. Client-side packages are added to ASP.NET Core using the Library Manager (LibMan) tool. To install the LibMan tool package.*



**Question 10**
*List two ways that a developer can debug code.*

**Answer**
*1. debugger option*
*2.console.writeline to seewhat it returns*
		


