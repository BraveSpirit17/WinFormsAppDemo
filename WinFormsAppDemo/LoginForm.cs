namespace WinFormsAppDemo;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void loginB_Click(object sender, EventArgs e)
    {
        if (IsValidUser(UserName.Text, Password.Text))
        {
            Hide();

            var mainForm = new UsersForm();
            mainForm.ShowDialog();
        }
        else
        {
            MessageBox.Show("Неверные учетные данные. Повторите вход.",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool IsValidUser(string username, string password) => username == "admin" && password == "password";
}
