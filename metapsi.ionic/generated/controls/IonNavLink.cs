using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonNavLink
{

    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public object component { get; set; }

    /// <summary>
    /// Data you want to pass to the component as props. Only used if the `"routerDirection"` is `"forward"` or `"root"`.
    /// </summary>
    public ComponentProps componentProps { get; set; }

    /// <summary>
    /// The transition animation when navigating to another page.
    /// </summary>
    public System.Func<object, object, Animation> routerAnimation { get; set; }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public string routerDirection { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonNavLinkControl
{
    /// <summary>
    /// Builds a "ion-nav-link" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNavLink(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonNavLink>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-nav-link", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-nav-link" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNavLink(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-nav-link", children);
    }

    /// <summary>
    /// Builds a "ion-nav-link" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNavLink(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonNavLink>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-nav-link", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-nav-link" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNavLink(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-nav-link", children);
    }

    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent(this Metapsi.Html.AttributesBuilder<IonNavLink> b, string component)
    {
        b.SetAttribute("component", component);
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionForward(this Metapsi.Html.AttributesBuilder<IonNavLink> b)
    {
        b.SetAttribute("router-direction", "forward");
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionBack(this Metapsi.Html.AttributesBuilder<IonNavLink> b)
    {
        b.SetAttribute("router-direction", "back");
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionRoot(this Metapsi.Html.AttributesBuilder<IonNavLink> b)
    {
        b.SetAttribute("router-direction", "root");
    }
    /// <summary>
    /// Builds a virtual "ion-nav-link" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNavLink(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonNavLink>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-nav-link", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-nav-link" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNavLink(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-nav-link", children);
    }

    /// <summary>
    /// Builds a virtual "ion-nav-link" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNavLink(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonNavLink>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-nav-link", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-nav-link" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNavLink(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-nav-link", children);
    }

    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> component) where T: IonNavLink
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Function> component) where T: IonNavLink
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<HTMLElement> component) where T: IonNavLink
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<ViewController> component) where T: IonNavLink
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// Data you want to pass to the component as props. Only used if the `"routerDirection"` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponentProps<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<ComponentProps> componentProps) where T: IonNavLink
    {
        b.SetProperty(b.Const("componentProps"), componentProps);
    }

    /// <summary>
    /// The transition animation when navigating to another page.
    /// </summary>
    public static void SetRouterAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> routerAnimation) where T: IonNavLink
    {
        b.SetProperty(b.Const("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonNavLink
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("forward"));
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonNavLink
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("back"));
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonNavLink
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("root"));
    }
}
public static partial class IonNavLinkExtensions
{

    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> component) where T: IonNavLink
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<Function> component) where T: IonNavLink
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<HTMLElement> component) where T: IonNavLink
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<ViewController> component) where T: IonNavLink
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// Data you want to pass to the component as props. Only used if the `"routerDirection"` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponentProps<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<ComponentProps> componentProps) where T: IonNavLink
    {
        b.SetProperty(b.Const("componentProps"), componentProps);
    }

    /// <summary>
    /// The transition animation when navigating to another page.
    /// </summary>
    public static void SetRouterAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> routerAnimation) where T: IonNavLink
    {
        b.SetProperty(b.Const("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonNavLink
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("forward"));
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonNavLink
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("back"));
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonNavLink
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("root"));
    }
}