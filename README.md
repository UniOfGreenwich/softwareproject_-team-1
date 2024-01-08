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
### Sequence Diagrams
---
### Class Diagrams
---
### Activity Diagrams
---
### State Chart Diagrams

## Gantt Chart
## References
- Put references in like you did last time so th5528e can add them




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
