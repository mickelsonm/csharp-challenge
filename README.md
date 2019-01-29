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

> Note: See Program.cs

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

# Comparison of Methods

ScrambleOne - This method uses caution when handling the provided input string. It makes a copy of the input and all work is done using the copy. Performance-wise this uses more upfront memory, but if data integrity is of value this might be a good way to go.

ScrambleTwo - This method swaps characters for random characters all in a single pass. This makes it the most performant. However, it comes at a cost, which is that it's highly likely that characters may seem repeated or less random. This method would be good for quickly randomizing, but the quality of the sample would be questionable.

ScrambleThree - This method splits the input string up into blocks of random lengths. Then, it puts them back together randomly at the end to form the result string. This approach would be useful if the randomized data should include partial pieces of its original somewhere in the output. If you're looking for randomization more on a character by character level, then this approach is definitely not the one to use.

# What method would I go with?

I personally would select ScrambleOne if I needed to randomize input throughly on a character by character basis. It may not be overly optimized or performant, but it offers some value in data integrity (very important to those that have spent a lot of time working with data) and it seems to be the best randomization strategy that is being analyzed presently.
