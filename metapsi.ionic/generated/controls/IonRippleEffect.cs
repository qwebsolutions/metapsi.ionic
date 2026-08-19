using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonRippleEffect
{

    /// <summary>
    /// Sets the type of ripple-effect:  - `bounded`: the ripple effect expands from the user's click position - `unbounded`: the ripple effect expands from the center of the button and overflows the container.  NOTE: Surfaces for bounded ripples should have the overflow property set to hidden, while surfaces for unbounded ripples should have it set to visible.
    /// </summary>
    public string type { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Adds the ripple effect to the parent element.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonRippleEffect> instead")]
        public const string AddRipple = "addRipple";
    }
}
public static partial class IonRippleEffectControl
{
    /// <summary>
    /// Builds a "ion-ripple-effect" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRippleEffect(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRippleEffect>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-ripple-effect", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-ripple-effect" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRippleEffect(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-ripple-effect", children);
    }

    /// <summary>
    /// Builds a "ion-ripple-effect" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRippleEffect(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRippleEffect>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-ripple-effect", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-ripple-effect" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRippleEffect(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-ripple-effect", children);
    }

    /// <summary>
    /// Sets the type of ripple-effect:  - `bounded`: the ripple effect expands from the user's click position - `unbounded`: the ripple effect expands from the center of the button and overflows the container.  NOTE: Surfaces for bounded ripples should have the overflow property set to hidden, while surfaces for unbounded ripples should have it set to visible.
    /// </summary>
    public static void SetTypeBounded(this Metapsi.Html.AttributesBuilder<IonRippleEffect> b)
    {
        b.SetAttribute("type", "bounded");
    }

    /// <summary>
    /// Sets the type of ripple-effect:  - `bounded`: the ripple effect expands from the user's click position - `unbounded`: the ripple effect expands from the center of the button and overflows the container.  NOTE: Surfaces for bounded ripples should have the overflow property set to hidden, while surfaces for unbounded ripples should have it set to visible.
    /// </summary>
    public static void SetTypeUnbounded(this Metapsi.Html.AttributesBuilder<IonRippleEffect> b)
    {
        b.SetAttribute("type", "unbounded");
    }
    /// <summary>
    /// Builds a virtual "ion-ripple-effect" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRippleEffect(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRippleEffect>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-ripple-effect", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-ripple-effect" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRippleEffect(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-ripple-effect", children);
    }

    /// <summary>
    /// Builds a virtual "ion-ripple-effect" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRippleEffect(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRippleEffect>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-ripple-effect", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-ripple-effect" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRippleEffect(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-ripple-effect", children);
    }

    /// <summary>
    /// Sets the type of ripple-effect:  - `bounded`: the ripple effect expands from the user's click position - `unbounded`: the ripple effect expands from the center of the button and overflows the container.  NOTE: Surfaces for bounded ripples should have the overflow property set to hidden, while surfaces for unbounded ripples should have it set to visible.
    /// </summary>
    public static void SetTypeBounded<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRippleEffect
    {
        b.SetProperty(b.Const("type"), b.Const("bounded"));
    }

    /// <summary>
    /// Sets the type of ripple-effect:  - `bounded`: the ripple effect expands from the user's click position - `unbounded`: the ripple effect expands from the center of the button and overflows the container.  NOTE: Surfaces for bounded ripples should have the overflow property set to hidden, while surfaces for unbounded ripples should have it set to visible.
    /// </summary>
    public static void SetTypeUnbounded<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRippleEffect
    {
        b.SetProperty(b.Const("type"), b.Const("unbounded"));
    }
}
public static partial class IonRippleEffectExtensions
{

    /// <summary>
    /// Sets the type of ripple-effect:  - `bounded`: the ripple effect expands from the user's click position - `unbounded`: the ripple effect expands from the center of the button and overflows the container.  NOTE: Surfaces for bounded ripples should have the overflow property set to hidden, while surfaces for unbounded ripples should have it set to visible.
    /// </summary>
    public static void SetTypeBounded<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRippleEffect
    {
        b.SetProperty(b.Const("type"), b.Const("bounded"));
    }

    /// <summary>
    /// Sets the type of ripple-effect:  - `bounded`: the ripple effect expands from the user's click position - `unbounded`: the ripple effect expands from the center of the button and overflows the container.  NOTE: Surfaces for bounded ripples should have the overflow property set to hidden, while surfaces for unbounded ripples should have it set to visible.
    /// </summary>
    public static void SetTypeUnbounded<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRippleEffect
    {
        b.SetProperty(b.Const("type"), b.Const("unbounded"));
    }

    /// <summary>
    /// Adds the ripple effect to the parent element.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<System.Action>> addRipple(this Metapsi.Syntax.ObjBuilder<IonRippleEffect> b, Metapsi.Syntax.Var<int> x, Metapsi.Syntax.Var<int> y)
    {
        return b.Call<Promise<System.Action>>("addRipple", x, y);
    }
}