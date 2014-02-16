using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    class Program
    {
        /// <summary>
        /// Eintritspunkt des Programmes
        /// </summary>
        /// <param name="args">Eine Liste von Übergabeparametern.</param>
        static void Main(string[] args)
        {
            try
            {
                bool quit = false;
                Movement move = new Movement();

                /*do
                {
                    // Pausiert das Programm für 10 Millisekunden
                    System.Threading.Thread.Sleep(10);
                    // Punkte und Linien neu setzen
                    //move.update();
                    // Programm beenden, wenn die rechte und linke Hand nach oben-rechts gehalten werden.
                    if (move.body.handRight.x >= 0.5 & move.body.handRight.y >= 0.5 & move.body.handLeft.x >= 0.5 & move.body.handLeft.y >= 0.5)
                    {
                        quit = true;
                    }

                } while (quit == false);
                
                // Programm beenden
                move.end();*/
                Console.Read();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
