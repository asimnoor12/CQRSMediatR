# CQRS + MediatR Web API (.NET 8)

This project demonstrates a clean implementation of **CQRS (Command Query Responsibility Segregation)** using **MediatR** in **ASP.NET Core 8 Web API**.

---

## 📁 Folder Structure

/Controllers → API endpoints
/Commands → Write operations (e.g. Create, Update)
/Queries → Read operations (e.g. Get, List)
/Handlers → Logic for handling Commands & Queries
/Models → Domain entities
/Repositories → Data access layer
/Data → EF Core DbContext, Migrations
Program.cs → App startup
appsettings.json → Configurations
CQRSMediatR.http → For API Testing

---

## 🛠️ Technologies Used

- .NET 8 Web API  
- CQRS Pattern  
- MediatR  
- EF Core (InMemory DB)  
- Swagger (for API testing)

---

## ✅ Features

- Separation of Read/Write using CQRS
- Handlers for each Command and Query
- MediatR for in-process messaging
- Repository layer for data access abstraction
- Scalable and testable architecture

---

## 🧾 Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022+ or VS Code

---

## ▶️ Getting Started

1. ### Clone the repo:
   git clone https://github.com/asimnoor12/CQRSMediatR.git
   cd CQRSMediatR
