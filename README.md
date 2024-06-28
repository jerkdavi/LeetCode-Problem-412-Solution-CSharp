# SOLUTION TO LEETCODE PROBLEM 412 - C#

This is my solution to LeetCode Problem 412 - **Fizz Buzz** - in C# and a brief explanation

Link to problem on LeetCode -> [https://leetcode.com/problems/fizz-buzz/](https://leetcode.com/problems/fizz-buzz/)

## PROJECT EXPLANATION

I have created a new project in _Visual Studio 2022 Community Edition_, selected the **Console App** project template, named the project **FizzBuzz**, selected _.NET Core 3.1 (Out of support) Framework_.

I have two classes, **Program** class and **Solution** class.

## CODE EXPLANATION

### Program class 

I am using the automatically generated **Program** class and **Main** function.

```cs
internal class Program
{
    static void Main(string[] args)
    {
```

Firstly, the **n** numeric input (int) is initialized by using basic int initialization. This part of code is commented out currently.

```cs
int n = 3;
```

Currently, the **n** numeric input (int) is initialized by using next structure:

- Console Write -> where it displays that the value of n needs to be inputted.
- int input = int Parse Console ReadLine -> where user input is stored into the numeric input (int).

```cs
Console.Write("Enter value of number n: ");
int n = int.Parse(Console.ReadLine());
```

---

<details>
<summary>CODE EXPLAINED IN GREATER DETAIL</summary><br>
- Console.ReadLine always takes user input in a text format (string) . To convert the text input (string) into a numeric input (int) -> int Parse needs to be used.<br>
</details>

---

Next, the **FizzBuzz** function from **Solution** class is called. It takes an int (_int n_) and returns a List of strings (_List\<string> output_). The returned List of strings is stored into a new IList of strings named **list**.
The returned IList of strings is then printed out to the console by using the for loop and if statement.

```cs
IList<string> list = Solution.FizzBuzz(n);

for (int i = 0; i < list.Count; i++)
{
    if (i != 0)
    {
        Console.Write(",");
    }
    Console.Write(list[i]);
}
```

At the end of the **Program** class there is next structure:

- Console WriteLine -> where it displays that the code is done processing.
- Console ReadLine -> where it waits for user input.

---

<details>
<summary>WHY DOES CONSOLE READLINE WAIT FOR USER INPUT?</summary><br>
To stop the code from automatically completing and exiting and us not being able to check the result of the code.<br>
</details>

---

```cs
Console.WriteLine("\nDone processing");
Console.ReadLine();
```

### Solution class 

I have created a new class and named it **Solution**. I have made it public. I have created the **FizzBuzz** function and mirrored the example provided in the LeetCode problem. I have made it static.

```cs
public class Solution
{
    public static IList<string> FizzBuzz(int n)
    {
```

Firstly, the List of strings (List\<string> **output**) is initialized by using basic List of strings initialization. It is instantiated. This List of strings will be used to store the result of all modulus of numbers into and return it at the end of the function.

```cs
List<string> output = new List<string>();
```

Secondly, the **for** loop is initialized that iterates from _0 to n_.

```cs
for (int i = 0; i < n; i++)
{
```

The **word** text input (string) is initialized by using basic string initialization. It is set as empty string. This text input (string) will be used to store the result of modulus of current number into and store it into the List of strings at the end of the for loop.

---

<details>
<summary>WHY IS IT INITIALIZED HERE AND NOT BEFORE THE FOR LOOP?</summary><br>
Because it needs to be set as empty string at every for loop iteration to correctly display the result of modulus of current number.<br>
</details>

---

```cs
string word = "";
```

Inside the **for** loop, there are three **if** statements.

- First if statement checks if the result of modulus 3 of a number is equal to 0. If the statement is true, it adds word 'Fizz' to the **word** text input (string).
- Second if statement checks if the result of modulus 5 of a number is equal to 0. If the statement is true, it adds word 'Buzz' to the **word** text input (string)
- Third if statement checks if **word** text input (string) is empty. The **word** is empty if the result of modulus 3 and 5 of a number are not equal to 0. If the statement is true, it adds value of a current number to the **word** text input (string).

```cs
if ((i + 1) % 3 == 0)
{
    word += "Fizz";
}
if ((i + 1) % 5 == 0)
{
    word += "Buzz";
}
if(word == "")
{
    word += i + 1;
}
```

At the end of the **for** loop, the **word** text input (string) is added to the List of strings (List\<string> **output**).

```cs
output.Add(word);
```

At the end of the **Solution** class, the List of strings (List\<string> **output**) is returned.

```cs
return output;
```

## POTENTIAL MISTAKES (I HAVE MADE)

None that I am aware of.

Any advice regarding making the code _MORE TIME AND SPACE EFFICIENT_ is **MORE THAN WELCOME**.

## RUNNING THE CODE - RESULT

![image](https://github.com/jerkdavi/LeetCode-Problem-412-Solution-CSharp/assets/75536158/70a7c6ac-1383-4a1e-91b5-c84598d25217) ![image](https://github.com/jerkdavi/LeetCode-Problem-412-Solution-CSharp/assets/75536158/e61cb58d-ae08-4016-abd4-616eeabe36d7) ![image](https://github.com/jerkdavi/LeetCode-Problem-412-Solution-CSharp/assets/75536158/4f768fdb-0c5b-4edb-b5f1-8a446469da85)



