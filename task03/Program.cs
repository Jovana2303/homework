Console.Write("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

int temp;
temp = firstNumber;
firstNumber = secondNumber;
secondNumber = temp;

Console.Write("First number: " + firstNumber + "\n" + "Second number: " + secondNumber);