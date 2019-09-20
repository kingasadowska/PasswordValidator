using PasswordTestManager.Validators;

namespace PasswordTestManager
{
    public abstract class AbstractFactory
    {
        public abstract LengthValidator GenerateLengthValidator(int length);

        public abstract SpecialDigitValidator GenerateSpecialDigitValidator();

        public abstract NumberInTheMiddleValidator GenerateNumberInTheMiddleValidator();

        public abstract TopValidator GenerateTopValidator();
    }
}
