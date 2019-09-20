using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTestManager.Levels
{
    public class LevelThree: ILevel
    {
        public async Task<bool> ValidatePasswordAsync(string password)
        {
            return await new Builder(new Factory())
                .AddValidateLength(12)
                .AddValidateSpecialDigit()
                .AddValidateNumberInTheMiddle()
                .AddValidateTop()
                .ExecuteAsync(password);
        }
    }
}
