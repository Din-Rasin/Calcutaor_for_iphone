namespace Calcutaor_for_iphone
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            btnplue = new Button();
            btnExp = new Button();
            btnDiv = new Button();
            btn0 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnMul = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnsub = new Button();
            btn6 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            buttonAdd = new Button();
            btn9 = new Button();
            buttonCE = new Button();
            btnPercent = new Button();
            buttonPM = new Button();
            buttonCearspace = new Button();
            txtdisplay = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 250, 239);
            panel1.Controls.Add(btnplue);
            panel1.Controls.Add(btnExp);
            panel1.Controls.Add(btnDiv);
            panel1.Controls.Add(btn0);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(btnMul);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(btnsub);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(btn7);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(btn9);
            panel1.Controls.Add(buttonCE);
            panel1.Controls.Add(btnPercent);
            panel1.Controls.Add(buttonPM);
            panel1.Controls.Add(buttonCearspace);
            panel1.Controls.Add(txtdisplay);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 554);
            panel1.TabIndex = 0;
            // 
            // btnplue
            // 
            btnplue.Font = new Font("Viner Hand ITC", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnplue.ForeColor = Color.FromArgb(192, 0, 0);
            btnplue.Location = new Point(246, 398);
            btnplue.Name = "btnplue";
            btnplue.Size = new Size(111, 73);
            btnplue.TabIndex = 20;
            btnplue.Text = ".";
            btnplue.UseVisualStyleBackColor = true;
            btnplue.Click += btnplue_Click;
            // 
            // btnExp
            // 
            btnExp.BackColor = Color.Gray;
            btnExp.Font = new Font("Viner Hand ITC", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExp.ForeColor = Color.Red;
            btnExp.Location = new Point(18, 477);
            btnExp.Name = "btnExp";
            btnExp.Size = new Size(465, 73);
            btnExp.TabIndex = 19;
            btnExp.Text = "=";
            btnExp.UseVisualStyleBackColor = false;
            btnExp.Click += btnExp_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(255, 128, 0);
            btnDiv.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btnDiv.ForeColor = SystemColors.ActiveCaptionText;
            btnDiv.Location = new Point(363, 398);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(120, 73);
            btnDiv.TabIndex = 18;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btn0
            // 
            btn0.BackgroundImageLayout = ImageLayout.Center;
            btn0.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btn0.ForeColor = Color.FromArgb(255, 128, 0);
            btn0.Location = new Point(18, 398);
            btn0.Name = "btn0";
            btn0.Size = new Size(222, 73);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btn2.ForeColor = SystemColors.ActiveCaptionText;
            btn2.Location = new Point(134, 319);
            btn2.Name = "btn2";
            btn2.Size = new Size(106, 73);
            btn2.TabIndex = 16;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btn1.ForeColor = Color.FromArgb(128, 64, 0);
            btn1.Location = new Point(246, 319);
            btn1.Name = "btn1";
            btn1.Size = new Size(111, 73);
            btn1.TabIndex = 15;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnMul
            // 
            btnMul.BackColor = Color.FromArgb(255, 128, 0);
            btnMul.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btnMul.ForeColor = SystemColors.ActiveCaptionText;
            btnMul.Location = new Point(363, 319);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(120, 73);
            btnMul.TabIndex = 14;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += btnMul_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btn3.ForeColor = SystemColors.ActiveCaptionText;
            btn3.Location = new Point(18, 319);
            btn3.Name = "btn3";
            btn3.Size = new Size(110, 73);
            btn3.TabIndex = 13;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btn5.ForeColor = SystemColors.ActiveCaptionText;
            btn5.Location = new Point(134, 240);
            btn5.Name = "btn5";
            btn5.Size = new Size(106, 73);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btn4.ForeColor = SystemColors.ActiveCaptionText;
            btn4.Location = new Point(246, 240);
            btn4.Name = "btn4";
            btn4.Size = new Size(111, 73);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnsub
            // 
            btnsub.BackColor = Color.FromArgb(255, 128, 0);
            btnsub.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btnsub.ForeColor = SystemColors.ActiveCaptionText;
            btnsub.Location = new Point(363, 240);
            btnsub.Name = "btnsub";
            btnsub.Size = new Size(120, 73);
            btnsub.TabIndex = 10;
            btnsub.Text = "-";
            btnsub.UseVisualStyleBackColor = false;
            btnsub.Click += btnsub_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btn6.ForeColor = SystemColors.ActiveCaptionText;
            btn6.Location = new Point(18, 240);
            btn6.Name = "btn6";
            btn6.Size = new Size(110, 73);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btn8.ForeColor = SystemColors.ActiveCaptionText;
            btn8.Location = new Point(134, 161);
            btn8.Name = "btn8";
            btn8.Size = new Size(106, 73);
            btn8.TabIndex = 8;
            btn8.Tag = "";
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btn7.ForeColor = SystemColors.ActiveCaptionText;
            btn7.Location = new Point(246, 161);
            btn7.Name = "btn7";
            btn7.Size = new Size(111, 73);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(255, 128, 0);
            buttonAdd.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            buttonAdd.ForeColor = SystemColors.ActiveCaptionText;
            buttonAdd.Location = new Point(363, 161);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 73);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btn9.ForeColor = SystemColors.ActiveCaptionText;
            btn9.Location = new Point(18, 161);
            btn9.Name = "btn9";
            btn9.Size = new Size(110, 73);
            btn9.TabIndex = 5;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // buttonCE
            // 
            buttonCE.BackColor = Color.FromArgb(224, 224, 224);
            buttonCE.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            buttonCE.ForeColor = Color.Red;
            buttonCE.Location = new Point(134, 82);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(106, 73);
            buttonCE.TabIndex = 4;
            buttonCE.Text = "Clear";
            buttonCE.UseVisualStyleBackColor = false;
            buttonCE.Click += buttonCE_Click;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = Color.FromArgb(224, 224, 224);
            btnPercent.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btnPercent.ForeColor = SystemColors.ActiveCaptionText;
            btnPercent.Location = new Point(246, 82);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(111, 73);
            btnPercent.TabIndex = 3;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += btnPercent_Click;
            // 
            // buttonPM
            // 
            buttonPM.BackColor = Color.FromArgb(255, 128, 0);
            buttonPM.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic);
            buttonPM.ForeColor = SystemColors.ActiveCaptionText;
            buttonPM.Location = new Point(363, 82);
            buttonPM.Name = "buttonPM";
            buttonPM.Size = new Size(120, 73);
            buttonPM.TabIndex = 2;
            buttonPM.Text = "±";
            buttonPM.UseVisualStyleBackColor = false;
            buttonPM.Click += buttonPM_Click;
            // 
            // buttonCearspace
            // 
            buttonCearspace.BackColor = Color.FromArgb(224, 224, 224);
            buttonCearspace.Font = new Font("Wingdings", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 2);
            buttonCearspace.ForeColor = Color.FromArgb(192, 0, 0);
            buttonCearspace.Location = new Point(18, 82);
            buttonCearspace.Name = "buttonCearspace";
            buttonCearspace.Size = new Size(110, 73);
            buttonCearspace.TabIndex = 1;
            buttonCearspace.Text = "";
            buttonCearspace.UseVisualStyleBackColor = false;
            buttonCearspace.Click += buttonCearspace_Click;
            // 
            // txtdisplay
            // 
            txtdisplay.BackColor = Color.FromArgb(224, 224, 224);
            txtdisplay.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtdisplay.Location = new Point(18, 9);
            txtdisplay.Multiline = true;
            txtdisplay.Name = "txtdisplay";
            txtdisplay.Size = new Size(465, 67);
            txtdisplay.TabIndex = 0;
            txtdisplay.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iphone;
            pictureBox1.Location = new Point(511, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(541, 551);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 239);
            ClientSize = new Size(1057, 560);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "CALCULATOR";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Panel panel1;
        private Button buttonCearspace;
        private TextBox txtdisplay;
        private Button btnplue;
        private Button btnExp;
        private Button btnDiv;
        private Button btn0;
        private Button btn2;
        private Button btn1;
        private Button btnMul;
        private Button btn3;
        private Button btn5;
        private Button btn4;
        private Button btnsub;
        private Button btn6;
        private Button btn8;
        private Button btn7;
        private Button buttonAdd;
        private Button btn9;
        private Button buttonCE;
        private Button btnPercent;
        private Button buttonPM;
        private PictureBox pictureBox1;
    }
}
