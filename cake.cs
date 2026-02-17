#:sdk Cake.Sdk@5.1.25296.94-beta
#:package Cake.Git@4.0.0

Information("Hello world");

InstallTool("dotnet:?package=Cake.Tool&version=5.1.0");
InstallTool("nuget:?package=Cake&version=1.0.0");
