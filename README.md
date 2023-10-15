# Feature Management In Blazor

In Microsoft's tutorial [Use feature flags in an ASP.NET Core app](https://learn.microsoft.com/en-us/azure/azure-app-configuration/use-feature-flags-dotnet-core?tabs=core6x#mvc-views), they outline how to use feature flags in an MVC application.

Nowhere is there mention of using feature flags in a Blazor Wasm application. In this project, we created a `<FeatureRender>` component to handle the Blazor Wasm use case. The component is inspired by the MVC tag helper `<feature>`.

As the examples in `FeatureManagement.Client` show, the component has two parameters: `Name` and `Requirement`. In the `Name` parameter, we can provide a comma-separated list of features. The features in the list can be negated by prepending `!` or `Not `. The `Requirement` parameter has 2 options:
* `All`: all features in the list must be enabled
* `Any`: any feature in the list must be enabled.

In our Blazor Wasm application, features are stored under `wwwroot/appsettings.json`. Other approaches include using Azure Application Configuration. This can be configured by adding `AddAzureAppConfiguration` as a configuration provider. Please see [Set up feature management](https://learn.microsoft.com/en-us/azure/azure-app-configuration/use-feature-flags-dotnet-core?tabs=core6x#set-up-feature-management) for more details.