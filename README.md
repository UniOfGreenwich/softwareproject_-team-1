<!-- omit in toc -->
# Phase 2 - System Modelling and Design

<!-- omit in toc -->
## Team 1- Library System

<div align=center>

![The Library is a cool place to go and hang out!](https://www.bedbugexterminatorpro.ca/wp-content/uploads/2019/05/libraries.jpg "The Library is a cool place to go and hang out!")
<!-- (bedbugexterminatorpro.ca, 2023) -->
</div>

<!-- omit in toc -->
## Contents

- [Introduction](#introduction)
- [Requirements](#requirements)
  - [Staff](#staff)
  - [Students](#students)
  - [Card Payments](#card-payments)
  - [Inventory](#inventory)
  - [Storage system of articles](#storage-system-of-articles)
  - [Data storage](#data-storage)
- [Overall Architecture of the System](#overall-architecture-of-the-system)
  - [Use Case Diagrams](#use-case-diagrams)
  - [Tabular Description Of Use Case Diagram](#tabular-description-of-use-case-diagram)
  - [Sequence Diagrams](#sequence-diagrams)
  - [Class Diagrams](#class-diagrams)
    - [Inheritance. UML notation: \<|-- (blank arrow-head with solid line)](#inheritance-uml-notation----blank-arrow-head-with-solid-line)
    - [Relisation/Implementation/Abstraction. UML notation: \<.. (arrow tip with dotted line)](#relisationimplementationabstraction-uml-notation--arrow-tip-with-dotted-line)
    - [Association. UML notation: -- (solid line)](#association-uml-notation----solid-line)
    - [Aggregation. UML notation: o-- (blank diamond head with solid line)](#aggregation-uml-notation-o---blank-diamond-head-with-solid-line)
    - [Composition. UML notation: \*-- (filled diamond head with solid line)](#composition-uml-notation----filled-diamond-head-with-solid-line)
    - [Dependency. UML notation: \<|.. (blank arrow-head with dotted line)](#dependency-uml-notation--blank-arrow-head-with-dotted-line)
    - [Multiplicity.](#multiplicity)
  - [Activity Diagrams](#activity-diagrams)
  - [State Chart Diagrams](#state-chart-diagrams)
- [Gantt Chart](#gantt-chart)
    - [Unidimensional](#unidimensional)
    - [Objective](#objective)
    - [Deterministic](#deterministic)
    - [Analytical and Accountable](#analytical-and-accountable)
    - [Sequential](#sequential)
  - [Kanban](#kanban)
  - [Kanban](#kanban-1)
- [References](#references)

## Introduction

The library system design and development continues into Phase/2 documenting a list of diagrammatic sections that meticulously breakdown the system architecture into more manageable and understandable pieces whilst keeping both abstraction for the end user and technicality for any future engineers (Ramuthi, 2024):

- **Use Case Diagrams**- show which functions of the system interact with the environment.
- **Sequence Diagrams**- show the actions whilst using the system between the user and system components.
- **Class Diagrams**- show classes and their relationships within the system.
- **State Diagrams**- show the response of the system to any events that occur during runtime.
- **Activity Diagrams** - shows the actions the system takes, rather than the message and information flow of the user and system.

This phase also includes updated references and Kanban and a new Gantt chart to display the key milestones for Phase/2 activity until delivery on 23/1/24. Previous tasks from Phase/1 have been labeled accordingly and archived to clear up the confusion between completed and ongoing tasks of Phase/2.

## Requirements
### Staff
- Staff all have the same access level.
- Staff can create a user.
- "Staff can delete a user, but a confirmation window will occur when asking to delete a user."
### Students
- Students will have a lower access level with limited access.
- Students can look at their own account and pay any outstanding balances.
### Card Payments
- There needs to be a card processing system for payment.
- Payment cannot be stored.
- A validation check is required and keep in mind all credit card numbers depending on vendor have a different starting number.
### Inventory
- 20 books, at least 3 should be journals.
  - Books require:
    - Titles
    - ISBN number
    - Authors
    - Synopsis - Find one, don't write it.
  - Journals require:
    - Titles
    - Authors
    - DOI number
    - Journal name
    - Conference paper name of the journal name (Seb's words)
### Storage system of articles
- Must use the Dewey Decimal System.
- Renting
- Books can only be rented in 3, 7, and 14 day intervals at a time.
- Renting starts the same day they take out the article.
- 10p late fee per day late.
### Data storage
- JSON, XML, CSV, matrix -  any of these to show what each student has taken out.


<div align=center>

<br>

**Table 1: Task Allocation**


| Username | Tasks |
|:---:|:---:|
| [th5528e](https://github.com/th5528e) | Activity Diagrams // Class Diagrams // References // Gantt Chart 
| [Repi909](https://github.com/Repi909) | Github Admin // Introduction // Kanban // Overall Architecture
| [GeorgeElliotMathieson](https://github.com/GeorgeElliotMathieson) | State Chart Diagrams // Pull Requests
| [shuvo00000](https://github.com/shuvo00000) | Sequence Diagrams // Use Case Diagrams

</div>

## Overall Architecture of the System
The library system needs many functions specified by the customer to be implemented, for example, inventory searching, fine payment, secure login and rule-sets for both normal and super users. A lot of transactional functions exist whilst a desire for data storage and event processing also exists. The system architecture needs to create an amalgamation of many traditional application types.

**Information systems architecture** allows the developers to employ a storage base for the library information as well as include transactional features such as querying the storage base for information when required. Storage mediums can be decided by the developer team with examples such as SQLExpress Server, XML files and JSON NoSQL databases being possible solutions. Transactional systems provide secure, available and fast response functions for the application to easily query and return necessary data IBM Corporation (2021).  Secure events such as user logins and payments can be adequately processed using encryption within the base and more simple events such as a book search will be effortless. The end user will be able to use a simple but effective UI to easily navigate and operate the application. Overheads for processing and storage can be managed remotely ensuring minimal downtime and costs for the user. Security of both hardware and software can be controlled by the developers during both development and during the maintenance and support period as specified by the customer.

### Use Case Diagrams
---
A use case diagram, which shows how users interact with a system visually, is an essential tool in system design. It acts as a guide to help stakeholders communicate and direct the development process by helping to understand the functional needs of a system from the viewpoint of the user.(GeeksforGeeks, 2024)

<div align=center>
<br>

**Figure 1: Library Management System Use Case Diagram**


<img src="https://www.plantuml.com/plantuml/png/bP11ImCn48Nl-HMFddOFNH0HGKgf2ZqfYFNOopGxxeOc4qbcmVnxjrqfBTI3SnfUllUHP9MLaWx1mxjTebIGIrOEndZ-L6X4SbslQ5rYgowAoNidNvGeWAp6jD7Y6OT3aiwpCUOOO_RowtlbiECq0sM4ush6cJRCvwZUMHHFCUvpVHxxs3cvI9vxjdkGjN4GhKV9URLfbgZMCU4MBPLSum6B1PnOFxICvV8wVFyV-ERkBtgwAuxaXYdP_b2z0bu-OUIhDofOE-7Qd3IBfa7rE6ZFeixIuTEtiYRdkTtAHogWZaPkilFtoJxEYgKTWly1" alt="Use case for Library member" width="370px" height="290px"> 
 <img src="https://www.plantuml.com/plantuml/png/TP31pffG44Rtzoc-k8A5F41ZZDQctTIDjZit8unmusKk6OQal7qfbTy8lplWE-UGpAurKklgWE2lIjgZxLlZshd0DuD5g2yhG-6LS_DHN7ltqf1IZORoEvLyjZum_iqaPM3dABUeMFqSWvva1MeHfhUXF3rYlKOIOkabnUphaMH8N-HhZFSsVHc7zGSBAHdZn4rKM-oJVUJwojgcc0Cdjau5ZxgR_GvPjaMoBueHI84ls6pW9GzTmTXkF-U_SM3ZjyepDzA_cu86-a16mmKwJfV6C_XUMbgFUuxycKdpQWmiG8S9tMHPik-iOZ6Va_ae5_bEFd1naL_QWqeQiD7dFn_-wms72993HLeo0Xb3_wytBvnYxheTIz7LuIy0" alt="Use case for librarian" width="370px" height="290px">

</div>

<div align=center>
<br>

### Tabular Description Of Use Case Diagram

**Table: Login Usecase**



| Components     | Description |
| ----------- | ----------- |
| Actors      |   Librarian, Library Member    |
| Description   | Enables users (library members and librarians) to log into the system securely. The system authenticates users based on their credentials (username and password). Users must have valid and authorized accounts to access the system. After login they can search for books.       | 
| Data      |   User credentials (username and password)    |
| Stimulas |   User command issued by a librarian or  member  |
| Response   |  Successful login or authentication failure |
|    Comments   |   Users must have valid credentials and appropriate permissions. The system should implement security measures such as encryption to protect user credentials   |

**Table: Rent Books Usecase**
| Components     | Description |
| ----------- | ----------- |
| Actors      |    Library Member    |
| Description |  Enables members to rent books from the library. Members can select a book and the days of rent. Members can rent a book for 3,7 or 15 days.    | 
| Data      |   Book information, member details, rental duration    |
| Stimulas  |   User command issued by a library member  | 
| Response  |  Confirmation of successful book renting |
| Comments  |  Availability of the book should be checked before confirming the book. The system should update the book status accordingly. |

**Table: Check Account Usecase**

| Components     | Description |
| ----------- | ----------- |
| Actors      |    Library Member   |
| Description |  Enables members to check their account status, including rent books and any fines accrued. The member can review their account details for transparency. The members can also pay there fine here through online. | 
| Data      |   Member details, rented books and fines.  |
| Stimulas     | User command issued by a library member.|
| Response     |  Display of Account details |
| Comments  |  The system should provide clear information to avoid confusion. The payment information should not be stored on the system. |

**Table: Manage Members Usecase**

| Components     | Description |
| ----------- | ----------- |
| Actors      |    Librarian   |
| Description | Allow librarian to manage members information. Librarian can include new members, update member details and also can remove the member when necessary.  |
| Data     |   User information, member details   |
| Stimulas      |    User command issued by the librarian   |
| Response      |    Confirmation of member management action  |
| Comments      |    Requires appropiate permissions and access to member data.   |


**Table: Manage Books Usecase**

| Components     | Description |
| ----------- | ----------- |
| Actors      |    Librarian   |
| Description | Allows the librarian to manage books in the library. This includes adding new books to the catalog, deleting existing books, and updating the catalog details. The librarian can ensure an accurate and up-to-date record of all library materials.  |
| Data     |   Book Information and catalog details   |
| Stimulas      |    User command issued by the librarian   |
| Response      |    Confirmation of book management actions |
| Comments      |    Requires appropriate permissions  to access and change books data.    |

**Table: Generate report Usecase**

| Components     | Description |
| ----------- | ----------- |
| Actors      |    Librarian   |
| Description | Allows the librarian to generate reports on various aspects of the library data. Reports may include information on book availability, members, borrowed books, fines, and other relevant things. The librarian can customize report criteria and export reports.   |
| Data     |   Book and member information, fines information   |
| Stimulas      |    User command issued by the librarian   |
| Response      |    Display of the generated report  |
| Comments      |    The system should support various report formats.   |


**Table: Return Books Usecase**

| Components     | Description |
| ----------- | ----------- |
| Actors      |    Librarian   |
| Description | Facilates the process of returning books to the library. Librarian processes returned books and may charge late return fines for overdue items.  |
| Data     |   Book Information and member details   |
| Stimulas      |    User command issued by the librarian   |
| Response      |    Confirmation of successful book return  |
| Comments      |    Late return may charge fine, which need to be calculated based on the return status. The system should handle fine calculations and update the book availability status.   |

</div>




### Sequence Diagrams
---

A sequence diagram is a type of Unified Modelling Language (UML) diagram that shows the messages that are sent back and forth between objects during an interaction. A sequence diagram shows a set of items, symbolised by lifelines, together with the messages they exchange throughout the course of their relationship.(IBM 2024)
<div align=center>
<br>

**[ Figure 2: Sequence Diagram for Member to Reserve a book ](https://www.plantuml.com/plantuml/png/VP9HRjim38RVTGh2JmdGN20FGxiK60Pq0zPW1s1ijX4gIuP4PV3j9yaHPC5staJo8t_-j9yTesNVAu4j6mlDcxnOj2Fyelv2jW5qqAUd608eMpcWveATHyVK9yobPuszUBwI3Z6oD3fX658rT496PJvJjPtUDV3Tc2zu3PKBEafOTmz4N5lUa2blcUEyJeudtHnbdP8e4wT1SFXs7t64D_CfzQxnZgp6dfedQ0Pqxf-nNRCN4nNvA764cMVQR8ee76OQzQNUoNd5ExQUia2axoQFy2hTe71CYvrzsv9pkxqG7LLsrxoS2MrxXNZIida-HowdwZqNo_auH_ZZoOuYnt2OzyOk-Aa_J6ajmgNwmC-aFfbtSpjPPCtHEsdUidEwKliLYoytb0elKaaUrvtz85w03tnMt9RVcXAeU9a6wNAiI00iNHI707EbillV8Rmf8cT6zkufjL2t3nth7av6VqZRfvyjG4i32sJxgqMj2YRbQDteRyF5xCEXiJtG1IRTLNz4zZNFJUFccMcgU0xTlbV_0G00)**

![Sequence Diagram Member!](https://www.plantuml.com/plantuml/png/VP9HRjim38RVTGh2JmdGN20FGxiK60Pq0zPW1s1ijX4gIuP4PV3j9yaHPC5staJo8t_-j9yTesNVAu4j6mlDcxnOj2Fyelv2jW5qqAUd608eMpcWveATHyVK9yobPuszUBwI3Z6oD3fX658rT496PJvJjPtUDV3Tc2zu3PKBEafOTmz4N5lUa2blcUEyJeudtHnbdP8e4wT1SFXs7t64D_CfzQxnZgp6dfedQ0Pqxf-nNRCN4nNvA764cMVQR8ee76OQzQNUoNd5ExQUia2axoQFy2hTe71CYvrzsv9pkxqG7LLsrxoS2MrxXNZIida-HowdwZqNo_auH_ZZoOuYnt2OzyOk-Aa_J6ajmgNwmC-aFfbtSpjPPCtHEsdUidEwKliLYoytb0elKaaUrvtz85w03tnMt9RVcXAeU9a6wNAiI00iNHI707EbillV8Rmf8cT6zkufjL2t3nth7av6VqZRfvyjG4i32sJxgqMj2YRbQDteRyF5xCEXiJtG1IRTLNz4zZNFJUFccMcgU0xTlbV_0G00)

**[ Figure 3: Sequence Diagram for Librarian to Return book and fine collection ](https://www.plantuml.com/plantuml/png/jPJ1ZjD038RlynHMJgr4No07j405McaHKWjdv2PUThIJIJIUMTItPvnfS8OjvSIjjZ_Rl_yckUE88QR1mOCz1Gvdu3D76WnsSGpGI1Q3HTy0ChWbCbFkifsTqCS5EiDnRft9CgN6tgNuH3x76ErO1c9ErT3xSNoUIwVyeovzfk540GxKZQ6VcO66G5rDVRIUoW3hN5tQOyGJSYdtby38gVO58-bvcYftQ2o2DHAD6XKr6ei0ZNIV-Rq7Tcyl6rfu67zOlsaIK_0uKFC6cWcPVygjMrCeuKL12oilwQzDWi9kjQF-1mx4oSLD38cM1KAh3ItiBKyEpxEsO-ewOjviZUcfDkJwHGUAAVXYakelBhNmuOcwvtlcH7kAQ1rl6Y6_ptTiJS6aOJ6kXKyKjU4FVg5Wjzenqt1plkgzHHjqiQw3vSk1rCFeuQiT2CO0ZzOJJ6Xx0t3LbMzJBxvL3tDcNnjKmC8LB5jFZkcra2yl5Ff41k3ctrZqxZ6IDbpLAEyGMFyuLiBaUIwr-rAIHEMWrcuB4QwCrsAzuVzP22QZv7lpZ-do8GAE61FNBkJy0Wbpd97whRZWwuoqhUCYiIBoyQjOFnYQKy76t97lq-1-0G00)**

![Sequence Diagram Librarian!](https://www.plantuml.com/plantuml/png/jPJ1ZjD038RlynHMJgr4No07j405McaHKWjdv2PUThIJIJIUMTItPvnfS8OjvSIjjZ_Rl_yckUE88QR1mOCz1Gvdu3D76WnsSGpGI1Q3HTy0ChWbCbFkifsTqCS5EiDnRft9CgN6tgNuH3x76ErO1c9ErT3xSNoUIwVyeovzfk540GxKZQ6VcO66G5rDVRIUoW3hN5tQOyGJSYdtby38gVO58-bvcYftQ2o2DHAD6XKr6ei0ZNIV-Rq7Tcyl6rfu67zOlsaIK_0uKFC6cWcPVygjMrCeuKL12oilwQzDWi9kjQF-1mx4oSLD38cM1KAh3ItiBKyEpxEsO-ewOjviZUcfDkJwHGUAAVXYakelBhNmuOcwvtlcH7kAQ1rl6Y6_ptTiJS6aOJ6kXKyKjU4FVg5Wjzenqt1plkgzHHjqiQw3vSk1rCFeuQiT2CO0ZzOJJ6Xx0t3LbMzJBxvL3tDcNnjKmC8LB5jFZkcra2yl5Ff41k3ctrZqxZ6IDbpLAEyGMFyuLiBaUIwr-rAIHEMWrcuB4QwCrsAzuVzP22QZv7lpZ-do8GAE61FNBkJy0Wbpd97whRZWwuoqhUCYiIBoyQjOFnYQKy76t97lq-1-0G00)

</div>

### Class Diagrams
---

**Class** diagrams are used to show the relationship between different planned classes for a class-based program. In this diagram, there are 9 different classes, and they are all related to each other in one way or another (Shelton, 2024). The different relationships in a normal class diagram are as follows (Visual Paradigm Online, 2024):

#### Inheritance. UML notation: <|-- (blank arrow-head with solid line)
Inherits previous attributes and methods of the super-class.

#### Relisation/Implementation/Abstraction. UML notation: <.. (arrow tip with dotted line)
An umbrella class such as a class named 'Animal' is an abstract class, as they can encompass many other classes under them.

#### Association. UML notation: -- (solid line)
No dependence between the classes, they are just related, and the relation between the two if not clear is put on the connecting line.

#### Aggregation. UML notation: o-- (blank diamond head with solid line)
A type of association that represents a whole and its parts, where they can be separated.

#### Composition. UML notation: *-- (filled diamond head with solid line)
A type of association, this represents parts of a whole that could not be present without its parent and vice versa.

#### Dependency. UML notation: <|.. (blank arrow-head with dotted line)
A dependency is where a class uses an attribute of another class in its methods.

#### Multiplicity.
When there can only be a certain amount of instances of a class in relation to another class. Represented by a solid line with the following notation: 
- Zero to one: 0..1
- Specific number: n
- Zero to many: 0..*
- One to many: 1..*
- Specific Number range: m..n 





<div align=center>

**[Figure 4: Class Diagram](https://mermaid.ink/img/pako:eNqVVctu2zAQ_BVBJ6dR8gFGL22MAAZsJ6ibU9XDmlzbjClS5cOpkPrfu9STUn1oLrY4uzu7wyGl95Rpjuk8ZRKsXQg4GChy5S2a5POfu7vEOs9RuTUqH8MOgR3RNLBQZ0rRpko-UUg4JIbw26S-am8UyCTGdlqfcmUdGLcQtpRQEX5_n4QGAe97JpTMwPBnqAqC4l51wWi8KLGJ9sm5omhQWHd4z9WtdUaoQ71UUOCAlJT1pg0nRBCP1AehVnhGSQAHhwnXO3ok_Mm7WVd_00BL1SNZRxRCv7wY5_aTXc2_dNNG8sLQe6nBDaq-GAPVj599YAcSFAtaDCXMOL5htQz1NzXkyIcJGPHP4r6Rvf-7WVFJoLoNyWtQcMDgRw0xg7SBLxSolxwlDsvL4FEvcNDMobIrKg4sR2SnrdPsNBEjKf4QghPcwQmv5R_E-RoeD0IHNtLvhJORePDuqI2dujCQjbjCkY-4ltuvm2G1rZQurbCRBe21iUoWT8th0YY3IzuYVnsk7xk2eNQ-vmsRJ01JBfzlH2fbwPNgcJBLqGCdh5PabFJSW9w0XIVLtPWMobUTr6M7G40V0O9ViWNk44tdeD-MsNHUFpk3wlWUGUn5XYrwCmj9CcfkEdFOJD0Q2azrmw3tsq5LFpFnDWfWcWXd-QyiS6g-TNTV94w1EY3vviHD0s2u8Vzr3m5umqUFmgIEp3c7bWyS5Clppb1K5_TIcQ9eujyldEqlfdB0BFk6d8ZjlvoyvOnar0E634O0hCIXdCnX7fci_F3-AvqTXSY?type=png)**

![Class Diagram](https://mermaid.ink/img/pako:eNqVVctu2zAQ_BVBJ6dR8gFGL22MAAZsJ6ibU9XDmlzbjClS5cOpkPrfu9STUn1oLrY4uzu7wyGl95Rpjuk8ZRKsXQg4GChy5S2a5POfu7vEOs9RuTUqH8MOgR3RNLBQZ0rRpko-UUg4JIbw26S-am8UyCTGdlqfcmUdGLcQtpRQEX5_n4QGAe97JpTMwPBnqAqC4l51wWi8KLGJ9sm5omhQWHd4z9WtdUaoQ71UUOCAlJT1pg0nRBCP1AehVnhGSQAHhwnXO3ok_Mm7WVd_00BL1SNZRxRCv7wY5_aTXc2_dNNG8sLQe6nBDaq-GAPVj599YAcSFAtaDCXMOL5htQz1NzXkyIcJGPHP4r6Rvf-7WVFJoLoNyWtQcMDgRw0xg7SBLxSolxwlDsvL4FEvcNDMobIrKg4sR2SnrdPsNBEjKf4QghPcwQmv5R_E-RoeD0IHNtLvhJORePDuqI2dujCQjbjCkY-4ltuvm2G1rZQurbCRBe21iUoWT8th0YY3IzuYVnsk7xk2eNQ-vmsRJ01JBfzlH2fbwPNgcJBLqGCdh5PabFJSW9w0XIVLtPWMobUTr6M7G40V0O9ViWNk44tdeD-MsNHUFpk3wlWUGUn5XYrwCmj9CcfkEdFOJD0Q2azrmw3tsq5LFpFnDWfWcWXd-QyiS6g-TNTV94w1EY3vviHD0s2u8Vzr3m5umqUFmgIEp3c7bWyS5Clppb1K5_TIcQ9eujyldEqlfdB0BFk6d8ZjlvoyvOnar0E634O0hCIXdCnX7fci_F3-AvqTXSY?type=png "Class Diagram")

</div>


### Activity Diagrams
---

**Activity** diagrams are behavioral diagrams that describe activity aspects within a system. An activity diagram moves just like a flow chart does, but does so with specific markers used for statements such as: if, switch and while (Visual Paradigm, 2024). Other markers can denote the start, stop, parallel activities and swim lanes (GeeksforGeeks, 2024).

The Activity diagram for this project depicts the process of the program from start to end, featuring all requested functional requirements, such as: a late fee system at 10p per day late, renting only in 3, 7 and 14 day intervals, having a teacher account that can control setup of new accounts and deletion of old accounts, amongst other requirements.

<div align=center>

**[Figure 5: Activity Diagram](https://www.plantuml.com/plantuml/png/hLLBRzj64BxlhnYWXqf03Z6QHoiU6iT9NGDjuSOfu4Cl8-vGMdWVpEnIgbhqltSu94LLIdgg3kPovfjlldci-IONvD85R_AJYoqo1iXRj6dluWOATsHCSSKJNDV5xLmvm3k7cnxs_WyChQVVepc9nGdrbm7vFVJiDyad1ky2RPWegkDzj8FP8Z-jVKTgVOlrquPJDpc_iYyilHnzYItnQ7z9tub7xTVCQJ-OrrxYpT-VaIEQGufML5scKJfBhxxzppHDYkN1_KbmzKeo66sRoNjNwYqiVaeR5q4YVkrS-NvfQim4YzyoCTniavmLi3HCBM4P7x1IW4ZjIeQo9SVGMo860XInzvZpNkHKnamX-wtpmdoNeHsTK2TcgYKhk0oBc9OGKu75WV9I0YU5zyJ1vUnIp9Eyevm9yv6mtXBBf6lfJPbnHuGA_XaZRYZGAG9WTSF2HO1QGsLM4vlWYBK-YBI7JhnVP-YB5D1hgBV8M2iaDOfgalUwVdBYW0MGIM0fK-mjYXbPkkW-TSFRIFXHd9gHhEOGKECu5_1Kn3hbK9issQCSnk0FlzngXXSGkx0cphtjvXOMBCWKPgsmeKYC9V5I0wv6Ui4_FZwNtoEuQQHIjF9BfaFgIcLEc_QEF6dJSakrQnnPwBHzhe75DHD82EIEISOhT76Ognat9uFLUDaGyfbq-eQYTKt_TnYQcVEjP0i71RFxRB5k4wpbSa19WCCMGA3OwN9fxd6xl39zSPCUIcSfbijDMasUkxYJH-93TGmwcaxW7yGYcr2D5SiMf4mP4DOfgKeMmD2jEstuuC0TEezhVzQsATEFQGy1um4i7lB4qWzolBfzvc-gu_7rVBnwKPqsR_LMicaqsMU0rf8LEbFddL0NN4lKCoWkK2uOsi_CQRvYVQsbu_Z5Qat3AOmxDSx6oDj1hmTFiPUzy5ZEjqU4mjNpLbtG445BtFT23PSQpUd2NAxJRBWNYX-8SYL7JvZ7gmWriWLB1PtFfm87nmwzisSAhqkXqFQZXnOFGOSiz7g2W5RQAgbpmMXxJ2D9ePQK_AyUpo4n3M7LMDB_TW5cdZEYuKjm-J_vyjiWo5CY4Sr9Fx2Vn27zoYMrvetuk-3_0G00)**

![Activity Diagram](https://www.plantuml.com/plantuml/png/hLLBRzj64BxlhnYWXqf03Z6QHoiU6iT9NGDjuSOfu4Cl8-vGMdWVpEnIgbhqltSu94LLIdgg3kPovfjlldci-IONvD85R_AJYoqo1iXRj6dluWOATsHCSSKJNDV5xLmvm3k7cnxs_WyChQVVepc9nGdrbm7vFVJiDyad1ky2RPWegkDzj8FP8Z-jVKTgVOlrquPJDpc_iYyilHnzYItnQ7z9tub7xTVCQJ-OrrxYpT-VaIEQGufML5scKJfBhxxzppHDYkN1_KbmzKeo66sRoNjNwYqiVaeR5q4YVkrS-NvfQim4YzyoCTniavmLi3HCBM4P7x1IW4ZjIeQo9SVGMo860XInzvZpNkHKnamX-wtpmdoNeHsTK2TcgYKhk0oBc9OGKu75WV9I0YU5zyJ1vUnIp9Eyevm9yv6mtXBBf6lfJPbnHuGA_XaZRYZGAG9WTSF2HO1QGsLM4vlWYBK-YBI7JhnVP-YB5D1hgBV8M2iaDOfgalUwVdBYW0MGIM0fK-mjYXbPkkW-TSFRIFXHd9gHhEOGKECu5_1Kn3hbK9issQCSnk0FlzngXXSGkx0cphtjvXOMBCWKPgsmeKYC9V5I0wv6Ui4_FZwNtoEuQQHIjF9BfaFgIcLEc_QEF6dJSakrQnnPwBHzhe75DHD82EIEISOhT76Ognat9uFLUDaGyfbq-eQYTKt_TnYQcVEjP0i71RFxRB5k4wpbSa19WCCMGA3OwN9fxd6xl39zSPCUIcSfbijDMasUkxYJH-93TGmwcaxW7yGYcr2D5SiMf4mP4DOfgKeMmD2jEstuuC0TEezhVzQsATEFQGy1um4i7lB4qWzolBfzvc-gu_7rVBnwKPqsR_LMicaqsMU0rf8LEbFddL0NN4lKCoWkK2uOsi_CQRvYVQsbu_Z5Qat3AOmxDSx6oDj1hmTFiPUzy5ZEjqU4mjNpLbtG445BtFT23PSQpUd2NAxJRBWNYX-8SYL7JvZ7gmWriWLB1PtFfm87nmwzisSAhqkXqFQZXnOFGOSiz7g2W5RQAgbpmMXxJ2D9ePQK_AyUpo4n3M7LMDB_TW5cdZEYuKjm-J_vyjiWo5CY4Sr9Fx2Vn27zoYMrvetuk-3_0G00 "Activity Diagram")



</div>

### State Chart Diagram

The purpose of a state chart diagram is to model the dynamic nature of a system. State chart diagrams act as a graphical representation of changes to components within a system by either internal or external events. A fully comprehensive state chart diagram would cover all possible states - including system crashes - in order for unexpected occurrences to be dealt with by a failsafe. In order to describe the relationship between components, a state chart diagram also includes the flow of control within a system (activities, data passthrough, etc).

<div align=center>

**[State Chart Diagram](State_Chart_Diagram.png)**

![State Chart Diagram](State_Chart_Diagram.png)

## Gantt Chart

Written in the popular app Mermaid for chart creation, this Gantt chart shows the planning for phase 1 and 2 of this project, of which phase 1 is already completed. Phase 3 will be fleshed out in the future once phase 2 is completed on the 23rd of January 2024.

The Gantt chart, Overall Architecture, Sequence Diagram, Class Diagram, Activity Diagram and State Chart Diagrams are to be drafted by the 2nd of January 2024. After this period, the diagrams and information are to be finalised and referenced. This again will give clarity in what is completed/to be completed in the future of the project, to give the team a boost in moral via means of a visible road map.

A Gantt chart is well known to be an intuitive, simple, practical and useful visual representation of activities and their associated durations. They are a very widely used tool within industry, and are built to focus on 5 main areas (Geraldi & Lechler, 2012).

#### Unidimensional
* One view being 'time', emphasising efficiency.

#### Objective
* Object-oriented.

#### Deterministic
* A Gantt chart determines all that will occur in the project.

#### Analytical and Accountable
* Division of the project allows for smaller bite-sized chunks so resources can be allocated efficiently.

#### Sequential
* After tasks have been completed, then the next task is to be completed, thus sequentially.

<div align=center>

**[Figure 6: Project Plan Gantt Chart, Phase 2 Update](https://mermaid.ink/img/pako:eNq9Vm1v2jAQ_itWPidtE7q2y7eqqNW0oVXQaprEFxMf4C1xsrPdClX97zs7LyQMtlXTQAiS3HPPPXe-c_wSZKWAIA1WXBkzV4w-Rpoc2APwgsXsHstvkBl25-zsZs2xQQlu4LbEghvGxuNoMom-0meuaqsmH1kqNiuX5pkjOJ4MtGYTCpfXmLHUmdXawdIMpQl1VYgwGUVxHCVnyShksaiRX8gKka0YV4JNYQkIithScni2GPKlAWTe-6LxmMKThGeWdiaHa-mGEh81Iabww0qEApTRB9RZHIj7kzaLW2nOdVeZxa31sLjZRhso_kaexjfWrqdP79GHDtDZDyucSv1d1-R0xaqcKyXV6vfBESvH2NN7KX7Jq_ap1fgUyUu0khuGLs0TlsbxKX09224bflAGS2H9TW259_fAxkh85HvRq9xVw3krFc-lhqH6pqeqOIsJ-35vUR74IofTj1wt-FHi3eWl1hw3_xqL7Q920j7P4r0t0C1s20It3R03a0BqB-onXIUDJaOGfGYXhTQ9Et973TKvetCdpHe3pJ28fRL9kJdvyb1trPs1J2TCbOV2PKrmeRQnNeGVaCRtfzpxn58AeZ6za8zWNAOZsQj7V2fLty34gU44S6Izn8z5wU54nHxyOxq7carHkq-QF_V4-p7Ux9Awo93KV7SJf4yYNzmnt8sRA17T35M0m2PGnBnXgr7ju7X9n3HbbXSowk-E7k9H7IZtMGrJxc74pFUS9lWNrgaAEQFG7n3QSXl3LoIwKIBOGFLQAeXFwecB7ScFzIOULgUsuc3NPJirV4Jya8rZRmVBatBCGNQD25QpSJc81_QUhDQlTupDjz_7vP4EwNzBfw?type=png)**

![Project Plan Gantt Chart](https://mermaid.ink/img/pako:eNq9Vm1v2jAQ_itWPidtE7q2y7eqqNW0oVXQaprEFxMf4C1xsrPdClX97zs7LyQMtlXTQAiS3HPPPXe-c_wSZKWAIA1WXBkzV4w-Rpoc2APwgsXsHstvkBl25-zsZs2xQQlu4LbEghvGxuNoMom-0meuaqsmH1kqNiuX5pkjOJ4MtGYTCpfXmLHUmdXawdIMpQl1VYgwGUVxHCVnyShksaiRX8gKka0YV4JNYQkIithScni2GPKlAWTe-6LxmMKThGeWdiaHa-mGEh81Iabww0qEApTRB9RZHIj7kzaLW2nOdVeZxa31sLjZRhso_kaexjfWrqdP79GHDtDZDyucSv1d1-R0xaqcKyXV6vfBESvH2NN7KX7Jq_ap1fgUyUu0khuGLs0TlsbxKX09224bflAGS2H9TW259_fAxkh85HvRq9xVw3krFc-lhqH6pqeqOIsJ-35vUR74IofTj1wt-FHi3eWl1hw3_xqL7Q920j7P4r0t0C1s20It3R03a0BqB-onXIUDJaOGfGYXhTQ9Et973TKvetCdpHe3pJ28fRL9kJdvyb1trPs1J2TCbOV2PKrmeRQnNeGVaCRtfzpxn58AeZ6za8zWNAOZsQj7V2fLty34gU44S6Izn8z5wU54nHxyOxq7carHkq-QF_V4-p7Ux9Awo93KV7SJf4yYNzmnt8sRA17T35M0m2PGnBnXgr7ju7X9n3HbbXSowk-E7k9H7IZtMGrJxc74pFUS9lWNrgaAEQFG7n3QSXl3LoIwKIBOGFLQAeXFwecB7ScFzIOULgUsuc3NPJirV4Jya8rZRmVBatBCGNQD25QpSJc81_QUhDQlTupDjz_7vP4EwNzBfw?type=png "Project Plan Gantt Chart")

</div>

### Kanban

Kanban is a method of improving software development by means of creating a visual flow using boards and charts. The idea is to promote team communication, collaboration and visibility of project timelines and projections Radigan, D. (2022).

Kanban originates from the manufacturing industry, specifically Taiichi Ohno from Toyota in Japan, where it literally translates to "signboard". Toyota continue their Kanban philosophy under a new name, "Just-in-Time" method TOYOTA (2023), where they focus more on incorporating lean principles however Kanban, in the last decade, has been on the rise in tech and is being used in an array of diverse software organisations.

Below is a screenshot of our project Kanban from 21/01/24 and will change throughout the project to include new tasks as they are defined and allocated. The board has been split into major categories that define each task's state which project contributors can use to visualise the progress of the overall project.

<div align=center>


**[Figure 3: Kanban Board 21/01/24](https://github.com/orgs/TeachingMaterial/projects/9)**

![Kanban](kanban2.png)

</div>

### Kanban

Kanban is a method of improving software development by means of creating a visual flow using boards and charts. The idea is to promote team communication, collaboration and visibility of project timelines and projections Radigan, D. (2022).

Kanban originates from the manufacturing industry, specifically Taiichi Ohno from Toyota in Japan, where it literally translates to "signboard". Toyota continue their Kanban philosophy under a new name, "Just-in-Time" method TOYOTA (2023), where they focus more on incorporating lean principles however Kanban, in the last decade, has been on the rise in tech and is being used in an array of diverse software organisations.

Below is a screenshot of our project Kanban from 21/01/24 and will change throughout the project to include new tasks as they are defined and allocated. The board has been split into major categories that define each task's state which project contributors can use to visualise the progress of the overall project.

<div align=center>


**[Figure 3: Kanban Board 21/01/24](https://github.com/orgs/TeachingMaterial/projects/9)**

![Kanban](kanban2.png)

</div>




## References

IBM Corporation (2021) IBM Documentation, Transaction Processing Systems. Available at: https://www.ibm.com/docs/en/txseries/9.1?topic=processing-transaction-systems

Toyota production system . [online] Toyota Motor Corporation Official Global Website. Available at: https://global.toyota/en/company/vision-and-philosophy/production-system/.

Radigan, D. (2022). What is kanban? [online] Atlassian. Available at: https://www.atlassian.com/agile/kanban.

bedbugexterminatorpro.ca. (2023, 12 08). library.jpg. Retrieved from bedbugexterminatorpro.ca: https://www.bedbugexterminatorpro.ca/wp-content/uploads/2019/05/libraries.jpg

GeeksforGeeks. (2024, 01 21). Difference between Sequence Diagram and Activity Diagram. Retrieved from GeeksforGeeks.org: https://www.geeksforgeeks.org/difference-between-sequence-diagram-and-activity-diagram/

GeeksforGeeks. (2024, 01 21). Use Case Diagrams | Unified Modeling Language (UML). Retrieved from GeeksforGeeks.org: https://www.geeksforgeeks.org/use-case-diagram/

Geraldi, J., & Lechler, T. (2012). Gantt Chart and the Scientific Management in Projects. International Journal of Managing Project in Business, 5(4), 578-594.

IBM. (2024, 01 21). Sequence Diagrams. Retrieved from IBM.com: https://www.ibm.com/docs/en/rsm/7.5.0?topic=uml-sequence-diagrams

oclc.org. (2023, 12 04). Dewey Services. Retrieved from oclc.org: https://www.oclc.org/en/dewey.html

Ramuthi, D. (2024, 01 21). 11 UML disgram Examples: Class, Activity, and More. Retrieved from venngage.com: https://venngage.com/blog/uml-diagram-examples/

Shelton, B. (2024, 01 21). YouTube | UML Class Diagrams. Retrieved from YouTube.com: https://www.youtube.com/watch?v=6XrL5jXmTwM&ab_channel=LucidSoftware

Visual Paradigm. (2024, 01 21). What is an Activity Diagram? Retrieved from visual-paradigm.com: https://www.visual-paradigm.com/guide/uml-unified-modeling-language/what-is-activity-diagram/

Visual Paradigm Online. (2024, 01 21). What are the six types of relationships in UML class diagrams? Retrieved from Visual Paradigm: https://blog.visual-paradigm.com/what-are-the-six-types-of-relationships-in-uml-class-diagrams/