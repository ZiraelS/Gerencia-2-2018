﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGerencia.DataBase.Entities
{
    public class PersonaJuridica
    {
        public int PersonaJuridicaId { get; set; }

        public string Correo { get; set; }

        public string Contrasena { get; set; }

        public string Documento { get; set; }

        public bool Activacion { get; set; }

        public virtual ICollection<Cuenta> Operadores { get; set; }

        public virtual ICollection<RepresentanteLegal> RepresentanteLegales { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}