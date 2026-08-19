using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonActionSheet
{

    /// <summary>
    /// If `true`, the action sheet will animate.
    /// </summary>
    public bool animated { get; set; }

    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public bool backdropDismiss { get; set; }

    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public System.Collections.Generic.List<string> buttons { get; set; }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public object cssClass { get; set; }

    /// <summary>
    /// Animation to use when the action sheet is presented.
    /// </summary>
    public System.Func<object, object, Animation> enterAnimation { get; set; }

    /// <summary>
    /// Title for the action sheet.
    /// </summary>
    public string header { get; set; }

    /// <summary>
    /// Additional attributes to pass to the action sheet.
    /// </summary>
    public object htmlAttributes { get; set; }

    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public bool isOpen { get; set; }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public bool keyboardClose { get; set; }

    /// <summary>
    /// Animation to use when the action sheet is dismissed.
    /// </summary>
    public System.Func<object, object, Animation> leaveAnimation { get; set; }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode { get; set; }

    /// <summary>
    /// Subtitle for the action sheet.
    /// </summary>
    public string subHeader { get; set; }

    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public bool translucent { get; set; }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the action sheet to open when clicked.
    /// </summary>
    public string trigger { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Dismiss the action sheet overlay after it has been presented. This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonActionSheet> instead")]
        public const string Dismiss = "dismiss";
        /// <summary>
        /// Returns a promise that resolves when the action sheet did dismiss.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonActionSheet> instead")]
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// Returns a promise that resolves when the action sheet will dismiss.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonActionSheet> instead")]
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// Present the action sheet overlay after it has been created.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonActionSheet> instead")]
        public const string Present = "present";
    }
}
public static partial class IonActionSheetControl
{
    /// <summary>
    /// Builds a "ion-action-sheet" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonActionSheet(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonActionSheet>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-action-sheet", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-action-sheet" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonActionSheet(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-action-sheet", children);
    }

    /// <summary>
    /// Builds a "ion-action-sheet" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonActionSheet(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonActionSheet>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-action-sheet", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-action-sheet" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonActionSheet(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-action-sheet", children);
    }

    /// <summary>
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, bool backdropDismiss)
    {
        if (backdropDismiss) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, string cssClass)
    {
        b.SetAttribute("css-class", cssClass);
    }

    /// <summary>
    /// Title for the action sheet.
    /// </summary>
    public static void SetHeader(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, string header)
    {
        b.SetAttribute("header", header);
    }

    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, bool isOpen)
    {
        if (isOpen) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, bool keyboardClose)
    {
        if (keyboardClose) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Subtitle for the action sheet.
    /// </summary>
    public static void SetSubHeader(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, string subHeader)
    {
        b.SetAttribute("sub-header", subHeader);
    }

    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, bool translucent)
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the action sheet to open when clicked.
    /// </summary>
    public static void SetTrigger(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, string trigger)
    {
        b.SetAttribute("trigger", trigger);
    }
    /// <summary>
    /// Builds a virtual "ion-action-sheet" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonActionSheet(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonActionSheet>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-action-sheet", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-action-sheet" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonActionSheet(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-action-sheet", children);
    }

    /// <summary>
    /// Builds a virtual "ion-action-sheet" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonActionSheet(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonActionSheet>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-action-sheet", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-action-sheet" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonActionSheet(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-action-sheet", children);
    }

    /// <summary>
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonActionSheet
    {
        b.SetProperty(b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Const("backdropDismiss"), b.Const(true));
    }
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> backdropDismiss) where T: IonActionSheet
    {
        b.SetProperty(b.Const("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public static void SetButtons<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> buttons) where T: IonActionSheet
    {
        b.SetProperty(b.Const("buttons"), buttons);
    }

    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public static void SetButtons<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<ActionSheetButton>> buttons) where T: IonActionSheet
    {
        b.SetProperty(b.Const("buttons"), buttons);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> cssClass) where T: IonActionSheet
    {
        b.SetProperty(b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> cssClass) where T: IonActionSheet
    {
        b.SetProperty(b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Animation to use when the action sheet is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> enterAnimation) where T: IonActionSheet
    {
        b.SetProperty(b.Const("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// Title for the action sheet.
    /// </summary>
    public static void SetHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> header) where T: IonActionSheet
    {
        b.SetProperty(b.Const("header"), header);
    }

    /// <summary>
    /// Additional attributes to pass to the action sheet.
    /// </summary>
    public static void SetHtmlAttributes<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<object> htmlAttributes) where T: IonActionSheet
    {
        b.SetProperty(b.Const("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Const("isOpen"), b.Const(true));
    }
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> isOpen) where T: IonActionSheet
    {
        b.SetProperty(b.Const("isOpen"), isOpen);
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Const("keyboardClose"), b.Const(true));
    }
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> keyboardClose) where T: IonActionSheet
    {
        b.SetProperty(b.Const("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// Animation to use when the action sheet is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> leaveAnimation) where T: IonActionSheet
    {
        b.SetProperty(b.Const("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Subtitle for the action sheet.
    /// </summary>
    public static void SetSubHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> subHeader) where T: IonActionSheet
    {
        b.SetProperty(b.Const("subHeader"), subHeader);
    }

    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Const("translucent"), b.Const(true));
    }
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonActionSheet
    {
        b.SetProperty(b.Const("translucent"), translucent);
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the action sheet to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: IonActionSheet
    {
        b.SetProperty(b.Const("trigger"), trigger);
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the action sheet has presented. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("ondidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the action sheet has presented. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has presented. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("ondidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the action sheet has presented. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onionActionSheetDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonActionSheetDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onionActionSheetDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonActionSheetDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onionActionSheetDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onionActionSheetDidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the action sheet has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonActionSheetDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onionActionSheetDidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the action sheet has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonActionSheetDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onionActionSheetWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonActionSheetWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onionActionSheetWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonActionSheetWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onionActionSheetWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onionActionSheetWillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the action sheet has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonActionSheetWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onionActionSheetWillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the action sheet has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonActionSheetWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the action sheet has presented. Shorthand for ionActionSheetWillPresent.
    /// </summary>
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onwillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the action sheet has presented. Shorthand for ionActionSheetWillPresent.
    /// </summary>
    [System.Obsolete]
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has presented. Shorthand for ionActionSheetWillPresent.
    /// </summary>
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Const("onwillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the action sheet has presented. Shorthand for ionActionSheetWillPresent.
    /// </summary>
    [System.Obsolete]
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnWillPresent(b.MakeAction(action));
    }
}
public static partial class IonActionSheetExtensions
{

    /// <summary>
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonActionSheet
    {
        b.SetProperty(b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Const("backdropDismiss"), b.Const(true));
    }
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> backdropDismiss) where T: IonActionSheet
    {
        b.SetProperty(b.Const("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public static void SetButtons<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> buttons) where T: IonActionSheet
    {
        b.SetProperty(b.Const("buttons"), buttons);
    }

    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public static void SetButtons<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<ActionSheetButton>> buttons) where T: IonActionSheet
    {
        b.SetProperty(b.Const("buttons"), buttons);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> cssClass) where T: IonActionSheet
    {
        b.SetProperty(b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> cssClass) where T: IonActionSheet
    {
        b.SetProperty(b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Animation to use when the action sheet is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> enterAnimation) where T: IonActionSheet
    {
        b.SetProperty(b.Const("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// Title for the action sheet.
    /// </summary>
    public static void SetHeader<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> header) where T: IonActionSheet
    {
        b.SetProperty(b.Const("header"), header);
    }

    /// <summary>
    /// Additional attributes to pass to the action sheet.
    /// </summary>
    public static void SetHtmlAttributes<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<object> htmlAttributes) where T: IonActionSheet
    {
        b.SetProperty(b.Const("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Const("isOpen"), b.Const(true));
    }
    public static void SetIsOpen<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> isOpen) where T: IonActionSheet
    {
        b.SetProperty(b.Const("isOpen"), isOpen);
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Const("keyboardClose"), b.Const(true));
    }
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> keyboardClose) where T: IonActionSheet
    {
        b.SetProperty(b.Const("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// Animation to use when the action sheet is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> leaveAnimation) where T: IonActionSheet
    {
        b.SetProperty(b.Const("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Subtitle for the action sheet.
    /// </summary>
    public static void SetSubHeader<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> subHeader) where T: IonActionSheet
    {
        b.SetProperty(b.Const("subHeader"), subHeader);
    }

    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Const("translucent"), b.Const(true));
    }
    public static void SetTranslucent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonActionSheet
    {
        b.SetProperty(b.Const("translucent"), translucent);
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the action sheet to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: IonActionSheet
    {
        b.SetProperty(b.Const("trigger"), trigger);
    }

    /// <summary>
    /// Dismiss the action sheet overlay after it has been presented. This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> dismiss(this Metapsi.Syntax.ObjBuilder<IonActionSheet> b, Metapsi.Syntax.Var<object> data = null, Metapsi.Syntax.Var<string> role = null)
    {
        return b.Call<Promise<bool>>("dismiss", data, role);
    }

    /// <summary>
    /// Returns a promise that resolves when the action sheet did dismiss.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<OverlayEventDetail>> onDidDismiss<T1>(this Metapsi.Syntax.ObjBuilder<IonActionSheet> b)
    {
        return b.Call<Promise<OverlayEventDetail>>("onDidDismiss");
    }

    /// <summary>
    /// Returns a promise that resolves when the action sheet will dismiss.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<OverlayEventDetail>> onWillDismiss<T1>(this Metapsi.Syntax.ObjBuilder<IonActionSheet> b)
    {
        return b.Call<Promise<OverlayEventDetail>>("onWillDismiss");
    }

    /// <summary>
    /// Present the action sheet overlay after it has been created.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> present(this Metapsi.Syntax.ObjBuilder<IonActionSheet> b)
    {
        return b.Call<Promise>("present");
    }
}