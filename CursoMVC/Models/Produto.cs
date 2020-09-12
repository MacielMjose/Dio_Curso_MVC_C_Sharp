﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria categoria { get; set; }

        public List<Produto> Produtos{ get; set; }

    }
}
