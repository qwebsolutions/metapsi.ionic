using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonItemOption
{

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public string color { get; set; }

    /// <summary>
    /// If `true`, the user cannot interact with the item option.
    /// </summary>
    public bool disabled { get; set; }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public string download { get; set; }

    /// <summary>
    /// If `true`, the option will expand to take up the available width and cover any other options.
    /// </summary>
    public bool expandable { get; set; }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public string href { get; set; }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode { get; set; }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public string rel { get; set; }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public string target { get; set; }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public string type { get; set; }

    public static partial class Slot
    {
        /// <summary>
        /// Content is placed below the option text.
        /// </summary>
        public const string Bottom = "bottom";
        /// <summary>
        /// Content is placed to the right of the option text in LTR, and to the left in RTL.
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// Should be used on an icon in an option that has no text.
        /// </summary>
        public const string IconOnly = "icon-only";
        /// <summary>
        /// Content is placed to the left of the option text in LTR, and to the right in RTL.
        /// </summary>
        public const string Start = "start";
        /// <summary>
        /// Content is placed above the option text.
        /// </summary>
        public const string Top = "top";
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonItemOptionControl
{
    /// <summary>
    /// Builds a "ion-item-option" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemOption(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonItemOption>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-item-option", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-item-option" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemOption(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-item-option", children);
    }

    /// <summary>
    /// Builds a "ion-item-option" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemOption(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonItemOption>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-item-option", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-item-option" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItemOption(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-item-option", children);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the item option.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonItemOption> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the item option.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this Metapsi.Html.AttributesBuilder<IonItemOption> b, string download)
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// If `true`, the option will expand to take up the available width and cover any other options.
    /// </summary>
    public static void SetExpandable(this Metapsi.Html.AttributesBuilder<IonItemOption> b, bool expandable)
    {
        if (expandable) b.SetAttribute("expandable", "");
    }

    /// <summary>
    /// If `true`, the option will expand to take up the available width and cover any other options.
    /// </summary>
    public static void SetExpandable(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("expandable", "");
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this Metapsi.Html.AttributesBuilder<IonItemOption> b, string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this Metapsi.Html.AttributesBuilder<IonItemOption> b, string rel)
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this Metapsi.Html.AttributesBuilder<IonItemOption> b, string target)
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("type", "reset");
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton(this Metapsi.Html.AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("type", "button");
    }
    /// <summary>
    /// Builds a virtual "ion-item-option" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemOption(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonItemOption>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-item-option", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-item-option" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemOption(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-item-option", children);
    }

    /// <summary>
    /// Builds a virtual "ion-item-option" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemOption(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonItemOption>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-item-option", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-item-option" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItemOption(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-item-option", children);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), color);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the item option.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonItemOption
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> download) where T: IonItemOption
    {
        b.SetProperty(b.Const("download"), download);
    }

    /// <summary>
    /// If `true`, the option will expand to take up the available width and cover any other options.
    /// </summary>
    public static void SetExpandable<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("expandable"), b.Const(true));
    }
    public static void SetExpandable<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> expandable) where T: IonItemOption
    {
        b.SetProperty(b.Const("expandable"), expandable);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> href) where T: IonItemOption
    {
        b.SetProperty(b.Const("href"), href);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> rel) where T: IonItemOption
    {
        b.SetProperty(b.Const("rel"), rel);
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> target) where T: IonItemOption
    {
        b.SetProperty(b.Const("target"), target);
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("type"), b.Const("submit"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("type"), b.Const("reset"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("type"), b.Const("button"));
    }
}
public static partial class IonItemOptionExtensions
{

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonItemOption
    {
        b.SetProperty(b.Const("color"), color);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the item option.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonItemOption
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> download) where T: IonItemOption
    {
        b.SetProperty(b.Const("download"), download);
    }

    /// <summary>
    /// If `true`, the option will expand to take up the available width and cover any other options.
    /// </summary>
    public static void SetExpandable<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("expandable"), b.Const(true));
    }
    public static void SetExpandable<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> expandable) where T: IonItemOption
    {
        b.SetProperty(b.Const("expandable"), expandable);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> href) where T: IonItemOption
    {
        b.SetProperty(b.Const("href"), href);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> rel) where T: IonItemOption
    {
        b.SetProperty(b.Const("rel"), rel);
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> target) where T: IonItemOption
    {
        b.SetProperty(b.Const("target"), target);
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("type"), b.Const("submit"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("type"), b.Const("reset"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItemOption
    {
        b.SetProperty(b.Const("type"), b.Const("button"));
    }
}