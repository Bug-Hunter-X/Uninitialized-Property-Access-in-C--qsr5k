# Uninitialized Property Access in C#

This repository demonstrates a common error in C# where a class property is accessed before it has been assigned a value.  This can lead to unexpected behavior, including `NullReferenceException` errors or the use of default values that don't reflect the program's intent.  The example highlights the problem and shows a correct way to handle property initialization.

## The Problem

In the `bug.cs` file, the `MyProperty` of the `ExampleClass` is used in `MyMethod` without first assigning a value. This could lead to the program crashing or producing incorrect output. 

## The Solution

The `bugSolution.cs` file provides a corrected version.  The solution involves initializing `MyProperty` either in the constructor or by assigning a default value when the property is declared. 