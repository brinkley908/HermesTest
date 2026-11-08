using System;
using System.Drawing;
using System.Windows.Forms;

namespace HermesForm
{
    static class Program
    {
        [System.STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    public class Form1 : Form
    {
        private Button button;

        public Form1()
        {
            this.Text = "Hermes Form";
            this.Size = new Size(300, 200);

            button = new Button();
            button.Text = "Click Me";
            button.Location = new Point(100, 70);
            button.Size = new Size(100, 40);
            button.Click += new EventHandler(this.Button_Click);

            this.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}
