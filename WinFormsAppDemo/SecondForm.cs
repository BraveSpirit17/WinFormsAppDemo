namespace WinFormsAppDemo;

public partial class SecondForm : BaseForm
{
    protected CheckBox checkBox;

    public SecondForm() : base()
    {
        InitializeComponent();
        
        checkBox = new CheckBox();
        Controls.Add(checkBox);
    }
}
