using System.Globalization;

namespace MacrosApp.Gui;

public partial class MacrosHistoryElemControl : UserControl
{
    public MacrosHistoryElemControl()
    {
        InitializeComponent();
    }

    public int X
    {
        get => Convert.ToInt32(xTextBox.Text);
        set => xTextBox.Text = value.ToString();
    }

    public int Y
    {
        get => Convert.ToInt32(yTextBox.Text);
        set => yTextBox.Text = value.ToString();
    }

    public double Delay
    {
        get => Convert.ToDouble(delayTextBox.Text, CultureInfo.InvariantCulture);
        set => delayTextBox.Text = value.ToString(CultureInfo.InvariantCulture);
    }

    public string Button
    {
        get => buttonTextBox.Text;
        set => buttonTextBox.Text = value;
    }

    public int Count
    {
        get => Convert.ToInt32(uiCountTextBox.Text);
        set => uiCountTextBox.Text = value.ToString();
    }

    public string TypeText
    {
        get => uiTypeLabel.Text;
        set => uiTypeLabel.Text = value;
    }
}
