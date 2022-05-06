using Heroes.src.Entitis;
using static System.Console;

Knight Arus = new Knight("Arus", 23, "Knight");
Wizard Jannice = new Wizard("Jannice", 23, "White Wizard");

WriteLine(Arus.Attack());
WriteLine(Jannice.Attack());
WriteLine(Jannice.Attack(7)); 