using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonSelectOption
{

    /// <summary>
    /// If `true`, the user cannot interact with the select option. This property does not apply when `interface="action-sheet"` as `ion-action-sheet` does not allow for disabled buttons.
    /// </summary>
    public bool disabled { get; set; }

    /// <summary>
    /// The text value of the option.
    /// </summary>
    public object value { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonSelectOptionControl
{
    /// <summary>
    /// Builds a "ion-select-option" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSelectOption(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSelectOption>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-select-option", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-select-option" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSelectOption(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-select-option", children);
    }

    /// <summary>
    /// Builds a "ion-select-option" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSelectOption(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSelectOption>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-select-option", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-select-option" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSelectOption(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-select-option", children);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the select option. This property does not apply when `interface="action-sheet"` as `ion-action-sheet` does not allow for disabled buttons.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonSelectOption> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the select option. This property does not apply when `interface="action-sheet"` as `ion-action-sheet` does not allow for disabled buttons.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonSelectOption> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The text value of the option.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<IonSelectOption> b, string value)
    {
        b.SetAttribute("value", value);
    }
    /// <summary>
    /// Builds a virtual "ion-select-option" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSelectOption(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSelectOption>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-select-option", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-select-option" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSelectOption(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-select-option", children);
    }

    /// <summary>
    /// Builds a virtual "ion-select-option" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSelectOption(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSelectOption>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-select-option", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-select-option" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSelectOption(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-select-option", children);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the select option. This property does not apply when `interface="action-sheet"` as `ion-action-sheet` does not allow for disabled buttons.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelectOption
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonSelectOption
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// The text value of the option.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<object> value) where T: IonSelectOption
    {
        b.SetProperty(b.Const("value"), value);
    }
}
public static partial class IonSelectOptionExtensions
{

    /// <summary>
    /// If `true`, the user cannot interact with the select option. This property does not apply when `interface="action-sheet"` as `ion-action-sheet` does not allow for disabled buttons.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonSelectOption
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonSelectOption
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// The text value of the option.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<object> value) where T: IonSelectOption
    {
        b.SetProperty(b.Const("value"), value);
    }
}