Project proposal report  
Eric, Heitor, Roger, Kate
===
## Project Description
### Requirements/Deliverables:
* Students will be able to sign into the system to reserve dorm rooms for themselves for a given time
    * They will need to see what rooms are available
* Search rooms by date
    * Students will see available/not available
    * Admins can view specific students
* Search for students
    * Id
    * Room/date

## Process Model
* Student
    * View available rooms for date
    * Reserve room for date
    * View room reservations
    * Edit current/future room reservations
* Admin
    * See rooms student has reserved
    * See students in room

## Database Model
* Accounts (**AccountID**, Username, Password, _StudentID_)
* Students (**StudentID**, Name)
* DormRooms (**RoomID**)
* Reservations (**ResID**, _StudentID_, _RoomID_, StartDate, EndDate)

## ER Diagram
[Image]

## User Interface
Number of screens and what they do
|**Login Screen**||
|---|---|
|[Image]|Allows students or admins to log in|

## Project Plan
General tasks, project team roles, who's doing what