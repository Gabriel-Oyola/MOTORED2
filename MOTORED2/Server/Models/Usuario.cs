﻿using System;
using System.Collections.Generic;

namespace MOTORED2.Server.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; }

    public string Correo { get; set; }

    public string Clave { get; set; }
}
