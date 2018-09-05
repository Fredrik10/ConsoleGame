using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        /// <summary>
        /// //Initiera värden i början av programmet 
        /// </summary>
        static void Initialize ()
        {

        }
        /// <summary>
        /// Ritar ut på bildskärmen
        /// </summary>
        static void Draw()
        {

        }
        /// <summary>
        /// AInnehåller pogrammets logik
        /// </summary>
        static void Update()
        {

        }
        /// <summary>
        /// Ett spel (syns inte i MonoGame)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Initialize();
            
            while(true)
            {
                Update();
                Draw();
            }


        }
    }
}
