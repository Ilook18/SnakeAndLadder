﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class SnakeAndLadder
    {

        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING = 100, START = 0;
        public int playerPosition = 0;
        Random random = new Random();
        public int rollDie()
        {

            int die = random.Next(1, 7);
            return die;
        }

        public void Play()
        {
            while (this.playerPosition < 100)
            {

                int rollDie = this.rollDie();
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY: break;
                    case LADDER:
                        this.playerPosition += rollDie;
                        if (this.playerPosition > WINNING)
                        {
                            this.playerPosition -= rollDie;
                        }
                        break;
                    case SNAKE:
                        this.playerPosition -= rollDie;
                        if (this.playerPosition < START)
                        {
                            this.playerPosition = START;
                        }
                        break;
                }
            }
        }

    }
}
