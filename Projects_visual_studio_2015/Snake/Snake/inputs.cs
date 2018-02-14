using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class inputs
    {
        //Load list of available keyboard buttons
        private static System.Collections.Hashtable keyTable = new System.Collections.Hashtable();

        //perform a check to see if a particular button is pressed.
        public static bool KeyPressed(Keys key)
        {
            if(keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        //Detect if keyboarf button is pressed
        public static void changeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
