using System.ComponentModel;

namespace Management_Users.pages;

partial class Register
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
        panel1 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        emailTextbox = new System.Windows.Forms.TextBox();
        nomeTextbox = new System.Windows.Forms.TextBox();
        senhaTextBox = new System.Windows.Forms.TextBox();
        confirmarSenhaTextbox = new System.Windows.Forms.TextBox();
        buttonCriarConta = new System.Windows.Forms.Button();
        linkLabel1 = new System.Windows.Forms.LinkLabel();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        panel1.Controls.Add(label1);
        panel1.Location = new System.Drawing.Point(-8, -2);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(816, 103);
        panel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Black", 24F);
        label1.Location = new System.Drawing.Point(29, 21);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(312, 61);
        label1.TabIndex = 0;
        label1.Text = "Cadastro de Conta";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F);
        label2.Location = new System.Drawing.Point(123, 161);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 1;
        label2.Text = "Nome";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F);
        label3.Location = new System.Drawing.Point(123, 235);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 2;
        label3.Text = "Email";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 12F);
        label4.Location = new System.Drawing.Point(474, 161);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 23);
        label4.TabIndex = 3;
        label4.Text = "Senha";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 12F);
        label5.Location = new System.Drawing.Point(474, 235);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(136, 23);
        label5.TabIndex = 4;
        label5.Text = "Confirmar Senha";
        // 
        // emailTextbox
        // 
        emailTextbox.Location = new System.Drawing.Point(123, 261);
        emailTextbox.Name = "emailTextbox";
        emailTextbox.Size = new System.Drawing.Size(233, 23);
        emailTextbox.TabIndex = 5;
        // 
        // nomeTextbox
        // 
        nomeTextbox.Location = new System.Drawing.Point(123, 187);
        nomeTextbox.Name = "nomeTextbox";
        nomeTextbox.Size = new System.Drawing.Size(233, 23);
        nomeTextbox.TabIndex = 6;
        // 
        // senhaTextBox
        // 
        senhaTextBox.Location = new System.Drawing.Point(474, 187);
        senhaTextBox.Name = "senhaTextBox";
        senhaTextBox.Size = new System.Drawing.Size(233, 23);
        senhaTextBox.TabIndex = 7;
        // 
        // confirmarSenhaTextbox
        // 
        confirmarSenhaTextbox.Location = new System.Drawing.Point(474, 261);
        confirmarSenhaTextbox.Name = "confirmarSenhaTextbox";
        confirmarSenhaTextbox.Size = new System.Drawing.Size(233, 23);
        confirmarSenhaTextbox.TabIndex = 8;
        // 
        // buttonCriarConta
        // 
        buttonCriarConta.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonCriarConta.Location = new System.Drawing.Point(348, 350);
        buttonCriarConta.Name = "buttonCriarConta";
        buttonCriarConta.Size = new System.Drawing.Size(129, 38);
        buttonCriarConta.TabIndex = 9;
        buttonCriarConta.Text = "Criar Conta";
        buttonCriarConta.UseVisualStyleBackColor = true;
        buttonCriarConta.Click += buttonCriarConta_Click;
        // 
        // linkLabel1
        // 
        linkLabel1.Location = new System.Drawing.Point(348, 391);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new System.Drawing.Size(129, 23);
        linkLabel1.TabIndex = 10;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Voltar Login";
        linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // Register
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(linkLabel1);
        Controls.Add(buttonCriarConta);
        Controls.Add(confirmarSenhaTextbox);
        Controls.Add(senhaTextBox);
        Controls.Add(nomeTextbox);
        Controls.Add(emailTextbox);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(panel1);
        Text = "Register";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox emailTextbox;
    private System.Windows.Forms.TextBox nomeTextbox;
    private System.Windows.Forms.TextBox senhaTextBox;
    private System.Windows.Forms.TextBox confirmarSenhaTextbox;
    private System.Windows.Forms.Button buttonCriarConta;
    private System.Windows.Forms.LinkLabel linkLabel1;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}