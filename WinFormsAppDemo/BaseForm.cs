namespace WinFormsAppDemo;

public partial class BaseForm : Form
{
    protected TextBox textBox;

    public BaseForm()
    {
        InitializeComponent();

        textBox = new TextBox();
        Controls.Add(textBox);
    }
}
