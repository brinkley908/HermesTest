using System;
using System.Windows.Forms;

namespace WinFormsApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.Load += (s, e) => {
            Button btn = new Button();
            btn.Text = "Click Me";
            btn.Location = new System.Drawing.Point(50, 50);
            btn.AutoSize = true;
            btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn.Click += (sender, args) => {
                MessageBox.Show("Hello");
            };
            this.Controls.Add(btn);
        };
    }
}