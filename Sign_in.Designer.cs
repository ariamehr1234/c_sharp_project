namespace quiz3
{
    partial class Sign_in
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_in));
            password_label = new Label();
            username_label = new Label();
            sign_in_label = new Label();
            errorProvider1 = new ErrorProvider(components);
            username_text_box = new TextBox();
            password_text_box = new TextBox();
            sign_in_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(17, 136);
            password_label.Name = "password_label";
            password_label.Size = new Size(77, 20);
            password_label.TabIndex = 10;
            password_label.Text = "Password :";
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Location = new Point(12, 83);
            username_label.Name = "username_label";
            username_label.Size = new Size(82, 20);
            username_label.TabIndex = 9;
            username_label.Text = "Username :";
            // 
            // sign_in_label
            // 
            sign_in_label.AutoSize = true;
            sign_in_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            sign_in_label.Location = new Point(138, 25);
            sign_in_label.Name = "sign_in_label";
            sign_in_label.Size = new Size(150, 28);
            sign_in_label.TabIndex = 8;
            sign_in_label.Text = "SIGN IN FORM";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // username_text_box
            // 
            username_text_box.Location = new Point(100, 80);
            username_text_box.MaxLength = 8;
            username_text_box.Name = "username_text_box";
            username_text_box.Size = new Size(232, 27);
            username_text_box.TabIndex = 15;
            username_text_box.Validating += username_text_box_Validating;
            // 
            // password_text_box
            // 
            password_text_box.Location = new Point(100, 133);
            password_text_box.MaxLength = 8;
            password_text_box.Name = "password_text_box";
            password_text_box.PasswordChar = '*';
            password_text_box.Size = new Size(232, 27);
            password_text_box.TabIndex = 16;
            password_text_box.Validating += password_text_box_Validating;
            // 
            // sign_in_btn
            // 
            sign_in_btn.Location = new Point(100, 190);
            sign_in_btn.Name = "sign_in_btn";
            sign_in_btn.Size = new Size(232, 29);
            sign_in_btn.TabIndex = 18;
            sign_in_btn.Text = "Sign in";
            sign_in_btn.UseVisualStyleBackColor = true;
            sign_in_btn.Click += sign_in_btn_Click;
            // 
            // Sign_in
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.assorted_an_assortment_of_various_fast_food_items_on_a_textured_gray_table_9906835;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(sign_in_btn);
            Controls.Add(password_text_box);
            Controls.Add(username_text_box);
            Controls.Add(password_label);
            Controls.Add(username_label);
            Controls.Add(sign_in_label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Sign_in";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In Page";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label password_label;
        private Label username_label;
        private Label sign_in_label;
        private ErrorProvider errorProvider1;
        private TextBox username_text_box;
        private Button sign_in_btn;
        private TextBox password_text_box;
    }
}