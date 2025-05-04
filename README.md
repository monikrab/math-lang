²# **λy** | Loy

A language designed to express computations with incredibly easy prototyping, while keeping high performance and optional expressiveness.


## What can it do?

#### The language plans to offer:

- De-bloated, math-like syntax which is fast to write and easy to read — expressive only when necessary.

- A flexible, precise type system for all mathematics:

-Numbers: real, rat, int, nat...
-Linear algebra: vec, mtx<real>, tens...
-...much more: functions, geometry, graphs



## Example

```cs
\\ A simple Fibonacci sequence calculator

fib(n: ℕ) => fib_n: ℕ:
{
    if n == 1:
        fib_n = 1

    for i = 2, a = 0, b = 1;
        while i ≤ n step i++:

        fib_n = a + b
        a = b
        b = fib_n
}
```

## Status

Extremely experimental — everything in the language is in very early prototyping and constantly changing.

## Goals

- Fully specified and standardized syntax and types

- Compiles to readable GPU code: for fast execution and maintainability

- Online playground to test code

- Optional formal verification