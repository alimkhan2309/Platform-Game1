using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_Game
{
    internal class Player
    {
        private float jumpSpeed;

        bool goLeft, goRight, goUp, goDown, jumping, alive;


        // Char attributes

        private int speed;

        private int strength;

        private int defense;

        private int dexterity;



        




        public Player()
        {
            this.speed = 7;
            this.jumpSpeed = 0;
        }




        // Variable Getters & Setters
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }

        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }

        public bool GoLeft
        {
            get { return goLeft; }
            set { goLeft = value; }
        }
        public bool GoUp
        {
            get { return goUp; }
            set { goUp = value; }
        }
        public bool GoDown
        {
            get { return goDown; }
            set { goDown = value; }
        }

        public bool GoRight
        {
            get { return goRight; }
            set { goRight = value; }
        }

        public bool Jumping
        {
            get { return jumping; }
            set { jumping = value; }
        }

        public bool Alive
        {
            get { return alive; }
            set { alive = value; }
        }

    }
}
