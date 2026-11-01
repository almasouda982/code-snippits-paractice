# Links for practice/studying

## 1. Indexing Types (revisit)
https://www.geeksforgeeks.org/dbms/indexing-in-databases-set-1/


- what is file organization which is used in indexing 

     https://www.geeksforgeeks.org/dbms/file-organization-in-dbms-set-1/

- What is disk access?
- Value base access and Range acccess
- B - trees and B + trees
- ISAM
- Clustered Indexing?
- Inner & outer & data blocks?
- DBMS?

-------------------------
Indexing types:

1. Clustered
2. Primary
3. non-clustered 
4. multi-level indexing

## 2. Dependancy Injection
https://medium.com/@shreyans_padmani/types-of-dependency-injection-9e9178094365
https://www.geeksforgeeks.org/java/types-of-dependency-injection/

Questions:

- loosly coupled?
- immunability?
- over injection?
- optional dependancies?


<B>3 Main DI</B>
1. Constructor DI
2. Property (setter)
3. Method


## 3. Entity framework object relational mapping and change tracking

Entity framework is an Object relational mapping (ORM) tool for .NET.

1. <B>Purpose:</B> it helps develop and interact with DB using C# <mark>objects</mark> instead of writing raw SQL
2. <B>DB Operations:</B> Supports CRUD with <mark>minimal</mark> SQL
3. <B>Approaches:</B> 
    - Code first: classes first then DB
    - Database first: Starts with <mark>existing DB and EF creates models</mark>
    - <mark>Model first:</mark> Create model digram, EF generates Database and the Code
    

4. <B>LINQ support:</B> Language integrated query
5. <B><mark> Change Tracking:</mark></B> Ef automatically tracks changes in objects and updates the DB
6. <B>Cross-Database:</B> works with SQL and MySQL ...
7. <B>Migration support:</B> Easily manages schema changes overtime
8. <B>Productivity:</B> Reduces boilerplate SQL code and speeds up development 


### Example:

```csharp
//This increases productivity and reduces boilerplate SQL, and makes the app more maintainable and DB independent 

var emp = _db.Employees.Find(1)
```
<b>Interview Answer</b>

An object relation mapper by microsoft for .NET apps. It allows developers to interact with the database using C# objects instead of writing complex SQL queries

1. Entity Framewrok CRUD can be easily applied using LINQ queries 

2. Supports Code, Data, and Modelfirst providing migrations to make schema changes

## 5. Normalization vs Denormalization and (why is normalization needed)

<!-- ![alt text](<normalization and denormalization.jpg>) -->

### <u>Normalization:-</u>
<p>It is a method used in db to reduce data redundancy by organizing the data into small <mark>well structured</mark> tables and reduce data <mark>in consistency</mark></p>

<b>Benifits:</b>

- Data is reduced in the table
- Optamized memory
- Maintain data integrity 

<b>Drawbacks:</b>

- Number of tables increased
- Consumes more resources when using <mark>expensive operations</mark>
- Query performance bay decrease duee to multible tables <u>joins</u>

### <u>Denormalization:-</u>

<p>A method used in DB in it adds reundancy to execute querys quickly</p>

<b>Benifits:</b>

- Executes query quickly
- fewer joins are needed
- improves read performance for complex queries

<b>Drawbacks:</b>

- Wastage of memory because of storing dublicated data
- complex data maintenance because CRUD operators because it is harder due to data reduncancy 
- does not maintain data <mark>integrity</mark> 

### Normalization and Denormalization

| Normalization | Denormalization |
|---|---|
| It stores non-redundant and consistent data in a structured schema. | It combines data from multiple tables to execute queries faster. |
| Data redundancy and inconsistency are minimized. | Data redundancy is intentionally added for faster query execution. |
| Data integrity is maintained. | Data integrity is not maintained. |
| Redundancy is reduced or eliminated. | Redundancy is added instead of being eliminated. |
| The number of tables increases. | The number of tables decreases. |
| Disk space usage is optimized. | Disk space usage is not optimized. |
| Query execution may be slower due to joins. | Query execution is faster due to fewer joins. |
| Used in OLTP systems where accuracy and consistency are important. | Used in OLAP systems where quick data retrieval and fast query responses are required. |

## 6. Design pattern mailing record approach and report

https://www.geeksforgeeks.org/system-design/software-design-patterns/

## 7. Domain Driven Design

https://www.geeksforgeeks.org/system-design/domain-driven-design-ddd/

## 8. In memory cache vs distributed cache
https://medium.com/@baraklagziel/in-memory-vs-distributed-caching-a-comparative-look-with-caffeine-15cedf6038c6

## 9. Design pattern mailing record background job modified at and batch

## 10. Try-Catch

In programming (such as Java, C#, and C++), try-catch priority follows a strict top-to-bottom order. You must order multiple catch blocks from most specific to most general.

Key Rules of Catch Block Priority

- Top-to-Bottom Evaluation: When an exception is thrown inside a try block, the runtime checks each catch block sequentially from the first one to the last one.
- First Match Wins: The runtime executes only the first catch block that matches (or can handle) the exception type, and then skips all remaining catch blocks.
- Specific Before General:
	- Place low-level, specialized exception subclasses (e.g., NullPointerException, FileNotFoundException, or DivideByZeroException) at the top.
	- Place broader, parent exception classes (e.g., Exception or Throwable) at the bottom.
- Compiler Errors for Bad Order: If you put a general exception catch block above a specific one, languages like Java will throw a compilation error (stating that the specific catch block is "unreachable").

## 11. Abstraction 

- [why is it used](https://www.geeksforgeeks.org/c-sharp/c-sharp-abstraction/)

## 12. Design pattern 

- Factory

    https://www.geeksforgeeks.org/system-design/factory-method-for-designing-pattern/

    https://www.geeksforgeeks.org/system-design/abstract-factory-pattern/

- adapter
    
    https://www.geeksforgeeks.org/system-design/adapter-pattern/

    https://medium.com/@erlandmuchasaj/adapter-design-pattern-eddc3fa6f33d
- observer

    https://www.geeksforgeeks.org/system-design/observer-pattern-set-1-introduction/

- Singleton pattern method

    https://www.geeksforgeeks.org/system-design/singleton-design-pattern/



    ---

## Resume related

### Qdrant

[Qdrand](https://www.geeksforgeeks.org/data-science/qdrant/)

### RabbitMQ

[RabbitMQ](https://www.geeksforgeeks.org/blogs/introduction-to-rabbitmq/)

### Redis

[Redis](https://www.geeksforgeeks.org/system-design/introduction-to-redis-server/)