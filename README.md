# KataStringCalculator
The aim of this project is to identify the vocabulary of unit testing. I used Xunit package.
it contains two project to separate of concerns, in the console project I created static class named StringCalculator.cs which has one method for simplesity:  int Add(String numbers).
In the StringCalculator project which depend on the Console project, there are many test casses as steps:
### **Step 1: the simplest thing**
The string argument can contain 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0) for example "" or "1" or "1,2".
### **Step 2: handle an unknown amount of numbers**
Allow the `add()` method to handle an unknown amount of numbers.
### **Step 3: handle new lines between numbers**
Allow the `add()` method to handle new lines between numbers (instead of commas).
### **Step 4: support different delimiters**
Support different delimiters: to change a delimiter, the beginning of the string will contain a separate line that looks like this:
`"//[delimiter]\n[numbers...]"`
### **Step 5: negative numbers**
Calling `add()` with a negative number will throw an exception `"negatives not allowed"` - and the negative that was passed.
For example `add("1,4,-1")` should throw an exception with the message `"negatives not allowed: -1"`.
If there are multiple negatives, show all of them in the exception message.
### **Step 6: ignore big numbers**
Numbers bigger than 1000 should be ignored, so adding 2 + 1001 = 2
