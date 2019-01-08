﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MacrosApp.Core;

namespace MacrosApp
{
    public partial class MacrosHistoryControl : UserControl
    {
        private int _currentId = 0;
        private Dictionary<MouseButtons, string> _mouseButtons;

        public MacrosHistoryControl()
        {
            InitializeComponent();
            _mouseButtons = new Dictionary<MouseButtons, string>();
            _mouseButtons.Add(MouseButtons.Left, "l");
            _mouseButtons.Add(MouseButtons.Right, "r");
        }

        public void AddAction(MyAction action)
        {
            _currentId++;
            var item = new MacrosHistoryElemControl();
            item.X = action.X;
            item.Y = action.Y;
            item.Count = action.Count;
            item.Delay = action.Delay;
            item.Button = _mouseButtons[action.Button];
            item.Tag = _currentId.ToString();
            item.Left = 0;
            item.Top = _currentId * item.Height;
            Controls.Add(item);
        }

        public void ClearActions()
        {
            Controls.Clear();
            _currentId = 0;
        }

        public List<MyAction> GetActions()
        {
            var actions = new List<MyAction>();
            foreach (Control control in Controls)
            {
                var historyElemControl = control as MacrosHistoryElemControl;
                if (historyElemControl != null)
                {
                    var action = new MyAction();
                    action.X = historyElemControl.X;
                    action.Y = historyElemControl.Y;
                    action.Count = historyElemControl.Count;
                    action.Delay = historyElemControl.Delay;
                    action.Button = _mouseButtons.Single(x => x.Value == historyElemControl.Button).Key;
                    action.IsMouseClick = true;
                    actions.Add(action);
                }
            }
            return actions;
        }
    }
}
