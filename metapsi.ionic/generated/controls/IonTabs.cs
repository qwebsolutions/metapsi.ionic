using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonTabs
{

    public static partial class Slot
    {
        /// <summary>
        /// Content is placed at the bottom of the screen.
        /// </summary>
        public const string Bottom = "bottom";
        /// <summary>
        /// Content is placed at the top of the screen.
        /// </summary>
        public const string Top = "top";
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Get the currently selected tab. This method is only available for vanilla JavaScript projects. The Angular, React, and Vue implementations of tabs are coupled to each framework's router.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonTabs> instead")]
        public const string GetSelected = "getSelected";
        /// <summary>
        /// Get a specific tab by the value of its `tab` property or an element reference. This method is only available for vanilla JavaScript projects. The Angular, React, and Vue implementations of tabs are coupled to each framework's router.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonTabs> instead")]
        public const string GetTab = "getTab";
        /// <summary>
        /// Select a tab by the value of its `tab` property or an element reference. This method is only available for vanilla JavaScript projects. The Angular, React, and Vue implementations of tabs are coupled to each framework's router.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonTabs> instead")]
        public const string Select = "select";
    }
}
public static partial class IonTabsControl
{
    /// <summary>
    /// Builds a "ion-tabs" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTabs(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonTabs>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-tabs", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-tabs" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTabs(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-tabs", children);
    }

    /// <summary>
    /// Builds a "ion-tabs" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTabs(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonTabs>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-tabs", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-tabs" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTabs(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-tabs", children);
    }
    /// <summary>
    /// Builds a virtual "ion-tabs" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTabs(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonTabs>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-tabs", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-tabs" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTabs(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-tabs", children);
    }

    /// <summary>
    /// Builds a virtual "ion-tabs" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTabs(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonTabs>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-tabs", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-tabs" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTabs(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-tabs", children);
    }

    /// <summary>
    /// Emitted when the navigation has finished transitioning to a new component.
    /// </summary>
    public static void OnIonTabsDidChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonTabs
    {
        b.SetProperty(b.Const("onionTabsDidChange"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the navigation has finished transitioning to a new component.
    /// </summary>
    [System.Obsolete]
    public static void OnIonTabsDidChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonTabs
    {
        b.OnIonTabsDidChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the navigation has finished transitioning to a new component.
    /// </summary>
    public static void OnIonTabsDidChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonTabs
    {
        b.SetProperty(b.Const("onionTabsDidChange"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the navigation has finished transitioning to a new component.
    /// </summary>
    [System.Obsolete]
    public static void OnIonTabsDidChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonTabs
    {
        b.OnIonTabsDidChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the navigation has finished transitioning to a new component.
    /// </summary>
    public static void OnIonTabsDidChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<TabsDidChangeEventDetail>>> action) where T: IonTabs
    {
        b.SetProperty(b.Const("onionTabsDidChange"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    public static void OnIonTabsWillChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonTabs
    {
        b.SetProperty(b.Const("onionTabsWillChange"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    [System.Obsolete]
    public static void OnIonTabsWillChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonTabs
    {
        b.OnIonTabsWillChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    public static void OnIonTabsWillChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonTabs
    {
        b.SetProperty(b.Const("onionTabsWillChange"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    [System.Obsolete]
    public static void OnIonTabsWillChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonTabs
    {
        b.OnIonTabsWillChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    public static void OnIonTabsWillChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<TabsWillChangeEventDetail>>> action) where T: IonTabs
    {
        b.SetProperty(b.Const("onionTabsWillChange"), b.Const(action));
    }
}
public static partial class IonTabsExtensions
{

    /// <summary>
    /// Get the currently selected tab. This method is only available for vanilla JavaScript projects. The Angular, React, and Vue implementations of tabs are coupled to each framework's router.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<string>> getSelected(this Metapsi.Syntax.ObjBuilder<IonTabs> b)
    {
        return b.Call<Promise<string>>("getSelected");
    }

    /// <summary>
    /// Get a specific tab by the value of its `tab` property or an element reference. This method is only available for vanilla JavaScript projects. The Angular, React, and Vue implementations of tabs are coupled to each framework's router.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<HTMLIonTabElement>> getTab(this Metapsi.Syntax.ObjBuilder<IonTabs> b, Metapsi.Syntax.Var<string> tab)
    {
        return b.Call<Promise<HTMLIonTabElement>>("getTab", tab);
    }

    /// <summary>
    /// Get a specific tab by the value of its `tab` property or an element reference. This method is only available for vanilla JavaScript projects. The Angular, React, and Vue implementations of tabs are coupled to each framework's router.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<HTMLIonTabElement>> getTab(this Metapsi.Syntax.ObjBuilder<IonTabs> b, Metapsi.Syntax.Var<HTMLIonTabElement> tab)
    {
        return b.Call<Promise<HTMLIonTabElement>>("getTab", tab);
    }

    /// <summary>
    /// Select a tab by the value of its `tab` property or an element reference. This method is only available for vanilla JavaScript projects. The Angular, React, and Vue implementations of tabs are coupled to each framework's router.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> select(this Metapsi.Syntax.ObjBuilder<IonTabs> b, Metapsi.Syntax.Var<string> tab)
    {
        return b.Call<Promise<bool>>("select", tab);
    }

    /// <summary>
    /// Select a tab by the value of its `tab` property or an element reference. This method is only available for vanilla JavaScript projects. The Angular, React, and Vue implementations of tabs are coupled to each framework's router.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> select(this Metapsi.Syntax.ObjBuilder<IonTabs> b, Metapsi.Syntax.Var<HTMLIonTabElement> tab)
    {
        return b.Call<Promise<bool>>("select", tab);
    }
}