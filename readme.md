# ASP.NET Core 3.1 backend for Web Dashboard

This example is an ASP.NET Core 3.1 backend application for the [DevExpress Web Dashboard](https://docs.devexpress.com/Dashboard/115955/web-dashboard?v=20.2).

The Web Dashboard is a client-side control that communicates with server part using HTTP requests:

- The **client part** is a JavaScript application that supplies end users with a UI for designing a dashboard and interacting with it. The [DashboardControl](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControl) is an underlying control.
- The **server part** is an ASP.NET Core or ASP.NET MVC application that handles client data requests and provides various backend capabilities such as accessing data, storing dashboards, etc.

## Quick Start

Run the following command to start server:

```
dotnet run
```
> This server allows CORS requests from _all_ origins with _any_ scheme (http or https). It is insecure because any website can make cross-origin requests to the app. We recommend you to specify the client application's URL directly to prohibit any client from getting access to your server with personal info. Learn more: [Cross-Origin Resource Sharing (CORS)](https://docs.devexpress.com/Dashboard/400709)

In the client application, use the following URL as an [endpoint](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControlOptions?p=netframework#js_devexpress_dashboard_dashboardcontroloptions_endpoint):

```
http://localhost:5000/api/dashboard
```

## Documentation
- [Dashboard Backend](https://docs.devexpress.com/Dashboard/402096?v=20.2)
    
    Refer to the article for information on how to configure backend for your needs.
    
- [Cross-Origin Resource Sharing (CORS)](https://docs.devexpress.com/Dashboard/400709?v=20.2)

    The article describes how to configure corresponding permissions to access resources from a server at a different origin.
