﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_da_memoria
{
    internal class Player
    {
        //ATRIBUTOS 
        private string _name;
        private int _score;

        //MÉTODOS 
        public Player(string name)
        {
            _name = name;
        }

        public string Name;
        {
            { get { return _name; } }

        }
        
    }
}
