using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abstracciones.Interfaces.Flujo
{
    public interface IVehiculoFlujo
    {
        Task<IEnumerable<VehiculoResponse>> Obtener();
        Task<VehiculoDetalle> Obtener(Guid Id);
        Task<Guid> Agregar(VehiculoRequest Vehiculo);
        Task<Guid> Editar(Guid Id, VehiculoRequest vehiculo);
        Task<Guid> Eliminar(Guid Id);
    }
}