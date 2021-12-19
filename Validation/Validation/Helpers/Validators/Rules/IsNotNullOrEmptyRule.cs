
namespace Validation.Helpers.Validators.Rules
{
    public class IsNotNullOrEmptyRule<T> : IValidationRule<T>
    {
        public string ValidationMessage { get; set; }

        public IsNotNullOrEmptyRule()
        {

        }

        public bool Check(T value)
        {
            if (value == null)
            {
                return false;
            }

            var str = $"{value }";
            return !string.IsNullOrWhiteSpace(str);
        }
    }
}
