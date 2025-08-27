# UserManagementAPI Project Documentation

## Part 1: Initial Controller Setup 🚀

During the first phase of the project, I set up the ASP.NET Core Web API project named **UserManagementAPI**.  

I used **Microsoft Copilot** to scaffold the project, which helped with:  
- Creating `Program.cs` with the basic Web API setup.  
- Generating boilerplate code for controllers and routing.  

Using Copilot, I then generated CRUD endpoints for managing users:

| Endpoint | Description |
|----------|-------------|
| `GET /api/users` | Retrieve a list of users |
| `GET /api/users/{id}` | Retrieve a specific user by ID |
| `POST /api/users` | Add a new user |
| `PUT /api/users/{id}` | Update an existing user |
| `DELETE /api/users/{id}` | Remove a user by ID |

**Testing**: I tested all endpoints using Postman to ensure they worked correctly.  

**How Copilot Helped 🤖**:  
- Suggested the structure for the `UsersController`.  
- Generated initial CRUD methods with correct routing and return types.  
- Saved time on boilerplate code, allowing focus on business logic.  

## Part 2: Debugging Documentation 🐛🛠️

After deploying the initial version, several bugs were identified. The debugging process involved fixing validation, error handling, and performance issues.

**Bugs Found 🐞:**  
- Missing validation in POST and PUT endpoints   
- Crash when calculating `Max` with an empty list  
- Missing try-catch blocks in endpoints   

**Fixes Applied ✅:**  
- Added `[Required]` and `[EmailAddress]` annotations  
- Implemented error handling with try-catch blocks  *(removed later when middleware was implemented)
- Safe logic for calculating new `Id`   

**How Copilot Helped 🤖:**
- Suggested validations using DataAnnotations  
- Automatically inserted try-catch blocks   
- Improved `Max()` logic by checking for empty list   

---

This documentation summarizes both the **initial setup** and the **debugging process**, highlighting the role of Microsoft Copilot in accelerating development and ensuring robust, reliable API functionality.
