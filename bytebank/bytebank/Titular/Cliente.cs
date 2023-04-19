﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public static int TotalDeClientesCadastrados { get; set; }
    
        public Cliente() {
            TotalDeClientesCadastrados++;        
        }
    }

}