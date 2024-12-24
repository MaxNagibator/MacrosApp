namespace MacrosApp.Gui
{
    partial class MacrosHistoryControl
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
            this.uiSaveButton = new System.Windows.Forms.Button();
            this.uiLoadButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // uiSaveButton
            // 
            this.uiSaveButton.Location = new System.Drawing.Point(3, 3);
            this.uiSaveButton.Name = "uiSaveButton";
            this.uiSaveButton.Size = new System.Drawing.Size(77, 23);
            this.uiSaveButton.TabIndex = 0;
            this.uiSaveButton.Text = "save";
            this.uiSaveButton.UseVisualStyleBackColor = true;
            this.uiSaveButton.Click += new System.EventHandler(this.uiSaveButton_Click);
            // 
            // uiLoadButton
            // 
            this.uiLoadButton.Location = new System.Drawing.Point(86, 3);
            this.uiLoadButton.Name = "uiLoadButton";
            this.uiLoadButton.Size = new System.Drawing.Size(75, 23);
            this.uiLoadButton.TabIndex = 1;
            this.uiLoadButton.Text = "load";
            this.uiLoadButton.UseVisualStyleBackColor = true;
            this.uiLoadButton.Click += new System.EventHandler(this.uiLoadButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(3, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 286);
            this.panel1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MacrosHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiLoadButton);
            this.Controls.Add(this.uiSaveButton);
            this.Name = "MacrosHistoryControl";
            this.Size = new System.Drawing.Size(520, 321);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiSaveButton;
        private System.Windows.Forms.Button uiLoadButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
