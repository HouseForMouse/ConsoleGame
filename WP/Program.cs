using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WP
{
    enum Color
    {
        Red,
        Green,
        Orange,
        Blue,
        Yellow,
    }
    class Character
    {
        public int HealtPoint = 20;
        public int MaxHealtPoint = 20;
        public int ManaPoint = 5;
        public int MaxManaPoint = 5;
        public int Experience = 0;
        public int MaxExperience = 30;
        public int Money = 0;
        public int Level = 0;
        public int Damage = 3;
        public int MagicDamage = 7;
        public int SkillPoint = 5;

    }
    class Skills
    {
        public int Strenght = 0;
        public int Intelligence = 0;
        public int Agillity = 0;
        public int Evasion = 0;
        public int Berserk = 0;
        public int MaxBerserk = 0;
        public int Perception = 0;

    }
public class Inventory
    {
        public bool Empty;
        public int Number;
        public string Name;
        public int Size = 10;
    }
    class Game
    {
        
        static void Main()
        {

            Character Char = new Character();

            Console.WriteLine("Dying Legion V1.0");
            Console.WriteLine(">Enter to Start");
            Console.WriteLine(">Escape to Exit");

            var button = Console.ReadKey();
            if (button.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                HeroCreate();
            }
            if (button.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Неправильно выбрана клавиша");
                Thread.Sleep(400);
                Console.Clear();
                Main();
            }

        }
       
        static void HeroCreate()
        {

            Character Char = new Character();
            Skills skills = new Skills();

            Console.WriteLine("Введите имя персонажа...");
            string HeroName = Console.ReadLine();
            Console.WriteLine($"Привет {HeroName} !");
            Thread.Sleep(500);
            Console.Clear();
        Case:
            Console.Clear();
            Console.WriteLine("Давай теперь распределим твои навыки");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"(1)Сила - {skills.Strenght}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"(2)Интеллект - {skills.Intelligence}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"(3)Ловкость - {skills.Agillity}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nКакой навык вы хотите улучшить? ");
            Console.Write($"\nОчков навыка осталось: {Char.SkillPoint}\n");
            var button = Console.ReadKey();
            if (button.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                if (Char.SkillPoint > 0)
                {
                    Char.SkillPoint = Char.SkillPoint - 1;
                    skills.Strenght = skills.Strenght + 1;
                    Console.Clear();
                    Console.WriteLine("Навык улучшен");
                    Thread.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto Case;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Вы потратили все навыки, начнём");
                    Thread.Sleep(500);
                    Menu();
                }

            }
            if (button.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                if (Char.SkillPoint > 0)
                {
                    Char.SkillPoint = Char.SkillPoint - 1;
                    skills.Intelligence = skills.Intelligence + 1;
                    Console.Clear();
                    Console.WriteLine("Навык улучшен");
                    Thread.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto Case;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Вы потратили все навыки, начнём");
                    Thread.Sleep(500);
                    Menu();
                }

            }
            if (button.Key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                if (Char.SkillPoint > 0)
                {
                    Char.SkillPoint = Char.SkillPoint - 1;
                    skills.Agillity = skills.Agillity + 1;
                    Console.Clear();
                    Console.WriteLine("Навык улучшен");
                    Thread.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto Case;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Вы потратили все навыки, начнём");
                    Thread.Sleep(500);
                    Menu();
                }
            }
            else
            {

                Console.Clear();
                Console.WriteLine("Неправильно выбрана клавиша");
                Thread.Sleep(400);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                goto Case;
            }

            void Menu()
            {
                Console.Clear();
                Console.Write(HeroName);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" {Char.Level} ");
                Console.Write($"({Char.Experience}/{Char.MaxExperience})");
                
                Console.Write(" Уровня");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($" {Char.HealtPoint}/{Char.MaxHealtPoint} Здоровья");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($" {Char.ManaPoint}/{Char.MaxManaPoint} Маны");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($" {Char.Money}");
                
                Console.Write(" Монет\n");

                Console.ResetColor();
                Console.WriteLine("(1) История (2) Магазин (3) Навыки \n(4) Кузница (5) Инвентраль (6) Арена");
                var button = Console.ReadKey();
                if (button.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("Ну что герой настало твоё время...");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("Выберите локацию.\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("(1) Поля Френгера (2) Тёмное болото\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("(3) Пещеры Экслота (4) Замок Принца Лютрика\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(5) Стена Малерта (6) Адское пекло Винтюра\n");
                    Console.ResetColor();
                    Console.ReadKey();

                }
                if (button.Key == ConsoleKey.D2)
                {
                   
                }
                if (button.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    Console.Write("(H)FAQ по умениям / (S)Статистика \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"(1)Сила - {skills.Strenght} (2)Берсерк - ({skills.Berserk}/{skills.MaxBerserk})" );
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"(3)Интеллект - {skills.Intelligence} (4)Магический щит - {skills.Perception}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"(5)Ловкость - {skills.Agillity} (6)Уклонение - {skills.Evasion}");
                    Console.Write($"\nОчков навыка осталось: {Char.SkillPoint}\n");
   
                    Console.ReadKey();
                }
                if (button.Key == ConsoleKey.D4)
                {

                }
                if (button.Key == ConsoleKey.D5)
                {
                    Console.Clear();
                    Console.ReadKey();
                }
                if (button.Key == ConsoleKey.D6)
                {

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Неправильно выбрана клавиша");
                    Thread.Sleep(400);
                    Console.Clear();
                    Menu();
                }
            }

        }

    }
}
