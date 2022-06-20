
namespace sorvete
{
    partial class Form2
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
            this.rdbnormal = new System.Windows.Forms.RadioButton();
            this.rdbchocolate = new System.Windows.Forms.RadioButton();
            this.rdbsundae = new System.Windows.Forms.RadioButton();
            this.btncontinuar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha sua casquinha:";
            // 
            // rdbnormal
            // 
            this.rdbnormal.AutoSize = true;
            this.rdbnormal.BackColor = System.Drawing.Color.Transparent;
            this.rdbnormal.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbnormal.ForeColor = System.Drawing.Color.White;
            this.rdbnormal.Location = new System.Drawing.Point(52, 163);
            this.rdbnormal.Name = "rdbnormal";
            this.rdbnormal.Size = new System.Drawing.Size(222, 34);
            this.rdbnormal.TabIndex = 2;
            this.rdbnormal.TabStop = true;
            this.rdbnormal.Text = "Casquinha Normal ($3)";
            this.rdbnormal.UseVisualStyleBackColor = false;
            // 
            // rdbchocolate
            // 
            this.rdbchocolate.AutoSize = true;
            this.rdbchocolate.BackColor = System.Drawing.Color.Transparent;
            this.rdbchocolate.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbchocolate.ForeColor = System.Drawing.Color.White;
            this.rdbchocolate.Location = new System.Drawing.Point(295, 163);
            this.rdbchocolate.Name = "rdbchocolate";
            this.rdbchocolate.Size = new System.Drawing.Size(297, 34);
            this.rdbchocolate.TabIndex = 3;
            this.rdbchocolate.TabStop = true;
            this.rdbchocolate.Text = "Casquinha Com Chocolate ($5)";
            this.rdbchocolate.UseVisualStyleBackColor = false;
            // 
            // rdbsundae
            // 
            this.rdbsundae.AutoSize = true;
            this.rdbsundae.BackColor = System.Drawing.Color.Transparent;
            this.rdbsundae.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbsundae.ForeColor = System.Drawing.Color.White;
            this.rdbsundae.Location = new System.Drawing.Point(614, 163);
            this.rdbsundae.Name = "rdbsundae";
            this.rdbsundae.Size = new System.Drawing.Size(139, 34);
            this.rdbsundae.TabIndex = 4;
            this.rdbsundae.TabStop = true;
            this.rdbsundae.Text = "Sundae ($7)";
            this.rdbsundae.UseVisualStyleBackColor = false;
            // 
            // btncontinuar
            // 
            this.btncontinuar.BackColor = System.Drawing.Color.DarkGreen;
            this.btncontinuar.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontinuar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncontinuar.Location = new System.Drawing.Point(614, 38);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(132, 66);
            this.btncontinuar.TabIndex = 8;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = false;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnvoltar.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnvoltar.Location = new System.Drawing.Point(52, 38);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(132, 66);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::sorvete.Properties.Resources.casquinha_recheada_png__800x400_subsampling_2;
            this.pictureBox1.Location = new System.Drawing.Point(353, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::sorvete.Properties.Resources.Sorvete_Casquinha_PNG;
            this.pictureBox2.Location = new System.Drawing.Point(52, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(222, 235);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::sorvete.Properties.Resources._65_5e979a623a6fd;
            this.pictureBox3.Location = new System.Drawing.Point(525, 203);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(303, 204);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sorvete.Properties.Resources.lousa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btncontinuar);
            this.Controls.Add(this.rdbsundae);
            this.Controls.Add(this.rdbchocolate);
            this.Controls.Add(this.rdbnormal);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Casquinha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbnormal;
        private System.Windows.Forms.RadioButton rdbchocolate;
        private System.Windows.Forms.RadioButton rdbsundae;
        private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}