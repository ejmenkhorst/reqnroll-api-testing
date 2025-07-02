# reqnroll-api-testing

A portfolio project about BDD API testing with a selection of .NET based testing frameworks.

Table of Contents

- [Application under test](#application-under-test)
- [Prerequisites](#prerequisites)
- [Execute tests](#execute-tests)

## Application under test

The application under test will be the [restful-booker-platform](https://github.com/mwinteringham/restful-booker-platform) written by Mark Winteringham.

This application has a UI and API which can be thorougly tested.  
For demonstration purposes we use the deployed instance online available [Shady Meadows B&B](https://automationintesting.online)

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com) with the C# and Cucumber (Gherkin) extensions
- [Setup vscode IDE](#vscode-setup)

### Vscode setup

To make developping the feature files and implementation of the steps a breeze please configure your IDE as stated in the [online documentation](https://docs.reqnroll.net/latest/installation/setup-ide.html#setup-visual-studio-code).  
With this setup you can now easily jump between feature files and step definitions.

```json
{
  // Other IDE configuration

  // This should be added 
  "explorer.fileNesting.enabled": true,
  "explorer.fileNesting.patterns": {
    // shows *.feature.cs files as nested items
    "*.feature": "${capture}.feature.cs"
  },
  "files.exclude": {
    // excludes compilation result
    "**/obj/": true,
    "**/bin/": true
  },
  "cucumber.glue": [
    // sets the location of the step definition classes
    "${workspaceFolder}/StepDefinitions/*.cs"
  ],
  "cucumber.features": [
    // sets the location of the feature files
    "src/test/**/*.feature",
    "Features/**/*.feature"
  ],
}
```

### Frameworks used in this project

- [xunit](https://xunit.net)
- [reqnroll](https://reqnroll.net/) - BDD framework
- [rest-assured-net](https://github.com/basdijkstra/rest-assured-net) - API testing framework

## Execute tests

### Run all tests

```sh
    dotnet test
```

### Run all tests with a report

```sh
    dotnet test --logger "trx;LogFileName=test_results.trx"
```

### Run only tests with a specific filter

```sh
    dotnet test --filter "Category=smoke"
```
