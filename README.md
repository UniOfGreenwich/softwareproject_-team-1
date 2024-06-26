<!-- omit in toc -->
## Team 1- Library System

<div align=center>

![The Library is a cool place to go and hang out!](https://www.bedbugexterminatorpro.ca/wp-content/uploads/2019/05/libraries.jpg "The Library is a cool place to go and hang out!")
<!-- (bedbugexterminatorpro.ca, 2023) -->
</div>

<!-- omit in toc -->
## Contents

- [Phase 1 - Requirements Engineering](#phase-1---requirements-engineering)
- [Team 1- Library System](#team-1--library-system)
  - [Contents](#contents)
  - [Introduction](#introduction)
  - [Glossary](#glossary)
  - [Software Process Model](#software-process-model)
    - [Explanation of Incremental model](#explanation-of-incremental-model)
    - [Incremental model stages:](#incremental-model-stages)
    - [Advantages and Disadvantages](#advantages-and-disadvantages)
      - [Benefits](#benefits)
      - [Drawbacks](#drawbacks)
    - [Reasons for choosing the Incremental model](#reasons-for-choosing-the-incremental-model)
    - [References](#references)
  - [User Requirements](#user-requirements)
    - [Functional Requirements](#functional-requirements)
    - [Non-Functional Requirements](#non-functional-requirements)
  - [Technical Requirements](#technical-requirements)
    - [Functional:](#functional)
    - [Non-Functional:](#non-functional)
  - [Potential Risks](#potential-risks)
- [Phase 2 - System Modelling and Design](#phase-2---system-modelling-and-design)
  - [Introduction](#introduction-1)
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
      - [Tabular Description Of Use Case Diagram](#tabular-description-of-use-case-diagram-1)
    - [State Chart Diagram](#state-chart-diagram)
  - [Phase 3 - Implementation and Testing](#phase-3---implementation-and-testing)
  - [Implementation](#implementation)
    - [Interfaces](#interfaces)
    - [The `InventoryManager` Class](#the-inventorymanager-class)
    - [The `UserManager` Class](#the-usermanager-class)
    - [The `paymentGateway` partial class](#the-paymentgateway-partial-class)
    - [The `bookRental` partial class](#the-bookrental-partial-class)
    - [The `studentMenu` partial class](#the-studentmenu-partial-class)
    - [The `teacherMenu` partial class](#the-teachermenu-partial-class)
    - [The `loginScreen` partial class](#the-loginscreen-partial-class)
  - [Testing](#testing)
      - [`teacherMenuTests`:](#teachermenutests)
      - [`userManagerTest`:](#usermanagertest)
      - [`bookRentalTest`:](#bookrentaltest)
  - [Project Planning](#project-planning)
    - [Gantt Chart](#gantt-chart)
      - [Unidimensional](#unidimensional)
      - [Objective](#objective)
      - [Deterministic](#deterministic)
      - [Analytical and Accountable](#analytical-and-accountable)
      - [Sequential](#sequential)
    - [Kanban](#kanban)
  - [References and Acknowledgements](#references-and-acknowledgements)

# Phase 1 - Requirements Engineering

## Introduction

The library system, commissioned to us as a project by our customer ***Blair&Co***, was the result of a need for a new and modernised system to monitor and control their extensive collection of computer hardware, programming and engineering documents dating back to early 1980s MS-DOS documentation through to generative AI journals printed this year by organisations such as OpenAI.

The team was given a specification by our customer which involved basic functions such as an inventory system through to advanced functions such as payment methods and authentication for security purposes.

The team decided a ***Incremental Design*** process was to be used as we could easily adapt to changing customer needs whilst also making deadlines key.

---

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
- JSON, XML, CSV, matrix -  any of these to show what each student has taken out (perhaps start all csv/text files with words so that the files can be identified as book logs - Toby idea).

The documentation will further develop as the project moves through its key phases with the initial planning of Phase/1 being delivered on 12/12/23.

<div align=center>

<br>

**Table 1: Task Allocation**

| Username | Tasks |
|:---:|:---:|
| [th5528e](https://github.com/th5528e) | Glossary // References // Gantt Chart // Kanban
| [Repi909](https://github.com/Repi909) | Github Admin // Introduction // Kanban
| [GeorgeElliotMathieson](https://github.com/GeorgeElliotMathieson) | Risk and Risk Planning // System Requirements
| [shuvo00000](https://github.com/shuvo00000) | Software Process Model // User Requirements

<br>

| Username | Tasks |
|:---:|:---:|
| [th5528e](https://github.com/th5528e) | UI/XAML Design // Kanban // Inventory Testing
| [Repi909](https://github.com/Repi909) | Github Admin // User/Inventory Classes and Interface // Login and StudentMenu Testing
| [GeorgeElliotMathieson](https://github.com/GeorgeElliotMathieson) | Pull Requests // Hashing and Auth // TeacherMenu Testing
| [shuvo00000](https://github.com/shuvo00000) | README.md // Payment Methods // UserManager and bookRent Testing

</div>

## Glossary

**User Requirements**

Specifying a system's requirements from a user's point of view. Functions that support a user in their tasks. e.g. the interfaces they will use, physical support, mental support, and usability goals. (Maguire, et al., 1998).

**System requirements**

Requirements are defined for a project or item before efforts to create a design for a project. (Grady, 2006)

**Gantt Chart**

A popular Time-Focused, Objective, Deterministic, Analytic, Accountable, and Sequential chart based planning method. (Geraldi & Lechler, 2012)

**Kanban**

A system from the manufacturing industry in the 1940s developed by Toyota. Visualised workflow using tables with limitations in the ‘in progress’ tab. (Kniberg & Skarin, 2010)

**Functional Requirements**

Specified requirements of the customer/end-user, that the system should offer. (Chitra, 2023)

**Non-Functional Requirements**

The requirements that a system must adhere to in the project contract. A few examples are: Maintainability, Portability, Reliability, Security, etc. (Chitra, 2023)


## Software Process Model

The software process model is an abstraction of a software development process. It explains a procedure from a particular perspective. Some of the most popular Software process models are:

- **Waterfall model:** It is a sequential, plan-driven process. It requires one to plan and schedule all activities before beginning the project.

- **Incremental model:**  The incremental model could be plan-driven or agile. In this model specification, development, and validation activities are interleaved rather than separate, with rapid feedback across activities.

- **Integration and Configuration:** This model assembles the system from pre-existing, configurable components.

We have chosen the Incremental model for our Library system project. 

### Explanation of Incremental model

The incremental model is now the most common approach for software development. It can be plan-driven, agile or a mixture of these approaches. The system increments are predetermined in a plan-driven method; if an agile approach is used, the early increments are predetermined, but the creation of subsequent increments depends on progress and client priorities. 

This model is better than a waterfall model when system requirements are expected to change during the process. The way we solve issues is reflected in incremental development. We rarely figure out the entire solution to an issue up front; instead, we approach a solution incrementally and then go back when we see that we made a mistake. It is less expensive and simpler to make modifications to the software while it is being built when it is developed incrementally (Collegenote.net, 2023).

<div align=center>

**<a href="#Figure_1">Figure 1: Incremental Design Model (Collegenote.net, 2023)</a>**

![Incremental Model](/Documentation%20Pictures/IncrementalModel.png "Incremental Model")
*Figure 1 (Collegenote.net, 2023)*


</div>

### Incremental model stages:

**Requirement analysis:** In this stage, the project requirements, such as its objectives, restrictions, and scope, are gathered and examined. Determining the resources required to finish the project, and developing the overall project plan are also included in this step. This phase performs a crucial role in the incremental model (Budhiraja, 2023).

**Design:** During this stage, the project team creates an overall software architecture together with high-level and detailed design. It includes system design, technology selection, and the creation of any prototypes or proofs of concept that may be required.

**Implementation:** In this phase, the project is implemented by writing the code in accordance with the requirements of the final product. To update and improve the quality of the product, the coding standards must be properly followed, without using needless hard codes or defaults (Pedamkar, 2023).

**Testing:** At this stage, the tester checks the performance of all existing functions and additional functionalities as per the customer's requirement. It is important to test the result after each code implementation to make sure it works correctly with other code already produced for the same project. The system is then deployed to the production environment.

### Advantages and Disadvantages

There are certain benefits and drawbacks to the incremental development process approach.

#### Benefits

* The software will be produced quickly throughout its life cycle.
* Changes to the requirements and scope are affordable and adaptable.
* At any stage in the development process, modifications could be made.
* Compared to other models, this model is less expensive.
* Customer feedback is welcome in every building.
* Errors are easy to identify.

#### Drawbacks

* Proper planning and designing are essential
* As not every requirement is acquired in advance for the duration of the program, issues could occur.
* Fixing a problem in one unit requires a lot of time and work since each iteration step is rigid and does not cross over with the others.

(Hiền, 2023)

### Reasons for choosing the Incremental model

One of the main reasons for choosing the Incremental model in our Library System project is requirements. The library system requirements can change with time and when we are going to unveil more information other requirements may fall off. When a project’s requirements are constantly changing it is best to work with the incremental model.

Another reason is that we can get customer feedback on the development work that has been done. Customers can comment on software demos and see how much has been implemented. 

Also, our team is small and inexperienced. For an inexperienced team, it is better to go with the incremental model.2 

The goals of the project are clearly stated and recognized, though some elements can change at each increment over time.

By using the incremental model, we can make a good mix of plan-driven and agile methods. We can stay engaged with customers whilst also sticking to the timelines and project phases.


## User Requirements

The following is an outline of everything a user expects from the system: it includes statements in natural language and diagrams that illustrate the services the system provides and its operational constraints.

### Functional Requirements

**For User**
* Allow users to search for books by title, author, or ISBN.
* The system should be able to display a list of all the books in the library.
* Allow users to check out and return books.
* Allow users to see which books are currently checked out and their due dates for return.
* Users should be able to reset their password.
* The system should send reminders to users when a book is due to be returned.
* Allow users to pay their outstanding balance online using a credit or debit card.
* The system should update the user’s account to reflect the payment immediately.
* Provide helpful error messages and feedback to guide the users.

**For Staff**
* Staff can add and remove books from the library.
* Staff should be able to generate reports regarding library usage and checkouts.

### Non-Functional Requirements
* User-friendly interface that allows easy navigation.
* The system should be accessible 24/7, except for the scheduled maintenance period.
* Ensure that robust data security and protection measures are in place to secure the privacy and confidentiality of users' data.
* Should be compatible with all operating systems and devices.
* Capacity to manage several users and concurrent system access without performance degradation.
* High performance and capacity to manage a huge amount of data.

## Technical Requirements

What follows is an outline of everything expected of the system in terms of functionality, compatibility, and back-end processing techniques.

### Functional:

**Account Management**
- Access levels are determined by the organisation's personnel hierarchy
- Account creation and deletion by authorised staff
- Search, sort, and filter functionality for authorised staff
- Account information is editable only by account-holder
  - Encrypted and verified by md5sum (rdrr.io, 2023)
  - ID comprises the user's first and last name initials, 4 random numbers, and a random character respectively (e.g. jp4661d)
  - Password must be 8 characters in length, contain a number and a symbol
- Account balance credit and debt issuing
  - Accounts are automatically charged for outstanding titles
  - Customers can add credit to their account anytime
  - Staff can clear account balances manually
    - Usage log associated with the user and flagged upon abuse of this feature

**Inventory Management**
- Book/journal/article information amendable by authorised staff
- Book/journal/article entry and removal by authorised staff
- Search, sort, and filter functionality
- Internal UID for each book/journal/article
- Dewy Decimal Classification (oclc.org, 2023)
- Book information
  - ISBN (International ISBN Agency, 2023)
  - Title
  - Author
  - Mini-synopsis
- Journal/article information
  - DOI number
  - Title
  - Author
  - Conference
  - Journal name

**Resource Optimisations**
- Suitable search and sort algorithms for expected database size(s)
- Data storage limit(s)
  - Functionality is limited if storage is full
- Data type and format validation throughout

### Non-Functional:
- A minimum of 20 books/journals/articles present in the system
- 3, 7, and 14-week rental options
- 10p/day late return charge

## Potential Risks

A stock management and lending system such as this has few - but by no means trivial - intrinsic risks derived from any aspect of the hardware, software, and/or personnel. Significant risks that we're aware of and continually take into consideration are as follows...

**Hardware:**
- Limited server data storage for database expandability
- Exiguous server cache for indexing and logging
- Unsuitable networking connections between server(s) and clients
- Subpar server/client processing speed
- System outages and/or data loss due to a lack of redundancy (Howard, 2023)
- Physical damage to equipment due to adverse conditions or deliberate tempering

**Software:**
- Non-compliance with legislation due to inadequate encryption, deletion, and extraction processes (gov.uk, 2023) (legislation.gov.uk, 2023)
- Inconsistent data validation techniques
- Arduous bug fixing due to poor code formatting, annotations, etc
- Inappropriate datatype selection leading to overflow, truncated, and/or inaccurate data 
- Redundant, non-modular, and inefficient code causing system underperformance
- Unrobust data handling processes that allow for database conflicts and the overwriting of data

**Personnel:**
- User error from insufficient training
- Data privacy/security compromised by unconfigured access levels
- Project drift due to infrequent communication with stakeholders
- Unsympathetic, offputting deployment method and timeframe (Amazon, 2023)
- Failure to provide technical support for the use and maintenance of the system

To summarise, many hardware-related risks can be overcome by having a performance overhead, options for future expandability, physical security on location, and redundancy with the host system(s). As for software, by far the most impactful forms of risk mitigation would be to have a combination of robust encryption techniques, multi-factor authentification, data validation, and error correction. When it comes to personnel, however, a hierarchy of access levels alongside training and documentation for stakeholders would suffice.

# Phase 2 - System Modelling and Design

## Introduction

The library system design and development continues into Phase/2 documenting a list of diagrammatic sections that meticulously breakdown the system architecture, into more manageable and understandable pieces, whilst keeping both abstraction for the end user, and technicality for any future maintenance (Ramuthi, 2024):

- **Use Case Diagrams**- show which functions of the system interact with the environment.
- **Sequence Diagrams**- show the actions whilst using the system between the user and system components.
- **Class Diagrams**- show classes and their relationships within the system.
- **State Diagrams**- show the response of the system to any events that occur during runtime.
- **Activity Diagrams** - shows the actions the system takes, rather than the message and information flow of the user and system.

This phase also includes updated references and Kanban and a new Gantt chart to display the key milestones for Phase/2 activity until delivery on 23/1/24. Previous tasks from Phase/1 have been labeled accordingly and archived to clear up the confusion between completed and ongoing tasks of Phase/2.

## Overall Architecture of the System
The library system needs many functions specified by the customer to be implemented, for example, inventory searching, fine payment, secure login and rule-sets for both normal and super users. A lot of transactional functions exist whilst a desire for data storage and event processing also exists. The system architecture needs to create an amalgamation of many traditional application types.

**Information systems architecture** allows the developers to employ a storage base for the library information as well as include transactional features such as querying the storage base for information when required. Storage mediums can be decided by the developer team with examples such as SQLExpress Server, XML files and JSON NoSQL databases being possible solutions. Transactional systems provide secure, available and fast response functions for the application to easily query and return necessary data IBM Corporation (2021).  Secure events such as user logins and payments can be adequately processed using encryption within the base and more simple events such as a book search will be effortless. The end user will be able to use a simple but effective UI to easily navigate and operate the application. Overheads for processing and storage can be managed remotely ensuring minimal downtime and costs for the user. Security of both hardware and software can be controlled by the developers during both development and during the maintenance and support period as specified by the customer.


### Use Case Diagrams
---

A use case diagram, which shows how users interact with a system visually, is an essential tool in system design. It acts as a guide to help stakeholders communicate and direct the development process by helping to understand the functional needs of a system from the viewpoint of the user (GeeksforGeeks, 2024).

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

A sequence diagram is a type of Unified Modelling Language (UML) diagram that shows the messages that are sent back and forth between objects during an interaction. A sequence diagram shows a set of items, symbolised by lifelines, together with the messages they exchange throughout the course of their relationship (IBM 2024).
<div align=center>
<br>

**Figure 2: Sequence Diagram for Member to Reserve a book**

![Sequence Diagram Member!](https://www.plantuml.com/plantuml/png/VP9HRjim38RVTGh2JmdGN20FGxiK60Pq0zPW1s1ijX4gIuP4PV3j9yaHPC5staJo8t_-j9yTesNVAu4j6mlDcxnOj2Fyelv2jW5qqAUd608eMpcWveATHyVK9yobPuszUBwI3Z6oD3fX658rT496PJvJjPtUDV3Tc2zu3PKBEafOTmz4N5lUa2blcUEyJeudtHnbdP8e4wT1SFXs7t64D_CfzQxnZgp6dfedQ0Pqxf-nNRCN4nNvA764cMVQR8ee76OQzQNUoNd5ExQUia2axoQFy2hTe71CYvrzsv9pkxqG7LLsrxoS2MrxXNZIida-HowdwZqNo_auH_ZZoOuYnt2OzyOk-Aa_J6ajmgNwmC-aFfbtSpjPPCtHEsdUidEwKliLYoytb0elKaaUrvtz85w03tnMt9RVcXAeU9a6wNAiI00iNHI707EbillV8Rmf8cT6zkufjL2t3nth7av6VqZRfvyjG4i32sJxgqMj2YRbQDteRyF5xCEXiJtG1IRTLNz4zZNFJUFccMcgU0xTlbV_0G00)

**Figure 3: Sequence Diagram for Librarian to Return book and fine collection**

![Sequence Diagram Librarian!](https://www.plantuml.com/plantuml/png/jPJ1ZjD038RlynHMJgr4No07j405McaHKWjdv2PUThIJIJIUMTItPvnfS8OjvSIjjZ_Rl_yckUE88QR1mOCz1Gvdu3D76WnsSGpGI1Q3HTy0ChWbCbFkifsTqCS5EiDnRft9CgN6tgNuH3x76ErO1c9ErT3xSNoUIwVyeovzfk540GxKZQ6VcO66G5rDVRIUoW3hN5tQOyGJSYdtby38gVO58-bvcYftQ2o2DHAD6XKr6ei0ZNIV-Rq7Tcyl6rfu67zOlsaIK_0uKFC6cWcPVygjMrCeuKL12oilwQzDWi9kjQF-1mx4oSLD38cM1KAh3ItiBKyEpxEsO-ewOjviZUcfDkJwHGUAAVXYakelBhNmuOcwvtlcH7kAQ1rl6Y6_ptTiJS6aOJ6kXKyKjU4FVg5Wjzenqt1plkgzHHjqiQw3vSk1rCFeuQiT2CO0ZzOJJ6Xx0t3LbMzJBxvL3tDcNnjKmC8LB5jFZkcra2yl5Ff41k3ctrZqxZ6IDbpLAEyGMFyuLiBaUIwr-rAIHEMWrcuB4QwCrsAzuVzP22QZv7lpZ-do8GAE61FNBkJy0Wbpd97whRZWwuoqhUCYiIBoyQjOFnYQKy76t97lq-1-0G00)

</div>

### Class Diagrams
---

**Class diagrams** are used to show the relationship between different planned classes for a program. In this diagram, there are 9 different classes, and they are all related to each other in one way or another. In the class diagram, per class there are three sections: class name, attributes, and methods. The class name is the name of the class. The attributes are the values within the class, these can be any form of data such as int, float, string, etc. The methods are the functions within the class. 

The class diagram also shows which attributes or methods of each class are public or private by showing a '+' or a '-' next to the item. If something is private, other classes will not be able to use the attribute/method, and the opposite is true for a public attribute/method. You can even have a full public or private class (Shelton, 2024). The different relationships in a normal class diagram are as follows:


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

(Visual Paradigm Online, 2024)


<div align=center>

**[Figure 4: Class Diagram](https://mermaid.ink/img/pako:eNqVVctu2zAQ_BVBJ6dR8gFGL22MAAZsJ6ibU9XDmlzbjClS5cOpkPrfu9STUn1oLrY4uzu7wyGl95Rpjuk8ZRKsXQg4GChy5S2a5POfu7vEOs9RuTUqH8MOgR3RNLBQZ0rRpko-UUg4JIbw26S-am8UyCTGdlqfcmUdGLcQtpRQEX5_n4QGAe97JpTMwPBnqAqC4l51wWi8KLGJ9sm5omhQWHd4z9WtdUaoQ71UUOCAlJT1pg0nRBCP1AehVnhGSQAHhwnXO3ok_Mm7WVd_00BL1SNZRxRCv7wY5_aTXc2_dNNG8sLQe6nBDaq-GAPVj599YAcSFAtaDCXMOL5htQz1NzXkyIcJGPHP4r6Rvf-7WVFJoLoNyWtQcMDgRw0xg7SBLxSolxwlDsvL4FEvcNDMobIrKg4sR2SnrdPsNBEjKf4QghPcwQmv5R_E-RoeD0IHNtLvhJORePDuqI2dujCQjbjCkY-4ltuvm2G1rZQurbCRBe21iUoWT8th0YY3IzuYVnsk7xk2eNQ-vmsRJ01JBfzlH2fbwPNgcJBLqGCdh5PabFJSW9w0XIVLtPWMobUTr6M7G40V0O9ViWNk44tdeD-MsNHUFpk3wlWUGUn5XYrwCmj9CcfkEdFOJD0Q2azrmw3tsq5LFpFnDWfWcWXd-QyiS6g-TNTV94w1EY3vviHD0s2u8Vzr3m5umqUFmgIEp3c7bWyS5Clppb1K5_TIcQ9eujyldEqlfdB0BFk6d8ZjlvoyvOnar0E634O0hCIXdCnX7fci_F3-AvqTXSY?type=png)**

![Class Diagram](https://mermaid.ink/img/pako:eNqVVctu2zAQ_BVBJ6dR8gFGL22MAAZsJ6ibU9XDmlzbjClS5cOpkPrfu9STUn1oLrY4uzu7wyGl95Rpjuk8ZRKsXQg4GChy5S2a5POfu7vEOs9RuTUqH8MOgR3RNLBQZ0rRpko-UUg4JIbw26S-am8UyCTGdlqfcmUdGLcQtpRQEX5_n4QGAe97JpTMwPBnqAqC4l51wWi8KLGJ9sm5omhQWHd4z9WtdUaoQ71UUOCAlJT1pg0nRBCP1AehVnhGSQAHhwnXO3ok_Mm7WVd_00BL1SNZRxRCv7wY5_aTXc2_dNNG8sLQe6nBDaq-GAPVj599YAcSFAtaDCXMOL5htQz1NzXkyIcJGPHP4r6Rvf-7WVFJoLoNyWtQcMDgRw0xg7SBLxSolxwlDsvL4FEvcNDMobIrKg4sR2SnrdPsNBEjKf4QghPcwQmv5R_E-RoeD0IHNtLvhJORePDuqI2dujCQjbjCkY-4ltuvm2G1rZQurbCRBe21iUoWT8th0YY3IzuYVnsk7xk2eNQ-vmsRJ01JBfzlH2fbwPNgcJBLqGCdh5PabFJSW9w0XIVLtPWMobUTr6M7G40V0O9ViWNk44tdeD-MsNHUFpk3wlWUGUn5XYrwCmj9CcfkEdFOJD0Q2azrmw3tsq5LFpFnDWfWcWXd-QyiS6g-TNTV94w1EY3vviHD0s2u8Vzr3m5umqUFmgIEp3c7bWyS5Clppb1K5_TIcQ9eujyldEqlfdB0BFk6d8ZjlvoyvOnar0E634O0hCIXdCnX7fci_F3-AvqTXSY?type=png "Class Diagram")

</div>


---
### Activity Diagrams
---

**Activity** diagrams are behavioral diagrams that describe activity aspects within a system. An activity diagram moves just like a flow chart does, but does so with specific markers used for statements such as: if, switch and while (Visual Paradigm, 2024). Other markers can denote the start, stop, parallel activities and swim lanes (GeeksforGeeks, 2024).

The Activity diagram for this project depicts the process of the program from start to end, featuring all requested functional requirements, such as: a late fee system at 10p per day late, renting only in 3, 7 and 14 day intervals, having a teacher account that can control setup of new accounts and deletion of old accounts, amongst other requirements.

<div align=center>

**[Figure 5: Activity Diagram](https://www.plantuml.com/plantuml/png/hLLBRzj64BxlhnYWXqf03Z6QHoiU6iT9NGDjuSOfu4Cl8-vGMdWVpEnIgbhqltSu94LLIdgg3kPovfjlldci-IONvD85R_AJYoqo1iXRj6dluWOATsHCSSKJNDV5xLmvm3k7cnxs_WyChQVVepc9nGdrbm7vFVJiDyad1ky2RPWegkDzj8FP8Z-jVKTgVOlrquPJDpc_iYyilHnzYItnQ7z9tub7xTVCQJ-OrrxYpT-VaIEQGufML5scKJfBhxxzppHDYkN1_KbmzKeo66sRoNjNwYqiVaeR5q4YVkrS-NvfQim4YzyoCTniavmLi3HCBM4P7x1IW4ZjIeQo9SVGMo860XInzvZpNkHKnamX-wtpmdoNeHsTK2TcgYKhk0oBc9OGKu75WV9I0YU5zyJ1vUnIp9Eyevm9yv6mtXBBf6lfJPbnHuGA_XaZRYZGAG9WTSF2HO1QGsLM4vlWYBK-YBI7JhnVP-YB5D1hgBV8M2iaDOfgalUwVdBYW0MGIM0fK-mjYXbPkkW-TSFRIFXHd9gHhEOGKECu5_1Kn3hbK9issQCSnk0FlzngXXSGkx0cphtjvXOMBCWKPgsmeKYC9V5I0wv6Ui4_FZwNtoEuQQHIjF9BfaFgIcLEc_QEF6dJSakrQnnPwBHzhe75DHD82EIEISOhT76Ognat9uFLUDaGyfbq-eQYTKt_TnYQcVEjP0i71RFxRB5k4wpbSa19WCCMGA3OwN9fxd6xl39zSPCUIcSfbijDMasUkxYJH-93TGmwcaxW7yGYcr2D5SiMf4mP4DOfgKeMmD2jEstuuC0TEezhVzQsATEFQGy1um4i7lB4qWzolBfzvc-gu_7rVBnwKPqsR_LMicaqsMU0rf8LEbFddL0NN4lKCoWkK2uOsi_CQRvYVQsbu_Z5Qat3AOmxDSx6oDj1hmTFiPUzy5ZEjqU4mjNpLbtG445BtFT23PSQpUd2NAxJRBWNYX-8SYL7JvZ7gmWriWLB1PtFfm87nmwzisSAhqkXqFQZXnOFGOSiz7g2W5RQAgbpmMXxJ2D9ePQK_AyUpo4n3M7LMDB_TW5cdZEYuKjm-J_vyjiWo5CY4Sr9Fx2Vn27zoYMrvetuk-3_0G00)**

![Activity Diagram](https://www.plantuml.com/plantuml/png/hLLBRzj64BxlhnYWXqf03Z6QHoiU6iT9NGDjuSOfu4Cl8-vGMdWVpEnIgbhqltSu94LLIdgg3kPovfjlldci-IONvD85R_AJYoqo1iXRj6dluWOATsHCSSKJNDV5xLmvm3k7cnxs_WyChQVVepc9nGdrbm7vFVJiDyad1ky2RPWegkDzj8FP8Z-jVKTgVOlrquPJDpc_iYyilHnzYItnQ7z9tub7xTVCQJ-OrrxYpT-VaIEQGufML5scKJfBhxxzppHDYkN1_KbmzKeo66sRoNjNwYqiVaeR5q4YVkrS-NvfQim4YzyoCTniavmLi3HCBM4P7x1IW4ZjIeQo9SVGMo860XInzvZpNkHKnamX-wtpmdoNeHsTK2TcgYKhk0oBc9OGKu75WV9I0YU5zyJ1vUnIp9Eyevm9yv6mtXBBf6lfJPbnHuGA_XaZRYZGAG9WTSF2HO1QGsLM4vlWYBK-YBI7JhnVP-YB5D1hgBV8M2iaDOfgalUwVdBYW0MGIM0fK-mjYXbPkkW-TSFRIFXHd9gHhEOGKECu5_1Kn3hbK9issQCSnk0FlzngXXSGkx0cphtjvXOMBCWKPgsmeKYC9V5I0wv6Ui4_FZwNtoEuQQHIjF9BfaFgIcLEc_QEF6dJSakrQnnPwBHzhe75DHD82EIEISOhT76Ognat9uFLUDaGyfbq-eQYTKt_TnYQcVEjP0i71RFxRB5k4wpbSa19WCCMGA3OwN9fxd6xl39zSPCUIcSfbijDMasUkxYJH-93TGmwcaxW7yGYcr2D5SiMf4mP4DOfgKeMmD2jEstuuC0TEezhVzQsATEFQGy1um4i7lB4qWzolBfzvc-gu_7rVBnwKPqsR_LMicaqsMU0rf8LEbFddL0NN4lKCoWkK2uOsi_CQRvYVQsbu_Z5Qat3AOmxDSx6oDj1hmTFiPUzy5ZEjqU4mjNpLbtG445BtFT23PSQpUd2NAxJRBWNYX-8SYL7JvZ7gmWriWLB1PtFfm87nmwzisSAhqkXqFQZXnOFGOSiz7g2W5RQAgbpmMXxJ2D9ePQK_AyUpo4n3M7LMDB_TW5cdZEYuKjm-J_vyjiWo5CY4Sr9Fx2Vn27zoYMrvetuk-3_0G00 "Activity Diagram")

</div>

#### Tabular Description Of Use Case Diagram


<div align=center>
<br>

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
| Data      |   member details, rented books and fines.  |
| Stimulas     | User command issued by a library member.|
| Response     |  Display of Account details |
| Comments  |  The system should provide clear information to avoid confusion. They payment information should not be stored on the system. |


</div>


### State Chart Diagram

The purpose of a state chart diagram is to model the dynamic nature of a system. State chart diagrams act as a graphical representation of changes to components within a system by either internal or external events. A fully comprehensive state chart diagram would cover all possible states - including system crashes - in order for unexpected occurrences to be dealt with by a failsafe. In order to describe the relationship between components, a state chart diagram also includes the flow of control within a system (activities, data passthrough, etc).

<div align=center>

**[State Chart Diagram](State_Chart_Diagram.png)**

![State Chart Diagram](State_Chart_Diagram.png)

</div>

## Phase 3 - Implementation and Testing

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

Adds a new item to the inventory. It validates the input object items, checks if an item with the same name already exists, and adds the new item to the `inventoryList`.

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

### The `paymentGateway` partial class

The `paymentGateway` class is responsible for handling payment from the users through various types of cards. It facilitates the process of users making payments towards their owed fees or balances.

**Core Methods**

**`payFeesButton_Click`:**

Handles the logic for processing payments when the user clicks the "Pay Fees" button. It gathers information such as the credit card number, expiry date, CVC, and payment amount entered by the user. It validates the credit card details, checks if the payment amount exceeds the owed balance, and updates the user's balance in the database accordingly. If the payment is successful, it displays a confirmation message and navigates the user back to the student menu window.

**`IsValidCreditCard()`:**

Validates the credit card details entered by the user. It verifies that the credit card number, expiry date, and CVC meet the necessary criteria for a valid credit card.

**`GetCardType()`:**

This method determines the type of credit card based on its number. 

---
### The `bookRental` partial class

This class is responsible for handling searching and renting books in the library management system. Users are able to search for books or journals by entering the title, author, or ISBN number and they are allowed to rent books for 3,7 or 14 days.

**Core Methods**

**`titleSearch_TextChanged()`:**

Filters the list of available books based on the entered title, updating the search results displayed.

**`isbnSearch_TextChanged()`:**

It filters the books based on the ISBN number entered by the user and shows possible results.

**`authorSearch_TextChanged()`:**

Filters the available books and journals list by the searched author name and displays the result.

**`submitButton_Click()`:**

This function processes the selected book or journal for renting. This function updates the status of the book and records the rental duration and show the confirmation message upon button clicked.

---

### The `studentMenu` partial class


The `studentMenu` class in the LMS_WPFApp responsible for managing the user interface and interactions related to student-specific functionalities within the application. It provides options for students to view their own account, pay any outstanding balances and rent any books.

**Core Methods**

**`payFeesButton_Click()`:**

Opens the payment gateway window to allow the students to pay their outstanding balance. This also Retrieves the current outstanding balance and passes it to the payment gateway window.

**`rentBookButton_Click()`:**

Navigates to the bookRental window for allowing students to rent books.

**`LoadDebtFromCSV()`:**

Shows the current outstanding balance of the user also the updated amount after paying.

---

### The `teacherMenu` partial class

This class provides options for staff or teachers to manage user accounts, such as deleting existing accounts, creating new user accounts or editing information of the user.

**`deleteUserButton_Click()`:**

Deletes the existing user from the user data after confirming the deletion with a message box.

**`createUserButton_Click()`**

Allows staff to create a new user. This function also hashes the password using SHA512 before adding it to the user data.

**`GenerateUsername()`**

it generates a unique username based on the provided first name and last name. this function instructs the username using the first letter of the first name, first letter of the last name, a random number, and a random letter.

---

### The `loginScreen` partial class

This class handles user login attempts, verifies credentials, and directs users to the appropriate menu based on their access level.

**Core Methods**

**`loginButton_Click()`:**

It provides a username and password input for users. Then it checks if the username exists in the user database and if the provided password matches the one stored in the database managed by the `UserManager` class. Then it provides message for unsuccessful login attempts. If the login is successful it navigates the users to the appropriate menu based on their access level.

---
### The `bookRental` partial class

This class is responsible for handling searching and renting books in the library management system. Users are able to search for books or journals by entering the title, author, or ISBN number and they are allowed to rent books for 3,7 or 14 days.

**Core Methods**

**`titleSearch_TextChanged()`:**

Filters the list of available books based on the entered title, updating the search results displayed.

**`isbnSearch_TextChanged()`:**

It filters the books based on the ISBN number entered by user and shows the possible result.

**`authorSearch_TextChanged()`:**

Filters the available books and journals list by the searched author name and displays the result.

**`submitButton_Click()`:**

This function processes the selected book or journal for renting. This function updates the status of the book and records the rental duration and show the confirmation message upon button clicked.

---

### The `studentMenu` partial class


The `studentMenu` class in the LMS_WPFApp responsible for managing the user interface and interactions related to student-specific functionalities within the application. It provides options for students to view there own account, pay any outstanding balances and rent any books.

**Core Methods**

**`payFeesButton_Click()`:**

Opens the payment gateway window to allow the students pay there outstanding balence. This also Retrives the current outstanding balance and passes it to the payment gateway window.

**`rentBookButton_Click()`:**

Nevigates to the bookRental window for allowing students to rent books.

**`LoadDebtFromCSV()`:**

Shows the current outstanding balance of the user also the updated amount after paying.

---

### The `teacherMenu` partial class

This class provides options for staff or teacher to  manage user account, such as deleting existing account, creating new accont or edit information of the user.

**`deleteUserButton_Click()`:**

Deletes the existing user from the user data after confirming the deletion with a message box.

**`createUserButton_Click()`**

Alows staff to create new user. This function also hasesh the password using SHA512 before adding it to the user data.

**`GenerateUsername()`**

it generates a unique username based on the provided first name and last name. this function onstructs the username using the first letter of the first name, first letter of the last name, a random number, and a random letter.

---

### The `loginScreen` partial class

This class handles user login attempts, verifies credentials, and directs users to the appropriate menu based on their access level.

**Core Methods**

**`loginButton_Click()`:**

It provides a username and password input for users. Then it checks if the username exists in the user database and if the provided password matches the one stored in the database managed by the `UserManager` class. Then it provides a message for unsuccessful login attempts. If the login is successful it navigates the users to the appropriate menu based on their access level.

---

### The `paymentGateway` partial class

This class handles the payment section of the application.

**Core Methods**

**`payFeesButton_Click()`:**

Upon the button click, the cardNumberText.Text, expiryDateText.Text, CvcText.Text and PaymentText.Text have their values stored in string and float parameters. These Parameters are then used to validate the card details, and pay the amount entered in to the PaymentText.Text textbox. The method from the Users class 'EditObject' is then used to change the stored amount of money owed in the userDatabase.csv.

**`IsValidCreditCard()`:**

This is a private void method which takes the cardNumber, expiryDate and cvc and strings and checks their lengths to ensure the right amount of characters are entered in to the relevant text boxes.

**`GetCardType()`:**

A private string that takes the cardNumber value, and removes any spaces or '-' characters to make one long string value to use in the cleanCardNumber value to identify which card is being used, where a card number starting with 4 is Visa, 5 is Mastercard, and 34 is American Express.

**`cancelPayFeesButton_Click()`:**

This takes the user back to the studentMenu window.

**`TextBox_TextChanged()`:**

Placeholder function.

**`CardNumberText_TextChanged()`:**

Placeholder function.

**`PaymentText_TextChanged()`:**

Placeholder function.

---

## Testing

**Testing Strategies**

The team employed a variety of testing strategies to ensure the reliability and functionality of the program. 

**Integration Test**

Integration testing is performed to test how the individual components of the program work together as a whole.

**Unit Test**

Unit testing is used to test individual components or units of the program in isolation.

**UI Testing**

Tests the user interface elements and their behaviour. It verifies the window opens and closes as expected and ensures UI elements function correctly based on user interaction.

#### `teacherMenuTests`:

The `teacherMenuTests` class contains unit tests for the following high-level teacher menu functionality:
- Opening window
- Closing window
- Generating usernames
- Creating new users
- Deleting users
- Database handling

All tests passed successfully (as shown in **Figure 8**), and the teacher menu functionality was verified to be working as expected.

<div align=center>

**[Figure 8: Teacher Menu Test Results]()**

![Teacher Menu Test Results](Documentation/teacherMenuTestResults.png)

</div>

#### `userManagerTest`:

<div align=center>

**Table 2: UserManager Test Cases and Result**

| Test case | Description | Result | Passed/Failed
|:---:|:---:|:---:|:---:|
|` OpenDatabaseFileTest` | Tests the `OpenDatabaseFile` method in UserManager to ensure it correctly reads the database file. | Database file is successfully opened  and `userList` and `tableHeader`s are populated. | Passed 
| `CloseDatabaseFileTest` | Tests if the method properly close the database file and save if any changes occur | Successfully closed the database and saved the updated data | passed
| `CreateNewFieldTest` | Tests if `CreateNewField` method successfully creates a new field to table headers and initializes it with empty value | Successfully Created a new field to `tableHeader` and has empty values for all the user in `userList` | Passed
| `CreateNewObjectTest` | Test the CreateNewObject to ensure it's correctly create a new user or object to an existing `userList` | The new object successfully added to `userList`| Passed
| `EditObjectTest` | Test the EditObject function to ensure it correctly modify existing object's field value | Successfully modify an exististing object's field value | Passed 


**[Figure 9: UserManager Test Results]()**

![UserManager Test Results](Documentation/UserManagerTest.png)

</div>

#### `bookRentalTest`:

<div align=center>

**Table 3: bookRental Test Cases and Result**
| Test case | Description | Result | Passed/Failed
|:---:|:---:|:---:|:---:|
|`bookRentalOpenTest` | Tests If the `bookRental` Window open successfully | The window opens when the program run but the test not running in test explorer | Not Run
| `bookRentalCloseTest` | Tests If the `bookRental` WIndow closes successfully | The window closes when the program run but the test not running on test explorer | Not Run

  
**[Figure 10: bookRental UI Test Results]()**

![bookRental Test Results](Documentation/bookRentalTest.png)

</div>

#### `paymentGatewayTest`:

<div align=center>

**Table 4: paymentGateway Test Cases and Result**
| Test case | Description | Result | Passed/Failed
|:---:|:---:|:---:|:---:|
|`TestGetCardType_Visa` | Tests the `getCardType` function to see what card is being used to pay with. This test tries to use the Visa card. It also tests to see if the window opens successfully | The window opens when the program is run, and the test passes as well, only when the `getCardType` function is run as public. | Run
| `TestIsValidCreditCard_Valid` | Tests the UI`IsValidCreditCard` function. And tests the UI by loading and closing the test window. | The window closes and no errors are found. | Run


**[Figure 4: paymentGateway UI Test Results]()**

![bookRental Test Results](Documentation/paymentGatewayTestResults.png)

</div>

## Project Planning

### Gantt Chart

Written in the popular app Mermaid for chart creation, this Gantt chart shows the planning for phase 1 and 2 of this project, of which phase 1 is already completed. Phase 3 will be fleshed out in the future once phase 2 is completed on the 23rd of January 2024.

The Gantt chart, Overall Architecture, Sequence Diagram, Class Diagram, Activity Diagram and State Chart Diagrams are to be drafted by the 2nd of January 2024. After this period, the diagrams and information are to be finalised and referenced. This again will give clarity in what is completed/to be completed in the future of the project, to give the team a boost in moral via means of a visible road map.

A Gantt chart is well known to be an intuitive, simple, practical and useful visual representation of activities and their associated durations. They are a very widely used tool within industry, and are built to focus on 5 main areas (Geraldi & Lechler, 2012).

#### Unidimensional
* One view being 'time', emphasising efficiency.

#### Objective
* Object-oriented.

#### Deterministic
* A Gantt chart determins all that will occur in the project.

#### Analytical and Accountable
* Division of the project allows for smaller bite-sized chunks so resources can be allocated efficiently.

#### Sequential
* After tasks have been completed, then the next task is to be completed, thus sequenciality.

<br>

A Gantt chart is well known to be an intuitive, simple, practical and useful visual representation of activities and their associated durations. They are a very widely used tool within the industry and are built to focus on 5 main areas. (Geraldi & Lechler, 2012)
<br>

<div align=center>

**[Figure 6: Project Plan Gantt Chart, Phase 2 Update](https://mermaid.ink/img/pako:eNq9Vm1v2jAQ_itWPidtE7q2y7eqqNW0oVXQaprEFxMf4C1xsrPdClX97zs7LyQMtlXTQAiS3HPPPXe-c_wSZKWAIA1WXBkzV4w-Rpoc2APwgsXsHstvkBl25-zsZs2xQQlu4LbEghvGxuNoMom-0meuaqsmH1kqNiuX5pkjOJ4MtGYTCpfXmLHUmdXawdIMpQl1VYgwGUVxHCVnyShksaiRX8gKka0YV4JNYQkIithScni2GPKlAWTe-6LxmMKThGeWdiaHa-mGEh81Iabww0qEApTRB9RZHIj7kzaLW2nOdVeZxa31sLjZRhso_kaexjfWrqdP79GHDtDZDyucSv1d1-R0xaqcKyXV6vfBESvH2NN7KX7Jq_ap1fgUyUu0khuGLs0TlsbxKX09224bflAGS2H9TW259_fAxkh85HvRq9xVw3krFc-lhqH6pqeqOIsJ-35vUR74IofTj1wt-FHi3eWl1hw3_xqL7Q920j7P4r0t0C1s20It3R03a0BqB-onXIUDJaOGfGYXhTQ9Et973TKvetCdpHe3pJ28fRL9kJdvyb1trPs1J2TCbOV2PKrmeRQnNeGVaCRtfzpxn58AeZ6za8zWNAOZsQj7V2fLty34gU44S6Izn8z5wU54nHxyOxq7carHkq-QF_V4-p7Ux9Awo93KV7SJf4yYNzmnt8sRA17T35M0m2PGnBnXgr7ju7X9n3HbbXSowk-E7k9H7IZtMGrJxc74pFUS9lWNrgaAEQFG7n3QSXl3LoIwKIBOGFLQAeXFwecB7ScFzIOULgUsuc3NPJirV4Jya8rZRmVBatBCGNQD25QpSJc81_QUhDQlTupDjz_7vP4EwNzBfw?type=png)**

![Project Plan Gantt Chart](https://mermaid.ink/img/pako:eNq9Vm1v2jAQ_itWPidtE7q2y7eqqNW0oVXQaprEFxMf4C1xsrPdClX97zs7LyQMtlXTQAiS3HPPPXe-c_wSZKWAIA1WXBkzV4w-Rpoc2APwgsXsHstvkBl25-zsZs2xQQlu4LbEghvGxuNoMom-0meuaqsmH1kqNiuX5pkjOJ4MtGYTCpfXmLHUmdXawdIMpQl1VYgwGUVxHCVnyShksaiRX8gKka0YV4JNYQkIithScni2GPKlAWTe-6LxmMKThGeWdiaHa-mGEh81Iabww0qEApTRB9RZHIj7kzaLW2nOdVeZxa31sLjZRhso_kaexjfWrqdP79GHDtDZDyucSv1d1-R0xaqcKyXV6vfBESvH2NN7KX7Jq_ap1fgUyUu0khuGLs0TlsbxKX09224bflAGS2H9TW259_fAxkh85HvRq9xVw3krFc-lhqH6pqeqOIsJ-35vUR74IofTj1wt-FHi3eWl1hw3_xqL7Q920j7P4r0t0C1s20It3R03a0BqB-onXIUDJaOGfGYXhTQ9Et973TKvetCdpHe3pJ28fRL9kJdvyb1trPs1J2TCbOV2PKrmeRQnNeGVaCRtfzpxn58AeZ6za8zWNAOZsQj7V2fLty34gU44S6Izn8z5wU54nHxyOxq7carHkq-QF_V4-p7Ux9Awo93KV7SJf4yYNzmnt8sRA17T35M0m2PGnBnXgr7ju7X9n3HbbXSowk-E7k9H7IZtMGrJxc74pFUS9lWNrgaAEQFG7n3QSXl3LoIwKIBOGFLQAeXFwecB7ScFzIOULgUsuc3NPJirV4Jya8rZRmVBatBCGNQD25QpSJc81_QUhDQlTupDjz_7vP4EwNzBfw?type=png "Project Plan Gantt Chart")

</div>


## Kanban

### Kanban

Kanban is a method of improving software development by means of creating a visual flow using boards and charts. The idea is to promote team communication, collaboration and visibility of project timelines and projections Radigan, D. (2022).

Kanban originates from the manufacturing industry, specifically Taiichi Ohno from Toyota in Japan, where it literally translates to "signboard". Toyota continue their Kanban philosophy under a new name, "Just-in-Time" method TOYOTA (2023), where they focus more on incorporating lean principles however Kanban, in the last decade, has been on the rise in tech and is being used in an array of diverse software organisations.

Below is a screenshot of our project Kanban from 01/12/23 and will change throughout the project to include new tasks as they are defined and allocated. The board has been split into major categories that define each task's state which project contributors can use to visualise the progress of the overall project.

<div align=center>

**[Figure 3: Kanban Board 01/12/23](https://github.com/orgs/TeachingMaterial/projects/9/views/2)**

![Kanban](/Documentation%20Pictures/kanban.png "Kanban")

</div>

Below is a screenshot of our project Kanban from 21/01/24.

<div align=center>


**[Figure 3: Kanban Board 21/01/24](https://github.com/orgs/TeachingMaterial/projects/9)**

![Kanban](kanban2.png)

</div>

Below is a screenshot of our project Kanban from 21/01/24.

<div align=center>

**[Figure 9: Kanban Board Phase/3](https://github.com/orgs/TeachingMaterial/projects/9)**

![Kanban](Documentation/kanban.png)


</div>

## References and Acknowledgements

We would like to thank the following for their contributions and support with this project:

<div align=center>

[CompEng0001](https://github.com/CompEng0001) for his guidance.<br>

Nathaniel Sadler, for his donation of Logo designs (Sadler, 2024).

</div>

## References

bedbugexterminatorpro.ca, 2023. library.jpg. [Online] 
Available at: https://www.bedbugexterminatorpro.ca/wp-content/uploads/2019/05/libraries.jpg

Geraldi, J. & Lechler, T., 2012. Gantt Chart and the Scientific Management in Projects. International Journal of Managing Project in Business, 5(4), pp. 578-594.

IBM, 2024. Processing Transaction Systems. [Online] 
Available at: https://www.ibm.com/docs/en/txseries/9.1?topic=processing-transaction-systems
oclc.org, 2023. Dewey Services. [Online] 
Available at: https://www.oclc.org/en/dewey.html

Radigan, D., 2023. Software Development - Kanban. [Online] 
Available at: https://www.atlassian.com/agile/kanban

Sadler, N. N., 2024. Logo resources, LMS. Bromley: Nathaniel Sadler Motion Design: https://vimeo.com/nathanielsadler.

Toyota, 2023. Toyota Production System - Company Information, Vision & Philosophy. [Online] 
Available at: https://global.toyota/en/company/vision-and-philosophy/production-system/

[CompEng0001](https://github.com/CompEng0001)
Nathanial Sadler

</div>

---

Amazon. (2023, 12 04). Deployment Methods. Retrieved from docs.aws.amazon.com: https://docs.aws.amazon.com/whitepapers/latest/practicing-continuous-integration-continuous-delivery/deployment-methods.html

Budhiraja, G. (2023, 12 04). Incremental Model. Retrieved from codingninjas: https://www.codingninjas.com/studio/library/incremental-model

Chitra, S. (2023, 12 04). Functional vs Non-Functional Requirements. Retrieved from Geeks for Geeks: https://www.geeksforgeeks.org/functional-vs-non-functional-requirements/

<div id="Figure_1">

Collegenote.net. (2023, 12 03). Incremental Development. Retrieved from collegenote.net: https://www.collegenote.net/curriculum/software-engineering-csit/52/298/

</div>

Geraldi, J., & Lechler, T. (2012). Gantt Chart and the Scientific Management in Projects. International Journal of Managing Project in Business, 5(4), 578-594.

gov.uk. (2023, 12 04). Data Protection: The Data Protection Act. Retrieved from gov.uk: https://www.gov.uk/data-protection

Grady, J. O. (2006). System Requirements Analysis. Burlington: Elsevier.

Hiền, B. X. (2023, 12 2023). Incremental Process Model in Software Engineering From A-Z. Retrieved from biplus.com.vn: https://biplus.com.vn/incremental-process-model-in-software-engineering/

Howard. (2023, 12 04). Server Redundancy: Types, Benefits, & Design. Retrieved from community.fs.com: https://community.fs.com/article/server-redundancy-types-benefits-and-design.html

International ISBN Agency. (2023, 12 04). International ISBN Agency. Retrieved from International ISBN Agency: https://www.isbn-international.org/

Kniberg, H., & Skarin, M. (2010). Kanban and Scrum, making the most of both. C4Media Inc.

legislation.gov.uk. (2023, 12 04). Freedom of Information Act 2000. Retrieved from legislation.gov.uk: https://www.legislation.gov.uk/ukpga/2000/36/contents

Maguire, M. C., Kirakowski, J., & Vereker, N. (1998). RESPECT - User-Centered Requirements Handbook - Version 3.3 (Version 3.3 ed.). Loughborough: RESPECT Consortium 1998.

oclc.org. (2023, 12 04). Dewey Services. Retrieved from oclc.org: https://www.oclc.org/en/dewey.html

Pedamkar, P. (2023, 12 04). Incremental Model. Retrieved from educba.com: https://www.educba.com/incremental-model/

rdrr.io. (2023, 12 04). md5sum: Compute MD5 Checksums. Retrieved from rdrr.io: https://rdrr.io/r/tools/md5sum.html

IBM (2021). Sequence Diagrams. Retrieved from IBM : https://www.ibm.com/docs/en/rsm/7.5.0?topic=uml-sequence-diagrams.

Srinam (2023). Use Case Diagram. Retrieved from Geeks for Geeks : https://www.geeksforgeeks.org/use-case-diagram/.

IBM Corporation (2021) IBM Documentation, Transaction Processing Systems. Available at: https://www.ibm.com/docs/en/txseries/9.1?topic=processing-transaction-systems

Toyota production system . [online] Toyota Motor Corporation Official Global Website. Available at: https://global.toyota/en/company/vision-and-philosophy/production-system/.
  

IBM (2021). Sequence Diagrams. Retrieved from IBM : https://www.ibm.com/docs/en/rsm/7.5.0?topic=uml-sequence-diagrams.

Radigan, D. (2022). What is kanban? [online] Atlassian. Available at: https://www.atlassian.com/agile/kanban.

bedbugexterminatorpro.ca. (2023, 12 08). library.jpg. Retrieved from bedbugexterminatorpro.ca: https://www.bedbugexterminatorpro.ca/wp-content/uploads/2019/05/libraries.jpg

GeeksforGeeks. (2024, 01 21). Difference between Sequence Diagram and Activity Diagram. Retrieved from GeeksforGeeks.org: https://www.geeksforgeeks.org/difference-between-sequence-diagram-and-activity-diagram/

GeeksforGeeks. (2024, 01 21). Use Case Diagrams | Unified Modeling Language (UML). Retrieved from GeeksforGeeks.org: https://www.geeksforgeeks.org/use-case-diagram/

