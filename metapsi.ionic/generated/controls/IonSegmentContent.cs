using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonSegmentContent
{

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonSegmentContentControl
{
    /// <summary>
    /// Builds a "ion-segment-content" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentContent(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSegmentContent>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-segment-content", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-segment-content" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentContent(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-segment-content", children);
    }

    /// <summary>
    /// Builds a "ion-segment-content" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentContent(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSegmentContent>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-segment-content", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-segment-content" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentContent(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-segment-content", children);
    }
    /// <summary>
    /// Builds a virtual "ion-segment-content" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentContent(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSegmentContent>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-segment-content", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-segment-content" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentContent(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-segment-content", children);
    }

    /// <summary>
    /// Builds a virtual "ion-segment-content" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentContent(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSegmentContent>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-segment-content", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-segment-content" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentContent(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-segment-content", children);
    }
}
public static partial class IonSegmentContentExtensions
{
}