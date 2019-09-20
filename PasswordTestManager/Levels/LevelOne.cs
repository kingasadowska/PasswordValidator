using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTestManager.Levels
{
    public class LevelOne : ILevel
    {
        public async Task<bool> ValidatePasswordAsync(string password)
        {
            return await new Builder(new Factory())
                .AddValidateLength(5)
                .AddValidateTop()
                .ExecuteAsync(password);
        }
    }
}
