# Phase 2 - System Modelling and Design

# Team 1- Library System

<div align=center>

![The Library is a cool place to go and hang out!](https://th.bing.com/th/id/OIP.GBmXICXxseHDVOZBynhjPwHaEc?pid=ImgDet&rs=1 "The Library is a cool place to go and hang out!")

</div>

## Contents

- [Phase 2 - System Modelling and Design](#phase-2---system-modelling-and-design)
- [Team 1- Library System](#team-1--library-system)
  - [Contents](#contents)
  - [Introduction](#introduction)
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


---
<div align=center>
<br>

**Table 1: Task Allocation**


| Username | Tasks |
|:---:|:---:|
| [th5528e](https://github.com/th5528e) | Glossary // References // Gantt Chart // Kanban
| [Repi909](https://github.com/Repi909) | Github Admin // Introduction // Kanban
| [GeorgeElliotMathieson](https://github.com/GeorgeElliotMathieson) | Risk and Risk Planning // System Requirements
| [shuvo00000](https://github.com/shuvo00000) | Software Process Model // User Requirements

</div>

## Use Case Diagrams
## Sequence Diagrams
## Class Diagrams
## Activity Diagrams
## State Chart Diagrams
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
