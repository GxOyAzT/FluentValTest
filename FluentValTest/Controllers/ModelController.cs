using FluentValidation;
using FluentValTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValTest.Controllers;
[ApiController]
[Route("[controller]")]
public class ModelController : ControllerBase
{
    private readonly IValidator<Model> modelValidator;

    public ModelController(
        IValidator<Model> modelValidator)
    {
        this.modelValidator = modelValidator;
    }

    [HttpPost]
    public IActionResult PostModel([FromBody] Model model)
    {
        modelValidator.ValidateAndThrow(model);
        return Ok();
    }
}
