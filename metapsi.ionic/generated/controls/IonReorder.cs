using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonReorder
{

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonReorderControl
{
    /// <summary>
    /// Builds a "ion-reorder" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonReorder(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonReorder>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-reorder", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-reorder" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonReorder(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-reorder", children);
    }

    /// <summary>
    /// Builds a "ion-reorder" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonReorder(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonReorder>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-reorder", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-reorder" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonReorder(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-reorder", children);
    }
    /// <summary>
    /// Builds a virtual "ion-reorder" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonReorder(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonReorder>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-reorder", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-reorder" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonReorder(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-reorder", children);
    }

    /// <summary>
    /// Builds a virtual "ion-reorder" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonReorder(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonReorder>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-reorder", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-reorder" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonReorder(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-reorder", children);
    }
}
public static partial class IonReorderExtensions
{
}