using System;
using System.Collections.Generic;
using System.Text;

namespace terminal_rpg
{
    public class GameClass // все игровые классы наследуются от GameClass
    {
        static int HandAttack = 0; // const вместо static, сила аттаки - 20

        public GameClass(int HandAttack)
        {
             HandAttack = 1; // не нужно, проинициализируй филд
        }
        
        // protected Attack() {
        // }
        
        // все классы переопределяют метод Attack
        // @override
        // public Attack() {}
            

        GameClass Dudu = new GameClass (HandAttack);
    }
}
