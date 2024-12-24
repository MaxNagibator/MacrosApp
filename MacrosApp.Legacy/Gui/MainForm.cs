using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MacrosApp.Core;

namespace MacrosApp
{
    partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void ButtonStartClick(object sender, EventArgs e)
        {
            actHook.Start();
        }

        void ButtonStopClick(object sender, EventArgs e)
        {
            actHook.Stop();
        }


        UserActivityHook actHook;
        void MainFormLoad(object sender, EventArgs e)
        {
            actHook = new UserActivityHook(); // crate an instance with global hooks
            // hang on events
            actHook.OnMouseActivity += new MouseEventHandler(MouseMoved);
            actHook.KeyDown += new KeyEventHandler(MyKeyDown);
            actHook.KeyPress += new KeyPressEventHandler(MyKeyPress);
            actHook.KeyUp += new KeyEventHandler(MyKeyUp);
        }
        private int lastMouseX;
        private int lastMouseY;
        public void MouseMoved(object sender, MouseEventArgs e)
        {
            labelMousePosition.Text = String.Format("x={0}  y={1} wheel={2}", e.X, e.Y, e.Delta);
            if (e.Clicks > 0)
            {
                LogWrite("MouseButton 	- " + e.Button.ToString());
                if (_isStartMacros)
                {
                    var myAction = new MouseAction
                    {
                        X = e.X,
                        Y = e.Y,
                        Button = e.Button,
                        Delay = (DateTime.Now - _startDate).TotalMilliseconds,
                        Count = 1,
                    };
                    uiMacrosHistoryControl.AddAction(myAction);
                    _startDate = DateTime.Now;
                }
            }
            lastMouseX = e.X;
            lastMouseY = e.Y;
        }

        public void MyKeyDown(object sender, KeyEventArgs e)
        {
            LogWrite("KeyDown 	- " + e.KeyData.ToString());
        }

        public void MyKeyPress(object sender, KeyPressEventArgs e)
        {
            LogWrite("KeyPress 	- " + e.KeyChar);
        }


        private bool _isStartMacros;
        private bool _isBreak;
        private DateTime _startDate;
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private List<MyAction> _myActions = new List<MyAction>();
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        public void MyKeyUp(object sender, KeyEventArgs e)
        {
            LogWrite("KeyUp 		- " + e.KeyData.ToString());
            if (_isStartMacros && e.KeyCode != Keys.W)
            {
                var myAction = new KeyboardAction
                {
                    Key = e.KeyCode,
                    KeyValue = e.KeyValue,
                    Delay = (DateTime.Now - _startDate).TotalMilliseconds,
                    Count = 1,
                };
                uiMacrosHistoryControl.AddAction(myAction);
                _startDate = DateTime.Now;
            }

            if (e.KeyCode == Keys.Q)
            {
                e.Handled = true;
                _isStartMacros = true;
                uiMacrosHistoryControl.ClearActions();
                _startDate = DateTime.Now;
                _isBreak = true;
            }
            if (e.KeyCode == Keys.W)
            {
                e.Handled = true;
                _isStartMacros = false;
                _isBreak = true;
            }
            if (e.KeyCode == Keys.E)
            {
                _myActions = uiMacrosHistoryControl.GetActions();

                e.Handled = true;
                _isBreak = false;
                if (uiKuricaKormRadioButton.Checked
                    || uiDerevoRadioButton.Checked
                    || uiKuricaCustomRadioButton.Checked)
                {
                    Thread th = new Thread(GoScriptKormKuricam);
                    th.Start();
                }
                else if (twoStepWithShiftRadioButton.Checked)
                {

                    Thread th = new Thread(GoScriptTwoStepWithShift);
                    th.Start();
                }
                else if (uiClassicRadioButton.Checked)
                {
                    Thread th = new Thread(GoScript);
                    th.Start();
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            if (e.KeyCode == Keys.S)
            {
                e.Handled = true;
                _isBreak = true;
            }
        }

        private void GoScriptTwoStepWithShift()
        {
            var step1Count = Convert.ToInt32(uiStep1CountTextBox.Text);
            var step2Count = Convert.ToInt32(uiStep2CountTextBox.Text);
            var shift = Convert.ToInt32(uiStep1ShiftCountTextBox.Text);
            var shift2 = Convert.ToInt32(uiStep2ShiftCountTextBox.Text);
            var delay = Convert.ToDouble(uiDelayTextBox.Text);
            var every = Convert.ToDouble(uiShiftEveryTextBox.Text);
            var mouseMoveClickDelay = Convert.ToInt32(mouseMoveClickDelayTextBox.Text);
            for (int iStep1 = 0; iStep1 < step1Count; iStep1++)
            {
                for (int iStep2 = 0; iStep2 < step2Count; iStep2++)
                {
                    for (int iAction = 0; iAction < _myActions.Count; iAction++)
                    {
                        if (_isBreak)
                        {
                            break;
                        }
                        var myAction2 = _myActions[iAction];

                        if (myAction2 is MouseAction)
                        {
                            var myAction = (MouseAction)myAction2;
                            var x = myAction.X;
                            var y = myAction.Y;
                            if ((iAction + 1) % every == 0)
                            {
                                var step = shift;
                                x = x + iStep2 * shift + iStep1 * shift;
                                y = y + (iStep2 * shift2) * -1 + iStep1 * shift2;
                            }
                            GoScriptMouseClick(myAction.Delay, myAction.Button, x, y, mouseMoveClickDelay, delay);
                        }
                        else if (myAction2 is KeyboardAction)
                        {
                            KeyboardCLick(delay, myAction2);
                        }
                    }
                }
            }
        }

        private void GoScriptKormKuricam()
        {
            var step1Count = Convert.ToInt32(uiKuricaKormStep1CountTextBox.Text);
            var step2Count = Convert.ToInt32(uiKuricaKormStep2CountTextBox.Text);
            var mouseMoveClickDelay = Convert.ToInt32(mouseMoveClickDelayTextBox.Text);
            var x = lastMouseX;
            var y = lastMouseY;
            var step = 32;
            if (uiDerevoRadioButton.Checked)
            {
                step = 64;
            }
            else if (uiKuricaCustomRadioButton.Checked)
            {
                step = Convert.ToInt32(uiKuricaKormShiftTextBox.Text);
            }
            for (int iStep1 = 0; iStep1 < step1Count; iStep1++)
            {
                for (int iStep2 = 0; iStep2 < step2Count; iStep2++)
                {
                    if (_isBreak)
                    {
                        break;
                    }

                    var x1 = x + iStep2 * step + iStep1 * step;
                    var y1 = y + (iStep2 * step / 2) * -1 + iStep1 * step / 2;
                    GoScriptMouseClick(100, MouseButtons.Left, x1, y1, mouseMoveClickDelay, 1);
                }
            }
        }

        const UInt32 WM_KEYDOWN = 0x0100;
        const int WM_KEYUP = 0x101;
        const int VK_F5 = 0x41;

        private void GoScript()
        {
            var stepCount = Convert.ToInt32(uiClassicStepCount.Text);
            var mouseMoveClickDelay = Convert.ToInt32(mouseMoveClickDelayTextBox.Text);
            var delay = Convert.ToDouble(uiDelayTextBox.Text);

            for (int i = 0; i < stepCount; i++)
            {
                for (int iAction = 0; iAction < _myActions.Count; iAction++)
                {
                    var myAction = _myActions[iAction];
                    for (int actionPiuPiu = 0; actionPiuPiu < myAction.Count; actionPiuPiu++)
                    {
                        if (_isBreak)
                        {
                            break;
                        }

                        if (myAction is MouseAction)
                        {
                            var mouseAction = ((MouseAction)myAction);
                            var x = mouseAction.X;
                            var y = mouseAction.Y;

                            GoScriptMouseClick(myAction.Delay, mouseAction.Button, x, y, mouseMoveClickDelay, delay);
                        }
                        else if(myAction is KeyboardAction)
                        {
                            KeyboardCLick(delay, myAction);
                        }
                    }
                }
            }
        }

        private void KeyboardCLick(double delay, MyAction myAction)
        {
            Thread.Sleep((int)(myAction.Delay * delay));
            IntPtr handle = GetForegroundWindow();
            LogWrite(handle.ToString());
            PostMessage(handle, WM_KEYDOWN, ((KeyboardAction)myAction).KeyValue, 0);
        }

        private void GoScriptMouseClick(double myActionWait, MouseButtons myActionButton, int x, int y, int mouseMoveClickDelay, double delay = 1)
        {
            Thread.Sleep((int)(myActionWait * delay));

            LogWrite("script MouseClick -> " + x + " - " + y);

            Cursor.Position = new Point(x, y);
            Thread.Sleep(mouseMoveClickDelay);
            if (myActionButton == MouseButtons.Left)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            }
            else if (myActionButton == MouseButtons.Right)
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            }
        }


        private void LogWrite(string txt)
        {
            textBox.AppendText(txt + Environment.NewLine);
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            actHook.Stop();
        }
    }
}
