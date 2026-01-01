# Observer Pattern

## Definition
The **Observer Pattern** is a behavioral design pattern that defines a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing. It establishes a **one-to-many dependency** between objects so that when one object changes state, all its dependents are notified and updated automatically.

## Problem
Imagine you have two types of objects: a `Customer` and a `Store`. The customer wants to buy a specific product (e.g., the new iPhone), but it's out of stock.
- **Scenario A (Polling):** The customer visits the store every day to check availability. This is inefficient and wastes the customer's time.
- **Scenario B (Spamming):** The store sends emails to *all* customers whenever a new product arrives. This upsets customers who aren't interested in that specific product.

In software, this problem manifests when one object needs to observe another, but we want to avoid **tight coupling** or inefficient loops checking for changes.

## Solution
The object that has some interesting state is often called the **Subject** (or Publisher). All other objects that want to track changes to the subject are called **Observers** (or Subscribers).

1. The **Subject** maintains a list of subscribers.
2. It provides methods to `Subscribe` (add) or `Unsubscribe` (remove) listeners.
3. When an event occurs, the Subject loops through its list and calls a specific method (e.g., `Update`) on every subscriber.

### Other Common Scenarios
- **MVC Architecture:** The View updates automatically when the Model changes.
- **Event Listeners:** Clicking a button in a UI triggers multiple functions.
- **Stock Market Tickers:** Updating multiple displays when a stock price changes.