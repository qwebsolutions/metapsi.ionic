using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonAlert
{

    /// <summary>
    /// If `true`, the alert will animate.
    /// </summary>
    public bool animated { get; set; }

    /// <summary>
    /// If `true`, the alert will be dismissed when the backdrop is clicked.
    /// </summary>
    public bool backdropDismiss { get; set; }

    /// <summary>
    /// Array of buttons to be added to the alert.
    /// </summary>
    public System.Collections.Generic.List<string> buttons { get; set; }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public object cssClass { get; set; }

    /// <summary>
    /// Animation to use when the alert is presented.
    /// </summary>
    public System.Func<object, object, Animation> enterAnimation { get; set; }

    /// <summary>
    /// The main title in the heading of the alert.
    /// </summary>
    public string header { get; set; }

    /// <summary>
    /// Additional attributes to pass to the alert.
    /// </summary>
    public object htmlAttributes { get; set; }

    /// <summary>
    /// Array of input to show in the alert.
    /// </summary>
    public System.Collections.Generic.List<AlertInput> inputs { get; set; }

    /// <summary>
    /// If `true`, the alert will open. If `false`, the alert will close. Use this if you need finer grained control over presentation, otherwise just use the alertController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the alert dismisses. You will need to do that in your code.
    /// </summary>
    public bool isOpen { get; set; }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public bool keyboardClose { get; set; }

    /// <summary>
    /// Animation to use when the alert is dismissed.
    /// </summary>
    public System.Func<object, object, Animation> leaveAnimation { get; set; }

    /// <summary>
    /// The main message to be displayed in the alert. `message` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public object message { get; set; }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode { get; set; }

    /// <summary>
    /// The subtitle in the heading of the alert. Displayed under the title.
    /// </summary>
    public string subHeader { get; set; }

    /// <summary>
    /// If `true`, the alert will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public bool translucent { get; set; }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the alert to open when clicked.
    /// </summary>
    public string trigger { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Dismiss the alert overlay after it has been presented. This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonAlert> instead")]
        public const string Dismiss = "dismiss";
        /// <summary>
        /// Returns a promise that resolves when the alert did dismiss.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonAlert> instead")]
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// Returns a promise that resolves when the alert will dismiss.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonAlert> instead")]
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// Present the alert overlay after it has been created.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonAlert> instead")]
        public const string Present = "present";
    }
}
public static partial class IonAlertControl
{
    /// <summary>
    /// Builds a "ion-alert" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonAlert(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonAlert>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-alert", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-alert" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonAlert(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-alert", children);
    }

    /// <summary>
    /// Builds a "ion-alert" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonAlert(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonAlert>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-alert", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-alert" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonAlert(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-alert", children);
    }

    /// <summary>
    /// If `true`, the alert will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonAlert> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the alert will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonAlert> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the alert will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonAlert> b, bool backdropDismiss)
    {
        if (backdropDismiss) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// If `true`, the alert will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonAlert> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this Metapsi.Html.AttributesBuilder<IonAlert> b, string cssClass)
    {
        b.SetAttribute("css-class", cssClass);
    }

    /// <summary>
    /// The main title in the heading of the alert.
    /// </summary>
    public static void SetHeader(this Metapsi.Html.AttributesBuilder<IonAlert> b, string header)
    {
        b.SetAttribute("header", header);
    }

    /// <summary>
    /// If `true`, the alert will open. If `false`, the alert will close. Use this if you need finer grained control over presentation, otherwise just use the alertController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the alert dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonAlert> b, bool isOpen)
    {
        if (isOpen) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the alert will open. If `false`, the alert will close. Use this if you need finer grained control over presentation, otherwise just use the alertController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the alert dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonAlert> b)
    {
        b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonAlert> b, bool keyboardClose)
    {
        if (keyboardClose) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonAlert> b)
    {
        b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// The main message to be displayed in the alert. `message` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage(this Metapsi.Html.AttributesBuilder<IonAlert> b, string message)
    {
        b.SetAttribute("message", message);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonAlert> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonAlert> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The subtitle in the heading of the alert. Displayed under the title.
    /// </summary>
    public static void SetSubHeader(this Metapsi.Html.AttributesBuilder<IonAlert> b, string subHeader)
    {
        b.SetAttribute("sub-header", subHeader);
    }

    /// <summary>
    /// If `true`, the alert will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonAlert> b, bool translucent)
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// If `true`, the alert will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonAlert> b)
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the alert to open when clicked.
    /// </summary>
    public static void SetTrigger(this Metapsi.Html.AttributesBuilder<IonAlert> b, string trigger)
    {
        b.SetAttribute("trigger", trigger);
    }
    /// <summary>
    /// Builds a virtual "ion-alert" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonAlert(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonAlert>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-alert", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-alert" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonAlert(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-alert", children);
    }

    /// <summary>
    /// Builds a virtual "ion-alert" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonAlert(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonAlert>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-alert", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-alert" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonAlert(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-alert", children);
    }

    /// <summary>
    /// If `true`, the alert will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAlert
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonAlert
    {
        b.SetProperty(b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the alert will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAlert
    {
        b.SetProperty(b.Const("backdropDismiss"), b.Const(true));
    }
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> backdropDismiss) where T: IonAlert
    {
        b.SetProperty(b.Const("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// Array of buttons to be added to the alert.
    /// </summary>
    public static void SetButtons<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> buttons) where T: IonAlert
    {
        b.SetProperty(b.Const("buttons"), buttons);
    }

    /// <summary>
    /// Array of buttons to be added to the alert.
    /// </summary>
    public static void SetButtons<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<AlertButton>> buttons) where T: IonAlert
    {
        b.SetProperty(b.Const("buttons"), buttons);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> cssClass) where T: IonAlert
    {
        b.SetProperty(b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> cssClass) where T: IonAlert
    {
        b.SetProperty(b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Animation to use when the alert is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> enterAnimation) where T: IonAlert
    {
        b.SetProperty(b.Const("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// The main title in the heading of the alert.
    /// </summary>
    public static void SetHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> header) where T: IonAlert
    {
        b.SetProperty(b.Const("header"), header);
    }

    /// <summary>
    /// Additional attributes to pass to the alert.
    /// </summary>
    public static void SetHtmlAttributes<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<object> htmlAttributes) where T: IonAlert
    {
        b.SetProperty(b.Const("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// Array of input to show in the alert.
    /// </summary>
    public static void SetInputs<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<AlertInput>> inputs) where T: IonAlert
    {
        b.SetProperty(b.Const("inputs"), inputs);
    }

    /// <summary>
    /// If `true`, the alert will open. If `false`, the alert will close. Use this if you need finer grained control over presentation, otherwise just use the alertController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the alert dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAlert
    {
        b.SetProperty(b.Const("isOpen"), b.Const(true));
    }
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> isOpen) where T: IonAlert
    {
        b.SetProperty(b.Const("isOpen"), isOpen);
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAlert
    {
        b.SetProperty(b.Const("keyboardClose"), b.Const(true));
    }
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> keyboardClose) where T: IonAlert
    {
        b.SetProperty(b.Const("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// Animation to use when the alert is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> leaveAnimation) where T: IonAlert
    {
        b.SetProperty(b.Const("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// The main message to be displayed in the alert. `message` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> message) where T: IonAlert
    {
        b.SetProperty(b.Const("message"), message);
    }

    /// <summary>
    /// The main message to be displayed in the alert. `message` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<IonicSafeString> message) where T: IonAlert
    {
        b.SetProperty(b.Const("message"), message);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAlert
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAlert
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// The subtitle in the heading of the alert. Displayed under the title.
    /// </summary>
    public static void SetSubHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> subHeader) where T: IonAlert
    {
        b.SetProperty(b.Const("subHeader"), subHeader);
    }

    /// <summary>
    /// If `true`, the alert will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAlert
    {
        b.SetProperty(b.Const("translucent"), b.Const(true));
    }
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonAlert
    {
        b.SetProperty(b.Const("translucent"), translucent);
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the alert to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: IonAlert
    {
        b.SetProperty(b.Const("trigger"), trigger);
    }

    /// <summary>
    /// Emitted after the alert has dismissed. Shorthand for ionAlertDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the alert has dismissed. Shorthand for ionAlertDidDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert has dismissed. Shorthand for ionAlertDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the alert has dismissed. Shorthand for ionAlertDidDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert has dismissed. Shorthand for ionAlertDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the alert has presented. Shorthand for ionAlertWillDismiss.
    /// </summary>
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("ondidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the alert has presented. Shorthand for ionAlertWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert has presented. Shorthand for ionAlertWillDismiss.
    /// </summary>
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("ondidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the alert has presented. Shorthand for ionAlertWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert has dismissed.
    /// </summary>
    public static void OnIonAlertDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onionAlertDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the alert has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonAlertDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnIonAlertDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert has dismissed.
    /// </summary>
    public static void OnIonAlertDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onionAlertDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the alert has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonAlertDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnIonAlertDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert has dismissed.
    /// </summary>
    public static void OnIonAlertDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onionAlertDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the alert has presented.
    /// </summary>
    public static void OnIonAlertDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onionAlertDidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the alert has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonAlertDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnIonAlertDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert has presented.
    /// </summary>
    public static void OnIonAlertDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onionAlertDidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the alert has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonAlertDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnIonAlertDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the alert has dismissed.
    /// </summary>
    public static void OnIonAlertWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onionAlertWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the alert has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonAlertWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnIonAlertWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the alert has dismissed.
    /// </summary>
    public static void OnIonAlertWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onionAlertWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the alert has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonAlertWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnIonAlertWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the alert has dismissed.
    /// </summary>
    public static void OnIonAlertWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onionAlertWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the alert has presented.
    /// </summary>
    public static void OnIonAlertWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onionAlertWillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the alert has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonAlertWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnIonAlertWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the alert has presented.
    /// </summary>
    public static void OnIonAlertWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onionAlertWillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the alert has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonAlertWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnIonAlertWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the alert has dismissed. Shorthand for ionAlertWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the alert has dismissed. Shorthand for ionAlertWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the alert has dismissed. Shorthand for ionAlertWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the alert has dismissed. Shorthand for ionAlertWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the alert has dismissed. Shorthand for ionAlertWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the alert has presented. Shorthand for ionAlertWillPresent.
    /// </summary>
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onwillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the alert has presented. Shorthand for ionAlertWillPresent.
    /// </summary>
    [System.Obsolete]
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the alert has presented. Shorthand for ionAlertWillPresent.
    /// </summary>
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonAlert
    {
        b.SetProperty(b.Const("onwillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the alert has presented. Shorthand for ionAlertWillPresent.
    /// </summary>
    [System.Obsolete]
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonAlert
    {
        b.OnWillPresent(b.MakeAction(action));
    }
}
public static partial class IonAlertExtensions
{

    /// <summary>
    /// If `true`, the alert will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonAlert
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonAlert
    {
        b.SetProperty(b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the alert will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonAlert
    {
        b.SetProperty(b.Const("backdropDismiss"), b.Const(true));
    }
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> backdropDismiss) where T: IonAlert
    {
        b.SetProperty(b.Const("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// Array of buttons to be added to the alert.
    /// </summary>
    public static void SetButtons<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> buttons) where T: IonAlert
    {
        b.SetProperty(b.Const("buttons"), buttons);
    }

    /// <summary>
    /// Array of buttons to be added to the alert.
    /// </summary>
    public static void SetButtons<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<AlertButton>> buttons) where T: IonAlert
    {
        b.SetProperty(b.Const("buttons"), buttons);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> cssClass) where T: IonAlert
    {
        b.SetProperty(b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> cssClass) where T: IonAlert
    {
        b.SetProperty(b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Animation to use when the alert is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> enterAnimation) where T: IonAlert
    {
        b.SetProperty(b.Const("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// The main title in the heading of the alert.
    /// </summary>
    public static void SetHeader<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> header) where T: IonAlert
    {
        b.SetProperty(b.Const("header"), header);
    }

    /// <summary>
    /// Additional attributes to pass to the alert.
    /// </summary>
    public static void SetHtmlAttributes<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<object> htmlAttributes) where T: IonAlert
    {
        b.SetProperty(b.Const("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// Array of input to show in the alert.
    /// </summary>
    public static void SetInputs<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<AlertInput>> inputs) where T: IonAlert
    {
        b.SetProperty(b.Const("inputs"), inputs);
    }

    /// <summary>
    /// If `true`, the alert will open. If `false`, the alert will close. Use this if you need finer grained control over presentation, otherwise just use the alertController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the alert dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonAlert
    {
        b.SetProperty(b.Const("isOpen"), b.Const(true));
    }
    public static void SetIsOpen<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> isOpen) where T: IonAlert
    {
        b.SetProperty(b.Const("isOpen"), isOpen);
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonAlert
    {
        b.SetProperty(b.Const("keyboardClose"), b.Const(true));
    }
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> keyboardClose) where T: IonAlert
    {
        b.SetProperty(b.Const("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// Animation to use when the alert is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> leaveAnimation) where T: IonAlert
    {
        b.SetProperty(b.Const("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// The main message to be displayed in the alert. `message` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> message) where T: IonAlert
    {
        b.SetProperty(b.Const("message"), message);
    }

    /// <summary>
    /// The main message to be displayed in the alert. `message` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<IonicSafeString> message) where T: IonAlert
    {
        b.SetProperty(b.Const("message"), message);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonAlert
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonAlert
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// The subtitle in the heading of the alert. Displayed under the title.
    /// </summary>
    public static void SetSubHeader<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> subHeader) where T: IonAlert
    {
        b.SetProperty(b.Const("subHeader"), subHeader);
    }

    /// <summary>
    /// If `true`, the alert will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonAlert
    {
        b.SetProperty(b.Const("translucent"), b.Const(true));
    }
    public static void SetTranslucent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonAlert
    {
        b.SetProperty(b.Const("translucent"), translucent);
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the alert to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: IonAlert
    {
        b.SetProperty(b.Const("trigger"), trigger);
    }

    /// <summary>
    /// Dismiss the alert overlay after it has been presented. This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> dismiss(this Metapsi.Syntax.ObjBuilder<IonAlert> b, Metapsi.Syntax.Var<object> data = null, Metapsi.Syntax.Var<string> role = null)
    {
        return b.Call<Promise<bool>>("dismiss", data, role);
    }

    /// <summary>
    /// Returns a promise that resolves when the alert did dismiss.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<OverlayEventDetail>> onDidDismiss<T1>(this Metapsi.Syntax.ObjBuilder<IonAlert> b)
    {
        return b.Call<Promise<OverlayEventDetail>>("onDidDismiss");
    }

    /// <summary>
    /// Returns a promise that resolves when the alert will dismiss.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<OverlayEventDetail>> onWillDismiss<T1>(this Metapsi.Syntax.ObjBuilder<IonAlert> b)
    {
        return b.Call<Promise<OverlayEventDetail>>("onWillDismiss");
    }

    /// <summary>
    /// Present the alert overlay after it has been created.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> present(this Metapsi.Syntax.ObjBuilder<IonAlert> b)
    {
        return b.Call<Promise>("present");
    }
}