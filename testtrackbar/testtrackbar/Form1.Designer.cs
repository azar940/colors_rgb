
namespace testtrackbar
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
            this.tbr_r = new System.Windows.Forms.TrackBar();
            this.tbr_g = new System.Windows.Forms.TrackBar();
            this.tbr_b = new System.Windows.Forms.TrackBar();
            this.tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_b)).BeginInit();
            this.SuspendLayout();
            // 
            // tbr_r
            // 
            this.tbr_r.Location = new System.Drawing.Point(72, 16);
            this.tbr_r.Maximum = 255;
            this.tbr_r.Name = "tbr_r";
            this.tbr_r.Size = new System.Drawing.Size(179, 45);
            this.tbr_r.TabIndex = 0;
            this.tbr_r.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbr_r.Scroll += new System.EventHandler(this.tbr_r_Scroll);
            // 
            // tbr_g
            // 
            this.tbr_g.Location = new System.Drawing.Point(72, 67);
            this.tbr_g.Maximum = 255;
            this.tbr_g.Name = "tbr_g";
            this.tbr_g.Size = new System.Drawing.Size(179, 45);
            this.tbr_g.TabIndex = 0;
            this.tbr_g.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbr_g.Scroll += new System.EventHandler(this.tbr_g_Scroll);
            // 
            // tbr_b
            // 
            this.tbr_b.Location = new System.Drawing.Point(72, 118);
            this.tbr_b.Maximum = 255;
            this.tbr_b.Name = "tbr_b";
            this.tbr_b.Size = new System.Drawing.Size(179, 45);
            this.tbr_b.TabIndex = 0;
            this.tbr_b.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbr_b.Scroll += new System.EventHandler(this.tbr_b_Scroll);
            // 
            // tb
            // 
            this.tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb.Font = new System.Drawing.Font("Unispace", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(72, 174);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(167, 31);
            this.tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "RGB :";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(257, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 178);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "B :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "G :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "R :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 217);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.tbr_b);
            this.Controls.Add(this.tbr_g);
            this.Controls.Add(this.tbr_r);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbr_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbr_r;
        private System.Windows.Forms.TrackBar tbr_g;
        private System.Windows.Forms.TrackBar tbr_b;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

