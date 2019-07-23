# Repository pattern
## Description
- de
- facilitates decoupling business logig and data access layers
- hides the details about how the data is stored or retrieved
- business logic should be agnostic to the datasource
- acts as a middle-man between the data access logic and the rest of the application
- allows you to change very easily the underlying data store/source
- Might be generic or specific:
- 
### Usage

- using Microsoft.EntityFrameworkCore.Sqlite
- define:  
`
 optionsBuilder.UseSqlite("Data Source=yourdb.db");
`

- run `Add-Migration Initial`
- run the app( you should see an employee.db in bin)
- run  `Update-Database` to apply a new migration


#### Aproach:
- start  by using directly the DbContext
- switch to using the repository and explain why is good to use that