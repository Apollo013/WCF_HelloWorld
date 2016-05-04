# WCF_HelloWorld
An 'Under The Hood' multi-assembly app that demonstrates how to create a WCF service without the use of WCF Templates. The app demonstrates how to host a service in IIS, IIS Express or a managed app using HTTP or TCP.

Developed using VS2015 Community

#####Project Layout

| Name | Type | Description|
| -- | ------ | -------- |
| HelloWorldService | Class Library | The WCF Service |
| HostDevServer | ASP.NET Web Site | Used to host our service on IIS Express |
| HelloWorldClient | Console Application | Client app used to consume our service |
| HostCmdLineApp | Console Application | A managed application for hosting our service (also consumes) |
| HelloWorldClientTcp | Console Application | Consumes our service hosted in IIS using the TCP protocol |
| HelloWorldExtension | Class Library | Assembly used to contain extension, behavior and behavior element clasess that extend our service |
| HelloWorldClientSecure | Console Application | Assembly used to demonstrate Basic Authentication |

---

#####Features

| No | Feature |
| -- | ------ |
| 1 | Creating a simple WCF Service that implements service & operation contracts |
| 2 | Hosting a WCF service in IIS Express |
| 3 | Creating a client to consume the WCF service |
| 4 | Generating the proxy and configuration files using the svcutil.exe tool |
| 5 | Hosting a WCF service in a console application |
| 6 | Hosting the service in IIS server using the HTTP protocol |
| 7 | Hosting the service in IIS server using the TCP protocol |
| 8 | Extending a WCF service to simply log incoming & outgoing messages |
| 9 | Hosting a WCF service using Basic Authentication |
| 10 | Configuring Basic Authentication on IIS |
| 11 | Configuring the HTTPS protocol on IIS by creating & binding to a self-signed certificate |
| 12 | Configuring Basic Authentication on the service itself |

---
#####Resources
| Resource | Author(s) | Chapters |
| --------- | --------- | ------- |
| WCF 4.5 Multi-Layer Services Development with Entity Framework | Mike Liu | 2, 3, 11, 12 |

