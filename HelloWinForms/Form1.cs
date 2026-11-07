namespace HelloWinForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Spec: clicking the button shows a dialog box with the text "Hello".
        MessageBox.Show("Hello");
    }
}