using FluentValidation;
using FluentValTest.Models;
using FluentValTest.Services;

namespace FluentValTest.Validations;

public class ModelValidator : AbstractValidator<Model>
{
    public ModelValidator(IService service)
    {
        var ids = service.Get();

        RuleFor(model => model.Id).Must(id => !ids.Contains(id));
    }
}
