<!-- omit in toc -->
# Phase 3 - Implementation and Testing

<!-- omit in toc -->
## Team 1- Library System

<div align=center>

![The Library is a cool place to go and hang out!](https://www.bedbugexterminatorpro.ca/wp-content/uploads/2019/05/libraries.jpg "The Library is a cool place to go and hang out!")
</div>
<i>(bedbugexterminatorpro.ca, 2023)</i>


<!-- omit in toc -->

## Contents 
- [Contents](#contents)
- [Task Allocation](#task-allocation)
- [Implementation](#implementation)
  - [Interfaces](#interfaces)
  - [The `InventoryManager` Class](#the-inventorymanager-class)
  - [The `UserManager` Class](#the-usermanager-class)
- [Testing](#testing)
- [Kanban](#kanban)
- [References and Acknowledgements](#references-and-acknowledgements)
  
## Task Allocation

<div align=center>

**Table 1: Task Allocation**

| Username | Tasks |
|:---:|:---:|
| [th5528e](https://github.com/th5528e) | UI/XAML Design // Kanban // Inventory Testing
| [Repi909](https://github.com/Repi909) | Github Admin // User/Inventory Classes and Interface // Login and StudentMenu Testing
| [GeorgeElliotMathieson](https://github.com/GeorgeElliotMathieson) | Pull Requests // Hashing and Auth // TeacherMenu Testing
| [shuvo00000](https://github.com/shuvo00000) | README.md // Payment Methods // User Testing

</div>

## Implementation

### Interfaces

The main implementation point for this project was to use an interface to create polymorphic classes as both users and inventory items could be seen as generic objects that have the same methods acting upon them. The role of the interface is to allow scalability as well as abstraction from the User and Inventory classes so the front end developer can easily implement the functions in the xaml.cs back-end. The creation of `I_SystemObjectManager` allows the methods to be created in the `InventoryManager` and `UserManager` classes as seen below.

### The `InventoryManager` Class
---

**The `InventoryManager` class** is responsible for managing the inventory of books and journals in the library system. It contains several methods that facilitate operations such as adding, deleting, editing, and retrieving inventory items and their information. 

**Core Methods**

**`OpenDatabaseFile()`:**

Opens the inventory database file(`.csv` format) and reads its contents into memory.

**`CloseDatabaseFile()`:**

Closes the inventory database file and saves the current state of the inventory data back to the database file. It concatenates the `tableHeaders` and `inventoryList` into a list of strings and writes it line by line to the CSV file.

**`CreateNewObject()`:**

Adds a new item to the inventory.It validates the input object items, checks if an item with the same name already exists, and adds the new item to the `inventoryList`.

**`DeleteObject()`:**

Deletes an item from the inventory.

**`GetObjectInfo()`:**

 Retrieves all information for a specific object (inventory item) by its name. It uses the `FindObjectInList` helper method to locate the object's index and then returns the entire row from `inventoryList` at that index.

**`EditObject:`**

Edits information about an item in the inventory. It uses helper methods to find the object's and field's index, then removes the old value and inserts the new edited value in the inventoryList.

**Helper Methods**

**`FindObjectInList` and `FindFieldNameInList`:**

 These helper methods iterate through specific columns in the inventoryList to find the index of an object by name or a field, respectively.

---
### The `UserManager` Class
---

The `UserManager`class is responsible for managing user data, such as adding, editing, or deleting user data.

**Core Methods**

**`OpenDatabaseFile()`:**

Opens the Uer database file and reads its contents into memory. Reads the user data from a CSV file located at the specified path and initializes the `userList` and `tableHeaders` properties with the data read from the file.

**`CloseDatabaseFile()`:**

The purpose of this method is to save any changes made to the user data in the database file. The method first closes the user database file, then prepares the data to be written back to the file and writes the updated user data back to the database file to effectively save any changes made to the user data.

**`CreateNewObject()`:** 

Add new user to the user database.  It validates the input user data, ensuring that it is not null and that the object name does not already exist in the database. If no issues are found, it adds the new user to the `userList`.

**`DeleteObject()`:**

Deletes an user entry from the databse. It finds the index of the user by name and removes it from the `userList`.

**`EditObject()`:** 

Edits user information in the database. This method finds the user by name, locates the field to edit, and updates its value with the new information provided.

**`GetObejectInfo()`:**

To retrieve information about a specific user in the user database. It finds the user by name and returns its information as a list of strings.

**`GetSpecificObjectData()`:**

Retrieves specific data about a user from the user database. It finds the user by name, retrieves the index of the specified field, and returns the corresponding data for that field.

**Helper Methods**

**`ToSHA512()`:**

Serves for password hashing using a secure algorithm (SHA512) for password storage.

---

## Testing
## Kanban


Kanban is a method of improving software development by means of creating a visual flow using boards and charts. The idea is to promote team communication, collaboration and visibility of project timelines and projections (Radigan, 2023).

Kanban originates from the manufacturing industry, specifically Taiichi Ohno from Toyota in Japan, where it literally translates to "signboard". Toyota continue their Kanban philosophy under a new name, "Just-in-Time" method (Toyota, 2023), where they focus more on incorporating lean principles however Kanban, in the last decade, has been on the rise in tech and is being used in an array of diverse software organisations.

Below is a screenshot of our project Kanban from 21/01/24 and will change throughout the project to include new tasks as they are defined and allocated. The board has been split into major categories that define each task's state which project contributors can use to visualise the progress of the overall project.

<div align=center>

**[Figure 8: Kanban Board Phase/3](https://github.com/orgs/TeachingMaterial/projects/9)**

![Kanban](kanban.png)

</div>

## References and Acknowledgements

We would like to thank the following for their contributions and support with this project:

<div align=center>

[CompEng0001](https://github.com/CompEng0001)<br>
Nathanial Sadler

</div>
