# ASP.NET Core backend for Web Dashboard

This example is an ASP.NET Core backend application.

The Web Dashboard is a client-side control that communicates with server part using HTTP requests:

- The **client part** is a JavaScript application that supplies end users with a UI for designing a dashboard and interacting with it. The @js-DevExpress.Dashboard.DashboardControl is an underlying control.
- The **server part** is an ASP.NET Core or ASP.NET MVC application that handles client data requests and provides various backend capabilities such as accessing data, storing dashboards, etc.

## Quick Start

Run the following command to start server:

```
dotnet run
```

In the client application, use the following URL as an [endpoint](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControlOptions?p=netframework#js_devexpress_dashboard_dashboardcontroloptions_endpoint):

```
http://localhost:5000/api/dashboard
```

## Documentation

Refer to the following article for information on how to configure backend for your needs:

- [Dashboard Backend](https://docs.devexpress.com/Dashboard/402096?v=20.2)