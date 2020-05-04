using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/*
 *  Collide
 *  Eine Simulation im 2-dimensionalen Raum
 * 
 * 
 * 
 * 2020 TFO-Meran
 */

namespace ConsoleApplication1
{
    class Program
    {
        const int seite = 50;
        static int[,] feld = new int[seite, seite];

        class einer
        {
            // Private Eigenschaften

            // Öffentliche Eigenschaften
            public int posx, posy;
            public ConsoleColor farbe;
            // Konstruktor
            public einer()
            {
            }
            //Private Methoden
            void show()
            {
            }
            void hide()
            {
            }
            void collide()
            {
            }
            //Öffentliche Methoden
            public void Move()
            {
            }

        }

        static void Main(string[] args)
        {
            Console.WindowWidth = seite*2;
            Console.WindowHeight = seite;
            Console.Clear();
            Random ZG = new Random();
            int Anzahl=ZG.Next(1,6);
            einer[] meineEiner = new einer[Anzahl];
            for (int i = 0; i < Anzahl; i++)
            {
                meineEiner[i] = new einer();
            }
            Console.CursorVisible = false;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < Anzahl; j++)
                {
                    meineEiner[j].Move();
                }
                System.Threading.Thread.Sleep(10);

            }
        }

        static bool SaveConfig(ref int Anzahl)
        {
            var path = @"D:\GIT\CollideB\4_CollideB\config.ini";
            string text = Convert.ToString(Anzahl);
            File.WriteAllText(path, text);

            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static bool LoadConfig(ref int Anzahl)
        {
            var path = @"D:\GIT\CollideB\4_CollideB\config.ini";

            string Rueckgabe = File.ReadAllText(path);
            int ueberpruefung = Convert.ToInt32(Rueckgabe);

            Anzahl = ueberpruefung;

            if (File.Exists(path) & ueberpruefung > 0)
            {
                Anzahl = ueberpruefung;
                return true;
            }
            else
            {
                Anzahl = 0;
                return false;
            }
        }

    }
}
