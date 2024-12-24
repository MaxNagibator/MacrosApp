using MacrosApp.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MacrosApp
{
    public partial class MacrosHistoryControl : UserControl
    {
        private int _currentId = 0;
        private Dictionary<MouseButtons, string> _mouseButtons;
        public MacrosHistoryControl()
        {
            InitializeComponent();
            _mouseButtons = new Dictionary<MouseButtons, string>
            {
                { MouseButtons.Left, "l" },
                { MouseButtons.Right, "r" }
            };
        }

        public void AddAction(MyAction action)
        {
            _currentId++;

            var item = new MacrosHistoryElemControl();
            item.Count = action.Count;
            item.Delay = action.Delay;
            item.Tag = _currentId.ToString();
            item.Left = 0;
            item.Top = (_currentId - 1) * item.Height;
            item.TypeText = action.TypeText;
            if (action is MouseAction)
            {
                var mouseAction = (MouseAction)action;
                item.X = mouseAction.X;
                item.Y = mouseAction.Y;
                item.Button = _mouseButtons[mouseAction.Button];
            }
            else if (action is KeyboardAction)
            {
                var keyboardAction = (KeyboardAction)action;
                item.Button = keyboardAction.KeyValue.ToString();
            }
            else
            {
                throw new Exception("unrecognized type");
            }

            panel1.Controls.Add(item);
        }

        public void ClearActions()
        {
            panel1.Controls.Clear();
            _currentId = 0;
        }

        public List<MyAction> GetActions()
        {
            var mouseHint = new MouseAction();
            var actions = new List<MyAction>();
            foreach (Control control in panel1.Controls)
            {
                var historyElemControl = control as MacrosHistoryElemControl;
                if (historyElemControl != null)
                {
                    MyAction myAction;
                    if (historyElemControl.TypeText == mouseHint.TypeText)
                    {
                        var action = new MouseAction();
                        action.X = historyElemControl.X;
                        action.Y = historyElemControl.Y;
                        action.Button = _mouseButtons.Single(x => x.Value == historyElemControl.Button).Key;
                        myAction = action;
                    }
                    else
                    {
                        var action = new KeyboardAction();
                        action.KeyValue = Int32.Parse(historyElemControl.Button);
                        myAction = action;
                    }

                    myAction.Count = historyElemControl.Count;
                    myAction.Delay = historyElemControl.Delay;
                    actions.Add(myAction);
                }
            }
            return actions;
        }

        private void uiSaveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            var actions = GetActions();

            string filename = saveFileDialog1.FileName;
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Objects };
            string jsonString = JsonConvert.SerializeObject(actions, settings);
            System.IO.File.WriteAllText(filename, jsonString);
        }

        private void uiLoadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Objects };
            var actions = JsonConvert.DeserializeObject<MyAction[]>(fileText, settings);
            ClearActions();
            foreach (var action in actions)
            {
                AddAction(action);
            }
        }
    }
}
