# Address Book Application

A modern full-stack address book application built with .NET 9 Web API and Angular 20.1.4

## 🏗️ Architecture

- **Backend**: .NET 9 Web API with Entity Framework Core
- **Frontend**: Angular 20 (Zoneless) with Standalone Components
- **Database**: SQL Server
- **State Management**: Angular Signals
- **Styling**: Angular Material + SCSS

## 📁 Project Structure

```
Address Book/
├── Client/                 # Angular 20 Frontend
│   ├── src/
│   ├── package.json
│   └── README.md
├── Server/                 # .NET 8 Backend
│   ├── AddressBook.Api/
│   ├── AddressBook.Core/
│   ├── AddressBook.Infrastructure/
│   └── README.md
└── README.md              # This file
```

## 🚀 Quick Start

### Prerequisites
- Node.js 18+
- .NET 9 SDK
- SQL Server (LocalDB or Express)

### 1. Backend Setup
```bash
cd Server
dotnet restore
dotnet ef database update --project AddressBook.Infrastructure --startup-project AddressBook.Api
dotnet run --project AddressBook.Api
```

### 2. Frontend Setup
```bash
cd Client
npm install
npm start
```

### 3. Access Application
- Frontend: http://localhost:4200
- Backend API: http://localhost:5000
- Swagger UI: http://localhost:5000/swagger

## 🛠️ Development

- **Backend runs on**: http://localhost:5000
- **Frontend runs on**: http://localhost:4200
- **API Documentation**: Available via Swagger UI

## 📋 Features

- ✅ CRUD operations for contacts
- ✅ Real-time search and [filtering]
- ✅ Responsive design with Angular Material
- ✅ Form validation
- ✅ Error handling
- ✅ Loading states
- ✅ Signal-based state management

## 🏛️ Architecture Patterns

- Clean Architecture (Backend)
- Repository Pattern
- Signal-based State Management (Frontend)
- Standalone Components (Angular)
- Zoneless Change Detection

## 📝 API Endpoints

- `GET /api/contacts` - Get all contacts
- `GET /api/contacts/{id}` - Get contact by ID
- `POST /api/contacts` - Create new contact
- `PUT /api/contacts/{id}` - Update contact
- `DELETE /api/contacts/{id}` - Delete contact

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## 📄 License

This project is licensed under the MIT License.
