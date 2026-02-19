namespace Boy_Girl_Book_Pen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rb_Boy = new System.Windows.Forms.RadioButton();
            this.rb_Girl = new System.Windows.Forms.RadioButton();
            this.rb_Book = new System.Windows.Forms.RadioButton();
            this.rb_Pen = new System.Windows.Forms.RadioButton();
            this.lb_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Boy_Girl_Book_Pen.Properties.Resources.pp_Book;
            this.pictureBox1.Image = global::Boy_Girl_Book_Pen.Properties.Resources.pp_Boy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rb_Boy
            // 
            this.rb_Boy.AutoSize = true;
            this.rb_Boy.Location = new System.Drawing.Point(12, 394);
            this.rb_Boy.Name = "rb_Boy";
            this.rb_Boy.Size = new System.Drawing.Size(55, 21);
            this.rb_Boy.TabIndex = 1;
            this.rb_Boy.TabStop = true;
            this.rb_Boy.Tag = "BOY";
            this.rb_Boy.Text = "BOY";
            this.rb_Boy.UseVisualStyleBackColor = true;
            this.rb_Boy.CheckedChanged += new System.EventHandler(this.rb_Boy_CheckedChanged);
            // 
            // rb_Girl
            // 
            this.rb_Girl.AutoSize = true;
            this.rb_Girl.Location = new System.Drawing.Point(187, 394);
            this.rb_Girl.Name = "rb_Girl";
            this.rb_Girl.Size = new System.Drawing.Size(58, 21);
            this.rb_Girl.TabIndex = 2;
            this.rb_Girl.TabStop = true;
            this.rb_Girl.Tag = "GIRL";
            this.rb_Girl.Text = "GIRL";
            this.rb_Girl.UseVisualStyleBackColor = true;
            this.rb_Girl.CheckedChanged += new System.EventHandler(this.rb_Girl_CheckedChanged);
            // 
            // rb_Book
            // 
            this.rb_Book.AutoSize = true;
            this.rb_Book.Location = new System.Drawing.Point(362, 394);
            this.rb_Book.Name = "rb_Book";
            this.rb_Book.Size = new System.Drawing.Size(65, 21);
            this.rb_Book.TabIndex = 3;
            this.rb_Book.TabStop = true;
            this.rb_Book.Tag = "BOOK";
            this.rb_Book.Text = "BOOK";
            this.rb_Book.UseVisualStyleBackColor = true;
            this.rb_Book.CheckedChanged += new System.EventHandler(this.rb_Book_CheckedChanged);
            // 
            // rb_Pen
            // 
            this.rb_Pen.AutoSize = true;
            this.rb_Pen.Location = new System.Drawing.Point(537, 394);
            this.rb_Pen.Name = "rb_Pen";
            this.rb_Pen.Size = new System.Drawing.Size(54, 21);
            this.rb_Pen.TabIndex = 4;
            this.rb_Pen.TabStop = true;
            this.rb_Pen.Tag = "PEN";
            this.rb_Pen.Text = "PEN";
            this.rb_Pen.UseVisualStyleBackColor = true;
            this.rb_Pen.CheckedChanged += new System.EventHandler(this.rb_Pen_CheckedChanged);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.Red;
            this.lb_Title.Location = new System.Drawing.Point(353, -2);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(101, 53);
            this.lb_Title.TabIndex = 5;
            this.lb_Title.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.rb_Pen);
            this.Controls.Add(this.rb_Book);
            this.Controls.Add(this.rb_Girl);
            this.Controls.Add(this.rb_Boy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rb_Boy;
        private System.Windows.Forms.RadioButton rb_Girl;
        private System.Windows.Forms.RadioButton rb_Book;
        private System.Windows.Forms.RadioButton rb_Pen;
        private System.Windows.Forms.Label lb_Title;
    }
}

