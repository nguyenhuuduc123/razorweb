using System.ComponentModel.DataAnnotations;

public class sochan : ValidationAttribute{
    public sochan() => ErrorMessage = " {0} phai nhap";
    public override bool IsValid(object value)
    {
        return base.IsValid(value);
    }
}