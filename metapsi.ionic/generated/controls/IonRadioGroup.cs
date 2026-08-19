using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonRadioGroup
{

    /// <summary>
    /// If `true`, the radios can be deselected.
    /// </summary>
    public bool allowEmptySelection { get; set; }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public object compareWith { get; set; }

    /// <summary>
    /// The error text to display at the top of the radio group.
    /// </summary>
    public string errorText { get; set; }

    /// <summary>
    /// The helper text to display at the top of the radio group.
    /// </summary>
    public string helperText { get; set; }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// the value of the radio group.
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
public static partial class IonRadioGroupControl
{
    /// <summary>
    /// Builds a "ion-radio-group" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRadioGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRadioGroup>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-radio-group", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-radio-group" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRadioGroup(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-radio-group", children);
    }

    /// <summary>
    /// Builds a "ion-radio-group" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRadioGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRadioGroup>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-radio-group", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-radio-group" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRadioGroup(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-radio-group", children);
    }

    /// <summary>
    /// If `true`, the radios can be deselected.
    /// </summary>
    public static void SetAllowEmptySelection(this Metapsi.Html.AttributesBuilder<IonRadioGroup> b, bool allowEmptySelection)
    {
        if (allowEmptySelection) b.SetAttribute("allow-empty-selection", "");
    }

    /// <summary>
    /// If `true`, the radios can be deselected.
    /// </summary>
    public static void SetAllowEmptySelection(this Metapsi.Html.AttributesBuilder<IonRadioGroup> b)
    {
        b.SetAttribute("allow-empty-selection", "");
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith(this Metapsi.Html.AttributesBuilder<IonRadioGroup> b, string compareWith)
    {
        b.SetAttribute("compare-with", compareWith);
    }

    /// <summary>
    /// The error text to display at the top of the radio group.
    /// </summary>
    public static void SetErrorText(this Metapsi.Html.AttributesBuilder<IonRadioGroup> b, string errorText)
    {
        b.SetAttribute("error-text", errorText);
    }

    /// <summary>
    /// The helper text to display at the top of the radio group.
    /// </summary>
    public static void SetHelperText(this Metapsi.Html.AttributesBuilder<IonRadioGroup> b, string helperText)
    {
        b.SetAttribute("helper-text", helperText);
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<IonRadioGroup> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// the value of the radio group.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<IonRadioGroup> b, string value)
    {
        b.SetAttribute("value", value);
    }
    /// <summary>
    /// Builds a virtual "ion-radio-group" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRadioGroup>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-radio-group", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-radio-group" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-radio-group", children);
    }

    /// <summary>
    /// Builds a virtual "ion-radio-group" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRadioGroup>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-radio-group", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-radio-group" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-radio-group", children);
    }

    /// <summary>
    /// If `true`, the radios can be deselected.
    /// </summary>
    public static void SetAllowEmptySelection<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("allowEmptySelection"), b.Const(true));
    }
    public static void SetAllowEmptySelection<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> allowEmptySelection) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("allowEmptySelection"), allowEmptySelection);
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> compareWith) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("compareWith"), compareWith);
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, bool>> compareWith) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("compareWith"), compareWith);
    }

    /// <summary>
    /// The error text to display at the top of the radio group.
    /// </summary>
    public static void SetErrorText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> errorText) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("errorText"), errorText);
    }

    /// <summary>
    /// The helper text to display at the top of the radio group.
    /// </summary>
    public static void SetHelperText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> helperText) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("helperText"), helperText);
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("name"), name);
    }

    /// <summary>
    /// the value of the radio group.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<object> value) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("value"), value);
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("onionChange"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    [System.Obsolete]
    public static void OnIonChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRadioGroup
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("onionChange"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    [System.Obsolete]
    public static void OnIonChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRadioGroup
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<RadioGroupChangeEventDetail>>> action) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("onionChange"), b.Const(action));
    }
}
public static partial class IonRadioGroupExtensions
{

    /// <summary>
    /// If `true`, the radios can be deselected.
    /// </summary>
    public static void SetAllowEmptySelection<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("allowEmptySelection"), b.Const(true));
    }
    public static void SetAllowEmptySelection<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> allowEmptySelection) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("allowEmptySelection"), allowEmptySelection);
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> compareWith) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("compareWith"), compareWith);
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, bool>> compareWith) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("compareWith"), compareWith);
    }

    /// <summary>
    /// The error text to display at the top of the radio group.
    /// </summary>
    public static void SetErrorText<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> errorText) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("errorText"), errorText);
    }

    /// <summary>
    /// The helper text to display at the top of the radio group.
    /// </summary>
    public static void SetHelperText<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> helperText) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("helperText"), helperText);
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("name"), name);
    }

    /// <summary>
    /// the value of the radio group.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<object> value) where T: IonRadioGroup
    {
        b.SetProperty(b.Const("value"), value);
    }
}