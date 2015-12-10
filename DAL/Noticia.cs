﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    [Serializable]
    public class Noticia
    {
        #region Properties

        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public string Cuerpo { get; set; }
        public int? IdCategoria { get; set; }

        #endregion

        #region Constructor

        public Noticia()
            : base()
        {
        }

        #endregion
    }
}