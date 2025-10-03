namespace Management_Users;

partial class LoginForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        textBox1 = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        textBox2 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        linkLabel1 = new System.Windows.Forms.LinkLabel();
        checkBox1 = new System.Windows.Forms.CheckBox();
        messageError = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(177, 26);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(371, 42);
        label1.TabIndex = 0;
        label1.Text = "Gerenciamento de Usuários";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(177, 180);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(371, 23);
        textBox1.TabIndex = 1;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        label2.Location = new System.Drawing.Point(277, 154);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(178, 23);
        label2.TabIndex = 2;
        label2.Text = "Email / Username";
        label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        label3.Location = new System.Drawing.Point(277, 237);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(178, 23);
        label3.TabIndex = 4;
        label3.Text = "Senha";
        label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(177, 263);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(371, 23);
        textBox2.TabIndex = 3;
        textBox2.UseSystemPasswordChar = true;
        // 
        // button1
        // 
        button1.Cursor = System.Windows.Forms.Cursors.Hand;
        button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        button1.Location = new System.Drawing.Point(277, 333);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(166, 45);
        button1.TabIndex = 5;
        button1.Text = "Entrar";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // linkLabel1
        // 
        linkLabel1.Location = new System.Drawing.Point(447, 289);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new System.Drawing.Size(101, 23);
        linkLabel1.TabIndex = 6;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Criar conta";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // checkBox1
        // 
        checkBox1.Location = new System.Drawing.Point(262, 399);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(181, 24);
        checkBox1.TabIndex = 7;
        checkBox1.Text = "Termos de uso e privacidade";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // messageError
        // 
        messageError.ForeColor = System.Drawing.Color.IndianRed;
        messageError.Location = new System.Drawing.Point(177, 289);
        messageError.Name = "messageError";
        messageError.Size = new System.Drawing.Size(201, 41);
        messageError.TabIndex = 8;
        messageError.Text = "Erro no Login";
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(697, 450);
        Controls.Add(messageError);
        Controls.Add(checkBox1);
        Controls.Add(linkLabel1);
        Controls.Add(button1);
        Controls.Add(label3);
        Controls.Add(textBox2);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Text = "Form1";
        Load += LoginForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label messageError;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.CheckBox checkBox1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;

    #endregion
}