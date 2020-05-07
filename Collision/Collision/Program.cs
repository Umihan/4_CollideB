using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/*
 *  Collide
 *  Eine Simulation im 2-dimensionalen Raum
 * 
 * c) Julian Mazohl
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
                Console.SetCursorPosition(posx,posy);                       //Setzt den Cursor auf Position X,Y
                Console.ForegroundColor = ConsoleColor.Green;               //Ändert die Farbe auf grün
                Console.Write("©");                                         //Zechnet ein Objekt
                Console.ResetColor();                                       //Farbe zurücksetzen
            }
            void hide()
            {
                Console.SetCursorPosition(posx, posy);                      //Setzt den Cursor auf Position X,Y
                Console.Write(" ");                                         //Hier wird das Objekt an der aktuellen Position gelöscht
            }
            void collide()
            {
                Console.SetCursorPosition(posx, posy);                      //Setzt den Cursor auf Position X,Y wenn eine Kollision entdeckt wird
                Console.ForegroundColor = ConsoleColor.Red;                 //Ändert die Farbe auf rot
                Console.Write("K");                                         //Schreibt an dieser Position ein "K" raus
                Console.ResetColor();                                       //Farbe zurücksetzen
                Move();
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
    }
}
