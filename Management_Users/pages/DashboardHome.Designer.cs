using System.ComponentModel;

namespace Management_Users.pages;

partial class DashboardHome
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        nomeUserDashboard = new System.Windows.Forms.Label();
        process1 = new System.Diagnostics.Process();
        buttonLogoutDashboard = new System.Windows.Forms.Button();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // nomeUserDashboard
        // 
        nomeUserDashboard.Font = new System.Drawing.Font("Segoe UI", 24F);
        nomeUserDashboard.Location = new System.Drawing.Point(12, 12);
        nomeUserDashboard.Name = "nomeUserDashboard";
        nomeUserDashboard.Size = new System.Drawing.Size(356, 71);
        nomeUserDashboard.TabIndex = 0;
        nomeUserDashboard.Text = "{{name}}";
        // 
        // process1
        // 
        process1.StartInfo.Domain = "";
        process1.StartInfo.LoadUserProfile = false;
        process1.StartInfo.UseCredentialsForNetworkingOnly = false;
        process1.StartInfo.UserName = "";
        process1.StartInfo.UseShellExecute = false;
        process1.SynchronizingObject = this;
        // 
        // buttonLogoutDashboard
        // 
        buttonLogoutDashboard.BackColor = System.Drawing.SystemColors.HotTrack;
        buttonLogoutDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        buttonLogoutDashboard.Location = new System.Drawing.Point(713, 12);
        buttonLogoutDashboard.Name = "buttonLogoutDashboard";
        buttonLogoutDashboard.Size = new System.Drawing.Size(75, 35);
        buttonLogoutDashboard.TabIndex = 3;
        buttonLogoutDashboard.Text = "Sair";
        buttonLogoutDashboard.UseVisualStyleBackColor = false;
        buttonLogoutDashboard.Click += buttonLogoutDashboard_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.640377F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.359623F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
        tableLayoutPanel1.Location = new System.Drawing.Point(12, 103);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new System.Drawing.Size(776, 121);
        tableLayoutPanel1.TabIndex = 4;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(492, 14);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(174, 33);
        button1.TabIndex = 5;
        button1.Text = "Adicionar Usuários";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click_1;
        // 
        // DashboardHome
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button1);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(buttonLogoutDashboard);
        Controls.Add(nomeUserDashboard);
        Text = "DashboardHome";
        Load += DashboardHome_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Button buttonLogoutDashboard;

    private System.Diagnostics.Process process1;

    private System.Windows.Forms.Label nomeUserDashboard;

    #endregion
}