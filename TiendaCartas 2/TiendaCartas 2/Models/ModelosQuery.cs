using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaCartas_2.Models
{
    public class ModelosQuery
    {
        public String nombrePro { get; set; }
        public String fotoPro { get; set; }
        public IEnumerable<ModelosQuery> Valores { get; set; }
        public ModelosQuery()
        {
            
        }
        public void GetEnumerator()
        {
            Valores.GetEnumerator().MoveNext();
        }
    }
}