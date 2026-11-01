# Links for practice/studying

# Table of Contents

* [1. Indexing Types (revisit)](#1-indexing-types-revisit)
* [2. Dependancy Injection](#2-dependancy-injection)
* [3. Entity framework object relational mapping and change tracking](#3-entity-framework-object-relational-mapping-and-change-tracking)
* [5. Normalization vs Denormalization and (why is normalization needed)](#5-normalization-vs-denormalization-and-why-is-normalization-needed)
* [6. Domain Driven Design](#6-domain-driven-design)
* [7. In memory cache vs distributed cache](#7-in-memory-cache-vs-distributed-cache)
* [8. Design pattern mailing record background job modified at and batch](#8-design-pattern-mailing-record-background-job-modified-at-and-batch)
* [9. Try-Catch](#9-try-catch)
* [10. Abstraction](#10-abstraction)
* [11. Design pattern](#11-design-pattern)

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




## 6. Domain Driven Design

https://www.geeksforgeeks.org/system-design/domain-driven-design-ddd/

What Is Domain-Driven Design (DDD)?
DDD is an approach that emphasizes modeling software based on the reality of the business domain. Here’s why it matters:

Business Alignment: DDD ensures that your software closely represents the business requirements and goals. It bridges the gap between technical implementation and business understanding.
Quality and Maintainability: By explicitly modeling the domain, you improve software quality, maintainability, and scalability.
Key Concepts in DDD
1. Bounded Contexts
Each Bounded Context corresponds to a microservice or a specific problem area. It defines a boundary around a domain subset and encourages a common language (ubiquitous language) for discussing domain problems.

2. Entities and Aggregates
Entities: Objects with a distinct, continuous identity (e.g., a User with an Id and Name).
Aggregates: Clusters of domain objects grouped together for transactional consistency (e.g., an Order aggregate with related entities).
3. Application, Domain, and Infrastructure Layers
Application Layer: Handles requests, validates input, and interacts with the Domain Layer. Includes controllers, system configurations, and payload delivery to clients.
Domain Layer: Contains most of the business logic. Defines concepts, behaviors, and rules. Avoids hard dependencies on infrastructure technologies (e.g., Entity Framework).
Infrastructure Layer: Handles database access. Interacts with the Domain Layer through defined behaviors and rules. Responsible for storage operations (e.g., CRUD, updates, removal).


---
### DDD Layers

In Domain-Driven Design (DDD), an application is split into four distinct layers to separate business logic from technical details.
Here is exactly what exists inside each layer, ordered from the core business logic outward:

1. Domain Layer (The Core)

This is the heart of the application. It contains the pure business logic, rules, and data structures that represent the problem you are solving. It has zero dependencies on databases, UI, or frameworks.
• Entities: Objects with a unique identity that persists over time (e.g., a User with an ID, where the name might change but it remains the same user).
• Value Objects: Objects defined solely by their attributes, with no identity. They are immutable (e.g., a Money object with an amount and currency, or an Address).
• Aggregates: A cluster of associated Entities and Value Objects treated as a single unit for data changes. It has a single "Aggregate Root" through which all external interactions flow.
• Domain Services: Logic that belongs to the business domain but doesn't naturally fit inside a single Entity or Value Object (e.g., a complex calculation involving multiple aggregates).
• Domain Events: Indications that something significant has happened in the business domain (e.g., OrderPlaced, AccountDeactivated).
• Repository Interfaces: Definitions (interfaces) of how to save and fetch aggregates. The actual implementation lives in the Infrastructure layer.

2. Application Layer (The Orchestrator)

This layer acts as a mediator or conductor. It coordinates the workflow of the application but does not contain business rules or perform database operations directly.
• Application Services: Classes that handle specific use cases (e.g., RegisterUserWorkflow). They coordinate fetching a domain aggregate, telling it to perform an action, and saving it back.
• Commands and Queries: Input models representing user intent (e.g., CreateOrderCommand) often used in CQRS patterns.
• DTOs (Data Transfer Objects): Simple data structures used to pass data in and out of the application layer without exposing the underlying domain objects.
• Event Handlers: Components that listen to domain events and trigger subsequent application workflows or external actions.

3. Infrastructure Layer (The Mechanic)

This layer contains all the technical implementation details and concrete implementations of abstractions defined in inner layers. It supports communication with external systems.
• Repository Implementations: The concrete code that talks to your database (using ORMs like Hibernate, Entity Framework, or raw SQL) to save and load aggregates.
• External API Clients: Gateways and clients to communicate with third-party services (e.g., payment gateways, SMS providers).
• Persistence Models: Database-specific schemas or models if they differ from domain entities.
• Configuration & Frameworks: Logging implementations, caching mechanisms, messaging queues (e.g., RabbitMQ, Kafka adapters), and dependency injection setups.

4. User Interface / Presentation Layer (The Face)

This layer is responsible for presenting information to the user and capturing user input. It translates external interactions into commands the application layer can understand.
• Controllers / Presenters: HTTP endpoints (REST, GraphQL, gRPC controllers) or MVC controllers that receive requests.
• View Models / API Responses: Data formats tailored specifically for frontend or API consumer consumption.
• UI Components: Web pages, mobile screens, CLI scripts, or views (if the frontend is coupled with the backend).
To help visualize how they interact, here is a quick overview of how code and dependencies flow:

Layer	Primary Responsibility	Knows About / Depends On
User Interface	Accepts user input, returns responses.	Application
Application	Coordinates use cases and workflows.	Domain
Domain	Holds pure business logic and rules.	Nothing (Completely isolated)
Infrastructure	Implements technical details (DB, Network).	Domain, Application

Would you like to see a code example of how a specific use case flows through these layers, or are you looking to map this to a specific programming framework?

---

The database connects to this architecture through a process called Dependency Injection (DI), which acts as the wiring system for your application.
The application startup configuration binds the database to the infrastructure repository, and then passes that repository into the business logic.
Here is the step-by-step breakdown of how the database safely connects without messing up the clean DDD layers:

1. The Database Client lives in Infrastructure

Your actual database connection pool, ORM context (like Entity Framework's DbContext, Hibernate's SessionFactory, or a Prisma client), and connection strings live entirely inside the Infrastructure Layer. No other layer knows your actual database technology exists.

2. The Dependency Injection "Wiring" Step

When your application boots up, a central configuration file (usually in the Infrastructure or a separate Composition Root/Startup file) wires everything together.
You tell your framework's DI container: "Whenever a piece of code asks for IUserRepository, automatically create a SqlUserRepository and hand it over—and make sure to give that repository the active database connection."
Example Configuration (Conceptual):
csharp
// At application startup:
services.AddDbContext<MyDbContext>(options => options.UseSqlServer("ConnectionString"));
services.AddScoped<IUserRepository, SqlUserRepository>(); 
Use code with caution.

3. The Execution Flow (How it plays out)

When a user clicks a button on the UI, here is how the database context is handed down like a relay baton:
[ 1. User Interface ]
      │  Receives request (e.g., POST /user)
      ▼
[ 2. Application Layer ]
      │  Wants to run the use case: "RegisterUser"
      │  It asks the framework: "Hey, give me whatever implements IUserRepository!"
      │  Framework injects: SqlUserRepository (pre-loaded with the Database Context)
      ▼
[ 3. Domain Layer ]
      │  Executes business rules on the entity (e.g., user.Activate())
      │  Application layer passes the entity to the injected repository: repository.Save(user)
      ▼
[ 4. Infrastructure Layer ]
         The SqlUserRepository takes the entity, converts it into a SQL statement,
         and pushes it into the actual Database.

Why do it this way?

Because the Application Layer and Domain Layer only ever touch the IUserRepository interface, they have no idea a real SQL database is running in the background.
If you decide to swap your SQL database for MongoDB tomorrow, you only change the Infrastructure Layer and the Startup Configuration. The core business logic in your Domain and Application layers remains 100% untouched.
Would you like to see how this Dependency Injection looks inside an Application Service constructor, or are you curious about how Database Models (Entities) are mapped to Domain Entities?

## 7. In memory cache vs distributed cache
https://medium.com/@baraklagziel/in-memory-vs-distributed-caching-a-comparative-look-with-caffeine-15cedf6038c6

<b>In-Memory Caching:</b>

Primarily local to the application’s process, it excels in scenarios requiring rapid data access with minimal latency. It’s straightforward in deployment but is constrained by the memory capacity of the hosting server and lacks inherent scalability across multiple nodes or services.


<b>Distributed Caching:</b>

Spreads data across several servers or instances in a network, ensuring availability and resilience in distributed systems. While it addresses scalability and data consistency challenges present in in-memory caching, it introduces complexity in cache management and potential latency due to network overhead.



<b>Cache stratgies</b>

1. Cache-Aside: 

Read Operations

a. Check the cache: The application queries the in-memory cache (like Redis or Memcached) first for the requested data.

b. Cache Hit: If the data is found in the cache, it is returned immediately to the client, bypassing the database.

c. Cache Miss: If the data is missing from 
the cache, the application queries the primary database to retrieve the actual record.

d. Populate cache: The application takes the database result, stores a copy in the cache (often with a Time-To-Live or TTL), and returns the data to the

2. Read-Through: 
<p>
Read-through is a form of lazy-load caching similar to the cache-aside strategy. However, unlike cache-aside, your app is unaware of the data store. So, it queries the database by the caching mechanism instead. By delegating database reads to the cache component, your application code becomes cleaner — but at the expense of configuring extra caching components for database credentials.
</p>

3. Write Through:
<p>Write-through is a caching strategy where your application delegates database operations to the cache (similarly to the read-through cache, but for writes). Your app updates the cache, which then synchronously writes the new data to the database. This process slows the writing operation but ensures cache consistency and reliability. Developers use this strategy when consistency is a significant concern, and the application doesn’t frequently write data to the cache.</p>

## 8. Design pattern mailing record background job modified at and batch






When handling high-volume email operations via background jobs, the core challenge is ensuring data consistency and efficiency. The transactional outbox pattern combined with idempotent consumers and state-tracking columns (modified_at, batch_id) is the industry-standard design pattern for this use case.
This approach ensures that emails are sent reliably (at-least-once or exactly-once delivery) without blocking user-facing HTTP requests or creating race conditions.

🗺️ System Architecture Overview

Instead of sending an email directly during a user action, you write a "Mailing Record" to your database in the same database transaction as the business logic. A background worker then polls, batches, and processes these records.
[ User Action ] ──> [ DB Transaction: Save Data + Create Mailing Record (Status: Pending) ]
                                                               │
                                                               ▼
[ External ESP ] <── [ Background Job Workers: Process & Update Record (Status: Sent) ]

🗄️ Database Schema Design

Your mailing_records table acts as a state machine. The fields modified_at (or updated_at) and batch_id serve specific technical purposes to handle concurrency and tracking.
• id (UUID / BigInt): Unique identifier.
• status (Enum): pending, processing, sent, failed.
• batch_id (UUID / Nullable): Grouping identifier assigned by the worker to prevent double-processing.
• modified_at (Timestamp): Tracks when the status or batch last changed. Used for timeout recovery.
• retry_count (Integer): Prevents "poison pill" records from crashing the worker indefinitely.

⚙️ Step-by-Step Processing Pattern

To process emails efficiently using modified_at and batch_id, the background worker executes a three-step lifecycle: Lock, Execute, and Update.

1. The "Lock & Batch" Phase (Optimistic Concurrency)

Multiple worker threads might run simultaneously. To prevent two workers from picking up the same pending emails, use an atomic database update to claim a chunk of records under a unique batch_id.
sql
-- Generate a unique Batch ID in your worker code (e.g., 'b83f92a1...')
-- Lock 100 pending records at a time safely

UPDATE mailing_records
SET 
    status = 'processing',
    batch_id = 'b83f92a1-3904-4b53-9bb6-bf2debc2b6f1',
    modified_at = NOW()
WHERE id IN (
    SELECT id 
    FROM mailing_records 
    WHERE status = 'pending'
    ORDER BY created_at ASC 
    LIMIT 100
    FOR UPDATE SKIP LOCKED -- Prevents database deadlocks across multiple workers
);
Use code with caution.

2. The Execution Phase

The worker fetches only the records assigned to its specific batch_id.
• The worker reads the batch from the database.
• It aggregates the emails (often formatting them as a single bulk request if supported by your Email Service Provider like SendGrid, Mailgun, or AWS SES).
• It sends the network request to the provider.

3. The Resolution Phase

Once the provider responds, the worker updates the records based on the result.
• Success: Mark records as sent and clear or keep the batch_id for audit trails.
• Failure: Mark records as failed, increment retry_count, reset status to pending (if retries remain), and update modified_at.

🛡️ Edge Cases & The Role of modified_at

The modified_at column is your safety net for handling distributed system failures:
-  Stuck/Crashed Workers: If a worker machine dies mid-delivery, records will stay stuck in processing status with a specific batch_id.
-  The Reaper Job: Run a secondary background "Reaper" cron job every 15 minutes. It looks for records where status = 'processing' AND modified_at < NOW() - INTERVAL '10 minutes'.
-  The Fix: The reaper resets those stuck records back to pending and nullifies the batch_id, allowing healthy workers to pick them up again.
To help me tailor this architectural pattern closer to your specific codebase, could you share:
-  The programming language or framework you are building this in (e.g., Node.js, Python/Celery, Ruby on Rails/Sidekiq, .NET)?
-  The type of database you are using (e.g., PostgreSQL, MySQL, MongoDB)?
-  The expected scale of your mailing system (e.g., hundreds per day vs. millions per hour)?


Yes, exactly. Your prompt was the core foundation for a mailing records background job system.
The terms you provided in your prompt map directly to the architectural components of that pattern:
-  "Mailing record" represents the database table acting as your Transactional Outbox (the state machine tracking each email).
-  "Background job" is the asynchronous worker process that pulls records from that table so your main application stays fast and responsive.
-  "Batch" (batch_id) is the mechanism the worker uses to safely group records, preventing multiple workers from accidentally sending the same email twice.
-  "Modified at" (modified_at) is the timestamp safety net used to detect and rescue stuck or crashed email jobs.
You provided the exact data points required to make a distributed background email system reliable and fault-tolerant.
If you're working on implementing this right now, let me know:
-  What programming language / framework (e.g., Python, Node.js, Spring Boot) are you using?
-  What database (e.g., PostgreSQL, MySQL) is powering it?
I can provide the exact code or ORM queries needed to set it up!

The core architecture you described relies on the Transactional Outbox Pattern.
When implemented specifically for background workers handling state transitions via fields like batch_id and modified_at, it combines three interconnected design patterns:

1. The Transactional Outbox Pattern (Core Architecture)

Instead of sending the email directly during a user action (which could fail or slow down the app), you save the email data into a mailing_records table within the same database transaction as your main business logic.
• Why it matters: If your database update succeeds, the email record is guaranteed to be saved. If the business logic fails, the database rolls back, and no phantom email is sent.

2. Idempotent Consumer / Lock-Free Queue Pattern (The "Batch" Element)

When background workers pull these records in a Batch, they use atomic database queries (like SELECT ... FOR UPDATE SKIP LOCKED or unique batch_id assignments) to dynamically claim rows.
• Why it matters: This allows you to scale up multiple background workers safely. Each worker isolates its own batch using the batch_id, ensuring no two workers accidentally process or send the same email twice.

3. State Machine & Dead Letter / Recovery Pattern (The "Modified At" Element)

Your mailing record moves through distinct states (pending → processing → sent / failed). The modified_at timestamp tracks the pulse of this state machine.
-  Why it matters: It enables the Reaper Pattern (a fault-tolerance pattern). If a worker crashes mid-send, the system knows a batch is "dead" because its status is stuck in processing but its modified_at timestamp hasn't changed in a long time, allowing a recovery job to safely reset it.



---
### approach and report


To implement this pattern effectively, you need a structured operational Approach to guide development, followed by a data-driven Report structure to monitor system health and catch deliverability issues.

⚙️ The Approach (Implementation Blueprint)

The implementation approach is broken down into three distinct phases: Ingestion, Execution, and Recovery.

Phase 1: Safe Ingestion (The Application Side)

1. Atomic Write: When a user triggers an action (e.g., signs up), open a database transaction.
2. Insert Data: Write the new user to the users table and simultaneously insert a row into the mailing_records table.
3. Commit: Commit the transaction. The email is now safely queued in the database. The user's web request completes instantly without waiting on a slow external email API.

Phase 2: Orchestrated Batching (The Worker Side)

1. Generate Batch Ticket: The worker boots up and generates a unique ID (e.g., a UUID string).
2. Claim the Batch: The worker executes a single, atomic SQL query to update a fixed number of rows (e.g., 500 rows) matching status = 'pending'. It sets their batch_id to its unique ID, changes the status to processing, and sets modified_at = NOW().
3. Bulk Dispatch: The worker fetches the rows matching its batch_id, compiles them, and passes them to the Email Service Provider (ESP) using a bulk/batch endpoint to minimize network overhead.
4. Finalize State:
	• If the ESP succeeds: Update rows matching the batch_id to status = 'sent' and modified_at = NOW().
	• If the ESP fails: Increment retry_count. If under the threshold, revert to status = 'pending'. If over, mark as failed. Update modified_at.

Phase 3: The Recovery Sweeper (The Safety Net)

1. Cron Poller: Run a small scheduled cron job every 5 to 10 minutes.
2. Identify Zombie Batches: Search for rows where status = 'processing' AND modified_at is older than a reasonable timeout window (e.g., 15 minutes ago).
3. Unlock: Revert those rows back to status = 'pending' and clear the batch_id so other workers can safely attempt them again.

📊 The Report (Monitoring & Operational Intelligence)

Because this background job operates entirely out of sight, you need an operational report. This report should look at your mailing_records table through two lenses: Real-Time Health (Infrastructure) and Historical Trends (Analytics).

1. Real-Time Operations Report (System Health)

This is a live dashboard view designed to catch processing bottlenecks or worker crashes.

Metric	Query Logic	What it Tells You	Action Required
Queue Backlog	Count of rows where status = 'pending'	Indicates system latency.	If this number is spiking, you need to spin up more background worker instances.
Active Throughput	Count of distinct batch_ids where status = 'processing'	Shows how many workers are actively processing right now.	If this drops to zero while backlog is high, your workers are dead.
Stuck/Zombie Rows	status = 'processing' AND modified_at < NOW() - 15 mins	Identifies jobs that crashed mid-execution.	If this is greater than zero, the Recovery Sweeper isn't running or workers are hitting hard system crashes (OOM errors).


2. Historical Performance Report (Delivery & Quality)

This report aggregates past records (usually grouped daily or weekly) using the modified_at field as the historical timestamp.
• Batch Delivery Efficiency: Measures the average time elapsed between a record's creation and its final modified_at timestamp when status = 'sent'. (Target should be < 5 seconds).
• Blast Volume Tracking: A chart aggregating COUNT(id) GROUP BY batch_id, DATE(modified_at). This helps marketing and product teams see exactly how many transactional or marketing blasts went out during specific time frames.
• Failure & Exhaustion Rates: A breakdown of failed records grouped by error categories or common traits. If a specific batch has an unusually high retry rate, it pinpoints bad downstream data (e.g., a broken email template or a blocklist from a specific provider).


Here is the complete implementation blueprint and reporting framework for the Transactional Outbox Pattern utilizing batch_id and modified_at.

⚙️ The Approach (Implementation Blueprint)


Phase 1: Safe Ingestion (The Application Side)

When a user triggers an event (like a sign-up), the application writes both the user data and the email intent into the database inside a single database transaction.
python
# Example using Python and a generic SQL/ORM context
def register_user(user_data):
    # Open a single, atomic database transaction
    with db.transaction():
        # 1. Insert user into the core business table
        user = db.execute(
            "INSERT INTO users (email, name) VALUES (%s, %s) RETURNING id", 
            (user_data['email'], user_data['name'])
        )
        
        # 2. Insert the mailing record into the Outbox table
        db.execute(
            """
            INSERT INTO mailing_records (user_id, email_type, recipient, status, created_at, modified_at)
            VALUES (%s, 'welcome_email', %s, 'pending', NOW(), NOW())
            """,
            (user['id'], user_data['email'])
        )
    # The HTTP request resolves instantly. The user does not wait for the network call to the ESP.
Use code with caution.

Phase 2: Orchestrated Batching (The Worker Side)

Background workers run continuously. They grab chunks of pending emails concurrently using an atomic SQL lock to avoid race conditions.
python
import uuid
import time

def process_email_batch():
    # 1. Generate a unique ticket for this specific worker instance
    worker_batch_id = str(uuid.uuid4())
    batch_size = 100

    # 2. Claim the batch atomically using PostgreSQL SKIP LOCKED mechanics
    claimed_rows = db.execute(
        """
        UPDATE mailing_records
        SET 
            status = 'processing',
            batch_id = %s,
            modified_at = NOW()
        WHERE id IN (
            SELECT id 
            FROM mailing_records 
            WHERE status = 'pending'
            ORDER BY created_at ASC 
            LIMIT %s
            FOR UPDATE SKIP LOCKED
        )
        RETURNING id, recipient, email_type;
        """,
        (worker_batch_id, batch_size)
    )

    if not claimed_rows:
        return # No pending mail to process

    # 3. Bulk Dispatch to the Email Service Provider (ESP)
    try:
        # Abstracted call to an provider API like SendGrid or AWS SES
        esp_client.send_bulk_emails(claimed_rows)
        
        # 4a. Success path: Mark the entire batch as sent
        db.execute(
            """
            UPDATE mailing_records
            SET status = 'sent', modified_at = NOW()
            WHERE batch_id = %s
            """,
            (worker_batch_id,)
        )
    except Exception as e:
        # 4b. Failure path: Increment retries or fail out
        db.execute(
            """
            UPDATE mailing_records
            SET 
                retry_count = retry_count + 1,
                status = CASE WHEN retry_count >= 3 THEN 'failed' ELSE 'pending' END,
                batch_id = NULL,
                modified_at = NOW()
            WHERE batch_id = %s
            """,
            (worker_batch_id,)
        )
Use code with caution.

Phase 3: The Recovery Sweeper (The Safety Net)

A lightweight cron job scans for tasks that started processing but never finished due to worker crashes (e.g., an Out-Of-Memory error or hardware failure).
sql
-- The Reaper Cron Query (Runs every 5 minutes)
-- Rescues records that have been stuck in 'processing' for more than 15 minutes
UPDATE mailing_records
SET 
    status = 'pending',
    batch_id = NULL,
    modified_at = NOW(),
    retry_count = retry_count + 1
WHERE status = 'processing' 
  AND modified_at < NOW() - INTERVAL '15 minutes';
Use code with caution.

📊 The Report (Monitoring & Operational Intelligence)


1. Real-Time Operations Report (Dashboard Queries)

Use these queries to populate a real-time system monitoring dashboard.
sql
-- 1. Queue Backlog: How many emails are waiting to be processed?
SELECT COUNT(*) AS pending_backlog 
FROM mailing_records 
WHERE status = 'pending';

-- 2. Worker Concurrency: How many batches are actively being pushed right now?
SELECT COUNT(DISTINCT batch_id) AS active_worker_batches 
FROM mailing_records 
WHERE status = 'processing';

-- 3. Dead/Stuck Jobs: Are there zombie processes requiring immediate attention?
SELECT COUNT(*) AS zombie_records 
FROM mailing_records 
WHERE status = 'processing' 
  AND modified_at <br NOW() - INTERVAL '15 minutes';
Use code with caution.

2. Historical Performance Report (Analytics Framework)

This summary table uses modified_at as the historical anchor to evaluate performance trends.
sql
-- Raw SQL behind the trend analysis reporting table below
SELECT 
    DATE(modified_at) AS processing_date,
    COUNT(id) AS total_processed,
    ROUND(AVG(EXTRACT(EPOCH FROM (modified_at - created_at))), 2) AS avg_delay_seconds,
    COUNT(CASE WHEN status = 'sent' THEN 1 END) AS successful_sends,
    COUNT(CASE WHEN status = 'failed' THEN 1 END) AS permanent_failures
FROM mailing_records
WHERE modified_at >= NOW() - INTERVAL '7 days'
GROUP BY DATE(modified_at)
ORDER BY processing_date DESC;
Use code with caution.

Date	Total Processed	Avg Delay (Created ➔ Sent)	Successful Sends	Permanent Failures
2026-11-01	145,200	2.14 seconds	145,050	150 (Bad Addresses)
2026-10-31	189,430	1.85 seconds	189,400	30
2026-10-30	122,010	12.45 seconds *	121,900	110

*Note: High Average Delay on 2026-10-30 indicates worker starvation or API rate-limiting issues during peak hours, signaling a need to spin up more consumer containers.




## 9. Try-Catch

In programming (such as Java, C#, and C++), try-catch priority follows a strict top-to-bottom order. You must order multiple catch blocks from most specific to most general.

Key Rules of Catch Block Priority

- Top-to-Bottom Evaluation: When an exception is thrown inside a try block, the runtime checks each catch block sequentially from the first one to the last one.
- First Match Wins: The runtime executes only the first catch block that matches (or can handle) the exception type, and then skips all remaining catch blocks.
- Specific Before General:
	- Place low-level, specialized exception subclasses (e.g., NullPointerException, FileNotFoundException, or DivideByZeroException) at the top.
	- Place broader, parent exception classes (e.g., Exception or Throwable) at the bottom.
- Compiler Errors for Bad Order: If you put a general exception catch block above a specific one, languages like Java will throw a compilation error (stating that the specific catch block is "unreachable").

## 10. Abstraction 

- [why is it used](https://www.geeksforgeeks.org/c-sharp/c-sharp-abstraction/)

## 11. Design pattern 

https://www.geeksforgeeks.org/system-design/software-design-patterns/


- what are design patterns?

    reusable solutions to commen software design problems which help devs build cleaner and more maintainable systems so they act as templeates for solving issues related to object creation, structurem and behavior instead of coplete code

1. provides standard terminology and best practice making communicationeasier among developers
2. helps create structured, scalable, and maintainable code by prooting proven design approaches 
3. reduces development time by offering ready-made solutions

Charesteristics:

- <b>Reusibility:</b> patterns can be applied to different projects saving time and effort in solving similar issues
- <b>Standardization:</b> They provied shared language amongs developers 
- <b>Efficiency</b> by using these patterns developers aviod finding the solution to recurring problems 

- <b>Flexibility</b>: 

Design patterns are a valuable tool in software development, and they offer various benefits and uses, some of them are explained below :

Cross-Platform Support : Design patterns are not tied to a specific programming language or platform. They are general guidelines that can be applied across different technologies, making it easier to adapt your code to different environments.

Improving Scalability: Design patterns, particularly structural patterns, allow us to create a flexible and extensible architecture, making it easier to add new features or components.

Simplifying Complex Problems: Complex software problems can be broken down into smaller, more manageable components using design patterns. This simplifies development by addressing one problem at a time and, in turn, makes the code more maintainable.

Enhancing Collaboration: Design patterns provide a common language and a shared understanding among team members. They enable developers to communicate effectively and collaborate on software projects by referring to well-known design solutions.

Improving Testability: Code designed with patterns in mind is often more modular and easier to test. we can write unit tests for individual components or classes, leading to more reliable and robust software.

Promoting Code Reusability: Design patterns encapsulate solutions to recurring design problems. By using these patterns, we can create reusable templates for solving specific problems in different parts of your application.

Enhancing Maintainability: Design patterns help organize code in a structured and consistent way. This makes it easier to maintain, update, and extend the codebase. Developers familiar with the patterns can quickly understand and work on the code.

---

### Creational Design Patterns

- Factory method and abstract

    https://www.geeksforgeeks.org/system-design/factory-method-for-designing-pattern/

    The Factory Method is a creational design pattern that defines an interface for creating objects but lets subclasses decide which object to instantiate. It promotes loose coupling by delegating object creation to a method, making the system more flexible and extensible.

    - Subclasses override the factory method to create specific object types, enabling flexible object creation.

    - Supports easy addition of new product types and improves maintainability and adaptability at runtime.

Real World Applications

    The Factory Method Pattern is widely used in software development to create objects dynamically while keeping the client code independent of their concrete classes.

    - Payment systems: A payment system can create different payment processors such as card, UPI, or wallet processors.

    - Game development: A game can create different enemies, weapons, or items depending on the game level or environment.

    - Document processing: An application can create different document objects such as PDF, Word, or text documents.

    - Notification systems: An application can create Email, SMS, or Push notification objects based on the required notification type.

Components

    The main components of Factory Design Pattern:

    - Creator: This is an abstract class or an interface that declares the factory method. The creator typically contains a method that serves as a factory for creating objects. It may also contain other methods that work with the created objects.

    - Concrete Creator: Concrete Creator classes are subclasses of the Creator that implement the factory method to create specific types of objects. Each Concrete Creator is responsible for creating a particular product.

    - Product: This is the interface or abstract class for the objects that the factory method creates. The Product defines the common interface for all objects that the factory method can create.

    - Concrete Product: Concrete Product classes are the actual objects that the factory method creates. Each Concrete Product class implements the Product interface or extends the Product abstract class.

    https://www.geeksforgeeks.org/system-design/abstract-factory-pattern/

- Singleton pattern method

    https://www.geeksforgeeks.org/system-design/singleton-design-pattern/

    
    The Singleton Design Pattern ensures that a class has only one instance and provides a global access point to it. It is used when we want centralized control of resources, such as managing database connections, configuration settings or logging.

    - Prevents accidental creation of multiple instances and ensures controlled, efficient use of resources like memory and connections.
    - Simplifies coordination across different parts of the application by providing a single shared instance.

    Real-World Applications

    - Logging Systems : Maintain a consistent logging mechanism across an application.
    - Configuration Managers : Centralize access to configuration settings.
    - Database Connections : Manage a single point of database access.
    - Thread Pools : Efficiently manage a pool of threads for concurrent tasks.



---

The Abstract Factory Pattern is a creational design pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes. It acts as a "factory of factories," where a super-factory creates other factories that in turn produce specific objects.

Works around a super-factory that produces multiple factories.
Concrete factories created at runtime decide the actual product types.
Useful when the system needs to be independent of how products are created or represented.
Makes it easy to switch between different groups of related objects without code changes.

---

### Structural Design Patterns

- adapter
    
    https://www.geeksforgeeks.org/system-design/adapter-pattern/

    https://medium.com/@erlandmuchasaj/adapter-design-pattern-eddc3fa6f33d

---
### Behavioral Design Patterns

- observer

    https://www.geeksforgeeks.org/system-design/observer-pattern-set-1-introduction/



    ---

## Resume related

### Qdrant

[Qdrand](https://www.geeksforgeeks.org/data-science/qdrant/)

### RabbitMQ

[RabbitMQ](https://www.geeksforgeeks.org/blogs/introduction-to-rabbitmq/)

### Redis

[Redis](https://www.geeksforgeeks.org/system-design/introduction-to-redis-server/)

### OOP and polymorphyosm

https://www.geeksforgeeks.org/cpp/difference-between-inheritance-and-polymorphism/