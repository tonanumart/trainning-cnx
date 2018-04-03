# trainning-cnx
Trainning .Net Simple Code

# Nuget require
Install-Package EntityFramework -Version 6.2.0

# Quick Memo Command
Enable-Migrations

Add-Migration NameTasks

Update-Database

# Config Connectoion String


  <connectionStrings>
     
     <connectionStrings>
      <add name="TodoDataContext" providerName="System.Data.SqlClient"    
          connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TodoAppData;Integrated Security=True;"/>
     </connectionStrings>
     
  </connectionStrings>
