<!-- default file list -->
*Files to look at*:

* [Startup.cs](./asp-net-core-server/Startup.cs)
<!-- default file list end -->

# Dashboard for ASP.NET Core - Backend

This example is an ASP.NET Core 3.1 backend application (server) for the [DevExpress Web Dashboard](https://docs.devexpress.com/Dashboard/115955/web-dashboard?v=20.2). The server handles client data requests and includes various backend capabilities such as data access, dashboard storage, etc. 

This application does not have any views. Configure and launch a client application to display data from this server.

## Quick Start

Run the following command to start server:

```
dotnet run
```
> This server allows CORS requests from _all_ origins with _any_ scheme (http or https). This default configuration is insecure: any website can make cross-origin requests to the app. We recommend that you specify the client application's URL to prohibit other clients from accessing sensitive information stored on the server. Learn more: [Cross-Origin Resource Sharing (CORS)](https://docs.devexpress.com/Dashboard/400709)

In the client application, set the following URL as an [endpoint](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControlOptions?p=netframework#js_devexpress_dashboard_dashboardcontroloptions_endpoint):

```
http://localhost:5000/api/dashboard
```

## More Examples

- [Get Started - Client-Side Dashboard Application (Angular)](https://github.com/DevExpress-Examples/dashboard-angular-app)
- [Get Started - Client-Side Dashboard Application (React)](https://github.com/DevExpress-Examples/dashboard-react-app)
- [Get Started - Client-Side Dashboard Application (Vue)](https://github.com/DevExpress-Examples/dashboard-vue-app)

## Documentation
- [Dashboard Backend](https://docs.devexpress.com/Dashboard/402096?v=20.2)
    
    Refer to the article for information on how to configure backend for your needs.
    
- [Cross-Origin Resource Sharing (CORS)](https://docs.devexpress.com/Dashboard/400709?v=20.2)

    The article describes how to configure corresponding permissions to access resources from a server at a different origin.
