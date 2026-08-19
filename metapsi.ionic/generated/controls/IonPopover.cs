using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonPopover
{

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public string alignment { get; set; }

    /// <summary>
    /// If `true`, the popover will animate.
    /// </summary>
    public bool animated { get; set; }

    /// <summary>
    /// If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode.
    /// </summary>
    public bool arrow { get; set; }

    /// <summary>
    /// If `true`, the popover will be dismissed when the backdrop is clicked.
    /// </summary>
    public bool backdropDismiss { get; set; }

    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public object component { get; set; }

    /// <summary>
    /// The data to pass to the popover component. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just set the props directly on your component.
    /// </summary>
    public ComponentProps componentProps { get; set; }

    /// <summary>
    /// If `true`, the popover will be automatically dismissed when the content has been clicked.
    /// </summary>
    public bool dismissOnSelect { get; set; }

    /// <summary>
    /// Animation to use when the popover is presented.
    /// </summary>
    public System.Func<object, object, Animation> enterAnimation { get; set; }

    /// <summary>
    /// The event to pass to the popover animation.
    /// </summary>
    public object @event { get; set; }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public bool focusTrap { get; set; }

    /// <summary>
    /// Additional attributes to pass to the popover.
    /// </summary>
    public object htmlAttributes { get; set; }

    /// <summary>
    /// If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code.
    /// </summary>
    public bool isOpen { get; set; }

    /// <summary>
    /// If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public bool keepContentsMounted { get; set; }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public bool keyboardClose { get; set; }

    /// <summary>
    /// Animation to use when the popover is dismissed.
    /// </summary>
    public System.Func<object, object, Animation> leaveAnimation { get; set; }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode { get; set; }

    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public string reference { get; set; }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public bool showBackdrop { get; set; }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public string side { get; set; }

    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public string size { get; set; }

    /// <summary>
    /// If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public bool translucent { get; set; }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening.
    /// </summary>
    public string trigger { get; set; }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public string triggerAction { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Dismiss the popover overlay after it has been presented. This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonPopover> instead")]
        public const string Dismiss = "dismiss";
        /// <summary>
        /// Returns a promise that resolves when the popover did dismiss.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonPopover> instead")]
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// Returns a promise that resolves when the popover will dismiss.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonPopover> instead")]
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// Present the popover overlay after it has been created. Developers can pass a mouse, touch, or pointer event to position the popover relative to where that event was dispatched.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonPopover> instead")]
        public const string Present = "present";
    }
}
public static partial class IonPopoverControl
{
    /// <summary>
    /// Builds a "ion-popover" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonPopover(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonPopover>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-popover", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-popover" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonPopover(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-popover", children);
    }

    /// <summary>
    /// Builds a "ion-popover" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonPopover(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonPopover>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-popover", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-popover" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonPopover(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-popover", children);
    }

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentStart(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("alignment", "start");
    }

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentEnd(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("alignment", "end");
    }

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentCenter(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("alignment", "center");
    }

    /// <summary>
    /// If `true`, the popover will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the popover will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode.
    /// </summary>
    public static void SetArrow(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool arrow)
    {
        if (arrow) b.SetAttribute("arrow", "");
    }

    /// <summary>
    /// If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode.
    /// </summary>
    public static void SetArrow(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("arrow", "");
    }

    /// <summary>
    /// If `true`, the popover will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool backdropDismiss)
    {
        if (backdropDismiss) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// If `true`, the popover will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent(this Metapsi.Html.AttributesBuilder<IonPopover> b, string component)
    {
        b.SetAttribute("component", component);
    }

    /// <summary>
    /// If `true`, the popover will be automatically dismissed when the content has been clicked.
    /// </summary>
    public static void SetDismissOnSelect(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool dismissOnSelect)
    {
        if (dismissOnSelect) b.SetAttribute("dismiss-on-select", "");
    }

    /// <summary>
    /// If `true`, the popover will be automatically dismissed when the content has been clicked.
    /// </summary>
    public static void SetDismissOnSelect(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("dismiss-on-select", "");
    }

    /// <summary>
    /// The event to pass to the popover animation.
    /// </summary>
    public static void SetEvent(this Metapsi.Html.AttributesBuilder<IonPopover> b, string @event)
    {
        b.SetAttribute("event", @event);
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool focusTrap)
    {
        if (focusTrap) b.SetAttribute("focus-trap", "");
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("focus-trap", "");
    }

    /// <summary>
    /// If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool isOpen)
    {
        if (isOpen) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool keepContentsMounted)
    {
        if (keepContentsMounted) b.SetAttribute("keep-contents-mounted", "");
    }

    /// <summary>
    /// If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("keep-contents-mounted", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool keyboardClose)
    {
        if (keyboardClose) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceTrigger(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("reference", "trigger");
    }

    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceEvent(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("reference", "event");
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool showBackdrop)
    {
        if (showBackdrop) b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideStart(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "start");
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideEnd(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "end");
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideTop(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "top");
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideBottom(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "bottom");
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideRight(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "right");
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideLeft(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "left");
    }

    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeCover(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("size", "cover");
    }

    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeAuto(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("size", "auto");
    }

    /// <summary>
    /// If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool translucent)
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening.
    /// </summary>
    public static void SetTrigger(this Metapsi.Html.AttributesBuilder<IonPopover> b, string trigger)
    {
        b.SetAttribute("trigger", trigger);
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionClick(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("trigger-action", "click");
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionHover(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("trigger-action", "hover");
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionContextMenu(this Metapsi.Html.AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("trigger-action", "context-menu");
    }
    /// <summary>
    /// Builds a virtual "ion-popover" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonPopover(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonPopover>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-popover", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-popover" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonPopover(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-popover", children);
    }

    /// <summary>
    /// Builds a virtual "ion-popover" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonPopover(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonPopover>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-popover", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-popover" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonPopover(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-popover", children);
    }

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("alignment"), b.Const("start"));
    }

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("alignment"), b.Const("end"));
    }

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentCenter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("alignment"), b.Const("center"));
    }

    /// <summary>
    /// If `true`, the popover will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonPopover
    {
        b.SetProperty(b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode.
    /// </summary>
    public static void SetArrow<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("arrow"), b.Const(true));
    }
    public static void SetArrow<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> arrow) where T: IonPopover
    {
        b.SetProperty(b.Const("arrow"), arrow);
    }

    /// <summary>
    /// If `true`, the popover will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("backdropDismiss"), b.Const(true));
    }
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> backdropDismiss) where T: IonPopover
    {
        b.SetProperty(b.Const("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> component) where T: IonPopover
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Function> component) where T: IonPopover
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<HTMLElement> component) where T: IonPopover
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// The data to pass to the popover component. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just set the props directly on your component.
    /// </summary>
    public static void SetComponentProps<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<ComponentProps> componentProps) where T: IonPopover
    {
        b.SetProperty(b.Const("componentProps"), componentProps);
    }

    /// <summary>
    /// If `true`, the popover will be automatically dismissed when the content has been clicked.
    /// </summary>
    public static void SetDismissOnSelect<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("dismissOnSelect"), b.Const(true));
    }
    public static void SetDismissOnSelect<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> dismissOnSelect) where T: IonPopover
    {
        b.SetProperty(b.Const("dismissOnSelect"), dismissOnSelect);
    }

    /// <summary>
    /// Animation to use when the popover is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> enterAnimation) where T: IonPopover
    {
        b.SetProperty(b.Const("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// The event to pass to the popover animation.
    /// </summary>
    public static void SetEvent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<object> @event) where T: IonPopover
    {
        b.SetProperty(b.Const("event"), @event);
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("focusTrap"), b.Const(true));
    }
    public static void SetFocusTrap<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> focusTrap) where T: IonPopover
    {
        b.SetProperty(b.Const("focusTrap"), focusTrap);
    }

    /// <summary>
    /// Additional attributes to pass to the popover.
    /// </summary>
    public static void SetHtmlAttributes<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<object> htmlAttributes) where T: IonPopover
    {
        b.SetProperty(b.Const("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("isOpen"), b.Const(true));
    }
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> isOpen) where T: IonPopover
    {
        b.SetProperty(b.Const("isOpen"), isOpen);
    }

    /// <summary>
    /// If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("keepContentsMounted"), b.Const(true));
    }
    public static void SetKeepContentsMounted<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> keepContentsMounted) where T: IonPopover
    {
        b.SetProperty(b.Const("keepContentsMounted"), keepContentsMounted);
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("keyboardClose"), b.Const(true));
    }
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> keyboardClose) where T: IonPopover
    {
        b.SetProperty(b.Const("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// Animation to use when the popover is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> leaveAnimation) where T: IonPopover
    {
        b.SetProperty(b.Const("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("reference"), b.Const("trigger"));
    }

    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceEvent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("reference"), b.Const("event"));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("showBackdrop"), b.Const(true));
    }
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> showBackdrop) where T: IonPopover
    {
        b.SetProperty(b.Const("showBackdrop"), showBackdrop);
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("side"), b.Const("start"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("side"), b.Const("end"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("side"), b.Const("top"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("side"), b.Const("bottom"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideRight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("side"), b.Const("right"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideLeft<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("side"), b.Const("left"));
    }

    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeCover<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("size"), b.Const("cover"));
    }

    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeAuto<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("size"), b.Const("auto"));
    }

    /// <summary>
    /// If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("translucent"), b.Const(true));
    }
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonPopover
    {
        b.SetProperty(b.Const("translucent"), translucent);
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: IonPopover
    {
        b.SetProperty(b.Const("trigger"), trigger);
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionClick<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("triggerAction"), b.Const("click"));
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionHover<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("triggerAction"), b.Const("hover"));
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionContextMenu<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("triggerAction"), b.Const("context-menu"));
    }

    /// <summary>
    /// Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("ondidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the popover has presented. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("ondidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the popover has presented. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has presented. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("ondidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the popover has presented. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onionPopoverDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonPopoverDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onionPopoverDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonPopoverDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverDidDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onionPopoverDidDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the popover has presented.
    /// </summary>
    public static void OnIonPopoverDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onionPopoverDidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the popover has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonPopoverDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has presented.
    /// </summary>
    public static void OnIonPopoverDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onionPopoverDidPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted after the popover has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonPopoverDidPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onionPopoverWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonPopoverWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onionPopoverWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed.
    /// </summary>
    [System.Obsolete]
    public static void OnIonPopoverWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onionPopoverWillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the popover has presented.
    /// </summary>
    public static void OnIonPopoverWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onionPopoverWillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the popover has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonPopoverWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has presented.
    /// </summary>
    public static void OnIonPopoverWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onionPopoverWillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the popover has presented.
    /// </summary>
    [System.Obsolete]
    public static void OnIonPopoverWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    [System.Obsolete]
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<OverlayEventDetail>>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onwillDismiss"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the popover has presented. Shorthand for ionPopoverWillPresent.
    /// </summary>
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onwillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the popover has presented. Shorthand for ionPopoverWillPresent.
    /// </summary>
    [System.Obsolete]
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has presented. Shorthand for ionPopoverWillPresent.
    /// </summary>
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Const("onwillPresent"), b.Const(action));
    }

    /// <summary>
    /// Emitted before the popover has presented. Shorthand for ionPopoverWillPresent.
    /// </summary>
    [System.Obsolete]
    public static void OnWillPresent<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnWillPresent(b.MakeAction(action));
    }
}
public static partial class IonPopoverExtensions
{

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentStart<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("alignment"), b.Const("start"));
    }

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentEnd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("alignment"), b.Const("end"));
    }

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentCenter<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("alignment"), b.Const("center"));
    }

    /// <summary>
    /// If `true`, the popover will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("animated"), b.Const(true));
    }
    public static void SetAnimated<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonPopover
    {
        b.SetProperty(b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode.
    /// </summary>
    public static void SetArrow<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("arrow"), b.Const(true));
    }
    public static void SetArrow<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> arrow) where T: IonPopover
    {
        b.SetProperty(b.Const("arrow"), arrow);
    }

    /// <summary>
    /// If `true`, the popover will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("backdropDismiss"), b.Const(true));
    }
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> backdropDismiss) where T: IonPopover
    {
        b.SetProperty(b.Const("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> component) where T: IonPopover
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<Function> component) where T: IonPopover
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<HTMLElement> component) where T: IonPopover
    {
        b.SetProperty(b.Const("component"), component);
    }

    /// <summary>
    /// The data to pass to the popover component. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just set the props directly on your component.
    /// </summary>
    public static void SetComponentProps<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<ComponentProps> componentProps) where T: IonPopover
    {
        b.SetProperty(b.Const("componentProps"), componentProps);
    }

    /// <summary>
    /// If `true`, the popover will be automatically dismissed when the content has been clicked.
    /// </summary>
    public static void SetDismissOnSelect<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("dismissOnSelect"), b.Const(true));
    }
    public static void SetDismissOnSelect<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> dismissOnSelect) where T: IonPopover
    {
        b.SetProperty(b.Const("dismissOnSelect"), dismissOnSelect);
    }

    /// <summary>
    /// Animation to use when the popover is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> enterAnimation) where T: IonPopover
    {
        b.SetProperty(b.Const("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// The event to pass to the popover animation.
    /// </summary>
    public static void SetEvent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<object> @event) where T: IonPopover
    {
        b.SetProperty(b.Const("event"), @event);
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("focusTrap"), b.Const(true));
    }
    public static void SetFocusTrap<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> focusTrap) where T: IonPopover
    {
        b.SetProperty(b.Const("focusTrap"), focusTrap);
    }

    /// <summary>
    /// Additional attributes to pass to the popover.
    /// </summary>
    public static void SetHtmlAttributes<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<object> htmlAttributes) where T: IonPopover
    {
        b.SetProperty(b.Const("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("isOpen"), b.Const(true));
    }
    public static void SetIsOpen<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> isOpen) where T: IonPopover
    {
        b.SetProperty(b.Const("isOpen"), isOpen);
    }

    /// <summary>
    /// If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("keepContentsMounted"), b.Const(true));
    }
    public static void SetKeepContentsMounted<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> keepContentsMounted) where T: IonPopover
    {
        b.SetProperty(b.Const("keepContentsMounted"), keepContentsMounted);
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("keyboardClose"), b.Const(true));
    }
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> keyboardClose) where T: IonPopover
    {
        b.SetProperty(b.Const("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// Animation to use when the popover is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> leaveAnimation) where T: IonPopover
    {
        b.SetProperty(b.Const("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceTrigger<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("reference"), b.Const("trigger"));
    }

    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceEvent<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("reference"), b.Const("event"));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("showBackdrop"), b.Const(true));
    }
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> showBackdrop) where T: IonPopover
    {
        b.SetProperty(b.Const("showBackdrop"), showBackdrop);
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideStart<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("side"), b.Const("start"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideEnd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("side"), b.Const("end"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideTop<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("side"), b.Const("top"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideBottom<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("side"), b.Const("bottom"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideRight<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("side"), b.Const("right"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideLeft<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("side"), b.Const("left"));
    }

    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeCover<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("size"), b.Const("cover"));
    }

    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeAuto<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("size"), b.Const("auto"));
    }

    /// <summary>
    /// If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("translucent"), b.Const(true));
    }
    public static void SetTranslucent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonPopover
    {
        b.SetProperty(b.Const("translucent"), translucent);
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: IonPopover
    {
        b.SetProperty(b.Const("trigger"), trigger);
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionClick<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("triggerAction"), b.Const("click"));
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionHover<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("triggerAction"), b.Const("hover"));
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionContextMenu<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Const("triggerAction"), b.Const("context-menu"));
    }

    /// <summary>
    /// Dismiss the popover overlay after it has been presented. This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<bool>> dismiss(this Metapsi.Syntax.ObjBuilder<IonPopover> b, Metapsi.Syntax.Var<object> data = null, Metapsi.Syntax.Var<string> role = null, Metapsi.Syntax.Var<bool> dismissParentPopover = null)
    {
        return b.Call<Promise<bool>>("dismiss", data, role, dismissParentPopover);
    }

    /// <summary>
    /// Returns a promise that resolves when the popover did dismiss.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<OverlayEventDetail>> onDidDismiss<T1>(this Metapsi.Syntax.ObjBuilder<IonPopover> b)
    {
        return b.Call<Promise<OverlayEventDetail>>("onDidDismiss");
    }

    /// <summary>
    /// Returns a promise that resolves when the popover will dismiss.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<OverlayEventDetail>> onWillDismiss<T1>(this Metapsi.Syntax.ObjBuilder<IonPopover> b)
    {
        return b.Call<Promise<OverlayEventDetail>>("onWillDismiss");
    }

    /// <summary>
    /// Present the popover overlay after it has been created. Developers can pass a mouse, touch, or pointer event to position the popover relative to where that event was dispatched.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> present(this Metapsi.Syntax.ObjBuilder<IonPopover> b, Metapsi.Syntax.Var<MouseEvent> @event = null)
    {
        return b.Call<Promise>("present", @event);
    }

    /// <summary>
    /// Present the popover overlay after it has been created. Developers can pass a mouse, touch, or pointer event to position the popover relative to where that event was dispatched.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> present(this Metapsi.Syntax.ObjBuilder<IonPopover> b, Metapsi.Syntax.Var<TouchEvent> @event = null)
    {
        return b.Call<Promise>("present", @event);
    }

    /// <summary>
    /// Present the popover overlay after it has been created. Developers can pass a mouse, touch, or pointer event to position the popover relative to where that event was dispatched.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> present(this Metapsi.Syntax.ObjBuilder<IonPopover> b, Metapsi.Syntax.Var<PointerEvent> @event = null)
    {
        return b.Call<Promise>("present", @event);
    }

    /// <summary>
    /// Present the popover overlay after it has been created. Developers can pass a mouse, touch, or pointer event to position the popover relative to where that event was dispatched.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> present(this Metapsi.Syntax.ObjBuilder<IonPopover> b, Metapsi.Syntax.Var<CustomEvent<object>> @event = null)
    {
        return b.Call<Promise>("present", @event);
    }

    /// <summary>
    /// Present the popover overlay after it has been created. Developers can pass a mouse, touch, or pointer event to position the popover relative to where that event was dispatched.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> present(this Metapsi.Syntax.ObjBuilder<IonPopover> b)
    {
        return b.Call<Promise>("present");
    }
}