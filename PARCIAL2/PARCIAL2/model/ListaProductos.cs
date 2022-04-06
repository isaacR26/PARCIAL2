using PARCIAL2.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL2
{

    public static class managerlist
    {
        public static List<product> GList = new List<product>();
    }

    internal class ListaProductos
    {
        public List<product> dataproduct = new List<product>();

        public void xdefecto()
        {
            dataproduct.Add(new product()
            {
                nombre = "Smirnoff",
                precio = 45000,
                desc = "750 ml."
                
            });
        }

    }
    
}
