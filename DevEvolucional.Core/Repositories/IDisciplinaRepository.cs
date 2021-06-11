using DevEvolucional.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevEvolucional.Core.Repositories
{
    public interface IDisciplinaRepository
    {
        Task<List<DisciplinaDTO>> GetAllAsync(); 
    }
}
