namespace ToolTipTest
{
    partial class frmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rbMouseMoveMode = new System.Windows.Forms.RadioButton();
            this.rbMouseHoverMode = new System.Windows.Forms.RadioButton();
            this.ucDrawBoard1 = new ToolTipTest.ucDrawBoard();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rbMouseMoveMode);
            this.splitContainer1.Panel1.Controls.Add(this.rbMouseHoverMode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucDrawBoard1);
            this.splitContainer1.Size = new System.Drawing.Size(557, 386);
            this.splitContainer1.SplitterDistance = 36;
            this.splitContainer1.TabIndex = 0;
            // 
            // rbMouseMoveMode
            // 
            this.rbMouseMoveMode.AutoSize = true;
            this.rbMouseMoveMode.Location = new System.Drawing.Point(125, 12);
            this.rbMouseMoveMode.Name = "rbMouseMoveMode";
            this.rbMouseMoveMode.Size = new System.Drawing.Size(95, 16);
            this.rbMouseMoveMode.TabIndex = 0;
            this.rbMouseMoveMode.Text = "鼠标移动模式";
            this.rbMouseMoveMode.UseVisualStyleBackColor = true;
            this.rbMouseMoveMode.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbMouseHoverMode
            // 
            this.rbMouseHoverMode.AutoSize = true;
            this.rbMouseHoverMode.Checked = true;
            this.rbMouseHoverMode.Location = new System.Drawing.Point(12, 12);
            this.rbMouseHoverMode.Name = "rbMouseHoverMode";
            this.rbMouseHoverMode.Size = new System.Drawing.Size(95, 16);
            this.rbMouseHoverMode.TabIndex = 0;
            this.rbMouseHoverMode.TabStop = true;
            this.rbMouseHoverMode.Text = "鼠标悬停模式";
            this.rbMouseHoverMode.UseVisualStyleBackColor = true;
            this.rbMouseHoverMode.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // ucDrawBoard1
            // 
            this.ucDrawBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDrawBoard1.Location = new System.Drawing.Point(0, 0);
            this.ucDrawBoard1.MouseHoverMode = true;
            this.ucDrawBoard1.Name = "ucDrawBoard1";
            this.ucDrawBoard1.Size = new System.Drawing.Size(557, 346);
            this.ucDrawBoard1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 386);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "ToolTip测试";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ucDrawBoard ucDrawBoard1;
        private System.Windows.Forms.RadioButton rbMouseMoveMode;
        private System.Windows.Forms.RadioButton rbMouseHoverMode;
    }
}

