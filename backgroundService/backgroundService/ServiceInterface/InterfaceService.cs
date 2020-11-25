using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace backgroundService.ServiceInterface
{
    public interface InterfaceService
    {
        Task<string> GetCoordenadas();
    }
}
