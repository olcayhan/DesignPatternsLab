# Strategy Pattern

## Definition
The **Strategy Pattern** is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.

## Problem
Imagine you are building a shipping calculator. Initially, you only support "Standard Shipping". Later, you need to add "Express" and "Free Shipping". Adding these checks into a single class results in a massive `if-else` or `switch` statement that is hard to maintain and violates the **Open/Closed Principle**.

## Solution
We create a common interface `IShippingStrategy` and implement different shipping algorithms in separate classes (`StandardShippingStrategy`, `ExpressShippingStrategy`, etc.). The client code (`ShippingContext`) works with the interface, allowing us to switch algorithms at runtime without changing the context code.

## Real-World Use Case
- Payment methods (Credit Card, PayPal, Crypto)
- Sorting algorithms (QuickSort, BubbleSort)
- Route calculation (Car, Walking, Public Transport) in maps