// See https://aka.ms/new-console-template for more information
using System;

double playerRandomNum;
double enemyRandomNum;
double playerTotal = 0.0;
double enemyTotal = 0.0;

Random random = new Random();
Console.WriteLine("              You are now playing the game \"Dice Averages\"!!");
System.Threading.Thread.Sleep(3000);
Console.WriteLine("\nThe rules are simple:\n\nYou will role the dice 8 times. Your score will be the average of all the numbers you rolled.");
System.Threading.Thread.Sleep(5000);
Console.WriteLine("\nAlso, you will be playing against another... uhh... player?  ");
System.Threading.Thread.Sleep(3000);
Console.Write("Dues Ex Machina!!");
System.Threading.Thread.Sleep(3000);
Console.WriteLine("\n\nWhoever has the highest average number after 8 rolls wins! Get ready...");
System.Threading.Thread.Sleep(5000);
Console.WriteLine("\nYou go first!");
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("\nYour turn. Press any key to roll the Dice...");
    Console.ReadKey();
    System.Threading.Thread.Sleep(1000);
    Console.WriteLine(" ");
    playerRandomNum = random.Next(1, 12);
    playerTotal += playerRandomNum;
    Console.WriteLine("You rolled... " + playerRandomNum + "!");

    Console.WriteLine(" ... ");
    System.Threading.Thread.Sleep(2000);

    enemyRandomNum = random.Next(1, 12);
    enemyTotal += enemyRandomNum;
    Console.WriteLine("Your opponent, Deus Ex, rolled... " + enemyRandomNum + "!");
    System.Threading.Thread.Sleep(800);
    
}
playerTotal /= 8;
enemyTotal /= 8;
Console.WriteLine("\nOkay! Who got the highest score?? Drum roll please.");
for (int j = 0; j < 10; j++)
{
    System.Threading.Thread.Sleep(500);
    Console.Write("~  ");
}
System.Threading.Thread.Sleep(1000);
Console.WriteLine("\nYour score is: " + playerTotal);
System.Threading.Thread.Sleep(2000);
Console.WriteLine("\nDeus Ex Machina's score is: " + enemyTotal);

if (playerTotal > enemyTotal)
{
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("\nYou Won!!!");
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("\n\nLuck is indeed on your side!");
}
else if (playerTotal < enemyTotal)
{
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("\nThat Creepy Machine God Won!!!");
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine("\n\nBetter luck next time...");
}
else
{
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("It's a Tie! You both... kinda win!");
}
System.Threading.Thread.Sleep(2000);