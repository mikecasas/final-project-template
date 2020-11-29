1) Create backend

```dotnet new webapi -n backend```
```dotnet new blazorwasm -n frontend```
```dotnet new classlib -n shared```

```
dotnet new sln
dotnet sln add frontend backend shared
```

* Set the solution to have multiple start-up projects.