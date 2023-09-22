namespace Bolum1_Uygulama16
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.turkceDogru = new System.Windows.Forms.TextBox();
            this.turkceYanlıs = new System.Windows.Forms.TextBox();
            this.turkceNet = new System.Windows.Forms.TextBox();
            this.matDogru = new System.Windows.Forms.TextBox();
            this.matYanlis = new System.Windows.Forms.TextBox();
            this.matNet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Türkçe (40 Soru)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matematik (40 Soru)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(241, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(369, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yanlış";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(508, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Net";
            // 
            // turkceDogru
            // 
            this.turkceDogru.Location = new System.Drawing.Point(246, 95);
            this.turkceDogru.Name = "turkceDogru";
            this.turkceDogru.Size = new System.Drawing.Size(60, 20);
            this.turkceDogru.TabIndex = 5;
            // 
            // turkceYanlıs
            // 
            this.turkceYanlıs.Location = new System.Drawing.Point(374, 95);
            this.turkceYanlıs.Name = "turkceYanlıs";
            this.turkceYanlıs.Size = new System.Drawing.Size(60, 20);
            this.turkceYanlıs.TabIndex = 6;
            // 
            // turkceNet
            // 
            this.turkceNet.Location = new System.Drawing.Point(501, 94);
            this.turkceNet.Name = "turkceNet";
            this.turkceNet.ReadOnly = true;
            this.turkceNet.Size = new System.Drawing.Size(60, 20);
            this.turkceNet.TabIndex = 7;
            // 
            // matDogru
            // 
            this.matDogru.Location = new System.Drawing.Point(246, 172);
            this.matDogru.Name = "matDogru";
            this.matDogru.Size = new System.Drawing.Size(60, 20);
            this.matDogru.TabIndex = 8;
            // 
            // matYanlis
            // 
            this.matYanlis.Location = new System.Drawing.Point(374, 172);
            this.matYanlis.Name = "matYanlis";
            this.matYanlis.Size = new System.Drawing.Size(60, 20);
            this.matYanlis.TabIndex = 9;
            // 
            // matNet
            // 
            this.matNet.Location = new System.Drawing.Point(501, 172);
            this.matNet.Name = "matNet";
            this.matNet.ReadOnly = true;
            this.matNet.Size = new System.Drawing.Size(60, 20);
            this.matNet.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(246, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Net Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matNet);
            this.Controls.Add(this.matYanlis);
            this.Controls.Add(this.matDogru);
            this.Controls.Add(this.turkceNet);
            this.Controls.Add(this.turkceYanlıs);
            this.Controls.Add(this.turkceDogru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox turkceDogru;
        private System.Windows.Forms.TextBox turkceYanlıs;
        private System.Windows.Forms.TextBox turkceNet;
        private System.Windows.Forms.TextBox matDogru;
        private System.Windows.Forms.TextBox matYanlis;
        private System.Windows.Forms.TextBox matNet;
        private System.Windows.Forms.Button button1;
    }
}

