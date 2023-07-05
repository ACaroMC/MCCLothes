﻿using Microsoft.AspNetCore.Mvc.Rendering;
using PruebaNetCore_Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNetCore_AccesoDatos.Datos.Repositorio.IRepositorio
{
    public interface IOrdenRepositorio :IRepositorio<Orden>
    {
        void Actualizar(Orden orden);
        
    }
}
