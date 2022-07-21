using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RP_Calculator
{
	public partial class form_SetAmount : Form
	{
		Form1 mother;

		public form_SetAmount(Form1 mom)
		{
			mother = mom;

			InitializeComponent();

			TextBox[] Cashes = new TextBox[] { textBox_setKRW0, textBox_setKRW1, textBox_setKRW2, textBox_setKRW3, textBox_setKRW4, textBox_setKRW5 };
			TextBox[] RPs = new TextBox[] { textBox_setRP0, textBox_setRP1, textBox_setRP2, textBox_setRP3, textBox_setRP4, textBox_setRP5 };

			for (int i = 0; i < 6; i++)
			{
				(Cashes[i].Text, RPs[i].Text) = (Form1.defaultCashPerRP[i].krw.ToString(), Form1.defaultCashPerRP[i].rp.ToString());
			}
		}

		private void button_ApplySetCharge_Click(object sender, EventArgs e)
		{
			TextBox[] Cashes = new TextBox[] { textBox_setKRW0, textBox_setKRW1, textBox_setKRW2, textBox_setKRW3, textBox_setKRW4, textBox_setKRW5 };
			TextBox[] RPs = new TextBox[] { textBox_setRP0, textBox_setRP1, textBox_setRP2, textBox_setRP3, textBox_setRP4, textBox_setRP5 };

			for (int i = 0; i < 6; i++)
			{
				(int, int) foo = (Cashes[i].Text != "" ? int.Parse(Cashes[i].Text) : 1, RPs[i].Text != "" ? int.Parse(RPs[i].Text) : 1);
				Form1.defaultCashPerRP[i] = foo;
			}

			mother.SetRadioText();
			mother.update_whenRadioChanged();
			mother.SaveCashRP();
			Close();
		}

		private void textBox_setKRWRP_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
