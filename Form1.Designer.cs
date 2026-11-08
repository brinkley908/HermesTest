namespace HermesTest;

partial class Form1
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
            ButtonHello = new Button();
            SuspendLayout();
            // 
            // ButtonHello
            // 
            ButtonHello.Location = new Point(84, 64);
            ButtonHello.Name = "ButtonHello";
            ButtonHello.Size = new Size(104, 34);
            ButtonHello.TabIndex = 0;
            ButtonHello.Text = "Say Hello";
            ButtonHello.UseVisualStyleBackColor = true;
            ButtonHello.Click += ButtonHello_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 200);
            Controls.Add(ButtonHello);
            Name = "Form1";
            Text = "Hello";
            ResumeLayout(false);
            PerformLayout();
    }

    #endregion

    private Button ButtonHello;
}
