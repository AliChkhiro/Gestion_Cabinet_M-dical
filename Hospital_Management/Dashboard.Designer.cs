namespace Hospital_Management
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCount1 = new System.Windows.Forms.Label();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.lblCount3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCount4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 78);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Life Care Hospital Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblCount1);
            this.panel2.Location = new System.Drawing.Point(12, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 163);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblCount2);
            this.panel3.Location = new System.Drawing.Point(322, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 163);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblCount3);
            this.panel4.Location = new System.Drawing.Point(634, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 163);
            this.panel4.TabIndex = 2;
            // 
            // lblCount1
            // 
            this.lblCount1.AutoSize = true;
            this.lblCount1.BackColor = System.Drawing.Color.White;
            this.lblCount1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount1.Location = new System.Drawing.Point(20, 63);
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(22, 23);
            this.lblCount1.TabIndex = 1;
            this.lblCount1.Text = "0";
            // 
            // lblCount2
            // 
            this.lblCount2.AutoSize = true;
            this.lblCount2.BackColor = System.Drawing.Color.White;
            this.lblCount2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount2.Location = new System.Drawing.Point(20, 63);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(22, 23);
            this.lblCount2.TabIndex = 2;
            this.lblCount2.Text = "0";
            // 
            // lblCount3
            // 
            this.lblCount3.AutoSize = true;
            this.lblCount3.BackColor = System.Drawing.Color.White;
            this.lblCount3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount3.Location = new System.Drawing.Point(25, 62);
            this.lblCount3.Name = "lblCount3";
            this.lblCount3.Size = new System.Drawing.Size(22, 23);
            this.lblCount3.TabIndex = 3;
            this.lblCount3.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblCount4);
            this.panel5.Location = new System.Drawing.Point(12, 287);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(302, 163);
            this.panel5.TabIndex = 2;
            // 
            // lblCount4
            // 
            this.lblCount4.AutoSize = true;
            this.lblCount4.BackColor = System.Drawing.Color.White;
            this.lblCount4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount4.Location = new System.Drawing.Point(20, 63);
            this.lblCount4.Name = "lblCount4";
            this.lblCount4.Size = new System.Drawing.Size(22, 23);
            this.lblCount4.TabIndex = 1;
            this.lblCount4.Text = "0";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(953, 471);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCount1;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.Label lblCount3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCount4;
    }
}