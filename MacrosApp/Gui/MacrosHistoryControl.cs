using MacrosApp.Core;
using Newtonsoft.Json;

namespace MacrosApp.Gui;

public partial class MacrosHistoryControl : UserControl
{
    public MacrosHistoryControl()
    {
        InitializeComponent();
    }

    public void AddAction(MyAction action)
    {
        MacrosHistoryElemControl item = new();
        action.FillHistoryElement(item);

        item.Left = 0;
        item.Top = panel1.Controls.Count * item.Height;

        panel1.Controls.Add(item);
    }

    public void ClearActions()
    {
        panel1.Controls.Clear();
    }

    public List<MyAction> GetActions()
    {
        List<MyAction> actions = [];

        foreach (Control control in panel1.Controls)
        {
            if (control is not MacrosHistoryElemControl historyElemControl)
            {
                continue;
            }

            if (historyElemControl.Tag is not MyAction myAction)
            {
                continue;
            }

            actions.Add(myAction.Update(historyElemControl));
        }

        return actions;
    }

    private void uiSaveButton_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
        {
            return;
        }

        List<MyAction> actions = GetActions();

        string filename = saveFileDialog1.FileName;

        JsonSerializerSettings settings = new()
        {
            TypeNameHandling = TypeNameHandling.Objects,
        };

        string jsonString = JsonConvert.SerializeObject(actions, settings);
        File.WriteAllText(filename, jsonString);
    }

    private void uiLoadButton_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
        {
            return;
        }

        string filename = openFileDialog1.FileName;
        string fileText = File.ReadAllText(filename);

        JsonSerializerSettings settings = new()
        {
            TypeNameHandling = TypeNameHandling.Objects,
        };

        MyAction[]? actions = JsonConvert.DeserializeObject<MyAction[]>(fileText, settings);

        if (actions == null)
        {
            MessageBox.Show("Не удалось десериализовать действия.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ClearActions();

        foreach (MyAction action in actions)
        {
            AddAction(action);
        }
    }
}
