namespace TcpClientProject
{
    partial class FormTCPClient
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbData = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(149, 21);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(637, 407);
            this.tbData.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(879, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(176, 490);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(30, 29);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(176, 545);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(29, 29);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "Y";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(176, 607);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(27, 29);
            this.labelZ.TabIndex = 4;
            this.labelZ.Text = "Z";
            // 
            // FormTCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 726);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbData);
            this.Name = "FormTCPClient";
            this.Text = "TcpClient";
            this.Shown += new System.EventHandler(this.FormTCPClient_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelZ;
    }
}

