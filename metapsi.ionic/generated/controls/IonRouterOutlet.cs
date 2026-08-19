using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonRouterOutlet
{

    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public bool animated { get; set; }

    /// <summary>
    /// This property allows to create custom transition using AnimationBuilder functions.
    /// </summary>
    public System.Func<object, object, Animation> animation { get; set; }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonRouterOutletControl
{
    /// <summary>
    /// Builds a "ion-router-outlet" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouterOutlet(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRouterOutlet>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-router-outlet", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-router-outlet" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouterOutlet(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-router-outlet", children);
    }

    /// <summary>
    /// Builds a "ion-router-outlet" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouterOutlet(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRouterOutlet>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-router-outlet", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-router-outlet" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouterOutlet(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-router-outlet", children);
    }

    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonRouterOutlet> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonRouterOutlet> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonRouterOutlet> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonRouterOutlet> b)
    {
        b.SetAttribute("mode", "md");
    }
    /// <summary>
    /// Builds a virtual "ion-router-outlet" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouterOutlet(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRouterOutlet>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-router-outlet", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-router-outlet" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouterOutlet(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-router-outlet", children);
    }

    /// <summary>
    /// Builds a virtual "ion-router-outlet" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouterOutlet(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRouterOutlet>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-router-outlet", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-router-outlet" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouterOutlet(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-router-outlet", children);
    }

    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonRouterOutlet
    {
        b.SetProperty(b.Const("animated"), animated);
    }

    /// <summary>
    /// This property allows to create custom transition using AnimationBuilder functions.
    /// </summary>
    public static void SetAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> animation) where T: IonRouterOutlet
    {
        b.SetProperty(b.Const("animation"), animation);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }
}
public static partial class IonRouterOutletExtensions
{

    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonRouterOutlet
    {
        b.SetProperty(b.Const("animated"), animated);
    }

    /// <summary>
    /// This property allows to create custom transition using AnimationBuilder functions.
    /// </summary>
    public static void SetAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> animation) where T: IonRouterOutlet
    {
        b.SetProperty(b.Const("animation"), animation);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }
}