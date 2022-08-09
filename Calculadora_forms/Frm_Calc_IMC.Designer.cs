namespace Calculadora_forms
{
    partial class Frm_Calc_IMC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Calc_IMC));
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.label_weight = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.label_kgs = new System.Windows.Forms.Label();
            this.label_metros = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(112, 155);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(140, 23);
            this.textBox_weight.TabIndex = 0;
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(112, 195);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(140, 23);
            this.textBox_height.TabIndex = 1;
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Location = new System.Drawing.Point(57, 163);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(35, 15);
            this.label_weight.TabIndex = 2;
            this.label_weight.Text = "Peso:";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(59, 203);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(42, 15);
            this.label_height.TabIndex = 3;
            this.label_height.Text = "Altura:";
            // 
            // label_kgs
            // 
            this.label_kgs.AutoSize = true;
            this.label_kgs.Location = new System.Drawing.Point(253, 163);
            this.label_kgs.Name = "label_kgs";
            this.label_kgs.Size = new System.Drawing.Size(25, 15);
            this.label_kgs.TabIndex = 4;
            this.label_kgs.Text = "kgs";
            // 
            // label_metros
            // 
            this.label_metros.AutoSize = true;
            this.label_metros.Location = new System.Drawing.Point(253, 202);
            this.label_metros.Name = "label_metros";
            this.label_metros.Size = new System.Drawing.Size(24, 15);
            this.label_metros.TabIndex = 5;
            this.label_metros.Text = "cm";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(59, 251);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 6;
            this.btn_calculate.Text = "Calcular";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(205, 251);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(75, 23);
            this.btn_clean.TabIndex = 7;
            this.btn_clean.Text = "Limpar";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.ForeColor = System.Drawing.Color.Purple;
            this.label_title.Location = new System.Drawing.Point(85, 111);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(180, 25);
            this.label_title.TabIndex = 8;
            this.label_title.Text = "Calculadora de IMC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_result.ForeColor = System.Drawing.Color.Purple;
            this.label_result.Location = new System.Drawing.Point(72, 289);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(17, 21);
            this.label_result.TabIndex = 10;
            this.label_result.Text = "*";
            // 
            // Frm_Calc_IMC
            // 
            this.AcceptButton = this.btn_calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 349);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label_metros);
            this.Controls.Add(this.label_kgs);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.textBox_weight);
            this.Name = "Frm_Calc_IMC";
            this.Text = "Calculadora_IMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_weight;
        private TextBox textBox_height;
        private Label label_weight;
        private Label label_height;
        private Label label_kgs;
        private Label label_metros;
        private Button btn_calculate;
        private Button btn_clean;
        private Label label_title;
        private PictureBox pictureBox1;
        private Label label_result;
    }
}