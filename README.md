# 2024 Petrotranz Technical Assessment

## Assumptions:
- **Question 2**: Space characters are not counted as characters.
- **Question 3**: The search function only accepts a single word and performs
  an exact match, but ignore cases. For example, "Thank you" is not a valid search input, and
  "thank" is not equivalent to "thanks", "THank" is equivalent to "thank".
- **Questions 3 & 4**: The program runs on a single process, and it is not
  required to implement Map-Reduce style processing.
- **Questions 3 & 4**: A valid word contains only alphabetical characters.
  Any non-alphabetical characters within a word should be removed. For example,
  "Hello!" becomes a valid word after removing the '!'.

## Tools and Environment:
1. **xUnit** - version 2.9.0
2. **.NET SDK** - version 8.0.401
3. **Operating System** - Linux, Ubuntu 22.04

## Test Instructions:

### To Run Unit Tests: Navigate to the test directory and run the tests:

```bash cd petrotranz.Tests && dotnet test ```

### To Run the Program: Navigate to the main project directory and execute the
program:

```bash cd petrotranz && dotnet run ```
