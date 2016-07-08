namespace RayNotationGenerator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SizeSelect = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SizeSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(12, 12);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(268, 20);
            this.textbox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save As...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Encode);
            // 
            // SizeSelect
            // 
            this.SizeSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.SizeSelect.Location = new System.Drawing.Point(75, 39);
            this.SizeSelect.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SizeSelect.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.SizeSelect.Name = "SizeSelect";
            this.SizeSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SizeSelect.Size = new System.Drawing.Size(57, 20);
            this.SizeSelect.TabIndex = 2;
            this.SizeSelect.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Glyph Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "px";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 67);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizeSelect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textbox);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Ray Notation Generator";
            ((System.ComponentModel.ISupportInitialize)(this.SizeSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown SizeSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

