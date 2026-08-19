using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonLoading
{

    /// <summary>
    /// If `true`, the loading indicator will animate.
    /// </summary>
    public bool animated { get; set; }

    /// <summary>
    /// If `true`, the loading indicator will be dismissed when the backdrop is clicked.
    /// </summary>
    public bool backdropDismiss { get; set; }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public object cssClass { get; set; }

    /// <summary>
    /// Number of milliseconds to wait before dismissing the loading indicator.
    /// </summary>
    public int duration { get; set; }

    /// <summary>
    /// Animation to use when the loading indicator is presented.
    /// </summary>
    public System.Func<object, object, Animation> enterAnimation { get; set; }

    /// <summary>
    /// Additional attributes to pass to the loader.
    /// </summary>
    public object htmlAttributes { get; set; }

    /// <summary>
    /// If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code.
    /// </summary>
    public bool isOpen { get; set; }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public bool keyboardClose { get; set; }

    /// <summary>
    /// Animation to use when the loading indicator is dismissed.
    /// </summary>
    public System.Func<object, object, Animation> leaveAnimation { get; set; }

    /// <summary>
    /// Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public object message { get; set; }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode { get; set; }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the loading indicator.
    /// </summary>
    public bool showBackdrop { get; set; }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public string spinner { get; set; }

    /// <summary>
    /// If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public bool translucent { get; set; }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the loading indicator to open when clicked.
    /// </summary>
    public string trigger { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Dismiss the loading overlay after it has been presented. This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonLoading> instead")]
        public const string Dismiss = "dismiss";
        /// <summary>
        /// Returns a promise that resolves when the loading did dismiss.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonLoading> instead")]
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// Returns a promise that resolves when the loading will dismiss.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonLoading> instead")]
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// Present the loading overlay after it has been created.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonLoading> instead")]
        public const string Present = "present";
    }
}
public static partial class IonLoadingControl
{
    /// <summary>
    /// Builds a "ion-loading" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonLoading(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonLoading>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-loading", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-loading" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonLoading(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-loading", children);
    }

    /// <summary>
    /// Builds a "ion-loading" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonLoading(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonLoading>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-loading", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-loading" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonLoading(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-loading", children);
    }

    /// <summary>
    /// If `true`, the loading indicator will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonLoading> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the loading indicator will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the loading indicator will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonLoading> b, bool backdropDismiss)
    {
        if (backdropDismiss) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// If `true`, the loading indicator will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this Metapsi.Html.AttributesBuilder<IonLoading> b, string cssClass)
    {
        b.SetAttribute("css-class", cssClass);
    }

    /// <summary>
    /// Number of milliseconds to wait before dismissing the loading indicator.
    /// </summary>
    public static void SetDuration(this Metapsi.Html.AttributesBuilder<IonLoading> b, string duration)
    {
        b.SetAttribute("duration", duration);
    }

    /// <summary>
    /// If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonLoading> b, bool isOpen)
    {
        if (isOpen) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonLoading> b, bool keyboardClose)
    {
        if (keyboardClose) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage(this Metapsi.Html.AttributesBuilder<IonLoading> b, string message)
    {
        b.SetAttribute("message", message);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the loading indicator.
    /// </summary>
    public static void SetShowBackdrop(this Metapsi.Html.AttributesBuilder<IonLoading> b, bool showBackdrop)
    {
        if (showBackdrop) b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the loading indicator.
    /// </summary>
    public static void SetShowBackdrop(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerBubbles(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "bubbles");
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCircles(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "circles");
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCircular(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "circular");
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCrescent(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "crescent");
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerDots(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "dots");
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLines(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "lines");
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSmall(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "lines-small");
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSharp(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "lines-sharp");
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSharpSmall(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "lines-sharp-small");
    }

    /// <summary>
    /// If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonLoading> b, bool translucent)
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the loading indicator to open when clicked.
    /// </summary>
    public static void SetTrigger(this Metapsi.Html.AttributesBuilder<IonLoading> b, string trigger)
    {
        b.SetAttribute("trigger", trigger);
    }
    /// <summary>
    /// Builds a virtual "ion-loading" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonLoading(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonLoading>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-loading", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-loading" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonLoading(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-loading", children);
    }

    /// <summary>
    /// Builds a virtual "ion-loading" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonLoading(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonLoading>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-loading", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-loading" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonLoading(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-loading", children);
    }

    /// <summary>
    /// If `true`, the loading indicator will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonLoading
    {
        b.SetProperty(b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the loading indicator will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("backdropDismiss"), b.Const(true));
    }
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> backdropDismiss) where T: IonLoading
    {
        b.SetProperty(b.Const("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> cssClass) where T: IonLoading
    {
        b.SetProperty(b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> cssClass) where T: IonLoading
    {
        b.SetProperty(b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Number of milliseconds to wait before dismissing the loading indicator.
    /// </summary>
    public static void SetDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> duration) where T: IonLoading
    {
        b.SetProperty(b.Const("duration"), duration);
    }

    /// <summary>
    /// Animation to use when the loading indicator is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> enterAnimation) where T: IonLoading
    {
        b.SetProperty(b.Const("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// Additional attributes to pass to the loader.
    /// </summary>
    public static void SetHtmlAttributes<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<object> htmlAttributes) where T: IonLoading
    {
        b.SetProperty(b.Const("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("isOpen"), b.Const(true));
    }
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> isOpen) where T: IonLoading
    {
        b.SetProperty(b.Const("isOpen"), isOpen);
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("keyboardClose"), b.Const(true));
    }
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> keyboardClose) where T: IonLoading
    {
        b.SetProperty(b.Const("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// Animation to use when the loading indicator is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> leaveAnimation) where T: IonLoading
    {
        b.SetProperty(b.Const("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> message) where T: IonLoading
    {
        b.SetProperty(b.Const("message"), message);
    }

    /// <summary>
    /// Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<IonicSafeString> message) where T: IonLoading
    {
        b.SetProperty(b.Const("message"), message);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the loading indicator.
    /// </summary>
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("showBackdrop"), b.Const(true));
    }
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> showBackdrop) where T: IonLoading
    {
        b.SetProperty(b.Const("showBackdrop"), showBackdrop);
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerBubbles<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("bubbles"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCircles<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("circles"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCircular<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("circular"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCrescent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("crescent"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerDots<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("dots"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLines<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("lines"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("lines-small"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSharp<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("lines-sharp"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSharpSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("lines-sharp-small"));
    }

    /// <summary>
    /// If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("translucent"), b.Const(true));
    }
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonLoading
    {
        b.SetProperty(b.Const("translucent"), translucent);
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the loading indicator to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: IonLoading
    {
        b.SetProperty(b.Const("trigger"), trigger);
    }

    /// <summary>
    /// Emitted after the loading indicator has dismissed. Shorthand for ionLoadingDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the loading indicator has dismissed. Shorthand for ionLoadingDidDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the loading indicator has dismissed. Shorthand for ionLoadingDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the loading indicator has dismissed. Shorthand for ionLoadingDidDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the loading indicator has dismissed. Shorthand for ionLoadingDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the loading indicator has presented. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("ondidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the loading indicator has presented. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the loading indicator has presented. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("ondidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the loading indicator has presented. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the loading has dismissed.
    /// </summary>
    public static void OnIonLoadingDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onionLoadingDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the loading has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonLoadingDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnIonLoadingDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the loading has dismissed.
    /// </summary>
    public static void OnIonLoadingDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onionLoadingDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the loading has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonLoadingDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnIonLoadingDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the loading has dismissed.
    /// </summary>
    public static void OnIonLoadingDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onionLoadingDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the loading has presented.
    /// </summary>
    public static void OnIonLoadingDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onionLoadingDidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the loading has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonLoadingDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnIonLoadingDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the loading has presented.
    /// </summary>
    public static void OnIonLoadingDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onionLoadingDidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the loading has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonLoadingDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnIonLoadingDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the loading has dismissed.
    /// </summary>
    public static void OnIonLoadingWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onionLoadingWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the loading has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonLoadingWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnIonLoadingWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the loading has dismissed.
    /// </summary>
    public static void OnIonLoadingWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onionLoadingWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the loading has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonLoadingWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnIonLoadingWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the loading has dismissed.
    /// </summary>
    public static void OnIonLoadingWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onionLoadingWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the loading has presented.
    /// </summary>
    public static void OnIonLoadingWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onionLoadingWillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the loading has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonLoadingWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnIonLoadingWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the loading has presented.
    /// </summary>
    public static void OnIonLoadingWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onionLoadingWillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the loading has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonLoadingWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnIonLoadingWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the loading indicator has dismissed. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the loading indicator has dismissed. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the loading indicator has dismissed. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the loading indicator has dismissed. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the loading indicator has dismissed. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the loading indicator has presented. Shorthand for ionLoadingWillPresent.
    /// </summary>
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onwillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the loading indicator has presented. Shorthand for ionLoadingWillPresent.
    /// </summary>
    [System.Obsolete]
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the loading indicator has presented. Shorthand for ionLoadingWillPresent.
    /// </summary>
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonLoading
    {
        b.SetProperty(b.Const("onwillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the loading indicator has presented. Shorthand for ionLoadingWillPresent.
    /// </summary>
    [System.Obsolete]
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonLoading
    {
        b.OnWillPresent(b.MakeAction(action));
    }
}
public static partial class IonLoadingExtensions
{

    /// <summary>
    /// If `true`, the loading indicator will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonLoading
    {
        b.SetProperty(b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the loading indicator will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("backdropDismiss"), b.Const(true));
    }
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> backdropDismiss) where T: IonLoading
    {
        b.SetProperty(b.Const("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> cssClass) where T: IonLoading
    {
        b.SetProperty(b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> cssClass) where T: IonLoading
    {
        b.SetProperty(b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Number of milliseconds to wait before dismissing the loading indicator.
    /// </summary>
    public static void SetDuration<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<int> duration) where T: IonLoading
    {
        b.SetProperty(b.Const("duration"), duration);
    }

    /// <summary>
    /// Animation to use when the loading indicator is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> enterAnimation) where T: IonLoading
    {
        b.SetProperty(b.Const("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// Additional attributes to pass to the loader.
    /// </summary>
    public static void SetHtmlAttributes<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<object> htmlAttributes) where T: IonLoading
    {
        b.SetProperty(b.Const("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("isOpen"), b.Const(true));
    }
    public static void SetIsOpen<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> isOpen) where T: IonLoading
    {
        b.SetProperty(b.Const("isOpen"), isOpen);
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("keyboardClose"), b.Const(true));
    }
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> keyboardClose) where T: IonLoading
    {
        b.SetProperty(b.Const("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// Animation to use when the loading indicator is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> leaveAnimation) where T: IonLoading
    {
        b.SetProperty(b.Const("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> message) where T: IonLoading
    {
        b.SetProperty(b.Const("message"), message);
    }

    /// <summary>
    /// Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<IonicSafeString> message) where T: IonLoading
    {
        b.SetProperty(b.Const("message"), message);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the loading indicator.
    /// </summary>
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("showBackdrop"), b.Const(true));
    }
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> showBackdrop) where T: IonLoading
    {
        b.SetProperty(b.Const("showBackdrop"), showBackdrop);
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerBubbles<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("bubbles"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCircles<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("circles"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCircular<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("circular"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCrescent<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("crescent"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerDots<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("dots"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLines<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("lines"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSmall<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("lines-small"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSharp<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("lines-sharp"));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSharpSmall<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("spinner"), b.Const("lines-sharp-small"));
    }

    /// <summary>
    /// If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonLoading
    {
        b.SetProperty(b.Const("translucent"), b.Const(true));
    }
    public static void SetTranslucent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonLoading
    {
        b.SetProperty(b.Const("translucent"), translucent);
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the loading indicator to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: IonLoading
    {
        b.SetProperty(b.Const("trigger"), trigger);
    }

    /// <summary>
    /// Dismiss the loading overlay after it has been presented. This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> dismiss(this Metapsi.Syntax.ObjBuilder<IonLoading> b, Metapsi.Syntax.Var<object> data = null, Metapsi.Syntax.Var<string> role = null)
    {
        return b.Call<Promise<bool>>("dismiss", data, role);
    }

    /// <summary>
    /// Returns a promise that resolves when the loading did dismiss.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<OverlayEventDetail>> onDidDismiss<T1>(this Metapsi.Syntax.ObjBuilder<IonLoading> b)
    {
        return b.Call<Promise<OverlayEventDetail>>("onDidDismiss");
    }

    /// <summary>
    /// Returns a promise that resolves when the loading will dismiss.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<OverlayEventDetail>> onWillDismiss<T1>(this Metapsi.Syntax.ObjBuilder<IonLoading> b)
    {
        return b.Call<Promise<OverlayEventDetail>>("onWillDismiss");
    }

    /// <summary>
    /// Present the loading overlay after it has been created.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> present(this Metapsi.Syntax.ObjBuilder<IonLoading> b)
    {
        return b.Call<Promise>("present");
    }
}