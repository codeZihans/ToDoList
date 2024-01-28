Console.WriteLine("Task 2");

string input = Console.ReadLine();
int number = int.Parse(input);

number << 3;

string binary = Convert.ToString(number, 2);


Console.WriteLine(binary);