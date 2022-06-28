namespace CarRental
{
    partial class Form_Add_Update
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
            this.button_AddNewCar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Color = new System.Windows.Forms.ComboBox();
            this.comboBox_Brand = new System.Windows.Forms.ComboBox();
            this.textBox_ModelYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_DailyPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_AddNewCar
            // 
            this.button_AddNewCar.Location = new System.Drawing.Point(286, 263);
            this.button_AddNewCar.Name = "button_AddNewCar";
            this.button_AddNewCar.Size = new System.Drawing.Size(107, 40);
            this.button_AddNewCar.TabIndex = 12;
            this.button_AddNewCar.Text = "Add New Car";
            this.button_AddNewCar.UseVisualStyleBackColor = true;
            this.button_AddNewCar.Click += new System.EventHandler(this.button_AddNewCar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Brand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Model Name:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(242, 79);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(151, 27);
            this.textBox_Name.TabIndex = 10;
            // 
            // comboBox_Color
            // 
            this.comboBox_Color.FormattingEnabled = true;
            this.comboBox_Color.Location = new System.Drawing.Point(242, 148);
            this.comboBox_Color.Name = "comboBox_Color";
            this.comboBox_Color.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Color.TabIndex = 9;
            // 
            // comboBox_Brand
            // 
            this.comboBox_Brand.FormattingEnabled = true;
            this.comboBox_Brand.Location = new System.Drawing.Point(242, 114);
            this.comboBox_Brand.Name = "comboBox_Brand";
            this.comboBox_Brand.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Brand.TabIndex = 8;
            // 
            // textBox_ModelYear
            // 
            this.textBox_ModelYear.Location = new System.Drawing.Point(242, 182);
            this.textBox_ModelYear.Name = "textBox_ModelYear";
            this.textBox_ModelYear.Size = new System.Drawing.Size(151, 27);
            this.textBox_ModelYear.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Model Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Daily Price:";
            // 
            // textBox_DailyPrice
            // 
            this.textBox_DailyPrice.Location = new System.Drawing.Point(242, 215);
            this.textBox_DailyPrice.Name = "textBox_DailyPrice";
            this.textBox_DailyPrice.Size = new System.Drawing.Size(151, 27);
            this.textBox_DailyPrice.TabIndex = 18;
            // 
            // Form_Add_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_DailyPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ModelYear);
            this.Controls.Add(this.button_AddNewCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.comboBox_Color);
            this.Controls.Add(this.comboBox_Brand);
            this.Name = "Form_Add_Update";
            this.Text = "Form_Add_Update";
            this.Load += new System.EventHandler(this.Form_Add_Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_AddNewCar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox_Name;
        private ComboBox comboBox_Color;
        private ComboBox comboBox_Brand;
        private TextBox textBox_ModelYear;
        private Label label4;
        private Label label5;
        private TextBox textBox_DailyPrice;
    }
}