using MacrosApp.Gui;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MacrosApp.Core;

public abstract record MyAction
{
    public double Delay { get; init; }
    public int Count { get; init; }

    // TODO: Подумать над логированием
    public abstract void Perform(double beforeActionDelay = 1, double beforePerformDelay = 0, Action<string>? log = null);

    // TODO: Происходит смешивание бизнес логики с логикой отображения
    public void FillHistoryElement(MacrosHistoryElemControl item)
    {
        item.Count = Count;
        item.Delay = Delay;
        item.Tag = this;

        FillHistoryElementInner(item);
    }

    public MyAction Update(MacrosHistoryElemControl historyElemControl)
    {
        return UpdateInner(historyElemControl) with
        {
            Count = historyElemControl.Count,
            Delay = historyElemControl.Delay,
        };
    }

    // Альтернативный вариант - виртуальный метод с вызовом базового в дочерних
    protected abstract void FillHistoryElementInner(MacrosHistoryElemControl item);
    protected abstract MyAction UpdateInner(MacrosHistoryElemControl historyElemControl);
}

public partial record MouseAction : MyAction
{
    private const int MOUSEEVENTF_LEFTDOWN = 0x02;
    private const int MOUSEEVENTF_LEFTUP = 0x04;
    private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
    private const int MOUSEEVENTF_RIGHTUP = 0x10;

    private static readonly Dictionary<MouseButtons, string> Buttons = new()
    {
        [MouseButtons.Left] = "L",
        [MouseButtons.Right] = "R",
    };

    public int X { get; init; }
    public int Y { get; init; }
    public MouseButtons Button { get; init; }

    private Point Position => new(X, Y);

    public override void Perform(double beforeActionDelay = 1, double beforePerformDelay = 0, Action<string>? log = null)
    {
        Thread.Sleep((int)(Delay * beforeActionDelay));

        log?.Invoke("script MouseClick -> " + X + " - " + Y);

        Cursor.Position = Position;
        Thread.Sleep((int)beforePerformDelay);

        switch (Button)
        {
            case MouseButtons.Left:
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                break;

            case MouseButtons.Right:
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                break;
        }
    }

    protected override MyAction UpdateInner(MacrosHistoryElemControl historyElemControl)
    {
        return this with
        {
            X = historyElemControl.X,
            Y = historyElemControl.Y,
            Button = Buttons.Single(x => x.Value == historyElemControl.Button).Key,
        };
    }

    protected override void FillHistoryElementInner(MacrosHistoryElemControl item)
    {
        item.X = X;
        item.Y = Y;
        item.Button = Buttons[Button];
    }

    [LibraryImport("user32.dll")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    private static partial void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
}

public partial record KeyboardAction : MyAction
{
    private const uint WM_KEYDOWN = 0x0100;

    public Keys Key { get; init; }
    public int KeyValue { get; init; }

    public override void Perform(double beforeActionDelay = 1, double beforePerformDelay = 0, Action<string>? log = null)
    {
        Thread.Sleep((int)(Delay * beforeActionDelay));
        IntPtr handle = GetForegroundWindow();

        log?.Invoke(handle.ToString());

        // Thread.Sleep((int)beforePerformDelay);
        PostMessage(handle, WM_KEYDOWN, KeyValue, 0);
    }

    protected override MyAction UpdateInner(MacrosHistoryElemControl historyElemControl)
    {
        return this with
        {
            KeyValue = int.Parse(historyElemControl.Button),
        };
    }

    protected override void FillHistoryElementInner(MacrosHistoryElemControl item)
    {
        item.Button = KeyValue.ToString();
    }

    [LibraryImport("user32.dll")]
    private static partial IntPtr GetForegroundWindow();

    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
}
