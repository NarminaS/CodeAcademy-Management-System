## Code Academy Student Management System
### Used technologies : 
  * ASP.NET MVC Core 2.1
  * Entity Framework Core
  * HTML , CSS, Javascript/Jquery (Views)
  * MailKit - email sending
#### Areas: 
  * Admin - admin panel part (Faculties, Roles, LessonStatuses, Lesson hours, Roles , Rooms CRUD)
  * Editor - editor panel (Students , Teacher , Groups ,Tags CRUD)
  * Edu - Home page for students and teachers and Library CRUD
#### Components - ViewComponent for upperpanel
#### Extensions
  * Controller extension methods for sending email and getting currently logged in user
#### Services:
  * Implementation of MilKit library in EmailSender class
#### Utilities:
  * OldFileRemover - class that performs I/O operations to replace deleted images in wwwroot folder
  * Uploader - class that uplads images and pds files to corresponding folders in wwwroot
  * Initializer - class that seeds the database  
  
