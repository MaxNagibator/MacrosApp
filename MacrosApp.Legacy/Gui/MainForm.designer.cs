using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MacrosApp
{
    partial class MainForm
    {
        void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelMousePosition = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.uiStep1CountTextBox = new System.Windows.Forms.TextBox();
            this.uiStep2CountTextBox = new System.Windows.Forms.TextBox();
            this.uiStep1ShiftCountTextBox = new System.Windows.Forms.TextBox();
            this.uiStep2ShiftCountTextBox = new System.Windows.Forms.TextBox();
            this.twoStepWithShiftRadioButton = new System.Windows.Forms.RadioButton();
            this.uiKuricaKormRadioButton = new System.Windows.Forms.RadioButton();
            this.uiKuricaKormStep2CountTextBox = new System.Windows.Forms.TextBox();
            this.uiKuricaKormStep1CountTextBox = new System.Windows.Forms.TextBox();
            this.uiDelayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uiClassicStepCount = new System.Windows.Forms.TextBox();
            this.uiShiftEveryTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.uiClassicRadioButton = new System.Windows.Forms.RadioButton();
            this.mouseMoveClickDelayTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.uiMacrosHistoryControl = new MacrosApp.MacrosHistoryControl();
            this.uiDerevoRadioButton = new System.Windows.Forms.RadioButton();
            this.uiKuricaCustomRadioButton = new System.Windows.Forms.RadioButton();
            this.uiKuricaKormShiftTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.textBox.Location = new System.Drawing.Point(4, 307);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(841, 270);
            this.textBox.TabIndex = 3;
            // 
            // labelMousePosition
            // 
            this.labelMousePosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMousePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMousePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMousePosition.Location = new System.Drawing.Point(4, 272);
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new System.Drawing.Size(831, 23);
            this.labelMousePosition.TabIndex = 2;
            this.labelMousePosition.Text = "labelMousePosition";
            this.labelMousePosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonStop
            // 
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Location = new System.Drawing.Point(85, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.Click += new System.EventHandler(this.ButtonStopClick);
            // 
            // buttonStart
            // 
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(4, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // uiStep1CountTextBox
            // 
            this.uiStep1CountTextBox.Location = new System.Drawing.Point(164, 49);
            this.uiStep1CountTextBox.Name = "uiStep1CountTextBox";
            this.uiStep1CountTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiStep1CountTextBox.TabIndex = 4;
            this.uiStep1CountTextBox.Text = "10";
            // 
            // uiStep2CountTextBox
            // 
            this.uiStep2CountTextBox.Location = new System.Drawing.Point(270, 49);
            this.uiStep2CountTextBox.Name = "uiStep2CountTextBox";
            this.uiStep2CountTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiStep2CountTextBox.TabIndex = 5;
            this.uiStep2CountTextBox.Text = "1";
            // 
            // uiStep1ShiftCountTextBox
            // 
            this.uiStep1ShiftCountTextBox.Location = new System.Drawing.Point(376, 49);
            this.uiStep1ShiftCountTextBox.Name = "uiStep1ShiftCountTextBox";
            this.uiStep1ShiftCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiStep1ShiftCountTextBox.TabIndex = 6;
            this.uiStep1ShiftCountTextBox.Text = "16";
            // 
            // uiStep2ShiftCountTextBox
            // 
            this.uiStep2ShiftCountTextBox.Location = new System.Drawing.Point(482, 49);
            this.uiStep2ShiftCountTextBox.Name = "uiStep2ShiftCountTextBox";
            this.uiStep2ShiftCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiStep2ShiftCountTextBox.TabIndex = 7;
            this.uiStep2ShiftCountTextBox.Text = "8";
            // 
            // twoStepWithShiftRadioButton
            // 
            this.twoStepWithShiftRadioButton.AutoSize = true;
            this.twoStepWithShiftRadioButton.Location = new System.Drawing.Point(4, 50);
            this.twoStepWithShiftRadioButton.Name = "twoStepWithShiftRadioButton";
            this.twoStepWithShiftRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.twoStepWithShiftRadioButton.Size = new System.Drawing.Size(154, 17);
            this.twoStepWithShiftRadioButton.TabIndex = 8;
            this.twoStepWithShiftRadioButton.Text = "2 прохода со смещением";
            this.twoStepWithShiftRadioButton.UseVisualStyleBackColor = true;
            // 
            // uiKuricaKormRadioButton
            // 
            this.uiKuricaKormRadioButton.AutoSize = true;
            this.uiKuricaKormRadioButton.Checked = true;
            this.uiKuricaKormRadioButton.Location = new System.Drawing.Point(60, 109);
            this.uiKuricaKormRadioButton.Name = "uiKuricaKormRadioButton";
            this.uiKuricaKormRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiKuricaKormRadioButton.Size = new System.Drawing.Size(98, 17);
            this.uiKuricaKormRadioButton.TabIndex = 9;
            this.uiKuricaKormRadioButton.TabStop = true;
            this.uiKuricaKormRadioButton.Text = "корм лебедям";
            this.uiKuricaKormRadioButton.UseVisualStyleBackColor = true;
            // 
            // uiKuricaKormStep2CountTextBox
            // 
            this.uiKuricaKormStep2CountTextBox.Location = new System.Drawing.Point(165, 108);
            this.uiKuricaKormStep2CountTextBox.Name = "uiKuricaKormStep2CountTextBox";
            this.uiKuricaKormStep2CountTextBox.Size = new System.Drawing.Size(52, 20);
            this.uiKuricaKormStep2CountTextBox.TabIndex = 10;
            this.uiKuricaKormStep2CountTextBox.Text = "10";
            // 
            // uiKuricaKormStep1CountTextBox
            // 
            this.uiKuricaKormStep1CountTextBox.Location = new System.Drawing.Point(246, 108);
            this.uiKuricaKormStep1CountTextBox.Name = "uiKuricaKormStep1CountTextBox";
            this.uiKuricaKormStep1CountTextBox.Size = new System.Drawing.Size(52, 20);
            this.uiKuricaKormStep1CountTextBox.TabIndex = 11;
            this.uiKuricaKormStep1CountTextBox.Text = "10";
            // 
            // uiDelayTextBox
            // 
            this.uiDelayTextBox.Location = new System.Drawing.Point(685, 209);
            this.uiDelayTextBox.Name = "uiDelayTextBox";
            this.uiDelayTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiDelayTextBox.TabIndex = 12;
            this.uiDelayTextBox.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Количество 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Количество 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "смещение 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "смещение 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "задержка (увеличить интервал между кликами) в";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Количество 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Количество 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Количество 1";
            // 
            // uiClassicStepCount
            // 
            this.uiClassicStepCount.Location = new System.Drawing.Point(168, 169);
            this.uiClassicStepCount.Name = "uiClassicStepCount";
            this.uiClassicStepCount.Size = new System.Drawing.Size(52, 20);
            this.uiClassicStepCount.TabIndex = 21;
            this.uiClassicStepCount.Text = "10";
            // 
            // uiShiftEveryTextBox
            // 
            this.uiShiftEveryTextBox.Location = new System.Drawing.Point(588, 47);
            this.uiShiftEveryTextBox.Name = "uiShiftEveryTextBox";
            this.uiShiftEveryTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiShiftEveryTextBox.TabIndex = 23;
            this.uiShiftEveryTextBox.Text = "3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "смещение каждые";
            // 
            // uiClassicRadioButton
            // 
            this.uiClassicRadioButton.AutoSize = true;
            this.uiClassicRadioButton.Location = new System.Drawing.Point(4, 170);
            this.uiClassicRadioButton.Name = "uiClassicRadioButton";
            this.uiClassicRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiClassicRadioButton.Size = new System.Drawing.Size(154, 17);
            this.uiClassicRadioButton.TabIndex = 25;
            this.uiClassicRadioButton.Text = "повторять без смещения";
            this.uiClassicRadioButton.UseVisualStyleBackColor = true;
            // 
            // mouseMoveClickDelayTextBox
            // 
            this.mouseMoveClickDelayTextBox.Location = new System.Drawing.Point(685, 235);
            this.mouseMoveClickDelayTextBox.Name = "mouseMoveClickDelayTextBox";
            this.mouseMoveClickDelayTextBox.Size = new System.Drawing.Size(100, 20);
            this.mouseMoveClickDelayTextBox.TabIndex = 26;
            this.mouseMoveClickDelayTextBox.Text = "500";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Задержка перед перемещение мышки и кликом";
            // 
            // uiMacrosHistoryControl
            // 
            this.uiMacrosHistoryControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiMacrosHistoryControl.AutoScroll = true;
            this.uiMacrosHistoryControl.Location = new System.Drawing.Point(841, 14);
            this.uiMacrosHistoryControl.Name = "uiMacrosHistoryControl";
            this.uiMacrosHistoryControl.Size = new System.Drawing.Size(377, 554);
            this.uiMacrosHistoryControl.TabIndex = 28;
            // 
            // uiDerevoRadioButton
            // 
            this.uiDerevoRadioButton.AutoSize = true;
            this.uiDerevoRadioButton.Location = new System.Drawing.Point(91, 90);
            this.uiDerevoRadioButton.Name = "uiDerevoRadioButton";
            this.uiDerevoRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiDerevoRadioButton.Size = new System.Drawing.Size(67, 17);
            this.uiDerevoRadioButton.TabIndex = 29;
            this.uiDerevoRadioButton.Text = "деревья";
            this.uiDerevoRadioButton.UseVisualStyleBackColor = true;
            // 
            // uiKuricaCustomRadioButton
            // 
            this.uiKuricaCustomRadioButton.AutoSize = true;
            this.uiKuricaCustomRadioButton.Location = new System.Drawing.Point(304, 109);
            this.uiKuricaCustomRadioButton.Name = "uiKuricaCustomRadioButton";
            this.uiKuricaCustomRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiKuricaCustomRadioButton.Size = new System.Drawing.Size(91, 17);
            this.uiKuricaCustomRadioButton.TabIndex = 30;
            this.uiKuricaCustomRadioButton.Text = "произвольно";
            this.uiKuricaCustomRadioButton.UseVisualStyleBackColor = true;
            // 
            // uiKuricaKormShiftTextBox
            // 
            this.uiKuricaKormShiftTextBox.Location = new System.Drawing.Point(401, 108);
            this.uiKuricaKormShiftTextBox.Name = "uiKuricaKormShiftTextBox";
            this.uiKuricaKormShiftTextBox.Size = new System.Drawing.Size(52, 20);
            this.uiKuricaKormShiftTextBox.TabIndex = 31;
            this.uiKuricaKormShiftTextBox.Text = "48";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(398, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "смещение (деревья 64, курицам 32)";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1230, 580);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.uiKuricaKormShiftTextBox);
            this.Controls.Add(this.uiKuricaCustomRadioButton);
            this.Controls.Add(this.uiDerevoRadioButton);
            this.Controls.Add(this.uiMacrosHistoryControl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mouseMoveClickDelayTextBox);
            this.Controls.Add(this.uiClassicRadioButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uiShiftEveryTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uiClassicStepCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiDelayTextBox);
            this.Controls.Add(this.uiKuricaKormStep1CountTextBox);
            this.Controls.Add(this.uiKuricaKormStep2CountTextBox);
            this.Controls.Add(this.uiKuricaKormRadioButton);
            this.Controls.Add(this.twoStepWithShiftRadioButton);
            this.Controls.Add(this.uiStep2ShiftCountTextBox);
            this.Controls.Add(this.uiStep1ShiftCountTextBox);
            this.Controls.Add(this.uiStep2CountTextBox);
            this.Controls.Add(this.uiStep1CountTextBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelMousePosition);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "MainForm";
            this.Text = "MacrosApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private Button buttonStart;
        private Button buttonStop;
        private Label labelMousePosition;
        private TextBox uiStep1CountTextBox;
        private TextBox uiStep2CountTextBox;
        private TextBox uiStep1ShiftCountTextBox;
        private TextBox uiStep2ShiftCountTextBox;
        private RadioButton twoStepWithShiftRadioButton;
        private RadioButton uiKuricaKormRadioButton;
        private TextBox uiKuricaKormStep2CountTextBox;
        private TextBox uiKuricaKormStep1CountTextBox;
        private TextBox uiDelayTextBox;
        private TextBox textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox uiClassicStepCount;
        private TextBox uiShiftEveryTextBox;
        private Label label9;
        private RadioButton uiClassicRadioButton;
        private TextBox mouseMoveClickDelayTextBox;
        private Label label10;
        private MacrosHistoryControl uiMacrosHistoryControl;
        private RadioButton uiDerevoRadioButton;
        private RadioButton uiKuricaCustomRadioButton;
        private TextBox uiKuricaKormShiftTextBox;
        private Label label11;
    }
}
