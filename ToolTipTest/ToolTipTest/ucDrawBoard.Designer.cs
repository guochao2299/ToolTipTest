namespace ToolTipTest
{
    partial class ucDrawBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tipMsg = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ucDrawBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucDrawBoard";
            this.Size = new System.Drawing.Size(277, 229);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ucDrawBoard_Paint);
            this.MouseHover += new System.EventHandler(this.ucDrawBoard_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucDrawBoard_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip tipMsg;
    }
}
