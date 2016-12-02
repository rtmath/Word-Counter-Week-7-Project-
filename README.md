# Word Counter
### by Ryan Mathisen 12/2/16

## Description

This is an exercise using Behavior Driven Development and Unit Testing in C#.

This program will take two inputs from a user: a word and another word or sentence. It will determine how many times the first word appears in the other word or sentence, and display the result to the user.

## Setup/Installation
1. Clone this repository to your computer directory of choice
2. Using Powershell, navigate inside that directory and run the command "dnu restore"
3. Using PowerShell, run the command "dnx kestrel"
4. Using your browser of choice, navigate to the url "localhost:5004" and enjoy!

## Specifications

| Behavior                                                          | Inputs (word, string to check against)                                | Output   | Description of Input Selection                                                                                                                                                 |
|-------------------------------------------------------------------|-----------------------------------------------------------------------|----------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Check if word is contained in string                              | "too", "tool"                                                         | true     | ("too", "tool") were chosen as inputs because they are both short words with the same case, and there is no punctuation to consider (as in the case of ("were, we're"))        |
|                                                                   | "cat", "dog"                                                          | false    | ("cat, dog") were chosen for the same reasons above to demonstrate output for nonmatching inputs                                                                               |
| Check if word is contained in string regardless of capitalization | "bReak", "BrEAkING"                                                   | true     | ("bReak", "BrEAkING") were chosen to demonstrate that regardless of whether a case discrepancy appears in the word or the string to check against, a match will still be found |
| Check how many times word occurs in string                        | "dodge", "The Dodgers"                                                | 1        | ("dodge", "The Dodgers") were chosen to build off of the previous behaviors and implement a new one - a counter for how many times a word appears in the inputted string       |
|                                                                   | "cat", "Cathy cannot keep all of her cats together in the cathedral"  | 3        | Further examples to elaborate on this behavior                                                                                                                                 |
|                                                                   | "the", "The thing is, there are a lot..."                             | 2        | Further examples to elaborate on this behavior                                                                                                                                 |

## Technologies Used
* C#
* Nancy/Razor
* xUnit
* HTML5/CSS

## License
Copyright (c) 2016 Ryan Mathisen

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
