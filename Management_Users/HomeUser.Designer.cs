using System.ComponentModel;

namespace Management_Users;

partial class HomeUser
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
        label_name_user = new System.Windows.Forms.Label();
        button = new System.Windows.Forms.Button();
        label_points = new System.Windows.Forms.Label();
        label_level = new System.Windows.Forms.Label();
        label_saldo = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label_name_user
        // 
        label_name_user.Font = new System.Drawing.Font("Segoe UI", 22F);
        label_name_user.Location = new System.Drawing.Point(27, 50);
        label_name_user.Name = "label_name_user";
        label_name_user.Size = new System.Drawing.Size(285, 75);
        label_name_user.TabIndex = 0;
        label_name_user.Text = "{{name}}";
        label_name_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // button
        // 
        button.Location = new System.Drawing.Point(644, 12);
        button.Name = "button";
        button.Size = new System.Drawing.Size(75, 23);
        button.TabIndex = 1;
        button.Text = "Sair";
        button.UseVisualStyleBackColor = true;
        button.Click += button_Click;
        // 
        // label_points
        // 
        label_points.Font = new System.Drawing.Font("Segoe UI", 13F);
        label_points.Location = new System.Drawing.Point(118, 4);
        label_points.Name = "label_points";
        label_points.Size = new System.Drawing.Size(194, 28);
        label_points.TabIndex = 2;
        label_points.Text = "{{points}}";
        label_points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label_level
        // 
        label_level.Location = new System.Drawing.Point(12, 9);
        label_level.Name = "label_level";
        label_level.Size = new System.Drawing.Size(100, 23);
        label_level.TabIndex = 3;
        label_level.Text = "{{level}}";
        // 
        // label_saldo
        // 
        label_saldo.Font = new System.Drawing.Font("Segoe UI", 24F);
        label_saldo.Location = new System.Drawing.Point(470, 87);
        label_saldo.Name = "label_saldo";
        label_saldo.RightToLeft = System.Windows.Forms.RightToLeft.No;
        label_saldo.Size = new System.Drawing.Size(205, 63);
        label_saldo.TabIndex = 4;
        label_saldo.Text = "{{saldo}}";
        label_saldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // HomeUser
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 382);
        Controls.Add(label_saldo);
        Controls.Add(label_level);
        Controls.Add(label_points);
        Controls.Add(button);
        Controls.Add(label_name_user);
        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        Text = "HomeUser";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label_saldo;

    private System.Windows.Forms.Label label_level;

    private System.Windows.Forms.Label label_points;

    private System.Windows.Forms.Button button;

    private System.Windows.Forms.Label label_name_user;

    #endregion
}