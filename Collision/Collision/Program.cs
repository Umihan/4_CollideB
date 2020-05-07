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
            SaveConfig(Anzahl);
        }
        // enthält den Pfad der congig.ini Datei;
        static string VollstaendigerPfad;   

        //Hier wird die Standard-Konfigurationsdatei config.ini erstellt oder geändert und die Anzahl
        //eingetragen. Sollte die Datei nicht erstellt werden können, wird ein Rückgabewert false retourniert.
        //Ansonsten ist der Rückgabewert true.
        static bool SaveConfig(int Anzahl)
        {           
            bool confErstellt;

            //gibt den Dateipfad und Namen der config.ini Datei an
            string DateiPfad = @"C:\Users\Isaak\Desktop\4_ CollideB\Collision\";
            string DateiName = "config.ini";
            VollstaendigerPfad = DateiPfad + DateiName;

            //Erstellt und beschreibt die config.ini Datei
            using(StreamWriter sw = new StreamWriter(VollstaendigerPfad))
            {
                sw.WriteLine("Anzahl;{0}", Anzahl);
            }
           
            //Kontrolliert ob die config.ini Datei erstellt wurde
            confErstellt = File.Exists(VollstaendigerPfad);

            return confErstellt;
        }

        //Hier wird die Standard-Konfigurationsdatei config.ini ausgelesen und die Anzahl zurückgegeben.
        //Sollte die Datei nicht existieren oder keine Anzahl enthalten, wird in Anzahl der Wert 0 und 
        //ein Rückgabewert false retourniert. Ansonsten ist der Rückgabewert true.
        static bool LoadConfig(ref int Anzahl)
        {
            bool confGelesen= true;

            return confGelesen;
        }
    }
}
