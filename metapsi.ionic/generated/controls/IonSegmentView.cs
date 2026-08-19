using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonSegmentView
{

    /// <summary>
    /// If `true`, the segment view cannot be interacted with.
    /// </summary>
    public bool disabled { get; set; }

    /// <summary>
    /// If `true`, users will be able to swipe the segment view to navigate between segment contents.
    /// </summary>
    public bool swipeGesture { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonSegmentViewControl
{
    /// <summary>
    /// Builds a "ion-segment-view" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentView(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSegmentView>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-segment-view", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-segment-view" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentView(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-segment-view", children);
    }

    /// <summary>
    /// Builds a "ion-segment-view" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentView(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSegmentView>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-segment-view", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-segment-view" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentView(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-segment-view", children);
    }

    /// <summary>
    /// If `true`, the segment view cannot be interacted with.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonSegmentView> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the segment view cannot be interacted with.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonSegmentView> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, users will be able to swipe the segment view to navigate between segment contents.
    /// </summary>
    public static void SetSwipeGesture(this Metapsi.Html.AttributesBuilder<IonSegmentView> b, bool swipeGesture)
    {
        if (swipeGesture) b.SetAttribute("swipe-gesture", "");
    }

    /// <summary>
    /// If `true`, users will be able to swipe the segment view to navigate between segment contents.
    /// </summary>
    public static void SetSwipeGesture(this Metapsi.Html.AttributesBuilder<IonSegmentView> b)
    {
        b.SetAttribute("swipe-gesture", "");
    }
    /// <summary>
    /// Builds a virtual "ion-segment-view" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentView(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSegmentView>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-segment-view", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-segment-view" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentView(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-segment-view", children);
    }

    /// <summary>
    /// Builds a virtual "ion-segment-view" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentView(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSegmentView>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-segment-view", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-segment-view" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentView(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-segment-view", children);
    }

    /// <summary>
    /// If `true`, the segment view cannot be interacted with.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSegmentView
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonSegmentView
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, users will be able to swipe the segment view to navigate between segment contents.
    /// </summary>
    public static void SetSwipeGesture<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSegmentView
    {
        b.SetProperty(b.Const("swipeGesture"), b.Const(true));
    }
    public static void SetSwipeGesture<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> swipeGesture) where T: IonSegmentView
    {
        b.SetProperty(b.Const("swipeGesture"), swipeGesture);
    }

    /// <summary>
    /// Emitted when the segment view is scrolled.
    /// </summary>
    public static void OnIonSegmentViewScroll<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonSegmentView
    {
        b.SetProperty(b.Const("onionSegmentViewScroll"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the segment view is scrolled.
    /// </summary>
    [System.Obsolete]
    public static void OnIonSegmentViewScroll<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonSegmentView
    {
        b.OnIonSegmentViewScroll(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the segment view is scrolled.
    /// </summary>
    public static void OnIonSegmentViewScroll<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonSegmentView
    {
        b.SetProperty(b.Const("onionSegmentViewScroll"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the segment view is scrolled.
    /// </summary>
    [System.Obsolete]
    public static void OnIonSegmentViewScroll<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonSegmentView
    {
        b.OnIonSegmentViewScroll(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the segment view is scrolled.
    /// </summary>
    public static void OnIonSegmentViewScroll<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<SegmentViewScrollEvent>>> action) where T: IonSegmentView
    {
        b.SetProperty(b.Const("onionSegmentViewScroll"), b.Const(action));
    }
}
public static partial class IonSegmentViewExtensions
{

    /// <summary>
    /// If `true`, the segment view cannot be interacted with.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonSegmentView
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonSegmentView
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, users will be able to swipe the segment view to navigate between segment contents.
    /// </summary>
    public static void SetSwipeGesture<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonSegmentView
    {
        b.SetProperty(b.Const("swipeGesture"), b.Const(true));
    }
    public static void SetSwipeGesture<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> swipeGesture) where T: IonSegmentView
    {
        b.SetProperty(b.Const("swipeGesture"), swipeGesture);
    }
}