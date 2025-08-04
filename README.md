# Address Book Application

A modern full-stack address book application built with .NET Web API and Angular.

## 🏗️ Architecture

- **Backend**: .NET 9 Web API with Entity Framework Core
- **Frontend**: Angular 20 (Zoneless) with Standalone Components
- **Database**: SQLite
- **State Management**: Angular Signals
- **Styling**: Angular Material + SCSS

## 📁 Project Structure

```
Address Book/
├── Client/                    # Angular 20 Frontend
│   ├── src/
│   ├── package.json
│   └── angular.json
├── Server/                    # .NET 9 Backend
│   └── Address Book/          # Single Web API Project
│       ├── Controllers/
│       ├── Data/
│       ├── DTOs/
│       ├── Models/
│       ├── Services/
│       ├── Migrations/
│       └── Program.cs
└── README.md                  # This file
```

## 🚀 Quick Start

### Prerequisites
- Node.js 18+
- .NET 9 SDK
- No database installation required (SQLite is file-based)

### 1. Backend Setup
```bash
cd "Server/Address Book"
dotnet restore
dotnet ef database update
dotnet run
```

### 2. Frontend Setup
```bash
cd Client
npm install
ng serve
```

### 3. Access Application
- Frontend: http://localhost:4200
- Backend API: https://localhost:7062
- Swagger UI: https://localhost:7062/ (root URL)

## 🛠️ Development

- **Backend runs on**: https://localhost:7062
- **Frontend runs on**: http://localhost:4200
- **API Documentation**: Available via Swagger UI at root URL
- **Database**: SQLite file (addressbook.db) created automatically

### CORS Issues

If you see CORS errors:
1. Ensure backend is running on https://localhost:7062
2. Ensure frontend is running on http://localhost:4200
3. Check browser console for specific error messages

### Port Conflicts

If ports are in use:
- Backend: Change in `Properties/launchSettings.json`
- Frontend: Run `ng serve --port 4201`

## 📋 Features

- ✅ Read operation for contacts
- ✅ Search functionality across name, email, phone, and city
- ✅ Email uniqueness validation
- ✅ Data seeding with sample contacts
- ✅ RESTful API with proper HTTP status codes
- ✅ Input validation with data annotations
- ✅ Error handling and logging
- ✅ Swagger API documentation

## 🏛️ Architecture Patterns

- **Backend**: Service Layer Pattern
- **Frontend**: Signal-based State Management, Standalone Components
- **Database**: Entity Framework Core with SQLite
- **API**: RESTful Web API with OpenAPI documentation

## 📝 API Endpoints

- `GET /api/contacts` - Get all contacts
- `GET /api/contacts/{id}` - Get contact by ID
<!-- - `GET /api/contacts/search?q={query}` - Search contacts
- `POST /api/contacts` - Create new contact
- `PUT /api/contacts/{id}` - Update contact
- `DELETE /api/contacts/{id}` - Delete contact -->

## 🗄️ Database

- **Type**: SQLite (file-based)
- **Location**: `Server/Address Book/addressbook.db`
- **Migrations**: Automatic on first run
- **Seed Data**: Sample contacts included

### Sample Contacts
- John Doe (john.doe@example.com, Cape Town, Western Cape)
- Deltas Lephalala (deltaslep@gmail.com, Johannesburg, Gauteng)
- Bokang Modise (b.modise@gmail.com, Mahikeng, North-West)

## 🛠️ Tech Stack

### Backend
- .NET 9 Web API
- Entity Framework Core 9
- SQLite Database
- Swagger/OpenAPI
- Serilog (implied for logging)

### Frontend
- Angular 20.1.4
- Angular Material
- TypeScript
- RxJS
- Angular Signals

## 🔧 Configuration

### Backend Configuration
- Database: SQLite (no connection string needed)
- CORS: Enabled for Angular app (localhost:4200)
- Swagger: Enabled in development
- Logging: Built-in .NET logging

### Database Commands
```bash
# Create new migration
dotnet ef migrations add MigrationName

# Update database
dotnet ef database update

# Remove last migration
dotnet ef migrations remove
```

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes (don't commit .db files)
4. Push to the branch
5. Create a Pull Request

## 📄 License

This project is licensed under the MIT License.
