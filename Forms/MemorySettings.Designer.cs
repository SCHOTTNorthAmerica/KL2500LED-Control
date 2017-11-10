using SCHOTT.WinForms.Controls.Buttons;
using SCHOTT.WinForms.Controls.Labels;

namespace SCHOTT.KL2500LED.Control.Forms
{
    partial class MemorySettings
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
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.M4 = new System.Windows.Forms.Button();
            this.M3 = new System.Windows.Forms.Button();
            this.M2 = new System.Windows.Forms.Button();
            this.M1 = new System.Windows.Forms.Button();
            this.saveLoad = new SCHOTT.WinForms.Controls.Buttons.ToggleButton();
            this.PowerUp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.transparentLabel = new SCHOTT.WinForms.Controls.Labels.TransparentLabel();
            this.scrollPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.AutoSize = true;
            this.scrollPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollPanel.Controls.Add(this.tableLayoutPanel2);
            this.scrollPanel.Controls.Add(this.tableLayoutPanel1);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Padding = new System.Windows.Forms.Padding(3);
            this.scrollPanel.Size = new System.Drawing.Size(246, 610);
            this.scrollPanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.M4, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.M3, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.M2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.M1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.saveLoad, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PowerUp, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(240, 194);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // M4
            // 
            this.M4.AutoSize = true;
            this.M4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.M4.Dock = System.Windows.Forms.DockStyle.Top;
            this.M4.Location = new System.Drawing.Point(3, 168);
            this.M4.Name = "M4";
            this.M4.Size = new System.Drawing.Size(234, 23);
            this.M4.TabIndex = 0;
            this.M4.Text = "M4";
            this.M4.UseVisualStyleBackColor = true;
            this.M4.Click += new System.EventHandler(this.MemoryClick);
            // 
            // M3
            // 
            this.M3.AutoSize = true;
            this.M3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.M3.Dock = System.Windows.Forms.DockStyle.Top;
            this.M3.Location = new System.Drawing.Point(3, 139);
            this.M3.Name = "M3";
            this.M3.Size = new System.Drawing.Size(234, 23);
            this.M3.TabIndex = 0;
            this.M3.Text = "M3";
            this.M3.UseVisualStyleBackColor = true;
            this.M3.Click += new System.EventHandler(this.MemoryClick);
            // 
            // M2
            // 
            this.M2.AutoSize = true;
            this.M2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.M2.Dock = System.Windows.Forms.DockStyle.Top;
            this.M2.Location = new System.Drawing.Point(3, 110);
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(234, 23);
            this.M2.TabIndex = 0;
            this.M2.Text = "M2";
            this.M2.UseVisualStyleBackColor = true;
            this.M2.Click += new System.EventHandler(this.MemoryClick);
            // 
            // M1
            // 
            this.M1.AutoSize = true;
            this.M1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.M1.Dock = System.Windows.Forms.DockStyle.Top;
            this.M1.Location = new System.Drawing.Point(3, 81);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(234, 23);
            this.M1.TabIndex = 0;
            this.M1.Text = "M1";
            this.M1.UseVisualStyleBackColor = true;
            this.M1.Click += new System.EventHandler(this.MemoryClick);
            // 
            // saveLoad
            // 
            this.saveLoad.AutoSize = true;
            this.saveLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveLoad.Channel = 0;
            this.saveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad.Location = new System.Drawing.Point(3, 3);
            this.saveLoad.Name = "saveLoad";
            this.saveLoad.Size = new System.Drawing.Size(234, 23);
            this.saveLoad.TabIndex = 0;
            this.saveLoad.Text = "Save Location";
            this.saveLoad.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.saveLoad.ToggleDisabledText = "Disabled";
            this.saveLoad.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.saveLoad.ToggleEnabledText = "Enabled";
            this.saveLoad.UseVisualStyleBackColor = true;
            this.saveLoad.Click += new System.EventHandler(this.saveLoad_Click);
            // 
            // PowerUp
            // 
            this.PowerUp.AutoSize = true;
            this.PowerUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PowerUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PowerUp.Location = new System.Drawing.Point(3, 52);
            this.PowerUp.Name = "PowerUp";
            this.PowerUp.Size = new System.Drawing.Size(234, 23);
            this.PowerUp.TabIndex = 4;
            this.PowerUp.Text = "PowerUp";
            this.PowerUp.UseVisualStyleBackColor = true;
            this.PowerUp.Click += new System.EventHandler(this.MemoryClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // transparentLabel
            // 
            this.transparentLabel.BackColor = System.Drawing.Color.Transparent;
            this.transparentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel.Location = new System.Drawing.Point(0, 0);
            this.transparentLabel.Name = "transparentLabel";
            this.transparentLabel.Opacity = 150;
            this.transparentLabel.Size = new System.Drawing.Size(246, 610);
            this.transparentLabel.TabIndex = 4;
            this.transparentLabel.TransparentBackColor = System.Drawing.Color.SlateGray;
            // 
            // MemorySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 610);
            this.Controls.Add(this.scrollPanel);
            this.Controls.Add(this.transparentLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MemorySettings";
            this.Text = "Memory Settings";
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ToggleButton saveLoad;
        private System.Windows.Forms.Button M1;
        private System.Windows.Forms.Button M2;
        private System.Windows.Forms.Button M3;
        private System.Windows.Forms.Button M4;
        private TransparentLabel transparentLabel;
        private System.Windows.Forms.Button PowerUp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}