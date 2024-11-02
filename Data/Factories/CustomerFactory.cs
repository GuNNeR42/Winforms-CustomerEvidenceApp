using CustomerEvidenceApp.Data.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace CustomerEvidenceApp.Data.Factories
{
    public class CustomerFactory: BaseFactory<Customer>
    {
        public CustomerFactory(string locale = "cz"): base(locale)
        {
            Faker
                .RuleFor(c => c.Gender, f => f.PickRandom<Gender>().ToString())
                .RuleFor(c => c.FullName, (f, c) => f.Name.FullName()) //TODO: Add full-names by gender
                .RuleFor(c => c.Birthday, f => f.Date.Past(100))
                .RuleFor(c => c.IQ, f => f.Random.Number(10, 220))
                .RuleFor(c => c.GdprAgreement, f => f.Random.Bool());
        }

        public override Customer Generate() => Faker.Generate();
        public enum Gender
        {
            Male,
            Female
        }
    }
}
