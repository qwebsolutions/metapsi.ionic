using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonNav
{

    /// <summary>
    /// If `true`, the nav should animate the transition of components.
    /// </summary>
    public bool animated { get; set; }

    /// <summary>
    /// By default `ion-nav` animates transition between pages based in the mode (ios or material design). However, this property allows to create custom transition using `AnimationBuilder` functions.
    /// </summary>
    public System.Func<object, object, Animation> animation { get; set; }

    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public object root { get; set; }

    /// <summary>
    /// Any parameters for the root component
    /// </summary>
    public ComponentProps rootParams { get; set; }

    /// <summary>
    /// If the nav component should allow for swipe-to-go-back.
    /// </summary>
    public bool swipeGesture { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Returns `true` if the current view can go back.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonNav> instead")]
        public const string CanGoBack = "canGoBack";
        /// <summary>
        /// Get the active view.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonNav> instead")]
        public const string GetActive = "getActive";
        /// <summary>
        /// Get the view at the specified index.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonNav> instead")]
        public const string GetByIndex = "getByIndex";
        /// <summary>
        /// Returns the number of views in the stack.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonNav> instead")]
        public const string GetLength = "getLength";
        /// <summary>
        /// Get the previous view.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonNav> instead")]
        public const string GetPrevious = "getPrevious";
        /// <summary>
        /// Inserts a component into the navigation stack at the specified index. This is useful to add a component at any point in the navigation stack.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonNav> instead")]
        public const string Insert = "insert";
        /// <summary>
        /// Inserts an array of components into the navigation stack at the specified index. The last component in the array will become instantiated as a view, and animate in to become the active view.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonNav> instead")]
        public const string InsertPages = "insertPages";
        /// <summary>
        /// Pop a component off of the navigation stack. Navigates back from the current component.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonNav> instead")]
        public const string Pop = "pop";
        /// <summary>
        /// Pop to a specific index in the navigation stack.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonNav> instead")]
        public const string PopTo = "popTo";
        /// <summary>
        /// Navigate back to the root of the stack, no matter how far back that is.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonNav> instead")]
        public const string PopToRoot = "popToRoot";
        /// <summary>
        /// Push a new component onto the current navigation stack. Pass any additional information along as an object. This additional information is accessible through NavParams.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonNav> instead")]
        public const string Push = "push";
        /// <summary>
        /// Removes a component from the navigation stack at the specified index.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonNav> instead")]
        public const string RemoveIndex = "removeIndex";
        /// <summary>
        /// Set the views of the current navigation stack and navigate to the last view. By default animations are disabled, but they can be enabled by passing options to the navigation controller. Navigation parameters can also be passed to the individual pages in the array.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonNav> instead")]
        public const string SetPages = "setPages";
        /// <summary>
        /// Set the root for the current navigation stack to a component.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonNav> instead")]
        public const string SetRoot = "setRoot";
    }
}
public static partial class IonNavControl
{
    /// <summary>
    /// Builds a "ion-nav" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNav(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonNav>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-nav", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-nav" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNav(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-nav", children);
    }

    /// <summary>
    /// Builds a "ion-nav" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNav(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonNav>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-nav", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-nav" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNav(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-nav", children);
    }

    /// <summary>
    /// If `true`, the nav should animate the transition of components.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonNav> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the nav should animate the transition of components.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonNav> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot(this Metapsi.Html.AttributesBuilder<IonNav> b, string root)
    {
        b.SetAttribute("root", root);
    }

    /// <summary>
    /// If the nav component should allow for swipe-to-go-back.
    /// </summary>
    public static void SetSwipeGesture(this Metapsi.Html.AttributesBuilder<IonNav> b, bool swipeGesture)
    {
        if (swipeGesture) b.SetAttribute("swipe-gesture", "");
    }

    /// <summary>
    /// If the nav component should allow for swipe-to-go-back.
    /// </summary>
    public static void SetSwipeGesture(this Metapsi.Html.AttributesBuilder<IonNav> b)
    {
        b.SetAttribute("swipe-gesture", "");
    }
    /// <summary>
    /// Builds a virtual "ion-nav" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNav(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonNav>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-nav", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-nav" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNav(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-nav", children);
    }

    /// <summary>
    /// Builds a virtual "ion-nav" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNav(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonNav>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-nav", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-nav" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNav(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-nav", children);
    }

    /// <summary>
    /// If `true`, the nav should animate the transition of components.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonNav
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonNav
    {
        b.SetProperty(b.Const("animated"), animated);
    }

    /// <summary>
    /// By default `ion-nav` animates transition between pages based in the mode (ios or material design). However, this property allows to create custom transition using `AnimationBuilder` functions.
    /// </summary>
    public static void SetAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> animation) where T: IonNav
    {
        b.SetProperty(b.Const("animation"), animation);
    }

    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> root) where T: IonNav
    {
        b.SetProperty(b.Const("root"), root);
    }

    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Function> root) where T: IonNav
    {
        b.SetProperty(b.Const("root"), root);
    }

    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<HTMLElement> root) where T: IonNav
    {
        b.SetProperty(b.Const("root"), root);
    }

    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<ViewController> root) where T: IonNav
    {
        b.SetProperty(b.Const("root"), root);
    }

    /// <summary>
    /// Any parameters for the root component
    /// </summary>
    public static void SetRootParams<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<ComponentProps> rootParams) where T: IonNav
    {
        b.SetProperty(b.Const("rootParams"), rootParams);
    }

    /// <summary>
    /// If the nav component should allow for swipe-to-go-back.
    /// </summary>
    public static void SetSwipeGesture<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonNav
    {
        b.SetProperty(b.Const("swipeGesture"), b.Const(true));
    }
    public static void SetSwipeGesture<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> swipeGesture) where T: IonNav
    {
        b.SetProperty(b.Const("swipeGesture"), swipeGesture);
    }

    /// <summary>
    /// Event fired when the nav has changed components
    /// </summary>
    public static void OnIonNavDidChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonNav
    {
        b.SetProperty(b.Const("onionNavDidChange"), b.Const(action));
    }

    /// <summary>
    /// Event fired when the nav has changed components
    /// </summary>
    [System.Obsolete]
    public static void OnIonNavDidChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonNav
    {
        b.OnIonNavDidChange(b.MakeAction(action));
    }

    /// <summary>
    /// Event fired when the nav has changed components
    /// </summary>
    public static void OnIonNavDidChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonNav
    {
        b.SetProperty(b.Const("onionNavDidChange"), b.Const(action));
    }

    /// <summary>
    /// Event fired when the nav has changed components
    /// </summary>
    [System.Obsolete]
    public static void OnIonNavDidChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonNav
    {
        b.OnIonNavDidChange(b.MakeAction(action));
    }

    /// <summary>
    /// Event fired when the nav will change components
    /// </summary>
    public static void OnIonNavWillChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonNav
    {
        b.SetProperty(b.Const("onionNavWillChange"), b.Const(action));
    }

    /// <summary>
    /// Event fired when the nav will change components
    /// </summary>
    [System.Obsolete]
    public static void OnIonNavWillChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonNav
    {
        b.OnIonNavWillChange(b.MakeAction(action));
    }

    /// <summary>
    /// Event fired when the nav will change components
    /// </summary>
    public static void OnIonNavWillChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonNav
    {
        b.SetProperty(b.Const("onionNavWillChange"), b.Const(action));
    }

    /// <summary>
    /// Event fired when the nav will change components
    /// </summary>
    [System.Obsolete]
    public static void OnIonNavWillChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonNav
    {
        b.OnIonNavWillChange(b.MakeAction(action));
    }
}
public static partial class IonNavExtensions
{

    /// <summary>
    /// If `true`, the nav should animate the transition of components.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonNav
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonNav
    {
        b.SetProperty(b.Const("animated"), animated);
    }

    /// <summary>
    /// By default `ion-nav` animates transition between pages based in the mode (ios or material design). However, this property allows to create custom transition using `AnimationBuilder` functions.
    /// </summary>
    public static void SetAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> animation) where T: IonNav
    {
        b.SetProperty(b.Const("animation"), animation);
    }

    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> root) where T: IonNav
    {
        b.SetProperty(b.Const("root"), root);
    }

    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<Function> root) where T: IonNav
    {
        b.SetProperty(b.Const("root"), root);
    }

    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<HTMLElement> root) where T: IonNav
    {
        b.SetProperty(b.Const("root"), root);
    }

    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<ViewController> root) where T: IonNav
    {
        b.SetProperty(b.Const("root"), root);
    }

    /// <summary>
    /// Any parameters for the root component
    /// </summary>
    public static void SetRootParams<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<ComponentProps> rootParams) where T: IonNav
    {
        b.SetProperty(b.Const("rootParams"), rootParams);
    }

    /// <summary>
    /// If the nav component should allow for swipe-to-go-back.
    /// </summary>
    public static void SetSwipeGesture<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonNav
    {
        b.SetProperty(b.Const("swipeGesture"), b.Const(true));
    }
    public static void SetSwipeGesture<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> swipeGesture) where T: IonNav
    {
        b.SetProperty(b.Const("swipeGesture"), swipeGesture);
    }

    /// <summary>
    /// Returns `true` if the current view can go back.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> canGoBack(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<ViewController> view = null)
    {
        return b.Call<Promise<bool>>("canGoBack", view);
    }

    /// <summary>
    /// Get the active view.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<ViewController>> getActive(this Metapsi.Syntax.ObjBuilder<IonNav> b)
    {
        return b.Call<Promise<ViewController>>("getActive");
    }

    /// <summary>
    /// Get the view at the specified index.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<ViewController>> getByIndex(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<int> index)
    {
        return b.Call<Promise<ViewController>>("getByIndex", index);
    }

    /// <summary>
    /// Returns the number of views in the stack.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<int>> getLength(this Metapsi.Syntax.ObjBuilder<IonNav> b)
    {
        return b.Call<Promise<int>>("getLength");
    }

    /// <summary>
    /// Get the previous view.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<ViewController>> getPrevious(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<ViewController> view = null)
    {
        return b.Call<Promise<ViewController>>("getPrevious", view);
    }

    /// <summary>
    /// Inserts a component into the navigation stack at the specified index. This is useful to add a component at any point in the navigation stack.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> insert(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<int> insertIndex, Metapsi.Syntax.Var<string> component, Metapsi.Syntax.Var<object> componentProps = null, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("insert", insertIndex, component, componentProps, opts, done);
    }

    /// <summary>
    /// Inserts a component into the navigation stack at the specified index. This is useful to add a component at any point in the navigation stack.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> insert(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<int> insertIndex, Metapsi.Syntax.Var<Function> component, Metapsi.Syntax.Var<object> componentProps = null, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("insert", insertIndex, component, componentProps, opts, done);
    }

    /// <summary>
    /// Inserts a component into the navigation stack at the specified index. This is useful to add a component at any point in the navigation stack.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> insert(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<int> insertIndex, Metapsi.Syntax.Var<HTMLElement> component, Metapsi.Syntax.Var<object> componentProps = null, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("insert", insertIndex, component, componentProps, opts, done);
    }

    /// <summary>
    /// Inserts a component into the navigation stack at the specified index. This is useful to add a component at any point in the navigation stack.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> insert(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<int> insertIndex, Metapsi.Syntax.Var<ViewController> component, Metapsi.Syntax.Var<object> componentProps = null, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("insert", insertIndex, component, componentProps, opts, done);
    }

    /// <summary>
    /// Inserts an array of components into the navigation stack at the specified index. The last component in the array will become instantiated as a view, and animate in to become the active view.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> insertPages(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<int> insertIndex, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> insertComponents, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("insertPages", insertIndex, insertComponents, opts, done);
    }

    /// <summary>
    /// Inserts an array of components into the navigation stack at the specified index. The last component in the array will become instantiated as a view, and animate in to become the active view.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> insertPages(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<int> insertIndex, Metapsi.Syntax.Var<System.Collections.Generic.List<Function>> insertComponents, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("insertPages", insertIndex, insertComponents, opts, done);
    }

    /// <summary>
    /// Inserts an array of components into the navigation stack at the specified index. The last component in the array will become instantiated as a view, and animate in to become the active view.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> insertPages(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<int> insertIndex, Metapsi.Syntax.Var<System.Collections.Generic.List<HTMLElement>> insertComponents, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("insertPages", insertIndex, insertComponents, opts, done);
    }

    /// <summary>
    /// Inserts an array of components into the navigation stack at the specified index. The last component in the array will become instantiated as a view, and animate in to become the active view.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> insertPages(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<int> insertIndex, Metapsi.Syntax.Var<System.Collections.Generic.List<ViewController>> insertComponents, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("insertPages", insertIndex, insertComponents, opts, done);
    }

    /// <summary>
    /// Inserts an array of components into the navigation stack at the specified index. The last component in the array will become instantiated as a view, and animate in to become the active view.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> insertPages(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<int> insertIndex, Metapsi.Syntax.Var<System.Collections.Generic.List<NavComponentWithProps>> insertComponents, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("insertPages", insertIndex, insertComponents, opts, done);
    }

    /// <summary>
    /// Pop a component off of the navigation stack. Navigates back from the current component.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> pop(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("pop", opts, done);
    }

    /// <summary>
    /// Pop to a specific index in the navigation stack.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> popTo(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<int> indexOrViewCtrl, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("popTo", indexOrViewCtrl, opts, done);
    }

    /// <summary>
    /// Pop to a specific index in the navigation stack.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> popTo(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<ViewController> indexOrViewCtrl, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("popTo", indexOrViewCtrl, opts, done);
    }

    /// <summary>
    /// Navigate back to the root of the stack, no matter how far back that is.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> popToRoot(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("popToRoot", opts, done);
    }

    /// <summary>
    /// Push a new component onto the current navigation stack. Pass any additional information along as an object. This additional information is accessible through NavParams.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> push(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<string> component, Metapsi.Syntax.Var<object> componentProps = null, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("push", component, componentProps, opts, done);
    }

    /// <summary>
    /// Push a new component onto the current navigation stack. Pass any additional information along as an object. This additional information is accessible through NavParams.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> push(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<Function> component, Metapsi.Syntax.Var<object> componentProps = null, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("push", component, componentProps, opts, done);
    }

    /// <summary>
    /// Push a new component onto the current navigation stack. Pass any additional information along as an object. This additional information is accessible through NavParams.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> push(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<HTMLElement> component, Metapsi.Syntax.Var<object> componentProps = null, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("push", component, componentProps, opts, done);
    }

    /// <summary>
    /// Push a new component onto the current navigation stack. Pass any additional information along as an object. This additional information is accessible through NavParams.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> push(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<ViewController> component, Metapsi.Syntax.Var<object> componentProps = null, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("push", component, componentProps, opts, done);
    }

    /// <summary>
    /// Removes a component from the navigation stack at the specified index.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> removeIndex(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<int> startIndex, Metapsi.Syntax.Var<int> removeCount = null, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("removeIndex", startIndex, removeCount, opts, done);
    }

    /// <summary>
    /// Set the views of the current navigation stack and navigate to the last view. By default animations are disabled, but they can be enabled by passing options to the navigation controller. Navigation parameters can also be passed to the individual pages in the array.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> setPages(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> views, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("setPages", views, opts, done);
    }

    /// <summary>
    /// Set the views of the current navigation stack and navigate to the last view. By default animations are disabled, but they can be enabled by passing options to the navigation controller. Navigation parameters can also be passed to the individual pages in the array.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> setPages(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<System.Collections.Generic.List<Function>> views, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("setPages", views, opts, done);
    }

    /// <summary>
    /// Set the views of the current navigation stack and navigate to the last view. By default animations are disabled, but they can be enabled by passing options to the navigation controller. Navigation parameters can also be passed to the individual pages in the array.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> setPages(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<System.Collections.Generic.List<HTMLElement>> views, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("setPages", views, opts, done);
    }

    /// <summary>
    /// Set the views of the current navigation stack and navigate to the last view. By default animations are disabled, but they can be enabled by passing options to the navigation controller. Navigation parameters can also be passed to the individual pages in the array.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> setPages(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<System.Collections.Generic.List<ViewController>> views, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("setPages", views, opts, done);
    }

    /// <summary>
    /// Set the views of the current navigation stack and navigate to the last view. By default animations are disabled, but they can be enabled by passing options to the navigation controller. Navigation parameters can also be passed to the individual pages in the array.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> setPages(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<System.Collections.Generic.List<NavComponentWithProps>> views, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("setPages", views, opts, done);
    }

    /// <summary>
    /// Set the root for the current navigation stack to a component.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> setRoot(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<string> component, Metapsi.Syntax.Var<object> componentProps = null, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("setRoot", component, componentProps, opts, done);
    }

    /// <summary>
    /// Set the root for the current navigation stack to a component.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> setRoot(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<Function> component, Metapsi.Syntax.Var<object> componentProps = null, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("setRoot", component, componentProps, opts, done);
    }

    /// <summary>
    /// Set the root for the current navigation stack to a component.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> setRoot(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<HTMLElement> component, Metapsi.Syntax.Var<object> componentProps = null, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("setRoot", component, componentProps, opts, done);
    }

    /// <summary>
    /// Set the root for the current navigation stack to a component.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> setRoot(this Metapsi.Syntax.ObjBuilder<IonNav> b, Metapsi.Syntax.Var<ViewController> component, Metapsi.Syntax.Var<object> componentProps = null, Metapsi.Syntax.Var<NavOptions> opts = null, Metapsi.Syntax.Var<System.Action<bool, bool, ViewController, ViewController, string>> done = null)
    {
        return b.Call<Promise<bool>>("setRoot", component, componentProps, opts, done);
    }
}