namespace WindowsFormsApplication1
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
            this.lblTgt = new System.Windows.Forms.Label();
            this.txtTgt = new System.Windows.Forms.TextBox();
            this.lblChng = new System.Windows.Forms.Label();
            this.txtOldStr = new System.Windows.Forms.TextBox();
            this.lblNewtext = new System.Windows.Forms.Label();
            this.txtNewStr = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtFailed = new System.Windows.Forms.TextBox();
            this.lblFails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTgt
            // 
            this.lblTgt.AutoSize = true;
            this.lblTgt.Location = new System.Drawing.Point(13, 13);
            this.lblTgt.Name = "lblTgt";
            this.lblTgt.Size = new System.Drawing.Size(70, 13);
            this.lblTgt.TabIndex = 0;
            this.lblTgt.Text = "Target Folder";
            // 
            // txtTgt
            // 
            this.txtTgt.Location = new System.Drawing.Point(13, 30);
            this.txtTgt.Name = "txtTgt";
            this.txtTgt.Size = new System.Drawing.Size(515, 20);
            this.txtTgt.TabIndex = 1;
            this.txtTgt.Text = "c:\\example\\";
            // 
            // lblChng
            // 
            this.lblChng.AutoSize = true;
            this.lblChng.Location = new System.Drawing.Point(13, 53);
            this.lblChng.Name = "lblChng";
            this.lblChng.Size = new System.Drawing.Size(141, 13);
            this.lblChng.TabIndex = 4;
            this.lblChng.Text = "What text are we changing?";
            // 
            // txtOldStr
            // 
            this.txtOldStr.Location = new System.Drawing.Point(13, 70);
            this.txtOldStr.Name = "txtOldStr";
            this.txtOldStr.Size = new System.Drawing.Size(515, 20);
            this.txtOldStr.TabIndex = 5;
            // 
            // lblNewtext
            // 
            this.lblNewtext.AutoSize = true;
            this.lblNewtext.Location = new System.Drawing.Point(13, 98);
            this.lblNewtext.Name = "lblNewtext";
            this.lblNewtext.Size = new System.Drawing.Size(149, 13);
            this.lblNewtext.TabIndex = 6;
            this.lblNewtext.Text = "What should the new text be?";
            // 
            // txtNewStr
            // 
            this.txtNewStr.Location = new System.Drawing.Point(13, 114);
            this.txtNewStr.Name = "txtNewStr";
            this.txtNewStr.Size = new System.Drawing.Size(515, 20);
            this.txtNewStr.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(453, 368);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update!";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtFailed
            // 
            this.txtFailed.Enabled = false;
            this.txtFailed.Location = new System.Drawing.Point(12, 153);
            this.txtFailed.Multiline = true;
            this.txtFailed.Name = "txtFailed";
            this.txtFailed.Size = new System.Drawing.Size(516, 209);
            this.txtFailed.TabIndex = 9;
            // 
            // lblFails
            // 
            this.lblFails.AutoSize = true;
            this.lblFails.Location = new System.Drawing.Point(13, 137);
            this.lblFails.Name = "lblFails";
            this.lblFails.Size = new System.Drawing.Size(226, 13);
            this.lblFails.TabIndex = 10;
            this.lblFails.Text = "There were no changes made to the following:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 406);
            this.Controls.Add(this.lblFails);
            this.Controls.Add(this.txtFailed);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewStr);
            this.Controls.Add(this.lblNewtext);
            this.Controls.Add(this.txtOldStr);
            this.Controls.Add(this.lblChng);
            this.Controls.Add(this.txtTgt);
            this.Controls.Add(this.lblTgt);
            this.Name = "Form1";
            this.Text = "GITI Updater!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTgt;
        private System.Windows.Forms.TextBox txtTgt;
        private System.Windows.Forms.Label lblChng;
        private System.Windows.Forms.TextBox txtOldStr;
        private System.Windows.Forms.Label lblNewtext;
        private System.Windows.Forms.TextBox txtNewStr;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtFailed;
        private System.Windows.Forms.Label lblFails;
    }
}

