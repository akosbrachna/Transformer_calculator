namespace Transformer_calculator
{
    partial class Transformer_calculator_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transformer_calculator_form));
            this.Input_panel = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_area_of_core = new System.Windows.Forms.TextBox();
            this.txt_wire_current_density = new System.Windows.Forms.TextBox();
            this.txt_efficiency = new System.Windows.Forms.TextBox();
            this.txt_frequency = new System.Windows.Forms.TextBox();
            this.txt_magnetic_flux_density = new System.Windows.Forms.TextBox();
            this.txt_secondary_voltage = new System.Windows.Forms.TextBox();
            this.txt_primary_voltage = new System.Windows.Forms.TextBox();
            this.txt_power = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_wire_current_density = new System.Windows.Forms.Label();
            this.label_efficiency = new System.Windows.Forms.Label();
            this.label_frequency = new System.Windows.Forms.Label();
            this.label_magnetic_flux_density = new System.Windows.Forms.Label();
            this.label_secondary_voltage = new System.Windows.Forms.Label();
            this.label_primary_voltage = new System.Windows.Forms.Label();
            this.label_power = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.Input_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Input_panel
            // 
            this.Input_panel.Controls.Add(this.label2);
            this.Input_panel.Controls.Add(this.txt_c);
            this.Input_panel.Controls.Add(this.txt_b);
            this.Input_panel.Controls.Add(this.txt_a);
            this.Input_panel.Controls.Add(this.lbl_c);
            this.Input_panel.Controls.Add(this.lbl_b);
            this.Input_panel.Controls.Add(this.lbl_a);
            this.Input_panel.Controls.Add(this.pictureBox1);
            this.Input_panel.Controls.Add(this.txt_area_of_core);
            this.Input_panel.Controls.Add(this.txt_wire_current_density);
            this.Input_panel.Controls.Add(this.txt_efficiency);
            this.Input_panel.Controls.Add(this.txt_frequency);
            this.Input_panel.Controls.Add(this.txt_magnetic_flux_density);
            this.Input_panel.Controls.Add(this.txt_secondary_voltage);
            this.Input_panel.Controls.Add(this.txt_primary_voltage);
            this.Input_panel.Controls.Add(this.txt_power);
            this.Input_panel.Controls.Add(this.label1);
            this.Input_panel.Controls.Add(this.label_wire_current_density);
            this.Input_panel.Controls.Add(this.label_efficiency);
            this.Input_panel.Controls.Add(this.label_frequency);
            this.Input_panel.Controls.Add(this.label_magnetic_flux_density);
            this.Input_panel.Controls.Add(this.label_secondary_voltage);
            this.Input_panel.Controls.Add(this.label_primary_voltage);
            this.Input_panel.Controls.Add(this.label_power);
            this.Input_panel.Location = new System.Drawing.Point(12, 12);
            this.Input_panel.Name = "Input_panel";
            this.Input_panel.Size = new System.Drawing.Size(740, 367);
            this.Input_panel.TabIndex = 0;
            this.Input_panel.TabStop = false;
            this.Input_panel.Text = "Input";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(41, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Geometry of core - if not given, calculated from Power. a and b are omitted if Co" +
    "re area is given";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(204, 331);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(100, 20);
            this.txt_c.TabIndex = 22;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(203, 279);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 20);
            this.txt_b.TabIndex = 21;
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(203, 253);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(100, 20);
            this.txt_a.TabIndex = 20;
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(160, 334);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(38, 13);
            this.lbl_c.TabIndex = 19;
            this.lbl_c.Text = "c (mm)";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(161, 282);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(36, 13);
            this.lbl_b.TabIndex = 18;
            this.lbl_b.Text = "b (cm)";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(161, 256);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(36, 13);
            this.lbl_a.TabIndex = 17;
            this.lbl_a.Text = "a (cm)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txt_area_of_core
            // 
            this.txt_area_of_core.Location = new System.Drawing.Point(203, 305);
            this.txt_area_of_core.Name = "txt_area_of_core";
            this.txt_area_of_core.Size = new System.Drawing.Size(100, 20);
            this.txt_area_of_core.TabIndex = 15;
            // 
            // txt_wire_current_density
            // 
            this.txt_wire_current_density.Location = new System.Drawing.Point(203, 180);
            this.txt_wire_current_density.Name = "txt_wire_current_density";
            this.txt_wire_current_density.Size = new System.Drawing.Size(100, 20);
            this.txt_wire_current_density.TabIndex = 14;
            this.txt_wire_current_density.Text = "2.3";
            // 
            // txt_efficiency
            // 
            this.txt_efficiency.Location = new System.Drawing.Point(203, 154);
            this.txt_efficiency.Name = "txt_efficiency";
            this.txt_efficiency.Size = new System.Drawing.Size(100, 20);
            this.txt_efficiency.TabIndex = 13;
            this.txt_efficiency.Text = "0.9";
            // 
            // txt_frequency
            // 
            this.txt_frequency.Location = new System.Drawing.Point(203, 128);
            this.txt_frequency.Name = "txt_frequency";
            this.txt_frequency.Size = new System.Drawing.Size(100, 20);
            this.txt_frequency.TabIndex = 12;
            this.txt_frequency.Text = "50";
            // 
            // txt_magnetic_flux_density
            // 
            this.txt_magnetic_flux_density.Location = new System.Drawing.Point(203, 102);
            this.txt_magnetic_flux_density.Name = "txt_magnetic_flux_density";
            this.txt_magnetic_flux_density.Size = new System.Drawing.Size(100, 20);
            this.txt_magnetic_flux_density.TabIndex = 11;
            this.txt_magnetic_flux_density.Text = "1.1";
            // 
            // txt_secondary_voltage
            // 
            this.txt_secondary_voltage.Location = new System.Drawing.Point(203, 76);
            this.txt_secondary_voltage.Name = "txt_secondary_voltage";
            this.txt_secondary_voltage.Size = new System.Drawing.Size(100, 20);
            this.txt_secondary_voltage.TabIndex = 10;
            // 
            // txt_primary_voltage
            // 
            this.txt_primary_voltage.Location = new System.Drawing.Point(203, 50);
            this.txt_primary_voltage.Name = "txt_primary_voltage";
            this.txt_primary_voltage.Size = new System.Drawing.Size(100, 20);
            this.txt_primary_voltage.TabIndex = 9;
            // 
            // txt_power
            // 
            this.txt_power.Location = new System.Drawing.Point(203, 24);
            this.txt_power.Name = "txt_power";
            this.txt_power.Size = new System.Drawing.Size(100, 20);
            this.txt_power.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Core area (cm^2)";
            // 
            // label_wire_current_density
            // 
            this.label_wire_current_density.AutoSize = true;
            this.label_wire_current_density.Location = new System.Drawing.Point(18, 183);
            this.label_wire_current_density.Name = "label_wire_current_density";
            this.label_wire_current_density.Size = new System.Drawing.Size(179, 13);
            this.label_wire_current_density.TabIndex = 6;
            this.label_wire_current_density.Text = "Current density of wire (Amps/mm^2)";
            // 
            // label_efficiency
            // 
            this.label_efficiency.AutoSize = true;
            this.label_efficiency.Location = new System.Drawing.Point(144, 157);
            this.label_efficiency.Name = "label_efficiency";
            this.label_efficiency.Size = new System.Drawing.Size(53, 13);
            this.label_efficiency.TabIndex = 5;
            this.label_efficiency.Text = "Efficiency";
            // 
            // label_frequency
            // 
            this.label_frequency.AutoSize = true;
            this.label_frequency.Location = new System.Drawing.Point(118, 128);
            this.label_frequency.Name = "label_frequency";
            this.label_frequency.Size = new System.Drawing.Size(79, 13);
            this.label_frequency.TabIndex = 4;
            this.label_frequency.Text = "Frequency (Hz)";
            // 
            // label_magnetic_flux_density
            // 
            this.label_magnetic_flux_density.AutoSize = true;
            this.label_magnetic_flux_density.Location = new System.Drawing.Point(75, 105);
            this.label_magnetic_flux_density.Name = "label_magnetic_flux_density";
            this.label_magnetic_flux_density.Size = new System.Drawing.Size(122, 13);
            this.label_magnetic_flux_density.TabIndex = 3;
            this.label_magnetic_flux_density.Text = "Magnetic flux density (T)";
            // 
            // label_secondary_voltage
            // 
            this.label_secondary_voltage.AutoSize = true;
            this.label_secondary_voltage.Location = new System.Drawing.Point(85, 79);
            this.label_secondary_voltage.Name = "label_secondary_voltage";
            this.label_secondary_voltage.Size = new System.Drawing.Size(112, 13);
            this.label_secondary_voltage.TabIndex = 2;
            this.label_secondary_voltage.Text = "Secondary voltage (V)";
            // 
            // label_primary_voltage
            // 
            this.label_primary_voltage.AutoSize = true;
            this.label_primary_voltage.Location = new System.Drawing.Point(102, 53);
            this.label_primary_voltage.Name = "label_primary_voltage";
            this.label_primary_voltage.Size = new System.Drawing.Size(95, 13);
            this.label_primary_voltage.TabIndex = 1;
            this.label_primary_voltage.Text = "Primary voltage (V)";
            // 
            // label_power
            // 
            this.label_power.AutoSize = true;
            this.label_power.Location = new System.Drawing.Point(137, 27);
            this.label_power.Name = "label_power";
            this.label_power.Size = new System.Drawing.Size(60, 13);
            this.label_power.TabIndex = 0;
            this.label_power.Text = "Power (VA)";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn_calculate.Location = new System.Drawing.Point(12, 385);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(150, 56);
            this.btn_calculate.TabIndex = 1;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // Transformer_calculator_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 446);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.Input_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Transformer_calculator_form";
            this.Text = "Transformer calculator";
            this.Input_panel.ResumeLayout(false);
            this.Input_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Input_panel;
        private System.Windows.Forms.TextBox txt_area_of_core;
        private System.Windows.Forms.TextBox txt_wire_current_density;
        private System.Windows.Forms.TextBox txt_efficiency;
        private System.Windows.Forms.TextBox txt_frequency;
        private System.Windows.Forms.TextBox txt_magnetic_flux_density;
        private System.Windows.Forms.TextBox txt_secondary_voltage;
        private System.Windows.Forms.TextBox txt_primary_voltage;
        private System.Windows.Forms.TextBox txt_power;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_wire_current_density;
        private System.Windows.Forms.Label label_efficiency;
        private System.Windows.Forms.Label label_frequency;
        private System.Windows.Forms.Label label_magnetic_flux_density;
        private System.Windows.Forms.Label label_secondary_voltage;
        private System.Windows.Forms.Label label_primary_voltage;
        private System.Windows.Forms.Label label_power;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

