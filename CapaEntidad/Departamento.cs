﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Departamento
    {
        public string IdDepartamento { get; set; }
        public string Descripcion { get; set; }
    }
}

/*create table departamento(
IdDepartamento varchar(2) not null,
Descripcion varchar(45) not null
)*/