namespace gradient_panel
{
    partial class Form1
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
            this._4cornergradientpanel1 = new gradient_panel._4cornergradientpanel();
            this.SuspendLayout();
            // 
            // _4cornergradientpanel1
            // 
            this._4cornergradientpanel1.GBottomLeft = System.Drawing.Color.Blue;
            this._4cornergradientpanel1.GBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._4cornergradientpanel1.GTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._4cornergradientpanel1.GTopRight = System.Drawing.Color.Fuchsia;
            this._4cornergradientpanel1.Location = new System.Drawing.Point(3, 12);
            this._4cornergradientpanel1.Name = "_4cornergradientpanel1";
            this._4cornergradientpanel1.Size = new System.Drawing.Size(649, 454);
            this._4cornergradientpanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 498);
            this.Controls.Add(this._4cornergradientpanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private _4cornergradientpanel _4cornergradientpanel1;
    }
}

