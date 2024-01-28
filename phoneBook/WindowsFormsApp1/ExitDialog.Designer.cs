
namespace WindowsFormsApp1
{
    partial class ExitDialog
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
            this.buttonYes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonYes
            // 
            this.buttonYes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonYes.Location = new System.Drawing.Point(12, 46);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(162, 48);
            this.buttonYes.TabIndex = 0;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Save changes?";
            // 
            // buttonNo
            // 
            this.buttonNo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonNo.Location = new System.Drawing.Point(180, 46);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(162, 48);
            this.buttonNo.TabIndex = 2;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // ExitDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 110);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExitDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExitDialog";
            this.Load += new System.EventHandler(this.ExitDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNo;
    }
}