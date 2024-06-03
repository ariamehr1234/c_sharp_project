using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quiz3
{
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
        }

        private void sign_in_btn_Click(object sender, EventArgs e)
        {

            if (File.Exists(@"D:\files\c# files\quiz3\quiz3.txt"))
            {
                FileStream file = new FileStream(@"D:\files\c# files\quiz3\quiz3.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);

                if (username_text_box.Text != string.Empty && password_text_box.Text != string.Empty)
                {
                    DialogResult result = MessageBox.Show("Are you sure that you want to sign into this account?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] fields = line.Split("|");
                            for (int i = 0; i < fields.Length; i++)
                            {
                                if (username_text_box.Text.ToString() == fields[i] && password_text_box.Text.ToString() == fields[i + 1])
                                {
                                    MessageBox.Show("You have entered successfully.");
                                    this.Close();
                                    goto end;
                                }
                            }
                            MessageBox.Show("This user does not exist.");
                            goto end;
                        }
                    end:;
                        reader.Close();
                    }
                }
            }
        }

        private void username_text_box_Validating(object sender, CancelEventArgs e)
        {
            if (username_text_box.Text == string.Empty)
            {
                errorProvider1.SetError(username_text_box, "Please enter the username.");
            }
        }

        private void password_text_box_Validating(object sender, CancelEventArgs e)
        {
            if(password_text_box.Text == string.Empty)
            {
                errorProvider1.SetError(password_text_box, "Please enter the password.");
            }
        }
    }
}
