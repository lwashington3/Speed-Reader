using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SpeedReader
{
    public partial class Menu : Form
    {
        private Color _textColor, _backgroundColor;
        private Font _font;

        public Color TextColor { 
            get => _textColor;
            set {
                _textColor = value;
                TextColorButton.BackColor = value;
            } 
        }
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                _backgroundColor = value;
                BackgroundColorButton.BackColor = value;
            }
        }
        
        public override Font Font
        {
            get => _font;
            set
            {
                _font = value;
                TextColorLabel.Font = value;
                BackgroundColorLabel.Font = value;
                ReadTextButton.Font = value;
                SaveTextButton.Font = value;
            }
        }

        public string ReadingText
        {
            get => InputBox.Text;
            set { InputBox.Text = value; }
        }

        public Menu()
        {
            InitializeComponent();
            TextColor = Color.White;
            BackgroundColor = Color.Black;
            Font = this.TextColorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ReadingText = "";
            CorrectButtonSpacing();
        }

        private void CorrectButtonSpacing()
        {
            Control[] controls = new Control[] { ReadTextButton, SaveTextButton, OptionsPanel, StartViewing};
            int individualHeight = RightPanel.Panel1.Height / controls.Length;
            foreach(Control control in controls)
            {
                control.Height = individualHeight;
            }
        }

        private void TextColorButton_Click(object sender, EventArgs e)
        {
            TextColor = PickColor(TextColor);
        }

        private void BackgroundColorPicker_Click(object sender, EventArgs e)
        {
            BackgroundColor = PickColor(BackgroundColor);
        }

        private void ReadTextButton_Click(object sender, EventArgs e)
        {
            DialogResult result = OpenFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                if (OpenFileDialog.CheckFileExists)
                {
                    using(StreamReader file = new(OpenFileDialog.FileName))
                    {
                        string text = file.ReadToEnd();
                        ReadingText = text;
                    }
                }
            }
        }

        private void SaveTextButton_Click(object sender, EventArgs e)
        {
            DialogResult result = SaveFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                if (SaveFileDialog.CheckPathExists)
                {
                    using(StreamWriter file = new(SaveFileDialog.FileName))
                    {
                        file.WriteLine(ReadingText);
                    }
                }
            }
        }

        private async void StartViewing_Click(object sender, EventArgs e)
        {
            foreach(Control control in Controls)
            {
                control.Visible = !control.Visible;
            }

            Color defaultBackColor = BackColor;
            Color defaultForeColor = ForeColor;

            BackColor = BackgroundColor;
            ForeColor = TextColor;

            int waitTime = (int)(60000 / WordsPerMinute.Value);
            string[] list = ReadingText.Split(new string[] { " ", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            if (RemoveCharactersCheckbox.Checked)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    list[i] = list[i].Replace("(", "").Replace(")", "").Replace("-", "").Replace(",", "");
                }
            }

            foreach (string word in list)
            {
                WordLabel.Text = word;
                await Task.Delay(waitTime);
            }

            BackColor = defaultBackColor;
            ForeColor = defaultForeColor;

            foreach (Control control in Controls)
            {
                control.Visible = !control.Visible;
            }
        }

        private Color PickColor(Color defaultColor)
        {
            ColorPicker.Color = defaultColor;
            DialogResult result = ColorPicker.ShowDialog();

            return result == DialogResult.OK ? ColorPicker.Color : defaultColor;
        }
    }
}
