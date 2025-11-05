using System.ComponentModel;

namespace Management_Users.pages;

partial class Home
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
        panel1 = new System.Windows.Forms.Panel();
        button3 = new System.Windows.Forms.Button();
        button1 = new System.Windows.Forms.Button();
        titleHomeLabel = new System.Windows.Forms.Label();
        button2 = new System.Windows.Forms.Button();
        panel2 = new System.Windows.Forms.Panel();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        label1 = new System.Windows.Forms.Label();
        imageList1 = new System.Windows.Forms.ImageList(components);
        imageList2 = new System.Windows.Forms.ImageList(components);
        openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        textMainHome = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel1.Controls.Add(button3);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(titleHomeLabel);
        panel1.Location = new System.Drawing.Point(1, 3);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(832, 61);
        panel1.TabIndex = 0;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(731, 14);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(75, 28);
        button3.TabIndex = 2;
        button3.Text = "Login";
        button3.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(639, 14);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 28);
        button1.TabIndex = 1;
        button1.Text = "Cadastro";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // titleHomeLabel
        // 
        titleHomeLabel.Font = new System.Drawing.Font("Segoe UI Black", 32F, System.Drawing.FontStyle.Bold);
        titleHomeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        titleHomeLabel.Location = new System.Drawing.Point(-1, -1);
        titleHomeLabel.Name = "titleHomeLabel";
        titleHomeLabel.Size = new System.Drawing.Size(216, 61);
        titleHomeLabel.TabIndex = 1;
        titleHomeLabel.Text = "You ERP";
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(500, 154);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(8, 8);
        button2.TabIndex = 1;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
        panel2.Controls.Add(pictureBox2);
        panel2.Controls.Add(pictureBox1);
        panel2.Controls.Add(label1);
        panel2.Location = new System.Drawing.Point(1, 346);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(832, 100);
        panel2.TabIndex = 2;
        // 
        // pictureBox2
        // 
        pictureBox2.Location = new System.Drawing.Point(624, 11);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(26, 27);
        pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 2;
        pictureBox2.TabStop = false;
        pictureBox2.Click += pictureBox2_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new System.Drawing.Point(592, 11);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(26, 27);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        pictureBox1.Click += pictureBox1_Click;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
        label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(328, 77);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(218, 23);
        label1.TabIndex = 0;
        label1.Text = "Desenvolvimento por Lucas Oliveira";
        // 
        // imageList1
        // 
        imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
        imageList1.ImageSize = new System.Drawing.Size(16, 16);
        imageList1.TransparentColor = System.Drawing.Color.Transparent;
        // 
        // imageList2
        // 
        imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
        imageList2.ImageSize = new System.Drawing.Size(16, 16);
        imageList2.TransparentColor = System.Drawing.Color.Transparent;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // textMainHome
        // 
        textMainHome.Location = new System.Drawing.Point(30, 94);
        textMainHome.Name = "textMainHome";
        textMainHome.Size = new System.Drawing.Size(517, 197);
        textMainHome.TabIndex = 3;
        // 
        // Home
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(834, 438);
        Controls.Add(textMainHome);
        Controls.Add(panel2);
        Controls.Add(button2);
        Controls.Add(panel1);
        Text = "Home";
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label textMainHome;

    private System.Windows.Forms.OpenFileDialog openFileDialog1;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.ImageList imageList2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Label titleHomeLabel;

    #endregion
}