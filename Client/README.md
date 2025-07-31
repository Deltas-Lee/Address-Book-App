# Address Book Frontend

Angular 20 frontend application for the Address Book app.

## 🚀 Quick Start

```bash
# Install dependencies
npm install

# Start development server
npm start

# Build for production
npm run build

## 🛠️ Development

- **Development server**: `npm start` → http://localhost:4200
- **Build**: `npm run build`
- **Watch mode**: `npm run watch`
- **Tests**: `npm test`

## 🏗️ Architecture

### Zoneless Angular
This application uses Angular's new zoneless change detection for better performance.

### Key Features
- **Standalone Components** - No NgModules required
- **Signals** - Reactive state management
- **Angular Material** - UI component library
- **Modern Forms** - Reactive forms with validation
- **Signal-based Store** - Custom state management

### Project Structure

```

src/
├── app/
│   ├── components/
│   │   ├── contact-list/
│   │   └── contact-form/
│   ├── models/
│   │   └── contact.model.ts
│   ├── services/
│   │   └── contact.service.ts
│   ├── stores/
│   │   └── contact.store.ts
│   ├── app.component.ts
│   ├── app.routes.ts
│   └── main.ts
├── environments/
└── assets/

```bash

## 🎨 Styling

- **Angular Material** - Primary UI framework
- **SCSS** - CSS preprocessor
- **Responsive Design** - Mobile-first approach

## 📱 Components

### ContactListComponent
- Displays all contacts in a grid layout
- Search functionality
- Contact selection and actions

### ContactFormComponent
- Create/Edit contact forms
- Form validation
- Error handling

## 🔄 State Management

Uses a custom signal-based store (`ContactStore`) for:
- Contact CRUD operations
- Loading states
- Error handling
- Search and filtering

## 🌐 API Integration

Connects to .NET 8 Web API backend:
- Base URL: `http://localhost:5000/api`
- Error handling and retry logic
- HTTP interceptors for common operations

## 📋 Environment Configuration

```typescript
// src/environments/environment.ts
export const environment = {
  production: false,
  apiUrl: 'http://localhost:5000'
};
```

## 🧪 Testing

- **Unit Tests**: Jasmine + Karma
- **Component Testing**: Angular Testing Utilities
- **Service Testing**: HttpClientTestingModule

## 🔧 Configuration

### Angular Material Setup

```bash
ng add @angular/material
```

### Key Dependencies

- `@angular/core`: ^20.1.0
- `@angular/material`: ^20.1.4
- `@angular/cdk`: ^20.1.4
- `rxjs`: ~7.8.0

## 📝 Scripts

- `npm start` - Start development server
- `npm run build` - Build for production
- `npm run watch` - Build in watch mode
- `npm test` - Run unit tests
- `npm run lint` - Run linting

Angular CLI does not come with an end-to-end testing framework by default. You can choose one that suits your needs.

## Additional Resources

For more information on using the Angular CLI, including detailed command references, visit the [Angular CLI Overview and Command Reference](https://angular.dev/tools/cli) page.
