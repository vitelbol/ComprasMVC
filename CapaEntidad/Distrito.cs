﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Distrito
    {
        public string IdDistrito { get; set; }
        public string Descripcion { get; set; }
    }
}
/*create table distrito(
IdDistrito varchar(4) not null,
Descripcion varchar(45) not null,
IdProvincia varchar(4) not null,
IdDepartamento varchar(2) null
)*/