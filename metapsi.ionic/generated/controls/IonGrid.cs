using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonGrid
{

    /// <summary>
    /// If `true`, the grid will have a fixed width based on the screen size.
    /// </summary>
    public bool @fixed { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonGridControl
{
    /// <summary>
    /// Builds a "ion-grid" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonGrid(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonGrid>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-grid", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-grid" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonGrid(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-grid", children);
    }

    /// <summary>
    /// Builds a "ion-grid" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonGrid(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonGrid>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-grid", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-grid" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonGrid(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-grid", children);
    }

    /// <summary>
    /// If `true`, the grid will have a fixed width based on the screen size.
    /// </summary>
    public static void SetFixed(this Metapsi.Html.AttributesBuilder<IonGrid> b, bool @fixed)
    {
        if (@fixed) b.SetAttribute("fixed", "");
    }

    /// <summary>
    /// If `true`, the grid will have a fixed width based on the screen size.
    /// </summary>
    public static void SetFixed(this Metapsi.Html.AttributesBuilder<IonGrid> b)
    {
        b.SetAttribute("fixed", "");
    }
    /// <summary>
    /// Builds a virtual "ion-grid" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonGrid(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonGrid>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-grid", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-grid" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonGrid(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-grid", children);
    }

    /// <summary>
    /// Builds a virtual "ion-grid" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonGrid(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonGrid>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-grid", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-grid" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonGrid(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-grid", children);
    }

    /// <summary>
    /// If `true`, the grid will have a fixed width based on the screen size.
    /// </summary>
    public static void SetFixed<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonGrid
    {
        b.SetProperty(b.Const("fixed"), b.Const(true));
    }
    public static void SetFixed<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> @fixed) where T: IonGrid
    {
        b.SetProperty(b.Const("fixed"), @fixed);
    }
}
public static partial class IonGridExtensions
{

    /// <summary>
    /// If `true`, the grid will have a fixed width based on the screen size.
    /// </summary>
    public static void SetFixed<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonGrid
    {
        b.SetProperty(b.Const("fixed"), b.Const(true));
    }
    public static void SetFixed<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> @fixed) where T: IonGrid
    {
        b.SetProperty(b.Const("fixed"), @fixed);
    }
}