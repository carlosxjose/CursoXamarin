using CursoXamarin.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CursoXamarin.Interfaces
{
    public interface IMaestro
    {
        [Get("/api/v1/NetCoreAPI/InventarioMaestro")]
        Task<List<InventarioMaestro>> GetInventarioMaestro();

        [Get("/api/v1/NetCoreAPI/InventarioMaestro/id?id={id}")]

        Task<List<InventarioMaestro>> GetInventarioMaestroById(string id);//string id);//[Query] int id);///[AliasAs("id")] int id);
    }
}
