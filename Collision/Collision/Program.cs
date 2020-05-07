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

            Random random_position = new Random();
            Random random_farbe = new Random();

            /// <summary>
            /// Hier soll ein neues Objekt initialisiert werden, und zwar muss eine freie Position im Feld zufällig gewählt werden, an dem dieses Objekt seine Startposition hat.Ebenso wird eine Zufallsfarbe (ConsoleColor) für das Objekt gewählt.
            /// </summary>
            public einer()
            {

                int posx = 0;
                int posy = 0;

                bool positionfrei = false;


                //Objekte werden mit einer zeitverzögerung erstellt
                System.Threading.Thread.Sleep(20);


                //die Eigenschaft "farbe" wird initialisiert
                farbe = (ConsoleColor)random_farbe.Next(0, 16);


                //Finden einer freien Position
                do
                {
                    posx = random_position.Next(1, seite);
                    posy = random_position.Next(1, seite);

                    if (feld[posx, posy] == 0)
                    {
                        positionfrei = true;
                    }
                }
                while (positionfrei == false);

                this.posx = posx;
                this.posy = posy;

                feld[posx, posy] = 1;
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
    }
}
