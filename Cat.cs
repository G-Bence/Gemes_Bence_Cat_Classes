using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_260221
{
    internal class Cat
    {
        Random random = new Random();
        private int age;
        private string name;
        private int weight;
        private string breed;
        private string color;
        private int messy_level;
        private int consumption;
        private bool cute;
        private bool hungry;
        private string sex;

        public Cat(int age, string name, int weight, string breed, string color, int messy_level, int consumption, bool hungry, string sex)
        {
            this.age = age;
            this.name = name;
            this.weight = weight;
            this.breed = breed;
            this.color = color;
            this.messy_level = messy_level;
            this.consumption = consumption;
            this.cute = hungry;
            this.sex = sex;
            Max_messy_level(age);
            Hey_thats_my_cat();
        }

        public void Eating(double FoodWeight)
        {
            hungry = false;

            int chance = random.Next(101);

            if (chance <= 4)
            {
                color = "Green";
                weight -= (int)(weight * (chance / 100.0));
                messy_level /= 2;
            }
            else
            {
                weight += (int)Math.Ceiling(consumption * FoodWeight);
            }
        }

        public void Sleeping()
        {
            messy_level = 0;

            if(color == "Green")
            {
                color = "Original";
            }
        }

        public void WakeUp()
        {
            messy_level = 100;
            Max_messy_level(age);
            hungry = true;
        }

        public void Play()
        {
            if (messy_level == 0) {
                Sleeping();
            }
            else if(messy_level >= 1 && messy_level < 25)
            {
                Console.WriteLine(Game(1)); 
            }
            else if (messy_level >= 25 && messy_level < 50)
            {
                Console.WriteLine(Game(2));
            }
            else if (messy_level >= 50 && messy_level < 75)
            {
                Console.WriteLine(Game(3));
            }
            else if (messy_level >= 75 && messy_level < 101)
            {
                Console.WriteLine(Game(4));
            }

        }

        private string Game(int index)
        {
            List<string> games = ["Killing the arm-chair", "Catching the maus", "Eating nuclear waste", "Colonizing the Mars", "Winning the president election", "Rebuilding the 3rd empire"];
            List<int> used_nums = [];
            int rand_num;

            string text = "The cat is ";
            for (int i = 0; i < index; i++)
            {
                do
                {
                    rand_num = random.Next(0, games.Count());
                } while (used_nums.Contains(rand_num));

                used_nums.Add(rand_num);
                text += $"{games[rand_num]}";

                if(games[rand_num] == "Eating nuclear waste")
                {
                    Eating(80);
                }

                if (i < index-1)
                {
                    text += " and ";
                }
            }
            used_nums.Clear();
            return text;
        }


        private void Max_messy_level(int age)
        {
            if (age >= 0 & age < 3)
            {
                if (messy_level > 100 & color.ToLower() != "orange")
                {
                    messy_level = 100;
                }
            }
            else if (age >= 3 & age < 5)
            {
                if (messy_level > 80 & color.ToLower() != "orange")
                {
                    messy_level = 80;
                }
            }
            else if (age >= 5 & age < 7)
            {
                if (messy_level > 60 & color.ToLower() != "orange")
                {
                    messy_level = 60;
                }
            }
            else if (age >= 7 & age < 9)
            {
                if (messy_level > 40 & color.ToLower() != "orange")
                {
                    messy_level = 40;
                }
            }
            else if (age >= 9 & age < 11)
            {
                {
                    if (messy_level > 20 & color.ToLower() != "orange")
                    {
                        messy_level = 20;
                    }
                }

            }
            else
            {
                if (messy_level > 10 & color.ToLower() != "orange")
                {
                    messy_level = 10;
                }
            }
        }


        private void Hey_thats_my_cat() {
            if(color.ToLower() == "orange" & sex.ToLower() == "male" & name.ToLower() == "bátor" || name.ToLower() == "brave")
            {
                Console.WriteLine($"Hey, that's my cat {name}");
            }
            else if (color.ToLower() == "gray" & sex.ToLower() == "female" & name.ToLower() == "husi" || name.ToLower() == "meaty")
            {
                Console.WriteLine($"Hey, that's my cat {name}");
            }
        }

        public override string ToString()
        {
            string is_hungry = hungry ? "Yes" : "No";
            return $"Cat's name: {name}\n\t-Age: {age}\n\t-Breed: {breed}\n\t-Color: {color}\n\t-Messy Level: {messy_level}\n\t-Consumption: {consumption}\n\t-Is hungry: {is_hungry}\n\t-Sex: {sex}";
            /*int age, string name, int weight, string breed, string color, int messy_level, int consumption, bool hungry, string sex*/
        }
    }
}
