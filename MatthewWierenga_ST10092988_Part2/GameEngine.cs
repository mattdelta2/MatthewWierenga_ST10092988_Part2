using MatthewWierenga_ST10092988_Part2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_ST10092988_Part2
{
    public class GameEngine
    {
        private Map gamemap;
        public Map GAMEMAP
        {
            get { return gamemap; }
            set { gamemap = value; }
        }

        Random RANDOM_NUMBER_GENERATOR = new Random();

        public GameEngine()
        {
            GAMEMAP = new Map(10, 10, 10, 10, 5, 5);
        }

        public void Save()
        {

        }

        public void Load()
        {

        }


        public bool MovePlayer(MovementDirection Direction)
        {
            if (GAMEMAP.PLAYERCHARACTER.ReturnMove(Direction) == Direction)
            {
                GAMEMAP.Create(TileType.Empty, GAMEMAP.PLAYERCHARACTER.X, GAMEMAP.PLAYERCHARACTER.Y);

                GAMEMAP.PLAYERCHARACTER.Move(Direction);
                GAMEMAP.MAPCONTAINER[GAMEMAP.PLAYERCHARACTER.X, GAMEMAP.PLAYERCHARACTER.Y] = GAMEMAP.PLAYERCHARACTER;

                return true;
            }

            return false;
        }

        public string PlayerAttack(int EnemyIndex)
        {
            bool EnemyInRange = false;

            foreach (Tile T in GAMEMAP.PLAYERCHARACTER.Vision)
            {
                if (T.X == GAMEMAP.ENEMIES[EnemyIndex].X && (T.Y == GAMEMAP.ENEMIES[EnemyIndex].Y))
                {
                    EnemyInRange = true;
                    break;
                }
            }

            if (EnemyInRange)
            {
                GAMEMAP.PLAYERCHARACTER.Attack(GAMEMAP.ENEMIES[EnemyIndex]);
                return "You did " + GAMEMAP.PLAYERCHARACTER.Damage.ToString() + " damage to a " + GAMEMAP.ENEMIES[EnemyIndex].TYPEOFTILE.ToString() + " leaving them on " + GAMEMAP.ENEMIES[EnemyIndex].HP.ToString() + "HP";
            }
            else
            {
                return "Target was not in range...";
            }
        }
        public void MoveEnemies()
        {
            int amount;
            for (int i = 0; i < GAMEMAP.ENEMIES.Count; i++)
            {
                amount = RANDOM_NUMBER_GENERATOR.Next(1, 4);
                if (GAMEMAP.ENEMIES[i].SYMBOL == "G")
                {
                    MovementDirection move;
                    move = GAMEMAP.ENEMIES[i].ReturnMove();
                    GAMEMAP.MAPCONTAINER[GAMEMAP.ENEMIES[i].X, GAMEMAP.ENEMIES[i].Y] = new EmptyTile(GAMEMAP.ENEMIES[i].X, GAMEMAP.ENEMIES[i].Y, " ", TileType.Empty);
                    GAMEMAP.ENEMIES[i].Move(move);
                    GAMEMAP.MAPCONTAINER[GAMEMAP.ENEMIES[i].X, GAMEMAP.ENEMIES[i].Y] = GAMEMAP.ENEMIES[i];
                }
            }
        }

        public void enemyAttack(int attackDamage)
        {
            foreach (Enemy e in GAMEMAP.ENEMIES)
            {
                if (e.SYMBOL == "G")
                {
                    if (e.Vision[1].TYPEOFTILE == TileType.Hero)
                    {
                        GAMEMAP.PLAYERCHARACTER.HP -= attackDamage;
                    }
                    else if (e.Vision[3].TYPEOFTILE == TileType.Hero)
                    {
                        GAMEMAP.PLAYERCHARACTER.HP -= attackDamage;
                    }
                    else if (e.Vision[4].TYPEOFTILE == TileType.Hero)
                    {
                        GAMEMAP.PLAYERCHARACTER.HP -= attackDamage;
                    }
                    else if (e.Vision[6].TYPEOFTILE == TileType.Hero)
                    {
                        GAMEMAP.PLAYERCHARACTER.HP -= attackDamage;
                    }
                }
                else
                {
                    foreach (Tile tile in e.Vision)
                    {
                        if (tile.TYPEOFTILE == TileType.Enemy)
                        {
                            GAMEMAP.PLAYERCHARACTER.HP -= attackDamage;
                        }
                    }

                    if (e.Vision[0].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.Vision[0].X && en.Y == en.Vision[0].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }
                    if (e.Vision[1].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.Vision[1].X && en.Y == en.Vision[1].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }
                    if (e.Vision[2].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.Vision[2].X && en.Y == en.Vision[2].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }

                    if (e.Vision[3].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.Vision[3].X && en.Y == en.Vision[3].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }

                    if (e.Vision[4].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.Vision[4].X && en.Y == en.Vision[4].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }

                    if (e.Vision[5].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.Vision[5].X && en.Y == en.Vision[5].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }

                    if (e.Vision[6].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.Vision[6].X && en.Y == en.Vision[6].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }

                    if (e.Vision[7].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.Vision[1].X && en.Y == en.Vision[1].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }
                }
            }
        }
    }



}

