<!-- omit in toc -->
# Phase 2 - System Modelling and Design

<!-- omit in toc -->
## Team 1- Library System

<div align=center>

![The Library is a cool place to go and hang out!](https://th.bing.com/th/id/OIP.GBmXICXxseHDVOZBynhjPwHaEc?pid=ImgDet&rs=1 "The Library is a cool place to go and hang out!")

</div>

<!-- omit in toc -->
## Contents

- [Introduction](#introduction)
- [Overall Architecture of the System](#overall-architecture-of-the-system)
  - [Use Case Diagrams](#use-case-diagrams)
  - [Sequence Diagrams](#sequence-diagrams)
  - [Class Diagrams](#class-diagrams)
  - [Activity Diagrams](#activity-diagrams)
  - [State Chart Diagrams](#state-chart-diagrams)
- [Gantt Chart](#gantt-chart)
- [References](#references)
- [Requirements](#requirements)
  - [A library system](#a-library-system)
    - [Staff](#staff)
    - [Students](#students)
    - [Card Payments](#card-payments)
    - [Inventory](#inventory)
    - [Storage system of articles](#storage-system-of-articles)
    - [Data storage](#data-storage)

## Introduction

The library system design and development continues into Phase/2 documenting a list of diagrammatic sections that meticulously breakdown the system architecture into more manageable and understandable pieces whilst keeping both abstraction for the end user and technicality for the any future maintenance:

- **Use Case Diagrams**- show which functions of the system interact with the environment.
- **Sequence Diagrams**- show the actions whilst using the system between the user and system components.
- **Class Diagrams**- show classes and their relationships within the system.
- **State Diagrams**- show the systems response to any events that occur during runtime.

This phase also includes updated references and Kanban and a new Gantt chart to display the key milestones for Phase/2 activity until delivery on 23/1/24. Previous tasks from Phase/1 have been labelled accordingly and archived to clear up confusion between done and ongoing tasks of Phase/2.

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

**Information systems architecture** allows the developers to employ a storage base for the library information as well as include transactional features such as querying the storage base for information when required. Secure events such as user logins and payments can be adequately processed using encryption within the base and more simple events such as a book search will be effortless. The end user will be able to use a simple but effective UI to easily navigate and operate the application. Overheads for processing and storage can be managed remotely ensuring minimal downtime and costs for the user. Security of both hardware and software can be controlled by the developers during both development and during the maintenance and support period as specified by the customer.

### Use Case Diagrams
---
A use case diagram, which shows how users interact with a system visually, is an essential tool in system design. It acts as a guide to help stakeholders communicate and direct the development process by helping to understand the functional needs of a system from the viewpoint of the user.(Srinam 2023)
<div align=center>
<br>

**Figure 1: Use Case Diagram of the Library System**

![Use Case Diagram!](https://www.plantuml.com/plantuml/png/bLBDZjD03BxxAQmzPG-jX112GbMrK2WNLa9TkFNYdV4cequybUC8ylQGJakPT5VQvZIPxyUUpxxhZDJwDc8CZqewO3TqnYq0H7uoj8GQwiRG1sLd8Gbqko1xKcfnJsv7DJ_O41b7cAIE343EakBDjuDZ8Bb1wZ2U_axmFRUFh0UiFHm181zmDfjXzS2ahi5FAUrkpm1M6nOxt7Qt1J-cEaXvzPq6N0VXydRLiDiXEPTwiHBQiFKg9tU0e-a8dX-0KFHMWb3Tar3DMyacM89VMKZ963UyJselYdCuKtdPtqGBy7yqy_aIgtLIV8kUXh_a3xXOO10NUy-uN3vFVdyD-Ssx5zW0rKVlZ-aivdESPd9X_vaZ6r-Z-BdtOumhCegfpg9prLVoYx9JoRyf4-PfPD75YAR2_7ZXNzVASZVNb_lYW-KrVwNYlDUBCRJU6XOBZYmasSgQGcI_bHyw8DKKv6Z0lqy6vHvcbrL3MZF6CMJDw5CGljG2tB7uleqmVdy0)

**Tabular Description Of Use Case diagram**
</div>



### Sequence Diagrams
---

A sequence diagram is a type of Unified Modelling Language (UML) diagram that shows the messages that are sent back and forth between objects during an interaction. A sequence diagram shows a set of items, symbolised by lifelines, together with the messages they exchange throughout the course of their relationship.(IBM 2021)
<div align=center>
<br>

**Figure 2: Sequence Diagram for Member to Reserve a book**

![Sequence Diagram Member!](https://www.plantuml.com/plantuml/png/VP9HRjim38RVTGh2JmdGN20FGxiK60Pq0zPW1s1ijX4gIuP4PV3j9yaHPC5staJo8t_-j9yTesNVAu4j6mlDcxnOj2Fyelv2jW5qqAUd608eMpcWveATHyVK9yobPuszUBwI3Z6oD3fX658rT496PJvJjPtUDV3Tc2zu3PKBEafOTmz4N5lUa2blcUEyJeudtHnbdP8e4wT1SFXs7t64D_CfzQxnZgp6dfedQ0Pqxf-nNRCN4nNvA764cMVQR8ee76OQzQNUoNd5ExQUia2axoQFy2hTe71CYvrzsv9pkxqG7LLsrxoS2MrxXNZIida-HowdwZqNo_auH_ZZoOuYnt2OzyOk-Aa_J6ajmgNwmC-aFfbtSpjPPCtHEsdUidEwKliLYoytb0elKaaUrvtz85w03tnMt9RVcXAeU9a6wNAiI00iNHI707EbillV8Rmf8cT6zkufjL2t3nth7av6VqZRfvyjG4i32sJxgqMj2YRbQDteRyF5xCEXiJtG1IRTLNz4zZNFJUFccMcgU0xTlbV_0G00)

**Figure 3: Sequence Diagram for Librarian to Return book and fine collection**

![Sequence Diagram Librarian!](https://www.plantuml.com/plantuml/png/jPJ1ZjD038RlynHMJgr4No07j405McaHKWjdv2PUThIJIJIUMTItPvnfS8OjvSIjjZ_Rl_yckUE88QR1mOCz1Gvdu3D76WnsSGpGI1Q3HTy0ChWbCbFkifsTqCS5EiDnRft9CgN6tgNuH3x76ErO1c9ErT3xSNoUIwVyeovzfk540GxKZQ6VcO66G5rDVRIUoW3hN5tQOyGJSYdtby38gVO58-bvcYftQ2o2DHAD6XKr6ei0ZNIV-Rq7Tcyl6rfu67zOlsaIK_0uKFC6cWcPVygjMrCeuKL12oilwQzDWi9kjQF-1mx4oSLD38cM1KAh3ItiBKyEpxEsO-ewOjviZUcfDkJwHGUAAVXYakelBhNmuOcwvtlcH7kAQ1rl6Y6_ptTiJS6aOJ6kXKyKjU4FVg5Wjzenqt1plkgzHHjqiQw3vSk1rCFeuQiT2CO0ZzOJJ6Xx0t3LbMzJBxvL3tDcNnjKmC8LB5jFZkcra2yl5Ff41k3ctrZqxZ6IDbpLAEyGMFyuLiBaUIwr-rAIHEMWrcuB4QwCrsAzuVzP22QZv7lpZ-do8GAE61FNBkJy0Wbpd97whRZWwuoqhUCYiIBoyQjOFnYQKy76t97lq-1-0G00)

</div>

### Class Diagrams
---
### Activity Diagrams
---
### State Chart Diagrams

## Gantt Chart
## References
- Put references in like you did last time so th5528e can add them
  
Srinam (2023). Use Case Diagram. Retrieved from Geeks for Geeks : https://www.geeksforgeeks.org/use-case-diagram/.

IBM (2021). Sequence Diagrams. Retrieved from IBM : https://www.ibm.com/docs/en/rsm/7.5.0?topic=uml-sequence-diagrams.



## Requirements
### A library system
#### Staff
- Staff all have the same access level.
- Staff can create a user.
- "Staff can delete a user, but a confirmation window will occur when asking to delete a user."
#### Students
- Students will have a lower access level with limited access.
- Students can look at their own account and pay any outstanding balances.
#### Card Payments
- There needs to be a card processing system for payment.
- Payment cannot be stored.
- A validation check is required and keep in mind all credit card numbers depending on vendor have a different starting number.
#### Inventory
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
#### Storage system of articles
- Must use the Dewey Decimal System.
- Renting
- Books can only be rented in 3, 7, and 14 day intervals at a time.
- Renting starts the same day they take out the article.
- 10p late fee per day late.
#### Data storage
- JSON, XML, CSV, matrix -  any of these to show what each student has taken out (perhaps start all csv/text files with words so that the files can be identified as book logs - Toby idea).
