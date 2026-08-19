
namespace Metapsi.Ionic;

public class ModalDragEventDetail
{

    /// <summary>
    /// The current Y coordinate of the drag event.
    /// </summary>
    public decimal currentY { get; set; }

    /// <summary>
    /// The change in Y coordinate since the last drag event.
    /// </summary>
    public decimal deltaY { get; set; }

    /// <summary>
    /// The velocity of the drag event in the Y direction.
    /// </summary>
    public decimal velocityY { get; set; }

    /// <summary>
    /// The progress of the drag event, represented as a value between 0 and 1. A value of 0 means the modal is at its lowest point (fully closed), while a value of 1 means the modal is at its highest point (fully open).
    /// </summary>
    public decimal progress { get; set; }

    /// <summary>
    /// The breakpoint that the sheet will snap to if the user releases the gesture.
    /// </summary>
    public decimal snapBreakpoint { get; set; }
}
public static partial class ModalDragEventDetailExtensions
{
}