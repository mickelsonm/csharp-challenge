# Challenge Text

Write 3 functions (each with a different implementation) which accept a
string and return a string containing the same characters as the input
string -- but in a random order. Compare the 3 implementations and
describe why you might prefer one implementation over another
(and under what circumstances). Two of the implementations should use
the System.Random type and its Next(int minValue, int maxValue)
overload, while the third implementation isn't constrained to
System.Random usage.

# Descriptions for methods

```csharp
private static string ScrambleOne(string input)
```

This method makes a copy of the input string to ensure the original remains
unchanged.

Next, it loops over all of the characters, picks a random character, adds that
character to the result string, and removes it from the available characters to
prevent it from being used again.

Once work has been completed it returns the result string.

```csharp
private static string ScrambleTwo(string input)
```

This method converts the input string to a character array.

Next, it loops over the characters in array and while doing so it picks a random character
to be swapped out with. For example, if given an input string of 'ABC', on the first
iteration 'A' is the current character and if 'C' is randomly selected then these are
swapped. So, 'A' would become 'C' and 'C' would become 'A'.

Once these swaps have been made within the array, then we simply construct a new
string that serves as our result.

```csharp
private static string ScrambleThree(string input)
```

This method takes the input and divides it into pieces of random lengths.

Randomly it puts the pieces back together to construct the result.
