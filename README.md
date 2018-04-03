# trainning-cnx
Trainning .Net Simple Code

# Nuget require
Install-Package EntityFramework -Version 6.2.0

# Quick Memo Command
Enable-Migrations

Add-Migration NameTasks

Update-Database

# Config Connection String

```xml
     <connectionStrings>
      <add name="TodoDataContext" providerName="System.Data.SqlClient"    
          connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TodoAppData;Integrated Security=True;"/>
     </connectionStrings>
```
# Web Config


```xml
<system.web> 
  <sessionState mode="InProc" cookieless="false" timeout="1" /> 
</system.web>  
```
