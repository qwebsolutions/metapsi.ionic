using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonItemOptions
{

    /// <summary>
    /// The side the option button should be on. Possible values: `"start"` and `"end"`. If you have multiple `ion-item-options`, a side must be provided for each.
    /// </summary>
    public string side { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonItemOptionsControl
{
    /// <summary>
    /// Builds a "ion-item-options" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemOptions(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonItemOptions>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-item-options", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-item-options" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemOptions(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-item-options", children);
    }

    /// <summary>
    /// Builds a "ion-item-options" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemOptions(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonItemOptions>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-item-options", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-item-options" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemOptions(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-item-options", children);
    }

    /// <summary>
    /// The side the option button should be on. Possible values: `"start"` and `"end"`. If you have multiple `ion-item-options`, a side must be provided for each.
    /// </summary>
    public static void SetSideStart(this Metapsi.Html.AttributesBuilder<IonItemOptions> b)
    {
        b.SetAttribute("side", "start");
    }

    /// <summary>
    /// The side the option button should be on. Possible values: `"start"` and `"end"`. If you have multiple `ion-item-options`, a side must be provided for each.
    /// </summary>
    public static void SetSideEnd(this Metapsi.Html.AttributesBuilder<IonItemOptions> b)
    {
        b.SetAttribute("side", "end");
    }
    /// <summary>
    /// Builds a virtual "ion-item-options" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemOptions(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonItemOptions>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-item-options", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-item-options" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemOptions(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-item-options", children);
    }

    /// <summary>
    /// Builds a virtual "ion-item-options" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemOptions(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonItemOptions>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-item-options", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-item-options" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemOptions(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-item-options", children);
    }

    /// <summary>
    /// The side the option button should be on. Possible values: `"start"` and `"end"`. If you have multiple `ion-item-options`, a side must be provided for each.
    /// </summary>
    public static void SetSideStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOptions
    {
        b.SetProperty(b.Const("side"), b.Const("start"));
    }

    /// <summary>
    /// The side the option button should be on. Possible values: `"start"` and `"end"`. If you have multiple `ion-item-options`, a side must be provided for each.
    /// </summary>
    public static void SetSideEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOptions
    {
        b.SetProperty(b.Const("side"), b.Const("end"));
    }

    /// <summary>
    /// Emitted when the item has been fully swiped.
    /// </summary>
    public static void OnIonSwipe<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonItemOptions
    {
        b.SetProperty(b.Const("onionSwipe"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the item has been fully swiped.
    /// </summary>
    [System.Obsolete]
    public static void OnIonSwipe<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonItemOptions
    {
        b.OnIonSwipe(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the item has been fully swiped.
    /// </summary>
    public static void OnIonSwipe<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonItemOptions
    {
        b.SetProperty(b.Const("onionSwipe"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the item has been fully swiped.
    /// </summary>
    [System.Obsolete]
    public static void OnIonSwipe<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonItemOptions
    {
        b.OnIonSwipe(b.MakeAction(action));
    }
}
public static partial class IonItemOptionsExtensions
{

    /// <summary>
    /// The side the option button should be on. Possible values: `"start"` and `"end"`. If you have multiple `ion-item-options`, a side must be provided for each.
    /// </summary>
    public static void SetSideStart<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOptions
    {
        b.SetProperty(b.Const("side"), b.Const("start"));
    }

    /// <summary>
    /// The side the option button should be on. Possible values: `"start"` and `"end"`. If you have multiple `ion-item-options`, a side must be provided for each.
    /// </summary>
    public static void SetSideEnd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOptions
    {
        b.SetProperty(b.Const("side"), b.Const("end"));
    }
}