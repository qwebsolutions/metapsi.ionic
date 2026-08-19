using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonAvatar
{

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonAvatarControl
{
    /// <summary>
    /// Builds a "ion-avatar" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonAvatar(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonAvatar>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-avatar", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-avatar" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonAvatar(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-avatar", children);
    }

    /// <summary>
    /// Builds a "ion-avatar" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonAvatar(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonAvatar>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-avatar", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-avatar" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonAvatar(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-avatar", children);
    }
    /// <summary>
    /// Builds a virtual "ion-avatar" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonAvatar(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonAvatar>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-avatar", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-avatar" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonAvatar(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-avatar", children);
    }

    /// <summary>
    /// Builds a virtual "ion-avatar" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonAvatar(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonAvatar>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-avatar", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-avatar" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonAvatar(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-avatar", children);
    }
}
public static partial class IonAvatarExtensions
{
}