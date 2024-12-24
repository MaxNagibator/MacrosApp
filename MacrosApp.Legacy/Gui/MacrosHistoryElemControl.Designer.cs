namespace MacrosApp
{
    partial class MacrosHistoryElemControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.delayTextBox = new System.Windows.Forms.TextBox();
            this.buttonTextBox = new System.Windows.Forms.TextBox();
            this.uiCountTextBox = new System.Windows.Forms.TextBox();
            this.uiTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(21, 3);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(66, 20);
            this.xTextBox.TabIndex = 0;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(93, 3);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(66, 20);
            this.yTextBox.TabIndex = 1;
            // 
            // delayTextBox
            // 
            this.delayTextBox.Location = new System.Drawing.Point(165, 3);
            this.delayTextBox.Name = "delayTextBox";
            this.delayTextBox.Size = new System.Drawing.Size(66, 20);
            this.delayTextBox.TabIndex = 2;
            // 
            // buttonTextBox
            // 
            this.buttonTextBox.Location = new System.Drawing.Point(237, 3);
            this.buttonTextBox.Name = "buttonTextBox";
            this.buttonTextBox.Size = new System.Drawing.Size(29, 20);
            this.buttonTextBox.TabIndex = 3;
            // 
            // uiCountTextBox
            // 
            this.uiCountTextBox.Location = new System.Drawing.Point(272, 3);
            this.uiCountTextBox.Name = "uiCountTextBox";
            this.uiCountTextBox.Size = new System.Drawing.Size(28, 20);
            this.uiCountTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.uiTypeLabel.AutoSize = true;
            this.uiTypeLabel.Location = new System.Drawing.Point(3, 6);
            this.uiTypeLabel.Name = "label1";
            this.uiTypeLabel.Size = new System.Drawing.Size(14, 13);
            this.uiTypeLabel.TabIndex = 5;
            this.uiTypeLabel.Text = "K";
            // 
            // MacrosHistoryElemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiTypeLabel);
            this.Controls.Add(this.uiCountTextBox);
            this.Controls.Add(this.buttonTextBox);
            this.Controls.Add(this.delayTextBox);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Name = "MacrosHistoryElemControl";
            this.Size = new System.Drawing.Size(312, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox delayTextBox;
        private System.Windows.Forms.TextBox buttonTextBox;
        private System.Windows.Forms.TextBox uiCountTextBox;
        private System.Windows.Forms.Label uiTypeLabel;
    }
}
