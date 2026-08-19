using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonRow
{

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonRowControl
{
    /// <summary>
    /// Builds a "ion-row" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRow(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRow>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-row", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-row" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRow(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-row", children);
    }

    /// <summary>
    /// Builds a "ion-row" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRow(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRow>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-row", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-row" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRow(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-row", children);
    }
    /// <summary>
    /// Builds a virtual "ion-row" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRow(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRow>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-row", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-row" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRow(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-row", children);
    }

    /// <summary>
    /// Builds a virtual "ion-row" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRow(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRow>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-row", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-row" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRow(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-row", children);
    }
}
public static partial class IonRowExtensions
{
}