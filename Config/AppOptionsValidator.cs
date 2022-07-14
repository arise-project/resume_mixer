namespace resume_mixer.Config
{
    public class AppOptionsValidator : IValidateOptions<AppOptions>
    {
        public ValidateOptionsResult Validate(string name, AppOptions options)
        {
            IList<string> validationFailures = new List<string>();

            if (string.IsNullOrEmpty(options.Foo))
                validationFailures.Add("Foo is required.");

            return validationFailures.Any()
            ? ValidateOptionsResult.Fail(validationFailures)
            : ValidateOptionsResult.Success;
        }
    }
}