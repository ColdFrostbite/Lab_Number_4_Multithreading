namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.bt_calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sizeA = new System.Windows.Forms.TextBox();
            this.tb_sizeB = new System.Windows.Forms.TextBox();
            this.bt_height = new System.Windows.Forms.TextBox();
            this.bt_layer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.bt_sbros = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.volumeGround = new System.Windows.Forms.Label();
            this.amountGround = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_calculate
            // 
            this.bt_calculate.BackColor = System.Drawing.Color.Salmon;
            this.bt_calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_calculate.Location = new System.Drawing.Point(33, 193);
            this.bt_calculate.Margin = new System.Windows.Forms.Padding(4);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(152, 87);
            this.bt_calculate.TabIndex = 1;
            this.bt_calculate.Text = "Расчет";
            this.bt_calculate.UseVisualStyleBackColor = false;
            this.bt_calculate.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размер А";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_sizeA
            // 
            this.bt_sizeA.Location = new System.Drawing.Point(53, 44);
            this.bt_sizeA.Margin = new System.Windows.Forms.Padding(4);
            this.bt_sizeA.Name = "bt_sizeA";
            this.bt_sizeA.Size = new System.Drawing.Size(132, 22);
            this.bt_sizeA.TabIndex = 4;
            // 
            // tb_sizeB
            // 
            this.tb_sizeB.Location = new System.Drawing.Point(53, 74);
            this.tb_sizeB.Margin = new System.Windows.Forms.Padding(4);
            this.tb_sizeB.Name = "tb_sizeB";
            this.tb_sizeB.Size = new System.Drawing.Size(132, 22);
            this.tb_sizeB.TabIndex = 5;
            // 
            // bt_height
            // 
            this.bt_height.Location = new System.Drawing.Point(53, 104);
            this.bt_height.Margin = new System.Windows.Forms.Padding(4);
            this.bt_height.Name = "bt_height";
            this.bt_height.Size = new System.Drawing.Size(132, 22);
            this.bt_height.TabIndex = 6;
            // 
            // bt_layer
            // 
            this.bt_layer.Location = new System.Drawing.Point(53, 134);
            this.bt_layer.Margin = new System.Windows.Forms.Padding(4);
            this.bt_layer.Name = "bt_layer";
            this.bt_layer.Size = new System.Drawing.Size(132, 22);
            this.bt_layer.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Размер B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Высота";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Слой грунта";
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.Location = new System.Drawing.Point(30, 326);
            this.volume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(16, 17);
            this.volume.TabIndex = 11;
            this.volume.Text = "0";
            // 
            // bt_sbros
            // 
            this.bt_sbros.BackColor = System.Drawing.Color.Salmon;
            this.bt_sbros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_sbros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_sbros.Location = new System.Drawing.Point(193, 193);
            this.bt_sbros.Margin = new System.Windows.Forms.Padding(4);
            this.bt_sbros.Name = "bt_sbros";
            this.bt_sbros.Size = new System.Drawing.Size(152, 87);
            this.bt_sbros.TabIndex = 12;
            this.bt_sbros.Text = "Сброс";
            this.bt_sbros.UseVisualStyleBackColor = false;
            this.bt_sbros.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Объем";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Объем грунта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 379);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Кол-во грунта";
            // 
            // volumeGround
            // 
            this.volumeGround.AutoSize = true;
            this.volumeGround.Location = new System.Drawing.Point(30, 352);
            this.volumeGround.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volumeGround.Name = "volumeGround";
            this.volumeGround.Size = new System.Drawing.Size(16, 17);
            this.volumeGround.TabIndex = 16;
            this.volumeGround.Text = "0";
            // 
            // amountGround
            // 
            this.amountGround.AutoSize = true;
            this.amountGround.Location = new System.Drawing.Point(30, 379);
            this.amountGround.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountGround.Name = "amountGround";
            this.amountGround.Size = new System.Drawing.Size(16, 17);
            this.amountGround.TabIndex = 17;
            this.amountGround.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(404, 417);
            this.Controls.Add(this.amountGround);
            this.Controls.Add(this.volumeGround);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_sbros);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_layer);
            this.Controls.Add(this.bt_height);
            this.Controls.Add(this.tb_sizeB);
            this.Controls.Add(this.bt_sizeA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_calculate);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bt_sizeA;
        private System.Windows.Forms.TextBox tb_sizeB;
        private System.Windows.Forms.TextBox bt_height;
        private System.Windows.Forms.TextBox bt_layer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Button bt_sbros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label volumeGround;
        private System.Windows.Forms.Label amountGround;
    }
}

