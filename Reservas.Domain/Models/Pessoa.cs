﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain
{
    public class Pessoa
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string data_nascimento { get; set; }
        public string email { get; set; }
        public string telefone{ get; set; }
        public string cpf { get; set; }
    } 
}
