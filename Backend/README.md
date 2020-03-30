- Configuration steps:
1. Open project by file has extension is '.sln'
1.1. Open file MainProject.csproj if it doesn't exist
1.2. Choose File -> Save MainProject.sln in the same location
2. Use Ctrl + F5 to run source
2.1. If project can't be run, please expand Reference and check it is invalid library in Solution Explorer
2.2. To fix invalid, enter this command "Update-Package -reinstall" to Tools -> Nuget Package Manager -> Package Manager Console
3. Before commit source please turn off visual studio and choose "save" if any question's appeared, just ignore folder bin, obj, .vs
4. Content files just upload into App_Data

- Views Folder is the main
- ViewsReadMe is explaination