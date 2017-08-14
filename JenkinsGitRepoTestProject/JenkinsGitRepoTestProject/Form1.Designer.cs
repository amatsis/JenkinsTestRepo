namespace JenkinsGitRepoTestProject
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
            this.txt_HelloWorld = new System.Windows.Forms.TextBox();
            this.btn_HelloWorld = new System.Windows.Forms.Button();
            this.lbl_HelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_HelloWorld
            // 
            this.txt_HelloWorld.Location = new System.Drawing.Point(12, 73);
            this.txt_HelloWorld.Name = "txt_HelloWorld";
            this.txt_HelloWorld.Size = new System.Drawing.Size(260, 20);
            this.txt_HelloWorld.TabIndex = 0;
            // 
            // btn_HelloWorld
            // 
            this.btn_HelloWorld.Location = new System.Drawing.Point(12, 99);
            this.btn_HelloWorld.Name = "btn_HelloWorld";
            this.btn_HelloWorld.Size = new System.Drawing.Size(260, 23);
            this.btn_HelloWorld.TabIndex = 1;
            this.btn_HelloWorld.Text = "Git Hub Fun!!";
            this.btn_HelloWorld.UseVisualStyleBackColor = true;
            this.btn_HelloWorld.Click += new System.EventHandler(this.btn_HelloWorld_Click);
            // 
            // lbl_HelloWorld
            // 
            this.lbl_HelloWorld.AutoSize = true;
            this.lbl_HelloWorld.Location = new System.Drawing.Point(78, 57);
            this.lbl_HelloWorld.Name = "lbl_HelloWorld";
            this.lbl_HelloWorld.Size = new System.Drawing.Size(124, 13);
            this.lbl_HelloWorld.TabIndex = 2;
            this.lbl_HelloWorld.Text = "i mean isnt this a change";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_HelloWorld);
            this.Controls.Add(this.btn_HelloWorld);
            this.Controls.Add(this.txt_HelloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_HelloWorld;
        private System.Windows.Forms.Button btn_HelloWorld;
        private System.Windows.Forms.Label lbl_HelloWorld;
    }
}

