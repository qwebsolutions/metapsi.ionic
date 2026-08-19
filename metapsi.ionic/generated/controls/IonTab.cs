using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonTab
{

    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public object component { get; set; }

    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public string tab { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Set the active component for the tab
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonTab> instead")]
        public const string SetActive = "setActive";
    }
}
public static partial class IonTabControl
{
    /// <summary>
    /// Builds a "ion-tab" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTab(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonTab>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-tab", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-tab" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTab(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-tab", children);
    }

    /// <summary>
    /// Builds a "ion-tab" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTab(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonTab>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-tab", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-tab" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTab(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-tab", children);
    }

    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent(this Metapsi.Html.AttributesBuilder<IonTab> b, string component)
    {
        b.SetAttribute("component", component);
    }

    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab(this Metapsi.Html.AttributesBuilder<IonTab> b, string tab)
    {
        b.SetAttribute("tab", tab);
    }
    /// <summary>
    /// Builds a virtual "ion-tab" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTab(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonTab>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-tab", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-tab" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTab(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-tab", children);
    }

    /// <summary>
    /// Builds a virtual "ion-tab" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTab(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonTab>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-tab", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-tab" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTab(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-tab", children);
    }

    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> component) where T: IonTab
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Function> component) where T: IonTab
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<HTMLElement> component) where T: IonTab
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> tab) where T: IonTab
    {
        b.SetProperty(b.Const("tab"), tab);
    }
}
public static partial class IonTabExtensions
{

    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> component) where T: IonTab
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<Function> component) where T: IonTab
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<HTMLElement> component) where T: IonTab
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> tab) where T: IonTab
    {
        b.SetProperty(b.Const("tab"), tab);
    }

    /// <summary>
    /// Set the active component for the tab
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> setActive(this Metapsi.Syntax.ObjBuilder<IonTab> b)
    {
        return b.Call<Promise>("setActive");
    }
}