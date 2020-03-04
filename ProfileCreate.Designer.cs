namespace DndPlayerDataTest
{
    partial class ProfileCreate
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.tbAlignment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbXP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFinished = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(300, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbClass
            // 
            this.tbClass.Location = new System.Drawing.Point(12, 77);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(126, 20);
            this.tbClass.TabIndex = 3;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(12, 61);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Class";
            // 
            // tbAlignment
            // 
            this.tbAlignment.Location = new System.Drawing.Point(12, 119);
            this.tbAlignment.Name = "tbAlignment";
            this.tbAlignment.Size = new System.Drawing.Size(126, 20);
            this.tbAlignment.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alignment";
            // 
            // tbRace
            // 
            this.tbRace.Location = new System.Drawing.Point(168, 77);
            this.tbRace.Name = "tbRace";
            this.tbRace.Size = new System.Drawing.Size(144, 20);
            this.tbRace.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Race";
            // 
            // tbXP
            // 
            this.tbXP.Location = new System.Drawing.Point(168, 119);
            this.tbXP.Name = "tbXP";
            this.tbXP.Size = new System.Drawing.Size(144, 20);
            this.tbXP.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "XP";
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(114, 490);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(106, 49);
            this.btnFinished.TabIndex = 10;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // ProfileCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 551);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.tbXP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAlignment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Name = "ProfileCreate";
            this.Text = "ProfileCreate";
            this.Load += new System.EventHandler(this.ProfileCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox tbAlignment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbXP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFinished;
    }
}