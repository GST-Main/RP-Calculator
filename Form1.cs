namespace RP_Calculator
{
	public partial class Form1 : Form
	{
		public enum ChargedCash
		{
			_4900, _9900, _19900, _35000, _49900, _99000
		}

		public ChargedCash selectedChaargedCash;

		private double CashPerRP
		{
			get
			{
				switch(selectedChaargedCash)
				{
					case ChargedCash._4900:
						return (double)4900 / 565;

					case ChargedCash._9900:
						return (double)9900 / 1200;

					case ChargedCash._19900:
						return (double)19900 / 2450;

					case ChargedCash._35000:
						return (double)35000 / 4350;

					case ChargedCash._49900:
						return (double)49900 / 6275;

					case ChargedCash._99000:
						return (double)99000 / 13000;

					default:
						return 0;
				}
			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void radio_4900_CheckedChanged(object sender, EventArgs e)
		{
			selectedChaargedCash = ChargedCash._4900;
			update_textBox_perRP();
		}

		private void radio_9900_CheckedChanged(object sender, EventArgs e)
		{
			selectedChaargedCash = ChargedCash._9900;
			update_textBox_perRP();
		}

		private void radio_19900_CheckedChanged(object sender, EventArgs e)
		{
			selectedChaargedCash = ChargedCash._19900;
			update_textBox_perRP();
		}

		private void radio_35000_CheckedChanged(object sender, EventArgs e)
		{
			selectedChaargedCash = ChargedCash._35000;
			update_textBox_perRP();
		}

		private void radio_49900_CheckedChanged(object sender, EventArgs e)
		{
			selectedChaargedCash = ChargedCash._49900;
			update_textBox_perRP();
		}

		private void radio_99000_CheckedChanged(object sender, EventArgs e)
		{
			selectedChaargedCash = ChargedCash._99000;
			update_textBox_perRP();
		}

		private void update_textBox_perRP()
		{
			string s = string.Format("{0:0.000}", CashPerRP);
			textBox_perRP.Text = s;

			textBox_InputRP_TextChanged(null, EventArgs.Empty);
		}

		private void textBox_InputRP_TextChanged(object sender, EventArgs e)
		{
			if (textBox_InputRP.Text != "")
			{
				string s = string.Format("{0:0.##}", CashPerRP * Double.Parse(textBox_InputRP.Text));
				textBox_Result.Text = s;
			}
			else
				textBox_Result.Text = "";
		}

		private void textBox_InputRP_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}