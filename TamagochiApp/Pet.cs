using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagochiApp
{
    public class Pet : IAction
    {
        public string Name { get; private set; }
        private int health { get; set; } = 7;
        private int hunger { get; set; }
        private int fatigue { get; set; }
        private int balance { get; set; }
        public bool liveFlag { get; private set; } = true;

        public string Health
        {
            get { return new string('+', health); }
        }
        public string Hunger
        {
            get { return new string('*', hunger); }
        }
        public string Fatigue
        {
            get { return new string('@', fatigue); }
        }
        public int Balance
        {
            get { return balance; } 
        }

        public Pet(string namePet)
        {
            Name = namePet;
        }

        public void Feed()
        {
            if (hunger == 0)
            {
                health--;
            } else hunger = (hunger <= 10) ? --hunger : 10;
            CheckDeath();
        }

        public void EatTaco()
        {
            balance = balance - 2;
            if (hunger == 0)
            {
                health--;
            }
            else
                hunger = (hunger <= 10 && hunger > 2) ? hunger - 2 : 0;
            CheckDeath();
        }

        public void DrinkEnergy()
        {
            fatigue = (fatigue >= 2) ? fatigue - 2 : 0;
        }

        public void Play()
        {
            if(fatigue == 10)
            {
                health--;
                hunger++;
            } else fatigue = (fatigue >= 0) ? ++fatigue : 0;
            CheckDeath();
        }

        public void Sleep()
        {
            fatigue = 0;
            health = (health < 10) ? ++health : 10;
            hunger = (hunger <= 10) ? ++hunger : 10;
        }

        public void Work()
        {
            health--;
            if (hunger == 10)
            {
                health--;
            }
            else hunger = (hunger <= 10) ? ++hunger : 10;
            if (fatigue == 10)
            {
                health--;
                hunger++;
            }
            else fatigue = (fatigue <= 10) ? ++fatigue : 10;
            balance++;
            CheckDeath();
        }
        

        private void CheckDeath()
        {
            if(health <= 0)
                liveFlag = false;  
        }
    }
}
