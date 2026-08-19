using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonThumbnail
{

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonThumbnailControl
{
    /// <summary>
    /// Builds a "ion-thumbnail" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonThumbnail(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonThumbnail>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-thumbnail", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-thumbnail" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonThumbnail(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-thumbnail", children);
    }

    /// <summary>
    /// Builds a "ion-thumbnail" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonThumbnail(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonThumbnail>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-thumbnail", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-thumbnail" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonThumbnail(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-thumbnail", children);
    }
    /// <summary>
    /// Builds a virtual "ion-thumbnail" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonThumbnail(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonThumbnail>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-thumbnail", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-thumbnail" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonThumbnail(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-thumbnail", children);
    }

    /// <summary>
    /// Builds a virtual "ion-thumbnail" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonThumbnail(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonThumbnail>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-thumbnail", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-thumbnail" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonThumbnail(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-thumbnail", children);
    }
}
public static partial class IonThumbnailExtensions
{
}