using System;
using System.Collections.Generic;
using System.Text;

namespace DevEvolucional.Core.Services
{
    public interface IAuthService
    {
        string GenerateJwtToken(string login);
        string ComputeSha256Hash(string password);
    }
}
