using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonSkeletonText
{

    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public bool animated { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonSkeletonTextControl
{
    /// <summary>
    /// Builds a "ion-skeleton-text" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSkeletonText(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSkeletonText>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-skeleton-text", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-skeleton-text" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSkeletonText(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-skeleton-text", children);
    }

    /// <summary>
    /// Builds a "ion-skeleton-text" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSkeletonText(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSkeletonText>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-skeleton-text", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-skeleton-text" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSkeletonText(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-skeleton-text", children);
    }

    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonSkeletonText> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonSkeletonText> b)
    {
        b.SetAttribute("animated", "");
    }
    /// <summary>
    /// Builds a virtual "ion-skeleton-text" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSkeletonText(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSkeletonText>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-skeleton-text", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-skeleton-text" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSkeletonText(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-skeleton-text", children);
    }

    /// <summary>
    /// Builds a virtual "ion-skeleton-text" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSkeletonText(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSkeletonText>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-skeleton-text", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-skeleton-text" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSkeletonText(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-skeleton-text", children);
    }

    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSkeletonText
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonSkeletonText
    {
        b.SetProperty(b.Const("animated"), animated);
    }
}
public static partial class IonSkeletonTextExtensions
{

    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonSkeletonText
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonSkeletonText
    {
        b.SetProperty(b.Const("animated"), animated);
    }
}