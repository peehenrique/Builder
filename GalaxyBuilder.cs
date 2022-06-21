namespace Builder;

public class GalaxyBuilder : SmartPhoneBuilder
{
    public override void BuildBrand()
    {
        _smartPhoneProduct.Brand = "Samsung";
    }

    public override void BuildColor()
    {
        _smartPhoneProduct.Color = "Black";
    }

    public override void BuildName()
    {
        _smartPhoneProduct.Name = "Galaxy 2022";
    }

    public override void BuildPrice()
    {
        _smartPhoneProduct.Price = 2.200;
    }

    public override void BuildScreen()
    {
        _smartPhoneProduct.Screen = 8.1;
    }
}