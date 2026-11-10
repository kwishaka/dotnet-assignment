using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Enter a username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Hide();
            using (var selectionForm = new choose())
            {
                selectionForm.ShowDialog(this);
            }
            Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    public class choose : Form
    {
        public choose()
        {
            Text = "Choose Service";
            ClientSize = new Size(435, 310);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            var titleLabel = new Label { AutoSize = true, Font = new Font("Segoe UI", 18F, FontStyle.Bold), Location = new Point(130, 45), Text = "Choose a Service" };
            var instructionLabel = new Label { AutoSize = true, Location = new Point(115, 100), Text = "What would you like help with?" };
            var bicycleButton = new Button { Location = new Point(75, 145), Size = new Size(130, 45), Text = "Bicycle" };
            var mechanicButton = new Button { Location = new Point(230, 145), Size = new Size(130, 45), Text = "Mechanic" };
            var logoutButton = new Button { Location = new Point(165, 225), Size = new Size(105, 30), Text = "Logout" };

            bicycleButton.Click += delegate { OpenServiceForm(new bycle()); };
            mechanicButton.Click += delegate { OpenServiceForm(new mashloom()); };
            logoutButton.Click += delegate { Close(); };

            Controls.AddRange(new Control[] { titleLabel, instructionLabel, bicycleButton, mechanicButton, logoutButton });
        }

        private void OpenServiceForm(Form serviceForm)
        {
            Hide();
            using (serviceForm)
            {
                serviceForm.ShowDialog(this);
            }
            Show();
        }
    }

    public class bycle : Form
    {
        public bycle()
        {
            Text = "Bicycle Service";
            ClientSize = new Size(420, 290);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            var titleLabel = new Label { AutoSize = true, Font = new Font("Segoe UI", 18F, FontStyle.Bold), Location = new Point(155, 55), Text = "Bicycle" };
            var descriptionLabel = new Label { AutoSize = true, Location = new Point(100, 120), Text = "Bicycle service selected.\nYour request can be handled here." };
            var logoutButton = new Button { Location = new Point(155, 205), Size = new Size(110, 32), Text = "Logout" };
            logoutButton.Click += delegate { Close(); };

            Controls.AddRange(new Control[] { titleLabel, descriptionLabel, logoutButton });
        }
    }

    public class mashloom : Form
    {
        public mashloom()
        {
            Text = "Mechanic Service";
            ClientSize = new Size(420, 290);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            var titleLabel = new Label { AutoSize = true, Font = new Font("Segoe UI", 18F, FontStyle.Bold), Location = new Point(135, 55), Text = "Mechanic" };
            var descriptionLabel = new Label { AutoSize = true, Location = new Point(90, 120), Text = "Mechanic service selected.\nYour request can be handled here." };
            var logoutButton = new Button { Location = new Point(155, 205), Size = new Size(110, 32), Text = "Logout" };
            logoutButton.Click += delegate { Close(); };

            Controls.AddRange(new Control[] { titleLabel, descriptionLabel, logoutButton });
        }
    }
    }
}
