namespace GuessNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.GTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.TryB = new System.Windows.Forms.Button();
            this.NumberLbl = new System.Windows.Forms.Label();
            this.GuessLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(1, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "GUESS THE NUMBER";
            // 
            // GTb
            // 
            this.GTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(45)))));
            this.GTb.BorderRadius = 10;
            this.GTb.BorderThickness = 3;
            this.GTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GTb.DefaultText = "";
            this.GTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GTb.Location = new System.Drawing.Point(76, 306);
            this.GTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GTb.Name = "GTb";
            this.GTb.PlaceholderText = "";
            this.GTb.SelectedText = "";
            this.GTb.Size = new System.Drawing.Size(514, 78);
            this.GTb.TabIndex = 1;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(-7, 139);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(655, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // TryB
            // 
            this.TryB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(45)))));
            this.TryB.FlatAppearance.BorderSize = 4;
            this.TryB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TryB.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TryB.ForeColor = System.Drawing.Color.White;
            this.TryB.Location = new System.Drawing.Point(219, 415);
            this.TryB.Name = "TryB";
            this.TryB.Size = new System.Drawing.Size(216, 61);
            this.TryB.TabIndex = 3;
            this.TryB.Text = "TRY";
            this.TryB.UseVisualStyleBackColor = false;
            this.TryB.Click += new System.EventHandler(this.TryB_Click);
            // 
            // NumberLbl
            // 
            this.NumberLbl.AutoSize = true;
            this.NumberLbl.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NumberLbl.ForeColor = System.Drawing.Color.White;
            this.NumberLbl.Location = new System.Drawing.Point(39, 210);
            this.NumberLbl.Name = "NumberLbl";
            this.NumberLbl.Size = new System.Drawing.Size(356, 37);
            this.NumberLbl.TabIndex = 4;
            this.NumberLbl.Text = "guess the number between:";
            // 
            // GuessLbl
            // 
            this.GuessLbl.AutoSize = true;
            this.GuessLbl.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GuessLbl.ForeColor = System.Drawing.Color.White;
            this.GuessLbl.Location = new System.Drawing.Point(192, 550);
            this.GuessLbl.Name = "GuessLbl";
            this.GuessLbl.Size = new System.Drawing.Size(231, 28);
            this.GuessLbl.TabIndex = 5;
            this.GuessLbl.Text = "you guessed   :   0 times";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(85)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(647, 648);
            this.Controls.Add(this.GuessLbl);
            this.Controls.Add(this.NumberLbl);
            this.Controls.Add(this.TryB);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.GTb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess The Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox GTb;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Button TryB;
        private System.Windows.Forms.Label NumberLbl;
        private System.Windows.Forms.Label GuessLbl;
    }
}