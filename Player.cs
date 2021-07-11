using System;
using System.Collections.Generic;
using System.Text;

namespace terminal_rpg
{
    public class Player
    {
        public string PlayerName { get; }
        public string GameClass { get; } // класс GameClass
        public int Inventory { get; }
        public int HealthPoint { get; }

        public Player(string PlayerName, string GameClass, int Inventory, int HealthPoint)
        {
            this.PlayerName = PlayerName;
            this.GameClass = GameClass;
            this.Inventory = Inventory;
            this.HealthPoint = HealthPoint;
        }

        public void Attack()
        {
            Console.WriteLine("Attack");
        }

        public void SayNameAndGameClass()
        {
            Console.WriteLine(PlayerName);
            Console.WriteLine(GameClass);
        }

        public void ShowInventory()
        {
            Console.WriteLine(Inventory);
        }

        public void ResurseReload() // RegenResource
        {
            
        }
    }
}
