# C# Infinite Recursion Bug

This repository demonstrates a common C# bug involving infinite recursion in a property setter. The `bug.cs` file contains the erroneous code, while `bugSolution.cs` provides the corrected version.

## Bug Description

The `IncrementValue` method in `ExampleClass` attempts to increment the `Value` property. However, the setter for `Value` calls `IncrementValue` again, creating an infinite loop that results in a `StackOverflowException`.

## Solution

The corrected code in `bugSolution.cs` directly modifies the private backing field `_value` to avoid the infinite recursion. 