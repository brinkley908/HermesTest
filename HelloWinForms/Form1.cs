using System;
using System.Windows.Forms;

namespace HelloWinForms
{
    public partial class Form1 : Form
    {
        private Button button;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button = new Button();
            this.SuspendLayout();
            
            // Button configuration
            this.button.Location = new System.Drawing.Point(50, 50);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 30);
            this.button.Text = "Click Me";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new EventHandler(this.button_Click);

            // Form configuration
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Hello App";
            this.ResumeLayout(false);
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello", "Greeting");
        }
    }
}
