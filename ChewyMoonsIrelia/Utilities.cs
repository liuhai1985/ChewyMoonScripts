﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;

namespace ChewyMoonsIrelia
{
    class Utilities
    {
        /// <summary>
        /// Thanks honda <3
        /// </summary>
        /// <param name="msg"></param>
        public static void PrintChat(string msg)
        {
            Game.PrintChat("<font color=\"#6699ff\"><b>ChewyMoon's Irelia:</b></font> <font color=\"#FFFFFF\">" + msg + ".</font>");
        }
    }
}
