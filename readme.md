<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T942028)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for ASP.NET Core - Backend

This example is an ASP.NET Core 3.1 backend application (server) for the [DevExpress Web Dashboard](https://docs.devexpress.com/Dashboard/115955/web-dashboard?v=20.2). The server handles client data requests and includes backend capabilities such as data access, dashboard storage, and so on.

This server contains a dashboard connected to a JSON data source. The data source obtains data from the following connection: `https://raw.githubusercontent.com/DevExpress-Examples/DataSources/master/JSON/customers.json`.

This application does not have any views. Configure and launch a client application to display data from this server.

## Quick Start

Run the following command to start server:

```
dotnet run
```

See the following section for information on how to install NuGet packages from the DevExpress NuGet feed: [Install DevExpress Controls Using NuGet Packages](https://docs.devexpress.com/GeneralInformation/115912/installation/install-devexpress-controls-using-nuget-packages).

> This server allows CORS requests from _all_ origins with _any_ scheme (http or https). This default configuration is insecure: any website can make cross-origin requests to the app. We recommend that you specify the client application's URL to prohibit other clients from accessing sensitive information stored on the server. Learn more: [Cross-Origin Resource Sharing (CORS)](https://docs.devexpress.com/Dashboard/400709)

In the client application, set the following URL as an [endpoint](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControlOptions?p=netframework#js_devexpress_dashboard_dashboardcontroloptions_endpoint):

```
http://localhost:5000/api/dashboard
```

<!-- default file list -->
## Files to Look At

* [Startup.cs](./asp-net-core-server/Startup.cs)
* [DefaultDashboardController.cs](./asp-net-core-server/DefaultDashboardController.cs)
<!-- default file list end -->


## Documentation
- [Dashboard Backend](https://docs.devexpress.com/Dashboard/402096)
    
    Refer to the article for information on how to configure backend for your needs.
    
- [Cross-Origin Resource Sharing (CORS)](https://docs.devexpress.com/Dashboard/400709)

    The article describes how to configure corresponding permissions to access resources from a server at a different origin.
    
- [Install DevExpress Controls Using NuGet Packages](https://docs.devexpress.com/GeneralInformation/115912/installation/install-devexpress-controls-using-nuget-packages)
    
    The following section contains information on how to install NuGet packages from the DevExpress NuGet feed.
    
## More Examples

- [Get Started - Client-Side Dashboard Application (Angular)](https://github.com/DevExpress-Examples/dashboard-angular-app)
- [Get Started - Client-Side Dashboard Application (React)](https://github.com/DevExpress-Examples/dashboard-react-app)
- [Get Started - Client-Side Dashboard Application (Vue)](https://github.com/DevExpress-Examples/dashboard-vue-app)
