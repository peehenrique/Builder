namespace Builder;

public class GadgetDirector
{
    protected SmartPhoneBuilder _smartPhoneBuilder;

    public GadgetDirector(SmartPhoneBuilder smartPhoneBuilder)
    {
        _smartPhoneBuilder = smartPhoneBuilder;
    }

    public void MakePhone()
    {
        _smartPhoneBuilder.BuildBrand();
        _smartPhoneBuilder.BuildColor();
        _smartPhoneBuilder.BuildName();
        _smartPhoneBuilder.BuildPrice();
        _smartPhoneBuilder.BuildScreen();
    }

    public SmartPhoneProduct GetSmartPhone()
    {
        return _smartPhoneBuilder.GetSmartPhone();
    }
}