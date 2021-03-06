﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    class GoblinClass:enemiesClass
    {
        //Goblin class that holds and controll random values
        public GoblinClass(int positionx, int positiony, char character = 'G', int playerDamage = 1, int playerHp = 10) : base(positionx, positiony, character, playerDamage, playerHp)
        {

        }
        //this is the returnmove method
        public override MovementOfCharacter ReturnMove(MovementOfCharacter movementStruct = 0)
        {
            int randomRollSelect = select.Next(0, 5);

            while (movementStruct == 0)
            {
                if (randomRollSelect == 0)
                {
                    if (PlayerObserver[0] is emptyTile)
                    {
                        movementStruct = MovementOfCharacter.Left;
                        PositonX--;
                    }
                    else
                    {
                        randomRollSelect = select.Next(0, 5);
                    }
                }

                else if (randomRollSelect == 1)
                {
                    if (PlayerObserver[1] is emptyTile)
                    {
                        movementStruct = MovementOfCharacter.Up;
                        PositionY--;
                    }
                    else
                    {
                        randomRollSelect = select.Next(0, 5);
                    }
                }

                else if (randomRollSelect == 2)
                {
                    if (PlayerObserver[2] is emptyTile)
                    {
                        movementStruct = MovementOfCharacter.Right;
                        PositonX++;
                    }
                    else
                    {
                        randomRollSelect = select.Next(0, 5);
                    }
                }

                else if (randomRollSelect == 3)
                {
                    if (PlayerObserver[3] is emptyTile)
                    {
                        movementStruct = MovementOfCharacter.Down;
                        PositionY++;
                    }
                    else
                    {
                        randomRollSelect = select.Next(0, 5);
                    }
                }

                else
                {
                    movementStruct = MovementOfCharacter.NoMovement;
                }
            }

            return movementStruct;
        }
    }
}
