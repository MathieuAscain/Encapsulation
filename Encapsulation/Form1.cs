using System;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class frmCharacter : Form
    {
        public frmCharacter()
        {
            InitializeComponent();
        }

        private Character[] theCharacters = new Character[100];
        private int nbrCharac = 0;
        private void ShowPersonalMessage(Character aCharacter)
        {
            if (aCharacter.GetHealth() == 0)
            {
                txtStatusCharacter.Text = aCharacter.GetLogin() + " is dead";
            }
            else
            {
                txtStatusCharacter.Text = aCharacter.GetLogin() + " : " + aCharacter.GetHealth();
            }
        }

        private void UpdateCharacList(int currentLine)
        {
            lstCharacters.Items.Clear();
            for(int k = 0; k < nbrCharac; k++)
            {
                lstCharacters.Items.Add(theCharacters[k].GetLogin() + " (" + theCharacters[k].GetHealth() + ")");
            }

            if (lstCharacters.Items.Count > 0 && currentLine < nbrCharac)
            {
                lstCharacters.SelectedIndex = currentLine;
            }
        }

        private void SearchCharacMaxLife()
        {
            if(nbrCharac == 0)
            {
                txtCharacMaxLife.Text = "";
            }
            else
            {
                int max = 0;
                for(int k = 1; k < nbrCharac; k++)
                {
                    if(theCharacters[k].GetHealth() > theCharacters[max].GetHealth())
                    {
                        max = k;
                    }
                }
                txtCharacMaxLife.Text = theCharacters[max].GetLogin();
            }
        }

        private void UpdateCharacHealth(int index)
        {
            ShowPersonalMessage(theCharacters[index]);
            UpdateCharacList(index);
            SearchCharacMaxLife();
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                nbrCharac++;
                Character myCharacter = new Character(txtLogin.Text);
                theCharacters[nbrCharac - 1] = myCharacter;
                UpdateCharacHealth(nbrCharac - 1);
                txtLogin.Text = "";
                txtLogin.Focus();
            }
        }

        private void lstCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            numHealth.Value = theCharacters[lstCharacters.SelectedIndex].GetHealth();
        }

        private void numHealth_ValueChanged(object sender, EventArgs e)
        {
            if(lstCharacters.SelectedIndex >= 0)
            {
                Character myCharacter = theCharacters[lstCharacters.SelectedIndex];
                myCharacter.SetHealth((int)numHealth.Value);
                UpdateCharacHealth(lstCharacters.SelectedIndex);
            }  
        }

        private void frmCharacter_Load(object sender, EventArgs e)
        {
            txtCharacMaxLife.Enabled = false;
            txtStatusCharacter.Enabled = false;
        }
    }
}
