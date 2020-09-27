# Cubes Technical Test

**Cube intersection**
_Design and start and application (or test project) which accepts as input dimensions
and coordinates of two cubic objects (considering a 3D space). The application must determine
whether the two objects collide and calculate the intersected volume.
It's not a math exercise, so it is acceptable to consider the two cubes are parallel, so
there is no rotation among themselves.
The input coordinates define the center of the cube.
The purpose of this exercise is to define the application design and architecture,
focusing on the parts which ensure the correctness, performance and code clarity. Any design
pattern is accepted and should be justified.
Max time: 1h._

## How to execute 

CubesTechnicalTest.exe Cube1Name X Y Z Length Cube2Name X Y Z Length  
  
Cube1Name/Cube2Name: Names of the 2 cubes. (string)  
X Y Z: 3D Coordinates (double)  
Length: Length of the Cube edges.

## Arquitecture 

_This project is splitted in diferent layers using the Clean Architecture methodology described here (https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures). Here you can find an explanation of each layer:_

1. CubesTechnicalTest: ASP .NET Core App console 3.1. It contains the app console logic and it' splitted in 3 parts:
- Dependecy injection. I have created a separated project in Infrastructure to load all the DI in this separated project.
- Parameters validation. I have created a separated static class to be able to check all the parameters and load the Cubes data.
- Business logic Execution. The app will call to the Core layer to execute the business logic.
2. CubesTechnicalTest.Core: It contains all the business logic. there aren't any dependecy with other projects, it's totally isolated to mantain the independecy. Here we'll find the Interfaces, models, entities, DTOs and Services.
3. Infrastructure.DependencyBuilder: It contains all the dependecy injections. If you add a new service or repository class, you will need to add the injection here.
4. Infrastructure.Geometry: It contains Geometry logic, I have created this separated logic to show the whole picture of the architecture chosen, but probably this logic could have built in the Core layer.
5. CubesTechnicalTest.Test: Unit test project.

If you need to add any dependency, add a new infrastructure project like I have done with Infrastructure.DependencyBuilder
and create Interfaces in Core layer to be able to call the new dependency to follow the Onion architecture.


## Authors ✒️

* **Oscar Rodríguez** - *Developer. https://www.linkedin.com/in/oscar-rodriguez-lopez-70b2a337/* 

