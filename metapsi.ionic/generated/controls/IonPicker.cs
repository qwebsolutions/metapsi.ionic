using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonPicker
{

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonPickerControl
{
    /// <summary>
    /// Builds a "ion-picker" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonPicker(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonPicker>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-picker", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-picker" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonPicker(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-picker", children);
    }

    /// <summary>
    /// Builds a "ion-picker" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonPicker(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonPicker>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-picker", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-picker" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonPicker(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-picker", children);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonPicker> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonPicker> b)
    {
        b.SetAttribute("mode", "md");
    }
    /// <summary>
    /// Builds a virtual "ion-picker" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonPicker(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonPicker>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-picker", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-picker" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonPicker(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-picker", children);
    }

    /// <summary>
    /// Builds a virtual "ion-picker" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonPicker(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonPicker>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-picker", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-picker" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonPicker(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-picker", children);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPicker
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPicker
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }
}
public static partial class IonPickerExtensions
{

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPicker
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPicker
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }
}