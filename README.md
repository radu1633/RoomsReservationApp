# Hotel Room Reservation System

## Introduction

The **Hotel Room Reservation System** is an application designed to streamline the management of hotel room reservations. It provides an intuitive interface for managing clients, reservations, and their associated details, automating the administrative tasks of hotel operations.

### Technologies Used
- **Programming Language**: C#
- **Development Environment**: Visual Studio
- **Database**: Microsoft Access (connected via OleDB)
- **Design Patterns** (mandatory as part of the project):
  - **Repository**: For data access management.
  - **Singleton**: For ensuring a single database connection instance.
  - **Decorator**: For extending class functionalities, particularly for data validation.
- **User Interface Controls**: `DateTimePicker`, `ComboBox`, `NumericUpDown`, `PictureBox`, `MenuStrip`, `OpenFileDialog`.

---

## Application Structure

### Entities and Relationships
The system operates with the following entities:
1. **Clients**: `IdClient`, `Nume`, `Prenume`, `NrTelefon`
2. **Rooms**: `IdCamera`, `NrCamera`, `NrLocuri`, `Etaj`, `PretZi`, `SpImagine`
3. **Reservations**: `IdRezervare`, `DataRezervarii`, `IdClient`, `IdUtilizator`
4. **Reservation Content**: `IdRezervare`, `Nrc`, `IdCamera`, `DataCazarii`, `PretZi`, `NrZile`
5. **Users**: `IdUtilizator`, `Nume`, `Parola`

### Relationships
- Each reservation is linked to a client and managed by a user.
- Reservations can include one or more rooms.
- A reservation without associated rooms is automatically deleted to ensure data integrity.

---

## Interfaces and Forms

### 1. **Login and Main Interface**
- **Login Form**: Allows users to authenticate and access the main application.
- **Main Form**:
  - Access menus for managing clients, rooms, and reservations.
  - Displays the logged-in user's name and provides a logout option.

### 2. **Client Management**
- Add, modify, delete, and search clients.
- Validation of required fields like `Nume`, `Prenume`, and `NrTelefon`.

### 3. **Room Management**
- Add, modify, delete, and search rooms.
- Fields include `NrCamera`, `NrLocuri`, `Etaj`, `PretZi`.
- Image upload and preview for each room.

### 4. **Reservation Management**
- Create, modify, and delete reservations and their associated details.
- Automatically calculates the total cost based on the selected rooms and duration.

---

## Features and Validations

### Functional Features
- **Data Selection**: `DateTimePicker` for date selection, `ComboBox` for dropdown options, and `NumericUpDown` for numeric input.
- **Image Display**: `PictureBox` for room previews.
- **Data Views**: `DataGridView` for quick record access and management.

### Validations
- **Mandatory Fields**: Ensures essential fields are completed before saving.
- **Format Validation**: Checks for numeric values and valid phone number formats.
- **Data Integrity**:
  - Prevents duplicate clients and rooms.
  - Restricts deletion of clients with active reservations.
- **Confirmation Messages**: Warns users before irreversible actions like deletions.

---

## Implementation

### Design Patterns (Mandatory Requirement)
The application was developed with a focus on integrating three key design patterns, as per the project requirements:
1. **Singleton**: Manages a single instance of the database connection to ensure efficient resource usage.
2. **Repository**: Isolates data access logic from business logic, making CRUD operations modular and maintainable.
3. **Decorator**: Enhances class functionalities without altering their structure, specifically used for user input validation.



---

## Author
Developed by **Marin Radu-George** as final project from the Advanced Programming Techniques subject that I studied this year at college.

---
