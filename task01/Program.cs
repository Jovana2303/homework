Console.Write("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.Write("Enter the Operation: ");
char Operator = char.Parse(Console.ReadLine()); ;

int result;
if (Operator == '+')
{
    result = firstNumber + secondNumber;
    Console.WriteLine("The result is: " + result);
}
else if (Operator == '-')
{
    result = firstNumber - secondNumber;
    Console.WriteLine("The result is: " + result);
}
else if (Operator == '*')
{
    result = firstNumber * secondNumber;
    Console.WriteLine("The result is: " + result);
}
else if (Operator == '/')
{
    result = firstNumber / secondNumber;
    Console.WriteLine("The result is: " + result);
}
else
{
    Console.Write("Invalid operator");
}
