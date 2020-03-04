namespace DndPlayerDataTest
{
    partial class PlayerView
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
            this.tbXP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAlignment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbXP
            // 
            this.tbXP.Location = new System.Drawing.Point(168, 112);
            this.tbXP.Name = "tbXP";
            this.tbXP.ReadOnly = true;
            this.tbXP.Size = new System.Drawing.Size(144, 20);
            this.tbXP.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "XP";
            // 
            // tbRace
            // 
            this.tbRace.Location = new System.Drawing.Point(168, 70);
            this.tbRace.Name = "tbRace";
            this.tbRace.ReadOnly = true;
            this.tbRace.Size = new System.Drawing.Size(144, 20);
            this.tbRace.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Race";
            // 
            // tbAlignment
            // 
            this.tbAlignment.Location = new System.Drawing.Point(12, 112);
            this.tbAlignment.Name = "tbAlignment";
            this.tbAlignment.ReadOnly = true;
            this.tbAlignment.Size = new System.Drawing.Size(126, 20);
            this.tbAlignment.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Alignment";
            // 
            // tbClass
            // 
            this.tbClass.Location = new System.Drawing.Point(12, 70);
            this.tbClass.Name = "tbClass";
            this.tbClass.ReadOnly = true;
            this.tbClass.Size = new System.Drawing.Size(126, 20);
            this.tbClass.TabIndex = 13;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(12, 54);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 12;
            this.lblClass.Text = "Class";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 24);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(300, 20);
            this.tbName.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(195, 468);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 51);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 531);
            this.Controls.Add(this.btnEdit);
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
            this.Name = "PlayerView";
            this.Text = "PlayerView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerView_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbXP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAlignment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnEdit;
    }
}