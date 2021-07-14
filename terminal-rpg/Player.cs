using System;
using System.Collections.Generic;
using System.Text;

namespace terminal_rpg
{
    class Player
    {
        private const string PLAYER_ATTACK = "Бью рукой";

        private string PlayerName { get; }
        private string PlayerClass { get; }
        private string Inventory { get; }
        private int HeathPoint { get; }

        public Player(string PlayerName, string PlayerClass, string Inventory, int HeathPoint)
        {
            this.PlayerName = PlayerName;
            this.PlayerClass = PlayerClass;
            this.Inventory = Inventory;
            this.HeathPoint = HeathPoint;
        }

        public void PlayerAttack()
        {
            Console.WriteLine(PLAYER_ATTACK);
        }

        public void PlayerSayClass()
        {
            Console.WriteLine(PlayerClass);
        }

        public void ShowInventory()
        {
            Console.WriteLine(Inventory);
        }

        public void ResourceRegen()
        {

        }
    }
}
