using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonInfiniteScroll
{

    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public bool disabled { get; set; }

    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public string position { get; set; }

    /// <summary>
    /// The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page.
    /// </summary>
    public string threshold { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Call `complete()` within the `ionInfinite` output event handler when your async operation has completed. For example, the `loading` state is while the app is performing an asynchronous operation, such as receiving more data from an AJAX request to add more items to a data list. Once the data has been received and UI updated, you then call this method to signify that the loading has completed. This method will change the infinite scroll's state from `loading` to `enabled`.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonInfiniteScroll> instead")]
        public const string Complete = "complete";
    }
}
public static partial class IonInfiniteScrollControl
{
    /// <summary>
    /// Builds a "ion-infinite-scroll" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInfiniteScroll(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonInfiniteScroll>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-infinite-scroll", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-infinite-scroll" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInfiniteScroll(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-infinite-scroll", children);
    }

    /// <summary>
    /// Builds a "ion-infinite-scroll" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInfiniteScroll(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonInfiniteScroll>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-infinite-scroll", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-infinite-scroll" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInfiniteScroll(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-infinite-scroll", children);
    }

    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonInfiniteScroll> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonInfiniteScroll> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionTop(this Metapsi.Html.AttributesBuilder<IonInfiniteScroll> b)
    {
        b.SetAttribute("position", "top");
    }

    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionBottom(this Metapsi.Html.AttributesBuilder<IonInfiniteScroll> b)
    {
        b.SetAttribute("position", "bottom");
    }

    /// <summary>
    /// The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page.
    /// </summary>
    public static void SetThreshold(this Metapsi.Html.AttributesBuilder<IonInfiniteScroll> b, string threshold)
    {
        b.SetAttribute("threshold", threshold);
    }
    /// <summary>
    /// Builds a virtual "ion-infinite-scroll" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInfiniteScroll(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonInfiniteScroll>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-infinite-scroll", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-infinite-scroll" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInfiniteScroll(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-infinite-scroll", children);
    }

    /// <summary>
    /// Builds a virtual "ion-infinite-scroll" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInfiniteScroll(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonInfiniteScroll>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-infinite-scroll", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-infinite-scroll" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInfiniteScroll(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-infinite-scroll", children);
    }

    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Const("position"), b.Const("top"));
    }

    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Const("position"), b.Const("bottom"));
    }

    /// <summary>
    /// The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page.
    /// </summary>
    public static void SetThreshold<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> threshold) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Const("threshold"), threshold);
    }

    /// <summary>
    /// Emitted when the scroll reaches the threshold distance. From within your infinite handler, you must call the infinite scroll's `complete()` method when your async operation has completed.
    /// </summary>
    public static void OnIonInfinite<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Const("onionInfinite"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the scroll reaches the threshold distance. From within your infinite handler, you must call the infinite scroll's `complete()` method when your async operation has completed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonInfinite<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonInfiniteScroll
    {
        b.OnIonInfinite(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the scroll reaches the threshold distance. From within your infinite handler, you must call the infinite scroll's `complete()` method when your async operation has completed.
    /// </summary>
    public static void OnIonInfinite<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Const("onionInfinite"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the scroll reaches the threshold distance. From within your infinite handler, you must call the infinite scroll's `complete()` method when your async operation has completed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonInfinite<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonInfiniteScroll
    {
        b.OnIonInfinite(b.MakeAction(action));
    }
}
public static partial class IonInfiniteScrollExtensions
{

    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionTop<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Const("position"), b.Const("top"));
    }

    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionBottom<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Const("position"), b.Const("bottom"));
    }

    /// <summary>
    /// The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page.
    /// </summary>
    public static void SetThreshold<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> threshold) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Const("threshold"), threshold);
    }

    /// <summary>
    /// Call `complete()` within the `ionInfinite` output event handler when your async operation has completed. For example, the `loading` state is while the app is performing an asynchronous operation, such as receiving more data from an AJAX request to add more items to a data list. Once the data has been received and UI updated, you then call this method to signify that the loading has completed. This method will change the infinite scroll's state from `loading` to `enabled`.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> complete(this Metapsi.Syntax.ObjBuilder<IonInfiniteScroll> b)
    {
        return b.Call<Promise>("complete");
    }
}