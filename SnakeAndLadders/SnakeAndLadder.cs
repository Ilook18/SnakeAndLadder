using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class SnakeAndLadder
    {


        public int playerPosition = 0;
        Random random = new Random();
        public int rollDie()
        {

            int die = random.Next(1, 7);
            return die;
        }



    }
}

