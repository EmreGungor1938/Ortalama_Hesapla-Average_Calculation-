
namespace Ortalama_Hesapla_Average_Calculation_
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblbut = new System.Windows.Forms.Label();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtBut = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOrt = new System.Windows.Forms.Label();
            this.lblDrm = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(22, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vize Final Hesaplama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vize:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Final:";
            // 
            // lblbut
            // 
            this.lblbut.AutoSize = true;
            this.lblbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbut.Location = new System.Drawing.Point(15, 76);
            this.lblbut.Name = "lblbut";
            this.lblbut.Size = new System.Drawing.Size(106, 24);
            this.lblbut.TabIndex = 2;
            this.lblbut.Text = "Bütünleme:";
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(79, 10);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(134, 20);
            this.txtVize.TabIndex = 3;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(78, 42);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(134, 20);
            this.txtFinal.TabIndex = 4;
            // 
            // txtBut
            // 
            this.txtBut.Location = new System.Drawing.Point(130, 81);
            this.txtBut.Name = "txtBut";
            this.txtBut.Size = new System.Drawing.Size(154, 20);
            this.txtBut.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHesapla);
            this.panel1.Controls.Add(this.txtBut);
            this.panel1.Controls.Add(this.txtFinal);
            this.panel1.Controls.Add(this.txtVize);
            this.panel1.Controls.Add(this.lblbut);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 174);
            this.panel1.TabIndex = 6;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(92, 124);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(141, 30);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDrm);
            this.panel2.Controls.Add(this.lblOrt);
            this.panel2.Location = new System.Drawing.Point(9, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 156);
            this.panel2.TabIndex = 7;
            // 
            // lblOrt
            // 
            this.lblOrt.AutoSize = true;
            this.lblOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrt.Location = new System.Drawing.Point(22, 28);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(105, 25);
            this.lblOrt.TabIndex = 0;
            this.lblOrt.Text = "Ortalama:";
            // 
            // lblDrm
            // 
            this.lblDrm.AutoSize = true;
            this.lblDrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDrm.Location = new System.Drawing.Point(27, 91);
            this.lblDrm.Name = "lblDrm";
            this.lblDrm.Size = new System.Drawing.Size(81, 25);
            this.lblDrm.TabIndex = 1;
            this.lblDrm.Text = "Durum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 427);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
          
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDrm;
        private System.Windows.Forms.Label lblOrt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtBut;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.Label lblbut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

