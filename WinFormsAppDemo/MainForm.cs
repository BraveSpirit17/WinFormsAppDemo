namespace WinFormsAppDemo;

public partial class MainForm : FourthForm
{
    public MainForm() : base()
    {
        InitializeComponent();

        SetupDataGridView();
    }

    //protected override void OnLoad(EventArgs e)
    //{
    //    base.OnLoad(e);

    //    // ѕереопределение OnLoad позвол€ет вам вносить изменени€ после загрузки базовой формы
    //    if (dataGridView != null)
    //    {
    //        // ¬аш код дл€ изменени€ свойств DataGridView
    //        // –азрешаем редактирование
    //        dataGridView.ReadOnly = false;

    //        // –азрешаем перемещение строк
    //        //dataGridView.AllowUserToMoveRows = true;
    //    }
    //}

    protected override void SetupDataGridView()
    {
        base.SetupDataGridView();

        dataGridView.DataSource = null;

        dataGridView.Dock = DockStyle.Bottom;
    }
}
