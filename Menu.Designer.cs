using System.Drawing;
using System.Windows.Forms;

namespace SpeedReader
{
    partial class Menu
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
            this.WordLabel = new Label();
            this.InputBox = new TextBox();
            this.TextColorLabel = new Label();
            this.BackgroundColorLabel = new Label();
            this.TextColorButton = new Button();
            this.BackgroundColorButton = new Button();
            this.RightPanel = new SplitContainer();
            this.OptionsPanel = new Panel();
            this.WordsPerMinute = new NumericUpDown();
            this.WPMLabel = new Label();
            this.RemoveCharactersCheckbox = new CheckBox();
            this.StartViewing = new Button();
            this.SaveTextButton = new Button();
            this.ReadTextButton = new Button();
            this.ColorPicker = new ColorDialog();
            this.OpenFileDialog = new OpenFileDialog();
            this.SaveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.RightPanel)).BeginInit();
            this.RightPanel.Panel1.SuspendLayout();
            this.RightPanel.Panel2.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WordsPerMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // WordLabel
            // 
            this.WordLabel.BackColor = Color.Transparent;
            this.WordLabel.Visible = false;
            this.WordLabel.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            this.WordLabel.Location = new Point(2, 103);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new Size(696, 95);
            this.WordLabel.TabIndex = 0;
            this.WordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputBox
            // 
            this.InputBox.AcceptsReturn = true;
            this.InputBox.AcceptsTab = true;
            this.InputBox.Dock = DockStyle.Left;
            this.InputBox.Location = new Point(0, 0);
            this.InputBox.Margin = new Padding(3, 2, 3, 2);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.PlaceholderText = "Input text to speed read";
            this.InputBox.ScrollBars = ScrollBars.Vertical;
            this.InputBox.Size = new Size(439, 338);
            this.InputBox.TabIndex = 0;
            // 
            // TextColorLabel
            // 
            this.TextColorLabel.AutoSize = true;
            this.TextColorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.TextColorLabel.Location = new Point(69, 15);
            this.TextColorLabel.Name = "TextColorLabel";
            this.TextColorLabel.Size = new Size(81, 21);
            this.TextColorLabel.TabIndex = 1;
            this.TextColorLabel.Text = "Text Color:";
            // 
            // BackgroundColorLabel
            // 
            this.BackgroundColorLabel.AutoSize = true;
            this.BackgroundColorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.BackgroundColorLabel.Location = new Point(7, 50);
            this.BackgroundColorLabel.Name = "BackgroundColorLabel";
            this.BackgroundColorLabel.Size = new Size(138, 21);
            this.BackgroundColorLabel.TabIndex = 2;
            this.BackgroundColorLabel.Text = "Background Color:";
            // 
            // TextColorButton
            // 
            this.TextColorButton.Location = new Point(164, 17);
            this.TextColorButton.Margin = new Padding(3, 2, 3, 2);
            this.TextColorButton.Name = "TextColorButton";
            this.TextColorButton.Size = new Size(94, 22);
            this.TextColorButton.TabIndex = 3;
            this.TextColorButton.UseVisualStyleBackColor = false;
            this.TextColorButton.Click += new System.EventHandler(this.TextColorButton_Click);
            // 
            // BackgroundColorButton
            // 
            this.BackgroundColorButton.Location = new Point(164, 52);
            this.BackgroundColorButton.Margin = new Padding(3, 2, 3, 2);
            this.BackgroundColorButton.Name = "BackgroundColorButton";
            this.BackgroundColorButton.Size = new Size(94, 22);
            this.BackgroundColorButton.TabIndex = 4;
            this.BackgroundColorButton.UseVisualStyleBackColor = false;
            this.BackgroundColorButton.Click += new System.EventHandler(this.BackgroundColorPicker_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.Cursor = Cursors.HSplit;
            this.RightPanel.Dock = DockStyle.Right;
            this.RightPanel.Location = new Point(437, 0);
            this.RightPanel.Margin = new Padding(3, 2, 3, 2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Orientation = Orientation.Horizontal;
            // 
            // RightPanel.Panel1
            // 
            this.RightPanel.Panel1.Controls.Add(this.OptionsPanel);
            this.RightPanel.Panel1.Controls.Add(this.StartViewing);
            this.RightPanel.Panel1.Controls.Add(this.SaveTextButton);
            this.RightPanel.Panel1.Controls.Add(this.ReadTextButton);
            // 
            // RightPanel.Panel2
            // 
            this.RightPanel.Panel2.Controls.Add(this.TextColorButton);
            this.RightPanel.Panel2.Controls.Add(this.BackgroundColorButton);
            this.RightPanel.Panel2.Controls.Add(this.BackgroundColorLabel);
            this.RightPanel.Panel2.Controls.Add(this.TextColorLabel);
            this.RightPanel.Panel2.Cursor = Cursors.HSplit;
            this.RightPanel.Size = new Size(263, 338);
            this.RightPanel.SplitterDistance = 249;
            this.RightPanel.SplitterWidth = 3;
            this.RightPanel.TabIndex = 6;
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BorderStyle = BorderStyle.FixedSingle;
            this.OptionsPanel.Controls.Add(this.WordsPerMinute);
            this.OptionsPanel.Controls.Add(this.WPMLabel);
            this.OptionsPanel.Controls.Add(this.RemoveCharactersCheckbox);
            this.OptionsPanel.Dock = DockStyle.Top;
            this.OptionsPanel.Location = new Point(0, 87);
            this.OptionsPanel.Margin = new Padding(3, 2, 3, 2);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new Size(263, 94);
            this.OptionsPanel.TabIndex = 8;
            // 
            // WordsPerMinute
            // 
            this.WordsPerMinute.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.WordsPerMinute.Location = new Point(165, 25);
            this.WordsPerMinute.Margin = new Padding(3, 2, 3, 2);
            this.WordsPerMinute.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.WordsPerMinute.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WordsPerMinute.Name = "WordsPerMinute";
            this.WordsPerMinute.Size = new Size(88, 29);
            this.WordsPerMinute.TabIndex = 4;
            this.WordsPerMinute.ThousandsSeparator = true;
            this.WordsPerMinute.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // WPMLabel
            // 
            this.WPMLabel.AutoSize = true;
            this.WPMLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.WPMLabel.Location = new Point(8, 27);
            this.WPMLabel.Name = "WPMLabel";
            this.WPMLabel.Size = new Size(138, 21);
            this.WPMLabel.TabIndex = 2;
            this.WPMLabel.Text = "Words per Minute:";
            // 
            // RemoveCharactersCheckbox
            // 
            this.RemoveCharactersCheckbox.AutoSize = true;
            this.RemoveCharactersCheckbox.Checked = true;
            this.RemoveCharactersCheckbox.CheckState = CheckState.Checked;
            this.RemoveCharactersCheckbox.Location = new Point(8, 5);
            this.RemoveCharactersCheckbox.Margin = new Padding(3, 2, 3, 2);
            this.RemoveCharactersCheckbox.Name = "RemoveCharactersCheckbox";
            this.RemoveCharactersCheckbox.Size = new Size(168, 19);
            this.RemoveCharactersCheckbox.TabIndex = 1;
            this.RemoveCharactersCheckbox.Text = "Remove Special Characters";
            this.RemoveCharactersCheckbox.UseVisualStyleBackColor = true;
            // 
            // StartViewing
            // 
            this.StartViewing.DialogResult = DialogResult.OK;
            this.StartViewing.Dock = DockStyle.Bottom;
            this.StartViewing.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.StartViewing.Location = new Point(0, 214);
            this.StartViewing.Margin = new Padding(3, 2, 3, 2);
            this.StartViewing.Name = "StartViewing";
            this.StartViewing.Size = new Size(263, 35);
            this.StartViewing.TabIndex = 7;
            this.StartViewing.Text = "Start Viewing";
            this.StartViewing.UseVisualStyleBackColor = true;
            this.StartViewing.Click += new System.EventHandler(this.StartViewing_Click);
            // 
            // SaveTextButton
            // 
            this.SaveTextButton.Dock = DockStyle.Top;
            this.SaveTextButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.SaveTextButton.Location = new Point(0, 43);
            this.SaveTextButton.Margin = new Padding(3, 2, 3, 2);
            this.SaveTextButton.Name = "SaveTextButton";
            this.SaveTextButton.Size = new Size(263, 44);
            this.SaveTextButton.TabIndex = 6;
            this.SaveTextButton.Text = "Save Text To File";
            this.SaveTextButton.UseVisualStyleBackColor = true;
            this.SaveTextButton.Click += new System.EventHandler(this.SaveTextButton_Click);
            // 
            // ReadTextButton
            // 
            this.ReadTextButton.Dock = DockStyle.Top;
            this.ReadTextButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.ReadTextButton.Location = new Point(0, 0);
            this.ReadTextButton.Margin = new Padding(3, 2, 3, 2);
            this.ReadTextButton.Name = "ReadTextButton";
            this.ReadTextButton.Size = new Size(263, 43);
            this.ReadTextButton.TabIndex = 5;
            this.ReadTextButton.Text = "Read Text From File";
            this.ReadTextButton.UseVisualStyleBackColor = true;
            this.ReadTextButton.Click += new System.EventHandler(this.ReadTextButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(700, 338);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.WordLabel);
            this.Margin = new Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Speed Reader";
            this.RightPanel.Panel1.ResumeLayout(false);
            this.RightPanel.Panel2.ResumeLayout(false);
            this.RightPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightPanel)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WordsPerMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InputBox;
        private Label TextColorLabel;
        private Label BackgroundColorLabel;
        private Label WordLabel;
        private Button TextColorButton;
        private Button BackgroundColorButton;
        private SplitContainer RightPanel;
        private ColorDialog ColorPicker;
        private Button ReadTextButton;
        private OpenFileDialog OpenFileDialog;
        private Button SaveTextButton;
        private SaveFileDialog SaveFileDialog;
        private Button StartViewing;
        private Panel OptionsPanel;
        private CheckBox RemoveCharactersCheckbox;
        private Label WPMLabel;
        private NumericUpDown WordsPerMinute;
    }
}

