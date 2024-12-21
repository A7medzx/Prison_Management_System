# Prison Management System

A digitalized solution to manage prisoners, visitors, and staff records in a prison. This system allows admins and normal users to access, modify, and export records. Admins have special privileges, while normal users have access only to their own records.

## Features

### 1. **Login System**
   - Users can log in with **email** and **password**.
   - Two types of users: **Admin** and **Normal User**.
   - Admin users have full access to all records, while normal users can only access their own records.

### 2. **User Registration**
   - New users can register by providing:
     - First Name
     - Last Name
     - Email
     - Password (with specific criteria)
   - After registration, users are redirected to the login screen.

### 3. **Admin Dashboard**
   - Access and manage **all user records**.
   - Admins can **add**, **edit**, **delete**, **search**, and **export** prisoner, visitor, and staff records.
   - **Data export** to Excel is available for all records.

### 4. **Normal User Dashboard**
   - Normal users can manage **their own prisoner**, **visitor**, and **staff records**.
   - Export their own records to **Excel**.

### 5. **Record Types**
   - **Prisoners**: `Prisoner ID | Name | National ID | Crime | Sentence Duration | Cell Number`
   - **Visitors**: `Visit ID | Name | National ID | Prisoner ID | Relation | Visit Date`
   - **Staff**: `Staff ID | Name | National ID | Job | Shift`

### 6. **Data Export**
   - Both **Admin** and **Normal User** can export data to Excel, either as a full export or filtered records.

## Technologies Used

- **C#**
- **Windows Forms** (UI Framework)
- **.NET Framework** (Version: [Insert Version Here])
- **Excel Exporting**: [Insert Library Name or Tool Used Here]

## Installation

Follow these steps to set up and run the Prison Management System:

1. Clone the repository:
   ```bash
   git clone [Insert Repository URL Here]
   ```

2. Open the project in **Visual Studio**.

3. Build the solution by clicking **Build > Build Solution**.

4. Run the project by pressing **F5** or selecting **Start Debugging**.

5. If necessary, install the required **Excel Export Library**:
   ```bash
   dotnet add package [Library Name]
   ```

## Usage

### Registration & Login

1. **Register**: Fill in the required fields on the registration form:
   - First Name
   - Last Name
   - Email
   - Password (must meet all security criteria)
   
2. **Login**: Use your **email** and **password** to log in. If the credentials are valid, you’ll be logged in as either **Admin** or **Normal User**.

### Admin Features

- **Access to All User Records**: View, edit, delete, and search all user records in a **DataGridView**.
- **Data Export**: Export full or filtered records to Excel.

### Normal User Features

- **Manage Own Records**: Add, edit, delete, and search your own prisoner, visitor, and staff records.
- **Export Own Data**: Export your records to Excel.

### File Structure

- **Users Records.txt**: Contains user data (admin and normal users).
- **UID.txt**: Stores the last ID used for user records.
- **Prisoners Records.txt**: Contains prisoner data.
- **PID.txt**: Stores the last ID used for prisoner records.
- **Visitors Records.txt**: Contains visitor data.
- **VID.txt**: Stores the last ID used for visitor records.
- **Staff Records.txt**: Contains staff data.
- **SID.txt**: Stores the last ID used for staff records.

> **Note**: Data is stored in plain text files for simplicity. Passwords and sensitive data should ideally be hashed or encrypted in future versions.

## Future Improvements

- Implement **password hashing** and **file encryption** for better security.
- Transition to a **relational database** (e.g., SQL Server or SQLite).
- Add **multi-user support** with different privilege levels (e.g., Supervisors).
- Introduce **email notifications** for important updates or actions.

### Notes:
- Make sure to replace placeholders like `[Insert Version Here]`, `[Insert Repository URL Here]`, and `[Library Name]` with actual data.
- If your repository has a license file, mention it in the **License** section. If not, you can add a license like the MIT License or any other appropriate license.
- The **Contributing** section is optional, but it's helpful if you expect others to contribute to the project.
