using Management_Users.entity;

namespace Management_Users.pages
{
    public partial class DashboardHome : Form
    {
        private readonly UserEntity _loggedUser;
        private readonly Random _random = new();

        public DashboardHome(UserEntity loggedUser)
        {
            InitializeComponent();
            _loggedUser = loggedUser;
        }

        private void DashboardHome_Load(object sender, EventArgs e)
        {
            // Saudação
            string nameUser = $"Olá, {_loggedUser.Nome}";
            nomeUserDashboard.Text = nameUser;

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            // Mantém posição do Designer e expande só pra baixo
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.RowCount = 0;

            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f)); // Nome
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45f)); // Gastos
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45f)); // Tempo
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f)); // Ações4
            if (tableLayoutPanel1.Parent is Panel parentPanel)
            {
                parentPanel.AutoScroll = true;
            }

            // Cabeçalho
            AddRow("Nome", "Gastos", "Tempo (meses)", "Ações", bold: true);

            int quantidade = _random.Next(1, 5);
            for (int i = 0; i < quantidade; i++)
            {
                AddRow(
                    GetRandomName(),
                    $"R$ {_random.Next(500, 5000)}",
                    $"{_random.Next(1, 24)} meses"
                );
            }
        }

        private void AddRow(string nome, string gastos, string tempo, string? acao = null, bool bold = false)
        {
            int rowIndex = tableLayoutPanel1.RowCount++;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            var nomeLabel = CreateLabel(nome, bold);
            var gastosLabel = CreateLabel(gastos, bold);
            var tempoLabel = CreateLabel(tempo, bold);

            tableLayoutPanel1.Controls.Add(nomeLabel, 0, rowIndex);
            tableLayoutPanel1.Controls.Add(gastosLabel, 1, rowIndex);
            tableLayoutPanel1.Controls.Add(tempoLabel, 2, rowIndex);

            if (bold)
            {
                var acaoLabel = CreateLabel(acao ?? "", bold);
                tableLayoutPanel1.Controls.Add(acaoLabel, 3, rowIndex);
            }
            else
            {
                var deleteButton = new Button
                {
                    Text = "Deletar",
                    BackColor = Color.FromArgb(220, 70, 70),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Fill,
                    Tag = rowIndex
                };
                deleteButton.FlatAppearance.BorderSize = 0;
                deleteButton.Click += DeleteRow_Click;

                tableLayoutPanel1.Controls.Add(deleteButton, 3, rowIndex);
            }
        }

        private void DeleteRow_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            int row = tableLayoutPanel1.GetRow(btn);

            // Evita excluir cabeçalho
            if (row == 0) return;

            // Remove todos os controles da linha
            for (int i = tableLayoutPanel1.ColumnCount - 1; i >= 0; i--)
            {
                var control = tableLayoutPanel1.GetControlFromPosition(i, row);
                if (control != null)
                    tableLayoutPanel1.Controls.Remove(control);
            }

            // Reorganiza linhas abaixo
            for (int i = row + 1; i < tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    var control = tableLayoutPanel1.GetControlFromPosition(j, i);
                    if (control != null)
                        tableLayoutPanel1.SetRow(control, i - 1);
                }
            }

            tableLayoutPanel1.RowCount--;
            tableLayoutPanel1.PerformLayout();
        }

        private Label CreateLabel(string text, bool bold)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", bold ? 10F : 9F, bold ? FontStyle.Bold : FontStyle.Regular),
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
        }

        private string GetRandomName()
        {
            string[] nomes = {
                "Lucas", "Mariana", "João", "Fernanda", "Pedro", "Ana",
                "Gabriel", "Camila", "Thiago", "Beatriz", "Rafaela", "Mateus",
                "Larissa", "Felipe", "Isabela", "Caio", "Juliana", "Bruno",
                "Carla", "Renan"
            };
            return nomes[_random.Next(nomes.Length)];
        }

        private void buttonLogoutDashboard_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int novosUsuarios = _random.Next(1, 2);

            for (int i = 0; i < novosUsuarios; i++)
            {
                AddRow(
                    GetRandomName(),
                    $"R$ {_random.Next(500, 5000)}",
                    $"{_random.Next(1, 24)} meses"
                );
            }

            // Atualiza layout da tabela
            tableLayoutPanel1.PerformLayout();
        }
    }
}
