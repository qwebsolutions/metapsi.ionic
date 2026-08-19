using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonApp
{

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Used to set focus on an element that uses `ion-focusable`. Do not use this if focusing the element as a result of a keyboard event as the focus utility should handle this for us. This method should be used when we want to programmatically focus an element as a result of another user action. (Ex: We focus the first element inside of a popover when the user presents it, but the popover is not always presented as a result of keyboard action.)
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonApp> instead")]
        public const string SetFocus = "setFocus";
    }
}
public static partial class IonAppControl
{
    /// <summary>
    /// Builds a "ion-app" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonApp(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonApp>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-app", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-app" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonApp(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-app", children);
    }

    /// <summary>
    /// Builds a "ion-app" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonApp(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonApp>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-app", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-app" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonApp(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-app", children);
    }
    /// <summary>
    /// Builds a virtual "ion-app" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonApp(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonApp>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-app", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-app" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonApp(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-app", children);
    }

    /// <summary>
    /// Builds a virtual "ion-app" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonApp(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonApp>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-app", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-app" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonApp(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-app", children);
    }
}
public static partial class IonAppExtensions
{

    /// <summary>
    /// Used to set focus on an element that uses `ion-focusable`. Do not use this if focusing the element as a result of a keyboard event as the focus utility should handle this for us. This method should be used when we want to programmatically focus an element as a result of another user action. (Ex: We focus the first element inside of a popover when the user presents it, but the popover is not always presented as a result of keyboard action.)
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> setFocus(this Metapsi.Syntax.ObjBuilder<IonApp> b, Metapsi.Syntax.Var<System.Collections.Generic.List<HTMLElement>> elements)
    {
        return b.Call<Promise>("setFocus", elements);
    }
}