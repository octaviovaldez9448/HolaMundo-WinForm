using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Obtener las contraseñas de los TextBox
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Expresión regular para validar:
            // - una mayúscula
            // - una minúscula
            // - un número
            // - un símbolo
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).+$";

            // Validar estructura de contraseña
            if (!Regex.IsMatch(password, pattern))
            {
                MessageBox.Show(
                    "La contraseña debe contener:\n" +
                    "- Una letra mayúscula\n" +
                    "- Una letra minúscula\n" +
                    "- Un número\n" +
                    "- Un símbolo",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validar que ambas contraseñas coincidan
            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Las contraseñas no coinciden",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Si todo está correcto
            MessageBox.Show(
                "La contraseña ha sido validada",
                "Validación exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
