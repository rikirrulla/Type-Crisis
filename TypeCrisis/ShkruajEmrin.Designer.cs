namespace TypeCrisis
{
    partial class ShkruajEmrin
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
            this.components = new System.ComponentModel.Container();
            this.emriLojtarit = new System.Windows.Forms.TextBox();
            this.lbllojaPerfundoi = new Guna.UI.WinForms.GunaLabel();
            this.btnFillo = new Guna.UI.WinForms.GunaButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.SuspendLayout();
            // 
            // emriLojtarit
            // 
            this.emriLojtarit.Font = new System.Drawing.Font("Kiona", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emriLojtarit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emriLojtarit.Location = new System.Drawing.Point(87, 63);
            this.emriLojtarit.Name = "emriLojtarit";
            this.emriLojtarit.Size = new System.Drawing.Size(129, 27);
            this.emriLojtarit.TabIndex = 0;
            // 
            // lbllojaPerfundoi
            // 
            this.lbllojaPerfundoi.AutoSize = true;
            this.lbllojaPerfundoi.Font = new System.Drawing.Font("Kiona", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllojaPerfundoi.ForeColor = System.Drawing.Color.White;
            this.lbllojaPerfundoi.Location = new System.Drawing.Point(34, 66);
            this.lbllojaPerfundoi.Name = "lbllojaPerfundoi";
            this.lbllojaPerfundoi.Size = new System.Drawing.Size(47, 19);
            this.lbllojaPerfundoi.TabIndex = 9;
            this.lbllojaPerfundoi.Text = "Emri";
            this.lbllojaPerfundoi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFillo
            // 
            this.btnFillo.AnimationHoverSpeed = 0.07F;
            this.btnFillo.AnimationSpeed = 0.03F;
            this.btnFillo.BackColor = System.Drawing.Color.White;
            this.btnFillo.BaseColor = System.Drawing.Color.White;
            this.btnFillo.BorderColor = System.Drawing.Color.Black;
            this.btnFillo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFillo.FocusedColor = System.Drawing.Color.Empty;
            this.btnFillo.Font = new System.Drawing.Font("Kiona", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFillo.Image = null;
            this.btnFillo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFillo.Location = new System.Drawing.Point(122, 116);
            this.btnFillo.Name = "btnFillo";
            this.btnFillo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFillo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFillo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFillo.OnHoverImage = null;
            this.btnFillo.OnPressedColor = System.Drawing.Color.Black;
            this.btnFillo.Size = new System.Drawing.Size(94, 33);
            this.btnFillo.TabIndex = 10;
            this.btnFillo.Text = "Shtyp";
            this.btnFillo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFillo.Click += new System.EventHandler(this.btnFillo_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = null;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(242, 1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 11;
            // 
            // ShkruajEmrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(288, 177);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.btnFillo);
            this.Controls.Add(this.lbllojaPerfundoi);
            this.Controls.Add(this.emriLojtarit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShkruajEmrin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lbllojaPerfundoi;
        private Guna.UI.WinForms.GunaButton btnFillo;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        public System.Windows.Forms.TextBox emriLojtarit;
    }
}