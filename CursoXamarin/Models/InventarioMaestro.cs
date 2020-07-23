using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoXamarin.Models
{
    public class InventarioMaestro
    {
        [JsonProperty(PropertyName = "id")]
        public int key1 { get; set; }
        public string tipo { get; set; }
        public string codigo { get; set; }
        public string nombreF { get; set; }
        public string referencia { get; set; }
        public object idCodControl { get; set; }
        public int idGrp1 { get; set; }
        public double costoUc { get; set; }
        public double costoPro { get; set; }
        public double precioM { get; set; }
        public double precioE { get; set; }
        public double precioR { get; set; }
        public DateTime? fechaR { get; set; }
        public bool stsPos { get; set; }
        public bool stsNulo { get; set; }
        //public object idCodControlNavigation { get; set; }
        //public object idGrp1Navigation { get; set; }
    }

    public class Root
    {
        public List<InventarioMaestro> Maestro { get; set; }
    }
    //public class Root
    //{
    //    public List<Fuel> Fuel { get; set; }
    //}
}
