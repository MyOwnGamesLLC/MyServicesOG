

# ServicesOG


| Catalog API   | Identity API | ISP API | Ordering API | 
| ------------- | ------------- | ------------- | ------------- |
| 		 | 		 | 		 |  		|


| Payment API   | ShoppingCart API | Webhooks API | Webpages API | 
| ------------- | ------------- | ------------- | ------------- |
| 		 | 		 | 		 |  		|



## Folder Structure

```
📁 src 
├── 📁  ApiGateways 
|	└── TODO
|
├── 📁  Services (MicroServices)
|	├── 📁  Catalog
|	├── 📁  Identity
|	├── 📁  ISP
|	├── 📁  Ordering
|	├── 📁  Payment
|	├── 📁  ShoppingCart
|	├── 📁  Webhooks
|	└── 📁  Webpages
|
└── 📁  Web 
	├── 📁  WebSPA
	├── 📁  WebhookClient
	└── TODO
```


## Each Service Folder Structure
```
📁 ServiceName 
├── 📁 ServiceName.API 
|	├── 📁  Controllers
|	│	├── 📄 	ServiceNameController.cs
|	│	└── 📄 	**Controller.cs
|	│	
|	├── 📁  Extensions
|	│	└── TODO
|	│	
|	├── 📁  Infrastructure
|	│	└── TODO
|	│	
|	├── 📁  IntegrationEvents
|	│	├── 📁  EventHandling
|	│	├── 📁  Events
|	│	├── 📄	IServiceNameIntegrationEventService.cs
|	│	└── 📄	ServiceNameIntegrationEventService.cs
|	│	
|	├── 📁  Model
|	│	├── 📄	ModelName1.cs
|	│	└── 📄	ModelName2.cs
|	│	
|	├── 📁  Properties
|	│	└── 📄	launchSettings.json
|	│	
|	├── 📁  Setup
|	│	├── 📄	ModelName1s.csv
|	│	└── 📄	ModelName2s.csv
|	│	
|	├── 📄	appsettings.json
|	├── 📄	ServiceName.API.csproj
|	├── 📄	ServiceNameSettings.cs
|	├── 📄	Dockerfile
|	├── 📄	Dockerfile.develop
|	├── 📄	Program.cs
|	├── 📄	Startup.cs
|	└── 📄	web.config
|	
├── 📁 ServiceName.FunctionalTests
|	├── 📁  Setup
|	├── 📄 	ServiceName.FunctionalTests.csproj	
|	├── 📄 	ServiceNameScenarioBase.cs
|	├── 📄 	ServiceNameScenarios.cs
|	└── 📄 	appsettings.json
|	
└── 📁 ServiceName.UnitTests
	├── 📁  Application
	└── 📄 	ServiceName.UnitTests.csproj

```



## Code Guidelines

- Follow the Microsoft AspNetCore [Engineering guidelines](https://github.com/aspnet/AspNetCore/wiki/Engineering-guidelines);
- GAMBETA **FREE** CODE
#### Git Flow

This repository follows the Git Flow branching model with the branches below:

|  |     |
| ----- |:----:|
| Master branch:   |   `master`    |
| Develop branch:  |   `develop`   |
| Feature branch prefix:  |   `feature/`  |
| Release branch prefix:  |   `release/`  |
| Hotfix branch prefix:   |   `hotfix/`   |
| Version Tag prefix:  | `v` |
|   |   |
