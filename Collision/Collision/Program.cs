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
        // enthält den Pfad der config.ini Datei, Achtung der Dateipfad muss angepasst werden!!!!
        static string DateiPfad = @"C:\Users\Isaak\Desktop\4_ CollideB\Collision\";
        static string DateiName = "config.ini";
        static string VollstaendigerPfad = DateiPfad + DateiName;

        static void Main(string[] args)
        {
            Console.WindowWidth = seite * 2;
            Console.WindowHeight = seite;
            Console.Clear();
            Random ZG = new Random();
            int Anzahl = ZG.Next(1, 6);
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
            LoadConfig(ref Anzahl);
        }
                       

        //Hier wird die Standard-Konfigurationsdatei config.ini erstellt oder geändert und die Anzahl
        //eingetragen. Sollte die Datei nicht erstellt werden können, wird ein Rückgabewert false retourniert.
        //Ansonsten ist der Rückgabewert true.
        static bool SaveConfig(int Anzahl)
        {
            bool confErstellt;
           
            //Erstellt und beschreibt die config.ini Datei
            using (StreamWriter sw = new StreamWriter(VollstaendigerPfad))
            {
                sw.WriteLine("{0};", Anzahl);
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
            bool confGelesen = true;

            //Alles was in der config.ini steht
            string config = "";
            //wird benötigt um die config.ini Datei Zeile für Zeile auszulesen
            string line = "";

            //Kontrolliert ob es die Config Datei gibt
            if (File.Exists(VollstaendigerPfad))
            {
                //Liest die config.ini aus und speichert es in config
                using (StreamReader sr = new StreamReader(VollstaendigerPfad))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        config += line;
                    }
                }
                //splitet den Inhalt der config.ini bei';'
                string[] ArraySplitConfig = config.Split(';');

                //Kontrolliert ob etwas geschrieben wurde
                if (ArraySplitConfig[0] != "")
                {
                    Anzahl = Convert.ToInt16(ArraySplitConfig[0]);
                }

                else
                {
                    Anzahl = 0;
                    confGelesen = false;
                }

            }
            else
            {
                Anzahl = 0;
                confGelesen = false;
            }
            return confGelesen;
        }
    }
}
