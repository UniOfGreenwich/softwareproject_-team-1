# Phase 1 - Requirements Engineering

# Team 1- Library System

![The Library is a cool place to go and hang out!](https://th.bing.com/th/id/OIP.GBmXICXxseHDVOZBynhjPwHaEc?pid=ImgDet&rs=1 "The Library is a cool place to go and hang out!")

---
### Contents

  - [Introduction](#introduction)
  - [Table](#table)
  - [Software Process Model](#software-process-model)
  - [Glossary](#glossary)
  - [User Requirements Definition](#user-requirements-definition)
  - [System Requirements Specification](#system-requirements-specification)
  - [Possible Risks and Risk Planning](#possible-risks-and-risk-planning)
  - [Gantt Chart of the Project Plan](#gantt-chart-of-the-project-plan)
  - [Kanban](#kanban)
  - [References and Acknowledgements](#references-and-acknowledgements)

## Introduction

The library system, commissioned to us as a project by our customer ***Blair&Co***, was the result of a need for a new and modernised system to monitor and control their extensive collection of computer hardware, programming and engineering documents dating back to early 1980s MS-DOS documentation all the way through to generative AI journals printed this year by organisations such as OpenAI.

The team was given a specification by our customer which involved basic functions such as an inventory system through to advanced functions such as payment methods and authentication for security purposes.

The team decided a ***Plan Driven Incremental Design*** process was to be used as we could easily adapt to changing customer needs whilst also making deadlines key.

## Table

| Name | Tasks |
|:---:|:---:|
| Toby Hagon | Glossary // References // Gantt Chart & Kanban
| Jake Willshire | Github Project // Introduction // Github Admin
| George Mathieson | Risk and Risk Planning // System Requirements
| Azharul Haque Shuvo | Software Process Model // User Requirements
## Software Process Model

## Glossary

> **User Requirements**

Specifying a system's requirements from a user's point of view. Functions that support a user in their tasks. e.g. the interfaces they will use, physical and mental support, usablilty goals. (Maguire, et al., 1998)

> **System Requirements**<br>

> **Gantt Chart**<br>

> **Kanban**<br>

> **Functional Requirements**<br>

> **Non-Functional Requirements**<br>

****
****
****
****
****
****
****
****


## User Requirements Definition

## System Requirements Specification

What follows is an outline of everything expected of the system in terms of functionality, compatibility, and back-end processing techniques.

### Functional:

**Account Management**
- Access levels are determined by the organisation's personnel hierarchy
- Account creation and deletion by authorised staff
- Search, sort, and filter functionality for authorised staff
- Account information is editable only by account-holder
  - Encrypted and verified by md5sum
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
- Dewy Decimal Classification
- Book information
  - ISBN
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

## Possible Risks and Risk Planning

A stock management and lending system such as this has few - but by no means trivial - intrinsic risks derived from any aspect of the hardware, software, and/or personnel. Significant risks that we're aware of and continually take into consideration are as follows...

**Hardware:**
- Limited server data storage for database expandability
- Exiguous server cache for indexing and logging
- Unsuitable networking connections between server(s) and clients
- Subpar server/client processing speed
- System outages and/or data loss due to a lack of server redundancy

**Software:**
- Non-compliance with data protection legislation due to inadequate encryption and deletion processes
- Inconsistent data validation techniques
- Arduous bug fixing due to poor code formatting, annotations, etc
- Inappropriate datatype selection leading to overflow, truncated, and/or inaccurate data
- Redundant, non-modular, and inefficient code causing system underperformance
- Unrobust data handling processes that allow for database conflicts and the overwriting of data

**Personnel:**
- User error from insufficient training
- Data privacy/security compromised by unconfigured access levels
- Project drift due to infrequent communication with stakeholders
- Unsympathetic, offputting deployment method and timeframe
- Failure to provide technical support for the use and maintenance of the system


## Gantt Chart of the Project Plan
Written in the popular app Mermaid for chart creation, this Gantt chart shows the planning for phase 1 of this project and will be fleshed out to show phases 2 and 3 when they have been finalised.

The Gantt chart, Kanban/Table, Introduction, and Glossary are to be drafted by the 23rd of November 2023. This is to allow for clarity in what is completed/to be completed so far within the project and to give a base to other sections of the project, thus boosting the team's confidence via means of a visible road map.

A Gantt chart is well known to be an intuitive, simple, practical and a useful visial representation of activities and their accociated durations. They are a very widely used tool within industry and are built to focus on 5 main areas.

> Unidimentional

* One view being 'time', emphasizing efficiency.

> Objective
* Object oriented.

> Deterministic
* A Gantt chart determins all that will occur in the project.

> Analytical and Accountable
* Division of the project allowing for smaller bite-sized chunks so resources can be allocated efficiently.

> Sequential
* After tasks have been completed, then the next task is to be completed, thus sequenciality.
---
A Gantt chart is well known to be an intuitive, simple, practical and useful visual representation of activities and their associated durations. They are a very widely used tool within the industry and are built to focus on 5 main areas.

(Geraldi & Lechler, 2012)

![Project Plan Gantt Chart](https://mermaid.live/edit#pako:eNq9VFtr2zAU_ivCz3Ib2WkHfm1oGCMQko4x8ItinTjabNk7khZC6X_f8S23JV1LYcYPls93O9JBz0FWKQiSIJfGudQwepx2BbAnkCUTbI7VD8gcmzZ19rCR2KOUdPBYYSkdY5NJOJuF3-lJTVe1xNGVYctq7bYSodHJwFo2I7uiw0y0zby1DSzJUDtu61LxKA6FCKNRFHMmVIf8RlUIfc2kUWwBa0AwpJYQYeuRy7UDZC37vmcs4LeGLUv2pQY3yJ1G_GoJsYBfXiOUYJy9ks7jSbh_ZfN4iNZQz5N5PFSvh1vurIPyLfEsvnPvjvLZC_mwAezr1xMutP1pO3H6YnUhjdEmf90csW4Uj_J-Un_11XG6NG2LxFJD5F5h3-YNS4S4pbdVOx_Dz8ZhpXy76Crzdg1sgqRH3PvDzg1RHrWRhbZwGr4fqVpkgtzji3vyJFcF3H6RZiX_h920qKyVuPugFbvsdTP8z8TF89-f6jA_g9xUug0gzQINE-b8OIgYjm3pV6V2RyLt4O3POCfo6HLP5_fRWdt5pviHWz-1nG8k8aLerluwpI64GIci6n3Go1e48TE3Jm7Mo7tw1GYcc3Y3VgEPSqBLVSu6k58beBrQLpaQBgl9KlhLX7g0SM0LQaV31XJnsiBx6IEHvm5u5YmWOcoySNaysPDyB2J72es "Project Plan Gantt Chart")

## Kanban

![Kanban](./Documentation%20Pictures/kanban.png "Kanban")

## References and Acknowledgements

Maguire, M. C., Kirakowski, J. & Vereker, N., 1998. RESPECT - User-Centered Requirements Handbook - Version 3.3. Version 3.3 ed. Loughborough: RESPECT Consortium 1998.

Geraldi, J. & Lechler, T., 2012. Gantt Chart and the Scientific Management in Projects. International Journal of Managing Project in Business, 5(4), pp. 578-594