using System.ComponentModel;

namespace Management_Users.pages;

partial class Login
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
        components = new System.ComponentModel.Container();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        emailLoginTextbox = new System.Windows.Forms.TextBox();
        senhaLoginTextbox = new System.Windows.Forms.TextBox();
        bindingSource1 = new System.Windows.Forms.BindingSource(components);
        button1 = new System.Windows.Forms.Button();
        linkLabel1 = new System.Windows.Forms.LinkLabel();
        ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(292, 17);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(165, 47);
        label1.TabIndex = 0;
        label1.Text = "Login";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(66, 142);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 1;
        label2.Text = "Email";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(66, 254);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 2;
        label3.Text = "Senha";
        // 
        // emailLoginTextbox
        // 
        emailLoginTextbox.Location = new System.Drawing.Point(66, 168);
        emailLoginTextbox.Name = "emailLoginTextbox";
        emailLoginTextbox.Size = new System.Drawing.Size(336, 23);
        emailLoginTextbox.TabIndex = 3;
        // 
        // senhaLoginTextbox
        // 
        senhaLoginTextbox.Location = new System.Drawing.Point(66, 280);
        senhaLoginTextbox.Name = "senhaLoginTextbox";
        senhaLoginTextbox.Size = new System.Drawing.Size(336, 23);
        senhaLoginTextbox.TabIndex = 4;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(292, 369);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 5;
        button1.Text = "Login";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // linkLabel1
        // 
        linkLabel1.Location = new System.Drawing.Point(265, 395);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new System.Drawing.Size(137, 23);
        linkLabel1.TabIndex = 6;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Criar Conta";
        linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Login
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(linkLabel1);
        Controls.Add(button1);
        Controls.Add(senhaLoginTextbox);
        Controls.Add(emailLoginTextbox);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "Login";
        ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox emailLoginTextbox;
    private System.Windows.Forms.TextBox senhaLoginTextbox;
    private System.Windows.Forms.BindingSource bindingSource1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.LinkLabel linkLabel1;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    #endregion
}