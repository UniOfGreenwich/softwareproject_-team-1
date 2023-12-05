# Phase 1 - Requirements Engineering

# Team 1- Library System

<div align=center>

![The Library is a cool place to go and hang out!](https://th.bing.com/th/id/OIP.GBmXICXxseHDVOZBynhjPwHaEc?pid=ImgDet&rs=1 "The Library is a cool place to go and hang out!")

</div>


## Contents

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
  - [User Requirements](#user-requirements)
    - [Functional Requirements](#functional-requirements)
    - [Non-Functional Requirements](#non-functional-requirements)
  - [Technical Requirements](#technical-requirements)
    - [Functional:](#functional)
    - [Non-Functional:](#non-functional)
  - [Potential Risks](#potential-risks)
  - [Project Planning](#project-planning)
    - [Gantt Chart of the Project Plan](#gantt-chart-of-the-project-plan)
      - [Unidimensional](#unidimensional)
      - [Objective](#objective)
      - [Deterministic](#deterministic)
      - [Analytical and Accountable](#analytical-and-accountable)
      - [Sequential](#sequential)
    - [Kanban](#kanban)
  - [References and Acknowledgements](#references-and-acknowledgements)

## Introduction

The library system, commissioned to us as a project by our customer ***Blair&Co***, was the result of a need for a new and modernised system to monitor and control their extensive collection of computer hardware, programming and engineering documents dating back to early 1980s MS-DOS documentation all the way through to generative AI journals printed this year by organisations such as OpenAI.

The team was given a specification by our customer which involved basic functions such as an inventory system through to advanced functions such as payment methods and authentication for security purposes.

The team decided a ***Incremental Design*** process was to be used as we could easily adapt to changing customer needs whilst also making deadlines key.

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

Specified requirements of the customer/end user, that the system should offer. (Chitra, 2023)

**Non-Functional Requirements**

The requirements that a system must adhere to in the project contract. A few examples are: Maintainability, Portability, Reliability, Security, etc. (Chitra, 2023)


## Software Process Model

The software process model is an abstraction of a software development process. It explains a procedure from a particular perspective. Some of the most popular Software process models are:

- **Waterfall model:** It is a sequential, plan-driven process. It requires one to plan and schedule all activities before beginning the project.

- **Incremental model:**  The incremental model could be plan-driven or agile. In this model specification, development, and validation activities are interleaved rather than separate, with rapid feedback across activities.

- **Integration and Configuration:** This model assembles the system from pre-existing, configurable components.

We have chosen the Incremental model for our Library system project. 

### Explanation of Incremental model

The incremental model is now the most common approach for software development. It can be plan-driven or agile or a mixture of these approaches. The system increments are predetermined in a plan-driven method; if an agile approach is used, the early increments are predetermined, but the creation of subsequent increments depends on progress and client priorities. 

This model is better than a waterfall model when system requirements are expected to change during the process. The way we solve issues is reflected in incremental development. We rarely figure out the entire solution to an issue up front; instead, we approach a solution incrementally and then go back when we see that we made a mistake. It is less expensive and simpler to make modifications to the software while it is being built when it is developed incrementally (Collegenote.net, 2023).

<div align=center>

**Figure 1: Incremental Design Model (Collegenote.net, 2023)**

![Incremental Model](/Documentation%20Pictures/IncrementalModel.png "Incremental Model")

</div>

### Incremental model stages:

**Requirement analysis:** In this stage, the project's requirements, such as its objectives, restrictions, and scope, are gathered and examined. Determining the resources required to finish the project and developing the overall project plan are also included in this step. This phase perform a crucial role in incremental model (Budhiraja, 2023).

**Design:** During this stage, the project team creates an overall software architecture together with high level and detailed design. It's includes system design, technology selection, and the creation of any prototypes or proofs of concept that may be required.

**Impementation:** In this phase, the project is actually implemented by writing the code in accordance with the requirements of the final product. To update and improve the quality of the product, the coding standards must be properly followed, without using needless hard codes or defaults (Pedamkar, 2023).

**Testing:** In this stage, tester check the performance of each and every existing function and aditional functionality as per the customer requirement or not. It is important to test the result after each code implementation to make sure it works correctly with other code already produced for the same project. The system is then deployed to the production environment.

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

Also, our team is small and inexperienced. For an inexperienced team, it is better to go with the incremental model.

The goals of the project are clearly stated and recognized, though some elements can change at each increment overtime.

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


## Project Planning

### Gantt Chart

Written in the popular app Mermaid for chart creation, this Gantt chart shows the planning for phase 1 of this project and will be fleshed out to show phases 2 and 3 when they have been finalised.

The Gantt chart, Kanban/Table, Introduction, and Glossary are to be drafted by the 23rd of November 2023. This is to allow for clarity in what is completed/to be completed so far within the project and to give a base to other sections of the project, thus boosting the team's confidence via means of a visible road map.

A Gantt chart is well known to be an intuitive, simple, practical and a useful visial representation of activities and their accociated durations. They are a very widely used tool within industry and are built to focus on 5 main areas.

#### Unidimensional
* One view being 'time', emphasizing efficiency.

#### Objective
* Object oriented.

#### Deterministic
* A Gantt chart determins all that will occur in the project.

#### Analytical and Accountable
* Division of the project allowing for smaller bite-sized chunks so resources can be allocated efficiently.

#### Sequential
* After tasks have been completed, then the next task is to be completed, thus sequenciality.

<br>

A Gantt chart is well known to be an intuitive, simple, practical and useful visual representation of activities and their associated durations. They are a very widely used tool within the industry and are built to focus on 5 main areas. (Geraldi & Lechler, 2012)

---

<div align=center>

**[Figure 2: Project Plan Gantt Chart](https://mermaid.ink/img/pako:eNq9VFtr2zAU_ivCz3Ib2WkHfl1oGCMQko4x8ItinThabdk7khZC6X_f8S23Jd1KocYPls93O9JBz0FWKQiSIJfGudQwepx2BbBHkCUTbI7VT8gcmzZ19nkjsUcp6eChwlI6xiaTcDYLf9CTmq5qiaMrw5bV2m0lQqOTgbVsRnZFh5lom3lrG1iSoXbc1qXiURwKEUajKOZMqA75naoQ-ppJo9gC1oBgSC0hwtYjl2sHyFr2fc9YwG8NW5bsSw1ukDuN-M0SYgG_vEYowTh7JZ3Hk3D_yubxEK2hnifzeKheD7fcWQfl_8Sz-Ma9O8pnL-TDBrCvX0-40PbJduL0xepCGqNN_ro5Yt0oHuX9pP7qq-N0adoWiaWGyL3Cvs0blghxS2-rdj6GX4zDSvl20VXm7RrYBEmPuPeHnRuiPGgjC23hNHw_UrXIBLnHF_fkUa4KuP0qzUp-hN20qKyVuHunFbvsdTP8z8TF89-f6jA_g9xUug0gzQINE-b8OIgYjm3pV6V2RyLt4O3POCfo6HLP5_fRWdt5pvi7Wz-1nG8k8aLerluwpI64GIci6n3Go1e48TE3Jm7Mo7tw1GYcc3Y3VgEPSqBLVSu6k58beBrQLpaQBgl9KolPaZCaF8JJ76rlzmRB4tADD3zdXMkTLXOUZffz5Q_1Tdhd?type=png)**

![Project Plan Gantt Chart](https://mermaid.ink/img/pako:eNq9VFtr2zAU_itCz3Yb2Wk7_LrQMEYgJB1j4BfFOnG12bJ3JC2E0v--41sap0l3gxk_WD7f7UgHPfGsUsATnkvjXGoYPU67AtgDyJIJtsTqK2SOzZs6e_8osUcp6eC-wlI6xmazcLEIv9CTmq5qiaMrw9bV1u0kQqOTgbVsQXZFh5lpm3lrG1iSoXaBrUsVRHEoRBhNojhgQnXIz1SF0NdMGsVWsAUEQ2oJEXYeA7l1gKxl3_aMFfzQsGPJodTgBrlxxE-WECv47jVCCcbZC-k8jsL9KpvHl2gN9TSZx5fq5XDrvXVQ_k48i3-4d0f57Jl82AAO9csJV9p-s504fbG6kMZok79tjlg3ikd579SrvjpOl6ZtkVhqiNwrHNq8YokQ1_S2aqdj-ME4rJRvF11l2a6BzZD0iHt7tHPves17bWShLYzT9zNVi0wQNj67KQ9yU8D1R2k28r_4zYvKWon7f_Vi582uhv-ZODsCh4MdRmiQm0v3CEjjQPOEeTBKMpzc2m9K7Y5E2tk7HHNO0Mn5pk-vpJO-80yNHO_-pvWx5fJREi_q7boFS-ooENNQRL3PdPIGNz7mxsSNg-gmnLQZpwG7mSoe8BLoXtWKruWnBp5y2sUSUp7Qp4Kt9IVLeWqeCSq9q9Z7k_HEoYeA-7q5mGda5ihLnmxlYeH5Jy792oE?type=png "Project Plan Gantt Chart")

---
### Kanban

**[Figure 3: Kanban Board](https://github.com/orgs/TeachingMaterial/projects/9/views/2)**

![Kanban](/Documentation%20Pictures/kanban.png "Kanban")

</div>


## References and Acknowledgements

Amazon. (2023, 12 04). Deployment Methods. Retrieved from docs.aws.amazon.com: https://docs.aws.amazon.com/whitepapers/latest/practicing-continuous-integration-continuous-delivery/deployment-methods.html

Budhiraja, G. (2023, 12 04). Incremental Model. Retrieved from codingninjas: https://www.codingninjas.com/studio/library/incremental-model

Chitra, S. (2023, 12 04). Functional vs Non-Functional Requirements. Retrieved from Geeks for Geeks: https://www.geeksforgeeks.org/functional-vs-non-functional-requirements/

Collegenote.net. (2023, 12 03). Incremental Development. Retrieved from collegenote.net: https://www.collegenote.net/curriculum/software-engineering-csit/52/298/

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

