# Join And Navigation Property

## 1. Navigation Property

**Definition:**

- It is a property __provided by EF Core__ which you can add
  in your entity class and it __work as pointr to another related entity__.
- EF Core automatically uses the __foreign key relationships__ to load related 
  data through this property.

**Purpose:**

- It define relationships between entities, such as:
  - One-to-One (e.g., Department ↔ Manager).
  - One-to-Many (e.g., Student ↔ Department).
  - Many-to-Many (e.g., Student ↔ Course).

- It allows you to navigate from one entity to another related entity without
  having to write a join query.

**Why It's Important:**

- It simplifies data access by allowing you to navigate through related entities
  without writing complex queries.
- Great for readability, less code, and automatic relationship handling.
- Perfect when working within your domain model and you don’t need a custom join.

**Disadvantage:**

- It can lead to performance issues if not used carefully, especially with large datasets.
- EF Core decides join behavior so you will not be having full control over the
  join operation.
- Only works for relationships defined in the EF model.

**Usage:**

- To directly access related entity data through object references (set and get).
````csharp
var student = _context.Students.First();
Console.WriteLine(student.Department.DepartmentName); // direct access to related entity ...

````
- To perform query operations (e.g., filtering, sorting) on related entities.

  - In-memory queries → When the related data is already loaded into 
	application memory (operates on objects).

````csharp
var students = _context.Students.ToList(); // Loads all
var filtered = students
    .Where(s => s.Department.DepartmentName == "IT")
    .ToList(); // Runs in memory
````

  - Database queries → When the related data is accessed in a way that 
	EF Core translates into a SQL query and executes it directly 
	in the database (operates on entities in the database).
	
````csharp
var students = _context.Students
    .Where(s => s.Department.DepartmentName == "IT")
    .ToList(); // Runs in DB

````
