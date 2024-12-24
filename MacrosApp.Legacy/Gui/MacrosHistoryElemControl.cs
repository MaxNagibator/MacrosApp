using System;
using System.Windows.Forms;

namespace MacrosApp
{
    public partial class MacrosHistoryElemControl : UserControl
    {
        public MacrosHistoryElemControl()
        {
            InitializeComponent();
        }

        public int X
        {
            get { return Convert.ToInt32(xTextBox.Text); }
            set { xTextBox.Text = value.ToString(); }
        }

        public int Y
        {
            get { return Convert.ToInt32(yTextBox.Text); }
            set { yTextBox.Text = value.ToString(); }
        }

        public double Delay
        {
            get { return Convert.ToDouble(delayTextBox.Text); }
            set { delayTextBox.Text = value.ToString(); }
        }

        public string Button
        {
            get { return buttonTextBox.Text; }
            set { buttonTextBox.Text = value; }
        }

        public int Count
        {
            get { return Convert.ToInt32(uiCountTextBox.Text); }
            set { uiCountTextBox.Text = value.ToString(); }
        }

        public string TypeText
        {
            get { return uiTypeLabel.Text; }
            set { uiTypeLabel.Text = value; }
        }
    }
}
