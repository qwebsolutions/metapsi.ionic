using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonItemSliding
{

    /// <summary>
    /// If `true`, the user cannot interact with the sliding item.
    /// </summary>
    public bool disabled { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Close the sliding item. Items can also be closed from the [List](./list).
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonItemSliding> instead")]
        public const string Close = "close";
        /// <summary>
        /// Close all of the sliding items in the list. Items can also be closed from the [List](./list).
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonItemSliding> instead")]
        public const string CloseOpened = "closeOpened";
        /// <summary>
        /// Get the amount the item is open in pixels.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonItemSliding> instead")]
        public const string GetOpenAmount = "getOpenAmount";
        /// <summary>
        /// Get the ratio of the open amount of the item compared to the width of the options. If the number returned is positive, then the options on the right side are open. If the number returned is negative, then the options on the left side are open. If the absolute value of the number is greater than 1, the item is open more than the width of the options.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonItemSliding> instead")]
        public const string GetSlidingRatio = "getSlidingRatio";
        /// <summary>
        /// Open the sliding item.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonItemSliding> instead")]
        public const string Open = "open";
    }
}
public static partial class IonItemSlidingControl
{
    /// <summary>
    /// Builds a "ion-item-sliding" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemSliding(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonItemSliding>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-item-sliding", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-item-sliding" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemSliding(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-item-sliding", children);
    }

    /// <summary>
    /// Builds a "ion-item-sliding" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemSliding(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonItemSliding>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-item-sliding", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-item-sliding" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemSliding(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-item-sliding", children);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the sliding item.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonItemSliding> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the sliding item.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonItemSliding> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// Builds a virtual "ion-item-sliding" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemSliding(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonItemSliding>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-item-sliding", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-item-sliding" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemSliding(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-item-sliding", children);
    }

    /// <summary>
    /// Builds a virtual "ion-item-sliding" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemSliding(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonItemSliding>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-item-sliding", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-item-sliding" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemSliding(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-item-sliding", children);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the sliding item.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemSliding
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonItemSliding
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Emitted when the sliding position changes.
    /// </summary>
    public static void OnIonDrag<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonItemSliding
    {
        b.SetProperty(b.Const("onionDrag"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the sliding position changes.
    /// </summary>
    [System.Obsolete]
    public static void OnIonDrag<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonItemSliding
    {
        b.OnIonDrag(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the sliding position changes.
    /// </summary>
    public static void OnIonDrag<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonItemSliding
    {
        b.SetProperty(b.Const("onionDrag"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the sliding position changes.
    /// </summary>
    [System.Obsolete]
    public static void OnIonDrag<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonItemSliding
    {
        b.OnIonDrag(b.MakeAction(action));
    }
}
public static partial class IonItemSlidingExtensions
{

    /// <summary>
    /// If `true`, the user cannot interact with the sliding item.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemSliding
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonItemSliding
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Close the sliding item. Items can also be closed from the [List](./list).
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> close(this Metapsi.Syntax.ObjBuilder<IonItemSliding> b)
    {
        return b.Call<Promise>("close");
    }

    /// <summary>
    /// Close all of the sliding items in the list. Items can also be closed from the [List](./list).
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> closeOpened(this Metapsi.Syntax.ObjBuilder<IonItemSliding> b)
    {
        return b.Call<Promise<bool>>("closeOpened");
    }

    /// <summary>
    /// Get the amount the item is open in pixels.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<int>> getOpenAmount(this Metapsi.Syntax.ObjBuilder<IonItemSliding> b)
    {
        return b.Call<Promise<int>>("getOpenAmount");
    }

    /// <summary>
    /// Get the ratio of the open amount of the item compared to the width of the options. If the number returned is positive, then the options on the right side are open. If the number returned is negative, then the options on the left side are open. If the absolute value of the number is greater than 1, the item is open more than the width of the options.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<decimal>> getSlidingRatio(this Metapsi.Syntax.ObjBuilder<IonItemSliding> b)
    {
        return b.Call<Promise<decimal>>("getSlidingRatio");
    }

    /// <summary>
    /// Open the sliding item.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> openStart(this Metapsi.Syntax.ObjBuilder<IonItemSliding> b)
    {
        return b.Call<Promise>("open", b.Const("start"));
    }

    /// <summary>
    /// Open the sliding item.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> openEnd(this Metapsi.Syntax.ObjBuilder<IonItemSliding> b)
    {
        return b.Call<Promise>("open", b.Const("end"));
    }
}