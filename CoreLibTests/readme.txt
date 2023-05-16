To generate coverage report can cobertura file format 

* change directory to the root of the test project and execute the below command
* dotnet test --collect:"XPlat Code Coverage"

To generate the HTML report from the cobertura file

* dotnet tool install -g dotnet-reportgenerator-globaltool
* change directory to the root of the test project and execute the below command
* reportgenerator -reports:'**/coverage.cobertura.xml' -targetdir:'CoverageReports' -reporttypes:Html

(The above command can also be used with absolute path or relative path, but for some reasonit may not identify the presence of the cobertura files!)