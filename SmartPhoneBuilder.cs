namespace Builder;

public abstract class SmartPhoneBuilder
{
    protected readonly SmartPhoneProduct _smartPhoneProduct;

    public SmartPhoneBuilder()
    {
        _smartPhoneProduct = new SmartPhoneProduct();
    }

    public abstract void BuildBrand();
    public abstract void BuildColor();
    public abstract void BuildName();
    public abstract void BuildPrice();
    public abstract void BuildScreen();

    public SmartPhoneProduct GetSmartPhone()
    {
        return _smartPhoneProduct;
    }
}