using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
   
    class Mage 
    {
        protected int healthbar = 100;
        protected int enemy_damage = 20;
        private int all_attack_damage;

        public void Attack()
        {
            
            if (healthbar<=0)
            {
                Console.WriteLine("Your Mage is Dead");
                Console.WriteLine();
            }
            else
            {
                healthbar -= 10;
                all_attack_damage = all_attack_damage+enemy_damage;
                Console.WriteLine($"Mage's health: {healthbar}\n Mage's attack damage:{all_attack_damage} ");
                Console.WriteLine();
            }

            
        }

    }

    class LegendaryMage : Mage
    {
        private int healing_capasity = 5;

        public void Healing()
        {
            if (healthbar==100 || healthbar ==0)
            {
                Console.WriteLine("Unable to heal");
            }
            else
            {
                healthbar = healthbar + healing_capasity;
                enemy_damage--;
                Console.WriteLine($"Mage's health after healing: {healthbar} ");
                Console.WriteLine($"Mage's current enemy damage capasity: {enemy_damage} ");
            }
            
        }
    }

    class Knights
    {
        private int attack_capacity = 5;
        private int all_attack_damage;
        private int army_number;
        public Knights(int n)
        {
            army_number = n;
        }
        
       
        private int Reinforcement()
        {
            attack_capacity++;
            return attack_capacity;
        }

        public void Attack()
        {          

            if (army_number<=0)
            {
                Console.WriteLine("All your knights are dead");
                Console.WriteLine();
            }
            else
            {

                Reinforcement();
                all_attack_damage = all_attack_damage + attack_capacity * army_number;
                Console.WriteLine($"Current army number: {army_number}\n All attack damage {all_attack_damage}");
                Console.WriteLine();
                army_number--;
            }
            
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Mage first = new Mage();

            for (int i = 0; i < 20; i++)
            {
                first.Attack();
            }

            LegendaryMage first1 = new LegendaryMage();

            first1.Healing();
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                first1.Attack();
            }
            first1.Healing();

            LegendaryMage second2 = new LegendaryMage();

            for (int i = 0; i < 15; i++)
            {
                first.Attack();
            }

            second2.Healing();

            Console.Write("Input the number of knights: ");

            int knights_num = int.Parse(Console.ReadLine());
            Knights first3 = new Knights(knights_num);

            for (int i = 0; i < 15; i++)
            {
                first3.Attack();
            }
           
            Console.ReadKey();
        }
    }
}
