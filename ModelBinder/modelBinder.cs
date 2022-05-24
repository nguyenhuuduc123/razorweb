using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

public class binder : IModelBinder
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        // get name

     var modelName = bindingContext.ModelName;
     var valueProvider =   bindingContext.ValueProvider.GetValue(modelName);
     var first = valueProvider.FirstValue;
     first  = first.Trim();
     
        throw new System.NotImplementedException();
    }
}