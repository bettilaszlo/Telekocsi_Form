namespace Telekocsi_Form
{
    partial class FrmFo
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
            this.btn = new System.Windows.Forms.Button();
            this.lbKimenet = new System.Windows.Forms.ListBox();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnThird = new System.Windows.Forms.Button();
            this.btnFourth = new System.Windows.Forms.Button();
            this.btnFifht = new System.Windows.Forms.Button();
            this.btnsixth = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(12, 19);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(103, 35);
            this.btn.TabIndex = 0;
            this.btn.Text = "Beolvasás";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbKimenet
            // 
            this.lbKimenet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKimenet.FormattingEnabled = true;
            this.lbKimenet.ItemHeight = 16;
            this.lbKimenet.Location = new System.Drawing.Point(143, 60);
            this.lbKimenet.Name = "lbKimenet";
            this.lbKimenet.Size = new System.Drawing.Size(411, 292);
            this.lbKimenet.TabIndex = 1;
            // 
            // btnSecond
            // 
            this.btnSecond.Enabled = false;
            this.btnSecond.Location = new System.Drawing.Point(12, 60);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(103, 35);
            this.btnSecond.TabIndex = 2;
            this.btnSecond.Text = "2. feladat";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // btnThird
            // 
            this.btnThird.Enabled = false;
            this.btnThird.Location = new System.Drawing.Point(12, 101);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(103, 33);
            this.btnThird.TabIndex = 3;
            this.btnThird.Text = "3. feladat";
            this.btnThird.UseVisualStyleBackColor = true;
            this.btnThird.Click += new System.EventHandler(this.btnThird_Click);
            // 
            // btnFourth
            // 
            this.btnFourth.Enabled = false;
            this.btnFourth.Location = new System.Drawing.Point(12, 138);
            this.btnFourth.Name = "btnFourth";
            this.btnFourth.Size = new System.Drawing.Size(103, 35);
            this.btnFourth.TabIndex = 4;
            this.btnFourth.Text = "4. feladat";
            this.btnFourth.UseVisualStyleBackColor = true;
            this.btnFourth.Click += new System.EventHandler(this.btnFourth_Click);
            // 
            // btnFifht
            // 
            this.btnFifht.Enabled = false;
            this.btnFifht.Location = new System.Drawing.Point(12, 179);
            this.btnFifht.Name = "btnFifht";
            this.btnFifht.Size = new System.Drawing.Size(103, 35);
            this.btnFifht.TabIndex = 5;
            this.btnFifht.Text = "5. feladat";
            this.btnFifht.UseVisualStyleBackColor = true;
            this.btnFifht.Click += new System.EventHandler(this.btnFifht_Click);
            // 
            // btnsixth
            // 
            this.btnsixth.Enabled = false;
            this.btnsixth.Location = new System.Drawing.Point(12, 220);
            this.btnsixth.Name = "btnsixth";
            this.btnsixth.Size = new System.Drawing.Size(103, 35);
            this.btnsixth.TabIndex = 6;
            this.btnsixth.Text = "6. feladat";
            this.btnsixth.UseVisualStyleBackColor = true;
            this.btnsixth.Click += new System.EventHandler(this.btnsixth_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(12, 294);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(117, 55);
            this.btnKilep.TabIndex = 7;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "A feladatok kimenete:";
            // 
            // FrmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnsixth);
            this.Controls.Add(this.btnFifht);
            this.Controls.Add(this.btnFourth);
            this.Controls.Add(this.btnThird);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.lbKimenet);
            this.Controls.Add(this.btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telekocsi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListBox lbKimenet;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnThird;
        private System.Windows.Forms.Button btnFourth;
        private System.Windows.Forms.Button btnFifht;
        private System.Windows.Forms.Button btnsixth;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Label label1;
    }
}

