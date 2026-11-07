using System.Windows.Forms;
using HermesTest.Core;

namespace HermesTest.App;

public sealed class MainForm : Form
{
    public Button? HelloButton { get; private set; }

    public MainForm()
    {
        Text = "HermesTest";
        ClientSize = new Size(260, 120);
        StartPosition = FormStartPosition.CenterScreen;

        HelloButton = new Button
        {
            Name = "helloButton",
            Text = "Say Hello",
            Location = new Point(32, 32),
            Size = new Size(120, 40),
        };
        HelloButton.Click += OnHelloButtonClicked;
        Controls.Add(HelloButton);
    }

    private void OnHelloButtonClicked(object? sender, EventArgs e)
    {
        MessageBox.Show(HelloDialog.Message);
    }
}
