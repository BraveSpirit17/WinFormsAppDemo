namespace WinFormsAppDemo;

public partial class FourthForm : ThirdForm
{
    protected TabControl tabControl;

    public FourthForm() : base()
    {
        InitializeComponent();

        tabControl = new TabControl();
        Controls.Add(tabControl);

        SetupDataGridView();
    }

    //protected override void OnLoad(EventArgs e)
    //{
    //    base.OnLoad(e);

    //    // Переопределение OnLoad позволяет вам вносить изменения после загрузки базовой формы
    //    if (dataGridView != null)
    //    {
    //        // Ваш код для изменения свойств DataGridView
    //        // Разрешаем редактирование
    //        dataGridView.ReadOnly = false;

    //        // Разрешаем перемещение строк
    //        //dataGridView.AllowUserToMoveRows = true;
    //    }
    //}

    protected override void SetupDataGridView()
    {
        // Вызываем базовую реализацию, чтобы сохранить общие настройки
        base.SetupDataGridView();

        dataGridView.DataSource = GetCustomDataSource();

        dataGridView.Dock = DockStyle.Top;

        // Другие специфичные настройки...
    }

    #region Private methods

    private object GetCustomDataSource()
    {
        return null;
    }

    #endregion
}
