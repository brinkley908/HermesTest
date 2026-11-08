namespace HermesTest;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void ButtonHello_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Hello", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
