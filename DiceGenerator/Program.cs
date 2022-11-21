// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int i,d;
Console.Write("Press 1 to roll dice");
i = Convert.ToInt32(Console.ReadLine());
while (i==1)
{
    Random rand = new Random();
    int number = rand.Next(1, 7);
    Console.WriteLine(number);
    Console.Write("Press 1 to roll dice");
    i = Convert.ToInt32(Console.ReadLine());
}

