namespace Builder;

public class IphoneBuilder : SmartPhoneBuilder
{
    public override void BuildBrand()
    {
        _smartPhoneProduct.Brand = "Apple";
    }

    public override void BuildColor()
    {
        _smartPhoneProduct.Color = "Blue";
    }

    public override void BuildName()
    {
        _smartPhoneProduct.Name = "IPhone 13 Pro Max";
    }

    public override void BuildPrice()
    {
        _smartPhoneProduct.Price = 1.200;
    }

    public override void BuildScreen()
    {
        _smartPhoneProduct.Screen = 6.7;
    }
}