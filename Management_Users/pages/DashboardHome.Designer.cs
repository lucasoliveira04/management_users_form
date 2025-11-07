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
        SuspendLayout();
        // 
        // nomeUserDashboard
        // 
        nomeUserDashboard.Location = new System.Drawing.Point(25, 36);
        nomeUserDashboard.Name = "nomeUserDashboard";
        nomeUserDashboard.Size = new System.Drawing.Size(171, 23);
        nomeUserDashboard.TabIndex = 0;
        nomeUserDashboard.Text = "{{name}}";
        // 
        // DashboardHome
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(nomeUserDashboard);
        Text = "DashboardHome";
        Load += DashboardHome_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label nomeUserDashboard;

    #endregion
}