using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTestManager.Levels
{
    public class LevelTwo : ILevel
    {
        public async Task<bool> ValidatePasswordAsync(string password)
        {
            return await new Builder(new Factory())
                .AddValidateLength(8)
                .AddValidateNumberInTheMiddle()
                .AddValidateTop()
                .ExecuteAsync(password);
        }

    }
}
