namespace PokemonBattleApp
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
            this.btn_Move1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Move4 = new System.Windows.Forms.Button();
            this.btn_Move3 = new System.Windows.Forms.Button();
            this.btn_Move2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Goal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Move1
            // 
            this.btn_Move1.Location = new System.Drawing.Point(6, 19);
            this.btn_Move1.Name = "btn_Move1";
            this.btn_Move1.Size = new System.Drawing.Size(168, 73);
            this.btn_Move1.TabIndex = 0;
            this.btn_Move1.Text = "button1";
            this.btn_Move1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Opponent:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Move4);
            this.groupBox1.Controls.Add(this.btn_Move3);
            this.groupBox1.Controls.Add(this.btn_Move2);
            this.groupBox1.Controls.Add(this.btn_Move1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 178);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Moves";
            // 
            // btn_Move4
            // 
            this.btn_Move4.Location = new System.Drawing.Point(186, 99);
            this.btn_Move4.Name = "btn_Move4";
            this.btn_Move4.Size = new System.Drawing.Size(168, 73);
            this.btn_Move4.TabIndex = 3;
            this.btn_Move4.Text = "button4";
            this.btn_Move4.UseVisualStyleBackColor = true;
            // 
            // btn_Move3
            // 
            this.btn_Move3.Location = new System.Drawing.Point(6, 99);
            this.btn_Move3.Name = "btn_Move3";
            this.btn_Move3.Size = new System.Drawing.Size(168, 73);
            this.btn_Move3.TabIndex = 2;
            this.btn_Move3.Text = "button3";
            this.btn_Move3.UseVisualStyleBackColor = true;
            // 
            // btn_Move2
            // 
            this.btn_Move2.Location = new System.Drawing.Point(186, 19);
            this.btn_Move2.Name = "btn_Move2";
            this.btn_Move2.Size = new System.Drawing.Size(168, 73);
            this.btn_Move2.TabIndex = 1;
            this.btn_Move2.Text = "button2";
            this.btn_Move2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(165, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 207);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Goal:";
            // 
            // lbl_Goal
            // 
            this.lbl_Goal.AutoSize = true;
            this.lbl_Goal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Goal.Location = new System.Drawing.Point(52, 147);
            this.lbl_Goal.Name = "lbl_Goal";
            this.lbl_Goal.Size = new System.Drawing.Size(45, 16);
            this.lbl_Goal.TabIndex = 9;
            this.lbl_Goal.Text = "label3";
            this.lbl_Goal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.lbl_Goal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Move1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Move4;
        private System.Windows.Forms.Button btn_Move3;
        private System.Windows.Forms.Button btn_Move2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Goal;
    }
}

