using System;

namespace RolePlayV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Warrior warriorA = new Warrior("Ragnar");
            Warrior warriorB = new Warrior("Lagertha");

            Console.WriteLine($"Warrior A is called {warriorA.Name} and is level {warriorA.Level}");
            Console.WriteLine($"Warrior B is called {warriorB.Name} and is level {warriorB.Level}");

            Console.WriteLine($"Both {warriorA.Name} and {warriorB.Name} defeated a monster yay!");
            Console.WriteLine($"{warriorA.Name} got 200 EXP and leveled up twice thanks to a hidden exp skill.");
            Console.WriteLine($"{warriorB.Name} got 100 EXP and leveled up once.");

            warriorA.LevelUp();
            warriorA.LevelUp();
            warriorB.LevelUp();
            
            Console.WriteLine($"Warrior A is called {warriorA.Name} and is level {warriorA.Level}");
            Console.WriteLine($"Warrior B is called {warriorB.Name} and is level {warriorB.Level}");

            // The LAST line of code should be ABOVE this line
        }
    }
}