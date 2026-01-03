# Chain of Responsibility Pattern

## Definition
**Chain of Responsibility** is a behavioral design pattern that lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.

## Problem
Imagine a support system where a request needs to go through multiple checks:
1. Is the user authorized?
2. Is the data format correct?
3. Is it a technical or billing issue?

Putting all this logic into a single class makes the code messy and tightly coupled. Adding a new check (e.g., "Check for Spam") requires modifying the main class.

## Solution
We transform each specific behavior (Authorization, Validation, Logging) into stand-alone objects called **Handlers**. We link these handlers into a chain. The request travels along the chain until a handler processes it.

## Real-World Use Case (In this Repository)
We implemented a **Customer Support Tier System**:
- **Level 1 (Bot):** Handles simple requests like "PasswordReset".
- **Level 2 (Agent):** Handles "Billing" issues.
- **Level 3 (Manager):** Handles "CriticalError".

### Other Common Scenarios
- **ASP.NET Core Middleware:** Request -> Auth Middleware -> Logging Middleware -> Controller.
- **Event Bubbling (DOM):** A click event on a button bubbles up to the div, then the body.
- **Logging:** Debug Log -> Info Log -> Error Log (Error log handles everything, Info handles info and above).