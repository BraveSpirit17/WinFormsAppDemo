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

    //    // ��������������� OnLoad ��������� ��� ������� ��������� ����� �������� ������� �����
    //    if (dataGridView != null)
    //    {
    //        // ��� ��� ��� ��������� ������� DataGridView
    //        // ��������� ��������������
    //        dataGridView.ReadOnly = false;

    //        // ��������� ����������� �����
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
