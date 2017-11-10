using SCHOTT.WinForms.Controls.Buttons;
using SCHOTT.WinForms.Controls.Labels;

namespace SCHOTT.KL2500LED.Control.Forms
{
    partial class MainControls
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShutter = new SCHOTT.WinForms.Controls.Buttons.ToggleButton();
            this.sliderOutputPower = new SCHOTT.WinForms.Controls.Combo_Controls.SliderNumericCombo();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.frontUnlocked = new System.Windows.Forms.RadioButton();
            this.frontLocked = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.remoteMomentary = new System.Windows.Forms.RadioButton();
            this.remoteToggle = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.transparentLabel = new SCHOTT.WinForms.Controls.Labels.TransparentLabel();
            this.scrollPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.AutoSize = true;
            this.scrollPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollPanel.Controls.Add(this.tableLayoutPanel3);
            this.scrollPanel.Controls.Add(this.tableLayoutPanel2);
            this.scrollPanel.Controls.Add(this.tableLayoutPanel1);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Padding = new System.Windows.Forms.Padding(3);
            this.scrollPanel.Size = new System.Drawing.Size(610, 491);
            this.scrollPanel.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnShutter, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.sliderOutputPower, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(604, 50);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnShutter
            // 
            this.btnShutter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShutter.Channel = 0;
            this.btnShutter.Location = new System.Drawing.Point(3, 3);
            this.btnShutter.Name = "btnShutter";
            this.btnShutter.Size = new System.Drawing.Size(218, 44);
            this.btnShutter.TabIndex = 0;
            this.btnShutter.Text = "Shutter Open";
            this.btnShutter.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.btnShutter.ToggleDisabledText = "Shutter Open";
            this.btnShutter.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.btnShutter.ToggleEnabledText = "Shutter Closed";
            this.btnShutter.UseVisualStyleBackColor = true;
            this.btnShutter.Click += new System.EventHandler(this.btnShutter_Click);
            // 
            // sliderOutputPower
            // 
            this.sliderOutputPower.AutoSize = true;
            this.sliderOutputPower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sliderOutputPower.Channel = 0;
            this.sliderOutputPower.DecimalPlaces = 1;
            this.sliderOutputPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sliderOutputPower.FontSize = 8.25F;
            this.sliderOutputPower.Location = new System.Drawing.Point(227, 3);
            this.sliderOutputPower.Maximum = 1000;
            this.sliderOutputPower.Minimum = 0;
            this.sliderOutputPower.Name = "sliderOutputPower";
            this.sliderOutputPower.Size = new System.Drawing.Size(374, 44);
            this.sliderOutputPower.TabIndex = 2;
            this.sliderOutputPower.Value = 50;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(604, 62);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Remote Switch Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(5, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Front Controls";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.frontUnlocked);
            this.panel1.Controls.Add(this.frontLocked);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(119, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 25);
            this.panel1.TabIndex = 4;
            // 
            // frontUnlocked
            // 
            this.frontUnlocked.AutoSize = true;
            this.frontUnlocked.Dock = System.Windows.Forms.DockStyle.Left;
            this.frontUnlocked.Location = new System.Drawing.Point(61, 0);
            this.frontUnlocked.Name = "frontUnlocked";
            this.frontUnlocked.Size = new System.Drawing.Size(71, 25);
            this.frontUnlocked.TabIndex = 0;
            this.frontUnlocked.TabStop = true;
            this.frontUnlocked.Text = "Unlocked";
            this.frontUnlocked.UseVisualStyleBackColor = true;
            // 
            // frontLocked
            // 
            this.frontLocked.AutoSize = true;
            this.frontLocked.Dock = System.Windows.Forms.DockStyle.Left;
            this.frontLocked.Location = new System.Drawing.Point(0, 0);
            this.frontLocked.Name = "frontLocked";
            this.frontLocked.Size = new System.Drawing.Size(61, 25);
            this.frontLocked.TabIndex = 0;
            this.frontLocked.TabStop = true;
            this.frontLocked.Text = "Locked";
            this.frontLocked.UseVisualStyleBackColor = true;
            this.frontLocked.CheckedChanged += new System.EventHandler(this.frontLocked_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.remoteMomentary);
            this.panel2.Controls.Add(this.remoteToggle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(119, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 25);
            this.panel2.TabIndex = 4;
            // 
            // remoteMomentary
            // 
            this.remoteMomentary.AutoSize = true;
            this.remoteMomentary.Dock = System.Windows.Forms.DockStyle.Left;
            this.remoteMomentary.Location = new System.Drawing.Point(58, 0);
            this.remoteMomentary.Name = "remoteMomentary";
            this.remoteMomentary.Size = new System.Drawing.Size(77, 25);
            this.remoteMomentary.TabIndex = 0;
            this.remoteMomentary.TabStop = true;
            this.remoteMomentary.Text = "Momentary";
            this.remoteMomentary.UseVisualStyleBackColor = true;
            // 
            // remoteToggle
            // 
            this.remoteToggle.AutoSize = true;
            this.remoteToggle.Dock = System.Windows.Forms.DockStyle.Left;
            this.remoteToggle.Location = new System.Drawing.Point(0, 0);
            this.remoteToggle.Name = "remoteToggle";
            this.remoteToggle.Size = new System.Drawing.Size(58, 25);
            this.remoteToggle.TabIndex = 0;
            this.remoteToggle.TabStop = true;
            this.remoteToggle.Text = "Toggle";
            this.remoteToggle.UseVisualStyleBackColor = true;
            this.remoteToggle.CheckedChanged += new System.EventHandler(this.remoteToggle_CheckedChanged);
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
            this.transparentLabel.Size = new System.Drawing.Size(610, 491);
            this.transparentLabel.TabIndex = 4;
            this.transparentLabel.TransparentBackColor = System.Drawing.Color.SlateGray;
            // 
            // MainControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 491);
            this.Controls.Add(this.scrollPanel);
            this.Controls.Add(this.transparentLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainControls";
            this.Text = "Main Controls";
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TransparentLabel transparentLabel;
        private WinForms.Controls.Combo_Controls.SliderNumericCombo sliderOutputPower;
        private ToggleButton btnShutter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton frontUnlocked;
        private System.Windows.Forms.RadioButton frontLocked;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton remoteMomentary;
        private System.Windows.Forms.RadioButton remoteToggle;
    }
}