using System.ComponentModel;

namespace Management_Users;

partial class RegisterUser
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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        name_textbox = new System.Windows.Forms.TextBox();
        textbox_email = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        textbox_password = new System.Windows.Forms.TextBox();
        btn_create_account = new System.Windows.Forms.Button();
        label5 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 22F);
        label1.Location = new System.Drawing.Point(12, 46);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(291, 43);
        label1.TabIndex = 0;
        label1.Text = "Crie uma conta";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F);
        label2.Location = new System.Drawing.Point(59, 117);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 1;
        label2.Text = "Username";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F);
        label3.Location = new System.Drawing.Point(59, 192);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 2;
        label3.Text = "Email";
        // 
        // name_textbox
        // 
        name_textbox.Location = new System.Drawing.Point(59, 143);
        name_textbox.Name = "name_textbox";
        name_textbox.Size = new System.Drawing.Size(202, 23);
        name_textbox.TabIndex = 3;
        // 
        // textbox_email
        // 
        textbox_email.Location = new System.Drawing.Point(59, 218);
        textbox_email.Name = "textbox_email";
        textbox_email.Size = new System.Drawing.Size(202, 23);
        textbox_email.TabIndex = 4;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 12F);
        label4.Location = new System.Drawing.Point(59, 277);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 23);
        label4.TabIndex = 5;
        label4.Text = "Senha";
        // 
        // textbox_password
        // 
        textbox_password.Location = new System.Drawing.Point(59, 303);
        textbox_password.Name = "textbox_password";
        textbox_password.Size = new System.Drawing.Size(202, 23);
        textbox_password.TabIndex = 6;
        // 
        // btn_create_account
        // 
        btn_create_account.Location = new System.Drawing.Point(102, 374);
        btn_create_account.Name = "btn_create_account";
        btn_create_account.Size = new System.Drawing.Size(127, 28);
        btn_create_account.TabIndex = 7;
        btn_create_account.Text = "Criar conta";
        btn_create_account.UseVisualStyleBackColor = true;
        btn_create_account.Click += btn_create_account_Click;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 12F);
        label5.Location = new System.Drawing.Point(12, 9);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(58, 23);
        label5.TabIndex = 8;
        label5.Text = "Voltar";
        label5.Click += label5_Click;
        // 
        // RegisterUser
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(308, 450);
        Controls.Add(label5);
        Controls.Add(btn_create_account);
        Controls.Add(textbox_password);
        Controls.Add(label4);
        Controls.Add(textbox_email);
        Controls.Add(name_textbox);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "RegisterUser";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textbox_password;
    private System.Windows.Forms.Button btn_create_account;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox name_textbox;
    private System.Windows.Forms.TextBox textbox_email;

    private System.Windows.Forms.Label label1;

    #endregion
}