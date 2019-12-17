﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class Roupa
    {
        public int RoupaId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
