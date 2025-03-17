# Product Roadmap

This roadmap outlines the next steps for developing, testing, and extending the SaaS API.

## Immediate Priorities

### 1. Automated Testing Integration (High Priority)
- **Objective:** Integrate automated testing into the development lifecycle to improve reliability and code quality.
  - **Implement Testing Framework:** Use xUnit and Moq for unit tests.
  - **Structure:** Develop a corresponding test class for each API controller and data model.
  - **CI Integration:** Ensure automated testing runs on every Pull Request.

### Example:
- `UserController` → `UserControllerTests`
- `User` model → `UserModelTests`

---

## Next Feature Expansion

### Add Service Models
- Define entities representing services provided by the SaaS application.
- Include properties such as `ServiceId`, `ServiceName`, `Description`, and pricing structure.

### Example Models:
- `Service`: Represents individual offerings
- `ServiceCategory`: Categorize services
- `Subscription`: Link users to service subscriptions

### CRUD Endpoints:
- Develop CRUD controllers (`ServicesController`, `SubscriptionsController`, etc.).
- Ensure foreign key relationships to Users, MembershipRoles, etc.

### Database Migration:
- Generate EF migrations (`dotnet ef migrations add ServicesAndSubscriptions`)
- Apply migrations automatically on deployment (`dbContext.Database.Migrate()`)

## JWT and Security Enhancements

### JWT Improvements:
- Configure token expiration, refresh tokens
- Set up roles-based authorization with detailed API access control

### External Authentication:
- Implement external identity providers (Microsoft, Google, GitHub, Apple)
- Configuration-based approach for flexibility

## Deployment Improvements
- Optimize Docker configuration for faster builds
- Configure production-ready security best practices (e.g., secure JWT secret storage, environment variables)

## Monitoring and Logging
- Integrate application logging
- Implement monitoring tools (e.g., Application Insights, Serilog)

## Documentation & Developer Experience
- Expand README.md with detailed documentation for onboarding
- Document API endpoints clearly with examples (Swagger annotations)

## Future Considerations
- API rate limiting and monitoring
- Performance benchmarking and optimizations
- Scalability enhancements (load balancing, caching)

---

## General Development Workflow
- Use feature branches for each new functionality
- Provide clear, descriptive commit messages
- Regular code reviews with automated test coverage requirement

This roadmap ensures a robust, maintainable, and secure development cycle, enabling effective collaboration and continuous integration.

