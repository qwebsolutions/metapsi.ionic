using Metapsi.Syntax;

namespace Metapsi.Ionic;

//...

// TODO:
// IonActionSheetButtonsBuilder - combine string + Action sheet button
// enterAnimation, etc - AnimationsBuilder
// IonicSafeString

public delegate Animation AnimationBuilder(object baseEl, object opts);

public static class TestExtensions
{
    public static void SetEnterAnimation(this PropsBuilder<IonActionSheet> b, Var<AnimationBuilder> enterAnimation)
    {
        b.SetProperty(b.Props, b.Const("animationBuilder"), enterAnimation);
    }
}

public class TouchEvent
{

}

public class RangeValues
{
    public decimal lower { get; set; }
    public decimal upper { get; set; }
}

public class SplitPaneVisibleEventDetail
{
    public bool visible { get; set; }
}

public class TabsDidChangeEventDetail
{
    public string tab { get; set; }
}

public class TabsWillChangeEventDetail
{
    public string tab { get; set; }
}

public class HTMLIonTabElement
{

}
// TODO: Temporary, this belongs to the DOM API
public class HTMLTextAreaElement
{

}