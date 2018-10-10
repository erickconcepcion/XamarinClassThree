using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseTres
{
    public class Comida
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string ImageUrl { get; set; }
        public string Details { get { return $"Precio: {Precio}RD$, Cantidad: {Cantidad}"; } }

    }
}
