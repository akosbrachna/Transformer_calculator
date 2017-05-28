namespace Transformer_calculator
{
    partial class Result_Form
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
            this.panel_pri_result = new System.Windows.Forms.GroupBox();
            this.cbox_standard_diameter_primary = new System.Windows.Forms.ComboBox();
            this.lbl_standard_diameter_primary = new System.Windows.Forms.Label();
            this.txt_width_primary = new System.Windows.Forms.TextBox();
            this.txt_layers_primary = new System.Windows.Forms.TextBox();
            this.txt_diameter_primary = new System.Windows.Forms.TextBox();
            this.txt_turns_primary = new System.Windows.Forms.TextBox();
            this.lbl_width_primary = new System.Windows.Forms.Label();
            this.lbl_layers_primary = new System.Windows.Forms.Label();
            this.lbl_diameter_primary = new System.Windows.Forms.Label();
            this.lbl_turns_primary = new System.Windows.Forms.Label();
            this.lbl_width_secondary = new System.Windows.Forms.Label();
            this.lbl_layers_secondary = new System.Windows.Forms.Label();
            this.lbl_diameter_secondary = new System.Windows.Forms.Label();
            this.lbl_turns_secondary = new System.Windows.Forms.Label();
            this.panel_sec_result = new System.Windows.Forms.GroupBox();
            this.cbox_standard_diameter_secondary = new System.Windows.Forms.ComboBox();
            this.lbl_standard_diameter_secondary = new System.Windows.Forms.Label();
            this.txt_width_secondary = new System.Windows.Forms.TextBox();
            this.txt_layers_secondary = new System.Windows.Forms.TextBox();
            this.txt_diameter_secondary = new System.Windows.Forms.TextBox();
            this.txt_turns_secondary = new System.Windows.Forms.TextBox();
            this.geometry_panel = new System.Windows.Forms.GroupBox();
            this.txt_core_area = new System.Windows.Forms.TextBox();
            this.lbl_core_area = new System.Windows.Forms.Label();
            this.panel_pri_result.SuspendLayout();
            this.panel_sec_result.SuspendLayout();
            this.geometry_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_pri_result
            // 
            this.panel_pri_result.Controls.Add(this.cbox_standard_diameter_primary);
            this.panel_pri_result.Controls.Add(this.lbl_standard_diameter_primary);
            this.panel_pri_result.Controls.Add(this.txt_width_primary);
            this.panel_pri_result.Controls.Add(this.txt_layers_primary);
            this.panel_pri_result.Controls.Add(this.txt_diameter_primary);
            this.panel_pri_result.Controls.Add(this.txt_turns_primary);
            this.panel_pri_result.Controls.Add(this.lbl_width_primary);
            this.panel_pri_result.Controls.Add(this.lbl_layers_primary);
            this.panel_pri_result.Controls.Add(this.lbl_diameter_primary);
            this.panel_pri_result.Controls.Add(this.lbl_turns_primary);
            this.panel_pri_result.Location = new System.Drawing.Point(12, 12);
            this.panel_pri_result.Name = "panel_pri_result";
            this.panel_pri_result.Size = new System.Drawing.Size(252, 172);
            this.panel_pri_result.TabIndex = 0;
            this.panel_pri_result.TabStop = false;
            this.panel_pri_result.Text = "Primary winding";
            // 
            // cbox_standard_diameter_primary
            // 
            this.cbox_standard_diameter_primary.FormattingEnabled = true;
            this.cbox_standard_diameter_primary.Location = new System.Drawing.Point(133, 79);
            this.cbox_standard_diameter_primary.Name = "cbox_standard_diameter_primary";
            this.cbox_standard_diameter_primary.Size = new System.Drawing.Size(100, 21);
            this.cbox_standard_diameter_primary.TabIndex = 3;
            this.cbox_standard_diameter_primary.SelectedIndexChanged += new System.EventHandler(this.cbox_standard_diameter_primary_SelectedIndexChanged);
            // 
            // lbl_standard_diameter_primary
            // 
            this.lbl_standard_diameter_primary.AutoSize = true;
            this.lbl_standard_diameter_primary.Location = new System.Drawing.Point(9, 82);
            this.lbl_standard_diameter_primary.Name = "lbl_standard_diameter_primary";
            this.lbl_standard_diameter_primary.Size = new System.Drawing.Size(118, 13);
            this.lbl_standard_diameter_primary.TabIndex = 3;
            this.lbl_standard_diameter_primary.Text = "Standard diameter (mm)";
            // 
            // txt_width_primary
            // 
            this.txt_width_primary.Location = new System.Drawing.Point(133, 132);
            this.txt_width_primary.Name = "txt_width_primary";
            this.txt_width_primary.ReadOnly = true;
            this.txt_width_primary.Size = new System.Drawing.Size(100, 20);
            this.txt_width_primary.TabIndex = 7;
            // 
            // txt_layers_primary
            // 
            this.txt_layers_primary.Location = new System.Drawing.Point(133, 106);
            this.txt_layers_primary.Name = "txt_layers_primary";
            this.txt_layers_primary.ReadOnly = true;
            this.txt_layers_primary.Size = new System.Drawing.Size(100, 20);
            this.txt_layers_primary.TabIndex = 6;
            // 
            // txt_diameter_primary
            // 
            this.txt_diameter_primary.Location = new System.Drawing.Point(133, 53);
            this.txt_diameter_primary.Name = "txt_diameter_primary";
            this.txt_diameter_primary.Size = new System.Drawing.Size(100, 20);
            this.txt_diameter_primary.TabIndex = 5;
            // 
            // txt_turns_primary
            // 
            this.txt_turns_primary.Location = new System.Drawing.Point(133, 27);
            this.txt_turns_primary.Name = "txt_turns_primary";
            this.txt_turns_primary.ReadOnly = true;
            this.txt_turns_primary.Size = new System.Drawing.Size(100, 20);
            this.txt_turns_primary.TabIndex = 4;
            // 
            // lbl_width_primary
            // 
            this.lbl_width_primary.AutoSize = true;
            this.lbl_width_primary.Location = new System.Drawing.Point(25, 135);
            this.lbl_width_primary.Name = "lbl_width_primary";
            this.lbl_width_primary.Size = new System.Drawing.Size(102, 13);
            this.lbl_width_primary.TabIndex = 3;
            this.lbl_width_primary.Text = "Width of layers (mm)";
            // 
            // lbl_layers_primary
            // 
            this.lbl_layers_primary.AutoSize = true;
            this.lbl_layers_primary.Location = new System.Drawing.Point(41, 109);
            this.lbl_layers_primary.Name = "lbl_layers_primary";
            this.lbl_layers_primary.Size = new System.Drawing.Size(86, 13);
            this.lbl_layers_primary.TabIndex = 2;
            this.lbl_layers_primary.Text = "Number of layers";
            // 
            // lbl_diameter_primary
            // 
            this.lbl_diameter_primary.AutoSize = true;
            this.lbl_diameter_primary.Location = new System.Drawing.Point(19, 56);
            this.lbl_diameter_primary.Name = "lbl_diameter_primary";
            this.lbl_diameter_primary.Size = new System.Drawing.Size(108, 13);
            this.lbl_diameter_primary.TabIndex = 1;
            this.lbl_diameter_primary.Text = "Diameter of wire (mm)";
            // 
            // lbl_turns_primary
            // 
            this.lbl_turns_primary.AutoSize = true;
            this.lbl_turns_primary.Location = new System.Drawing.Point(45, 30);
            this.lbl_turns_primary.Name = "lbl_turns_primary";
            this.lbl_turns_primary.Size = new System.Drawing.Size(82, 13);
            this.lbl_turns_primary.TabIndex = 0;
            this.lbl_turns_primary.Text = "Number of turns";
            // 
            // lbl_width_secondary
            // 
            this.lbl_width_secondary.AutoSize = true;
            this.lbl_width_secondary.Location = new System.Drawing.Point(27, 135);
            this.lbl_width_secondary.Name = "lbl_width_secondary";
            this.lbl_width_secondary.Size = new System.Drawing.Size(102, 13);
            this.lbl_width_secondary.TabIndex = 7;
            this.lbl_width_secondary.Text = "Width of layers (mm)";
            // 
            // lbl_layers_secondary
            // 
            this.lbl_layers_secondary.AutoSize = true;
            this.lbl_layers_secondary.Location = new System.Drawing.Point(43, 109);
            this.lbl_layers_secondary.Name = "lbl_layers_secondary";
            this.lbl_layers_secondary.Size = new System.Drawing.Size(86, 13);
            this.lbl_layers_secondary.TabIndex = 6;
            this.lbl_layers_secondary.Text = "Number of layers";
            // 
            // lbl_diameter_secondary
            // 
            this.lbl_diameter_secondary.AutoSize = true;
            this.lbl_diameter_secondary.Location = new System.Drawing.Point(22, 56);
            this.lbl_diameter_secondary.Name = "lbl_diameter_secondary";
            this.lbl_diameter_secondary.Size = new System.Drawing.Size(108, 13);
            this.lbl_diameter_secondary.TabIndex = 5;
            this.lbl_diameter_secondary.Text = "Diameter of wire (mm)";
            // 
            // lbl_turns_secondary
            // 
            this.lbl_turns_secondary.AutoSize = true;
            this.lbl_turns_secondary.Location = new System.Drawing.Point(48, 30);
            this.lbl_turns_secondary.Name = "lbl_turns_secondary";
            this.lbl_turns_secondary.Size = new System.Drawing.Size(82, 13);
            this.lbl_turns_secondary.TabIndex = 4;
            this.lbl_turns_secondary.Text = "Number of turns";
            // 
            // panel_sec_result
            // 
            this.panel_sec_result.Controls.Add(this.cbox_standard_diameter_secondary);
            this.panel_sec_result.Controls.Add(this.lbl_standard_diameter_secondary);
            this.panel_sec_result.Controls.Add(this.txt_width_secondary);
            this.panel_sec_result.Controls.Add(this.txt_layers_secondary);
            this.panel_sec_result.Controls.Add(this.txt_diameter_secondary);
            this.panel_sec_result.Controls.Add(this.txt_turns_secondary);
            this.panel_sec_result.Controls.Add(this.lbl_width_secondary);
            this.panel_sec_result.Controls.Add(this.lbl_turns_secondary);
            this.panel_sec_result.Controls.Add(this.lbl_layers_secondary);
            this.panel_sec_result.Controls.Add(this.lbl_diameter_secondary);
            this.panel_sec_result.Location = new System.Drawing.Point(270, 12);
            this.panel_sec_result.Name = "panel_sec_result";
            this.panel_sec_result.Size = new System.Drawing.Size(249, 172);
            this.panel_sec_result.TabIndex = 1;
            this.panel_sec_result.TabStop = false;
            this.panel_sec_result.Text = "Secondary winding";
            // 
            // cbox_standard_diameter_secondary
            // 
            this.cbox_standard_diameter_secondary.FormattingEnabled = true;
            this.cbox_standard_diameter_secondary.Location = new System.Drawing.Point(136, 79);
            this.cbox_standard_diameter_secondary.Name = "cbox_standard_diameter_secondary";
            this.cbox_standard_diameter_secondary.Size = new System.Drawing.Size(101, 21);
            this.cbox_standard_diameter_secondary.TabIndex = 13;
            this.cbox_standard_diameter_secondary.SelectedIndexChanged += new System.EventHandler(this.cbox_standard_diameter_secondary_SelectedIndexChanged);
            // 
            // lbl_standard_diameter_secondary
            // 
            this.lbl_standard_diameter_secondary.AutoSize = true;
            this.lbl_standard_diameter_secondary.Location = new System.Drawing.Point(12, 82);
            this.lbl_standard_diameter_secondary.Name = "lbl_standard_diameter_secondary";
            this.lbl_standard_diameter_secondary.Size = new System.Drawing.Size(118, 13);
            this.lbl_standard_diameter_secondary.TabIndex = 12;
            this.lbl_standard_diameter_secondary.Text = "Standard diameter (mm)";
            // 
            // txt_width_secondary
            // 
            this.txt_width_secondary.Location = new System.Drawing.Point(135, 132);
            this.txt_width_secondary.Name = "txt_width_secondary";
            this.txt_width_secondary.ReadOnly = true;
            this.txt_width_secondary.Size = new System.Drawing.Size(101, 20);
            this.txt_width_secondary.TabIndex = 11;
            // 
            // txt_layers_secondary
            // 
            this.txt_layers_secondary.Location = new System.Drawing.Point(135, 106);
            this.txt_layers_secondary.Name = "txt_layers_secondary";
            this.txt_layers_secondary.ReadOnly = true;
            this.txt_layers_secondary.Size = new System.Drawing.Size(101, 20);
            this.txt_layers_secondary.TabIndex = 10;
            // 
            // txt_diameter_secondary
            // 
            this.txt_diameter_secondary.Location = new System.Drawing.Point(136, 53);
            this.txt_diameter_secondary.Name = "txt_diameter_secondary";
            this.txt_diameter_secondary.Size = new System.Drawing.Size(101, 20);
            this.txt_diameter_secondary.TabIndex = 9;
            // 
            // txt_turns_secondary
            // 
            this.txt_turns_secondary.Location = new System.Drawing.Point(136, 27);
            this.txt_turns_secondary.Name = "txt_turns_secondary";
            this.txt_turns_secondary.ReadOnly = true;
            this.txt_turns_secondary.Size = new System.Drawing.Size(101, 20);
            this.txt_turns_secondary.TabIndex = 8;
            // 
            // geometry_panel
            // 
            this.geometry_panel.Controls.Add(this.txt_core_area);
            this.geometry_panel.Controls.Add(this.lbl_core_area);
            this.geometry_panel.Location = new System.Drawing.Point(12, 190);
            this.geometry_panel.Name = "geometry_panel";
            this.geometry_panel.Size = new System.Drawing.Size(252, 51);
            this.geometry_panel.TabIndex = 2;
            this.geometry_panel.TabStop = false;
            this.geometry_panel.Text = "Geometry";
            // 
            // txt_core_area
            // 
            this.txt_core_area.Location = new System.Drawing.Point(146, 22);
            this.txt_core_area.Name = "txt_core_area";
            this.txt_core_area.ReadOnly = true;
            this.txt_core_area.Size = new System.Drawing.Size(100, 20);
            this.txt_core_area.TabIndex = 3;
            // 
            // lbl_core_area
            // 
            this.lbl_core_area.AutoSize = true;
            this.lbl_core_area.Location = new System.Drawing.Point(6, 25);
            this.lbl_core_area.Name = "lbl_core_area";
            this.lbl_core_area.Size = new System.Drawing.Size(140, 13);
            this.lbl_core_area.TabIndex = 3;
            this.lbl_core_area.Text = "Calculated core area (cm^2)";
            // 
            // Result_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 251);
            this.Controls.Add(this.geometry_panel);
            this.Controls.Add(this.panel_sec_result);
            this.Controls.Add(this.panel_pri_result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Result_Form";
            this.Text = "Results";
            this.panel_pri_result.ResumeLayout(false);
            this.panel_pri_result.PerformLayout();
            this.panel_sec_result.ResumeLayout(false);
            this.panel_sec_result.PerformLayout();
            this.geometry_panel.ResumeLayout(false);
            this.geometry_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panel_pri_result;
        private System.Windows.Forms.Label lbl_width_secondary;
        private System.Windows.Forms.Label lbl_layers_secondary;
        private System.Windows.Forms.Label lbl_diameter_secondary;
        private System.Windows.Forms.Label lbl_turns_secondary;
        private System.Windows.Forms.Label lbl_width_primary;
        private System.Windows.Forms.Label lbl_layers_primary;
        private System.Windows.Forms.Label lbl_diameter_primary;
        private System.Windows.Forms.Label lbl_turns_primary;
        private System.Windows.Forms.GroupBox panel_sec_result;
        private System.Windows.Forms.TextBox txt_width_primary;
        private System.Windows.Forms.TextBox txt_layers_primary;
        private System.Windows.Forms.TextBox txt_diameter_primary;
        private System.Windows.Forms.TextBox txt_turns_primary;
        private System.Windows.Forms.TextBox txt_width_secondary;
        private System.Windows.Forms.TextBox txt_layers_secondary;
        private System.Windows.Forms.TextBox txt_diameter_secondary;
        private System.Windows.Forms.TextBox txt_turns_secondary;
        private System.Windows.Forms.GroupBox geometry_panel;
        private System.Windows.Forms.TextBox txt_core_area;
        private System.Windows.Forms.Label lbl_core_area;
        private System.Windows.Forms.ComboBox cbox_standard_diameter_primary;
        private System.Windows.Forms.Label lbl_standard_diameter_primary;
        private System.Windows.Forms.ComboBox cbox_standard_diameter_secondary;
        private System.Windows.Forms.Label lbl_standard_diameter_secondary;
    }
}