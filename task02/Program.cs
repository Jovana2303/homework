Console.Write("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.Write("Enter the third number: ");
int thirdNumber = int.Parse(Console.ReadLine());

Console.Write("Enter the fourth number: ");
int fourthNumber = int.Parse(Console.ReadLine());

double sum = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

Console.Write("The average of "+ firstNumber + ", " + secondNumber + ", " + thirdNumber + " and " + fourthNumber + " is: " + sum);