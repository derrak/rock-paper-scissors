using System;

public class Program
{
  static void Main()
  {
  Console.WriteLine("Player 1, Choose rock, paper, or scissors");
  string user1Input = Console.ReadLine();
  Console.WriteLine("Player 2, choose rock, paper or scissors");
  string user2Input = Console.ReadLine();
    if (user1Input == user2Input){
      Console.WriteLine("Draw");
      Main();
    }
    else if (user1Input == "paper"){
      if (user2Input == "scissors"){
        Console.WriteLine("User 2 wins");
         Main();
      }
      else{Console.WriteLine("User 1 wins");
       Main();
       }
    }
    else if (user1Input == "scissors"){
      if (user2Input == "paper"){
        Console.WriteLine("User 1 wins");
         Main();
      }
      else{Console.WriteLine("User 2 wins");
       Main();
       }
    }
    else if (user1Input == "rock"){
      if (user2Input == "paper"){
        Console.WriteLine("User 2 wins");
         Main();
      }
      else{Console.WriteLine("User 1 wins");
       Main();
       }
    }
  }
}