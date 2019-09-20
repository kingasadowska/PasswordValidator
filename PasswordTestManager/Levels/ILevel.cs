using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTestManager.Levels
{
    public interface ILevel
    {
        Task<bool> ValidatePasswordAsync(string password);
    }
}
