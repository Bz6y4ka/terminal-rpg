using System;
using System.Collections.Generic;
using System.Text;

namespace terminal_rpg
{
    class Player
    {
        private const string PLAYER_ATTACK = "Бью рукой";

        public const string remorse1PlayerName = "Я хардкодю";
        public const string remorse2PlayerClass = "Но не потому, что петух";
        public const string remorse3Inventory = "а потому, что не знаю как это грамотно сделать";
        public const int remorse4HeathPoint = 1000;
        //private string PlayerName { get; }
        //private string PlayerClass { get; }
        //private string Inventory { get; }
        //private int HeathPoint { get; }

        //public Player(string PlayerName, string PlayerClass, string Inventory, int HeathPoint)
        //{
        //    this.PlayerName = PlayerName;
        //    this.PlayerClass = PlayerClass;
        //    this.Inventory = Inventory;
        //    this.HeathPoint = HeathPoint;
        //}

        public void PlayerAttack()
        {
            Console.WriteLine(PLAYER_ATTACK);
        }

        public void PlayerSayClass()
        {
            Console.WriteLine(remorse2PlayerClass);
        }

        public void ShowInventory()
        {
            Console.WriteLine(remorse3Inventory);
        }

        public void ResourceRegen()
        {

        }
    }
}
