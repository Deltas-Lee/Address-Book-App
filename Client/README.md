# 📒 Address Book Frontend

A modern Angular 20 frontend for the Address Book app.

---

## 🚀 Quick Start

```bash
# Install dependencies
npm install

# Start development server
npm start

# Build for production
npm run build
```

---

## 🛠️ Development

- **Development server:** `npm start` → [http://localhost:4200](http://localhost:4200)
- **Build:** `npm run build`
- **Watch mode:** `npm run watch`
- **Tests:** `npm test`

---

## 🏗️ Architecture

### Zoneless Angular

Leverages Angular's new zoneless change detection for improved performance.

### Key Features

- **Standalone Components** — No NgModules required
- **Signals** — Reactive state management
- **Angular Material** — UI component library
- **Modern Forms** — Reactive forms with validation
- **Signal-based Store** — Custom state management

### Project Structure

```
src/
├── app/
│   ├── components/
│   │   ├── contact-card/
│   │   └── contact-details-dialog/
|   |   └── contact-list/
|   |   └── search-filter
│   ├── models/
│   │   └── contact.model.ts
│   ├── services/
│   │   └── contact.service.ts
│   ├── app.component.ts
│   ├── app.routes.ts
│   └── main.ts
├── environments/
└── assets/
```

---

## 🎨 Styling

- **Angular Material** — Primary UI framework
- **SCSS** — CSS preprocessor
- **Responsive Design** — Mobile-first approach

---

## 📱 Components

### `ContactListComponent`

- Displays all contacts in a grid layout
- Search & Filter functionality
- Contact selection and actions

### `ContactDetailsComponent`

- More details about the contact/profile

---

## 🔄 State Management

Uses a custom signal-based store (`ContactStore`) for:

- Contact CRUD operations
- Loading states
- Error handling
- Search and filtering

---

## 🌐 API Integration

Connects to a .NET 8 Web API backend:

- **Base URL:** `http://localhost:5000/api`
- Error handling and retry logic
- HTTP interceptors for common operations

---

## 📋 Environment Configuration

```typescript
// src/environments/environment.ts
export const environment = {
  production: false,
  apiUrl: 'http://localhost:5000'
};
```

---

<!-- ## 🧪 Testing

- **Unit Tests:** Jasmine + Karma
- **Component Testing:** Angular Testing Utilities
- **Service Testing:** HttpClientTestingModule -->

---

## 🔧 Configuration

### Angular Material Setup

```bash
ng add @angular/material
```

### Key Dependencies

- `@angular/core` ^20.1.0
- `@angular/material` ^20.1.4
- `@angular/cdk` ^20.1.4
- `rxjs` ~7.8.0

---

## 📝 Scripts

- `npm start` — Start development server
- `npm run build` — Build for production
- `npm run watch` — Build in watch mode
- `npm test` — Run unit tests
- `npm run lint` — Run linting

> **Note:** Angular CLI does not include an end-to-end testing framework by default. Choose one that fits your needs.

---

## 📚 Additional Resources

For more on Angular CLI, see the [Angular CLI Overview and Command Reference](https://angular.dev/tools/cli).
