using PasswordTestManager.Validators;

namespace PasswordTestManager
{
    public class Factory : AbstractFactory
    {
        public override LengthValidator GenerateLengthValidator(int lenght)
        {
            return new LengthValidator(lenght);
        }

        public override SpecialDigitValidator GenerateSpecialDigitValidator()
        {
            return new SpecialDigitValidator();
        }

        public override NumberInTheMiddleValidator GenerateNumberInTheMiddleValidator()
        {
            return new NumberInTheMiddleValidator();
        }

        public override TopValidator GenerateTopValidator()
        {
            return new TopValidator();
        }
    }

}
