using Senai.InLock.WebApi.Domains;
using System.Collections.Generic;

namespace Senai.InLock.WebApi.Interfaces
{
    interface IEstudioRepository
    {
        List<EstudioDomain> Listar(); 
    }
}
