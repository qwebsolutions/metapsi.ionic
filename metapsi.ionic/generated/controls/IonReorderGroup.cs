using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonReorderGroup
{

    /// <summary>
    /// If `true`, the reorder will be hidden.
    /// </summary>
    public bool disabled { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Completes the reorder operation. Must be called by the `ionReorderEnd` event.  If a list of items is passed, the list will be reordered and returned in the proper order.  If no parameters are passed or if `true` is passed in, the reorder will complete and the item will remain in the position it was dragged to. If `false` is passed, the reorder will complete and the item will bounce back to its original position.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonReorderGroup> instead")]
        public const string Complete = "complete";
    }
}
public static partial class IonReorderGroupControl
{
    /// <summary>
    /// Builds a "ion-reorder-group" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonReorderGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonReorderGroup>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-reorder-group", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-reorder-group" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonReorderGroup(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-reorder-group", children);
    }

    /// <summary>
    /// Builds a "ion-reorder-group" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonReorderGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonReorderGroup>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-reorder-group", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-reorder-group" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonReorderGroup(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-reorder-group", children);
    }

    /// <summary>
    /// If `true`, the reorder will be hidden.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonReorderGroup> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the reorder will be hidden.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonReorderGroup> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// Builds a virtual "ion-reorder-group" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonReorderGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonReorderGroup>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-reorder-group", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-reorder-group" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonReorderGroup(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-reorder-group", children);
    }

    /// <summary>
    /// Builds a virtual "ion-reorder-group" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonReorderGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonReorderGroup>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-reorder-group", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-reorder-group" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonReorderGroup(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-reorder-group", children);
    }

    /// <summary>
    /// If `true`, the reorder will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Event that needs to be listened to in order to complete the reorder action.
    /// </summary>
    public static void OnIonItemReorder<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("onionItemReorder"), b.Const(action));
    }

    /// <summary>
    /// Event that needs to be listened to in order to complete the reorder action.
    /// </summary>
    [System.Obsolete]
    public static void OnIonItemReorder<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonReorderGroup
    {
        b.OnIonItemReorder(b.MakeAction(action));
    }

    /// <summary>
    /// Event that needs to be listened to in order to complete the reorder action.
    /// </summary>
    public static void OnIonItemReorder<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("onionItemReorder"), b.Const(action));
    }

    /// <summary>
    /// Event that needs to be listened to in order to complete the reorder action.
    /// </summary>
    [System.Obsolete]
    public static void OnIonItemReorder<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonReorderGroup
    {
        b.OnIonItemReorder(b.MakeAction(action));
    }

    /// <summary>
    /// Event that needs to be listened to in order to complete the reorder action.
    /// </summary>
    public static void OnIonItemReorder<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<ItemReorderEventDetail>>> action) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("onionItemReorder"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the reorder gesture ends. The from and to properties are always available, regardless of if the reorder gesture moved the item. If the item did not change from its start position, the from and to properties will be the same. Once the event has been emitted, the `complete()` method then needs to be called in order to finalize the reorder action.
    /// </summary>
    public static void OnIonReorderEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("onionReorderEnd"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the reorder gesture ends. The from and to properties are always available, regardless of if the reorder gesture moved the item. If the item did not change from its start position, the from and to properties will be the same. Once the event has been emitted, the `complete()` method then needs to be called in order to finalize the reorder action.
    /// </summary>
    [System.Obsolete]
    public static void OnIonReorderEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonReorderGroup
    {
        b.OnIonReorderEnd(b.MakeAction(action));
    }

    /// <summary>
    /// Event that is emitted when the reorder gesture ends. The from and to properties are always available, regardless of if the reorder gesture moved the item. If the item did not change from its start position, the from and to properties will be the same. Once the event has been emitted, the `complete()` method then needs to be called in order to finalize the reorder action.
    /// </summary>
    public static void OnIonReorderEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("onionReorderEnd"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the reorder gesture ends. The from and to properties are always available, regardless of if the reorder gesture moved the item. If the item did not change from its start position, the from and to properties will be the same. Once the event has been emitted, the `complete()` method then needs to be called in order to finalize the reorder action.
    /// </summary>
    [System.Obsolete]
    public static void OnIonReorderEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonReorderGroup
    {
        b.OnIonReorderEnd(b.MakeAction(action));
    }

    /// <summary>
    /// Event that is emitted when the reorder gesture ends. The from and to properties are always available, regardless of if the reorder gesture moved the item. If the item did not change from its start position, the from and to properties will be the same. Once the event has been emitted, the `complete()` method then needs to be called in order to finalize the reorder action.
    /// </summary>
    public static void OnIonReorderEnd<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<ReorderEndEventDetail>>> action) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("onionReorderEnd"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted as the reorder gesture moves.
    /// </summary>
    public static void OnIonReorderMove<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("onionReorderMove"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted as the reorder gesture moves.
    /// </summary>
    [System.Obsolete]
    public static void OnIonReorderMove<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonReorderGroup
    {
        b.OnIonReorderMove(b.MakeAction(action));
    }

    /// <summary>
    /// Event that is emitted as the reorder gesture moves.
    /// </summary>
    public static void OnIonReorderMove<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("onionReorderMove"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted as the reorder gesture moves.
    /// </summary>
    [System.Obsolete]
    public static void OnIonReorderMove<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonReorderGroup
    {
        b.OnIonReorderMove(b.MakeAction(action));
    }

    /// <summary>
    /// Event that is emitted as the reorder gesture moves.
    /// </summary>
    public static void OnIonReorderMove<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<ReorderMoveEventDetail>>> action) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("onionReorderMove"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the reorder gesture starts.
    /// </summary>
    public static void OnIonReorderStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("onionReorderStart"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the reorder gesture starts.
    /// </summary>
    [System.Obsolete]
    public static void OnIonReorderStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonReorderGroup
    {
        b.OnIonReorderStart(b.MakeAction(action));
    }

    /// <summary>
    /// Event that is emitted when the reorder gesture starts.
    /// </summary>
    public static void OnIonReorderStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("onionReorderStart"), b.Const(action));
    }

    /// <summary>
    /// Event that is emitted when the reorder gesture starts.
    /// </summary>
    [System.Obsolete]
    public static void OnIonReorderStart<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonReorderGroup
    {
        b.OnIonReorderStart(b.MakeAction(action));
    }
}
public static partial class IonReorderGroupExtensions
{

    /// <summary>
    /// If `true`, the reorder will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonReorderGroup
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Completes the reorder operation. Must be called by the `ionReorderEnd` event.  If a list of items is passed, the list will be reordered and returned in the proper order.  If no parameters are passed or if `true` is passed in, the reorder will complete and the item will remain in the position it was dragged to. If `false` is passed, the reorder will complete and the item will bounce back to its original position.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<object>> complete(this Metapsi.Syntax.ObjBuilder<IonReorderGroup> b, Metapsi.Syntax.Var<bool> listOrReorder = null)
    {
        return b.Call<Promise<object>>("complete", listOrReorder);
    }

    /// <summary>
    /// Completes the reorder operation. Must be called by the `ionReorderEnd` event.  If a list of items is passed, the list will be reordered and returned in the proper order.  If no parameters are passed or if `true` is passed in, the reorder will complete and the item will remain in the position it was dragged to. If `false` is passed, the reorder will complete and the item will bounce back to its original position.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<object>> complete(this Metapsi.Syntax.ObjBuilder<IonReorderGroup> b, Metapsi.Syntax.Var<System.Collections.Generic.List<object>> listOrReorder = null)
    {
        return b.Call<Promise<object>>("complete", listOrReorder);
    }

    /// <summary>
    /// Completes the reorder operation. Must be called by the `ionReorderEnd` event.  If a list of items is passed, the list will be reordered and returned in the proper order.  If no parameters are passed or if `true` is passed in, the reorder will complete and the item will remain in the position it was dragged to. If `false` is passed, the reorder will complete and the item will bounce back to its original position.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise<object>> complete(this Metapsi.Syntax.ObjBuilder<IonReorderGroup> b)
    {
        return b.Call<Promise<object>>("complete");
    }
}