# (experimental math language)

A math-like pseudocode language designed for prototyping and embedding efficient algorithms.


## Why?

The language plans to offer:

- Minimalist, math-like syntax (easy to write, easy to read), expressive where it matters, dynamic when not

- Precise types (nat, real, vec, seq, etc.)

## Example

A simple Fibonacci sequence calculator

```
nat n

fib(n) => (fib_n):

    if n == 1:
        fib_n = 1
        return

    for i = 2, a = 0, b = 1;
        while i ≤ n step i++:

        fib_n = a + b
        a = b
        b = fib_n

return
```

## Status

Extremely experimental — everything in the language is in very early prototyping and constantly changing.

## Goals

- Fully specified and standardized syntax and types

- Compilation to C: drop into projects, compile anywhere for any machine

- Playground to test code

- Optional proving (prove algorithm properties formally)