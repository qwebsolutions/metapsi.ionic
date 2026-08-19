using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonRouteRedirect
{

    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "from" URL. It needs to be an exact match of the navigated URL in order to apply.  The path specified in this value is always an absolute path, even if the initial `/` slash is not specified.
    /// </summary>
    public string from { get; set; }

    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "to" URL. When the defined `ion-route-redirect` rule matches, the router will redirect to the path specified in this property.  The value of this property is always an absolute path inside the scope of routes defined in `ion-router` it can't be used with another router or to perform a redirection to a different domain.  Note that this is a virtual redirect, it will not cause a real browser refresh, again, it's a redirect inside the context of ion-router.  When this property is not specified or his value is `undefined` the whole redirect route is noop, even if the "from" value matches.
    /// </summary>
    public string to { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonRouteRedirectControl
{
    /// <summary>
    /// Builds a "ion-route-redirect" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouteRedirect(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRouteRedirect>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-route-redirect", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-route-redirect" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouteRedirect(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-route-redirect", children);
    }

    /// <summary>
    /// Builds a "ion-route-redirect" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouteRedirect(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRouteRedirect>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-route-redirect", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-route-redirect" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouteRedirect(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-route-redirect", children);
    }

    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "from" URL. It needs to be an exact match of the navigated URL in order to apply.  The path specified in this value is always an absolute path, even if the initial `/` slash is not specified.
    /// </summary>
    public static void SetFrom(this Metapsi.Html.AttributesBuilder<IonRouteRedirect> b, string from)
    {
        b.SetAttribute("from", from);
    }

    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "to" URL. When the defined `ion-route-redirect` rule matches, the router will redirect to the path specified in this property.  The value of this property is always an absolute path inside the scope of routes defined in `ion-router` it can't be used with another router or to perform a redirection to a different domain.  Note that this is a virtual redirect, it will not cause a real browser refresh, again, it's a redirect inside the context of ion-router.  When this property is not specified or his value is `undefined` the whole redirect route is noop, even if the "from" value matches.
    /// </summary>
    public static void SetTo(this Metapsi.Html.AttributesBuilder<IonRouteRedirect> b, string to)
    {
        b.SetAttribute("to", to);
    }
    /// <summary>
    /// Builds a virtual "ion-route-redirect" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouteRedirect(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRouteRedirect>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-route-redirect", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-route-redirect" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouteRedirect(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-route-redirect", children);
    }

    /// <summary>
    /// Builds a virtual "ion-route-redirect" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouteRedirect(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRouteRedirect>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-route-redirect", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-route-redirect" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouteRedirect(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-route-redirect", children);
    }

    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "from" URL. It needs to be an exact match of the navigated URL in order to apply.  The path specified in this value is always an absolute path, even if the initial `/` slash is not specified.
    /// </summary>
    public static void SetFrom<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> from) where T: IonRouteRedirect
    {
        b.SetProperty(b.Const("from"), from);
    }

    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "to" URL. When the defined `ion-route-redirect` rule matches, the router will redirect to the path specified in this property.  The value of this property is always an absolute path inside the scope of routes defined in `ion-router` it can't be used with another router or to perform a redirection to a different domain.  Note that this is a virtual redirect, it will not cause a real browser refresh, again, it's a redirect inside the context of ion-router.  When this property is not specified or his value is `undefined` the whole redirect route is noop, even if the "from" value matches.
    /// </summary>
    public static void SetTo<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> to) where T: IonRouteRedirect
    {
        b.SetProperty(b.Const("to"), to);
    }

    /// <summary>
    /// Internal event that fires when any value of this rule is added/removed from the DOM, or any of his public properties changes.  `ion-router` captures this event in order to update his internal registry of router rules.
    /// </summary>
    public static void OnIonRouteRedirectChanged<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRouteRedirect
    {
        b.SetProperty(b.Const("onionRouteRedirectChanged"), b.Const(action));
    }

    /// <summary>
    /// Internal event that fires when any value of this rule is added/removed from the DOM, or any of his public properties changes.  `ion-router` captures this event in order to update his internal registry of router rules.
    /// </summary>
    [System.Obsolete]
    public static void OnIonRouteRedirectChanged<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRouteRedirect
    {
        b.OnIonRouteRedirectChanged(b.MakeAction(action));
    }

    /// <summary>
    /// Internal event that fires when any value of this rule is added/removed from the DOM, or any of his public properties changes.  `ion-router` captures this event in order to update his internal registry of router rules.
    /// </summary>
    public static void OnIonRouteRedirectChanged<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRouteRedirect
    {
        b.SetProperty(b.Const("onionRouteRedirectChanged"), b.Const(action));
    }

    /// <summary>
    /// Internal event that fires when any value of this rule is added/removed from the DOM, or any of his public properties changes.  `ion-router` captures this event in order to update his internal registry of router rules.
    /// </summary>
    [System.Obsolete]
    public static void OnIonRouteRedirectChanged<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRouteRedirect
    {
        b.OnIonRouteRedirectChanged(b.MakeAction(action));
    }
}
public static partial class IonRouteRedirectExtensions
{

    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "from" URL. It needs to be an exact match of the navigated URL in order to apply.  The path specified in this value is always an absolute path, even if the initial `/` slash is not specified.
    /// </summary>
    public static void SetFrom<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> from) where T: IonRouteRedirect
    {
        b.SetProperty(b.Const("from"), from);
    }

    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "to" URL. When the defined `ion-route-redirect` rule matches, the router will redirect to the path specified in this property.  The value of this property is always an absolute path inside the scope of routes defined in `ion-router` it can't be used with another router or to perform a redirection to a different domain.  Note that this is a virtual redirect, it will not cause a real browser refresh, again, it's a redirect inside the context of ion-router.  When this property is not specified or his value is `undefined` the whole redirect route is noop, even if the "from" value matches.
    /// </summary>
    public static void SetTo<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> to) where T: IonRouteRedirect
    {
        b.SetProperty(b.Const("to"), to);
    }
}