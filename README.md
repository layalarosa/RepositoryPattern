# RepositoryPattern
Repository Pattern in .Net Core 5.0.1 Proyecto de Prueba.

The Web API can be texted in swagger.

The repository pattern in .NET Core
Entity Framework Core already serves as the unit of work.

The repository pattern in .NET Core
For the demo I am creating a simple 3-tier application consisting of a controller, services and repositories. Repositories will be injected into services using built-in dependency injection.

In the data project, I have my models and repositories. I create a generic repository that takes a class and offers methods like get, add or update.

Implementing the Repositories

This repository can be used for most entities. In case one of your models needs more functionality, you can create a specific repository that inherits from Repository.

The last step is to register the generic and specific repositories in the Startup class.

The first line records the generic attributes. This means that if you want to use it in the future with a new model, you don't have to register anything else. The second and third lines record the implementation.

Implementation Services that use the Repositories
I implement two services. Each service injects a repository. Inside the services, you can implement any logic your application needs. I implemented only simple repository calls, but you could also have complex calculations and multiple repository calls in a single method.

Controller implementation to test the application
To test the app I implemented a really simple controller. Controllers provide for each service method a parameterless getter method and return whatever the service returned. Each controller gets the respective service injected.

When you call the create client action, a JSON client object should be returned.

Use the database
If you want to use a database, you need to add your connection string in the appsettings.json file.



conclusion
This solution uses the entity framework core as a unit of work and implements a generic repository that can be used for most operations. I also showed how to implement a specific repository, in case the generic repository cannot meet your requirements.


