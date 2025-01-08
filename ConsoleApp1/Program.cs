// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello Sir!");



int Num_A = 3;
int Num_B = 4;

Console.WriteLine($"{Num_A} + {Num_B} = {Num_A + Num_B}");
Console.WriteLine($"{Num_A} * {Num_B} = {Num_A * Num_B}");
Console.WriteLine($"{Num_A} / {Num_B} = {Num_A / Num_B}");
Console.WriteLine($"{Num_A} - {Num_B} = {Num_A - Num_B}");
Console.WriteLine($"{Num_A} ^ {Num_B} = {Num_A ^ Num_B}");
Console.WriteLine($"{Num_A} % {Num_B} = {Num_A % Num_B}");


int age  = 25, health = 50, power  = 100;
Console.WriteLine(age + 2);
Console.WriteLine(health + 2);  
Console.WriteLine(power + 2);
Console.WriteLine(age + "," + health + "," + power);

string name = "Champion Coder";
Console.WriteLine("My name is " + name + " and I'm " + age + " years old.");    
Console.WriteLine($"My name is {name} and I'm {age} years old.");
Console.WriteLine("My name is \"Champion Coder\"");


switch (name) {
    default:
     case "Guardian Angel":
        Console.WriteLine("Hello Guardian Angel!");
        break;
    case "Hobbies":
        Console.WriteLine("Hello Hobbies!");
        break;
    case "Champion Coder":
        Console.WriteLine("Hello Champion Coder!");
        break;
        
    
}


{
    Random rng = new Random();
    int RandomNumber = rng.Next(0, 10);
    Console.WriteLine($"Guess a Randon number: ? ");

}
