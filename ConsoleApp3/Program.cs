﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ALPHA_0._4._9
{
    internal class Program
    {
        // слова героев
        static void replica_leshego()
        {
            Console.Write("***** - ");
            {
                string te = "Остерегайся энергичного волчёнка, он быстро взрослеет.";
                int ab = 100;

                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ab);
                }
                Console.WriteLine();
            }
        }

        // бои 
        static void gornostai_gomage_1()
        {
            Console.Clear();
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
            Console.WriteLine("|---------| |         | |---------| |         |");
            Console.WriteLine("|         | |         | |         | |         |");
            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
            Console.WriteLine("|---------| |         | |---------| |         |");
            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
            Console.WriteLine("|---------| |---------| |         | |         |");
            Console.WriteLine(@"|        1| | ___     | |         | |         |");
            Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
            Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
            Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
            Console.WriteLine("|---------| |---------| |         | |         |");
            Console.WriteLine("|.1.....3.| |.......5.| |         | |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

            while (true)
            {
                Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                ConsoleKeyInfo keyinfo = Console.ReadKey();

                if (keyinfo.Key == ConsoleKey.Tab)
                {
                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                    Console.WriteLine("|---------| |---------| |         | |         |");
                    Console.WriteLine(@"|        1| | ___     | |         | |         |");
                    Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                    Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
                    Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                    Console.WriteLine("|---------| |---------| |         | |         |");
                    Console.WriteLine("|.1.....3.| |.......5.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |..Пень...| |         |");
                    Console.WriteLine("| _______ | |         | |---------| |         |");
                    Console.WriteLine("||       || |         | |         | |         |");
                    Console.WriteLine(@"||  /-\  || |         | | |\_  /| | |         |");
                    Console.WriteLine(@"| \ \_/ / | |         | | |  \/ | | |         |");
                    Console.WriteLine(@"|  \   /  | |         | | |_____\ | |         |");
                    Console.WriteLine(@"|   \_/   | |         | |---------| |         |");
                    Console.WriteLine("|         | |         | |.......3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— |.КАМЕНЬ..| |         | |         |");
                    Console.WriteLine(@"|   / \   | |---------| |         | |         |");
                    Console.WriteLine(@"|  /   \  | | ___     | |         | |         |");
                    Console.WriteLine(@"|  |   |  | ||___\_   | |         | |         |");
                    Console.WriteLine(@"|  |   |  | ||_____\_ | |         | |         |");
                    Console.WriteLine(@"|  |   |  | ||_______\| |         | |         |");
                    Console.WriteLine(@"| -|___|- | |---------| |         | |         |");
                    Console.WriteLine(@"|   | |   | |.......5.| |         | |         |");
                    Console.WriteLine(@"|   | |   | ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   (*)   |");
                    Console.WriteLine(@"-----------");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | ——————————— ——————————— ———————————");
                    Console.WriteLine("| _______ | |         | |..Пень...| |         |");
                    Console.WriteLine("||       || |         | |---------| |         |");
                    Console.WriteLine(@"||  /-\  || |         | |         | |         |");
                    Console.WriteLine(@"| \ \_/ / | |         | | |\_  /| | |         |");
                    Console.WriteLine(@"|  \   /  | |         | | |  \/ | | |         |");
                    Console.WriteLine(@"|   \_/   | |         | | |_____\ | |         |");
                    Console.WriteLine("|         | |         | |---------| |         |");
                    Console.WriteLine("——————————— |         | |.......3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   / \   | ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|  /   \  | |.КАМЕНЬ..| |         | |         |");
                    Console.WriteLine(@"|  |   |  | |---------| |         | |         |");
                    Console.WriteLine(@"|  |   |  | | ___     | |         | |         |");
                    Console.WriteLine(@"|  |   |  | ||___\_   | |         | |         |");
                    Console.WriteLine(@"| -|___|- | ||_____\_ | |         | |         |");
                    Console.WriteLine(@"|   | |   | ||_______\| |         | |         |");
                    Console.WriteLine(@"|   | |   | |---------| |         | |         |");
                    Console.WriteLine(@"|   (*)   | |.......5.| |         | |         |");
                    Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|.......2.| |         | |.......3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                    Console.WriteLine("|—————————| |---------| |         | |         |");
                    Console.WriteLine("|        1| | ___     | |         | |         |");
                    Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                    Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
                    Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                    Console.WriteLine("|—————————| |---------| |         | |         |");
                    Console.WriteLine("|.1.....3.| |.......5.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(1000);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                    Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                    Console.WriteLine("|—————————| |---------| |         | |         |");
                    Console.WriteLine("|        1| | ___     | |         | |         |");
                    Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                    Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
                    Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                    Console.WriteLine("|—————————| |---------| |         | |         |");
                    Console.WriteLine("|.1.....3.| |.......5.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(750);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"----------- ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— |   (*)   | ——————————— ———————————");
                    Console.WriteLine(@"|..Пень...| |   | |   | |..Пень...| |         |");
                    Console.WriteLine(@"|---------| |   | |   | |---------| |         |");
                    Console.WriteLine(@"|         | | -|---|- | |         | |         |");
                    Console.WriteLine(@"| |\_  /| | |  |   |  | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |  |   |  | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |  \   /  | | |_____\ | |         |");
                    Console.WriteLine(@"|---------| |   \ /   | |---------| |         |");
                    Console.WriteLine(@"|.......2.| ----------- |.......3.| |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|ГОРНОСТАЙ| |         | |         | |          |");
                    Console.WriteLine(@"|—————————| | _______ | |         | |          |");
                    Console.WriteLine(@"|        1| ||       || |         | |          |");
                    Console.WriteLine(@"| |\---/| | ||  /-\  || |         | |          |");
                    Console.WriteLine(@"| | -_- | | | \ \_/ / | |         | |          |");
                    Console.WriteLine(@"|  \_^_/  | |  \   /  | |         | |          |");
                    Console.WriteLine(@"|—————————| |   \_/   | |         | |          |");
                    Console.WriteLine(@"|.1.....3.| |         | |         | |          |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                    Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                    Console.WriteLine(@"|..Пень...| |   (*)   | |..Пень...| |         |");
                    Console.WriteLine(@"|---------| |   | |   | |---------| |         |");
                    Console.WriteLine(@"|         | |   | |   | |         | |         |");
                    Console.WriteLine(@"| |\_  /| | | -|---|- | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |  |   |  | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |  |   |  | | |_____\ | |         |");
                    Console.WriteLine(@"|---------| |  |   |  | |---------| |         |");
                    Console.WriteLine(@"|.......2.| |  \   /  | |.......3.| |         |");
                    Console.WriteLine(@"——————————— |   \ /   | ——————————— ——————————— ");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|ГОРНОСТАЙ| ——————————— |         | |         |");
                    Console.WriteLine(@"|---------| |         | |         | |         |");
                    Console.WriteLine(@"|        1| | _______ | |         | |         |");
                    Console.WriteLine(@"| |\---/| | ||       || |         | |         |");
                    Console.WriteLine(@"| | -_- | | ||  /-\  || |         | |         |");
                    Console.WriteLine(@"|  \_^_/  | | \ \_/ / | |         | |         |");
                    Console.WriteLine(@"|—————————| |  \   /  | |         | |         |");
                    Console.WriteLine(@"|.1.....3.| |   \_/   | |         | |         |");
                    Console.WriteLine(@"——————————— |         | ——————————— ———————————");
                    Console.WriteLine(@"            ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                    Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
                    Console.WriteLine("|—————————| |---------| |         | |         |");
                    Console.WriteLine("|        1| | ___     | |         | |         |");
                    Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
                    Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
                    Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
                    Console.WriteLine("|—————————| |---------| |         | |         |");
                    Console.WriteLine("|.1.....3.| |.......4.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
        static void gornostai_domage_3()
        {
            Console.Clear();
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
            Console.WriteLine("|---------| |         | |---------| |         |");
            Console.WriteLine("|         | |         | |         | |         |");
            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
            Console.WriteLine("|---------| |         | |---------| |         |");
            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|         | |.КАМЕНЬ..| |ГОРНОСТАЙ| |         |");
            Console.WriteLine("|         | |---------| |---------| |         |");
            Console.WriteLine(@"|         | | ___     | |        1| |         |");
            Console.WriteLine(@"|         | ||___\_   | | |\---/| | |         |");
            Console.WriteLine(@"|         | ||_____\_ | | | -_- | | |         |");
            Console.WriteLine(@"|         | ||_______\| |  \_^_/  | |         |");
            Console.WriteLine("|         | |---------| |---------| |         |");
            Console.WriteLine("|         | |.......5.| |.1.....3.| |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

            while (true)
            {
                Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                ConsoleKeyInfo keyinfo = Console.ReadKey();

                if (keyinfo.Key == ConsoleKey.Tab)
                {

                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |.КАМЕНЬ..| |ГОРНОСТАЙ| |         |");
                    Console.WriteLine("|         | |---------| |—————————| |         |");
                    Console.WriteLine("|         | | ___     | |        1| |         |");
                    Console.WriteLine(@"|         | ||___\_   | | |\---/| | |         |");
                    Console.WriteLine(@"|         | ||_____\_ | | | -_- | | |         |");
                    Console.WriteLine(@"|         | ||_______\| |  \_^_/  | |         |");
                    Console.WriteLine("|         | |---------| |—————————| |         |");
                    Console.WriteLine("|         | |.......5.| |.1.....3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);

                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|..Пень...| |         | |         | |          |");
                    Console.WriteLine(@"|---------| |         | | _______ | |          |");
                    Console.WriteLine(@"|         | |         | ||       || |          |");
                    Console.WriteLine(@"| |\_  /| | |         | ||  /-\  || |          |");
                    Console.WriteLine(@"| |  \/ | | |         | | \ \_/ / | |          |");
                    Console.WriteLine(@"| |_____\ | |         | |  \   /  | |          |");
                    Console.WriteLine(@"|---------| |         | |   \_/   | |          |");
                    Console.WriteLine(@"|.......3.| |         | |         | |          |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |.КАМЕНЬ..| ——————————— |         |");
                    Console.WriteLine(@"|         | |---------| |   / \   | |         |");
                    Console.WriteLine(@"|         | | ___     | |  /   \  | |         |");
                    Console.WriteLine(@"|         | ||___\_   | |  |   |  | |         |");
                    Console.WriteLine(@"|         | ||_____\_ | |  |   |  | |         |");
                    Console.WriteLine(@"|         | ||_______\| |  |   |  | |         |");
                    Console.WriteLine(@"|         | |---------| | -|___|- | |         |");
                    Console.WriteLine(@"|         | |.......5.| |   | |   | |         |");
                    Console.WriteLine(@"----------- ----------- |   | |   | ———————————");
                    Console.WriteLine(@"                        |   (*)   |");
                    Console.WriteLine(@"                        -----------");


                    Thread.Sleep(250);

                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("----------- ----------- |         | ———————————");
                    Console.WriteLine(@"|..Пень...| |         | | _______ | |          |");
                    Console.WriteLine(@"|---------| |         | ||       || |          |");
                    Console.WriteLine(@"|         | |         | ||  /-\  || |          |");
                    Console.WriteLine(@"| |\_  /| | |         | | \ \_/ / | |          |");
                    Console.WriteLine(@"| |  \/ | | |         | |  \   /  | |          |");
                    Console.WriteLine(@"| |_____\ | |         | |   \_/   | |          |");
                    Console.WriteLine(@"|---------| |         | |         | |          |");
                    Console.WriteLine("|.......3.| |         | ——————————— |          |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"----------- ——————————— |   / \   | ———————————");
                    Console.WriteLine(@"|         | |.КАМЕНЬ..| |  /   \  | |         |");
                    Console.WriteLine(@"|         | |---------| |  |   |  | |         |");
                    Console.WriteLine(@"|         | | ___     | |  |   |  | |         |");
                    Console.WriteLine(@"|         | ||___\_   | |  |   |  | |         |");
                    Console.WriteLine(@"|         | ||_____\_ | | -|___|- | |         |");
                    Console.WriteLine(@"|         | ||_______\| |   | |   | |         |");
                    Console.WriteLine(@"|         | |---------| |   | |   | |         |");
                    Console.WriteLine(@"|         | |.......5.| |   (*)   | |         |");
                    Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                    Thread.Sleep(250);

                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|.......3.| |         | |.......2.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |.КАМЕНЬ..| |ГОРНОСТАЙ| |         |");
                    Console.WriteLine("|         | |---------| |—————————| |         |");
                    Console.WriteLine("|         | | ___     | |        1| |         |");
                    Console.WriteLine(@"|         | ||___\_   | | |\---/| | |         |");
                    Console.WriteLine(@"|         | ||_____\_ | | | -_- | | |         |");
                    Console.WriteLine(@"|         | ||_______\| |  \_^_/  | |         |");
                    Console.WriteLine("|         | |---------| |—————————| |         |");
                    Console.WriteLine("|         | |.......5.| |.1.....3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(1000);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                    Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine("|.......3.| |.1..$..1.| |.......2.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |.КАМЕНЬ..| |ГОРНОСТАЙ| |         |");
                    Console.WriteLine("|         | |---------| |—————————| |         |");
                    Console.WriteLine("|         | | ___     | |        1| |         |");
                    Console.WriteLine(@"|         | ||___\_   | | |\---/| | |         |");
                    Console.WriteLine(@"|         | ||_____\_ | | | -_- | | |         |");
                    Console.WriteLine(@"|         | ||_______\| |  \_^_/  | |         |");
                    Console.WriteLine("|         | |---------| |—————————| |         |");
                    Console.WriteLine("|         | |.......5.| |.1.....3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);

                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"----------- ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— |   (*)   | ——————————— ———————————");
                    Console.WriteLine(@"|..Пень...| |   | |   | |..Пень...| |         |");
                    Console.WriteLine(@"|---------| |   | |   | |---------| |         |");
                    Console.WriteLine(@"|         | | -|---|- | |         | |         |");
                    Console.WriteLine(@"| |\_  /| | |  |   |  | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |  |   |  | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |  \   /  | | |_____\ | |         |");
                    Console.WriteLine(@"|---------| |   \ /   | |---------| |         |");
                    Console.WriteLine(@"|.......3.| ----------- |.......2.| |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |ГОРНОСТАЙ| |          |");
                    Console.WriteLine(@"|         | | _______ | |—————————| |          |");
                    Console.WriteLine(@"|         | ||       || |        1| |          |");
                    Console.WriteLine(@"|         | ||  /-\  || | |\---/| | |          |");
                    Console.WriteLine(@"|         | | \ \_/ / | | | -_- | | |          |");
                    Console.WriteLine(@"|         | |  \   /  | |  \_^_/  | |          |");
                    Console.WriteLine(@"|         | |   \_/   | |—————————| |          |");
                    Console.WriteLine(@"|         | |         | |.1.....3.| |          |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);

                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                    Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                    Console.WriteLine(@"|..Пень...| |   (*)   | |..Пень...| |         |");
                    Console.WriteLine(@"|---------| |   | |   | |---------| |         |");
                    Console.WriteLine(@"|         | |   | |   | |         | |         |");
                    Console.WriteLine(@"| |\_  /| | | -|---|- | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |  |   |  | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |  |   |  | | |_____\ | |         |");
                    Console.WriteLine(@"|---------| |  |   |  | |---------| |         |");
                    Console.WriteLine(@"|.......3.| |  \   /  | |.......2.| |         |");
                    Console.WriteLine(@"——————————— |   \ /   | ——————————— ——————————— ");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | ——————————— |ГОРНОСТАЙ| |         |");
                    Console.WriteLine(@"|         | |         | |---------| |         |");
                    Console.WriteLine(@"|         | | _______ | |        1| |         |");
                    Console.WriteLine(@"|         | ||       || | |\---/| | |         |");
                    Console.WriteLine(@"|         | ||  /-\  || | | -_- | | |         |");
                    Console.WriteLine(@"|         | | \ \_/ / | |  \_^_/  | |         |");
                    Console.WriteLine(@"|         | |  \   /  | |—————————| |         |");
                    Console.WriteLine(@"|         | |   \_/   | |.1.....3.| |         |");
                    Console.WriteLine(@"——————————— |         | ——————————— ———————————");
                    Console.WriteLine(@"            ———————————");

                    Thread.Sleep(250);

                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                    Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine("|.......3.| |.1..$..1.| |.......2.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |.КАМЕНЬ..| |ГОРНОСТАЙ| |         |");
                    Console.WriteLine("|         | |---------| |—————————| |         |");
                    Console.WriteLine("|         | | ___     | |        1| |         |");
                    Console.WriteLine(@"|         | ||___\_   | | |\---/| | |         |");
                    Console.WriteLine(@"|         | ||_____\_ | | | -_- | | |         |");
                    Console.WriteLine(@"|         | ||_______\| |  \_^_/  | |         |");
                    Console.WriteLine("|         | |---------| |—————————| |         |");
                    Console.WriteLine("|         | |.......4.| |.1.....3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
        static void gomage_gornostai_4()
        {
            Console.Clear();
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
            Console.WriteLine("|---------| |         | |---------| |         |");
            Console.WriteLine("|         | |         | |         | |         |");
            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
            Console.WriteLine("|---------| |         | |---------| |         |");
            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |ГОРНОСТАЙ|");
            Console.WriteLine("|         | |---------| |         | |—————————|");
            Console.WriteLine("|         | | ___     | |         | |        1|");
            Console.WriteLine(@"|         | ||___\_   | |         | | |\---/| |");
            Console.WriteLine(@"|         | ||_____\_ | |         | | | -_- | |");
            Console.WriteLine(@"|         | ||_______\| |         | |  \_^_/  |");
            Console.WriteLine("|         | |---------| |         | |—————————|");
            Console.WriteLine("|         | |.......5.| |         | |.1.....3.|");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

            while (true)
            {
                Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                ConsoleKeyInfo keyinfo = Console.ReadKey();

                if (keyinfo.Key == ConsoleKey.Tab)
                {

                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |.КАМЕНЬ..| |         | |ГОРНОСТАЙ|");
                    Console.WriteLine("|         | |---------| |         | |—————————|");
                    Console.WriteLine("|         | | ___     | |         | |        1|");
                    Console.WriteLine(@"|         | ||___\_   | |         | | |\---/| |");
                    Console.WriteLine(@"|         | ||_____\_ | |         | | | -_- | |");
                    Console.WriteLine(@"|         | ||_______\| |         | |  \_^_/  |");
                    Console.WriteLine("|         | |---------| |         | |—————————|");
                    Console.WriteLine("|         | |.......5.| |         | |.1.....3.|");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |.КАМЕНЬ..| |         | |         |");
                    Console.WriteLine(@"|         | |---------| |         | |   / \   |");
                    Console.WriteLine(@"|         | | ___     | |         | |  /   \  |");
                    Console.WriteLine(@"|         | ||___\_   | |         | |  |   |  |");
                    Console.WriteLine(@"|         | ||_____\_ | |         | |  |   |  |");
                    Console.WriteLine(@"|         | ||_______\| |         | |  |   |  |");
                    Console.WriteLine(@"|         | |---------| |         | | -|___|- |");
                    Console.WriteLine(@"|         | |.......5.| |         | |   | |   |");
                    Console.WriteLine(@"——————————— ----------- ----------- |   | |   |");
                    Console.WriteLine(@"                                    |   (*)   |");
                    Console.WriteLine(@"                                    -----------");

                    Thread.Sleep(250);

                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|.......3.| |         | |.......3.| -----------");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"----------- ----------- ——————————— |   / \   |");
                    Console.WriteLine(@"|         | |.КАМЕНЬ..| |         | |  /   \  |");
                    Console.WriteLine(@"|         | |---------| |         | |  |   |  |");
                    Console.WriteLine(@"|         | | ___     | |         | |  |   |  |");
                    Console.WriteLine(@"|         | ||___\_   | |         | |  |   |  |");
                    Console.WriteLine(@"|         | ||_____\_ | |         | | -|___|- |");
                    Console.WriteLine(@"|         | ||_______\| |         | |   | |   |");
                    Console.WriteLine(@"|         | |---------| |         | |   | |   |");
                    Console.WriteLine(@"|         | |.......5.| |         | |   (*)   |");
                    Console.WriteLine(@"----------- ----------- ——————————— ———————————");

                    Thread.Sleep(250);

                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |         | |---------| |         |");
                    Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |.КАМЕНЬ..| |         | |ГОРНОСТАЙ|");
                    Console.WriteLine("|         | |---------| |         | |—————————|");
                    Console.WriteLine("|         | | ___     | |         | |        1|");
                    Console.WriteLine(@"|         | ||___\_   | |         | | |\---/| |");
                    Console.WriteLine(@"|         | ||_____\_ | |         | | | -_- | |");
                    Console.WriteLine(@"|         | ||_______\| |         | |  \_^_/  |");
                    Console.WriteLine("|         | |---------| |         | |—————————|");
                    Console.WriteLine("|         | |.......5.| |         | |.1.....3.|");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(700);

                    Console.Clear();
                    Console.WriteLine(@"
                               _____________                                                 
                             _/. . . + . . .\_
                           _/.       ^       .\_ 
                          /+         |         +\
                         |___________|___________|
                                    | |
                                    | |
               _____________________|_|_____________________
              /_____________________________________________\
             /_|                    | |                    |_\
               |                   /   \                    |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
              / \                 |     |                  / \
             /   \                |     |                 /   \ 
            /     \               |     |                /     \
           /       \              |     |               /       \
          |---------|             |     |              |---------|
          |         |             |     |              |         |
          |---------|             |     |              |---------|
                                  |     |
                                  |     |
                                  |     |
                                  |     |
                                 /       \
                                /         \
                               /___________\");

                    Thread.Sleep(500);

                    Console.Clear();
                    Console.WriteLine(@"
                               _____________                                                 
                             _/. . . + . . .\_
                           _/.         ^     .\_ 
                          /+          /        +\
                         |___________/___________|
                                    | |
                                    | |
               _____________________|_|_____________________
              /_____________________________________________\
             /_|                    | |                    |_\
               |                   /   \                    |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
              / \                 |     |                   |
             /   \                |     |                  / \
            /     \               |     |                 /   \ 
           /       \              |     |                /     \
          |---------|             |     |               /       \
          |         |             |     |              |---------|
          |---------|             |     |              |*        |
                                  |     |              |---------|
                                  |     |
                                  |     |
                                  |     |
                                  |     |
                                 /       \
                                /         \
                               /___________\");

                    Thread.Sleep(1000);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                    Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine("|.......3.| |.1..$..1.| |.......3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |.КАМЕНЬ..| |         | |ГОРНОСТАЙ|");
                    Console.WriteLine("|         | |---------| |         | |—————————|");
                    Console.WriteLine("|         | | ___     | |         | |        1|");
                    Console.WriteLine(@"|         | ||___\_   | |         | | |\---/| |");
                    Console.WriteLine(@"|         | ||_____\_ | |         | | | -_- | |");
                    Console.WriteLine(@"|         | ||_______\| |         | |  \_^_/  |");
                    Console.WriteLine("|         | |---------| |         | |—————————|");
                    Console.WriteLine("|         | |.......5.| |         | |.1.....3.|");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);

                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"----------- ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— |   (*)   | ——————————— ———————————");
                    Console.WriteLine(@"|..Пень...| |   | |   | |..Пень...| |         |");
                    Console.WriteLine(@"|---------| |   | |   | |---------| |         |");
                    Console.WriteLine(@"|         | | -|---|- | |         | |         |");
                    Console.WriteLine(@"| |\_  /| | |  |   |  | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |  |   |  | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |  \   /  | | |_____\ | |         |");
                    Console.WriteLine(@"|---------| |   \ /   | |---------| |         |");
                    Console.WriteLine(@"|.......3.| ----------- |.......3.| |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |         | |ГОРНОСТАЙ|");
                    Console.WriteLine(@"|         | | _______ | |         | |—————————|");
                    Console.WriteLine(@"|         | ||       || |         | |        1|");
                    Console.WriteLine(@"|         | ||  /-\  || |         | | |\---/| |");
                    Console.WriteLine(@"|         | | \ \_/ / | |         | | | -_- | |");
                    Console.WriteLine(@"|         | |  \   /  | |         | |  \_^_/  |");
                    Console.WriteLine(@"|         | |   \_/   | |         | |—————————|");
                    Console.WriteLine(@"|         | |         | |         | |.1.....3.|");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);

                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                    Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                    Console.WriteLine(@"|..Пень...| |   (*)   | |..Пень...| |         |");
                    Console.WriteLine(@"|---------| |   | |   | |---------| |         |");
                    Console.WriteLine(@"|         | |   | |   | |         | |         |");
                    Console.WriteLine(@"| |\_  /| | | -|---|- | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |  |   |  | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |  |   |  | | |_____\ | |         |");
                    Console.WriteLine(@"|---------| |  |   |  | |---------| |         |");
                    Console.WriteLine(@"|.......3.| |  \   /  | |.......3.| |         |");
                    Console.WriteLine(@"——————————— |   \ /   | ——————————— ——————————— ");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | ——————————— |         | |ГОРНОСТАЙ|");
                    Console.WriteLine(@"|         | |         | |         | |---------|");
                    Console.WriteLine(@"|         | | _______ | |         | |        1|");
                    Console.WriteLine(@"|         | ||       || |         | | |\---/| |");
                    Console.WriteLine(@"|         | ||  /-\  || |         | | | -_- | |");
                    Console.WriteLine(@"|         | | \ \_/ / | |         | |  \_^_/  |");
                    Console.WriteLine(@"|         | |  \   /  | |         | |—————————|");
                    Console.WriteLine(@"|         | |   \_/   | |         | |.1.....3.|");
                    Console.WriteLine(@"——————————— |         | ——————————— ———————————");
                    Console.WriteLine(@"            ———————————");

                    Thread.Sleep(250);

                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
                    Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
                    Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
                    Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                    Console.WriteLine("|---------| |—————————| |---------| |         |");
                    Console.WriteLine("|.......3.| |.1..$..1.| |.......3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |.КАМЕНЬ..| |         | |ГОРНОСТАЙ|");
                    Console.WriteLine("|         | |---------| |         | |—————————|");
                    Console.WriteLine("|         | | ___     | |         | |        1|");
                    Console.WriteLine(@"|         | ||___\_   | |         | | |\---/| |");
                    Console.WriteLine(@"|         | ||_____\_ | |         | | | -_- | |");
                    Console.WriteLine(@"|         | ||_______\| |         | |  \_^_/  |");
                    Console.WriteLine("|         | |---------| |         | |—————————|");
                    Console.WriteLine("|         | |.......4.| |         | |.1.....3.|");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }

        static void bitva_nomer_1()
        {
            Console.Clear();
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
            Console.WriteLine("|---------| |         | |---------| |         |");
            Console.WriteLine("|         | |         | |         | |         |");
            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
            Console.WriteLine("|---------| |         | |---------| |         |");
            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
            Console.WriteLine("|         | |---------| |         | |         |");
            Console.WriteLine(@"|         | | ___     | |         | |         |");
            Console.WriteLine(@"|    1    | ||___\_   | |    3    | |    4    |");
            Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
            Console.WriteLine(@"|         | ||_______\| |         | |         |");
            Console.WriteLine("|         | |---------| |         | |         |");
            Console.WriteLine("|         | |.......5.| |         | |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

            Console.Write("***** - ");
            {
                string fraza = "Положи карту.";
                int vrema = 100;
                foreach (char c in fraza)
                {
                    Console.Write(c);
                    Thread.Sleep(vrema);
                }
                Console.WriteLine();
                Thread.Sleep(1000);
            }

            int mesto_gornostai = int.Parse(Console.ReadLine());

            if (mesto_gornostai == 1)
            {
                void mesto1()
                {
                    gornostai_gomage_1();
                }
                mesto1();

                void rep()
                {
                    replica_leshego();
                }
                rep();
            }
            else if (mesto_gornostai == 3)
            {
                void mesto3()
                {
                    gornostai_domage_3();
                }
                mesto3();

                void rep()
                {
                    replica_leshego();
                }
                rep();
            }
            else if (mesto_gornostai == 4)
            {
                void mesto4()
                {
                    gomage_gornostai_4();
                }
                mesto4();

                void rep()
                {
                    replica_leshego();
                }
                rep();
            }

            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine(@"——————————— ———————————");
            Console.WriteLine(@"|   / \   | |         |");
            Console.WriteLine(@"|  0   0  | |         |");
            Console.WriteLine(@"|   \ /   | |  C...C  |");
            Console.WriteLine(@"|   / \   | | ( . . ) |");
            Console.WriteLine(@"|   \ /   | |  \   /  |");
            Console.WriteLine(@"|   / \   | |   `o`   |");
            Console.WriteLine(@"|  0   0  | |         |");
            Console.WriteLine(@"|   \ /   | |         |");
            Console.WriteLine(@"——————————— ———————————");

            Thread.Sleep(250);
            Console.WriteLine("1) Своя карта.");

            Thread.Sleep(250);
            Console.WriteLine("2) Белка.");

            int vibor__belka_ili_svoia_carta = int.Parse(Console.ReadLine());

            if (vibor__belka_ili_svoia_carta == 1)
            {
                if (mesto_gornostai == 1)
                {
                    void karta()
                    {
                        karta_mestnosti2_ataka1_1();
                    }
                    karta();

                    void koloda()
                    {
                        kalodaB2();
                    }
                    koloda();
                    Thread.Sleep(1000);

                    void karta1()
                    {
                        karta_mestnosti2_ataka1_1();
                    }
                    karta1();

                    void koloda1()
                    {
                        kalodaB3();
                    }
                    koloda1();
                }
                else if (mesto_gornostai == 3)
                {
                    void karta()
                    {
                        karta_mestnosti2_ataka1_3();
                    }
                    karta();

                    void koloda()
                    {
                        kalodaB2();
                    }
                    koloda();
                    Thread.Sleep(1000);

                    void karta1()
                    {
                        karta_mestnosti2_ataka1_3();
                    }
                    karta1();

                    void koloda1()
                    {
                        kalodaB3();
                    }
                    koloda1();
                }
                else if (mesto_gornostai == 4)
                {
                    void karta()
                    {
                        karta_mestnosti2_ataka1_4();
                    }
                    karta();

                    void koloda()
                    {
                        kalodaB2();
                    }
                    koloda();
                    Thread.Sleep(1000);

                    void karta1()
                    {
                        karta_mestnosti2_ataka1_4();
                    }
                    karta1();

                    void koloda1()
                    {
                        kalodaB3();
                    }
                    koloda1();
                }
            }
            if (vibor__belka_ili_svoia_carta == 2)
            {
                if (mesto_gornostai == 1)
                {
                    void karta()
                    {
                        karta_mestnosti2_ataka1_1();
                    }
                    karta();

                    void koloda()
                    {
                        kalodaA2();
                    }
                    koloda();
                    Thread.Sleep(1000);

                    void karta1()
                    {
                        karta_mestnosti2_ataka1_1();
                    }
                    karta1();

                    void koloda1()
                    {
                        kalodaA3();
                    }
                    koloda1();
                }
                else if (mesto_gornostai == 3)
                {
                    void karta()
                    {
                        karta_mestnosti2_ataka1_3();
                    }
                    karta();

                    void koloda()
                    {
                        kalodaA2();
                    }
                    koloda();
                    Thread.Sleep(1000);

                    void karta1()
                    {
                        karta_mestnosti2_ataka1_3();
                    }
                    karta1();

                    void koloda1()
                    {
                        kalodaA3();
                    }
                    koloda1();
                }
                else if (mesto_gornostai == 4)
                {
                    void karta()
                    {
                        karta_mestnosti2_ataka1_4();
                    }
                    karta();

                    void koloda()
                    {
                        kalodaA2();
                    }
                    koloda();
                    Thread.Sleep(1000);

                    void karta1()
                    {
                        karta_mestnosti2_ataka1_4();
                    }
                    karta1();

                    void koloda1()
                    {
                        kalodaA3();
                    }
                    koloda1();
                }
            }
        }

        // игра
        static void start1_game()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Thread.Sleep(1000);
            Console.Write(@"
             ██╗                                                                        
             ██║                                                                        
             ██║                                                                       
             ██║                                                                       
             ██║                                                                       
             ╚═╝                                                                        
");
            Thread.Sleep(500);
            Console.Clear();
            Console.Write(@"
             ██╗                                                                        ███╗   ██╗
             ██║                                                                        ████╗  ██║
             ██║                                                                        ██╔██╗ ██║
             ██║                                                                        ██║╚██╗██║
             ██║                                                                        ██║ ╚████║
             ╚═╝                                                                        ╚═╝  ╚═══╝
            ");
            Thread.Sleep(400);
            Console.Clear();
            Console.Write(@"
             ██╗███╗   ██╗                                                      ██████╗ ███╗   ██╗
             ██║████╗  ██║                                                     ██╔═══██╗████╗  ██║
             ██║██╔██╗ ██║                                                     ██║   ██║██╔██╗ ██║
             ██║██║╚██╗██║                                                     ██║   ██║██║╚██╗██║
             ██║██║ ╚████║                                                     ╚██████╔╝██║ ╚████║
             ╚═╝╚═╝  ╚═══╝                                                     ╚═════╝ ╚═╝  ╚═══╝
            ");
            Thread.Sleep(300);
            Console.Clear();
            Console.Write(@"
            ██╗███╗   ██╗███████╗                                          ██╗ ██████╗ ███╗   ██╗
            ██║████╗  ██║██╔════╝                                          ██║██╔═══██╗████╗  ██║
            ██║██╔██╗ ██║███████╗                                          ██║██║   ██║██╔██╗ ██║
            ██║██║╚██╗██║╚════██║                                          ██║██║   ██║██║╚██╗██║
            ██║██║ ╚████║███████║                                          ██║╚██████╔╝██║ ╚████║
            ╚═╝╚═╝  ╚═══╝╚══════╝                                          ╚═╝ ╚═════╝ ╚═╝  ╚═══╝
            ");
            Thread.Sleep(200);
            Console.Clear();
            Console.Write(@"
            ██╗███╗   ██╗███████╗ ██████╗                         ████████╗██╗ ██████╗ ███╗   ██╗
            ██║████╗  ██║██╔════╝██╔════╝                         ╚══██╔══╝██║██╔═══██╗████╗  ██║
            ██║██╔██╗ ██║███████╗██║                                 ██║   ██║██║   ██║██╔██╗ ██║
            ██║██║╚██╗██║╚════██║██║                                 ██║   ██║██║   ██║██║╚██╗██║
            ██║██║ ╚████║███████║╚██████╗                            ██║   ██║╚██████╔╝██║ ╚████║
            ╚═╝╚═╝  ╚═══╝╚══════╝ ╚═════╝                            ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝
            ");
            Thread.Sleep(150);
            Console.Clear();
            Console.Write(@"
            ██╗███╗   ██╗███████╗ ██████╗██████╗          ██████╗ ████████╗██╗ ██████╗ ███╗   ██╗
            ██║████╗  ██║██╔════╝██╔════╝██╔══██╗         ██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║
            ██║██╔██╗ ██║███████╗██║     ██████╔╝         ██████╔╝   ██║   ██║██║   ██║██╔██╗ ██║
            ██║██║╚██╗██║╚════██║██║     ██╔══██╗         ██╔═══╝    ██║   ██║██║   ██║██║╚██╗██║
            ██║██║ ╚████║███████║╚██████╗██║  ██║         ██║        ██║   ██║╚██████╔╝██║ ╚████║
            ╚═╝╚═╝  ╚═══╝╚══════╝ ╚═════╝╚═╝  ╚═╝         ╚═╝        ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝
            ");
            Thread.Sleep(100);
            Console.Clear();
            Console.Write(@"
            ██╗███╗   ██╗███████╗ ██████╗██████╗   ╚═╝    ██████╗ ████████╗██╗ ██████╗ ███╗   ██╗
            ██║████╗  ██║██╔════╝██╔════╝██╔══██╗         ██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║
            ██║██╔██╗ ██║███████╗██║     ██████╔╝         ██████╔╝   ██║   ██║██║   ██║██╔██╗ ██║
            ██║██║╚██╗██║╚════██║██║     ██╔══██╗         ██╔═══╝    ██║   ██║██║   ██║██║╚██╗██║
            ██║██║ ╚████║███████║╚██████╗██║  ██║         ██║        ██║   ██║╚██████╔╝██║ ╚████║
            ╚═╝╚═╝  ╚═══╝╚══════╝ ╚═════╝╚═╝  ╚═╝         ╚═╝        ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝
            ");
            Thread.Sleep(100);
            Console.Clear();
            Console.Write(@"
            ██╗███╗   ██╗███████╗ ██████╗██████╗    ██║   ██████╗ ████████╗██╗ ██████╗ ███╗   ██╗
            ██║████╗  ██║██╔════╝██╔════╝██╔══██╗   ╚═╝   ██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║
            ██║██╔██╗ ██║███████╗██║     ██████╔╝         ██████╔╝   ██║   ██║██║   ██║██╔██╗ ██║
            ██║██║╚██╗██║╚════██║██║     ██╔══██╗         ██╔═══╝    ██║   ██║██║   ██║██║╚██╗██║
            ██║██║ ╚████║███████║╚██████╗██║  ██║         ██║        ██║   ██║╚██████╔╝██║ ╚████║
            ╚═╝╚═╝  ╚═══╝╚══════╝ ╚═════╝╚═╝  ╚═╝         ╚═╝        ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝
            ");
            Thread.Sleep(100);
            Console.Clear();
            Console.Write(@"
            ██╗███╗   ██╗███████╗ ██████╗██████╗  ╚████╔╝ ██████╗ ████████╗██╗ ██████╗ ███╗   ██╗
            ██║████╗  ██║██╔════╝██╔════╝██╔══██╗   ██║   ██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║
            ██║██╔██╗ ██║███████╗██║     ██████╔╝   ╚═╝   ██████╔╝   ██║   ██║██║   ██║██╔██╗ ██║
            ██║██║╚██╗██║╚════██║██║     ██╔══██╗         ██╔═══╝    ██║   ██║██║   ██║██║╚██╗██║
            ██║██║ ╚████║███████║╚██████╗██║  ██║         ██║        ██║   ██║╚██████╔╝██║ ╚████║
            ╚═╝╚═╝  ╚═══╝╚══════╝ ╚═════╝╚═╝  ╚═╝         ╚═╝        ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝
            ");
            Thread.Sleep(100);
            Console.Clear();
            Console.Write(@"
            ██╗███╗   ██╗███████╗ ██████╗██████╗ ╚██╗ ██╔╝██████╗ ████████╗██╗ ██████╗ ███╗   ██╗
            ██║████╗  ██║██╔════╝██╔════╝██╔══██╗ ╚████╔╝ ██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║
            ██║██╔██╗ ██║███████╗██║     ██████╔╝  ╚██╔╝  ██████╔╝   ██║   ██║██║   ██║██╔██╗ ██║
            ██║██║╚██╗██║╚════██║██║     ██╔══██╗   ██║   ██╔═══╝    ██║   ██║██║   ██║██║╚██╗██║
            ██║██║ ╚████║███████║╚██████╗██║  ██║   ╚═╝   ██║        ██║   ██║╚██████╔╝██║ ╚████║
            ╚═╝╚═╝  ╚═══╝╚══════╝ ╚═════╝╚═╝  ╚═╝         ╚═╝        ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝
            ");
            Thread.Sleep(150);
            Console.Clear();
            Console.Write(@"
            ██╗███╗   ██╗███████╗ ██████╗██████╗ ██╗   ██╗██████╗ ████████╗██╗ ██████╗ ███╗   ██╗
            ██║████╗  ██║██╔════╝██╔════╝██╔══██╗╚██╗ ██╔╝██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║
            ██║██╔██╗ ██║███████╗██║     ██████╔╝ ╚████╔╝ ██████╔╝   ██║   ██║██║   ██║██╔██╗ ██║
            ██║██║╚██╗██║╚════██║██║     ██╔══██╗  ╚██╔╝  ██╔═══╝    ██║   ██║██║   ██║██║╚██╗██║
            ██║██║ ╚████║███████║╚██████╗██║  ██║   ██║   ██║        ██║   ██║╚██████╔╝██║ ╚████║
            ╚═╝╚═╝  ╚═══╝╚══════╝ ╚═════╝╚═╝  ╚═╝   ╚═╝   ╚═╝        ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝
            ");

            Console.ResetColor();

            Console.Write("                              НАЖМИТЕ НА ЛЮБУЮ КНОПКУ                         ");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine(@"                ———————————");
            Console.WriteLine(@"                |         |");
            Console.WriteLine(@"                |         |");
            Console.WriteLine(@"                |    |    |");
            Console.WriteLine(@"                |   \_/   |");
            Console.WriteLine(@"                |         |");
            Console.WriteLine(@"                |         |");
            Console.WriteLine(@"                |         |");
            Console.WriteLine(@"                ———————————");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(@"———————————     ———————————     ———————————");
            Console.WriteLine(@"|   ( )   |     |  _( )   |     | _______ |");
            Console.WriteLine(@"|   / \   |     | / / \   |     | \|- - | |");
            Console.WriteLine(@"|//| + |\\|     || |   |\\|     |  |-- -| |");
            Console.WriteLine(@"|/ |   | \|     ||-|   | \|     |  |- --| |");
            Console.WriteLine(@"|  // \\  |     |  // \\ /|     |  |-- -| |");
            Console.WriteLine(@"| //   \\ |     | //   || |     |  \-----\|");
            Console.WriteLine(@"|//     \\|     |//   /|| |     |         |");
            Console.WriteLine(@"———————————     ———————————     ———————————");

            Console.WriteLine();
            Console.WriteLine("     1                2              3  ");
            Console.WriteLine("НОВАЯ ИГРА        ПРОДОЛЖИТЬ       ТИТРЫ");

        }                       //начало игры 

        // колоды карт
        static void kaloda2()
        {
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine(@"|..БЕЛКА..| |ГОРНОСТАЙ| |ЧЕРЕПАХА.| |..КОШКА..|");
            Console.WriteLine(@"|—————————| |—————————| |—————————| |—————————|");
            Console.WriteLine(@"| _  (\_  | |        1| |      _ 2| | \    /\2|");
            Console.WriteLine(@"|( \  ( '>| | |\---/| | |  .-./*) | |  )  ( ')|");
            Console.WriteLine(@"| ) \/_)= | | | -_- | | |_/___\/  | | (  /  ) |");
            Console.WriteLine(@"|(_(__)_  | |  \_^_/  | |  U U    | |  \(__)| |");
            Console.WriteLine(@"|—————————| |—————————| |—————————| |—————————|");
            Console.WriteLine(@"|.0.....1.| |.1.....3.| |.1.....6.| |.0..%..1.|");
            Console.WriteLine(@"——————————— ——————————— ——————————- ———————————");
        }                           //колода с кошкой
        static void kalodaB1()
        {
            Console.WriteLine(@"——————————— ——————————— ———————————");
            Console.WriteLine(@"|ГОРНОСТАЙ| |ЧЕРЕПАХА.| |..КОШКА..|");
            Console.WriteLine(@"|—————————| |—————————| |—————————|");
            Console.WriteLine(@"|        1| |      _ 2| | \    /\2|");
            Console.WriteLine(@"| |\---/| | |  .-./*) | |  )  ( ')|");
            Console.WriteLine(@"| | -_- | | |_/___\/  | | (  /  ) |");
            Console.WriteLine(@"|  \_^_/  | |  U U    | |  \(__)| |");
            Console.WriteLine(@"|—————————| |—————————| |—————————|");
            Console.WriteLine(@"|.1.....3.| |.1.....6.| |.0..%..1.|");
            Console.WriteLine(@"——————————— ——————————- ———————————");
        }                          //колода без белк но с кошкой
        static void kalodaB2()
        {
            Console.WriteLine(@"——————————— ———————————");
            Console.WriteLine(@"|ЧЕРЕПАХА.| |..КОШКА..|");
            Console.WriteLine(@"|—————————| |—————————|");
            Console.WriteLine(@"|      _ 2| | \    /\2|");
            Console.WriteLine(@"|  .-./*) | |  )  ( ')|");
            Console.WriteLine(@"|_/___\/  | | (  /  ) |");
            Console.WriteLine(@"|  U U    | |  \(__)| |");
            Console.WriteLine(@"|—————————| |—————————|");
            Console.WriteLine(@"|.1.....6.| |.0..%..1.|");
            Console.WriteLine(@"——————————- ———————————");
        }
        static void kalodaB3()
        {
            Console.WriteLine(@"——————————— ——————————— ———————————");
            Console.WriteLine(@"|ЧЕРЕПАХА.| |..КОШКА..| |...Волк..|");
            Console.WriteLine(@"|—————————| |—————————| |—————————|");
            Console.WriteLine(@"|      _ 2| | \    /\2| ||\_____/2|");
            Console.WriteLine(@"|  .-./*) | |  )  ( ')| ||)     (||");
            Console.WriteLine(@"|_/___\/  | | (  /  ) | | \ o o / |");
            Console.WriteLine(@"|  U U    | |  \(__)| | |  \_0_/  |");
            Console.WriteLine(@"|—————————| |—————————| |—————————|");
            Console.WriteLine(@"|.1.....6.| |.0..%..1.| |.3.....2.|");
            Console.WriteLine(@"——————————- ——————————— ———————————");
        }
        static void kaloda1()
        {
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine(@"|..БЕЛКА..| |ГОРНОСТАЙ| |ЧЕРЕПАХА.| |.ГАДЮКА..|");
            Console.WriteLine(@"|—————————| |—————————| |—————————| |—————————|");
            Console.WriteLine(@"| _  (\_  | |        1| |      _ 2| |        2|");
            Console.WriteLine(@"|( \  ( '>| | |\---/| | |  .-./*) | |  ___   /|");
            Console.WriteLine(@"| ) \/_)= | | | -_- | | |_/___\/  | | ('')\_//|");
            Console.WriteLine(@"|(_(__)_  | |  \_^_/  | |  U U    | |  ^  \_/ |");
            Console.WriteLine(@"|—————————| |—————————| |—————————| |—————————|");
            Console.WriteLine(@"|.0.....1.| |.1.....3.| |.1.....6.| |.1..X..1.|");
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
        }                           //колода с гадюкой
        static void kalodaA1()
        {
            Console.WriteLine(@"——————————— ——————————— ———————————");
            Console.WriteLine(@"|ГОРНОСТАЙ| |ЧЕРЕПАХА.| |.ГАДЮКА..|");
            Console.WriteLine(@"|—————————| |—————————| |—————————|");
            Console.WriteLine(@"|        1| |      _ 2| |        2|");
            Console.WriteLine(@"| |\---/| | |  .-./*) | |  ___   /|");
            Console.WriteLine(@"| | -_- | | |_/___\/  | | ('')\_//|");
            Console.WriteLine(@"|  \_^_/  | |  U U    | |  ^  \_/ |");
            Console.WriteLine(@"|—————————| |—————————| |—————————|");
            Console.WriteLine(@"|.1.....3.| |.1.....6.| |.1..X..1.|");
            Console.WriteLine(@"——————————— ——————————— ———————————");
        }                          //колода с гадюкой без кошки
        static void kalodaA2()
        {
            Console.WriteLine(@"——————————— ———————————");
            Console.WriteLine(@"|ЧЕРЕПАХА.| |.ГАДЮКА..|");
            Console.WriteLine(@"|—————————| |—————————|");
            Console.WriteLine(@"|      _ 2| |        2|");
            Console.WriteLine(@"|  .-./*) | |  ___   /|");
            Console.WriteLine(@"|_/___\/  | | ('')\_//|");
            Console.WriteLine(@"|  U U    | |  ^  \_/ |");
            Console.WriteLine(@"|—————————| |—————————|");
            Console.WriteLine(@"|.1.....6.| |.1..X..1.|");
            Console.WriteLine(@"——————————— ———————————");
        }
        static void kalodaA3()
        {
            Console.WriteLine(@"——————————— ——————————— -----------");
            Console.WriteLine(@"|ЧЕРЕПАХА.| |.ГАДЮКА..| |..БЕЛКА..|");
            Console.WriteLine(@"|—————————| |—————————| |---------|");
            Console.WriteLine(@"|      _ 2| |        2| | _  (\_  |");
            Console.WriteLine(@"|  .-./*) | |  ___   /| |( \  ( '>|");
            Console.WriteLine(@"|_/___\/  | | ('')\_//| | ) \/_)= |");
            Console.WriteLine(@"|  U U    | |  ^  \_/ | |(_(__)_  |");
            Console.WriteLine(@"|—————————| |—————————| |---------|");
            Console.WriteLine(@"|.1.....6.| |.1..X..1.| |.0.....1.|");
            Console.WriteLine(@"——————————— ——————————— -----------");
        }

        // карты местности
        static void karta_mestnosti()
        {
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | | |\___/| | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
            Console.WriteLine("|---------| |         | |---------| |         |");
            Console.WriteLine("|         | |         | |         | |         |");
            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
            Console.WriteLine("|---------| |         | |---------| |         |");
            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
            Console.WriteLine("|         | |---------| |         | |         |");
            Console.WriteLine(@"|         | | ___     | |         | |         |");
            Console.WriteLine(@"|         | ||___\_   | |         | |         |");
            Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
            Console.WriteLine(@"|         | ||_______\| |         | |         |");
            Console.WriteLine("|         | |---------| |         | |         |");
            Console.WriteLine("|         | |.......5.| |         | |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
        }                   //карта местности
        static void karta_mestnosti1_zertva_belki()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                Console.WriteLine("|---------| |         | |---------| |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                Console.WriteLine("|---------| |         | |---------| |         |");
                Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
                Console.WriteLine("|         | |---------| |         | |         |");
                Console.WriteLine(@"|         | | ___     | |         | |         |");
                Console.WriteLine(@"|    1    | ||___\_   | |    3    | |    4    |");
                Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
                Console.WriteLine(@"|         | ||_______\| |         | |         |");
                Console.WriteLine("|         | |---------| |         | |         |");
                Console.WriteLine("|         | |.......5.| |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Console.Write("***** - ");
                {
                    string fraza = "Положи карту.";
                    int vrema = 100;
                    foreach (char c in fraza)
                    {
                        Console.Write(c);
                        Thread.Sleep(vrema);
                    }
                    Console.WriteLine();
                    Thread.Sleep(1000);
                }

                int Mesto_belki = int.Parse(Console.ReadLine());

                if (Mesto_belki == 1)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                        Console.WriteLine("|---------| |         | |---------| |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                        Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                        Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                        Console.WriteLine("|---------| |         | |---------| |         |");
                        Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|..БЕЛКА..| |.КАМЕНЬ..| |         | |         |");
                        Console.WriteLine("|—————————| |---------| |         | |         |");
                        Console.WriteLine(@"| _  (\_  | | ___     | |         | |         |");
                        Console.WriteLine(@"|( \  ( '>| ||___\_   | |         | |         |");
                        Console.WriteLine(@"| ) \/_)= | ||_____\_ | |         | |         |");
                        Console.WriteLine(@"|(_(__)_  | ||_______\| |         | |         |");
                        Console.WriteLine("|—————————| |---------| |         | |         |");
                        Console.WriteLine("|.0.....1.| |.......5.| |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Console.Write("***** - ");
                        {
                            string fraza = "Выбери жертву.";
                            int vrema = 100;
                            foreach (char c in fraza)
                            {
                                Console.Write(c);
                                Thread.Sleep(vrema);
                            }
                            Console.WriteLine();
                            Thread.Sleep(1000);
                        }

                        int carta_zertvi = int.Parse(Console.ReadLine());

                        if (carta_zertvi == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|\.БЕЛКА./| |.КАМЕНЬ..| |         | |         |");
                            Console.WriteLine(@"|—\—————/—| |---------| |         | |         |");
                            Console.WriteLine(@"|  \  (/_ | | ___     | |         | |         |");
                            Console.WriteLine(@"|(  \ / '>| ||___\_   | |         | |         |");
                            Console.WriteLine(@"| ) //\)= | ||_____\_ | |         | |         |");
                            Console.WriteLine(@"|(_/__)\  | ||_______\| |         | |         |");
                            Console.WriteLine(@"|—/—————\—| |---------| |         | |         |");
                            Console.WriteLine(@"|/0.....1\| |.......5.| |         | |         |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(1000);
                            Console.Clear();

                            void mesto()
                            {
                                karta_mestnosti();
                            }
                            mesto();

                            break;
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                    break;
                }
                else if (Mesto_belki == 2)
                {
                    Console.Write("***** - ");
                    {
                        string fraza = "На этом месте уже стоит карта.";
                        int vrema = 100;
                        foreach (char c in fraza)
                        {
                            Console.Write(c);
                            Thread.Sleep(vrema);
                        }
                        Console.WriteLine();
                        Thread.Sleep(1000);
                    }
                }
                else if (Mesto_belki == 3)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                        Console.WriteLine("|---------| |         | |---------| |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                        Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                        Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                        Console.WriteLine("|---------| |         | |---------| |         |");
                        Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |.КАМЕНЬ..| |..БЕЛКА..| |         |");
                        Console.WriteLine("|         | |---------| |—————————| |         |");
                        Console.WriteLine(@"|         | | ___     | | _  (\_  | |         |");
                        Console.WriteLine(@"|         | ||___\_   | |( \  ( '>| |         |");
                        Console.WriteLine(@"|         | ||_____\_ | | ) \/_)= | |         |");
                        Console.WriteLine(@"|         | ||_______\| |(_(__)_  | |         |");
                        Console.WriteLine("|         | |---------| |—————————| |         |");
                        Console.WriteLine("|         | |.......5.| |.0.....1.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Console.Write("***** - ");
                        {
                            string fraza = "Выбери жертву.";
                            int vrema = 100;
                            foreach (char c in fraza)
                            {
                                Console.Write(c);
                                Thread.Sleep(vrema);
                            }
                            Console.WriteLine();
                            Thread.Sleep(1000);
                        }

                        int carta_zertvi = int.Parse(Console.ReadLine());

                        if (carta_zertvi == 3)
                        {
                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|         | |.КАМЕНЬ..| |\.БЕЛКА./| |         |");
                            Console.WriteLine(@"|         | |---------| |—\—————/—| |         |");
                            Console.WriteLine(@"|         | | ___     | |  \  (/_ | |         |");
                            Console.WriteLine(@"|         | ||___\_   | |(  \ / '>| |         |");
                            Console.WriteLine(@"|         | ||_____\_ | | ) //\)= | |         |");
                            Console.WriteLine(@"|         | ||_______\| |(_/__)\  | |         |");
                            Console.WriteLine(@"|         | |---------| |—/—————\—| |         |");
                            Console.WriteLine(@"|         | |.......5.| |/0.....1\| |         |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(1000);
                            Console.Clear();

                            void mesto()
                            {
                                karta_mestnosti();
                            }
                            mesto();

                            break;
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                    break;
                }
                else if (Mesto_belki == 4)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                        Console.WriteLine("|---------| |         | |---------| |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                        Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                        Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                        Console.WriteLine("|---------| |         | |---------| |         |");
                        Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |.КАМЕНЬ..| |         | |..БЕЛКА..|");
                        Console.WriteLine("|         | |---------| |         | |—————————|");
                        Console.WriteLine(@"|         | | ___     | |         | | _  (\_  |");
                        Console.WriteLine(@"|         | ||___\_   | |         | |( \  ( '>|");
                        Console.WriteLine(@"|         | ||_____\_ | |         | | ) \/_)= |");
                        Console.WriteLine(@"|         | ||_______\| |         | |(_(__)_  |");
                        Console.WriteLine("|         | |---------| |         | |—————————|");
                        Console.WriteLine("|         | |.......5.| |         | |.0.....1.|");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Console.Write("***** - ");
                        {
                            string fraza = "Выбери жертву.";
                            int vrema = 100;
                            foreach (char c in fraza)
                            {
                                Console.Write(c);
                                Thread.Sleep(vrema);
                            }
                            Console.WriteLine();
                            Thread.Sleep(1000);
                        }

                        int carta_zertvi = int.Parse(Console.ReadLine());

                        if (carta_zertvi == 4)
                        {
                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |ВОЛЧЁНОК.| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |—————————| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |\___/|2| |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | | |)o o(| | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |  \_0_/  | |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | |         | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |—————————| |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |.1..$..1.| |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
                            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
                            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
                            Console.WriteLine("|---------| |         | |---------| |         |");
                            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|         | |.КАМЕНЬ..| |         | |\.БЕЛКА./|");
                            Console.WriteLine(@"|         | |---------| |         | |—\—————/—|");
                            Console.WriteLine(@"|         | | ___     | |         | |  \  (/_ |");
                            Console.WriteLine(@"|         | ||___\_   | |         | |(  \ / '>|");
                            Console.WriteLine(@"|         | ||_____\_ | |         | | ) //\)= |");
                            Console.WriteLine(@"|         | ||_______\| |         | |(_/__)\  |");
                            Console.WriteLine(@"|         | |---------| |         | |—/—————\—|");
                            Console.WriteLine(@"|         | |.......5.| |         | |/0.....1\|");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(1000);
                            Console.Clear();

                            void mesto()
                            {
                                karta_mestnosti();
                            }
                            mesto();

                            break;
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                }
                break;
            }
        }     //место болки уровень 4


        static void karta_mestnosti2_ataka1_1()
        {
            Console.Clear();
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
            Console.WriteLine("|---------| |—————————| |---------| |         |");
            Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
            Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
            Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
            Console.WriteLine("|---------| |—————————| |---------| |         |");
            Console.WriteLine("|.......2.| |.1..$..1.| |.......3.| |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|ГОРНОСТАЙ| |.КАМЕНЬ..| |         | |         |");
            Console.WriteLine("|—————————| |---------| |         | |         |");
            Console.WriteLine("|        1| | ___     | |         | |         |");
            Console.WriteLine(@"| |\---/| | ||___\_   | |         | |         |");
            Console.WriteLine(@"| | -_- | | ||_____\_ | |         | |         |");
            Console.WriteLine(@"|  \_^_/  | ||_______\| |         | |         |");
            Console.WriteLine("|—————————| |---------| |         | |         |");
            Console.WriteLine("|.1.....3.| |.......4.| |         | |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
        }
        static void karta_mestnosti2_ataka1_3()
        {
            Console.Clear();
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
            Console.WriteLine("|---------| |—————————| |---------| |         |");
            Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
            Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
            Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
            Console.WriteLine("|---------| |—————————| |---------| |         |");
            Console.WriteLine("|.......3.| |.1..$..1.| |.......2.| |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|         | |.КАМЕНЬ..| |ГОРНОСТАЙ| |         |");
            Console.WriteLine("|         | |---------| |—————————| |         |");
            Console.WriteLine("|         | | ___     | |        1| |         |");
            Console.WriteLine(@"|         | ||___\_   | | |\---/| | |         |");
            Console.WriteLine(@"|         | ||_____\_ | | | -_- | | |         |");
            Console.WriteLine(@"|         | ||_______\| |  \_^_/  | |         |");
            Console.WriteLine("|         | |---------| |—————————| |         |");
            Console.WriteLine("|         | |.......4.| |.1.....3.| |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
        }
        static void karta_mestnosti2_ataka1_4()
        {
            Console.Clear();
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|..Пень...| |ВОЛЧЁНОК.| |..Пень...| |         |");
            Console.WriteLine("|---------| |—————————| |---------| |         |");
            Console.WriteLine(@"|         | | |\___/|2| |         | |         |");
            Console.WriteLine(@"| |\_  /| | | |)o o(| | | |\_  /| | |         |");
            Console.WriteLine(@"| |  \/ | | |  \_0_/  | | |  \/ | | |         |");
            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
            Console.WriteLine("|---------| |—————————| |---------| |         |");
            Console.WriteLine("|.......3.| |.1..$..1.| |.......3.| |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |ГОРНОСТАЙ|");
            Console.WriteLine("|         | |---------| |         | |—————————|");
            Console.WriteLine("|         | | ___     | |         | |        1|");
            Console.WriteLine(@"|         | ||___\_   | |         | | |\---/| |");
            Console.WriteLine(@"|         | ||_____\_ | |         | | | -_- | |");
            Console.WriteLine(@"|         | ||_______\| |         | |  \_^_/  |");
            Console.WriteLine("|         | |---------| |         | |—————————|");
            Console.WriteLine("|         | |.......4.| |         | |.1.....3.|");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
        }

        // игра
        static void bitva1()
        {
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

            Thread.Sleep(200);

            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|..Пень...| |         | |..Пень...| |         |");
            Console.WriteLine("|---------| |         | |---------| |         |");
            Console.WriteLine("|         | |         | |         | |         |");
            Console.WriteLine(@"| |\_  /| | |         | | |\_  /| | |         |");
            Console.WriteLine(@"| |  \/ | | |         | | |  \/ | | |         |");
            Console.WriteLine(@"| |_____\ | |         | | |_____\ | |         |");
            Console.WriteLine("|---------| |         | |---------| |         |");
            Console.WriteLine("|.......3.| |         | |.......3.| |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

            Thread.Sleep(200);

            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
            Console.WriteLine("|         | |.КАМЕНЬ..| |         | |         |");
            Console.WriteLine("|         | |---------| |         | |         |");
            Console.WriteLine(@"|         | | ___     | |         | |         |");
            Console.WriteLine(@"|         | ||___\_   | |         | |         |");
            Console.WriteLine(@"|         | ||_____\_ | |         | |         |");
            Console.WriteLine(@"|         | ||_______\| |         | |         |");
            Console.WriteLine("|         | |---------| |         | |         |");
            Console.WriteLine("|         | |.......5.| |         | |         |");
            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

            Console.Write("***** - ");
            {
                string te = "Ты попал в засаду по среди бездорожья.";
                int ad = 100;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.Clear();
            }
            void mesto()
            {
                karta_mestnosti();
            }
            mesto();

            Console.Write("***** - ");
            {
                string fraza = "Теперь ты можешь видеть мою предстоящую атаку.";
                int vrema = 100;
                foreach (char c in fraza)
                {
                    Console.Write(c);
                    Thread.Sleep(vrema);
                }
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.Clear();
            }
            void mesto1()
            {
                karta_mestnosti();
            }
            mesto1();
        }                            //первая полноценная битва
        static void igra1()
        {
            Thread.Sleep(500);

            Console.Clear();
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\     __/   /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |\/|  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    |__|__ ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||         \__ \   /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\         \ \ /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \        ---  ||  /\   /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\     |?|--    ||    || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    --/?/ /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||      ---  ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||        / /     /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\    / /   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||   (oo)  /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);
            Console.Write("***** - ");
            {
                string te = "Ты заблудился в лесу";
                int ad = 100;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
            }
            {
                string te = "...";
                int ad = 300;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
                Console.WriteLine();
            }
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\     __/   /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |\/|  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    |__|__ ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||         \__ \   /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\         \ \ /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \        ---  ||  /\   /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\     |?|--    ||    || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    --/?/ /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||      ---  ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||      A o /     /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   |-0\   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||   | H   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);
            Console.Write("***** - ");
            {
                string te = "Пeред тобой появилась тропинка.";
                int ad = 100;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
                Console.WriteLine();
            }
            Thread.Sleep(500);
            Console.Clear();

            Console.Clear();
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\     __/   /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |\/|  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    |__|__ ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||         \__ \   /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\         \ \ /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \        ---  ||  /\   /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\     |?|--    ||    || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    --/?/ /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||      ---  ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||      A o /     /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   |-0\   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||   | |\  /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);

            Console.Clear();
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\     __/   /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |\/|  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    |__|__ ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||         \__ \   /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\         \ \ /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \        ---  ||  /\   /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\     |?|--    ||    || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    --/?/ /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     A o   ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||        |-0\    /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\     |/|  /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    (oo) /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);

            Console.Clear();
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\     __/   /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |\/|  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    |__|__ ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||         \__ \   /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\         \ \ /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \        ---  ||  /\   /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\     |?|--    ||    || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    A o    /\   /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     |-0\   ||  /~~\/\        |");
            Console.WriteLine(@"|   /\     ||        | |\    /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\     / /  /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    (oo) /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);

            Console.Clear();
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\     __/   /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |\/|  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    |__|__ ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||         \__ \   /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\         \ \ /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \        ---  ||  /\   /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\     A o      ||    || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    |-0\   /\   /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     |/|    ||  /~~\/\        |");
            Console.WriteLine(@"|   /\     ||       / /      /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   (oo)   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    ''   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);

            Console.Clear();
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\     __/   /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |\/|  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    |__|__ ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||         \__ \   /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\         \ \ /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \        A o  ||  /\   /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\     |-0\     ||    || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    | H    /\   /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     / /    ||  /~~\/\        |");
            Console.WriteLine(@"|   /\     ||       / /      /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   (oo)   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    ''   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(@"——————————— ———————————");
            Console.WriteLine(@"|   / \   | |   / \   |");
            Console.WriteLine(@"|  0   0  | |  0   0  |");
            Console.WriteLine(@"|   \ /   | |   \ /   |");
            Console.WriteLine(@"|   / \   | |   / \   |");
            Console.WriteLine(@"|   \ /   | |   \ /   |");
            Console.WriteLine(@"|   / \   | |   / \   |");
            Console.WriteLine(@"|  0   0  | |  0   0  |");
            Console.WriteLine(@"|   \ /   | |   \ /   |");
            Console.WriteLine(@"——————————— ———————————");

            Thread.Sleep(500);
            Console.Write("***** - ");
            {
                string te = "К тебе осторожно приблизились двое лесных обитателей.";
                int ad = 100;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
                Console.WriteLine();
            }
            Thread.Sleep(500);
            Console.Clear();

            Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine(@"——————————— ———————————");
            Console.WriteLine(@"|   / \   | |   / \   |");
            Console.WriteLine(@"|  0   0  | |  0   0  |");
            Console.WriteLine(@"|   \ /   | |   \ /   |");
            Console.WriteLine(@"|   / \   | |   / \   |");
            Console.WriteLine(@"|   \ /   | |   \ /   |");
            Console.WriteLine(@"|   / \   | |   / \   |");
            Console.WriteLine(@"|  0   0  | |  0   0  |");
            Console.WriteLine(@"|   \ /   | |   \ /   |");
            Console.WriteLine(@"——————————— ———————————");

            Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine(@"    |-|     ———————————");
            Console.WriteLine(@"    | |     |   / \   |");
            Console.WriteLine(@"    | |     |  0   0  |");
            Console.WriteLine(@"    | |     |   \ /   |");
            Console.WriteLine(@"    | |     |   / \   |");
            Console.WriteLine(@"    | |     |   \ /   |");
            Console.WriteLine(@"    | |     |   / \   |");
            Console.WriteLine(@"    | |     |  0   0  |");
            Console.WriteLine(@"    | |     |   \ /   |");
            Console.WriteLine(@"    |-|     ———————————");

            Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine(@"——————————— ———————————");
            Console.WriteLine(@"|.ГАДЮКА..| |   / \   |");
            Console.WriteLine(@"|—————————| |  0   0  |");
            Console.WriteLine(@"|        2| |   \ /   |");
            Console.WriteLine(@"|  ___   /| |   / \   |");
            Console.WriteLine(@"| ('')\_//| |   \ /   |");
            Console.WriteLine(@"|  ^  \_/ | |   / \   |");
            Console.WriteLine(@"|—————————| |  0   0  |");
            Console.WriteLine(@"|.1..X..1.| |   \ /   |");
            Console.WriteLine(@"——————————— ———————————");


            Thread.Sleep(500);
            Console.Write("***** - ");
            {
                string te = "Ядовитая гадюка. Её яд смертелен для всех.";
                int ad = 100;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();

            Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine(@"——————————— ———————————");
            Console.WriteLine(@"|.ГАДЮКА..| |   / \   |");
            Console.WriteLine(@"|—————————| |  0   0  |");
            Console.WriteLine(@"|        2| |   \ /   |");
            Console.WriteLine(@"|  ___   /| |   / \   |");
            Console.WriteLine(@"| ('')\_//| |   \ /   |");
            Console.WriteLine(@"|  ^  \_/ | |   / \   |");
            Console.WriteLine(@"|—————————| |  0   0  |");
            Console.WriteLine(@"|.1..X..1.| |   \ /   |");
            Console.WriteLine(@"——————————— ———————————");

            Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine(@"———————————    |-|     ");
            Console.WriteLine(@"|.ГАДЮКА..|    | |     ");
            Console.WriteLine(@"|—————————|    | |     ");
            Console.WriteLine(@"|        2|    | |     ");
            Console.WriteLine(@"|  ___   /|    | |     ");
            Console.WriteLine(@"| ('')\_//|    | |     ");
            Console.WriteLine(@"|  ^  \_/ |    | |     ");
            Console.WriteLine(@"|—————————|    | |     ");
            Console.WriteLine(@"|.1..X..1.|    | |     ");
            Console.WriteLine(@"———————————    |-|     ");

            Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine(@"——————————— ———————————");
            Console.WriteLine(@"|.ГАДЮКА..| |..КОШКА..|");
            Console.WriteLine(@"|—————————| |—————————|");
            Console.WriteLine(@"|        2| | \    /\2|");
            Console.WriteLine(@"|  ___   /| |  )  ( ')|");
            Console.WriteLine(@"| ('')\_//| | (  /  ) |");
            Console.WriteLine(@"|  ^  \_/ | |  \(__)| |");
            Console.WriteLine(@"|—————————| |—————————|");
            Console.WriteLine(@"|.1..X..1.| |.0..%..1.|");
            Console.WriteLine(@"——————————— ———————————");

            Thread.Sleep(500);
            Console.Write("***** - ");
            {
                string te = "Бессмертная кошка. Если принести её в жертву, она не умрёт.";
                int ad = 100;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
                Console.WriteLine();
            }
            Thread.Sleep(500);

            Console.Write("***** - ");
            {
                string te = "Только 1 карта украсит твою ничтожную колоду.";
                int ad = 100;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
                Console.WriteLine();
            }

            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine(@"——————————— ———————————");
            Console.WriteLine(@"|.ГАДЮКА..| |..КОШКА..|");
            Console.WriteLine(@"|—————————| |—————————|");
            Console.WriteLine(@"|        2| | \    /\2|");
            Console.WriteLine(@"|  ___   /| |  )  ( ')|");
            Console.WriteLine(@"| ('')\_//| | (  /  ) |");
            Console.WriteLine(@"|  ^  \_/ | |  \(__)| |");
            Console.WriteLine(@"|—————————| |—————————|");
            Console.WriteLine(@"|.1..X..1.| |.0..%..1.|");
            Console.WriteLine(@"——————————— ———————————");

            Console.WriteLine("Напиши число от 1 или 2 что бы выбрать карту.");

            int Leavel3_Gagyka_ili_kosha = int.Parse(Console.ReadLine());

            Console.Clear();
            Thread.Sleep(500);
            Console.Write("***** - ");
            {
                string te = "Твой караван пополнился ещё одним существом.";
                int ad = 100;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
                Console.WriteLine();
            }

            Thread.Sleep(1000);

            Console.Clear();
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\     __/   /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |\/|  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    |__|__ ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||         \__ \   /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\         \ \ /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \        A o  ||  /\   /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\     |-0\     ||    || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    | H   /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     / /   ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||       / /      /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   (oo)   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    ''   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);
            Console.Write("***** - ");
            {
                string te = "Некоторые лесные существа пытались идти за тобой по пятам.";
                int ad = 100;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
                Console.WriteLine();
                Thread.Sleep(500);
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\     __/   /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |\/|  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    |__|__ ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||         \__ \   /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\         \ \ /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \        A o  ||  /\   /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\     |-0\     ||    || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    | H   /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     / /   ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||       / /      /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   (oo)   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    ''   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);

            Console.Clear();
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\     __/   /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |\/|  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    |__|__ ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||         \__ \   /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\         A o /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \        |-0\ ||   /\  /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\     |/|       ||   || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    ---   /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     / /   ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||       / /      /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   (oo)   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    ''   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);

            Console.Clear();
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\     __/   /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |\/|  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    |__|__ ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||         \_A o   /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\        |-0\ /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \       | |\  ||   /\  /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\    --/?/      ||   || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    ---   /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     / /   ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||       / /      /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   (oo)   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    ''   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);

            Console.Clear();
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\     __/   /\           /\        |");
            Console.WriteLine(@"| /  \   /  \   |\/|  /  \   /\    /  \  /\   |");
            Console.WriteLine(@"|  ||  /\ ||    |_A o  ||    || /\  ||  /  \  |");
            Console.WriteLine(@"|    /\||         |-0\     /\  /  \      ||   |");
            Console.WriteLine(@"|   /  \  /\      |/|--   /  \  ||  /\        |");
            Console.WriteLine(@"|    ||  /  \       |?|--  ||  /\  /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\    --/?/      ||   || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    ---   /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     / /   ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||       / /      /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   (oo)   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    ''   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);

            Console.Clear();
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\    A o    /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |-0\  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    | H__  ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||        \__ \    /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\        ---  /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \       |?|-- ||   /\  /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\    --/?/      ||   || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    ---   /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     / /   ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||       / /      /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   (oo)   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    ''   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");


            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("***** - ");
            {
                string te = "Ты нашёл оставленный кем то рюкзак.";
                int ad = 100;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
                Console.WriteLine();
                Thread.Sleep(500);
                Console.Clear();
            }

            Thread.Sleep(500);
            Console.Clear();
            Console.Write("***** - ");
            {
                string te = "Ты нашёл белку в бутылке. Разбей в экстренном случае.";
                int ad = 100;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
                Console.WriteLine();
                Thread.Sleep(500);
            }

            Console.WriteLine(" ——————————— ");
            Console.WriteLine(" |.БУТЫЛКА.| ");
            Console.WriteLine(" |---------| ");
            Console.WriteLine(" |   {-}   | ");
            Console.WriteLine(@" |  /(\_\  | ");
            Console.WriteLine(@" |  |('>|  | ");
            Console.WriteLine(@" |  |___|  | ");
            Console.WriteLine(" |         | ");
            Console.WriteLine(" |         | ");
            Console.WriteLine(" ——————————— ");

            Thread.Sleep(1000);
            Console.Write("***** - ");
            {
                string te = "Возьми ещё.";
                int ad = 100;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
                Console.WriteLine();
                Thread.Sleep(500);
                Console.Clear();
            }

            Console.WriteLine(" ——————————— ");
            Console.WriteLine(" |.БУТЫЛКА.| ");
            Console.WriteLine(" |---------| ");
            Console.WriteLine(" |   {-}   | ");
            Console.WriteLine(@" |  /(\_\  | ");
            Console.WriteLine(@" |  |('>|  | ");
            Console.WriteLine(@" |  |___|  | ");
            Console.WriteLine(" |         | ");
            Console.WriteLine(" |         | Х2 ");
            Console.WriteLine(" ——————————— ");

            Console.ReadKey();

            Console.Clear();

            Console.Write("***** - ");
            {
                string te = "Ещё один полезный инструмент. Можешь перевесить шансы в свою пользу.";
                int ad = 100;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
                Console.WriteLine();
                Thread.Sleep(500);
            }

            Console.WriteLine(@"

              /| |\
             / \ / \
             |  |  | 
            /  /_\  \
           /  /   \  \ 
           |  |   |  | 
           |  |   |  | 
           |  |   |  |
           \__/   \__/

            ");

            Console.ReadKey();
            Console.Clear();
            Console.Write("***** - ");
            {
                string te = "Больше трёх тебе не унести.";
                int ad = 100;
                foreach (char c in te)
                {
                    Console.Write(c);
                    Thread.Sleep(ad);
                }
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\    A o    /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |-0\  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    | H__  ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||        \__ \    /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\        ---  /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \       |?|-- ||   /\  /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\    --/?/      ||   || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    ---   /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     / /   ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||       / /      /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   (oo)   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    ''   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\    A o    /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |-0\  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    | H__  ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||        \__ \    /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\        ---  /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \       |?|-- ||   /\  /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\    --/?/      ||   || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    ---   /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     / /   ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||       / /      /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   (oo)   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    ''   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\         / /       /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\    A o    /\          /\         |");
            Console.WriteLine(@"| /  \   /  \   |-0\  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||    | |\_  ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||        \__ \    /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\        ---  /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \       |?|-- ||   /\  /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\    --/?/      ||   || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    ---   /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     / /   ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||       / /      /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   (oo)   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    ''   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||      ''   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\        A o        /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\    _|-0\  /\          /\         |");
            Console.WriteLine(@"| /  \   /  \  |\|/|  /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||   |__|__  ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||        \__ \    /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\        ---  /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \       |?|-- ||   /\  /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\    --/?/      ||   || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    ---   /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     / /   ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||       / /      /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   (oo)   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    ''   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||    __/  /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    (oo) /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||   A o     ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\       |-0\        /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\    __|\   /\          /\         |");
            Console.WriteLine(@"| /  \   /  \  |\/|   /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||   |__|__  ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||        \__ \    /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\        ---  /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \       |?|-- ||   /\  /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\    --/?/      ||   || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    ---   /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     / /   ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||       / /      /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   (oo)   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    ''   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");
            Console.WriteLine(@"|  /\     /\       `/\~    /\      /\    /\   |");
            Console.WriteLine(@"| /  \   /  \      ====   /  \ /\ /  \  /  \  |");
            Console.WriteLine(@"|  ||  /\ ||    /\    \ \  ||  ||  ||/\  ||   |");
            Console.WriteLine(@"|    /\||    /\/  \    \ ---    /\  /  \ /\   |");
            Console.WriteLine(@"|   /  \  /\/  \||       |?|-- /  \  ||  ||/\ |");
            Console.WriteLine(@"|    ||   || ||       __ --/?/  ||    /\  /  \|");
            Console.WriteLine(@"| /\  /\     /\      / __ ---        /  \  || |");
            Console.WriteLine(@"|/  \/  \   /  \    / /     /\    /\  ||      |");
            Console.WriteLine(@"| ||  ||   /\||   A o   /\  ||   /~~\      /\ |");
            Console.WriteLine(@"|   /\    /  \    |-0\ /  \   /\/    \    /  \|");
            Console.WriteLine(@"|  /  \    ||     | H   ||   /~~\     \/\  || |");
            Console.WriteLine(@"|   || /\        / /        /____\____/__\    |");
            Console.WriteLine(@"|  /\  || /\    __/    /\          /\         |");
            Console.WriteLine(@"| /  \   /  \  |\/|   /  \   /\   /  \  /\    |");
            Console.WriteLine(@"|  ||  /\ ||   |__|__  ||    ||/\  ||  /  \   |");
            Console.WriteLine(@"|    /\||        \__ \    /\  /  \      ||    |");
            Console.WriteLine(@"|   /  \  /\        ---  /  \  ||   /\        |");
            Console.WriteLine(@"|    ||  /  \       |?|-- ||   /\  /  \ /\    |");
            Console.WriteLine(@"| /\  /\  ||  /\    --/?/      ||   || /  \   |");
            Console.WriteLine(@"|/  \/  \    /  \    ---   /\    /\     ||    |");
            Console.WriteLine(@"| ||  ||   /\ ||     / /   ||   /~~\/\        |");
            Console.WriteLine(@"|   /\     ||       / /      /\/   /~~\       |");
            Console.WriteLine(@"|  /  \ /\    /\   (oo)   /\/~~\  /    \__/\  |");
            Console.WriteLine(@"|   ||  ||    ||    ''   /__\___\/______\/__\ |");
            Console.WriteLine(@"|——————————-———————————-———————————-——————————|");

            Thread.Sleep(500);
            Console.Clear();

            void mesto_boya()
            {
                bitva1();
            }
            mesto_boya();

            Console.Clear();

            while (true)
            {
                if (Leavel3_Gagyka_ili_kosha == 1)
                {

                    void mesto1()
                    {
                        karta_mestnosti();
                    }
                    mesto1();

                    void kaloda()
                    {
                        kaloda1();
                    }
                    kaloda();


                    Thread.Sleep(500);
                    Console.WriteLine("1) Белка.");

                    Thread.Sleep(500);
                    Console.WriteLine("2) Горностай.");

                    Thread.Sleep(500);
                    Console.WriteLine("3) Черепаха.");

                    Thread.Sleep(500);
                    Console.WriteLine("4) Гадюка.");
                }
                else
                {
                    void mesto1()
                    {
                        karta_mestnosti();
                    }
                    mesto1();

                    void kaloda()
                    {
                        kaloda2();
                    }
                    kaloda();

                    Thread.Sleep(500);
                    Console.WriteLine("1) Белка.");

                    Thread.Sleep(500);
                    Console.WriteLine("2) Горностай.");

                    Thread.Sleep(500);
                    Console.WriteLine("3) Черепаха.");

                    Thread.Sleep(500);
                    Console.WriteLine("4) Кошка.");
                }

                int vibor_karti_is_ryk = int.Parse(Console.ReadLine());

                if (vibor_karti_is_ryk != 1)
                {
                    Random random = new Random();
                    int fraza3 = random.Next(1, 4);

                    Console.Write("***** - ");

                    string text = "";
                    switch (fraza3)
                    {
                        case 1:
                            text = "этой карте нужно больше крови.";
                            break;
                        case 2:
                            text = "этим пока ходить нельзя, но вот белка бесплатная.";
                            break;
                        case 3:
                            text = "не... но ты можешь пойти белкой.";
                            break;
                    }

                    int time = 100;
                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(time);
                    }

                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }

            void mesto()
            {
                karta_mestnosti1_zertva_belki();
            }
            mesto();

            while (true)
            {
                Console.Clear();

                void mesto_gornostai1()
                {
                    karta_mestnosti();
                }
                mesto_gornostai1();

                if (Leavel3_Gagyka_ili_kosha == 1)
                {
                    void koloda()
                    {
                        kalodaA1();
                    }
                    koloda();

                    Thread.Sleep(500);
                    Console.WriteLine("1) Горностай.");

                    Thread.Sleep(500);
                    Console.WriteLine("2) Черепаха.");

                    Thread.Sleep(500);
                    Console.WriteLine("3) Гадюка.");
                }
                else
                {
                    void koloda()
                    {
                        kalodaB1();
                    }
                    koloda();

                    Thread.Sleep(500);
                    Console.WriteLine("1) Горностай.");

                    Thread.Sleep(500);
                    Console.WriteLine("2) Черепаха.");

                    Thread.Sleep(500);
                    Console.WriteLine("3) Кошка.");
                }

                int vibor_karti = int.Parse(Console.ReadLine());

                if (vibor_karti != 1)
                {
                    Console.Write("***** - ");
                    {
                        string fraza = "Этой карте нужно больше крови.";
                        int vrema = 100;
                        foreach (char c in fraza)
                        {
                            Console.Write(c);
                            Thread.Sleep(vrema);
                        }
                        Console.WriteLine();
                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }
            void bitva()
            {
                bitva_nomer_1();
            }
            bitva();
        }                             // полноценная игра 

        // обучение 
        static void Mesto_gornostai()
        {
            int mesto_gornostayi = int.Parse(Console.ReadLine());

            Thread.Sleep(1000);
            Console.Clear();

            if (mesto_gornostayi == 1)
            {
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine(@"|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine(@"|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Thread.Sleep(2000);
                Console.Clear();

                Thread.Sleep(500);
                Console.WriteLine(@"———————————");
                Console.WriteLine(@"|ГОРНОСТАЙ|");
                Console.WriteLine(@"|—————————|");
                Console.WriteLine(@"|        1|");
                Console.WriteLine(@"| |\---/| |");
                Console.WriteLine(@"| | -_- | |");
                Console.WriteLine(@"|  \_^_/  |");
                Console.WriteLine(@"|—————————|");
                Console.WriteLine(@"|.1.....3.|");
                Console.WriteLine(@"———————————");

                Thread.Sleep(3000);
                Console.Write("***** - ");
                {
                    string te = "В левом нижнем углу написаны очки атаки: 1.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                Console.WriteLine("|—————————| |         | |         | |         |");
                Console.WriteLine("|        1| |         | |         | |         |");
                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                Console.WriteLine("| | -_- | | |         | |         | |         |");
                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                Console.WriteLine("|—————————| |         | |         | |         |");
                Console.WriteLine("|.1.....3.| |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(2000);
                Console.Write("***** - ");
                {
                    string te = "Твой Горностай остался один.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                while (true)
                {
                    Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                    ConsoleKeyInfo keyinfo = Console.ReadKey();

                    if (keyinfo.Key == ConsoleKey.Tab)
                    {
                        while (true)
                        {

                            Thread.Sleep(250);

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"——————————— |         | |         | |         |");
                            Console.WriteLine(@"|   / \   | |         | |         | |         |");
                            Console.WriteLine(@"|  /   \  | |         | |         | |         |");
                            Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                            Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                            Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                            Console.WriteLine(@"| -|___|- | |         | |         | |         |");
                            Console.WriteLine(@"|   | |   | |         | |         | |         |");
                            Console.WriteLine(@"|   | |   | ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   (*)   |");
                            Console.WriteLine(@"-----------");

                            Thread.Sleep(250);

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   / \   | ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|  /   \  | |         | |         | |         |");
                            Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                            Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                            Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                            Console.WriteLine(@"| -|___|- | |         | |         | |         |");
                            Console.WriteLine(@"|   | |   | |         | |         | |         |");
                            Console.WriteLine(@"|   | |   | |         | |         | |         |");
                            Console.WriteLine(@"|   (*)   | |         | |         | |         |");
                            Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                            Thread.Sleep(250);

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                            Console.WriteLine("|—————————| |         | |         | |         |");
                            Console.WriteLine("|        1| |         | |         | |         |");
                            Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                            Console.WriteLine("| | -_- | | |         | |         | |         |");
                            Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                            Console.WriteLine("|—————————| |         | |         | |         |");
                            Console.WriteLine("|.1.....3.| |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Thread.Sleep(250);
                            break;
                        }
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                        Console.WriteLine("|—————————| |         | |         | |         |");
                        Console.WriteLine("|        1| |         | |         | |         |");
                        Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                        Console.WriteLine("| | -_- | | |         | |         | |         |");
                        Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                        Console.WriteLine("|—————————| |         | |         | |         |");
                        Console.WriteLine("|.1.....3.| |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(500);

                        Console.WriteLine(@"———————————  ———————————");
                        Console.WriteLine(@"|...Волк..|  |...Волк..|");
                        Console.WriteLine(@"|—————————|  |—————————|");
                        Console.WriteLine(@"||\_____/2|  ||\_____/2|");
                        Console.WriteLine(@"||)     (||  ||)     (||");
                        Console.WriteLine(@"| \ o o / |  | \ o o / |");
                        Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |");
                        Console.WriteLine(@"|—————————|  |—————————|");
                        Console.WriteLine(@"|.3.....2.|  |.3.....2.|");
                        Console.WriteLine(@"———————————  ———————————");

                        Console.Write("***** - ");
                        {
                            string te = "Тебе нечем ходить. У тебя нет существ которых можно отдать в жертву.";
                            int ab = 100;

                            foreach (char c in te)
                            {
                                Console.Write(c);
                                Thread.Sleep(ab);
                            }
                            Console.WriteLine();
                        }
                    }
                }
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Твой Горностай нанёс мне 1 единицу урона. Я добавил её на весы.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Console.Clear();

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(@"
                               _____________                                                 
                             _/. . . + . . .\_
                           _/.       ^       .\_ 
                          /+         |         +\
                         |___________|___________|
                                    | |
                                    | |
               _____________________|_|_____________________
              /_____________________________________________\
             /_|                    | |                    |_\
               |                   /   \                    |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
              / \                 |     |                  / \
             /   \                |     |                 /   \ 
            /     \               |     |                /     \
           /       \              |     |               /       \
          |---------|             |     |              |---------|
          |         |             |     |              |         |
          |---------|             |     |              |---------|
                                  |     |
                                  |     |
                                  |     |
                                  |     |
                                 /       \
                                /         \
                               /___________\");

                    Thread.Sleep(500);

                    Console.Clear();
                    Console.WriteLine(@"
                               _____________                                                 
                             _/. . . + . . .\_
                           _/.         ^     .\_ 
                          /+          /        +\
                         |___________/___________|
                                    | |
                                    | |
               _____________________|_|_____________________
              /_____________________________________________\
             /_|                    | |                    |_\
               |                   /   \                    |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
              / \                 |     |                   |
             /   \                |     |                  / \
            /     \               |     |                 /   \ 
           /       \              |     |                /     \
          |---------|             |     |               /       \
          |         |             |     |              |---------|
          |---------|             |     |              |*        |
                                  |     |              |---------|
                                  |     |
                                  |     |
                                  |     |
                                  |     |
                                 /       \
                                /         \
                               /___________\");

                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                Thread.Sleep(2000);
                Console.Write("***** - ");
                {
                    string te = "Ты победишь, когда моя чаша весов перевесит твою.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Вот так: ";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine(@"
                               _____________                                                 
                             _/. . . + . . .\_
                           _/.               .\_ 
                          /+          _______> +\
                         |___________/___________|
                                    | |
                                    | |
               _____________________|_|_____________________
              /_____________________________________________\
             /_|                    | |                    |_\
              / \                  /   \                    |
             /   \                |     |                   |
            /     \               |     |                   |
           /       \              |     |                   |
          |---------|             |     |                   |
          |         |             |     |                   |
          |---------|             |     |                   |
                                  |     |                   |
                                  |     |                   |                         
                                  |     |                  / \
                                  |     |                 /   \ 
                                  |     |                /     \
                                  |     |               /       \
                                  |     |              |---------|
                                  |     |              |*        |
                                  |     |              |---------|
                                  |     |
                                  |     |
                                  |     |
                                 /       \
                                /         \
                               /___________\");

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                Console.WriteLine("|—————————| |         | |         | |         |");
                Console.WriteLine("|        1| |         | |         | |         |");
                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                Console.WriteLine("| | -_- | | |         | |         | |         |");
                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                Console.WriteLine("|—————————| |         | |         | |         |");
                Console.WriteLine("|.1.....3.| |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Мой ход. ";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(1500);
                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|..КАЙОТ..| |         | |         | |         |");
                Console.WriteLine(@"|—————————| |         | |         | |         |");
                Console.WriteLine(@"|         | |         | |         | |         |");
                Console.WriteLine(@"|  /\_/\  | |         | |         | |         |");
                Console.WriteLine(@"|  (o o)  | |         | |         | |         |");
                Console.WriteLine(@"| (--Y--) | |         | |         | |         |");
                Console.WriteLine(@"|—————————| |         | |         | |         |");
                Console.WriteLine(@"|.2.....1.| |         | |         | |         |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                Console.WriteLine("|—————————| |         | |         | |         |");
                Console.WriteLine("|        1| |         | |         | |         |");
                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                Console.WriteLine("| | -_- | | |         | |         | |         |");
                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                Console.WriteLine("|—————————| |         | |         | |         |");
                Console.WriteLine("|.1.....3.| |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Твой Горностай встал перед моим Кайотом.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Console.Clear();

                while (true)
                {

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|..КАЙОТ..| |         | |         | |         |");
                    Console.WriteLine(@"|—————————| |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|  /\_/\  | |         | |         | |         |");
                    Console.WriteLine(@"|  (o o)  | |         | |         | |         |");
                    Console.WriteLine(@"| (--Y--) | |         | |         | |         |");
                    Console.WriteLine(@"|—————————| |         | |         | |         |");
                    Console.WriteLine(@"|.2.....1.| |         | |         | |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|        1| |         | |         | |         |");
                    Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                    Console.WriteLine("| | -_- | | |         | |         | |         |");
                    Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|.1.....3.| |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"----------- ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   (*)   | ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |         | |         | |         |");
                    Console.WriteLine(@"|   | |   | |         | |         | |         |");
                    Console.WriteLine(@"| -|---|- | |         | |         | |         |");
                    Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                    Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                    Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                    Console.WriteLine(@"|  \   /  | |         | |         | |         |");
                    Console.WriteLine(@"|   \ /   | |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"| _______ | |         | |         | |         |");
                    Console.WriteLine(@"||       || |         | |         | |         |");
                    Console.WriteLine(@"||  /-\  || |         | |         | |         |");
                    Console.WriteLine(@"| \ \_/ / | |         | |         | |         |");
                    Console.WriteLine(@"|  \   /  | |         | |         | |         |");
                    Console.WriteLine(@"|   \_/   | |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                    Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                    Console.WriteLine(@"|   (*)   | |         | |         | |         |");
                    Console.WriteLine(@"|   | |   | |         | |         | |         |");
                    Console.WriteLine(@"|   | |   | |         | |         | |         |");
                    Console.WriteLine(@"| -|---|- | |         | |         | |         |");
                    Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                    Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                    Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                    Console.WriteLine(@"|  \   /  | |         | |         | |         |");
                    Console.WriteLine(@"|   \ /   | ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"| _______ | |         | |         | |         |");
                    Console.WriteLine(@"||       || |         | |         | |         |");
                    Console.WriteLine(@"||  /-\  || |         | |         | |         |");
                    Console.WriteLine(@"| \ \_/ / | |         | |         | |         |");
                    Console.WriteLine(@"|  \   /  | |         | |         | |         |");
                    Console.WriteLine(@"|   \_/   | |         | |         | |         |");
                    Console.WriteLine(@"|         | ——————————— ——————————— ———————————");
                    Console.WriteLine(@"———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|..КАЙОТ..| |         | |         | |         |");
                    Console.WriteLine(@"|—————————| |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|  /\_/\  | |         | |         | |         |");
                    Console.WriteLine(@"|  (o o)  | |         | |         | |         |");
                    Console.WriteLine(@"| (--Y--) | |         | |         | |         |");
                    Console.WriteLine(@"|—————————| |         | |         | |         |");
                    Console.WriteLine(@"|.2.....1.| |         | |         | |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|        1| |         | |         | |         |");
                    Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                    Console.WriteLine("| | -_- | | |         | |         | |         |");
                    Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|.1.....1.| |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    break;
                }

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Мой Кайот нанёс твоему Горностаю 2 единицы урона.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Значит, здоровье твоего Горностая уменьшилось на 2 единицы.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Если здоровье снизится до нуля то существо умрёт.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Снова твой ход.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(1500);
                Console.Clear();
                Console.Write("***** - ");
                {
                    string te = "Можешь взять белку или же карту из своей колоды.";
                    int ab = 100;
                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(@"——————————— ———————————");
                Console.WriteLine(@"|   / \   | |         |");
                Console.WriteLine(@"|  0   0  | |         |");
                Console.WriteLine(@"|   \ /   | |  C...C  |");
                Console.WriteLine(@"|   / \   | | ( . . ) |");
                Console.WriteLine(@"|   \ /   | |  \   /  |");
                Console.WriteLine(@"|   / \   | |   `o`   |");
                Console.WriteLine(@"|  0   0  | |         |");
                Console.WriteLine(@"|   \ /   | |         |");
                Console.WriteLine(@"——————————— ———————————");

                Console.WriteLine("1) Своя карта.");
                Console.WriteLine("2) Белка.");

                int Karta = int.Parse(Console.ReadLine());
                Console.Clear();

                if (Karta == 1)
                {
                    Console.Clear();
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|..КАЙОТ..| |         | |         | |         |");
                    Console.WriteLine(@"|—————————| |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|  /\_/\  | |         | |         | |         |");
                    Console.WriteLine(@"|  (o o)  | |         | |         | |         |");
                    Console.WriteLine(@"| (--Y--) | |         | |         | |         |");
                    Console.WriteLine(@"|—————————| |         | |         | |         |");
                    Console.WriteLine(@"|.2.....1.| |         | |         | |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|        1| |         | |         | |         |");
                    Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                    Console.WriteLine("| | -_- | | |         | |         | |         |");
                    Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|.1.....1.| |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(1000);

                    Console.WriteLine(@"———————————  ———————————  -----------");
                    Console.WriteLine(@"|...Волк..|  |...Волк..|  |...Жаба..|");
                    Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                    Console.WriteLine(@"||\_____/2|  ||\_____/2|  |    00  1|");
                    Console.WriteLine(@"||)     (||  ||)     (||  |   (--)  |");
                    Console.WriteLine(@"| \ o o / |  | \ o o / |  |  ( || ) |");
                    Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |  ^^~~^^ |");
                    Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                    Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.1.....2.|");
                    Console.WriteLine(@"———————————  ———————————  -----------");

                    while (true)
                    {
                        Console.WriteLine("Что бы начать атаку нажми на Tab");
                        ConsoleKeyInfo keyinfo = Console.ReadKey();

                        if (keyinfo.Key == ConsoleKey.Tab)
                        {
                            while (true)
                            {
                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|..КАЙОТ..| |         | |         | |         |");
                                Console.WriteLine(@"|—————————| |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine(@"|  /\_/\  | |         | |         | |         |");
                                Console.WriteLine(@"|  (o o)  | |         | |         | |         |");
                                Console.WriteLine(@"| (--Y--) | |         | |         | |         |");
                                Console.WriteLine(@"|—————————| |         | |         | |         |");
                                Console.WriteLine(@"|.2.....1.| |         | |         | |         |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|        1| |         | |         | |         |");
                                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                                Console.WriteLine("| | -_- | | |         | |         | |         |");
                                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|.1.....1.| |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("| _______ | |         | |         | |         |");
                                Console.WriteLine("||       || |         | |         | |         |");
                                Console.WriteLine(@"||  /-\  || |         | |         | |         |");
                                Console.WriteLine(@"| \ \_/ / | |         | |         | |         |");
                                Console.WriteLine(@"|  \   /  | |         | |         | |         |");
                                Console.WriteLine(@"|   \_/   | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"——————————— |         | |         | |         |");
                                Console.WriteLine(@"|   / \   | |         | |         | |         |");
                                Console.WriteLine(@"|  /   \  | |         | |         | |         |");
                                Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                                Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                                Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                                Console.WriteLine(@"| -|___|- | |         | |         | |         |");
                                Console.WriteLine(@"|   | |   | |         | |         | |         |");
                                Console.WriteLine(@"|   | |   | ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   (*)   |");
                                Console.WriteLine(@"-----------");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | ——————————— ——————————— ———————————");
                                Console.WriteLine("| _______ | |         | |         | |         |");
                                Console.WriteLine("||       || |         | |         | |         |");
                                Console.WriteLine(@"||  /-\  || |         | |         | |         |");
                                Console.WriteLine(@"| \ \_/ / | |         | |         | |         |");
                                Console.WriteLine(@"|  \   /  | |         | |         | |         |");
                                Console.WriteLine(@"|   \_/   | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   / \   | ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|  /   \  | |         | |         | |         |");
                                Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                                Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                                Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                                Console.WriteLine(@"| -|___|- | |         | |         | |         |");
                                Console.WriteLine(@"|   | |   | |         | |         | |         |");
                                Console.WriteLine(@"|   | |   | |         | |         | |         |");
                                Console.WriteLine(@"|   (*)   | |         | |         | |         |");
                                Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|  _____  | |         | |         | |         |");
                                Console.WriteLine(@"| /     \ | |         | |         | |         |");
                                Console.WriteLine("| | * * | | |         | |         | |         |");
                                Console.WriteLine(@"| \  #  / | |         | |         | |         |");
                                Console.WriteLine("|  |_|_|  | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|        1| |         | |         | |         |");
                                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                                Console.WriteLine("| | -_- | | |         | |         | |         |");
                                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|.1.....1.| |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|---------| |         | |         | |         |");
                                Console.WriteLine("|| _____ || |         | |         | |         |");
                                Console.WriteLine(@"||/     \|| |         | |         | |         |");
                                Console.WriteLine("||| * * ||| |         | |         | |         |");
                                Console.WriteLine(@"||\  #  /|| |         | |         | |         |");
                                Console.WriteLine("|| |_|_| || |         | |         | |         |");
                                Console.WriteLine("||       || |         | |         | |         |");
                                Console.WriteLine("|---------| |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|        1| |         | |         | |         |");
                                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                                Console.WriteLine("| | -_- | | |         | |         | |         |");
                                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|.1.....1.| |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("| ------- | |         | |         | |         |");
                                Console.WriteLine(@"| |/   \| | |         | |         | |         |");
                                Console.WriteLine("| ||* *|| | |         | |         | |         |");
                                Console.WriteLine(@"| |\ # /| | |         | |         | |         |");
                                Console.WriteLine("| ||_|_|| | |         | |         | |         |");
                                Console.WriteLine("| ------- | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|        1| |         | |         | |         |");
                                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                                Console.WriteLine("| | -_- | | |         | |         | |         |");
                                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|.1.....1.| |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|  -----  | |         | |         | |         |");
                                Console.WriteLine("|  ||*||  | |         | |         | |         |");
                                Console.WriteLine(@"|  |\ /|  | |         | |         | |         |");
                                Console.WriteLine("|  -----  | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|        1| |         | |         | |         |");
                                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                                Console.WriteLine("| | -_- | | |         | |         | |         |");
                                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|.1.....1.| |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|        1| |         | |         | |         |");
                                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                                Console.WriteLine("| | -_- | | |         | |         | |         |");
                                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|.1.....1.| |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                break;
                            }
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|..КАЙОТ..| |         | |         | |         |");
                            Console.WriteLine(@"|—————————| |         | |         | |         |");
                            Console.WriteLine(@"|         | |         | |         | |         |");
                            Console.WriteLine(@"|  /\_/\  | |         | |         | |         |");
                            Console.WriteLine(@"|  (o o)  | |         | |         | |         |");
                            Console.WriteLine(@"| (--Y--) | |         | |         | |         |");
                            Console.WriteLine(@"|—————————| |         | |         | |         |");
                            Console.WriteLine(@"|.2.....1.| |         | |         | |         |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                            Console.WriteLine("|—————————| |         | |         | |         |");
                            Console.WriteLine("|        1| |         | |         | |         |");
                            Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                            Console.WriteLine("| | -_- | | |         | |         | |         |");
                            Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                            Console.WriteLine("|—————————| |         | |         | |         |");
                            Console.WriteLine("|.1.....1.| |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(500);

                            Console.WriteLine(@"———————————  ———————————  -----------");
                            Console.WriteLine(@"|...Волк..|  |...Волк..|  |...Жаба..|");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"||\_____/2|  ||\_____/2|  |    00  1|");
                            Console.WriteLine(@"||)     (||  ||)     (||  |   (--)  |");
                            Console.WriteLine(@"| \ o o / |  | \ o o / |  |  ( || ) |");
                            Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |  ^^~~^^ |");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.1.....2.|");
                            Console.WriteLine(@"———————————  ———————————  -----------");

                            Console.Write("***** - ");
                            {
                                string te = "Из-за лени автора тебе нечем ходить.";
                                int ab = 100;

                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ab);
                                }
                                Console.WriteLine();
                            }
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                    }
                }
                else
                {
                    while (true)
                    {

                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|..КАЙОТ..| |         | |         | |         |");
                        Console.WriteLine(@"|—————————| |         | |         | |         |");
                        Console.WriteLine(@"|         | |         | |         | |         |");
                        Console.WriteLine(@"|  /\_/\  | |         | |         | |         |");
                        Console.WriteLine(@"|  (o o)  | |         | |         | |         |");
                        Console.WriteLine(@"| (--Y--) | |         | |         | |         |");
                        Console.WriteLine(@"|—————————| |         | |         | |         |");
                        Console.WriteLine(@"|.2.....1.| |         | |         | |         |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                        Console.WriteLine("|—————————| |         | |         | |         |");
                        Console.WriteLine("|        1| |         | |         | |         |");
                        Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                        Console.WriteLine("| | -_- | | |         | |         | |         |");
                        Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                        Console.WriteLine("|—————————| |         | |         | |         |");
                        Console.WriteLine("|.1.....1.| |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(1000);

                        Console.WriteLine(@"———————————  ———————————  -----------");
                        Console.WriteLine(@"|...Волк..|  |...Волк..|  |..БЕЛКА..|");
                        Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                        Console.WriteLine(@"||\_____/2|  ||\_____/2|  | _  (\_  |");
                        Console.WriteLine(@"||)     (||  ||)     (||  |( \  ( '>|");
                        Console.WriteLine(@"| \ o o / |  | \ o o / |  | ) \/_)= |");
                        Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |(_(__)_  |");
                        Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                        Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.0.....1.|");
                        Console.WriteLine(@"———————————  ———————————  -----------");

                        Console.WriteLine("Что бы начать атаку нажми на Tab");
                        ConsoleKeyInfo keyinfo = Console.ReadKey();

                        if (keyinfo.Key == ConsoleKey.Tab)
                        {
                            while (true)
                            {
                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|..КАЙОТ..| |         | |         | |         |");
                                Console.WriteLine(@"|—————————| |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine(@"|  /\_/\  | |         | |         | |         |");
                                Console.WriteLine(@"|  (o o)  | |         | |         | |         |");
                                Console.WriteLine(@"| (--Y--) | |         | |         | |         |");
                                Console.WriteLine(@"|—————————| |         | |         | |         |");
                                Console.WriteLine(@"|.2.....1.| |         | |         | |         |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|        1| |         | |         | |         |");
                                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                                Console.WriteLine("| | -_- | | |         | |         | |         |");
                                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|.1.....1.| |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("| _______ | |         | |         | |         |");
                                Console.WriteLine("||       || |         | |         | |         |");
                                Console.WriteLine(@"||  /-\  || |         | |         | |         |");
                                Console.WriteLine(@"| \ \_/ / | |         | |         | |         |");
                                Console.WriteLine(@"|  \   /  | |         | |         | |         |");
                                Console.WriteLine(@"|   \_/   | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"——————————— |         | |         | |         |");
                                Console.WriteLine(@"|   / \   | |         | |         | |         |");
                                Console.WriteLine(@"|  /   \  | |         | |         | |         |");
                                Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                                Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                                Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                                Console.WriteLine(@"| -|___|- | |         | |         | |         |");
                                Console.WriteLine(@"|   | |   | |         | |         | |         |");
                                Console.WriteLine(@"|   | |   | ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   (*)   |");
                                Console.WriteLine(@"-----------");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | ——————————— ——————————— ———————————");
                                Console.WriteLine("| _______ | |         | |         | |         |");
                                Console.WriteLine("||       || |         | |         | |         |");
                                Console.WriteLine(@"||  /-\  || |         | |         | |         |");
                                Console.WriteLine(@"| \ \_/ / | |         | |         | |         |");
                                Console.WriteLine(@"|  \   /  | |         | |         | |         |");
                                Console.WriteLine(@"|   \_/   | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   / \   | ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|  /   \  | |         | |         | |         |");
                                Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                                Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                                Console.WriteLine(@"|  |   |  | |         | |         | |         |");
                                Console.WriteLine(@"| -|___|- | |         | |         | |         |");
                                Console.WriteLine(@"|   | |   | |         | |         | |         |");
                                Console.WriteLine(@"|   | |   | |         | |         | |         |");
                                Console.WriteLine(@"|   (*)   | |         | |         | |         |");
                                Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|  _____  | |         | |         | |         |");
                                Console.WriteLine(@"| /     \ | |         | |         | |         |");
                                Console.WriteLine("| | * * | | |         | |         | |         |");
                                Console.WriteLine(@"| \  #  / | |         | |         | |         |");
                                Console.WriteLine("|  |_|_|  | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|        1| |         | |         | |         |");
                                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                                Console.WriteLine("| | -_- | | |         | |         | |         |");
                                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|.1.....1.| |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|---------| |         | |         | |         |");
                                Console.WriteLine("|| _____ || |         | |         | |         |");
                                Console.WriteLine(@"||/     \|| |         | |         | |         |");
                                Console.WriteLine("||| * * ||| |         | |         | |         |");
                                Console.WriteLine(@"||\  #  /|| |         | |         | |         |");
                                Console.WriteLine("|| |_|_| || |         | |         | |         |");
                                Console.WriteLine("||       || |         | |         | |         |");
                                Console.WriteLine("|---------| |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|        1| |         | |         | |         |");
                                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                                Console.WriteLine("| | -_- | | |         | |         | |         |");
                                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|.1.....1.| |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("| ------- | |         | |         | |         |");
                                Console.WriteLine(@"| |/   \| | |         | |         | |         |");
                                Console.WriteLine("| ||* *|| | |         | |         | |         |");
                                Console.WriteLine(@"| |\ # /| | |         | |         | |         |");
                                Console.WriteLine("| ||_|_|| | |         | |         | |         |");
                                Console.WriteLine("| ------- | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|        1| |         | |         | |         |");
                                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                                Console.WriteLine("| | -_- | | |         | |         | |         |");
                                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|.1.....1.| |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|  -----  | |         | |         | |         |");
                                Console.WriteLine("|  ||*||  | |         | |         | |         |");
                                Console.WriteLine(@"|  |\ /|  | |         | |         | |         |");
                                Console.WriteLine("|  -----  | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|        1| |         | |         | |         |");
                                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                                Console.WriteLine("| | -_- | | |         | |         | |         |");
                                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|.1.....1.| |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|        1| |         | |         | |         |");
                                Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                                Console.WriteLine("| | -_- | | |         | |         | |         |");
                                Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                                Console.WriteLine("|—————————| |         | |         | |         |");
                                Console.WriteLine("|.1.....1.| |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                break;
                            }
                            break;
                        }
                        else
                        {

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|..КАЙОТ..| |         | |         | |         |");
                            Console.WriteLine(@"|—————————| |         | |         | |         |");
                            Console.WriteLine(@"|         | |         | |         | |         |");
                            Console.WriteLine(@"|  /\_/\  | |         | |         | |         |");
                            Console.WriteLine(@"|  (o o)  | |         | |         | |         |");
                            Console.WriteLine(@"| (--Y--) | |         | |         | |         |");
                            Console.WriteLine(@"|—————————| |         | |         | |         |");
                            Console.WriteLine(@"|.2.....1.| |         | |         | |         |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|ГОРНОСТАЙ| |         | |         | |         |");
                            Console.WriteLine("|—————————| |         | |         | |         |");
                            Console.WriteLine("|        1| |         | |         | |         |");
                            Console.WriteLine(@"| |\---/| | |         | |         | |         |");
                            Console.WriteLine("| | -_- | | |         | |         | |         |");
                            Console.WriteLine(@"|  \_^_/  | |         | |         | |         |");
                            Console.WriteLine("|—————————| |         | |         | |         |");
                            Console.WriteLine("|.1.....1.| |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(500);

                            Console.WriteLine(@"———————————  ———————————  -----------");
                            Console.WriteLine(@"|...Волк..|  |...Волк..|  |..БЕЛКА..|");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"||\_____/2|  ||\_____/2|  | _  (\_  |");
                            Console.WriteLine(@"||)     (||  ||)     (||  |( \  ( '>|");
                            Console.WriteLine(@"| \ o o / |  | \ o o / |  | ) \/_)= |");
                            Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |(_(__)_  |");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.0.....1.|");
                            Console.WriteLine(@"———————————  ———————————  -----------");

                            Console.Write("***** - ");
                            {
                                string te = "Из-за лени автора тебе нечем ходить.";
                                int ab = 100;

                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ab);
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            else if (mesto_gornostayi == 2)
            {
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine(@"|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine(@"|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Thread.Sleep(2000);
                Console.Clear();

                Thread.Sleep(500);
                Console.WriteLine(@"———————————");
                Console.WriteLine(@"|ГОРНОСТАЙ|");
                Console.WriteLine(@"|—————————|");
                Console.WriteLine(@"|        1|");
                Console.WriteLine(@"| |\---/| |");
                Console.WriteLine(@"| | -_- | |");
                Console.WriteLine(@"|  \_^_/  |");
                Console.WriteLine(@"|—————————|");
                Console.WriteLine(@"|.1.....3.|");
                Console.WriteLine(@"———————————");

                Thread.Sleep(3000);
                Console.Write("***** - ");
                {
                    string te = "В левом нижнем углу написаны очки атаки: 1.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                Console.WriteLine("|         | |—————————| |         | |         |");
                Console.WriteLine("|         | |        1| |         | |         |");
                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                Console.WriteLine("|         | | | -_- | | |         | |         |");
                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                Console.WriteLine("|         | |—————————| |         | |         |");
                Console.WriteLine("|         | |.1.....3.| |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(2000);
                Console.Write("***** - ");
                {
                    string te = "Твой Горностай остался один.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                while (true)
                {
                    Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                    ConsoleKeyInfo keyinfo = Console.ReadKey();

                    if (keyinfo.Key == ConsoleKey.Tab)
                    {
                        while (true)
                        {

                            Thread.Sleep(250);

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|         | ——————————— |         | |         |");
                            Console.WriteLine(@"|         | |   / \   | |         | |         |");
                            Console.WriteLine(@"|         | |  /   \  | |         | |         |");
                            Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                            Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                            Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                            Console.WriteLine(@"|         | | -|___|- | |         | |         |");
                            Console.WriteLine(@"|         | |   | |   | |         | |         |");
                            Console.WriteLine(@"----------- |   | |   | ——————————— ———————————");
                            Console.WriteLine(@"            |   (*)   |");
                            Console.WriteLine(@"            -----------");

                            Thread.Sleep(250);

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"----------- |   / \   | ——————————— ———————————");
                            Console.WriteLine(@"|         | |  /   \  | |         | |         |");
                            Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                            Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                            Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                            Console.WriteLine(@"|         | | -|___|- | |         | |         |");
                            Console.WriteLine(@"|         | |   | |   | |         | |         |");
                            Console.WriteLine(@"|         | |   | |   | |         | |         |");
                            Console.WriteLine(@"|         | |   (*)   | |         | |         |");
                            Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                            Thread.Sleep(250);

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                            Console.WriteLine("|         | |—————————| |         | |         |");
                            Console.WriteLine("|         | |        1| |         | |         |");
                            Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                            Console.WriteLine("|         | | | -_- | | |         | |         |");
                            Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                            Console.WriteLine("|         | |—————————| |         | |         |");
                            Console.WriteLine("|         | |.1.....3.| |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Thread.Sleep(250);
                            break;
                        }
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                        Console.WriteLine("|         | |—————————| |         | |         |");
                        Console.WriteLine("|         | |        1| |         | |         |");
                        Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                        Console.WriteLine("|         | | | -_- | | |         | |         |");
                        Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                        Console.WriteLine("|         | |—————————| |         | |         |");
                        Console.WriteLine("|         | |.1.....3.| |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(500);

                        Console.WriteLine(@"———————————  ———————————");
                        Console.WriteLine(@"|...Волк..|  |...Волк..|");
                        Console.WriteLine(@"|—————————|  |—————————|");
                        Console.WriteLine(@"||\_____/2|  ||\_____/2|");
                        Console.WriteLine(@"||)     (||  ||)     (||");
                        Console.WriteLine(@"| \ o o / |  | \ o o / |");
                        Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |");
                        Console.WriteLine(@"|—————————|  |—————————|");
                        Console.WriteLine(@"|.3.....2.|  |.3.....2.|");
                        Console.WriteLine(@"———————————  ———————————");

                        Console.Write("***** - ");
                        {
                            string te = "Тебе нечем ходить. У тебя нет существ которых можно отдать в жертву.";
                            int ab = 100;

                            foreach (char c in te)
                            {
                                Console.Write(c);
                                Thread.Sleep(ab);
                            }
                            Console.WriteLine();
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Твой Горностай нанёс мне 1 единицу урона. Я добавил её на весы.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Console.Clear();

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(@"
                               _____________                                                 
                             _/. . . + . . .\_
                           _/.       ^       .\_ 
                          /+         |         +\
                         |___________|___________|
                                    | |
                                    | |
               _____________________|_|_____________________
              /_____________________________________________\
             /_|                    | |                    |_\
               |                   /   \                    |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
              / \                 |     |                  / \
             /   \                |     |                 /   \ 
            /     \               |     |                /     \
           /       \              |     |               /       \
          |---------|             |     |              |---------|
          |         |             |     |              |         |
          |---------|             |     |              |---------|
                                  |     |
                                  |     |
                                  |     |
                                  |     |
                                 /       \
                                /         \
                               /___________\");

                    Thread.Sleep(500);

                    Console.Clear();
                    Console.WriteLine(@"
                               _____________                                                 
                             _/. . . + . . .\_
                           _/.         ^     .\_ 
                          /+          /        +\
                         |___________/___________|
                                    | |
                                    | |
               _____________________|_|_____________________
              /_____________________________________________\
             /_|                    | |                    |_\
               |                   /   \                    |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
              / \                 |     |                   |
             /   \                |     |                  / \
            /     \               |     |                 /   \ 
           /       \              |     |                /     \
          |---------|             |     |               /       \
          |         |             |     |              |---------|
          |---------|             |     |              |*        |
                                  |     |              |---------|
                                  |     |
                                  |     |
                                  |     |
                                  |     |
                                 /       \
                                /         \
                               /___________\");

                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                Thread.Sleep(2000);
                Console.Write("***** - ");
                {
                    string te = "Ты победишь, когда моя чаша весов перевесит твою.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Вот так: ";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine(@"
                               _____________                                                 
                             _/. . . + . . .\_
                           _/.               .\_ 
                          /+          _______> +\
                         |___________/___________|
                                    | |
                                    | |
               _____________________|_|_____________________
              /_____________________________________________\
             /_|                    | |                    |_\
              / \                  /   \                    |
             /   \                |     |                   |
            /     \               |     |                   |
           /       \              |     |                   |
          |---------|             |     |                   |
          |         |             |     |                   |
          |---------|             |     |                   |
                                  |     |                   |
                                  |     |                   |                         
                                  |     |                  / \
                                  |     |                 /   \ 
                                  |     |                /     \
                                  |     |               /       \
                                  |     |              |---------|
                                  |     |              |*        |
                                  |     |              |---------|
                                  |     |
                                  |     |
                                  |     |
                                 /       \
                                /         \
                               /___________\");

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                Console.WriteLine("|         | |—————————| |         | |         |");
                Console.WriteLine("|         | |        1| |         | |         |");
                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                Console.WriteLine("|         | | | -_- | | |         | |         |");
                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                Console.WriteLine("|         | |—————————| |         | |         |");
                Console.WriteLine("|         | |.1.....3.| |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(500);
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Мой ход. ";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(1500);
                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|         | |..КАЙОТ..| |         | |         |");
                Console.WriteLine(@"|         | |—————————| |         | |         |");
                Console.WriteLine(@"|         | |         | |         | |         |");
                Console.WriteLine(@"|         | |  /\_/\  | |         | |         |");
                Console.WriteLine(@"|         | |  (o o)  | |         | |         |");
                Console.WriteLine(@"|         | | (--Y--) | |         | |         |");
                Console.WriteLine(@"|         | |—————————| |         | |         |");
                Console.WriteLine(@"|         | |.2.....1.| |         | |         |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                Console.WriteLine("|         | |—————————| |         | |         |");
                Console.WriteLine("|         | |        1| |         | |         |");
                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                Console.WriteLine("|         | | | -_- | | |         | |         |");
                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                Console.WriteLine("|         | |—————————| |         | |         |");
                Console.WriteLine("|         | |.1.....3.| |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Твой Горностай встал перед моим Кайотом.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Console.Clear();

                while (true)
                {

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |..КАЙОТ..| |         | |         |");
                    Console.WriteLine(@"|         | |—————————| |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|         | |  /\_/\  | |         | |         |");
                    Console.WriteLine(@"|         | |  (o o)  | |         | |         |");
                    Console.WriteLine(@"|         | | (--Y--) | |         | |         |");
                    Console.WriteLine(@"|         | |—————————| |         | |         |");
                    Console.WriteLine(@"|         | |.2.....1.| |         | |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |        1| |         | |         |");
                    Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                    Console.WriteLine("|         | | | -_- | | |         | |         |");
                    Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |.1.....3.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"----------- ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— |   (*)   | ——————————— ———————————");
                    Console.WriteLine(@"|         | |   | |   | |         | |         |");
                    Console.WriteLine(@"|         | |   | |   | |         | |         |");
                    Console.WriteLine(@"|         | | -|---|- | |         | |         |");
                    Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                    Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                    Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                    Console.WriteLine(@"|         | |  \   /  | |         | |         |");
                    Console.WriteLine(@"|         | |   \ /   | |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |         | |          |");
                    Console.WriteLine(@"|         | | _______ | |         | |          |");
                    Console.WriteLine(@"|         | ||       || |         | |          |");
                    Console.WriteLine(@"|         | ||  /-\  || |         | |          |");
                    Console.WriteLine(@"|         | | \ \_/ / | |         | |          |");
                    Console.WriteLine(@"|         | |  \   /  | |         | |          |");
                    Console.WriteLine(@"|         | |   \_/   | |         | |          |");
                    Console.WriteLine(@"|         | |         | |         | |          |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                    Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                    Console.WriteLine(@"|         | |   (*)   | |         | |         |");
                    Console.WriteLine(@"|         | |   | |   | |         | |         |");
                    Console.WriteLine(@"|         | |   | |   | |         | |         |");
                    Console.WriteLine(@"|         | | -|---|- | |         | |         |");
                    Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                    Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                    Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                    Console.WriteLine(@"|         | |  \   /  | |         | |         |");
                    Console.WriteLine(@"——————————— |   \ /   | ——————————— ——————————— ");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | ——————————— |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|         | | _______ | |         | |         |");
                    Console.WriteLine(@"|         | ||       || |         | |         |");
                    Console.WriteLine(@"|         | ||  /-\  || |         | |         |");
                    Console.WriteLine(@"|         | | \ \_/ / | |         | |         |");
                    Console.WriteLine(@"|         | |  \   /  | |         | |         |");
                    Console.WriteLine(@"|         | |   \_/   | |         | |         |");
                    Console.WriteLine(@"——————————— |         | ——————————— ———————————");
                    Console.WriteLine(@"            ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |..КАЙОТ..| |         | |         |");
                    Console.WriteLine(@"|         | |—————————| |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|         | |  /\_/\  | |         | |         |");
                    Console.WriteLine(@"|         | |  (o o)  | |         | |         |");
                    Console.WriteLine(@"|         | | (--Y--) | |         | |         |");
                    Console.WriteLine(@"|         | |—————————| |         | |         |");
                    Console.WriteLine(@"|         | |.2.....1.| |         | |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |        1| |         | |         |");
                    Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                    Console.WriteLine("|         | | | -_- | | |         | |         |");
                    Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |.1.....1.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    break;
                }

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Мой Кайот нанёс твоему Горностаю 2 единицы урона.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Значит, здоровье твоего Горностая уменьшилось на 2 единицы.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Если здоровье снизится до нуля то существо умрёт.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Снова твой ход.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(500);
                Console.Clear();
                Console.Write("***** - ");
                {
                    string te = "Можешь взять белку или же карту из своей колоды.";
                    int ab = 100;
                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(@"——————————— ———————————");
                Console.WriteLine(@"|   / \   | |         |");
                Console.WriteLine(@"|  0   0  | |         |");
                Console.WriteLine(@"|   \ /   | |  C...C  |");
                Console.WriteLine(@"|   / \   | | ( . . ) |");
                Console.WriteLine(@"|   \ /   | |  \   /  |");
                Console.WriteLine(@"|   / \   | |   `o`   |");
                Console.WriteLine(@"|  0   0  | |         |");
                Console.WriteLine(@"|   \ /   | |         |");
                Console.WriteLine(@"——————————— ———————————");

                Console.WriteLine("1) Своя карта.");
                Console.WriteLine("2) Белка.");

                int Karta1 = int.Parse(Console.ReadLine());
                Console.Clear();

                if (Karta1 == 1)
                {
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |..КАЙОТ..| |         | |         |");
                    Console.WriteLine(@"|         | |—————————| |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|         | |  /\_/\  | |         | |         |");
                    Console.WriteLine(@"|         | |  (o o)  | |         | |         |");
                    Console.WriteLine(@"|         | | (--Y--) | |         | |         |");
                    Console.WriteLine(@"|         | |—————————| |         | |         |");
                    Console.WriteLine(@"|         | |.2.....1.| |         | |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |        1| |         | |         |");
                    Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                    Console.WriteLine("|         | | | -_- | | |         | |         |");
                    Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |.1.....1.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(1000);

                    Console.WriteLine(@"———————————  ———————————  -----------");
                    Console.WriteLine(@"|...Волк..|  |...Волк..|  |...Жаба..|");
                    Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                    Console.WriteLine(@"||\_____/2|  ||\_____/2|  |    00  1|");
                    Console.WriteLine(@"||)     (||  ||)     (||  |   (--)  |");
                    Console.WriteLine(@"| \ o o / |  | \ o o / |  |  ( || ) |");
                    Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |  ^^~~^^ |");
                    Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                    Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.1.....2.|");
                    Console.WriteLine(@"———————————  ———————————  -----------");

                    while (true)
                    {
                        Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                        ConsoleKeyInfo keyinfo = Console.ReadKey();

                        if (keyinfo.Key == ConsoleKey.Tab)
                        {
                            while (true)
                            {
                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | |..КАЙОТ..| |         | |         |");
                                Console.WriteLine(@"|         | |—————————| |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |  /\_/\  | |         | |         |");
                                Console.WriteLine(@"|         | |  (o o)  | |         | |         |");
                                Console.WriteLine(@"|         | | (--Y--) | |         | |         |");
                                Console.WriteLine(@"|         | |—————————| |         | |         |");
                                Console.WriteLine(@"|         | |.2.....1.| |         | |         |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |        1| |         | |         |");
                                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                                Console.WriteLine("|         | | | -_- | | |         | |         |");
                                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |.1.....1.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | | _______ | |         | |         |");
                                Console.WriteLine("|         | ||       || |         | |         |");
                                Console.WriteLine(@"|         | ||  /-\  || |         | |         |");
                                Console.WriteLine(@"|         | | \ \_/ / | |         | |         |");
                                Console.WriteLine(@"|         | |  \   /  | |         | |         |");
                                Console.WriteLine(@"|         | |   \_/   | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | ——————————— |         | |         |");
                                Console.WriteLine(@"|         | |   / \   | |         | |         |");
                                Console.WriteLine(@"|         | |  /   \  | |         | |         |");
                                Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                                Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                                Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                                Console.WriteLine(@"|         | | -|___|- | |         | |         |");
                                Console.WriteLine(@"|         | |   | |   | |         | |         |");
                                Console.WriteLine(@"|         | |   | |   | ——————————— ———————————");
                                Console.WriteLine(@"----------- |   (*)   |");
                                Console.WriteLine(@"           -----------");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("----------- |         | ——————————— ———————————");
                                Console.WriteLine("|         | | _______ | |         | |         |");
                                Console.WriteLine("|         | ||       || |         | |         |");
                                Console.WriteLine(@"|         | ||  /-\  || |         | |         |");
                                Console.WriteLine(@"|         | | \ \_/ / | |         | |         |");
                                Console.WriteLine(@"|         | |  \   /  | |         | |         |");
                                Console.WriteLine(@"|         | |   \_/   | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | ——————————— |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"----------- |   / \   | ——————————— ———————————");
                                Console.WriteLine(@"|         | |  /   \  | |         | |         |");
                                Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                                Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                                Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                                Console.WriteLine(@"|         | | -|___|- | |         | |         |");
                                Console.WriteLine(@"|         | |   | |   | |         | |         |");
                                Console.WriteLine(@"|         | |   | |   | |         | |         |");
                                Console.WriteLine(@"|         | |   (*)   | |         | |         |");
                                Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |  _____  | |         | |         |");
                                Console.WriteLine(@"|         | | /     \ | |         | |         |");
                                Console.WriteLine("|         | | | * * | | |         | |         |");
                                Console.WriteLine(@"|         | | \  #  / | |         | |         |");
                                Console.WriteLine("|         | |  |_|_|  | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |        1| |         | |         |");
                                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                                Console.WriteLine("|         | | | -_- | | |         | |         |");
                                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |.1.....1.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |---------| |         | |         |");
                                Console.WriteLine("|         | || _____ || |         | |         |");
                                Console.WriteLine(@"|         | ||/     \|| |         | |         |");
                                Console.WriteLine("|         | ||| * * ||| |         | |         |");
                                Console.WriteLine(@"|         | ||\  #  /|| |         | |         |");
                                Console.WriteLine("|         | || |_|_| || |         | |         |");
                                Console.WriteLine("|         | ||       || |         | |         |");
                                Console.WriteLine("|         | |---------| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |        1| |         | |         |");
                                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                                Console.WriteLine("|         | | | -_- | | |         | |         |");
                                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |.1.....1.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | | ------- | |         | |         |");
                                Console.WriteLine(@"|         | | |/   \| | |         | |         |");
                                Console.WriteLine("|         | | ||* *|| | |         | |         |");
                                Console.WriteLine(@"|         | | |\ # /| | |         | |         |");
                                Console.WriteLine("|         | | ||_|_|| | |         | |         |");
                                Console.WriteLine("|         | | ------- | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |        1| |         | |         |");
                                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                                Console.WriteLine("|         | | | -_- | | |         | |         |");
                                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |.1.....1.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |  -----  | |         | |         |");
                                Console.WriteLine("|         | |  ||*||  | |         | |         |");
                                Console.WriteLine(@"|         | |  |\ /|  | |         | |         |");
                                Console.WriteLine("|         | |  -----  | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |        1| |         | |         |");
                                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                                Console.WriteLine("|         | | | -_- | | |         | |         |");
                                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |.1.....1.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |        1| |         | |         |");
                                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                                Console.WriteLine("|         | | | -_- | | |         | |         |");
                                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |.1.....1.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                break;
                            }
                            break;
                        }
                        else
                        {

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|         | |..КАЙОТ..| |         | |         |");
                            Console.WriteLine(@"|         | |—————————| |         | |         |");
                            Console.WriteLine(@"|         | |         | |         | |         |");
                            Console.WriteLine(@"|         | |  /\_/\  | |         | |         |");
                            Console.WriteLine(@"|         | |  (o o)  | |         | |         |");
                            Console.WriteLine(@"|         | | (--Y--) | |         | |         |");
                            Console.WriteLine(@"|         | |—————————| |         | |         |");
                            Console.WriteLine(@"|         | |.2.....1.| |         | |         |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                            Console.WriteLine("|         | |—————————| |         | |         |");
                            Console.WriteLine("|         | |        1| |         | |         |");
                            Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                            Console.WriteLine("|         | | | -_- | | |         | |         |");
                            Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                            Console.WriteLine("|         | |—————————| |         | |         |");
                            Console.WriteLine("|         | |.1.....1.| |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(500);

                            Console.WriteLine(@"———————————  ———————————  -----------");
                            Console.WriteLine(@"|...Волк..|  |...Волк..|  |...Жаба..|");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"||\_____/2|  ||\_____/2|  |    00  1|");
                            Console.WriteLine(@"||)     (||  ||)     (||  |   (--)  |");
                            Console.WriteLine(@"| \ o o / |  | \ o o / |  |  ( || ) |");
                            Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |  ^^~~^^ |");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.1.....2.|");
                            Console.WriteLine(@"———————————  ———————————  -----------");

                            Console.Write("***** - ");
                            {
                                string te = "Из-за лени автора тебе нечем ходить.";
                                int ab = 100;

                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ab);
                                }
                                Console.WriteLine();
                            }
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                    }
                }
                else
                {
                    while (true)
                    {

                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|         | |..КАЙОТ..| |         | |         |");
                        Console.WriteLine(@"|         | |—————————| |         | |         |");
                        Console.WriteLine(@"|         | |         | |         | |         |");
                        Console.WriteLine(@"|         | |  /\_/\  | |         | |         |");
                        Console.WriteLine(@"|         | |  (o o)  | |         | |         |");
                        Console.WriteLine(@"|         | | (--Y--) | |         | |         |");
                        Console.WriteLine(@"|         | |—————————| |         | |         |");
                        Console.WriteLine(@"|         | |.2.....1.| |         | |         |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                        Console.WriteLine("|         | |—————————| |         | |         |");
                        Console.WriteLine("|         | |        1| |         | |         |");
                        Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                        Console.WriteLine("|         | | | -_- | | |         | |         |");
                        Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                        Console.WriteLine("|         | |—————————| |         | |         |");
                        Console.WriteLine("|         | |.1.....1.| |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(1000);

                        Console.WriteLine(@"———————————  ———————————  -----------");
                        Console.WriteLine(@"|...Волк..|  |...Волк..|  |..БЕЛКА..|");
                        Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                        Console.WriteLine(@"||\_____/2|  ||\_____/2|  | _  (\_  |");
                        Console.WriteLine(@"||)     (||  ||)     (||  |( \  ( '>|");
                        Console.WriteLine(@"| \ o o / |  | \ o o / |  | ) \/_)= |");
                        Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |(_(__)_  |");
                        Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                        Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.0.....1.|");
                        Console.WriteLine(@"———————————  ———————————  -----------");

                        Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                        ConsoleKeyInfo keyinfo = Console.ReadKey();

                        if (keyinfo.Key == ConsoleKey.Tab)
                        {
                            while (true)
                            {
                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | |..КАЙОТ..| |         | |         |");
                                Console.WriteLine(@"|         | |—————————| |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |  /\_/\  | |         | |         |");
                                Console.WriteLine(@"|         | |  (o o)  | |         | |         |");
                                Console.WriteLine(@"|         | | (--Y--) | |         | |         |");
                                Console.WriteLine(@"|         | |—————————| |         | |         |");
                                Console.WriteLine(@"|         | |.2.....1.| |         | |         |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |        1| |         | |         |");
                                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                                Console.WriteLine("|         | | | -_- | | |         | |         |");
                                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |.1.....1.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | | _______ | |         | |         |");
                                Console.WriteLine("|         | ||       || |         | |         |");
                                Console.WriteLine(@"|         | ||  /-\  || |         | |         |");
                                Console.WriteLine(@"|         | | \ \_/ / | |         | |         |");
                                Console.WriteLine(@"|         | |  \   /  | |         | |         |");
                                Console.WriteLine(@"|         | |   \_/   | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | ——————————— |         | |         |");
                                Console.WriteLine(@"|         | |   / \   | |         | |         |");
                                Console.WriteLine(@"|         | |  /   \  | |         | |         |");
                                Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                                Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                                Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                                Console.WriteLine(@"|         | | -|___|- | |         | |         |");
                                Console.WriteLine(@"|         | |   | |   | |         | |         |");
                                Console.WriteLine(@"|         | |   | |   | ——————————— ———————————");
                                Console.WriteLine(@"----------- |   (*)   |");
                                Console.WriteLine(@"           -----------");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("----------- |         | ——————————— ———————————");
                                Console.WriteLine("|         | | _______ | |         | |         |");
                                Console.WriteLine("|         | ||       || |         | |         |");
                                Console.WriteLine(@"|         | ||  /-\  || |         | |         |");
                                Console.WriteLine(@"|         | | \ \_/ / | |         | |         |");
                                Console.WriteLine(@"|         | |  \   /  | |         | |         |");
                                Console.WriteLine(@"|         | |   \_/   | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | ——————————— |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"----------- |   / \   | ——————————— ———————————");
                                Console.WriteLine(@"|         | |  /   \  | |         | |         |");
                                Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                                Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                                Console.WriteLine(@"|         | |  |   |  | |         | |         |");
                                Console.WriteLine(@"|         | | -|___|- | |         | |         |");
                                Console.WriteLine(@"|         | |   | |   | |         | |         |");
                                Console.WriteLine(@"|         | |   | |   | |         | |         |");
                                Console.WriteLine(@"|         | |   (*)   | |         | |         |");
                                Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |  _____  | |         | |         |");
                                Console.WriteLine(@"|         | | /     \ | |         | |         |");
                                Console.WriteLine("|         | | | * * | | |         | |         |");
                                Console.WriteLine(@"|         | | \  #  / | |         | |         |");
                                Console.WriteLine("|         | |  |_|_|  | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |        1| |         | |         |");
                                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                                Console.WriteLine("|         | | | -_- | | |         | |         |");
                                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |.1.....1.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |---------| |         | |         |");
                                Console.WriteLine("|         | || _____ || |         | |         |");
                                Console.WriteLine(@"|         | ||/     \|| |         | |         |");
                                Console.WriteLine("|         | ||| * * ||| |         | |         |");
                                Console.WriteLine(@"|         | ||\  #  /|| |         | |         |");
                                Console.WriteLine("|         | || |_|_| || |         | |         |");
                                Console.WriteLine("|         | ||       || |         | |         |");
                                Console.WriteLine("|         | |---------| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |        1| |         | |         |");
                                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                                Console.WriteLine("|         | | | -_- | | |         | |         |");
                                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |.1.....1.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | | ------- | |         | |         |");
                                Console.WriteLine(@"|         | | |/   \| | |         | |         |");
                                Console.WriteLine("|         | | ||* *|| | |         | |         |");
                                Console.WriteLine(@"|         | | |\ # /| | |         | |         |");
                                Console.WriteLine("|         | | ||_|_|| | |         | |         |");
                                Console.WriteLine("|         | | ------- | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |        1| |         | |         |");
                                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                                Console.WriteLine("|         | | | -_- | | |         | |         |");
                                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |.1.....1.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |  -----  | |         | |         |");
                                Console.WriteLine("|         | |  ||*||  | |         | |         |");
                                Console.WriteLine(@"|         | |  |\ /|  | |         | |         |");
                                Console.WriteLine("|         | |  -----  | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |        1| |         | |         |");
                                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                                Console.WriteLine("|         | | | -_- | | |         | |         |");
                                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |.1.....1.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |        1| |         | |         |");
                                Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                                Console.WriteLine("|         | | | -_- | | |         | |         |");
                                Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                                Console.WriteLine("|         | |—————————| |         | |         |");
                                Console.WriteLine("|         | |.1.....1.| |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                break;
                            }
                            break;
                        }
                        else
                        {

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|         | |..КАЙОТ..| |         | |         |");
                            Console.WriteLine(@"|         | |—————————| |         | |         |");
                            Console.WriteLine(@"|         | |         | |         | |         |");
                            Console.WriteLine(@"|         | |  /\_/\  | |         | |         |");
                            Console.WriteLine(@"|         | |  (o o)  | |         | |         |");
                            Console.WriteLine(@"|         | | (--Y--) | |         | |         |");
                            Console.WriteLine(@"|         | |—————————| |         | |         |");
                            Console.WriteLine(@"|         | |.2.....1.| |         | |         |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |ГОРНОСТАЙ| |         | |         |");
                            Console.WriteLine("|         | |—————————| |         | |         |");
                            Console.WriteLine("|         | |        1| |         | |         |");
                            Console.WriteLine(@"|         | | |\---/| | |         | |         |");
                            Console.WriteLine("|         | | | -_- | | |         | |         |");
                            Console.WriteLine(@"|         | |  \_^_/  | |         | |         |");
                            Console.WriteLine("|         | |—————————| |         | |         |");
                            Console.WriteLine("|         | |.1.....1.| |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(500);

                            Console.WriteLine(@"———————————  ———————————  -----------");
                            Console.WriteLine(@"|...Волк..|  |...Волк..|  |..БЕЛКА..|");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"||\_____/2|  ||\_____/2|  | _  (\_  |");
                            Console.WriteLine(@"||)     (||  ||)     (||  |( \  ( '>|");
                            Console.WriteLine(@"| \ o o / |  | \ o o / |  | ) \/_)= |");
                            Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |(_(__)_  |");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.0.....1.|");
                            Console.WriteLine(@"———————————  ———————————  -----------");

                            Console.Write("***** - ");
                            {
                                string te = "Из-за лени автора тебе нечем ходить.";
                                int ab = 100;

                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ab);
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            else if (mesto_gornostayi == 3)
            {
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine(@"|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine(@"|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Thread.Sleep(2000);
                Console.Clear();

                Thread.Sleep(500);
                Console.WriteLine(@"———————————");
                Console.WriteLine(@"|ГОРНОСТАЙ|");
                Console.WriteLine(@"|—————————|");
                Console.WriteLine(@"|        1|");
                Console.WriteLine(@"| |\---/| |");
                Console.WriteLine(@"| | -_- | |");
                Console.WriteLine(@"|  \_^_/  |");
                Console.WriteLine(@"|—————————|");
                Console.WriteLine(@"|.1.....3.|");
                Console.WriteLine(@"———————————");

                Thread.Sleep(3000);
                Console.Write("***** - ");
                {
                    string te = "В левом нижнем углу написаны очки атаки: 1.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                Console.WriteLine("|         | |         | |—————————| |         |");
                Console.WriteLine("|         | |         | |        1| |         |");
                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                Console.WriteLine("|         | |         | | | -_- | | |         |");
                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                Console.WriteLine("|         | |         | |—————————| |         |");
                Console.WriteLine("|         | |         | |.1.....3.| |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(2000);
                Console.Write("***** - ");
                {
                    string te = "Твой Горностай остался один.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                while (true)
                {
                    Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                    ConsoleKeyInfo keyinfo = Console.ReadKey();

                    if (keyinfo.Key == ConsoleKey.Tab)
                    {
                        while (true)
                        {

                            Thread.Sleep(250);

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|         | |         | ——————————— |         |");
                            Console.WriteLine(@"|         | |         | |   / \   | |         |");
                            Console.WriteLine(@"|         | |         | |  /   \  | |         |");
                            Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                            Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                            Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                            Console.WriteLine(@"|         | |         | | -|___|- | |         |");
                            Console.WriteLine(@"|         | |         | |   | |   | |         |");
                            Console.WriteLine(@"----------- ----------- |   | |   | ———————————");
                            Console.WriteLine(@"                        |   (*)   |");
                            Console.WriteLine(@"                        -----------");

                            Thread.Sleep(250);

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"----------- ——————————— |   / \   | ———————————");
                            Console.WriteLine(@"|         | |         | |  /   \  | |         |");
                            Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                            Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                            Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                            Console.WriteLine(@"|         | |         | | -|___|- | |         |");
                            Console.WriteLine(@"|         | |         | |   | |   | |         |");
                            Console.WriteLine(@"|         | |         | |   | |   | |         |");
                            Console.WriteLine(@"|         | |         | |   (*)   | |         |");
                            Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                            Thread.Sleep(250);

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                            Console.WriteLine("|         | |         | |—————————| |         |");
                            Console.WriteLine("|         | |         | |        1| |         |");
                            Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                            Console.WriteLine("|         | |         | | | -_- | | |         |");
                            Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                            Console.WriteLine("|         | |         | |—————————| |         |");
                            Console.WriteLine("|         | |         | |.1.....3.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Thread.Sleep(250);
                            break;
                        }
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |        1| |         |");
                        Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                        Console.WriteLine("|         | |         | | | -_- | | |         |");
                        Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |.1.....3.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(500);

                        Console.WriteLine(@"———————————  ———————————");
                        Console.WriteLine(@"|...Волк..|  |...Волк..|");
                        Console.WriteLine(@"|—————————|  |—————————|");
                        Console.WriteLine(@"||\_____/2|  ||\_____/2|");
                        Console.WriteLine(@"||)     (||  ||)     (||");
                        Console.WriteLine(@"| \ o o / |  | \ o o / |");
                        Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |");
                        Console.WriteLine(@"|—————————|  |—————————|");
                        Console.WriteLine(@"|.3.....2.|  |.3.....2.|");
                        Console.WriteLine(@"———————————  ———————————");

                        Console.Write("***** - ");
                        {
                            string te = "Тебе нечем ходить. У тебя нет существ которых можно отдать в жертву.";
                            int ab = 100;

                            foreach (char c in te)
                            {
                                Console.Write(c);
                                Thread.Sleep(ab);
                            }
                            Console.WriteLine();
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Твой Горностай нанёс мне 1 единицу урона. Я добавил её на весы.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Console.Clear();

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(@"
                               _____________                                                 
                             _/. . . + . . .\_
                           _/.       ^       .\_ 
                          /+         |         +\
                         |___________|___________|
                                    | |
                                    | |
               _____________________|_|_____________________
              /_____________________________________________\
             /_|                    | |                    |_\
               |                   /   \                    |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
              / \                 |     |                  / \
             /   \                |     |                 /   \ 
            /     \               |     |                /     \
           /       \              |     |               /       \
          |---------|             |     |              |---------|
          |         |             |     |              |         |
          |---------|             |     |              |---------|
                                  |     |
                                  |     |
                                  |     |
                                  |     |
                                 /       \
                                /         \
                               /___________\");

                    Thread.Sleep(500);

                    Console.Clear();
                    Console.WriteLine(@"
                               _____________                                                 
                             _/. . . + . . .\_
                           _/.         ^     .\_ 
                          /+          /        +\
                         |___________/___________|
                                    | |
                                    | |
               _____________________|_|_____________________
              /_____________________________________________\
             /_|                    | |                    |_\
               |                   /   \                    |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
              / \                 |     |                   |
             /   \                |     |                  / \
            /     \               |     |                 /   \ 
           /       \              |     |                /     \
          |---------|             |     |               /       \
          |         |             |     |              |---------|
          |---------|             |     |              |*        |
                                  |     |              |---------|
                                  |     |
                                  |     |
                                  |     |
                                  |     |
                                 /       \
                                /         \
                               /___________\");

                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                Thread.Sleep(2000);
                Console.Write("***** - ");
                {
                    string te = "Ты победишь, когда моя чаша весов перевесит твою.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Вот так: ";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine(@"
                               _____________                                                 
                             _/. . . + . . .\_
                           _/.               .\_ 
                          /+          _______> +\
                         |___________/___________|
                                    | |
                                    | |
               _____________________|_|_____________________
              /_____________________________________________\
             /_|                    | |                    |_\
              / \                  /   \                    |
             /   \                |     |                   |
            /     \               |     |                   |
           /       \              |     |                   |
          |---------|             |     |                   |
          |         |             |     |                   |
          |---------|             |     |                   |
                                  |     |                   |
                                  |     |                   |                         
                                  |     |                  / \
                                  |     |                 /   \ 
                                  |     |                /     \
                                  |     |               /       \
                                  |     |              |---------|
                                  |     |              |*        |
                                  |     |              |---------|
                                  |     |
                                  |     |
                                  |     |
                                 /       \
                                /         \
                               /___________\");

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                Console.WriteLine("|         | |         | |—————————| |         |");
                Console.WriteLine("|         | |         | |        1| |         |");
                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                Console.WriteLine("|         | |         | | | -_- | | |         |");
                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                Console.WriteLine("|         | |         | |—————————| |         |");
                Console.WriteLine("|         | |         | |.1.....3.| |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(500);
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Мой ход. ";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(1500);
                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|         | |         | |..КАЙОТ..| |         |");
                Console.WriteLine(@"|         | |         | |—————————| |         |");
                Console.WriteLine(@"|         | |         | |         | |         |");
                Console.WriteLine(@"|         | |         | |  /\_/\  | |         |");
                Console.WriteLine(@"|         | |         | |  (o o)  | |         |");
                Console.WriteLine(@"|         | |         | | (--Y--) | |         |");
                Console.WriteLine(@"|         | |         | |—————————| |         |");
                Console.WriteLine(@"|         | |         | |.2.....1.| |         |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                Console.WriteLine("|         | |         | |—————————| |         |");
                Console.WriteLine("|         | |         | |        1| |         |");
                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                Console.WriteLine("|         | |         | | | -_- | | |         |");
                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                Console.WriteLine("|         | |         | |—————————| |         |");
                Console.WriteLine("|         | |         | |.1.....3.| |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Твой Горностай встал перед моим Кайотом.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Console.Clear();

                while (true)
                {

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |..КАЙОТ..| |         |");
                    Console.WriteLine(@"|         | |         | |—————————| |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | |  /\_/\  | |         |");
                    Console.WriteLine(@"|         | |         | |  (o o)  | |         |");
                    Console.WriteLine(@"|         | |         | | (--Y--) | |         |");
                    Console.WriteLine(@"|         | |         | |—————————| |         |");
                    Console.WriteLine(@"|         | |         | |.2.....1.| |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |        1| |         |");
                    Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                    Console.WriteLine("|         | |         | | | -_- | | |         |");
                    Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |.1.....3.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"----------- ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ----------- |   (*)   | ———————————");
                    Console.WriteLine(@"|         | |         | |   | |   | |         |");
                    Console.WriteLine(@"|         | |         | |   | |   | |         |");
                    Console.WriteLine(@"|         | |         | | -|---|- | |         |");
                    Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                    Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                    Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                    Console.WriteLine(@"|         | |         | |  \   /  | |         |");
                    Console.WriteLine(@"|         | |         | |   \ /   | |         |");
                    Console.WriteLine(@"|         | |         | ——————————— |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |         | |          |");
                    Console.WriteLine(@"|         | |         | | _______ | |          |");
                    Console.WriteLine(@"|         | |         | ||       || |          |");
                    Console.WriteLine(@"|         | |         | ||  /-\  || |          |");
                    Console.WriteLine(@"|         | |         | | \ \_/ / | |          |");
                    Console.WriteLine(@"|         | |         | |  \   /  | |          |");
                    Console.WriteLine(@"|         | |         | |   \_/   | |          |");
                    Console.WriteLine(@"|         | |         | |         | |          |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                    Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |   (*)   | |         |");
                    Console.WriteLine(@"|         | |         | |   | |   | |         |");
                    Console.WriteLine(@"|         | |         | |   | |   | |         |");
                    Console.WriteLine(@"|         | |         | | -|---|- | |         |");
                    Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                    Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                    Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                    Console.WriteLine(@"|         | |         | |  \   /  | |         |");
                    Console.WriteLine(@"——————————— ——————————— |   \ /   | ——————————— ");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | ——————————— |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | | _______ | |         |");
                    Console.WriteLine(@"|         | |         | ||       || |         |");
                    Console.WriteLine(@"|         | |         | ||  /-\  || |         |");
                    Console.WriteLine(@"|         | |         | | \ \_/ / | |         |");
                    Console.WriteLine(@"|         | |         | |  \   /  | |         |");
                    Console.WriteLine(@"|         | |         | |   \_/   | |         |");
                    Console.WriteLine(@"——————————— ——————————— |         | ———————————");
                    Console.WriteLine(@"                        ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |..КАЙОТ..| |         |");
                    Console.WriteLine(@"|         | |         | |—————————| |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | |  /\_/\  | |         |");
                    Console.WriteLine(@"|         | |         | |  (o o)  | |         |");
                    Console.WriteLine(@"|         | |         | | (--Y--) | |         |");
                    Console.WriteLine(@"|         | |         | |—————————| |         |");
                    Console.WriteLine(@"|         | |         | |.2.....1.| |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |        1| |         |");
                    Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                    Console.WriteLine("|         | |         | | | -_- | | |         |");
                    Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |.1.....1.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    break;
                }

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Мой Кайот нанёс твоему Горностаю 2 единицы урона.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Значит, здоровье твоего Горностая уменьшилось на 2 единицы.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Если здоровье снизится до нуля то существо умрёт.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Снова твой ход.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(500);
                Console.Clear();
                Console.Write("***** - ");
                {
                    string te = "Можешь взять белку или же карту из своей колоды.";
                    int ab = 100;
                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(@"——————————— ———————————");
                Console.WriteLine(@"|   / \   | |         |");
                Console.WriteLine(@"|  0   0  | |         |");
                Console.WriteLine(@"|   \ /   | |  C...C  |");
                Console.WriteLine(@"|   / \   | | ( . . ) |");
                Console.WriteLine(@"|   \ /   | |  \   /  |");
                Console.WriteLine(@"|   / \   | |   `o`   |");
                Console.WriteLine(@"|  0   0  | |         |");
                Console.WriteLine(@"|   \ /   | |         |");
                Console.WriteLine(@"——————————— ———————————");

                Console.WriteLine("1) Своя карта.");
                Console.WriteLine("2) Белка.");

                int Karta2 = int.Parse(Console.ReadLine());
                Console.Clear();

                if (Karta2 == 1)
                {
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |..КАЙОТ..| |         |");
                    Console.WriteLine(@"|         | |         | |—————————| |         |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | |  /\_/\  | |         |");
                    Console.WriteLine(@"|         | |         | |  (o o)  | |         |");
                    Console.WriteLine(@"|         | |         | | (--Y--) | |         |");
                    Console.WriteLine(@"|         | |         | |—————————| |         |");
                    Console.WriteLine(@"|         | |         | |.2.....1.| |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |        1| |         |");
                    Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                    Console.WriteLine("|         | |         | | | -_- | | |         |");
                    Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |.1.....1.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(1000);

                    Console.WriteLine(@"———————————  ———————————  -----------");
                    Console.WriteLine(@"|...Волк..|  |...Волк..|  |...Жаба..|");
                    Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                    Console.WriteLine(@"||\_____/2|  ||\_____/2|  |    00  1|");
                    Console.WriteLine(@"||)     (||  ||)     (||  |   (--)  |");
                    Console.WriteLine(@"| \ o o / |  | \ o o / |  |  ( || ) |");
                    Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |  ^^~~^^ |");
                    Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                    Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.1.....2.|");
                    Console.WriteLine(@"———————————  ———————————  -----------");

                    while (true)
                    {
                        Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                        ConsoleKeyInfo keyinfo = Console.ReadKey();

                        if (keyinfo.Key == ConsoleKey.Tab)
                        {
                            while (true)
                            {
                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | |         | |..КАЙОТ..| |         |");
                                Console.WriteLine(@"|         | |         | |—————————| |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |  /\_/\  | |         |");
                                Console.WriteLine(@"|         | |         | |  (o o)  | |         |");
                                Console.WriteLine(@"|         | |         | | (--Y--) | |         |");
                                Console.WriteLine(@"|         | |         | |—————————| |         |");
                                Console.WriteLine(@"|         | |         | |.2.....1.| |         |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |        1| |         |");
                                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                                Console.WriteLine("|         | |         | | | -_- | | |         |");
                                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |.1.....1.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | |         | |         | |          |");
                                Console.WriteLine(@"|         | |         | | _______ | |          |");
                                Console.WriteLine(@"|         | |         | ||       || |          |");
                                Console.WriteLine(@"|         | |         | ||  /-\  || |          |");
                                Console.WriteLine(@"|         | |         | | \ \_/ / | |          |");
                                Console.WriteLine(@"|         | |         | |  \   /  | |          |");
                                Console.WriteLine(@"|         | |         | |   \_/   | |          |");
                                Console.WriteLine(@"|         | |         | |         | |          |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | |         | ——————————— |         |");
                                Console.WriteLine(@"|         | |         | |   / \   | |         |");
                                Console.WriteLine(@"|         | |         | |  /   \  | |         |");
                                Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                                Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                                Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                                Console.WriteLine(@"|         | |         | | -|___|- | |         |");
                                Console.WriteLine(@"|         | |         | |   | |   | |         |");
                                Console.WriteLine(@"----------- ----------- |   | |   | ———————————");
                                Console.WriteLine(@"                        |   (*)   |");
                                Console.WriteLine(@"                        -----------");
                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("----------- ----------- |         | ———————————");
                                Console.WriteLine(@"|         | |         | |         | |          |");
                                Console.WriteLine(@"|         | |         | | _______ | |          |");
                                Console.WriteLine(@"|         | |         | ||       || |          |");
                                Console.WriteLine(@"|         | |         | ||  /-\  || |          |");
                                Console.WriteLine(@"|         | |         | | \ \_/ / | |          |");
                                Console.WriteLine(@"|         | |         | |  \   /  | |          |");
                                Console.WriteLine(@"|         | |         | |   \_/   | |          |");
                                Console.WriteLine(@"|         | |         | |         | |          |");
                                Console.WriteLine("|         | ——————————— |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"----------- ——————————— |   / \   | ———————————");
                                Console.WriteLine(@"|         | |         | |  /   \  | |         |");
                                Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                                Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                                Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                                Console.WriteLine(@"|         | |         | | -|___|- | |         |");
                                Console.WriteLine(@"|         | |         | |   | |   | |         |");
                                Console.WriteLine(@"|         | |         | |   | |   | |         |");
                                Console.WriteLine(@"|         | |         | |   (*)   | |         |");
                                Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |  _____  | |         |");
                                Console.WriteLine(@"|         | |         | | /     \ | |         |");
                                Console.WriteLine("|         | |         | | | * * | | |         |");
                                Console.WriteLine(@"|         | |         | | \  #  / | |         |");
                                Console.WriteLine("|         | |         | |  |_|_|  | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |        1| |         |");
                                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                                Console.WriteLine("|         | |         | | | -_- | | |         |");
                                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |.1.....1.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |---------| |         |");
                                Console.WriteLine("|         | |         | || _____ || |         |");
                                Console.WriteLine(@"|         | |         | ||/     \|| |         |");
                                Console.WriteLine("|         | |         | ||| * * ||| |         |");
                                Console.WriteLine(@"|         | |         | ||\  #  /|| |         |");
                                Console.WriteLine("|         | |         | || |_|_| || |         |");
                                Console.WriteLine("|         | |         | ||       || |         |");
                                Console.WriteLine("|         | |         | |---------| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |        1| |         |");
                                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                                Console.WriteLine("|         | |         | | | -_- | | |         |");
                                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |.1.....1.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | | ------- | |         |");
                                Console.WriteLine(@"|         | |         | | |/   \| | |         |");
                                Console.WriteLine("|         | |         | | ||* *|| | |         |");
                                Console.WriteLine(@"|         | |         | | |\ # /| | |         |");
                                Console.WriteLine("|         | |         | | ||_|_|| | |         |");
                                Console.WriteLine("|         | |         | | ------- | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |        1| |         |");
                                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                                Console.WriteLine("|         | |         | | | -_- | | |         |");
                                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |.1.....1.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |  -----  | |         |");
                                Console.WriteLine("|         | |         | |  ||*||  | |         |");
                                Console.WriteLine(@"|         | |         | |  |\ /|  | |         |");
                                Console.WriteLine("|         | |         | |  -----  | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |        1| |         |");
                                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                                Console.WriteLine("|         | |         | | | -_- | | |         |");
                                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |.1.....1.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |        1| |         |");
                                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                                Console.WriteLine("|         | |         | | | -_- | | |         |");
                                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |.1.....1.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                break;
                            }
                            break;
                        }
                        else
                        {

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|         | |         | |..КАЙОТ..| |         |");
                            Console.WriteLine(@"|         | |         | |—————————| |         |");
                            Console.WriteLine(@"|         | |         | |         | |         |");
                            Console.WriteLine(@"|         | |         | |  /\_/\  | |         |");
                            Console.WriteLine(@"|         | |         | |  (o o)  | |         |");
                            Console.WriteLine(@"|         | |         | | (--Y--) | |         |");
                            Console.WriteLine(@"|         | |         | |—————————| |         |");
                            Console.WriteLine(@"|         | |         | |.2.....1.| |         |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                            Console.WriteLine("|         | |         | |—————————| |         |");
                            Console.WriteLine("|         | |         | |        1| |         |");
                            Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                            Console.WriteLine("|         | |         | | | -_- | | |         |");
                            Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                            Console.WriteLine("|         | |         | |—————————| |         |");
                            Console.WriteLine("|         | |         | |.1.....1.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(500);

                            Console.WriteLine(@"———————————  ———————————  -----------");
                            Console.WriteLine(@"|...Волк..|  |...Волк..|  |...Жаба..|");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"||\_____/2|  ||\_____/2|  |    00  1|");
                            Console.WriteLine(@"||)     (||  ||)     (||  |   (--)  |");
                            Console.WriteLine(@"| \ o o / |  | \ o o / |  |  ( || ) |");
                            Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |  ^^~~^^ |");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.1.....2.|");
                            Console.WriteLine(@"———————————  ———————————  -----------");

                            Console.Write("***** - ");
                            {
                                string te = "Из-за лени автора тебе нечем ходить.";
                                int ab = 100;

                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ab);
                                }
                                Console.WriteLine();
                            }
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                    }
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|         | |         | |..КАЙОТ..| |         |");
                        Console.WriteLine(@"|         | |         | |—————————| |         |");
                        Console.WriteLine(@"|         | |         | |         | |         |");
                        Console.WriteLine(@"|         | |         | |  /\_/\  | |         |");
                        Console.WriteLine(@"|         | |         | |  (o o)  | |         |");
                        Console.WriteLine(@"|         | |         | | (--Y--) | |         |");
                        Console.WriteLine(@"|         | |         | |—————————| |         |");
                        Console.WriteLine(@"|         | |         | |.2.....1.| |         |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |        1| |         |");
                        Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                        Console.WriteLine("|         | |         | | | -_- | | |         |");
                        Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                        Console.WriteLine("|         | |         | |—————————| |         |");
                        Console.WriteLine("|         | |         | |.1.....1.| |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(1000);

                        Console.WriteLine(@"———————————  ———————————  -----------");
                        Console.WriteLine(@"|...Волк..|  |...Волк..|  |..БЕЛКА..|");
                        Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                        Console.WriteLine(@"||\_____/2|  ||\_____/2|  | _  (\_  |");
                        Console.WriteLine(@"||)     (||  ||)     (||  |( \  ( '>|");
                        Console.WriteLine(@"| \ o o / |  | \ o o / |  | ) \/_)= |");
                        Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |(_(__)_  |");
                        Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                        Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.0.....1.|");
                        Console.WriteLine(@"———————————  ———————————  -----------");

                        Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                        ConsoleKeyInfo keyinfo = Console.ReadKey();

                        if (keyinfo.Key == ConsoleKey.Tab)
                        {

                            while (true)
                            {
                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | |         | |..КАЙОТ..| |         |");
                                Console.WriteLine(@"|         | |         | |—————————| |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |  /\_/\  | |         |");
                                Console.WriteLine(@"|         | |         | |  (o o)  | |         |");
                                Console.WriteLine(@"|         | |         | | (--Y--) | |         |");
                                Console.WriteLine(@"|         | |         | |—————————| |         |");
                                Console.WriteLine(@"|         | |         | |.2.....1.| |         |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |        1| |         |");
                                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                                Console.WriteLine("|         | |         | | | -_- | | |         |");
                                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |.1.....1.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | |         | |         | |          |");
                                Console.WriteLine(@"|         | |         | | _______ | |          |");
                                Console.WriteLine(@"|         | |         | ||       || |          |");
                                Console.WriteLine(@"|         | |         | ||  /-\  || |          |");
                                Console.WriteLine(@"|         | |         | | \ \_/ / | |          |");
                                Console.WriteLine(@"|         | |         | |  \   /  | |          |");
                                Console.WriteLine(@"|         | |         | |   \_/   | |          |");
                                Console.WriteLine(@"|         | |         | |         | |          |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | |         | ——————————— |         |");
                                Console.WriteLine(@"|         | |         | |   / \   | |         |");
                                Console.WriteLine(@"|         | |         | |  /   \  | |         |");
                                Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                                Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                                Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                                Console.WriteLine(@"|         | |         | | -|___|- | |         |");
                                Console.WriteLine(@"|         | |         | |   | |   | |         |");
                                Console.WriteLine(@"----------- ----------- |   | |   | ———————————");
                                Console.WriteLine(@"                        |   (*)   |");
                                Console.WriteLine(@"                        -----------");
                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("----------- ----------- |         | ———————————");
                                Console.WriteLine(@"|         | |         | |         | |          |");
                                Console.WriteLine(@"|         | |         | | _______ | |          |");
                                Console.WriteLine(@"|         | |         | ||       || |          |");
                                Console.WriteLine(@"|         | |         | ||  /-\  || |          |");
                                Console.WriteLine(@"|         | |         | | \ \_/ / | |          |");
                                Console.WriteLine(@"|         | |         | |  \   /  | |          |");
                                Console.WriteLine(@"|         | |         | |   \_/   | |          |");
                                Console.WriteLine(@"|         | |         | |         | |          |");
                                Console.WriteLine("|         | ——————————— |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"----------- ——————————— |   / \   | ———————————");
                                Console.WriteLine(@"|         | |         | |  /   \  | |         |");
                                Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                                Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                                Console.WriteLine(@"|         | |         | |  |   |  | |         |");
                                Console.WriteLine(@"|         | |         | | -|___|- | |         |");
                                Console.WriteLine(@"|         | |         | |   | |   | |         |");
                                Console.WriteLine(@"|         | |         | |   | |   | |         |");
                                Console.WriteLine(@"|         | |         | |   (*)   | |         |");
                                Console.WriteLine(@"----------- ——————————— ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |  _____  | |         |");
                                Console.WriteLine(@"|         | |         | | /     \ | |         |");
                                Console.WriteLine("|         | |         | | | * * | | |         |");
                                Console.WriteLine(@"|         | |         | | \  #  / | |         |");
                                Console.WriteLine("|         | |         | |  |_|_|  | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |        1| |         |");
                                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                                Console.WriteLine("|         | |         | | | -_- | | |         |");
                                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |.1.....1.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |---------| |         |");
                                Console.WriteLine("|         | |         | || _____ || |         |");
                                Console.WriteLine(@"|         | |         | ||/     \|| |         |");
                                Console.WriteLine("|         | |         | ||| * * ||| |         |");
                                Console.WriteLine(@"|         | |         | ||\  #  /|| |         |");
                                Console.WriteLine("|         | |         | || |_|_| || |         |");
                                Console.WriteLine("|         | |         | ||       || |         |");
                                Console.WriteLine("|         | |         | |---------| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |        1| |         |");
                                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                                Console.WriteLine("|         | |         | | | -_- | | |         |");
                                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |.1.....1.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | | ------- | |         |");
                                Console.WriteLine(@"|         | |         | | |/   \| | |         |");
                                Console.WriteLine("|         | |         | | ||* *|| | |         |");
                                Console.WriteLine(@"|         | |         | | |\ # /| | |         |");
                                Console.WriteLine("|         | |         | | ||_|_|| | |         |");
                                Console.WriteLine("|         | |         | | ------- | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |        1| |         |");
                                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                                Console.WriteLine("|         | |         | | | -_- | | |         |");
                                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |.1.....1.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |  -----  | |         |");
                                Console.WriteLine("|         | |         | |  ||*||  | |         |");
                                Console.WriteLine(@"|         | |         | |  |\ /|  | |         |");
                                Console.WriteLine("|         | |         | |  -----  | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |        1| |         |");
                                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                                Console.WriteLine("|         | |         | | | -_- | | |         |");
                                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |.1.....1.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |        1| |         |");
                                Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                                Console.WriteLine("|         | |         | | | -_- | | |         |");
                                Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                                Console.WriteLine("|         | |         | |—————————| |         |");
                                Console.WriteLine("|         | |         | |.1.....1.| |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                break;
                            }
                            break;
                        }
                        else
                        {

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|         | |         | |..КАЙОТ..| |         |");
                            Console.WriteLine(@"|         | |         | |—————————| |         |");
                            Console.WriteLine(@"|         | |         | |         | |         |");
                            Console.WriteLine(@"|         | |         | |  /\_/\  | |         |");
                            Console.WriteLine(@"|         | |         | |  (o o)  | |         |");
                            Console.WriteLine(@"|         | |         | | (--Y--) | |         |");
                            Console.WriteLine(@"|         | |         | |—————————| |         |");
                            Console.WriteLine(@"|         | |         | |.2.....1.| |         |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |ГОРНОСТАЙ| |         |");
                            Console.WriteLine("|         | |         | |—————————| |         |");
                            Console.WriteLine("|         | |         | |        1| |         |");
                            Console.WriteLine(@"|         | |         | | |\---/| | |         |");
                            Console.WriteLine("|         | |         | | | -_- | | |         |");
                            Console.WriteLine(@"|         | |         | |  \_^_/  | |         |");
                            Console.WriteLine("|         | |         | |—————————| |         |");
                            Console.WriteLine("|         | |         | |.1.....1.| |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(500);

                            Console.WriteLine(@"———————————  ———————————  -----------");
                            Console.WriteLine(@"|...Волк..|  |...Волк..|  |..БЕЛКА..|");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"||\_____/2|  ||\_____/2|  | _  (\_  |");
                            Console.WriteLine(@"||)     (||  ||)     (||  |( \  ( '>|");
                            Console.WriteLine(@"| \ o o / |  | \ o o / |  | ) \/_)= |");
                            Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |(_(__)_  |");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.0.....1.|");
                            Console.WriteLine(@"———————————  ———————————  -----------");

                            Console.Write("***** - ");
                            {
                                string te = "Из-за лени автора тебе нечем ходить.";
                                int ab = 100;

                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ab);
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            else if (mesto_gornostayi == 4)
            {
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine(@"|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine(@"|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Thread.Sleep(2000);
                Console.Clear();

                Thread.Sleep(500);
                Console.WriteLine(@"———————————");
                Console.WriteLine(@"|ГОРНОСТАЙ|");
                Console.WriteLine(@"|—————————|");
                Console.WriteLine(@"|        1|");
                Console.WriteLine(@"| |\---/| |");
                Console.WriteLine(@"| | -_- | |");
                Console.WriteLine(@"|  \_^_/  |");
                Console.WriteLine(@"|—————————|");
                Console.WriteLine(@"|.1.....3.|");
                Console.WriteLine(@"———————————");

                Thread.Sleep(3000);
                Console.Write("***** - ");
                {
                    string te = "В левом нижнем углу написаны очки атаки: 1.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                Console.WriteLine("|         | |         | |         | |—————————|");
                Console.WriteLine("|         | |         | |         | |        1|");
                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                Console.WriteLine("|         | |         | |         | | | -_- | |");
                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                Console.WriteLine("|         | |         | |         | |—————————|");
                Console.WriteLine("|         | |         | |         | |.1.....3.|");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(2000);
                Console.Write("***** - ");
                {
                    string te = "Твой Горностай остался один.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                while (true)
                {
                    Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                    ConsoleKeyInfo keyinfo = Console.ReadKey();

                    if (keyinfo.Key == ConsoleKey.Tab)
                    {
                        while (true)
                        {

                            Thread.Sleep(250);

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|         | |         | |         | |         |");
                            Console.WriteLine(@"|         | |         | |         | |   / \   |");
                            Console.WriteLine(@"|         | |         | |         | |  /   \  |");
                            Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                            Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                            Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                            Console.WriteLine(@"|         | |         | |         | | -|___|- |");
                            Console.WriteLine(@"|         | |         | |         | |   | |   |");
                            Console.WriteLine(@"——————————— ----------- ----------- |   | |   |");
                            Console.WriteLine(@"                                    |   (*)   |");
                            Console.WriteLine(@"                                    -----------");

                            Thread.Sleep(250);

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"----------- ----------- ——————————— |   / \   |");
                            Console.WriteLine(@"|         | |         | |         | |  /   \  |");
                            Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                            Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                            Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                            Console.WriteLine(@"|         | |         | |         | | -|___|- |");
                            Console.WriteLine(@"|         | |         | |         | |   | |   |");
                            Console.WriteLine(@"|         | |         | |         | |   | |   |");
                            Console.WriteLine(@"|         | |         | |         | |   (*)   |");
                            Console.WriteLine(@"----------- ----------- ——————————— ———————————");

                            Thread.Sleep(250);

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("|         | |         | |         | |         |");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                            Console.WriteLine("|         | |         | |         | |—————————|");
                            Console.WriteLine("|         | |         | |         | |        1|");
                            Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                            Console.WriteLine("|         | |         | |         | | | -_- | |");
                            Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                            Console.WriteLine("|         | |         | |         | |—————————|");
                            Console.WriteLine("|         | |         | |         | |.1.....3.|");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Thread.Sleep(250);
                            break;
                        }
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |        1|");
                        Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                        Console.WriteLine("|         | |         | |         | | | -_- | |");
                        Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |.1.....3.|");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(500);

                        Console.WriteLine(@"———————————  ———————————");
                        Console.WriteLine(@"|...Волк..|  |...Волк..|");
                        Console.WriteLine(@"|—————————|  |—————————|");
                        Console.WriteLine(@"||\_____/2|  ||\_____/2|");
                        Console.WriteLine(@"||)     (||  ||)     (||");
                        Console.WriteLine(@"| \ o o / |  | \ o o / |");
                        Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |");
                        Console.WriteLine(@"|—————————|  |—————————|");
                        Console.WriteLine(@"|.3.....2.|  |.3.....2.|");
                        Console.WriteLine(@"———————————  ———————————");

                        Console.Write("***** - ");
                        {
                            string te = "Тебе нечем ходить. У тебя нет существ которых можно отдать в жертву.";
                            int ab = 100;

                            foreach (char c in te)
                            {
                                Console.Write(c);
                                Thread.Sleep(ab);
                            }
                            Console.WriteLine();
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Твой Горностай нанёс мне 1 единицу урона. Я добавил её на весы.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Console.Clear();

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(@"
                               _____________                                                 
                             _/. . . + . . .\_
                           _/.       ^       .\_ 
                          /+         |         +\
                         |___________|___________|
                                    | |
                                    | |
               _____________________|_|_____________________
              /_____________________________________________\
             /_|                    | |                    |_\
               |                   /   \                    |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
              / \                 |     |                  / \
             /   \                |     |                 /   \ 
            /     \               |     |                /     \
           /       \              |     |               /       \
          |---------|             |     |              |---------|
          |         |             |     |              |         |
          |---------|             |     |              |---------|
                                  |     |
                                  |     |
                                  |     |
                                  |     |
                                 /       \
                                /         \
                               /___________\");

                    Thread.Sleep(500);

                    Console.Clear();
                    Console.WriteLine(@"
                               _____________                                                 
                             _/. . . + . . .\_
                           _/.         ^     .\_ 
                          /+          /        +\
                         |___________/___________|
                                    | |
                                    | |
               _____________________|_|_____________________
              /_____________________________________________\
             /_|                    | |                    |_\
               |                   /   \                    |
               |                  |     |                   |
               |                  |     |                   |
               |                  |     |                   |
              / \                 |     |                   |
             /   \                |     |                  / \
            /     \               |     |                 /   \ 
           /       \              |     |                /     \
          |---------|             |     |               /       \
          |         |             |     |              |---------|
          |---------|             |     |              |*        |
                                  |     |              |---------|
                                  |     |
                                  |     |
                                  |     |
                                  |     |
                                 /       \
                                /         \
                               /___________\");

                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                Thread.Sleep(2000);
                Console.Write("***** - ");
                {
                    string te = "Ты победишь, когда моя чаша весов перевесит твою.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Вот так: ";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine(@"
                               _____________                                                 
                             _/. . . + . . .\_
                           _/.               .\_ 
                          /+          _______> +\
                         |___________/___________|
                                    | |
                                    | |
               _____________________|_|_____________________
              /_____________________________________________\
             /_|                    | |                    |_\
              / \                  /   \                    |
             /   \                |     |                   |
            /     \               |     |                   |
           /       \              |     |                   |
          |---------|             |     |                   |
          |         |             |     |                   |
          |---------|             |     |                   |
                                  |     |                   |
                                  |     |                   |                         
                                  |     |                  / \
                                  |     |                 /   \ 
                                  |     |                /     \
                                  |     |               /       \
                                  |     |              |---------|
                                  |     |              |*        |
                                  |     |              |---------|
                                  |     |
                                  |     |
                                  |     |
                                 /       \
                                /         \
                               /___________\");

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                Console.WriteLine("|         | |         | |         | |—————————|");
                Console.WriteLine("|         | |         | |         | |        1|");
                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                Console.WriteLine("|         | |         | |         | | | -_- | |");
                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                Console.WriteLine("|         | |         | |         | |—————————|");
                Console.WriteLine("|         | |         | |         | |.1.....3.|");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(500);
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Мой ход. ";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(1500);
                Console.Clear();

                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|         | |         | |         | |..КАЙОТ..|");
                Console.WriteLine(@"|         | |         | |         | |—————————|");
                Console.WriteLine(@"|         | |         | |         | |         |");
                Console.WriteLine(@"|         | |         | |         | |  /\_/\  |");
                Console.WriteLine(@"|         | |         | |         | |  (o o)  |");
                Console.WriteLine(@"|         | |         | |         | | (--Y--) |");
                Console.WriteLine(@"|         | |         | |         | |—————————|");
                Console.WriteLine(@"|         | |         | |         | |.2.....1.|");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                Console.WriteLine("|         | |         | |         | |—————————|");
                Console.WriteLine("|         | |         | |         | |        1|");
                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                Console.WriteLine("|         | |         | |         | | | -_- | |");
                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                Console.WriteLine("|         | |         | |         | |—————————|");
                Console.WriteLine("|         | |         | |         | |.1.....3.|");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Твой Горностай встал перед моим Кайотом.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Console.Clear();

                while (true)
                {

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |         | |..КАЙОТ..|");
                    Console.WriteLine(@"|         | |         | |         | |—————————|");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | |  /\_/\  |");
                    Console.WriteLine(@"|         | |         | |         | |  (o o)  |");
                    Console.WriteLine(@"|         | |         | |         | | (--Y--) |");
                    Console.WriteLine(@"|         | |         | |         | |—————————|");
                    Console.WriteLine(@"|         | |         | |         | |.2.....1.|");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |        1|");
                    Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                    Console.WriteLine("|         | |         | |         | | | -_- | |");
                    Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |.1.....3.|");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"----------- ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |         | |   (*)   |");
                    Console.WriteLine(@"|         | |         | |         | |   | |   |");
                    Console.WriteLine(@"|         | |         | |         | |   | |   |");
                    Console.WriteLine(@"|         | |         | |         | | -|---|- |");
                    Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                    Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                    Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                    Console.WriteLine(@"|         | |         | |         | |  \   /  |");
                    Console.WriteLine(@"|         | |         | |         | |   \ /   |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | | _______ |");
                    Console.WriteLine(@"|         | |         | |         | ||       ||");
                    Console.WriteLine(@"|         | |         | |         | ||  /-\  ||");
                    Console.WriteLine(@"|         | |         | |         | | \ \_/ / |");
                    Console.WriteLine(@"|         | |         | |         | |  \   /  |");
                    Console.WriteLine(@"|         | |         | |         | |   \_/   |");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                    Console.WriteLine(@"——————————— ----------- ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |         | |   (*)   |");
                    Console.WriteLine(@"|         | |         | |         | |   | |   |");
                    Console.WriteLine(@"|         | |         | |         | |   | |   |");
                    Console.WriteLine(@"|         | |         | |         | | -|---|- |");
                    Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                    Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                    Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                    Console.WriteLine(@"|         | |         | |         | |  \   /  |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— |   \ /   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |         | ———————————|");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | | _______ |");
                    Console.WriteLine(@"|         | |         | |         | ||       ||");
                    Console.WriteLine(@"|         | |         | |         | ||  /-\  ||");
                    Console.WriteLine(@"|         | |         | |         | | \ \_/ / |");
                    Console.WriteLine(@"|         | |         | |         | |  \   /  |");
                    Console.WriteLine(@"|         | |         | |         | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— |         |");
                    Console.WriteLine(@"                                    ———————————");

                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |         | |..КАЙОТ..|");
                    Console.WriteLine(@"|         | |         | |         | |—————————|");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | |  /\_/\  |");
                    Console.WriteLine(@"|         | |         | |         | |  (o o)  |");
                    Console.WriteLine(@"|         | |         | |         | | (--Y--) |");
                    Console.WriteLine(@"|         | |         | |         | |—————————|");
                    Console.WriteLine(@"|         | |         | |         | |.2.....1.|");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |        1|");
                    Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                    Console.WriteLine("|         | |         | |         | | | -_- | |");
                    Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |.1.....1.|");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    break;
                }

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Мой Кайот нанёс твоему Горностаю 2 единицы урона.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Значит, здоровье твоего Горностая уменьшилось на 2 единицы.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Если здоровье снизится до нуля то существо умрёт.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string te = "Снова твой ход.";
                    int ab = 100;

                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(500);
                Console.Clear();
                Console.Write("***** - ");
                {
                    string te = "Можешь взять белку или же карту из своей колоды.";
                    int ab = 100;
                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ab);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(@"——————————— ———————————");
                Console.WriteLine(@"|   / \   | |         |");
                Console.WriteLine(@"|  0   0  | |         |");
                Console.WriteLine(@"|   \ /   | |  C...C  |");
                Console.WriteLine(@"|   / \   | | ( . . ) |");
                Console.WriteLine(@"|   \ /   | |  \   /  |");
                Console.WriteLine(@"|   / \   | |   `o`   |");
                Console.WriteLine(@"|  0   0  | |         |");
                Console.WriteLine(@"|   \ /   | |         |");
                Console.WriteLine(@"——————————— ———————————");

                Console.WriteLine("1) Своя карта.");
                Console.WriteLine("2) Белка.");

                int Karta2 = int.Parse(Console.ReadLine());
                Console.Clear();

                if (Karta2 == 1)
                {
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|         | |         | |         | |..КАЙОТ..|");
                    Console.WriteLine(@"|         | |         | |         | |—————————|");
                    Console.WriteLine(@"|         | |         | |         | |         |");
                    Console.WriteLine(@"|         | |         | |         | |  /\_/\  |");
                    Console.WriteLine(@"|         | |         | |         | |  (o o)  |");
                    Console.WriteLine(@"|         | |         | |         | | (--Y--) |");
                    Console.WriteLine(@"|         | |         | |         | |—————————|");
                    Console.WriteLine(@"|         | |         | |         | |.2.....1.|");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |        1|");
                    Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                    Console.WriteLine("|         | |         | |         | | | -_- | |");
                    Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |.1.....1.|");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(1000);

                    Console.WriteLine(@"———————————  ———————————  -----------");
                    Console.WriteLine(@"|...Волк..|  |...Волк..|  |...Жаба..|");
                    Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                    Console.WriteLine(@"||\_____/2|  ||\_____/2|  |    00  1|");
                    Console.WriteLine(@"||)     (||  ||)     (||  |   (--)  |");
                    Console.WriteLine(@"| \ o o / |  | \ o o / |  |  ( || ) |");
                    Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |  ^^~~^^ |");
                    Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                    Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.1.....2.|");
                    Console.WriteLine(@"———————————  ———————————  -----------");

                    while (true)
                    {
                        Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                        ConsoleKeyInfo keyinfo = Console.ReadKey();

                        if (keyinfo.Key == ConsoleKey.Tab)
                        {
                            while (true)
                            {
                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | |         | |         | |..КАЙОТ..|");
                                Console.WriteLine(@"|         | |         | |         | |—————————|");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |  /\_/\  |");
                                Console.WriteLine(@"|         | |         | |         | |  (o o)  |");
                                Console.WriteLine(@"|         | |         | |         | | (--Y--) |");
                                Console.WriteLine(@"|         | |         | |         | |—————————|");
                                Console.WriteLine(@"|         | |         | |         | |.2.....1.|");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |        1|");
                                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                                Console.WriteLine("|         | |         | |         | | | -_- | |");
                                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |.1.....1.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | | _______ |");
                                Console.WriteLine(@"|         | |         | |         | ||       ||");
                                Console.WriteLine(@"|         | |         | |         | ||  /-\  ||");
                                Console.WriteLine(@"|         | |         | |         | | \ \_/ / |");
                                Console.WriteLine(@"|         | |         | |         | |  \   /  |");
                                Console.WriteLine(@"|         | |         | |         | |   \_/   |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— -——————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | |         | |         | ———————————");
                                Console.WriteLine(@"|         | |         | |         | |   / \   |");
                                Console.WriteLine(@"|         | |         | |         | |  /   \  |");
                                Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                                Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                                Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                                Console.WriteLine(@"|         | |         | |         | | -|___|- |");
                                Console.WriteLine(@"|         | |         | |         | |   | |   |");
                                Console.WriteLine(@"----------- ----------- ----------- |   | |   |");
                                Console.WriteLine(@"                                    |   (*)   |");
                                Console.WriteLine(@"                                    -----------");
                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("----------- ----------- ----------- |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | | _______ |");
                                Console.WriteLine(@"|         | |         | |         | ||       ||");
                                Console.WriteLine(@"|         | |         | |         | ||  /-\  ||");
                                Console.WriteLine(@"|         | |         | |         | | \ \_/ / |");
                                Console.WriteLine(@"|         | |         | |         | |  \   /  |");
                                Console.WriteLine(@"|         | |         | |         | |   \_/   |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | -----------");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"----------- ----------- ——————————— |   / \   |");
                                Console.WriteLine(@"|         | |         | |         | |  /   \  |");
                                Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                                Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                                Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                                Console.WriteLine(@"|         | |         | |         | | -|___|- |");
                                Console.WriteLine(@"|         | |         | |         | |   | |   |");
                                Console.WriteLine(@"|         | |         | |         | |   | |   |");
                                Console.WriteLine(@"|         | |         | |         | |   (*)   |");
                                Console.WriteLine(@"----------- ----------- ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |  _____  |");
                                Console.WriteLine(@"|         | |         | |         | | /     \ |");
                                Console.WriteLine("|         | |         | |         | | | * * | |");
                                Console.WriteLine(@"|         | |         | |         | | \  #  / |");
                                Console.WriteLine("|         | |         | |         | |  |_|_|  |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |        1|");
                                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                                Console.WriteLine("|         | |         | |         | | | -_- | |");
                                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |.1.....1.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |---------|");
                                Console.WriteLine("|         | |         | |         | || _____ ||");
                                Console.WriteLine(@"|         | |         | |         | ||/     \||");
                                Console.WriteLine("|         | |         | |         | ||| * * |||");
                                Console.WriteLine(@"|         | |         | |         | ||\  #  /||");
                                Console.WriteLine("|         | |         | |         | || |_|_| ||");
                                Console.WriteLine("|         | |         | |         | ||       ||");
                                Console.WriteLine("|         | |         | |         | |---------|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |        1|");
                                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                                Console.WriteLine("|         | |         | |         | | | -_- | |");
                                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |.1.....1.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | | ------- |");
                                Console.WriteLine(@"|         | |         | |         | | |/   \| |");
                                Console.WriteLine("|         | |         | |         | | ||* *|| |");
                                Console.WriteLine(@"|         | |         | |         | | |\ # /| |");
                                Console.WriteLine("|         | |         | |         | | ||_|_|| |");
                                Console.WriteLine("|         | |         | |         | | ------- |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |        1|");
                                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                                Console.WriteLine("|         | |         | |         | | | -_- | |");
                                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |.1.....1.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |  -----  |");
                                Console.WriteLine("|         | |         | |         | |  ||*||  |");
                                Console.WriteLine(@"|         | |         | |         | |  |\ /|  |");
                                Console.WriteLine("|         | |         | |         | |  -----  |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |        1|");
                                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                                Console.WriteLine("|         | |         | |         | | | -_- | |");
                                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |.1.....1.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |        1|");
                                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                                Console.WriteLine("|         | |         | |         | | | -_- | |");
                                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |.1.....1.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                break;
                            }
                            break;
                        }
                        else
                        {

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|         | |         | |         | |..КАЙОТ..|");
                            Console.WriteLine(@"|         | |         | |         | |—————————|");
                            Console.WriteLine(@"|         | |         | |         | |         |");
                            Console.WriteLine(@"|         | |         | |         | |  /\_/\  |");
                            Console.WriteLine(@"|         | |         | |         | |  (o o)  |");
                            Console.WriteLine(@"|         | |         | |         | | (--Y--) |");
                            Console.WriteLine(@"|         | |         | |         | |—————————|");
                            Console.WriteLine(@"|         | |         | |         | |.2.....1.|");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                            Console.WriteLine("|         | |         | |         | |—————————|");
                            Console.WriteLine("|         | |         | |         | |        1|");
                            Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                            Console.WriteLine("|         | |         | |         | | | -_- | |");
                            Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                            Console.WriteLine("|         | |         | |         | |—————————|");
                            Console.WriteLine("|         | |         | |         | |.1.....1.|");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(500);

                            Console.WriteLine(@"———————————  ———————————  -----------");
                            Console.WriteLine(@"|...Волк..|  |...Волк..|  |...Жаба..|");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"||\_____/2|  ||\_____/2|  |    00  1|");
                            Console.WriteLine(@"||)     (||  ||)     (||  |   (--)  |");
                            Console.WriteLine(@"| \ o o / |  | \ o o / |  |  ( || ) |");
                            Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |  ^^~~^^ |");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.1.....2.|");
                            Console.WriteLine(@"———————————  ———————————  -----------");

                            Console.Write("***** - ");
                            {
                                string te = "Из-за лени автора тебе нечем ходить.";
                                int ab = 100;

                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ab);
                                }
                                Console.WriteLine();
                            }
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                    }
                }
                else
                {
                    while (true)
                    {

                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|         | |         | |         | |..КАЙОТ..|");
                        Console.WriteLine(@"|         | |         | |         | |—————————|");
                        Console.WriteLine(@"|         | |         | |         | |         |");
                        Console.WriteLine(@"|         | |         | |         | |  /\_/\  |");
                        Console.WriteLine(@"|         | |         | |         | |  (o o)  |");
                        Console.WriteLine(@"|         | |         | |         | | (--Y--) |");
                        Console.WriteLine(@"|         | |         | |         | |—————————|");
                        Console.WriteLine(@"|         | |         | |         | |.2.....1.|");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |        1|");
                        Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                        Console.WriteLine("|         | |         | |         | | | -_- | |");
                        Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                        Console.WriteLine("|         | |         | |         | |—————————|");
                        Console.WriteLine("|         | |         | |         | |.1.....1.|");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(1000);

                        Console.WriteLine(@"———————————  ———————————  -----------");
                        Console.WriteLine(@"|...Волк..|  |...Волк..|  |..БЕЛКА..|");
                        Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                        Console.WriteLine(@"||\_____/2|  ||\_____/2|  | _  (\_  |");
                        Console.WriteLine(@"||)     (||  ||)     (||  |( \  ( '>|");
                        Console.WriteLine(@"| \ o o / |  | \ o o / |  | ) \/_)= |");
                        Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |(_(__)_  |");
                        Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                        Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.0.....1.|");
                        Console.WriteLine(@"———————————  ———————————  -----------");

                        Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                        ConsoleKeyInfo keyinfo = Console.ReadKey();

                        if (keyinfo.Key == ConsoleKey.Tab)
                        {
                            while (true)
                            {

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | |         | |         | |..КАЙОТ..|");
                                Console.WriteLine(@"|         | |         | |         | |—————————|");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |  /\_/\  |");
                                Console.WriteLine(@"|         | |         | |         | |  (o o)  |");
                                Console.WriteLine(@"|         | |         | |         | | (--Y--) |");
                                Console.WriteLine(@"|         | |         | |         | |—————————|");
                                Console.WriteLine(@"|         | |         | |         | |.2.....1.|");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |        1|");
                                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                                Console.WriteLine("|         | |         | |         | | | -_- | |");
                                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |.1.....1.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | | _______ |");
                                Console.WriteLine(@"|         | |         | |         | ||       ||");
                                Console.WriteLine(@"|         | |         | |         | ||  /-\  ||");
                                Console.WriteLine(@"|         | |         | |         | | \ \_/ / |");
                                Console.WriteLine(@"|         | |         | |         | |  \   /  |");
                                Console.WriteLine(@"|         | |         | |         | |   \_/   |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— -——————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|         | |         | |         | ———————————");
                                Console.WriteLine(@"|         | |         | |         | |   / \   |");
                                Console.WriteLine(@"|         | |         | |         | |  /   \  |");
                                Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                                Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                                Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                                Console.WriteLine(@"|         | |         | |         | | -|___|- |");
                                Console.WriteLine(@"|         | |         | |         | |   | |   |");
                                Console.WriteLine(@"----------- ----------- ----------- |   | |   |");
                                Console.WriteLine(@"                                    |   (*)   |");
                                Console.WriteLine(@"                                    -----------");
                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("----------- ----------- ----------- |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | | _______ |");
                                Console.WriteLine(@"|         | |         | |         | ||       ||");
                                Console.WriteLine(@"|         | |         | |         | ||  /-\  ||");
                                Console.WriteLine(@"|         | |         | |         | | \ \_/ / |");
                                Console.WriteLine(@"|         | |         | |         | |  \   /  |");
                                Console.WriteLine(@"|         | |         | |         | |   \_/   |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | -----------");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"----------- ----------- ——————————— |   / \   |");
                                Console.WriteLine(@"|         | |         | |         | |  /   \  |");
                                Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                                Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                                Console.WriteLine(@"|         | |         | |         | |  |   |  |");
                                Console.WriteLine(@"|         | |         | |         | | -|___|- |");
                                Console.WriteLine(@"|         | |         | |         | |   | |   |");
                                Console.WriteLine(@"|         | |         | |         | |   | |   |");
                                Console.WriteLine(@"|         | |         | |         | |   (*)   |");
                                Console.WriteLine(@"----------- ----------- ——————————— ———————————");

                                Thread.Sleep(250);

                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |  _____  |");
                                Console.WriteLine(@"|         | |         | |         | | /     \ |");
                                Console.WriteLine("|         | |         | |         | | | * * | |");
                                Console.WriteLine(@"|         | |         | |         | | \  #  / |");
                                Console.WriteLine("|         | |         | |         | |  |_|_|  |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |        1|");
                                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                                Console.WriteLine("|         | |         | |         | | | -_- | |");
                                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |.1.....1.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |---------|");
                                Console.WriteLine("|         | |         | |         | || _____ ||");
                                Console.WriteLine(@"|         | |         | |         | ||/     \||");
                                Console.WriteLine("|         | |         | |         | ||| * * |||");
                                Console.WriteLine(@"|         | |         | |         | ||\  #  /||");
                                Console.WriteLine("|         | |         | |         | || |_|_| ||");
                                Console.WriteLine("|         | |         | |         | ||       ||");
                                Console.WriteLine("|         | |         | |         | |---------|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |        1|");
                                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                                Console.WriteLine("|         | |         | |         | | | -_- | |");
                                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |.1.....1.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | | ------- |");
                                Console.WriteLine(@"|         | |         | |         | | |/   \| |");
                                Console.WriteLine("|         | |         | |         | | ||* *|| |");
                                Console.WriteLine(@"|         | |         | |         | | |\ # /| |");
                                Console.WriteLine("|         | |         | |         | | ||_|_|| |");
                                Console.WriteLine("|         | |         | |         | | ------- |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |        1|");
                                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                                Console.WriteLine("|         | |         | |         | | | -_- | |");
                                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |.1.....1.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |  -----  |");
                                Console.WriteLine("|         | |         | |         | |  ||*||  |");
                                Console.WriteLine(@"|         | |         | |         | |  |\ /|  |");
                                Console.WriteLine("|         | |         | |         | |  -----  |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |        1|");
                                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                                Console.WriteLine("|         | |         | |         | | | -_- | |");
                                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |.1.....1.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                                Thread.Sleep(250);
                                Console.Clear();
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine(@"|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("|         | |         | |         | |         |");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |        1|");
                                Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                                Console.WriteLine("|         | |         | |         | | | -_- | |");
                                Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                                Console.WriteLine("|         | |         | |         | |—————————|");
                                Console.WriteLine("|         | |         | |         | |.1.....1.|");
                                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                                break;
                            }
                            break;
                        }
                        else
                        {

                            Console.Clear();
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                            Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                            Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                            Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                            Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine(@"|         | |         | |         | |..КАЙОТ..|");
                            Console.WriteLine(@"|         | |         | |         | |—————————|");
                            Console.WriteLine(@"|         | |         | |         | |         |");
                            Console.WriteLine(@"|         | |         | |         | |  /\_/\  |");
                            Console.WriteLine(@"|         | |         | |         | |  (o o)  |");
                            Console.WriteLine(@"|         | |         | |         | | (--Y--) |");
                            Console.WriteLine(@"|         | |         | |         | |—————————|");
                            Console.WriteLine(@"|         | |         | |         | |.2.....1.|");
                            Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                            Console.WriteLine("|         | |         | |         | |ГОРНОСТАЙ|");
                            Console.WriteLine("|         | |         | |         | |—————————|");
                            Console.WriteLine("|         | |         | |         | |        1|");
                            Console.WriteLine(@"|         | |         | |         | | |\---/| |");
                            Console.WriteLine("|         | |         | |         | | | -_- | |");
                            Console.WriteLine(@"|         | |         | |         | |  \_^_/  |");
                            Console.WriteLine("|         | |         | |         | |—————————|");
                            Console.WriteLine("|         | |         | |         | |.1.....1.|");
                            Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                            Thread.Sleep(500);

                            Console.WriteLine(@"———————————  ———————————  -----------");
                            Console.WriteLine(@"|...Волк..|  |...Волк..|  |..БЕЛКА..|");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"||\_____/2|  ||\_____/2|  | _  (\_  |");
                            Console.WriteLine(@"||)     (||  ||)     (||  |( \  ( '>|");
                            Console.WriteLine(@"| \ o o / |  | \ o o / |  | ) \/_)= |");
                            Console.WriteLine(@"|  \_0_/  |  |  \_0_/  |  |(_(__)_  |");
                            Console.WriteLine(@"|—————————|  |—————————|  |---------|");
                            Console.WriteLine(@"|.3.....2.|  |.3.....2.|  |.0.....1.|");
                            Console.WriteLine(@"———————————  ———————————  -----------");

                            Console.Write("***** - ");
                            {
                                string te = "Из-за лени автора тебе нечем ходить.";
                                int ab = 100;

                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ab);
                                }
                                Console.WriteLine();
                            }

                        }
                    }
                }
            }
        }                   // место горностая из обучения
        static void obychenie()
        {
            void s()
            {
                start1_game();
            }
            s();

            Console.WriteLine();
            int start = int.Parse(Console.ReadLine());

            if (start == 1)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.Write(" ***** - ");

                {
                    string text = "Очередной соискатель, прошла целая вечность.";
                    int a = 100;

                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(a);
                    }

                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Clear();
                Console.Write("***** - ");

                {
                    string text = "Вероятно, ты забыл, как играть в эту игру.";
                    int a = 100;

                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(a);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Clear();
                Console.Write("***** - ");

                {
                    string text = "Позволь мне напомнить.";
                    int a = 100;

                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(a);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Clear();
                Console.Write("***** - ");

                {
                    string text = "Это игровое поле.";
                    int a = 100;

                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(a);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(1000);
                Console.Write("***** - ");

                {
                    string text = "Это твоя колода карт.";
                    int a = 100;

                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(a);
                    }
                    Console.WriteLine();
                }
                while (true)
                {

                    Thread.Sleep(500);
                    Console.Clear();

                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(500);

                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|..БЕЛКА..| |ГОРНОСТАЙ| |...Волк..| |...Волк..|");
                    Console.WriteLine(@"|—————————| |—————————| |—————————| |—————————|");
                    Console.WriteLine(@"| _  (\_  | |        1| ||\_____/2| ||\_____/2|");
                    Console.WriteLine(@"|( \  ( '>| | |\---/| | ||)     (|| ||)     (||");
                    Console.WriteLine(@"| ) \/_)= | | | -_- | | | \ o o / | | \ o o / |");
                    Console.WriteLine(@"|(_(__)_  | |  \_^_/  | |  \_0_/  | |  \_0_/  |");
                    Console.WriteLine(@"|—————————| |—————————| |—————————| |—————————|");
                    Console.WriteLine(@"|.0.....1.| |.1.....3.| |.3.....2.| |.3.....2.|");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                    int Vibor1 = 1;

                    Console.Write("***** - ");
                    {
                        string text = "Играй белкой.";
                        int a = 100;

                        foreach (char c in text)
                        {
                            Console.Write(c);
                            Thread.Sleep(a);
                        }
                        Console.WriteLine();
                    }

                    Thread.Sleep(500);
                    Console.WriteLine("1) Белка.");
                    Thread.Sleep(500);
                    Console.WriteLine("2) Горностай.");
                    Thread.Sleep(500);
                    Console.WriteLine("3) Волк.");
                    Thread.Sleep(500);
                    Console.WriteLine("4) Волк.");
                    Thread.Sleep(500);
                    Console.WriteLine("Выбери Белку.");

                    int Vibor2 = int.Parse(Console.ReadLine());

                    if (Vibor2 == Vibor1)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        if (Vibor2 > 1)
                        {
                            Random text3 = new Random();
                            int fraza3 = text3.Next(1, 3);

                            if (fraza3 == 1)
                            {
                                Thread.Sleep(500);
                                Console.Write("***** - ");
                                {
                                    string text = "Этой карте нужно больше крови.";
                                    int a = 100;

                                    foreach (char c in text)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(a);
                                    }
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }
                            }
                            else if (fraza3 == 2)
                            {
                                Thread.Sleep(500);
                                Console.Write("***** - ");
                                {
                                    string text = "Этим пока ходить нельзя, но вот белка бесплатная.";
                                    int a = 100;

                                    foreach (char c in text)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(a);
                                    }
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }

                            }
                            else if (fraza3 == 3)
                            {
                                Thread.Sleep(500);
                                Console.Write("***** - ");
                                {
                                    string text = "Не... Но ты можешь пойти Белкой.";
                                    int a = 100;

                                    foreach (char c in text)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(a);
                                    }
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|    1    | |    2    | |    3    | |    4    |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("|         | |         | |         | |         |");
                Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string text = "Выбери куда положить карту.";
                    int a = 100;

                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(a);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Write("***** - ");
                {
                    string text = "Напиши число от 1 до 4 что бы положить на это место карту.";
                    int a = 100;

                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(a);
                    }
                    Console.WriteLine();
                }

                int Mesto = int.Parse(Console.ReadLine());

                Console.Clear();

                if (Mesto == 1)
                {
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|..БЕЛКА..| |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine(@"| _  (\_  | |         | |         | |         |");
                    Console.WriteLine(@"|( \  ( '>| |         | |         | |         |");
                    Console.WriteLine(@"| ) \/_)= | |         | |         | |         |");
                    Console.WriteLine("|(_(__)_  | |         | |         | |         |");
                    Console.WriteLine("|—————————| |         | |         | |         |");
                    Console.WriteLine("|.0.....1.| |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(500);
                    Console.Write("***** - ");
                    {
                        string text = "Теперь играй Горностаем.";
                        int a = 100;

                        foreach (char c in text)
                        {
                            Console.Write(c);
                            Thread.Sleep(a);
                        }
                        Console.WriteLine();
                    }

                    Thread.Sleep(500);
                    Console.Write("***** - ");
                    {
                        string text = "Цена Горностая - 1 капля крови. Необходимо кем то пожертвовать.";
                        int a = 100;

                        foreach (char c in text)
                        {
                            Console.Write(c);
                            Thread.Sleep(a);
                        }
                        Console.WriteLine();
                    }

                    Thread.Sleep(500);
                    Console.Write("***** - ");
                    {
                        string te = "Напиши число от 1 до 4 и пожертвуй этой картой.";
                        int ab = 100;

                        foreach (char c in te)
                        {
                            Console.Write(c);
                            Thread.Sleep(ab);
                        }
                        Console.WriteLine();
                    }

                    int mesto = 1;

                    while (true)
                    {
                        int a = int.Parse(Console.ReadLine());
                        if (a == mesto)
                        {
                            break;
                        }
                        else
                        {
                            Thread.Sleep(500);
                            Console.Write("***** - ");
                            {
                                string te = "На этом месте нет карты.";
                                int ab = 100;

                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ab);
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                    Thread.Sleep(500);
                    Console.Clear();

                    if (mesto == 1)
                    {

                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|\.БЕЛКА./| |         | |         | |         |");
                        Console.WriteLine(@"|—\—————/—| |         | |         | |         |");
                        Console.WriteLine(@"| _\ (\/  | |         | |         | |         |");
                        Console.WriteLine(@"|( \\ / '>| |         | |         | |         |");
                        Console.WriteLine(@"| ) //\)= | |         | |         | |         |");
                        Console.WriteLine(@"|(_/__)\  | |         | |         | |         |");
                        Console.WriteLine(@"|—/—————\-| |         | |         | |         |");
                        Console.WriteLine(@"|/0.....1\| |         | |         | |         |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(500);

                        Random text3 = new Random();
                        int fraza = text3.Next(1, 2);
                        if (fraza == 1)
                        {
                            Thread.Sleep(500);
                            Console.Write("***** - ");
                            {
                                string text = "Благородная жертва. Играй Горностаем.";
                                int a = 100;

                                foreach (char c in text)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(a);
                                }
                                Console.WriteLine();
                            }
                        }

                        else
                        {
                            Thread.Sleep(500);
                            Console.Write("***** - ");
                            {
                                string text = "Блaгородная смерть. Играй Горностаем.";
                                int a = 100;

                                foreach (char c in text)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(a);
                                }
                                Console.WriteLine();
                            }
                        }

                        Console.Clear();

                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(500);
                        Console.Write("***** - ");
                        {
                            string te = "Играй Горностаем.";
                            int ab = 100;

                            foreach (char c in te)
                            {
                                Console.Write(c);
                                Thread.Sleep(ab);
                            }
                            Console.WriteLine();
                        }

                        void mesto_gornostaya()
                        {
                            Mesto_gornostai();
                        }
                        mesto_gornostaya();
                    }
                }
                else if (Mesto == 2)
                {
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |..БЕЛКА..| |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine(@"|         | | _  (\_  | |         | |         |");
                    Console.WriteLine(@"|         | |( \  ( '>| |         | |         |");
                    Console.WriteLine(@"|         | | ) \/_)= | |         | |         |");
                    Console.WriteLine("|         | |(_(_ )_  | |         | |         |");
                    Console.WriteLine("|         | |—————————| |         | |         |");
                    Console.WriteLine("|         | |.0.....1.| |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(500);
                    Console.Write("***** - ");
                    {
                        string text = "Теперь играй Горностаем.";
                        int a = 100;

                        foreach (char c in text)
                        {
                            Console.Write(c);
                            Thread.Sleep(a);
                        }
                        Console.WriteLine();
                    }

                    Thread.Sleep(500);
                    Console.Write("***** - ");
                    {
                        string text = "Цена Горностая - 1 капля крови. Необходимо кем то пожертвовать.";
                        int a = 100;

                        foreach (char c in text)
                        {
                            Console.Write(c);
                            Thread.Sleep(a);
                        }
                        Console.WriteLine();
                    }

                    Thread.Sleep(500);
                    Console.Write("***** - ");
                    {
                        string te = "Напиши число от 1 до 4 и пожертвуй этой картой.";
                        int ab = 100;

                        foreach (char c in te)
                        {
                            Console.Write(c);
                            Thread.Sleep(ab);
                        }
                        Console.WriteLine();
                    }

                    int mesto1 = 2;

                    while (true)
                    {
                        int a = int.Parse(Console.ReadLine());
                        if (a == mesto1)
                        {
                            break;
                        }
                        else
                        {
                            Thread.Sleep(500);
                            Console.Write("***** - ");
                            {
                                string te = "На этом месте нет карты.";
                                int ab = 100;

                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ab);
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                    Thread.Sleep(500);
                    Console.Clear();

                    if (mesto1 == 2)
                    {

                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|         | |\.БЕЛКА./| |         | |         |");
                        Console.WriteLine(@"|         | |—\—————/—| |         | |         |");
                        Console.WriteLine(@"|         | | _\ (\/  | |         | |         |");
                        Console.WriteLine(@"|         | |( \\ / '>| |         | |         |");
                        Console.WriteLine(@"|         | | ) //\)= | |         | |         |");
                        Console.WriteLine(@"|         | |(_/_ )\  | |         | |         |");
                        Console.WriteLine(@"|         | |—/—————\-| |         | |         |");
                        Console.WriteLine(@"|         | |/0.....1\| |         | |         |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(500);

                        Random text5 = new Random();
                        int fraza = text5.Next(1, 2);
                        if (fraza == 1)
                        {
                            Thread.Sleep(500);
                            Console.Write("***** - ");
                            {
                                string te = "Благородная жертва. Играй Горностаем.";
                                int ab = 100;

                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ab);
                                }
                                Console.WriteLine();
                            }
                        }

                        else
                        {
                            Thread.Sleep(500);
                            Console.Write("***** - ");
                            {
                                string te = "Блaгородная смерть. Играй Горностаем.";
                                int ab = 100;

                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ab);
                                }
                                Console.WriteLine();
                            }
                        }

                        Console.Clear();

                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(500);
                        Console.Write("***** - ");
                        {
                            string te = "Играй Горностаем.";
                            int ab = 100;

                            foreach (char c in te)
                            {
                                Console.Write(c);
                                Thread.Sleep(ab);
                            }
                            Console.WriteLine();
                        }

                        void mesto_gornostaya()
                        {
                            Mesto_gornostai();
                        }
                        mesto_gornostaya();
                    }
                }
                else if (Mesto == 3)
                {
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |..БЕЛКА..| |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine(@"|         | |         | | _  (\_  | |         |");
                    Console.WriteLine(@"|         | |         | |( \  ( '>| |         |");
                    Console.WriteLine(@"|         | |         | | ) \/_)= | |         |");
                    Console.WriteLine("|         | |         | |(_(_ )_  | |         |");
                    Console.WriteLine("|         | |         | |—————————| |         |");
                    Console.WriteLine("|         | |         | |.0.....1.| |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(500);
                    Console.Write("***** - ");
                    {
                        string text = "Теперь играй Горностаем.";
                        int a = 100;

                        foreach (char c in text)
                        {
                            Console.Write(c);
                            Thread.Sleep(a);
                        }
                        Console.WriteLine();
                    }

                    Thread.Sleep(500);
                    Console.Write("***** - ");
                    {
                        string text = "Цена Горностая - 1 капля крови. Необходимо кем то пожертвовать.";
                        int a = 100;

                        foreach (char c in text)
                        {
                            Console.Write(c);
                            Thread.Sleep(a);
                        }
                        Console.WriteLine();
                    }

                    Thread.Sleep(500);
                    Console.Write("***** - ");
                    {
                        string te = "Напиши число от 1 до 4 и пожертвуй этой картой.";
                        int ab = 100;

                        foreach (char c in te)
                        {
                            Console.Write(c);
                            Thread.Sleep(ab);
                        }
                        Console.WriteLine();
                    }

                    int mesto = 3;

                    while (true)
                    {
                        int a = int.Parse(Console.ReadLine());
                        if (a == mesto)
                        {
                            break;
                        }
                        else
                        {
                            Thread.Sleep(500);
                            Console.Write("***** - ");
                            {
                                string te = "На этом месте нет карты.";
                                int ab = 100;

                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ab);
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                    if (mesto == 3)
                    {
                        Thread.Sleep(500);
                        Console.Clear();

                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|         | |         | |\.БЕЛКА./| |         |");
                        Console.WriteLine(@"|         | |         | |—\—————/—| |         |");
                        Console.WriteLine(@"|         | |         | | _\ (\/  | |         |");
                        Console.WriteLine(@"|         | |         | |( \\ / '>| |         |");
                        Console.WriteLine(@"|         | |         | | ) //\)= | |         |");
                        Console.WriteLine(@"|         | |         | |(_/_ )\  | |         |");
                        Console.WriteLine(@"|         | |         | |—/—————\-| |         |");
                        Console.WriteLine(@"|         | |         | |/0.....1\| |         |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(500);

                        Random text3 = new Random();
                        int fraza = text3.Next(1, 2);
                        if (fraza == 1)
                        {
                            Thread.Sleep(500);
                            Console.Write("***** - ");
                            {
                                string text = "Благородная жертва. Играй Горностаем.";
                                int a = 100;

                                foreach (char c in text)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(a);
                                }
                                Console.WriteLine();
                            }
                        }

                        else
                        {
                            Thread.Sleep(500);
                            Console.Write("***** - ");
                            {
                                string text = "Блaгородная смерть. Играй Горностаем.";
                                int a = 100;

                                foreach (char c in text)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(a);
                                }
                                Console.WriteLine();
                            }
                        }

                        Console.Clear();

                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(500);
                        Console.Write("***** - ");
                        {
                            string te = "Играй Горностаем.";
                            int ab = 100;

                            foreach (char c in te)
                            {
                                Console.Write(c);
                                Thread.Sleep(ab);
                            }
                            Console.WriteLine();
                        }

                        void mesto_gornostaya()
                        {
                            Mesto_gornostai();
                        }
                        mesto_gornostaya();

                    }
                }
                else if (Mesto == 4)
                {
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                    Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                    Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                    Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                    Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                    Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("|         | |         | |         | |         |");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                    Console.WriteLine("|         | |         | |         | |..БЕЛКА..|");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine(@"|         | |         | |         | | _  (\_  |");
                    Console.WriteLine(@"|         | |         | |         | |( \  ( '>|");
                    Console.WriteLine(@"|         | |         | |         | | ) \/_)= |");
                    Console.WriteLine("|         | |         | |         | |(_(_ )_  |");
                    Console.WriteLine("|         | |         | |         | |—————————|");
                    Console.WriteLine("|         | |         | |         | |.0.....1.|");
                    Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                    Thread.Sleep(500);
                    Console.Write("***** - ");
                    {
                        string text = "Теперь играй Горностаем.";
                        int a = 100;

                        foreach (char c in text)
                        {
                            Console.Write(c);
                            Thread.Sleep(a);
                        }
                        Console.WriteLine();
                    }

                    Thread.Sleep(500);
                    Console.Write("***** - ");
                    {
                        string text = "Цена Горностая - 1 капля крови. Необходимо кем то пожертвовать.";
                        int a = 100;

                        foreach (char c in text)
                        {
                            Console.Write(c);
                            Thread.Sleep(a);
                        }
                        Console.WriteLine();
                    }

                    Thread.Sleep(500);
                    Console.Write("***** - ");
                    {
                        string te = "Напиши число от 1 до 4 и пожертвуй этой картой.";
                        int ab = 100;

                        foreach (char c in te)
                        {
                            Console.Write(c);
                            Thread.Sleep(ab);
                        }
                        Console.WriteLine();
                    }

                    int mesto = 4;

                    while (true)
                    {
                        int a = int.Parse(Console.ReadLine());
                        if (a == mesto)
                        {
                            break;
                        }
                        else
                        {
                            Thread.Sleep(500);
                            Console.Write("***** - ");
                            {
                                string te = "На этом месте нет карты.";
                                int ab = 100;

                                foreach (char c in te)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(ab);
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                    Thread.Sleep(500);
                    Console.Clear();

                    if (mesto == 4)
                    {
                        Thread.Sleep(1000);
                        Console.Clear();

                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|         | |         | |         | |\.БЕЛКА./|");
                        Console.WriteLine(@"|         | |         | |         | |—\—————/—|");
                        Console.WriteLine(@"|         | |         | |         | | _\ (\/  |");
                        Console.WriteLine(@"|         | |         | |         | |( \\ / '>|");
                        Console.WriteLine(@"|         | |         | |         | | ) //\)= |");
                        Console.WriteLine(@"|         | |         | |         | |(_/_ )\  |");
                        Console.WriteLine(@"|         | |         | |         | |—/—————\-|");
                        Console.WriteLine(@"|         | |         | |         | |/0.....1\|");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(500);

                        Random text3 = new Random();
                        int fraza = text3.Next(1, 2);
                        if (fraza == 1)
                        {
                            Thread.Sleep(500);
                            Console.Write("***** - ");
                            {
                                string text = "Благородная жертва. Играй Горностаем.";
                                int a = 100;

                                foreach (char c in text)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(a);
                                }
                                Console.WriteLine();
                            }
                        }

                        else
                        {
                            Thread.Sleep(500);
                            Console.Write("***** - ");
                            {
                                string text = "Блaгородная смерть. Играй Горностаем.";
                                int a = 100;

                                foreach (char c in text)
                                {
                                    Console.Write(c);
                                    Thread.Sleep(a);
                                }
                                Console.WriteLine();
                            }
                        }

                        Console.Clear();

                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                        Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                        Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                        Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                        Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                        Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("|         | |         | |         | |         |");
                        Console.WriteLine("——————————— ——————————— ——————————— ———————————");

                        Thread.Sleep(500);
                        Console.Write("***** - ");
                        {
                            string te = "Играй Горностаем.";
                            int ab = 100;

                            foreach (char c in te)
                            {
                                Console.Write(c);
                                Thread.Sleep(ab);
                            }
                            Console.WriteLine();
                        }

                        void mesto_gornostaya()
                        {
                            Mesto_gornostai();
                        }
                        mesto_gornostaya();

                    }
                }

                Console.Write("***** - ");
                {
                    string te = "Предпочту сдаться. Так как это твой первый поединок.";
                    int ad = 100;
                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ad);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(1000);
                Console.Clear();

                Console.Write("***** - ");
                {
                    string te = "Этот раунд за тобой.";
                    int ad = 100;
                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ad);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Clear();

                Console.Write("***** - ");
                {
                    string te = "Но чем дальше - тем сложнее.";
                    int ad = 100;
                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ad);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                Console.Clear();

                Console.Write("***** - ");
                {
                    string te = "Позволь мне заглянуть в твоё прошлое";
                    int ad = 100;
                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ad);
                    }

                    void igra()
                    {
                        igra1();
                    }
                    igra();
                }
                {
                    string te = "...";
                    int ad = 300;
                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ad);
                    }
                    Console.WriteLine();
                }
                Console.Write("***** - ");
                {
                    string te = "Ах, да";
                    int ad = 100;
                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ad);
                    }
                }
                {
                    string te = "...";
                    int ad = 300;
                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ad);
                    }
                    Console.WriteLine();
                }
            }
            else if (start == 2)
            {
                void game()
                {
                    igra1();
                }
                game();
            }
            else if (start == 3)
            {
                void t()
                {
                    tiri();
                }
                t();
            }
        }                         // обучение 

        // титры
        static void tiri()
        {
            // Создаем массив строк для хранения титров концовки игры
            string[] credits =
            {
                "Разработчики:",                      // Первая строка титров
                "Питолин Миша",                 // Имя первого разработчика
                "Строганов Макс",                 // Имя второго разработчика
                "Бохан Стас",                 // Имя третьего разработчика
                "Бохан Андрей",                 // Имя чтвёртого разработчика
                "",                                   // Пустая строка для создания паузы в титрах
                "Игра создана в 2023 году"             // Последняя строка с информацией о годе создания игры

            };
            // Отображение каждой строки титров с небольшой задержкой
            foreach (string line in credits)
            {
                Console.WriteLine(line);
                Thread.Sleep(1000); // Создание паузы в одну секунду между строками титров
            }
            string text = "Каждый из нас 4 отвечал за что то своё.";
            int a = 100;

            Console.WriteLine();

            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(a);
            }
            Console.WriteLine();
            string text1 = "Миша - писал код (основа нашей игры).";
            int a1 = 100;

            foreach (char c in text1)
            {
                Console.Write(c);
                Thread.Sleep(a1);
            }
            Console.WriteLine();
            string text2 = "Стас - был автором общей картины игры , а именно созданием сюжета, соавтором создания анимаций в игре.";
            int a2 = 100;

            foreach (char c in text2)
            {
                Console.Write(c);
                Thread.Sleep(a2);
            }
            Console.WriteLine();
            string text3 = "Андрей - это наш дизайнер).";
            int a3 = 100;

            foreach (char c in text3)
            {
                Console.Write(c);
                Thread.Sleep(a3);
            }
            Console.WriteLine();
            string text4 = "Макс - он являлся формальным дизайнером. Рисовал ASCII арты карт, мест и локаций.";
            int a4 = 100;

            foreach (char c in text4)
            {
                Console.Write(c);
                Thread.Sleep(a4);
            }
            Console.WriteLine();
            string text5 = "Игра вдохнавлялась картиной INSCRYPTION.";
            int a5 = 100;

            foreach (char c in text5)
            {
                Console.Write(c);
                Thread.Sleep(a5);
            }
            Console.WriteLine();
            string text6 = "Идеей создания данной игры служила: 'Чисто поиграть, портация игры на мобильные устройства'.";
            int a6 = 100;

            foreach (char c in text6)
            {
                Console.Write(c);
                Thread.Sleep(a6);
            }
            Console.WriteLine();
            Console.ReadLine(); // Для того, чтобы окно консоли не закрывалось сразу после вывода титров
        }

        // программа
        static void Main(string[] args)
        {
            void obychenie1()
            {
                obychenie();
            }
            obychenie1();
        }
    }
}