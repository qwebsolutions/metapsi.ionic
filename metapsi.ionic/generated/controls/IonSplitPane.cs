using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonSplitPane
{

    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public string contentId { get; set; }

    /// <summary>
    /// If `true`, the split pane will be hidden.
    /// </summary>
    public bool disabled { get; set; }

    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public object when { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonSplitPaneControl
{
    /// <summary>
    /// Builds a "ion-split-pane" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSplitPane(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSplitPane>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-split-pane", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-split-pane" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSplitPane(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-split-pane", children);
    }

    /// <summary>
    /// Builds a "ion-split-pane" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSplitPane(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSplitPane>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-split-pane", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-split-pane" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSplitPane(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-split-pane", children);
    }

    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId(this Metapsi.Html.AttributesBuilder<IonSplitPane> b, string contentId)
    {
        b.SetAttribute("content-id", contentId);
    }

    /// <summary>
    /// If `true`, the split pane will be hidden.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonSplitPane> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the split pane will be hidden.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonSplitPane> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen(this Metapsi.Html.AttributesBuilder<IonSplitPane> b, bool when)
    {
        if (when) b.SetAttribute("when", "");
    }

    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen(this Metapsi.Html.AttributesBuilder<IonSplitPane> b)
    {
        b.SetAttribute("when", "");
    }
    /// <summary>
    /// Builds a virtual "ion-split-pane" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSplitPane(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSplitPane>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-split-pane", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-split-pane" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSplitPane(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-split-pane", children);
    }

    /// <summary>
    /// Builds a virtual "ion-split-pane" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSplitPane(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSplitPane>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-split-pane", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-split-pane" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSplitPane(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-split-pane", children);
    }

    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> contentId) where T: IonSplitPane
    {
        b.SetProperty(b.Const("contentId"), contentId);
    }

    /// <summary>
    /// If `true`, the split pane will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSplitPane
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonSplitPane
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSplitPane
    {
        b.SetProperty(b.Const("when"), b.Const(true));
    }
    public static void SetWhen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> when) where T: IonSplitPane
    {
        b.SetProperty(b.Const("when"), when);
    }

    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> when) where T: IonSplitPane
    {
        b.SetProperty(b.Const("when"), when);
    }

    /// <summary>
    /// Expression to be called when the split-pane visibility has changed
    /// </summary>
    public static void OnIonSplitPaneVisible<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonSplitPane
    {
        b.SetProperty(b.Const("onionSplitPaneVisible"), b.Const(action));
    }

    /// <summary>
    /// Expression to be called when the split-pane visibility has changed
    /// </summary>
    [System.Obsolete]
    public static void OnIonSplitPaneVisible<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonSplitPane
    {
        b.OnIonSplitPaneVisible(b.MakeAction(action));
    }

    /// <summary>
    /// Expression to be called when the split-pane visibility has changed
    /// </summary>
    public static void OnIonSplitPaneVisible<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonSplitPane
    {
        b.SetProperty(b.Const("onionSplitPaneVisible"), b.Const(action));
    }

    /// <summary>
    /// Expression to be called when the split-pane visibility has changed
    /// </summary>
    [System.Obsolete]
    public static void OnIonSplitPaneVisible<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonSplitPane
    {
        b.OnIonSplitPaneVisible(b.MakeAction(action));
    }

    /// <summary>
    /// Expression to be called when the split-pane visibility has changed
    /// </summary>
    public static void OnIonSplitPaneVisible<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<SplitPaneVisibleEventDetail>>> action) where T: IonSplitPane
    {
        b.SetProperty(b.Const("onionSplitPaneVisible"), b.Const(action));
    }
}
public static partial class IonSplitPaneExtensions
{

    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> contentId) where T: IonSplitPane
    {
        b.SetProperty(b.Const("contentId"), contentId);
    }

    /// <summary>
    /// If `true`, the split pane will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonSplitPane
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonSplitPane
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonSplitPane
    {
        b.SetProperty(b.Const("when"), b.Const(true));
    }
    public static void SetWhen<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> when) where T: IonSplitPane
    {
        b.SetProperty(b.Const("when"), when);
    }

    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> when) where T: IonSplitPane
    {
        b.SetProperty(b.Const("when"), when);
    }
}