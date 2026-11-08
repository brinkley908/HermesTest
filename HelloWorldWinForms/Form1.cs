using System.Windows.Forms;

namespace HelloWorldWinForms;

public partial class Form1 : Form
{
    private Button _button;

    public Form1()
    {
        InitializeComponent();
        InitializeCustomControls();
    }

    private void InitializeCustomControls()
    {
        _button = new Button
        {
            Text = "Click Me",
            Location = new Point(100, 100),
            Size = new Size(100, 40)
        };

        _button.Click += (s, e) => MessageBox.Show("Hello");

        this.Controls.Add(_button);
    }
}
