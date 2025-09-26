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
        label_nome = new System.Windows.Forms.Label();
        label_dateBirth = new System.Windows.Forms.Label();
        button_enviar = new System.Windows.Forms.Button();
        label_sexo = new System.Windows.Forms.Label();
        input_name = new System.Windows.Forms.TextBox();
        input_data_nascimento = new System.Windows.Forms.TextBox();
        input_sexo = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // label_nome
        // 
        label_nome.Location = new System.Drawing.Point(63, 75);
        label_nome.Name = "label_nome";
        label_nome.Size = new System.Drawing.Size(100, 23);
        label_nome.TabIndex = 0;
        label_nome.Text = "Nome";
        // 
        // label_dateBirth
        // 
        label_dateBirth.Location = new System.Drawing.Point(63, 122);
        label_dateBirth.Name = "label_dateBirth";
        label_dateBirth.Size = new System.Drawing.Size(158, 23);
        label_dateBirth.TabIndex = 1;
        label_dateBirth.Text = "Data de nascimento";
        // 
        // button_enviar
        // 
        button_enviar.Location = new System.Drawing.Point(63, 309);
        button_enviar.Name = "button_enviar";
        button_enviar.Size = new System.Drawing.Size(109, 46);
        button_enviar.TabIndex = 4;
        button_enviar.Text = "Enviar";
        button_enviar.UseVisualStyleBackColor = true;
        button_enviar.Click += button_enviar_Click;
        // 
        // label_sexo
        // 
        label_sexo.Location = new System.Drawing.Point(63, 172);
        label_sexo.Name = "label_sexo";
        label_sexo.Size = new System.Drawing.Size(100, 23);
        label_sexo.TabIndex = 5;
        label_sexo.Text = "Sexo";
        // 
        // input_name
        // 
        input_name.Location = new System.Drawing.Point(129, 71);
        input_name.Name = "input_name";
        input_name.Size = new System.Drawing.Size(154, 27);
        input_name.TabIndex = 6;
        // 
        // input_data_nascimento
        // 
        input_data_nascimento.Location = new System.Drawing.Point(227, 122);
        input_data_nascimento.Name = "input_data_nascimento";
        input_data_nascimento.Size = new System.Drawing.Size(146, 27);
        input_data_nascimento.TabIndex = 7;
        // 
        // input_sexo
        // 
        input_sexo.Location = new System.Drawing.Point(121, 168);
        input_sexo.Name = "input_sexo";
        input_sexo.Size = new System.Drawing.Size(162, 27);
        input_sexo.TabIndex = 8;
        // 
        // HomeUser
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(input_sexo);
        Controls.Add(input_data_nascimento);
        Controls.Add(input_name);
        Controls.Add(label_sexo);
        Controls.Add(button_enviar);
        Controls.Add(label_dateBirth);
        Controls.Add(label_nome);
        Text = "HomeUser";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button_enviar;
    private System.Windows.Forms.TextBox input_name;
    private System.Windows.Forms.TextBox input_data_nascimento;
    private System.Windows.Forms.TextBox input_sexo;

    private System.Windows.Forms.Label label_sexo;

    private System.Windows.Forms.Label label_nome;
    private System.Windows.Forms.Label label_dateBirth;

    #endregion
}