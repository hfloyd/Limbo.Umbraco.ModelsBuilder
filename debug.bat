@echo off
dotnet build src/Limbo.Umbraco.ModelsBuilder --configuration Debug /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=c:/nuget