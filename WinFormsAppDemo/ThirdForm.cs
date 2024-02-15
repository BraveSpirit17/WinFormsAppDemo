namespace WinFormsAppDemo;

public partial class ThirdForm : SecondForm
{
    protected DataGridView dataGridView;

    public ThirdForm() : base()
    {
        InitializeComponent();

        dataGridView = new DataGridView();
        Controls.Add(dataGridView);
    }

    protected virtual void SetupDataGridView()
    {
        // Настройте свойства DataGridView по умолчанию
        dataGridView.Dock = DockStyle.Fill;

        // Установите по умолчанию только для чтения
        //dataGridView.ReadOnly = true;
    }

}
