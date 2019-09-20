using System.Threading.Tasks;

namespace PasswordTestManager.Validators
{
    public abstract class Validator
    {
        private Validator _successor;

        public void SetSuccessor(Validator successor)
        {
            _successor = successor;
        }

        public virtual Task<bool> ValidAsync(string password)
        {
            _successor?.ValidAsync(password);

            return Task.FromResult(true);
        }
    }
}
