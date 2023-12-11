namespace Calculator1
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
            this.lbA = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.lbB = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(159, 76);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(48, 24);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "Số a";
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbA.Location = new System.Drawing.Point(233, 76);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(137, 26);
            this.tbA.TabIndex = 1;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(159, 132);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(49, 24);
            this.lbB.TabIndex = 0;
            this.lbB.Text = "Số b";
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbB.Location = new System.Drawing.Point(233, 132);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(137, 26);
            this.tbB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết quả";
            // 
            // lbKQ
            // 
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.Location = new System.Drawing.Point(233, 193);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.ReadOnly = true;
            this.lbKQ.Size = new System.Drawing.Size(137, 26);
            this.lbKQ.TabIndex = 1;
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCong.Location = new System.Drawing.Point(55, 257);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(92, 42);
            this.btCong.TabIndex = 2;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lbA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbKQ;
        private System.Windows.Forms.Button btCong;
    }
}

