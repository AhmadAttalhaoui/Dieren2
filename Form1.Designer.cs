namespace Dieren2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbKoe = new System.Windows.Forms.CheckBox();
            this.cbVarken = new System.Windows.Forms.CheckBox();
            this.cbSlang = new System.Windows.Forms.CheckBox();
            this.btHoren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKoe
            // 
            this.cbKoe.AutoSize = true;
            this.cbKoe.Location = new System.Drawing.Point(196, 114);
            this.cbKoe.Name = "cbKoe";
            this.cbKoe.Size = new System.Drawing.Size(57, 24);
            this.cbKoe.TabIndex = 0;
            this.cbKoe.Text = "Koe";
            this.cbKoe.UseVisualStyleBackColor = true;
            // 
            // cbVarken
            // 
            this.cbVarken.AutoSize = true;
            this.cbVarken.Location = new System.Drawing.Point(410, 114);
            this.cbVarken.Name = "cbVarken";
            this.cbVarken.Size = new System.Drawing.Size(75, 24);
            this.cbVarken.TabIndex = 1;
            this.cbVarken.Text = "Varken";
            this.cbVarken.UseVisualStyleBackColor = true;
            // 
            // cbSlang
            // 
            this.cbSlang.AutoSize = true;
            this.cbSlang.Location = new System.Drawing.Point(303, 114);
            this.cbSlang.Name = "cbSlang";
            this.cbSlang.Size = new System.Drawing.Size(68, 24);
            this.cbSlang.TabIndex = 2;
            this.cbSlang.Text = "Slang";
            this.cbSlang.UseVisualStyleBackColor = true;
            // 
            // btHoren
            // 
            this.btHoren.Location = new System.Drawing.Point(196, 155);
            this.btHoren.Name = "btHoren";
            this.btHoren.Size = new System.Drawing.Size(315, 29);
            this.btHoren.TabIndex = 3;
            this.btHoren.Text = "Laat Horen";
            this.btHoren.UseVisualStyleBackColor = true;
            this.btHoren.Click += new System.EventHandler(this.btHoren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btHoren);
            this.Controls.Add(this.cbSlang);
            this.Controls.Add(this.cbVarken);
            this.Controls.Add(this.cbKoe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbKoe;
        private System.Windows.Forms.CheckBox cbVarken;
        private System.Windows.Forms.CheckBox cbSlang;
        private System.Windows.Forms.Button btHoren;
    }
}

