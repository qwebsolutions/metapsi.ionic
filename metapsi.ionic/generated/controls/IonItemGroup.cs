using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonItemGroup
{

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonItemGroupControl
{
    /// <summary>
    /// Builds a "ion-item-group" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonItemGroup>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-item-group", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-item-group" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemGroup(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-item-group", children);
    }

    /// <summary>
    /// Builds a "ion-item-group" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonItemGroup>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-item-group", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-item-group" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemGroup(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-item-group", children);
    }
    /// <summary>
    /// Builds a virtual "ion-item-group" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonItemGroup>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-item-group", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-item-group" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemGroup(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-item-group", children);
    }

    /// <summary>
    /// Builds a virtual "ion-item-group" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonItemGroup>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-item-group", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-item-group" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemGroup(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-item-group", children);
    }
}
public static partial class IonItemGroupExtensions
{
}