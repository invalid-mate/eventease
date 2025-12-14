# EventEase - Blazor Event Management Application

## Project Overview
EventEase is a comprehensive Blazor WebAssembly application for managing events, registrations, and attendance tracking. This project was developed as part of the Blazor for Front-End Development course.

## Features Implemented

### 1. Event Card Component
- **Two-way data binding** for event properties (Name, Date, Location, Description)
- **Real-time updates** to UI when event data changes
- **Reusable component** design for displaying event information

### 2. Routing Functionality
- `/` - Home page with event listings
- `/event/{id}` - Event details page with route parameters
- `/register/{eventId}` - Event registration form
- `/attendance` - Attendance tracker dashboard

### 3. Registration Form with Validation
- **Data Annotations** validation attributes ([Required], [EmailAddress], [Range])
- **Real-time validation** feedback with error messages
- **Form state management** using EditContext
- Custom validation for age restrictions (18-99)

### 4. State Management
- **Dependency Injection** for EventService
- **Cascading parameters** for user session data
- **Application-wide state** for theme management (light/dark mode)

### 5. Attendance Tracker
- **Real-time attendance** monitoring
- **Event capacity** tracking
- **Registered attendees** list with filtering

### 6. Performance Optimizations
- **Lazy loading** for non-critical components
- **ShouldRender** optimization to prevent unnecessary re-renders
- **Scoped CSS** for component-specific styling
- **Minified assets** for faster load times

## Technologies Used
- **Blazor WebAssembly** (.NET 8.0)
- **C#** for component logic
- **Razor syntax** for templating
- **CSS** for styling (Global + Scoped)
- **Data Annotations** for validation

## Getting Started

### Prerequisites
- .NET 8.0 SDK or later
- Visual Studio Code or Visual Studio 2022

### Installation

1. Clone the repository:
```bash
git clone https://github.com/[your-username]/EventEase.git
cd EventEase
```

2. Restore dependencies:
```bash
dotnet restore
```

3. Run the application:
```bash
dotnet run
```

4. For live reload during development:
```bash
dotnet watch run
```

The app will be available at `https://localhost:5001` or `http://localhost:5000`

## Project Structure

```
EventEase/
├── Components/
│   ├── EventCard.razor          # Event display component
│   ├── RegistrationForm.razor   # Event registration form
│   └── AttendanceTracker.razor  # Attendance monitoring
├── Pages/
│   ├── Index.razor             # Home page
│   ├── EventDetails.razor      # Event details with routing
│   └── Attendance.razor        # Attendance dashboard
├── Services/
│   ├── EventService.cs         # Event data service
│   └── StateService.cs         # Application state management
├── Models/
│   ├── Event.cs               # Event model
│   └── Registration.cs        # Registration model
├── wwwroot/
│   └── css/
│       └── app.css            # Global styles
└── Program.cs                 # App configuration
```


## License
This project is created for educational purposes as part of a Coursera course.

## Contact
Project Link: https://github.com/invalid-mate/EventEase
