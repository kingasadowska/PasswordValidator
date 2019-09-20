using System.Threading.Tasks;
using PasswordTestManager.Validators;

namespace PasswordTestManager
{
    public class Builder
    {
        private Validator Current { get; set; }
        private AbstractFactory Factory { get; }

        public Builder(AbstractFactory factory)
        {
            Factory = factory;
        }

        public Builder AddValidateLength(int length)
        {
            var lengthValidator = Factory.GenerateLengthValidator(length);
            Current?.SetSuccessor(lengthValidator);
            if (Current == null)
            {
                Current = lengthValidator;
            }
            return this;
        }

        public Builder AddValidateNumberInTheMiddle()
        {
            var numberInTheMiddleValidator = Factory.GenerateNumberInTheMiddleValidator();
            Current?.SetSuccessor(numberInTheMiddleValidator);
            if (Current == null)
            {
                Current = numberInTheMiddleValidator;
            }
            return this;
        }

        public Builder AddValidateSpecialDigit()
        {
            var specialDigitValidator = Factory.GenerateSpecialDigitValidator();
            Current?.SetSuccessor(specialDigitValidator);
            if (Current == null)
            {
                Current = specialDigitValidator;
            }
            return this;
        }


        public Builder AddValidateTop()
        {
            var topValidator = Factory.GenerateTopValidator();
            Current?.SetSuccessor(topValidator);
            if (Current == null)
            {
                Current = topValidator;
            }
            return this;
        }

        public async Task<bool> ExecuteAsync(string password)
        {
            if (Current == null)
            {
                return true;
            }
            return await Current.ValidAsync(password);
        }
    }
}
