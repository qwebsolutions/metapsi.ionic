using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonBackdrop
{

    /// <summary>
    /// If `true`, the backdrop will stop propagation on tap.
    /// </summary>
    public bool stopPropagation { get; set; }

    /// <summary>
    /// If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event.
    /// </summary>
    public bool tappable { get; set; }

    /// <summary>
    /// If `true`, the backdrop will be visible.
    /// </summary>
    public bool visible { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonBackdropControl
{
    /// <summary>
    /// Builds a "ion-backdrop" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonBackdrop(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonBackdrop>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-backdrop", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-backdrop" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonBackdrop(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-backdrop", children);
    }

    /// <summary>
    /// Builds a "ion-backdrop" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonBackdrop(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonBackdrop>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-backdrop", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-backdrop" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonBackdrop(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-backdrop", children);
    }

    /// <summary>
    /// If `true`, the backdrop will stop propagation on tap.
    /// </summary>
    public static void SetStopPropagation(this Metapsi.Html.AttributesBuilder<IonBackdrop> b, bool stopPropagation)
    {
        if (stopPropagation) b.SetAttribute("stop-propagation", "");
    }

    /// <summary>
    /// If `true`, the backdrop will stop propagation on tap.
    /// </summary>
    public static void SetStopPropagation(this Metapsi.Html.AttributesBuilder<IonBackdrop> b)
    {
        b.SetAttribute("stop-propagation", "");
    }

    /// <summary>
    /// If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event.
    /// </summary>
    public static void SetTappable(this Metapsi.Html.AttributesBuilder<IonBackdrop> b, bool tappable)
    {
        if (tappable) b.SetAttribute("tappable", "");
    }

    /// <summary>
    /// If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event.
    /// </summary>
    public static void SetTappable(this Metapsi.Html.AttributesBuilder<IonBackdrop> b)
    {
        b.SetAttribute("tappable", "");
    }

    /// <summary>
    /// If `true`, the backdrop will be visible.
    /// </summary>
    public static void SetVisible(this Metapsi.Html.AttributesBuilder<IonBackdrop> b, bool visible)
    {
        if (visible) b.SetAttribute("visible", "");
    }

    /// <summary>
    /// If `true`, the backdrop will be visible.
    /// </summary>
    public static void SetVisible(this Metapsi.Html.AttributesBuilder<IonBackdrop> b)
    {
        b.SetAttribute("visible", "");
    }
    /// <summary>
    /// Builds a virtual "ion-backdrop" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonBackdrop(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonBackdrop>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-backdrop", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-backdrop" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonBackdrop(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-backdrop", children);
    }

    /// <summary>
    /// Builds a virtual "ion-backdrop" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonBackdrop(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonBackdrop>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-backdrop", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-backdrop" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonBackdrop(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-backdrop", children);
    }

    /// <summary>
    /// If `true`, the backdrop will stop propagation on tap.
    /// </summary>
    public static void SetStopPropagation<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackdrop
    {
        b.SetProperty(b.Const("stopPropagation"), b.Const(true));
    }
    public static void SetStopPropagation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> stopPropagation) where T: IonBackdrop
    {
        b.SetProperty(b.Const("stopPropagation"), stopPropagation);
    }

    /// <summary>
    /// If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event.
    /// </summary>
    public static void SetTappable<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackdrop
    {
        b.SetProperty(b.Const("tappable"), b.Const(true));
    }
    public static void SetTappable<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> tappable) where T: IonBackdrop
    {
        b.SetProperty(b.Const("tappable"), tappable);
    }

    /// <summary>
    /// If `true`, the backdrop will be visible.
    /// </summary>
    public static void SetVisible<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackdrop
    {
        b.SetProperty(b.Const("visible"), b.Const(true));
    }
    public static void SetVisible<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> visible) where T: IonBackdrop
    {
        b.SetProperty(b.Const("visible"), visible);
    }

    /// <summary>
    /// Emitted when the backdrop is tapped.
    /// </summary>
    public static void OnIonBackdropTap<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonBackdrop
    {
        b.SetProperty(b.Const("onionBackdropTap"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the backdrop is tapped.
    /// </summary>
    [System.Obsolete]
    public static void OnIonBackdropTap<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonBackdrop
    {
        b.OnIonBackdropTap(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the backdrop is tapped.
    /// </summary>
    public static void OnIonBackdropTap<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonBackdrop
    {
        b.SetProperty(b.Const("onionBackdropTap"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the backdrop is tapped.
    /// </summary>
    [System.Obsolete]
    public static void OnIonBackdropTap<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonBackdrop
    {
        b.OnIonBackdropTap(b.MakeAction(action));
    }
}
public static partial class IonBackdropExtensions
{

    /// <summary>
    /// If `true`, the backdrop will stop propagation on tap.
    /// </summary>
    public static void SetStopPropagation<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonBackdrop
    {
        b.SetProperty(b.Const("stopPropagation"), b.Const(true));
    }
    public static void SetStopPropagation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> stopPropagation) where T: IonBackdrop
    {
        b.SetProperty(b.Const("stopPropagation"), stopPropagation);
    }

    /// <summary>
    /// If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event.
    /// </summary>
    public static void SetTappable<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonBackdrop
    {
        b.SetProperty(b.Const("tappable"), b.Const(true));
    }
    public static void SetTappable<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> tappable) where T: IonBackdrop
    {
        b.SetProperty(b.Const("tappable"), tappable);
    }

    /// <summary>
    /// If `true`, the backdrop will be visible.
    /// </summary>
    public static void SetVisible<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonBackdrop
    {
        b.SetProperty(b.Const("visible"), b.Const(true));
    }
    public static void SetVisible<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> visible) where T: IonBackdrop
    {
        b.SetProperty(b.Const("visible"), visible);
    }
}