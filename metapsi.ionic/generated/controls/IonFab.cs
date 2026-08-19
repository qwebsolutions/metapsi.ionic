using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonFab
{

    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public bool activated { get; set; }

    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public bool edge { get; set; }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public string horizontal { get; set; }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public string vertical { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Close an active FAB list container.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonFab> instead")]
        public const string Close = "close";
    }
}
public static partial class IonFabControl
{
    /// <summary>
    /// Builds a "ion-fab" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFab(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonFab>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-fab", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-fab" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFab(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-fab", children);
    }

    /// <summary>
    /// Builds a "ion-fab" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFab(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonFab>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-fab", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-fab" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFab(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-fab", children);
    }

    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated(this Metapsi.Html.AttributesBuilder<IonFab> b, bool activated)
    {
        if (activated) b.SetAttribute("activated", "");
    }

    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated(this Metapsi.Html.AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("activated", "");
    }

    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge(this Metapsi.Html.AttributesBuilder<IonFab> b, bool edge)
    {
        if (edge) b.SetAttribute("edge", "");
    }

    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge(this Metapsi.Html.AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("edge", "");
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalStart(this Metapsi.Html.AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("horizontal", "start");
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalEnd(this Metapsi.Html.AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("horizontal", "end");
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalCenter(this Metapsi.Html.AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("horizontal", "center");
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalCenter(this Metapsi.Html.AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("vertical", "center");
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalTop(this Metapsi.Html.AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("vertical", "top");
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalBottom(this Metapsi.Html.AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("vertical", "bottom");
    }
    /// <summary>
    /// Builds a virtual "ion-fab" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFab(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonFab>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-fab", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-fab" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFab(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-fab", children);
    }

    /// <summary>
    /// Builds a virtual "ion-fab" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFab(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonFab>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-fab", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-fab" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFab(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-fab", children);
    }

    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("activated"), b.Const(true));
    }
    public static void SetActivated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> activated) where T: IonFab
    {
        b.SetProperty(b.Const("activated"), activated);
    }

    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("edge"), b.Const(true));
    }
    public static void SetEdge<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> edge) where T: IonFab
    {
        b.SetProperty(b.Const("edge"), edge);
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("horizontal"), b.Const("start"));
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("horizontal"), b.Const("end"));
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalCenter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("horizontal"), b.Const("center"));
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalCenter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("vertical"), b.Const("center"));
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("vertical"), b.Const("top"));
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("vertical"), b.Const("bottom"));
    }
}
public static partial class IonFabExtensions
{

    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("activated"), b.Const(true));
    }
    public static void SetActivated<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> activated) where T: IonFab
    {
        b.SetProperty(b.Const("activated"), activated);
    }

    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("edge"), b.Const(true));
    }
    public static void SetEdge<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> edge) where T: IonFab
    {
        b.SetProperty(b.Const("edge"), edge);
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalStart<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("horizontal"), b.Const("start"));
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalEnd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("horizontal"), b.Const("end"));
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalCenter<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("horizontal"), b.Const("center"));
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalCenter<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("vertical"), b.Const("center"));
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalTop<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("vertical"), b.Const("top"));
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalBottom<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Const("vertical"), b.Const("bottom"));
    }

    /// <summary>
    /// Close an active FAB list container.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> close(this Metapsi.Syntax.ObjBuilder<IonFab> b)
    {
        return b.Call<Promise>("close");
    }
}