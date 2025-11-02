Asp.net core Webapi Microservices Architecture ( Simple Example ) 

Microservice Architecture
├─ API Gateway
│  ├─ API Gateway.csproj
│  ├─ API Gateway.csproj.user
│  ├─ API Gateway.http
│  ├─ appsettings.Development.json
│  ├─ appsettings.json
│  ├─ Controllers
│  │  └─ WeatherForecastController.cs
│  ├─ ocelot.json
│  ├─ Program.cs
│  ├─ Properties
│  │  └─ launchSettings.json
│  └─ WeatherForecast.cs
├─ CustomerService
│  ├─ appsettings.Development.json
│  ├─ appsettings.json
│  ├─ Controllers
│  │  └─ WeatherForecastController.cs
│  ├─ CustomerService.csproj
│  ├─ CustomerService.csproj.user
│  ├─ CustomerService.http
│  ├─ obj
│  │  ├─ CustomerService.csproj.nuget.dgspec.json
│  │  ├─ CustomerService.csproj.nuget.g.props
│  │  ├─ CustomerService.csproj.nuget.g.targets
│  │  ├─ Debug
│  │  │  └─ net8.0
│  │  │     ├─ .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
│  │  │     ├─ apphost.exe
│  │  │     ├─ Customer.09A7C259.Up2Date
│  │  │     ├─ CustomerService.AssemblyInfo.cs
│  │  │     ├─ CustomerService.AssemblyInfoInputs.cache
│  │  │     ├─ CustomerService.assets.cache
│  │  │     ├─ CustomerService.csproj.AssemblyReference.cache
│  │  │     ├─ CustomerService.csproj.CoreCompileInputs.cache
│  │  │     ├─ CustomerService.csproj.FileListAbsolute.txt
│  │  │     ├─ CustomerService.dll
│  │  │     ├─ CustomerService.GeneratedMSBuildEditorConfig.editorconfig
│  │  │     ├─ CustomerService.genruntimeconfig.cache
│  │  │     ├─ CustomerService.GlobalUsings.g.cs
│  │  │     ├─ CustomerService.MvcApplicationPartsAssemblyInfo.cache
│  │  │     ├─ CustomerService.MvcApplicationPartsAssemblyInfo.cs
│  │  │     ├─ CustomerService.pdb
│  │  │     ├─ rbcswa.dswa.cache.json
│  │  │     ├─ ref
│  │  │     │  └─ CustomerService.dll
│  │  │     ├─ refint
│  │  │     │  └─ CustomerService.dll
│  │  │     ├─ rjsmcshtml.dswa.cache.json
│  │  │     ├─ rjsmrazor.dswa.cache.json
│  │  │     ├─ rpswa.dswa.cache.json
│  │  │     ├─ staticwebassets
│  │  │     ├─ staticwebassets.build.endpoints.json
│  │  │     ├─ staticwebassets.build.json
│  │  │     ├─ staticwebassets.build.json.cache
│  │  │     ├─ staticwebassets.references.upToDateCheck.txt
│  │  │     └─ staticwebassets.removed.txt
│  │  ├─ project.assets.json
│  │  └─ project.nuget.cache
│  ├─ Program.cs
│  ├─ Properties
│  │  └─ launchSettings.json
│  └─ WeatherForecast.cs
├─ Microservices
│  ├─ appsettings.Development.json
│  ├─ appsettings.json
│  ├─ Microservices.csproj
│  ├─ Microservices.csproj.user
│  ├─ Microservices.sln
│  ├─ obj
│  │  ├─ Debug
│  │  │  └─ net8.0
│  │  │     ├─ .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
│  │  │     ├─ Microservices.AssemblyInfo.cs
│  │  │     ├─ Microservices.AssemblyInfoInputs.cache
│  │  │     ├─ Microservices.assets.cache
│  │  │     ├─ Microservices.GeneratedMSBuildEditorConfig.editorconfig
│  │  │     ├─ Microservices.GlobalUsings.g.cs
│  │  │     ├─ ref
│  │  │     ├─ refint
│  │  │     ├─ rpswa.dswa.cache.json
│  │  │     ├─ staticwebassets
│  │  │     └─ staticwebassets.removed.txt
│  │  ├─ Microservices.csproj.nuget.dgspec.json
│  │  ├─ Microservices.csproj.nuget.g.props
│  │  ├─ Microservices.csproj.nuget.g.targets
│  │  ├─ project.assets.json
│  │  └─ project.nuget.cache
│  ├─ Program.cs
│  └─ Properties
│     └─ launchSettings.json
├─ OrderService
│  ├─ appsettings.Development.json
│  ├─ appsettings.json
│  ├─ Controllers
│  │  ├─ OrdersController.cs
│  │  └─ WeatherForecastController.cs
│  ├─ Model
│  │  └─ Order.cs
│  ├─ obj
│  │  ├─ Debug
│  │  │  └─ net8.0
│  │  │     ├─ .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
│  │  │     ├─ apphost.exe
│  │  │     ├─ OrderSer.4493321F.Up2Date
│  │  │     ├─ OrderService.AssemblyInfo.cs
│  │  │     ├─ OrderService.AssemblyInfoInputs.cache
│  │  │     ├─ OrderService.assets.cache
│  │  │     ├─ OrderService.csproj.AssemblyReference.cache
│  │  │     ├─ OrderService.csproj.CoreCompileInputs.cache
│  │  │     ├─ OrderService.csproj.FileListAbsolute.txt
│  │  │     ├─ OrderService.dll
│  │  │     ├─ OrderService.GeneratedMSBuildEditorConfig.editorconfig
│  │  │     ├─ OrderService.genruntimeconfig.cache
│  │  │     ├─ OrderService.GlobalUsings.g.cs
│  │  │     ├─ OrderService.MvcApplicationPartsAssemblyInfo.cache
│  │  │     ├─ OrderService.MvcApplicationPartsAssemblyInfo.cs
│  │  │     ├─ OrderService.pdb
│  │  │     ├─ rbcswa.dswa.cache.json
│  │  │     ├─ ref
│  │  │     │  └─ OrderService.dll
│  │  │     ├─ refint
│  │  │     │  └─ OrderService.dll
│  │  │     ├─ rjsmcshtml.dswa.cache.json
│  │  │     ├─ rjsmrazor.dswa.cache.json
│  │  │     ├─ rpswa.dswa.cache.json
│  │  │     ├─ staticwebassets
│  │  │     ├─ staticwebassets.build.endpoints.json
│  │  │     ├─ staticwebassets.build.json
│  │  │     ├─ staticwebassets.build.json.cache
│  │  │     ├─ staticwebassets.references.upToDateCheck.txt
│  │  │     └─ staticwebassets.removed.txt
│  │  ├─ OrderService.csproj.nuget.dgspec.json
│  │  ├─ OrderService.csproj.nuget.g.props
│  │  ├─ OrderService.csproj.nuget.g.targets
│  │  ├─ project.assets.json
│  │  └─ project.nuget.cache
│  ├─ OrderService.csproj
│  ├─ OrderService.csproj.user
│  ├─ OrderService.http
│  ├─ Program.cs
│  ├─ Properties
│  │  └─ launchSettings.json
│  └─ WeatherForecast.cs
└─ ProductService
   ├─ appsettings.Development.json
   ├─ appsettings.json
   ├─ Controllers
   │  ├─ ProductsController.cs
   │  └─ WeatherForecastController.cs
   ├─ Models
   │  └─ Product.cs
   ├─ obj
   │  ├─ Debug
   │  │  └─ net8.0
   │  │     ├─ .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
   │  │     ├─ ApiEndpoints.json
   │  │     ├─ apphost.exe
   │  │     ├─ EndpointInfo
   │  │     │  ├─ ProductService.json
   │  │     │  └─ ProductService.OpenApiFiles.cache
   │  │     ├─ ProductS.A0FC5512.Up2Date
   │  │     ├─ ProductService.AssemblyInfo.cs
   │  │     ├─ ProductService.AssemblyInfoInputs.cache
   │  │     ├─ ProductService.assets.cache
   │  │     ├─ ProductService.csproj.AssemblyReference.cache
   │  │     ├─ ProductService.csproj.BuildWithSkipAnalyzers
   │  │     ├─ ProductService.csproj.CoreCompileInputs.cache
   │  │     ├─ ProductService.csproj.FileListAbsolute.txt
   │  │     ├─ ProductService.dll
   │  │     ├─ ProductService.GeneratedMSBuildEditorConfig.editorconfig
   │  │     ├─ ProductService.genruntimeconfig.cache
   │  │     ├─ ProductService.GlobalUsings.g.cs
   │  │     ├─ ProductService.MvcApplicationPartsAssemblyInfo.cache
   │  │     ├─ ProductService.MvcApplicationPartsAssemblyInfo.cs
   │  │     ├─ ProductService.pdb
   │  │     ├─ rbcswa.dswa.cache.json
   │  │     ├─ ref
   │  │     │  └─ ProductService.dll
   │  │     ├─ refint
   │  │     │  └─ ProductService.dll
   │  │     ├─ rjsmcshtml.dswa.cache.json
   │  │     ├─ rjsmrazor.dswa.cache.json
   │  │     ├─ rpswa.dswa.cache.json
   │  │     ├─ staticwebassets
   │  │     ├─ staticwebassets.build.endpoints.json
   │  │     ├─ staticwebassets.build.json
   │  │     ├─ staticwebassets.build.json.cache
   │  │     ├─ staticwebassets.references.upToDateCheck.txt
   │  │     └─ staticwebassets.removed.txt
   │  ├─ ProductService.csproj.nuget.dgspec.json
   │  ├─ ProductService.csproj.nuget.g.props
   │  ├─ ProductService.csproj.nuget.g.targets
   │  ├─ project.assets.json
   │  └─ project.nuget.cache
   ├─ ProductService.csproj
   ├─ ProductService.csproj.user
   ├─ ProductService.http
   ├─ Program.cs
   ├─ Properties
   │  └─ launchSettings.json
   └─ WeatherForecast.cs

```