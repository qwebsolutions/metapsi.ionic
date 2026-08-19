using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonRefresher
{

    /// <summary>
    /// Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public string closeDuration { get; set; }

    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public bool disabled { get; set; }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode { get; set; }

    /// <summary>
    /// How much to multiply the pull speed by. To slow the pull animation down, pass a number less than `1`. To speed up the pull, pass a number greater than `1`. The default value is `1` which is equal to the speed of the cursor. If a negative value is passed in, the factor will be `1` instead.  For example, If the value passed is `1.2` and the content is dragged by `10` pixels, instead of `10` pixels, the content will be pulled by `12` pixels (an increase of 20 percent). If the value passed is `0.8`, the dragged amount will be `8` pixels, less than the amount the cursor has moved.  Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public decimal pullFactor { get; set; }

    /// <summary>
    /// The maximum distance of the pull until the refresher will automatically go into the `refreshing` state. Defaults to the result of `pullMin + 60`. Does not apply when  the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public int pullMax { get; set; }

    /// <summary>
    /// The minimum distance the user must pull down until the refresher will go into the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public int pullMin { get; set; }

    /// <summary>
    /// Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public string snapbackDuration { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Changes the refresher's state from `refreshing` to `cancelling`.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonRefresher> instead")]
        public const string Cancel = "cancel";
        /// <summary>
        /// Call `complete()` when your async operation has completed. For example, the `refreshing` state is while the app is performing an asynchronous operation, such as receiving more data from an AJAX request. Once the data has been received, you then call this method to signify that the refreshing has completed and to close the refresher. This method also changes the refresher's state from `refreshing` to `completing`.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonRefresher> instead")]
        public const string Complete = "complete";
        /// <summary>
        /// A number representing how far down the user has pulled. The number `0` represents the user hasn't pulled down at all. The number `1`, and anything greater than `1`, represents that the user has pulled far enough down that when they let go then the refresh will happen. If they let go and the number is less than `1`, then the refresh will not happen, and the content will return to it's original position.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonRefresher> instead")]
        public const string GetProgress = "getProgress";
    }
}
public static partial class IonRefresherControl
{
    /// <summary>
    /// Builds a "ion-refresher" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRefresher(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRefresher>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-refresher", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-refresher" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRefresher(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-refresher", children);
    }

    /// <summary>
    /// Builds a "ion-refresher" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRefresher(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRefresher>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-refresher", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-refresher" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRefresher(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-refresher", children);
    }

    /// <summary>
    /// Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetCloseDuration(this Metapsi.Html.AttributesBuilder<IonRefresher> b, string closeDuration)
    {
        b.SetAttribute("close-duration", closeDuration);
    }

    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonRefresher> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonRefresher> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonRefresher> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonRefresher> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// How much to multiply the pull speed by. To slow the pull animation down, pass a number less than `1`. To speed up the pull, pass a number greater than `1`. The default value is `1` which is equal to the speed of the cursor. If a negative value is passed in, the factor will be `1` instead.  For example, If the value passed is `1.2` and the content is dragged by `10` pixels, instead of `10` pixels, the content will be pulled by `12` pixels (an increase of 20 percent). If the value passed is `0.8`, the dragged amount will be `8` pixels, less than the amount the cursor has moved.  Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullFactor(this Metapsi.Html.AttributesBuilder<IonRefresher> b, string pullFactor)
    {
        b.SetAttribute("pull-factor", pullFactor);
    }

    /// <summary>
    /// The maximum distance of the pull until the refresher will automatically go into the `refreshing` state. Defaults to the result of `pullMin + 60`. Does not apply when  the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMax(this Metapsi.Html.AttributesBuilder<IonRefresher> b, string pullMax)
    {
        b.SetAttribute("pull-max", pullMax);
    }

    /// <summary>
    /// The minimum distance the user must pull down until the refresher will go into the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMin(this Metapsi.Html.AttributesBuilder<IonRefresher> b, string pullMin)
    {
        b.SetAttribute("pull-min", pullMin);
    }

    /// <summary>
    /// Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetSnapbackDuration(this Metapsi.Html.AttributesBuilder<IonRefresher> b, string snapbackDuration)
    {
        b.SetAttribute("snapback-duration", snapbackDuration);
    }
    /// <summary>
    /// Builds a virtual "ion-refresher" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRefresher(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRefresher>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-refresher", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-refresher" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRefresher(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-refresher", children);
    }

    /// <summary>
    /// Builds a virtual "ion-refresher" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRefresher(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRefresher>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-refresher", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-refresher" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRefresher(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-refresher", children);
    }

    /// <summary>
    /// Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetCloseDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> closeDuration) where T: IonRefresher
    {
        b.SetProperty(b.Const("closeDuration"), closeDuration);
    }

    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresher
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonRefresher
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresher
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresher
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// How much to multiply the pull speed by. To slow the pull animation down, pass a number less than `1`. To speed up the pull, pass a number greater than `1`. The default value is `1` which is equal to the speed of the cursor. If a negative value is passed in, the factor will be `1` instead.  For example, If the value passed is `1.2` and the content is dragged by `10` pixels, instead of `10` pixels, the content will be pulled by `12` pixels (an increase of 20 percent). If the value passed is `0.8`, the dragged amount will be `8` pixels, less than the amount the cursor has moved.  Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullFactor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> pullFactor) where T: IonRefresher
    {
        b.SetProperty(b.Const("pullFactor"), pullFactor);
    }

    /// <summary>
    /// The maximum distance of the pull until the refresher will automatically go into the `refreshing` state. Defaults to the result of `pullMin + 60`. Does not apply when  the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> pullMax) where T: IonRefresher
    {
        b.SetProperty(b.Const("pullMax"), pullMax);
    }

    /// <summary>
    /// The minimum distance the user must pull down until the refresher will go into the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMin<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> pullMin) where T: IonRefresher
    {
        b.SetProperty(b.Const("pullMin"), pullMin);
    }

    /// <summary>
    /// Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetSnapbackDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> snapbackDuration) where T: IonRefresher
    {
        b.SetProperty(b.Const("snapbackDuration"), snapbackDuration);
    }

    /// <summary>
    /// Emitted while the user is pulling down the content and exposing the refresher.
    /// </summary>
    public static void OnIonPull<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRefresher
    {
        b.SetProperty(b.Const("onionPull"), b.Const(action));
    }

    /// <summary>
    /// Emitted while the user is pulling down the content and exposing the refresher.
    /// </summary>
    [System.Obsolete]
    public static void OnIonPull<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonPull(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted while the user is pulling down the content and exposing the refresher.
    /// </summary>
    public static void OnIonPull<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRefresher
    {
        b.SetProperty(b.Const("onionPull"), b.Const(action));
    }

    /// <summary>
    /// Emitted while the user is pulling down the content and exposing the refresher.
    /// </summary>
    [System.Obsolete]
    public static void OnIonPull<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonPull(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the refresher has returned to the inactive state after a pull gesture. This fires whether the refresh completed successfully or was canceled.
    /// </summary>
    public static void OnIonPullEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRefresher
    {
        b.SetProperty(b.Const("onionPullEnd"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the refresher has returned to the inactive state after a pull gesture. This fires whether the refresh completed successfully or was canceled.
    /// </summary>
    [System.Obsolete]
    public static void OnIonPullEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonPullEnd(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the refresher has returned to the inactive state after a pull gesture. This fires whether the refresh completed successfully or was canceled.
    /// </summary>
    public static void OnIonPullEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRefresher
    {
        b.SetProperty(b.Const("onionPullEnd"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the refresher has returned to the inactive state after a pull gesture. This fires whether the refresh completed successfully or was canceled.
    /// </summary>
    [System.Obsolete]
    public static void OnIonPullEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonPullEnd(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the refresher has returned to the inactive state after a pull gesture. This fires whether the refresh completed successfully or was canceled.
    /// </summary>
    public static void OnIonPullEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<RefresherPullEndEventDetail>>> action) where T: IonRefresher
    {
        b.SetProperty(b.Const("onionPullEnd"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    public static void OnIonPullStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRefresher
    {
        b.SetProperty(b.Const("onionPullStart"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    [System.Obsolete]
    public static void OnIonPullStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonPullStart(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    public static void OnIonPullStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRefresher
    {
        b.SetProperty(b.Const("onionPullStart"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    [System.Obsolete]
    public static void OnIonPullStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonPullStart(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed.
    /// </summary>
    public static void OnIonRefresh<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRefresher
    {
        b.SetProperty(b.Const("onionRefresh"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonRefresh<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonRefresh(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed.
    /// </summary>
    public static void OnIonRefresh<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRefresher
    {
        b.SetProperty(b.Const("onionRefresh"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonRefresh<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonRefresh(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed.
    /// </summary>
    public static void OnIonRefresh<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<RefresherEventDetail>>> action) where T: IonRefresher
    {
        b.SetProperty(b.Const("onionRefresh"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    public static void OnIonStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRefresher
    {
        b.SetProperty(b.Const("onionStart"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    [System.Obsolete]
    public static void OnIonStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonStart(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    public static void OnIonStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRefresher
    {
        b.SetProperty(b.Const("onionStart"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    [System.Obsolete]
    public static void OnIonStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonStart(b.MakeAction(action));
    }
}
public static partial class IonRefresherExtensions
{

    /// <summary>
    /// Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetCloseDuration<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> closeDuration) where T: IonRefresher
    {
        b.SetProperty(b.Const("closeDuration"), closeDuration);
    }

    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRefresher
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonRefresher
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRefresher
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRefresher
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// How much to multiply the pull speed by. To slow the pull animation down, pass a number less than `1`. To speed up the pull, pass a number greater than `1`. The default value is `1` which is equal to the speed of the cursor. If a negative value is passed in, the factor will be `1` instead.  For example, If the value passed is `1.2` and the content is dragged by `10` pixels, instead of `10` pixels, the content will be pulled by `12` pixels (an increase of 20 percent). If the value passed is `0.8`, the dragged amount will be `8` pixels, less than the amount the cursor has moved.  Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullFactor<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<decimal> pullFactor) where T: IonRefresher
    {
        b.SetProperty(b.Const("pullFactor"), pullFactor);
    }

    /// <summary>
    /// The maximum distance of the pull until the refresher will automatically go into the `refreshing` state. Defaults to the result of `pullMin + 60`. Does not apply when  the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMax<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<int> pullMax) where T: IonRefresher
    {
        b.SetProperty(b.Const("pullMax"), pullMax);
    }

    /// <summary>
    /// The minimum distance the user must pull down until the refresher will go into the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMin<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<int> pullMin) where T: IonRefresher
    {
        b.SetProperty(b.Const("pullMin"), pullMin);
    }

    /// <summary>
    /// Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetSnapbackDuration<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> snapbackDuration) where T: IonRefresher
    {
        b.SetProperty(b.Const("snapbackDuration"), snapbackDuration);
    }

    /// <summary>
    /// Changes the refresher's state from `refreshing` to `cancelling`.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> cancel(this Metapsi.Syntax.ObjBuilder<IonRefresher> b)
    {
        return b.Call<Promise>("cancel");
    }

    /// <summary>
    /// Call `complete()` when your async operation has completed. For example, the `refreshing` state is while the app is performing an asynchronous operation, such as receiving more data from an AJAX request. Once the data has been received, you then call this method to signify that the refreshing has completed and to close the refresher. This method also changes the refresher's state from `refreshing` to `completing`.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> complete(this Metapsi.Syntax.ObjBuilder<IonRefresher> b)
    {
        return b.Call<Promise>("complete");
    }

    /// <summary>
    /// A number representing how far down the user has pulled. The number `0` represents the user hasn't pulled down at all. The number `1`, and anything greater than `1`, represents that the user has pulled far enough down that when they let go then the refresh will happen. If they let go and the number is less than `1`, then the refresh will not happen, and the content will return to it's original position.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<decimal>> getProgress(this Metapsi.Syntax.ObjBuilder<IonRefresher> b)
    {
        return b.Call<Promise<decimal>>("getProgress");
    }
}