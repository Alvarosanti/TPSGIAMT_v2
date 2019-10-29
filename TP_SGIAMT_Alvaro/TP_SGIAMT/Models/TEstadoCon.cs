﻿using System;
using System.Collections.Generic;

namespace TP_SGIAMT.Models
{
    public partial class TEstadoCon
    {
        public TEstadoCon()
        {
            TConcurso = new HashSet<TConcurso>();
        }

        public int PkIeIdEstado { get; set; }
        public string VeNombreEsta { get; set; }

        public ICollection<TConcurso> TConcurso { get; set; }
    }
}
