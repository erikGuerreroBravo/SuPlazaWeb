﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodetech.Administrador.Domain
{
    public class ClienteDM
    {
        public string IdCliente { get; set; }
        public string Rfc { get; set; }
        public string Razon_Social { get; set; }
        public string Contacto { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public int IdMunicipio { get; set; }
        public int IdEntidad { get; set; }
    }
}