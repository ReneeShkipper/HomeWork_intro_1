// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input price of notebooks");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Input price of pens");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Input quantity of notebooks");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Input quantity of pens");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Total quantity of products - {0}; Total amount of goods - {1}", m + n, x * m + y * n);
Console.ReadLine();
