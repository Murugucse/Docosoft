# DevOps Take-Home Assignment – CI/CD with Azure Pipelines

## Overview

This project demonstrates a CI/CD setup for a .NET 8 Web API (`CounterApi`) using Azure DevOps Pipelines. It includes separate CI and CD pipelines with a self-hosted agent, following DevOps best practices.

---

## Tech Stack

- **.NET 8 Web API**
- **Azure Pipelines (CI/CD)**
- **Azure App Service (Deployment)**
- **Self-hosted Azure DevOps agent**

---

## Repository Structure

```
.
-src/                    # Source code for the API
  CounterApi.csproj
-tests/                  # Unit tests
    CounterAPI.Tests/
-azure-build.yml         # CI Pipeline
-azure-release.yml       # CD Pipeline
-TASK README.md
```

---

## CI/CD Pipeline Details

### azure-build.yml (CI Pipeline)

- **Triggers**: Automatically on `main` branch commit
- **Steps**:
  - Install .NET 8 SDK
  - Restore packages
  - Build project
  - Run unit tests
  - Publish output to artifacts

### azure-release.yml (CD Pipeline)

- **Triggers**: Runs when a new artifact is published by CI
- **Steps**:
  - Download artifact
  - Deploy ZIP to Azure App Service via `AzureWebApp@1`

---

## Setup Instructions

1. **Clone the Repo**

```bash
git clone https://github.com/Murugucse/Docosoft.git
cd Docosoft
```

2. **Configure Azure DevOps**
   - Create project in Azure DevOps
   - Add a service connection to Azure
   - Register a self-hosted agent named `doco`

3. **Setup Pipelines**
   - Create pipeline using `azure-build.yml` for CI
   - Create pipeline using `azure-release.yml` for CD

---

## Design Decisions

- **Separation of Concerns**: CI and CD pipelines are kept separate for clarity and maintainability.
- **Self-hosted Agent**: Used to simulate production-like environment.
- **Environment Binding**: Program.cs dynamically binds to port using `PORT` env variable for Azure compatibility.
- **Swagger Integration**: Ensures API is testable post-deployment.

---

## Best Practices Implemented

- CI pipeline includes `restore`, `build`, `test`, and `publish`
- CD pipeline deploys from published artifact
- Pipelines defined as YAML files
- Triggered by commits to `main`
- Agent pool defined and reusable
- Swagger enabled for easy verification

---

## API Info

- Base URL: `https://murugu-docowebapp.azurewebsites.net/`
- Swagger: `https://murugu-docowebapp.azurewebsites.net/swagger/index.html`

---

## Notes

- All tasks tested on a self-hosted VM named `doco`
- Pipelines completed successfully and validated
- Full Git commit history included in GitHub repo

---

## Submission

-  GitHub Repository: [https://github.com/Murugucse/Docosoft](https://github.com/Murugucse/Docosoft)
- Valid CI/CD YAML files
- Application deployed and accessible
- This README explains design, setup, and decisions
- Video Demo Link:[https://youtu.be/b-gBnA6hn5s](https://youtu.be/b-gBnA6hn5s)


---

## Author

**Murugappan Krishnan**  
📧 murugumsai@gmail.com  
📍 Dublin, Ireland  
🗓️ May 23, 2025
