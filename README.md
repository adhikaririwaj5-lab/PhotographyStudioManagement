# PhotographyStudioManagement



Photography Studio Booking \& Client Management System



Project Description



The Photography Studio Booking \& Client Management System is a C# Windows Forms application developed for ITS203 Object-Oriented Design and Programming.



The application is designed to help photographers and small photography studios manage clients, photography and videography services, bookings, payment information, and booking statuses in one place.



The system uses SQLite for local data storage and demonstrates object-oriented programming principles including classes and objects, encapsulation, inheritance, abstraction, polymorphism, and exception handling.



Main Features



\- Add new clients

\- View and search clients

\- Edit client information

\- Delete clients

\- Create photography and videography bookings

\- Automatically calculate booking prices

\- View all bookings

\- Search bookings by client, service, location, or booking ID

\- Filter bookings by booking status

\- Edit existing bookings

\- Delete bookings

\- Track booking status:

&#x20; - Pending

&#x20; - Confirmed

&#x20; - Completed

&#x20; - Cancelled

\- Track payment status:

&#x20; - Unpaid

&#x20; - Partially Paid

&#x20; - Paid

\- Store application data using SQLite

\- Input validation and exception handling



Object-Oriented Programming



Classes and Objects



The application uses classes such as:



\- Client

\- Booking

\- Service

\- PhotographyService

\- VideographyService



Objects are created from these classes to represent clients, bookings, and studio services.



Encapsulation



The Service class uses controlled properties and validation. For example, the base price cannot be set to a negative value.



Abstraction



`Service` is an abstract base class. It contains common information and behaviour for studio services.



Inheritance



`PhotographyService` and `VideographyService` inherit from the `Service` class.



Polymorphism



Both photography and videography services override the `CalculatePrice()` method.



Photography services calculate the price based on the hourly rate, while videography services can also include an editing fee.



The program can call the same `CalculatePrice()` method through a `Service` reference while receiving different behaviour depending on the actual service object.



Exception Handling



Database operations are protected using `try-catch` blocks so that errors can be handled gracefully instead of causing the application to crash.



Technologies Used



\- C#

\- .NET Windows Forms

\- Microsoft Visual Studio

\- SQLite

\- Microsoft.Data.Sqlite

\- Git

\- GitHub



Database



The application uses a local SQLite database called:



`photography.db`



The main database tables are:



Clients

Stores:

\- Client ID

\- Name

\- Phone

\- Email



Services

Stores:

\- Service ID

\- Service name

\- Service type

\- Base price

\- Editing fee



Bookings

Stores:

\- Booking ID

\- Client ID

\- Service ID

\- Booking date

\- Location

\- Hours

\- Price

\- Booking status

\- Payment status

\- Amount paid

\- Notes



How to Run the Application



1\. Clone or download this repository.

2\. Open the project in Microsoft Visual Studio.

3\. Open the `PhotographyStudioManagement` solution/project.

4\. Make sure the `Microsoft.Data.Sqlite` NuGet package is installed.

5\. Build the solution.

6\. Run the application using the Start button in Visual Studio.

7\. The SQLite database and required tables will be created automatically when the application starts.



Basic Usage



1\. Add a client using the \*\*Add Client\*\* screen.

2\. View, search, edit, or delete clients using \*\*View Clients\*\*.

3\. Create a booking using \*\*Add Booking\*\*.

4\. Select the client and photography/videography service.

5\. Enter the booking date, location, hours, payment information, and status.

6\. Calculate the booking price.

7\. Save the booking.

8\. Use \*\*View Bookings\*\* to search, filter, edit, or delete bookings.



Project Development



The project was developed progressively using Git and GitHub.



Meaningful commits were made throughout development to record features, database changes, object-oriented design improvements, validation, and application functionality.



References and Tools Used



The following tools and resources were used during development:



\- Microsoft Visual Studio

\- Microsoft .NET / Windows Forms

\- Microsoft.Data.Sqlite

\- SQLite

\- GitHub and Git version control

\- Microsoft documentation for C#, Windows Forms, and SQLite integration

\- ChatGPT was used as a learning and debugging support tool during development. All submitted code was reviewed, tested.



Assessment



This project was developed for:



\*\*ITS203 – Object-Oriented Design and Programming\*\*



Assessment C – Milestone 1, Milestone 2 and Milestone 3.

