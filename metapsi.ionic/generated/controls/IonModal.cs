using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonModal
{

    /// <summary>
    /// If `true`, the modal will animate.
    /// </summary>
    public bool animated { get; set; }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the point after which the backdrop will begin to fade in when using a sheet modal. Prior to this point, the backdrop will be hidden and the content underneath the sheet can be interacted with. This value is exclusive meaning the backdrop will become active after the value specified.
    /// </summary>
    public decimal backdropBreakpoint { get; set; }

    /// <summary>
    /// If `true`, the modal will be dismissed when the backdrop is clicked.
    /// </summary>
    public bool backdropDismiss { get; set; }

    /// <summary>
    /// The breakpoints to use when creating a sheet modal. Each value in the array must be a decimal between 0 and 1 where 0 indicates the modal is fully closed and 1 indicates the modal is fully open. Values are relative to the height of the modal, not the height of the screen. One of the values in this array must be the value of the `initialBreakpoint` property. For example: [0, .25, .5, 1]
    /// </summary>
    public System.Collections.Generic.List<decimal> breakpoints { get; set; }

    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public object canDismiss { get; set; }

    /// <summary>
    /// Animation to use when the modal is presented.
    /// </summary>
    public System.Func<object, object, Animation> enterAnimation { get; set; }

    /// <summary>
    /// Controls whether scrolling or dragging within the sheet modal expands it to a larger breakpoint. This only takes effect when `breakpoints` and `initialBreakpoint` are set.  If `true`, scrolling or dragging anywhere in the modal will first expand it to the next breakpoint. Once fully expanded, scrolling will affect the content. If `false`, scrolling will always affect the content. The modal will only expand when dragging the header or handle. The modal will close when dragging the header or handle. It can also be closed when dragging the content, but only if the content is scrolled to the top.
    /// </summary>
    public bool expandToScroll { get; set; }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public bool focusTrap { get; set; }

    /// <summary>
    /// The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties.
    /// </summary>
    public bool handle { get; set; }

    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public string handleBehavior { get; set; }

    /// <summary>
    /// Additional attributes to pass to the modal.
    /// </summary>
    public object htmlAttributes { get; set; }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array.
    /// </summary>
    public decimal initialBreakpoint { get; set; }

    /// <summary>
    /// If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code.
    /// </summary>
    public bool isOpen { get; set; }

    /// <summary>
    /// If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public bool keepContentsMounted { get; set; }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public bool keyboardClose { get; set; }

    /// <summary>
    /// Animation to use when the modal is dismissed.
    /// </summary>
    public System.Func<object, object, Animation> leaveAnimation { get; set; }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode { get; set; }

    /// <summary>
    /// The element that presented the modal. This is used for card presentation effects and for stacking multiple modals on top of each other. Only applies in iOS mode.
    /// </summary>
    public HTMLElement presentingElement { get; set; }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public bool showBackdrop { get; set; }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the modal to open when clicked.
    /// </summary>
    public string trigger { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Dismiss the modal overlay after it has been presented. This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonModal> instead")]
        public const string Dismiss = "dismiss";
        /// <summary>
        /// Returns the current breakpoint of a sheet style modal
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonModal> instead")]
        public const string GetCurrentBreakpoint = "getCurrentBreakpoint";
        /// <summary>
        /// Returns a promise that resolves when the modal did dismiss.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonModal> instead")]
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// Returns a promise that resolves when the modal will dismiss.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonModal> instead")]
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// Present the modal overlay after it has been created.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonModal> instead")]
        public const string Present = "present";
        /// <summary>
        /// Move a sheet style modal to a specific breakpoint.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonModal> instead")]
        public const string SetCurrentBreakpoint = "setCurrentBreakpoint";
    }
}
public static partial class IonModalControl
{
    /// <summary>
    /// Builds a "ion-modal" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonModal(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonModal>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-modal", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-modal" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonModal(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-modal", children);
    }

    /// <summary>
    /// Builds a "ion-modal" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonModal(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonModal>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-modal", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-modal" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonModal(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-modal", children);
    }

    /// <summary>
    /// If `true`, the modal will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonModal> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the modal will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the point after which the backdrop will begin to fade in when using a sheet modal. Prior to this point, the backdrop will be hidden and the content underneath the sheet can be interacted with. This value is exclusive meaning the backdrop will become active after the value specified.
    /// </summary>
    public static void SetBackdropBreakpoint(this Metapsi.Html.AttributesBuilder<IonModal> b, string backdropBreakpoint)
    {
        b.SetAttribute("backdrop-breakpoint", backdropBreakpoint);
    }

    /// <summary>
    /// If `true`, the modal will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonModal> b, bool backdropDismiss)
    {
        if (backdropDismiss) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// If `true`, the modal will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss(this Metapsi.Html.AttributesBuilder<IonModal> b, bool canDismiss)
    {
        if (canDismiss) b.SetAttribute("can-dismiss", "");
    }

    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss(this Metapsi.Html.AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("can-dismiss", "");
    }

    /// <summary>
    /// Controls whether scrolling or dragging within the sheet modal expands it to a larger breakpoint. This only takes effect when `breakpoints` and `initialBreakpoint` are set.  If `true`, scrolling or dragging anywhere in the modal will first expand it to the next breakpoint. Once fully expanded, scrolling will affect the content. If `false`, scrolling will always affect the content. The modal will only expand when dragging the header or handle. The modal will close when dragging the header or handle. It can also be closed when dragging the content, but only if the content is scrolled to the top.
    /// </summary>
    public static void SetExpandToScroll(this Metapsi.Html.AttributesBuilder<IonModal> b, bool expandToScroll)
    {
        if (expandToScroll) b.SetAttribute("expand-to-scroll", "");
    }

    /// <summary>
    /// Controls whether scrolling or dragging within the sheet modal expands it to a larger breakpoint. This only takes effect when `breakpoints` and `initialBreakpoint` are set.  If `true`, scrolling or dragging anywhere in the modal will first expand it to the next breakpoint. Once fully expanded, scrolling will affect the content. If `false`, scrolling will always affect the content. The modal will only expand when dragging the header or handle. The modal will close when dragging the header or handle. It can also be closed when dragging the content, but only if the content is scrolled to the top.
    /// </summary>
    public static void SetExpandToScroll(this Metapsi.Html.AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("expand-to-scroll", "");
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap(this Metapsi.Html.AttributesBuilder<IonModal> b, bool focusTrap)
    {
        if (focusTrap) b.SetAttribute("focus-trap", "");
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap(this Metapsi.Html.AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("focus-trap", "");
    }

    /// <summary>
    /// The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties.
    /// </summary>
    public static void SetHandle(this Metapsi.Html.AttributesBuilder<IonModal> b, bool handle)
    {
        if (handle) b.SetAttribute("handle", "");
    }

    /// <summary>
    /// The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties.
    /// </summary>
    public static void SetHandle(this Metapsi.Html.AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("handle", "");
    }

    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorNone(this Metapsi.Html.AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("handle-behavior", "none");
    }

    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorCycle(this Metapsi.Html.AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("handle-behavior", "cycle");
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array.
    /// </summary>
    public static void SetInitialBreakpoint(this Metapsi.Html.AttributesBuilder<IonModal> b, string initialBreakpoint)
    {
        b.SetAttribute("initial-breakpoint", initialBreakpoint);
    }

    /// <summary>
    /// If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonModal> b, bool isOpen)
    {
        if (isOpen) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted(this Metapsi.Html.AttributesBuilder<IonModal> b, bool keepContentsMounted)
    {
        if (keepContentsMounted) b.SetAttribute("keep-contents-mounted", "");
    }

    /// <summary>
    /// If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted(this Metapsi.Html.AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("keep-contents-mounted", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonModal> b, bool keyboardClose)
    {
        if (keyboardClose) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop(this Metapsi.Html.AttributesBuilder<IonModal> b, bool showBackdrop)
    {
        if (showBackdrop) b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop(this Metapsi.Html.AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the modal to open when clicked.
    /// </summary>
    public static void SetTrigger(this Metapsi.Html.AttributesBuilder<IonModal> b, string trigger)
    {
        b.SetAttribute("trigger", trigger);
    }
    /// <summary>
    /// Builds a virtual "ion-modal" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonModal(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonModal>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-modal", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-modal" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonModal(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-modal", children);
    }

    /// <summary>
    /// Builds a virtual "ion-modal" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonModal(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonModal>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-modal", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-modal" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonModal(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-modal", children);
    }

    /// <summary>
    /// If `true`, the modal will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonModal
    {
        b.SetProperty(b.Const("animated"), animated);
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the point after which the backdrop will begin to fade in when using a sheet modal. Prior to this point, the backdrop will be hidden and the content underneath the sheet can be interacted with. This value is exclusive meaning the backdrop will become active after the value specified.
    /// </summary>
    public static void SetBackdropBreakpoint<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> backdropBreakpoint) where T: IonModal
    {
        b.SetProperty(b.Const("backdropBreakpoint"), backdropBreakpoint);
    }

    /// <summary>
    /// If `true`, the modal will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("backdropDismiss"), b.Const(true));
    }
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> backdropDismiss) where T: IonModal
    {
        b.SetProperty(b.Const("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// The breakpoints to use when creating a sheet modal. Each value in the array must be a decimal between 0 and 1 where 0 indicates the modal is fully closed and 1 indicates the modal is fully open. Values are relative to the height of the modal, not the height of the screen. One of the values in this array must be the value of the `initialBreakpoint` property. For example: [0, .25, .5, 1]
    /// </summary>
    public static void SetBreakpoints<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<decimal>> breakpoints) where T: IonModal
    {
        b.SetProperty(b.Const("breakpoints"), breakpoints);
    }

    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("canDismiss"), b.Const(true));
    }
    public static void SetCanDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> canDismiss) where T: IonModal
    {
        b.SetProperty(b.Const("canDismiss"), canDismiss);
    }

    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, string, Promise<bool>>> canDismiss) where T: IonModal
    {
        b.SetProperty(b.Const("canDismiss"), canDismiss);
    }

    /// <summary>
    /// Animation to use when the modal is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> enterAnimation) where T: IonModal
    {
        b.SetProperty(b.Const("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// Controls whether scrolling or dragging within the sheet modal expands it to a larger breakpoint. This only takes effect when `breakpoints` and `initialBreakpoint` are set.  If `true`, scrolling or dragging anywhere in the modal will first expand it to the next breakpoint. Once fully expanded, scrolling will affect the content. If `false`, scrolling will always affect the content. The modal will only expand when dragging the header or handle. The modal will close when dragging the header or handle. It can also be closed when dragging the content, but only if the content is scrolled to the top.
    /// </summary>
    public static void SetExpandToScroll<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("expandToScroll"), b.Const(true));
    }
    public static void SetExpandToScroll<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> expandToScroll) where T: IonModal
    {
        b.SetProperty(b.Const("expandToScroll"), expandToScroll);
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("focusTrap"), b.Const(true));
    }
    public static void SetFocusTrap<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> focusTrap) where T: IonModal
    {
        b.SetProperty(b.Const("focusTrap"), focusTrap);
    }

    /// <summary>
    /// The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties.
    /// </summary>
    public static void SetHandle<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("handle"), b.Const(true));
    }
    public static void SetHandle<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> handle) where T: IonModal
    {
        b.SetProperty(b.Const("handle"), handle);
    }

    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("handleBehavior"), b.Const("none"));
    }

    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorCycle<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("handleBehavior"), b.Const("cycle"));
    }

    /// <summary>
    /// Additional attributes to pass to the modal.
    /// </summary>
    public static void SetHtmlAttributes<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<object> htmlAttributes) where T: IonModal
    {
        b.SetProperty(b.Const("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array.
    /// </summary>
    public static void SetInitialBreakpoint<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> initialBreakpoint) where T: IonModal
    {
        b.SetProperty(b.Const("initialBreakpoint"), initialBreakpoint);
    }

    /// <summary>
    /// If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("isOpen"), b.Const(true));
    }
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> isOpen) where T: IonModal
    {
        b.SetProperty(b.Const("isOpen"), isOpen);
    }

    /// <summary>
    /// If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("keepContentsMounted"), b.Const(true));
    }
    public static void SetKeepContentsMounted<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> keepContentsMounted) where T: IonModal
    {
        b.SetProperty(b.Const("keepContentsMounted"), keepContentsMounted);
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("keyboardClose"), b.Const(true));
    }
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> keyboardClose) where T: IonModal
    {
        b.SetProperty(b.Const("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// Animation to use when the modal is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> leaveAnimation) where T: IonModal
    {
        b.SetProperty(b.Const("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// The element that presented the modal. This is used for card presentation effects and for stacking multiple modals on top of each other. Only applies in iOS mode.
    /// </summary>
    public static void SetPresentingElement<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<HTMLElement> presentingElement) where T: IonModal
    {
        b.SetProperty(b.Const("presentingElement"), presentingElement);
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("showBackdrop"), b.Const(true));
    }
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> showBackdrop) where T: IonModal
    {
        b.SetProperty(b.Const("showBackdrop"), showBackdrop);
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the modal to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: IonModal
    {
        b.SetProperty(b.Const("trigger"), trigger);
    }

    /// <summary>
    /// Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonModal
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the modal has presented. Shorthand for ionModalDidPresent.
    /// </summary>
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Const("ondidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the modal has presented. Shorthand for ionModalDidPresent.
    /// </summary>
    [System.Obsolete]
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal has presented. Shorthand for ionModalDidPresent.
    /// </summary>
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Const("ondidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the modal has presented. Shorthand for ionModalDidPresent.
    /// </summary>
    [System.Obsolete]
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal breakpoint has changed.
    /// </summary>
    public static void OnIonBreakpointDidChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionBreakpointDidChange"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the modal breakpoint has changed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonBreakpointDidChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonBreakpointDidChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal breakpoint has changed.
    /// </summary>
    public static void OnIonBreakpointDidChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionBreakpointDidChange"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the modal breakpoint has changed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonBreakpointDidChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonBreakpointDidChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal breakpoint has changed.
    /// </summary>
    public static void OnIonBreakpointDidChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<ModalBreakpointChangeEventDetail>>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionBreakpointDidChange"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the sheet modal or card modal gesture ends.
    /// </summary>
    public static void OnIonDragEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionDragEnd"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the sheet modal or card modal gesture ends.
    /// </summary>
    [System.Obsolete]
    public static void OnIonDragEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonDragEnd(b.MakeAction(action));
    }

    /// <summary>
    /// Event that is emitted when the sheet modal or card modal gesture ends.
    /// </summary>
    public static void OnIonDragEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionDragEnd"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the sheet modal or card modal gesture ends.
    /// </summary>
    [System.Obsolete]
    public static void OnIonDragEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonDragEnd(b.MakeAction(action));
    }

    /// <summary>
    /// Event that is emitted when the sheet modal or card modal gesture ends.
    /// </summary>
    public static void OnIonDragEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<ModalDragEventDetail>>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionDragEnd"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the sheet modal or card modal gesture moves.
    /// </summary>
    public static void OnIonDragMove<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionDragMove"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the sheet modal or card modal gesture moves.
    /// </summary>
    [System.Obsolete]
    public static void OnIonDragMove<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonDragMove(b.MakeAction(action));
    }

    /// <summary>
    /// Event that is emitted when the sheet modal or card modal gesture moves.
    /// </summary>
    public static void OnIonDragMove<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionDragMove"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the sheet modal or card modal gesture moves.
    /// </summary>
    [System.Obsolete]
    public static void OnIonDragMove<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonDragMove(b.MakeAction(action));
    }

    /// <summary>
    /// Event that is emitted when the sheet modal or card modal gesture moves.
    /// </summary>
    public static void OnIonDragMove<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<ModalDragEventDetail>>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionDragMove"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the sheet modal or card modal gesture starts.
    /// </summary>
    public static void OnIonDragStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionDragStart"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the sheet modal or card modal gesture starts.
    /// </summary>
    [System.Obsolete]
    public static void OnIonDragStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonDragStart(b.MakeAction(action));
    }

    /// <summary>
    /// Event that is emitted when the sheet modal or card modal gesture starts.
    /// </summary>
    public static void OnIonDragStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionDragStart"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the sheet modal or card modal gesture starts.
    /// </summary>
    [System.Obsolete]
    public static void OnIonDragStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonDragStart(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal has dismissed.
    /// </summary>
    public static void OnIonModalDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionModalDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the modal has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonModalDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal has dismissed.
    /// </summary>
    public static void OnIonModalDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionModalDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the modal has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonModalDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal has dismissed.
    /// </summary>
    public static void OnIonModalDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionModalDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the modal has presented.
    /// </summary>
    public static void OnIonModalDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionModalDidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the modal has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonModalDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal has presented.
    /// </summary>
    public static void OnIonModalDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionModalDidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the modal has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonModalDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed.
    /// </summary>
    public static void OnIonModalWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionModalWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonModalWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed.
    /// </summary>
    public static void OnIonModalWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionModalWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonModalWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed.
    /// </summary>
    public static void OnIonModalWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionModalWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the modal has presented.
    /// </summary>
    public static void OnIonModalWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionModalWillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the modal has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonModalWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has presented.
    /// </summary>
    public static void OnIonModalWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onionModalWillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the modal has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonModalWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the modal has presented. Shorthand for ionModalWillPresent.
    /// </summary>
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onwillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the modal has presented. Shorthand for ionModalWillPresent.
    /// </summary>
    [System.Obsolete]
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has presented. Shorthand for ionModalWillPresent.
    /// </summary>
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Const("onwillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the modal has presented. Shorthand for ionModalWillPresent.
    /// </summary>
    [System.Obsolete]
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnWillPresent(b.MakeAction(action));
    }
}
public static partial class IonModalExtensions
{

    /// <summary>
    /// If `true`, the modal will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonModal
    {
        b.SetProperty(b.Const("animated"), animated);
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the point after which the backdrop will begin to fade in when using a sheet modal. Prior to this point, the backdrop will be hidden and the content underneath the sheet can be interacted with. This value is exclusive meaning the backdrop will become active after the value specified.
    /// </summary>
    public static void SetBackdropBreakpoint<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<decimal> backdropBreakpoint) where T: IonModal
    {
        b.SetProperty(b.Const("backdropBreakpoint"), backdropBreakpoint);
    }

    /// <summary>
    /// If `true`, the modal will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("backdropDismiss"), b.Const(true));
    }
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> backdropDismiss) where T: IonModal
    {
        b.SetProperty(b.Const("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// The breakpoints to use when creating a sheet modal. Each value in the array must be a decimal between 0 and 1 where 0 indicates the modal is fully closed and 1 indicates the modal is fully open. Values are relative to the height of the modal, not the height of the screen. One of the values in this array must be the value of the `initialBreakpoint` property. For example: [0, .25, .5, 1]
    /// </summary>
    public static void SetBreakpoints<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<decimal>> breakpoints) where T: IonModal
    {
        b.SetProperty(b.Const("breakpoints"), breakpoints);
    }

    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("canDismiss"), b.Const(true));
    }
    public static void SetCanDismiss<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> canDismiss) where T: IonModal
    {
        b.SetProperty(b.Const("canDismiss"), canDismiss);
    }

    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, string, Promise<bool>>> canDismiss) where T: IonModal
    {
        b.SetProperty(b.Const("canDismiss"), canDismiss);
    }

    /// <summary>
    /// Animation to use when the modal is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> enterAnimation) where T: IonModal
    {
        b.SetProperty(b.Const("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// Controls whether scrolling or dragging within the sheet modal expands it to a larger breakpoint. This only takes effect when `breakpoints` and `initialBreakpoint` are set.  If `true`, scrolling or dragging anywhere in the modal will first expand it to the next breakpoint. Once fully expanded, scrolling will affect the content. If `false`, scrolling will always affect the content. The modal will only expand when dragging the header or handle. The modal will close when dragging the header or handle. It can also be closed when dragging the content, but only if the content is scrolled to the top.
    /// </summary>
    public static void SetExpandToScroll<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("expandToScroll"), b.Const(true));
    }
    public static void SetExpandToScroll<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> expandToScroll) where T: IonModal
    {
        b.SetProperty(b.Const("expandToScroll"), expandToScroll);
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("focusTrap"), b.Const(true));
    }
    public static void SetFocusTrap<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> focusTrap) where T: IonModal
    {
        b.SetProperty(b.Const("focusTrap"), focusTrap);
    }

    /// <summary>
    /// The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties.
    /// </summary>
    public static void SetHandle<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("handle"), b.Const(true));
    }
    public static void SetHandle<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> handle) where T: IonModal
    {
        b.SetProperty(b.Const("handle"), handle);
    }

    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorNone<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("handleBehavior"), b.Const("none"));
    }

    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorCycle<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("handleBehavior"), b.Const("cycle"));
    }

    /// <summary>
    /// Additional attributes to pass to the modal.
    /// </summary>
    public static void SetHtmlAttributes<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<object> htmlAttributes) where T: IonModal
    {
        b.SetProperty(b.Const("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array.
    /// </summary>
    public static void SetInitialBreakpoint<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<decimal> initialBreakpoint) where T: IonModal
    {
        b.SetProperty(b.Const("initialBreakpoint"), initialBreakpoint);
    }

    /// <summary>
    /// If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("isOpen"), b.Const(true));
    }
    public static void SetIsOpen<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> isOpen) where T: IonModal
    {
        b.SetProperty(b.Const("isOpen"), isOpen);
    }

    /// <summary>
    /// If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("keepContentsMounted"), b.Const(true));
    }
    public static void SetKeepContentsMounted<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> keepContentsMounted) where T: IonModal
    {
        b.SetProperty(b.Const("keepContentsMounted"), keepContentsMounted);
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("keyboardClose"), b.Const(true));
    }
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> keyboardClose) where T: IonModal
    {
        b.SetProperty(b.Const("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// Animation to use when the modal is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> leaveAnimation) where T: IonModal
    {
        b.SetProperty(b.Const("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// The element that presented the modal. This is used for card presentation effects and for stacking multiple modals on top of each other. Only applies in iOS mode.
    /// </summary>
    public static void SetPresentingElement<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<HTMLElement> presentingElement) where T: IonModal
    {
        b.SetProperty(b.Const("presentingElement"), presentingElement);
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Const("showBackdrop"), b.Const(true));
    }
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> showBackdrop) where T: IonModal
    {
        b.SetProperty(b.Const("showBackdrop"), showBackdrop);
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the modal to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: IonModal
    {
        b.SetProperty(b.Const("trigger"), trigger);
    }

    /// <summary>
    /// Dismiss the modal overlay after it has been presented. This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> dismiss(this Metapsi.Syntax.ObjBuilder<IonModal> b, Metapsi.Syntax.Var<object> data = null, Metapsi.Syntax.Var<string> role = null)
    {
        return b.Call<Promise<bool>>("dismiss", data, role);
    }

    /// <summary>
    /// Returns the current breakpoint of a sheet style modal
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<decimal>> getCurrentBreakpoint(this Metapsi.Syntax.ObjBuilder<IonModal> b)
    {
        return b.Call<Promise<decimal>>("getCurrentBreakpoint");
    }

    /// <summary>
    /// Returns a promise that resolves when the modal did dismiss.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<OverlayEventDetail>> onDidDismiss<T1>(this Metapsi.Syntax.ObjBuilder<IonModal> b)
    {
        return b.Call<Promise<OverlayEventDetail>>("onDidDismiss");
    }

    /// <summary>
    /// Returns a promise that resolves when the modal will dismiss.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<OverlayEventDetail>> onWillDismiss<T1>(this Metapsi.Syntax.ObjBuilder<IonModal> b)
    {
        return b.Call<Promise<OverlayEventDetail>>("onWillDismiss");
    }

    /// <summary>
    /// Present the modal overlay after it has been created.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> present(this Metapsi.Syntax.ObjBuilder<IonModal> b)
    {
        return b.Call<Promise>("present");
    }

    /// <summary>
    /// Move a sheet style modal to a specific breakpoint.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> setCurrentBreakpoint(this Metapsi.Syntax.ObjBuilder<IonModal> b, Metapsi.Syntax.Var<decimal> breakpoint)
    {
        return b.Call<Promise>("setCurrentBreakpoint", breakpoint);
    }
}