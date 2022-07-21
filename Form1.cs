using System.IO;

namespace RP_Calculator
{
	public partial class Form1 : Form
	{
		public enum ChargedCash
		{
			a, b, c, d, e, f
		}

		public ChargedCash selectedChargedCash;

		private double CashPerRP
		{
			get
			{
				return selectedChargedCash switch
				{
					ChargedCash.a => (double) defaultCashPerRP[0].krw / defaultCashPerRP[0].rp,
					ChargedCash.b => (double) defaultCashPerRP[1].krw / defaultCashPerRP[1].rp,
					ChargedCash.c => (double) defaultCashPerRP[2].krw / defaultCashPerRP[2].rp,
					ChargedCash.d => (double) defaultCashPerRP[3].krw / defaultCashPerRP[3].rp,
					ChargedCash.e => (double) defaultCashPerRP[4].krw / defaultCashPerRP[4].rp,
					ChargedCash.f => (double) defaultCashPerRP[5].krw / defaultCashPerRP[5].rp,
					_ => 0,
				};
			}
		}

		static readonly string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		static readonly string myFolder = Path.Combine(appData, "GST RP Calculator");
		static readonly string myConfigFile = "config.txt";
		public static (int krw, int rp)[] defaultCashPerRP = new (int, int)[6] { (4900, 565), (9900, 1200), (19900, 2450), (35000, 4350), (49900, 6275), (99000, 13000) };

		public Form1()
		{
			if (File.Exists(Path.Combine(myFolder, myConfigFile)))
			{
				string[] strList = File.ReadAllLines(Path.Combine(myFolder, myConfigFile));
				for(int i = 0; i < 6; i++)
				{
					string[] s = strList[i].Split(",");
					defaultCashPerRP[i] = (int.Parse(s[0]), int.Parse(s[1]));
				}
			}
			else
			{
				Directory.CreateDirectory(myFolder);
				using var writer = new StreamWriter(Path.Combine(myFolder, myConfigFile), append: true);

				foreach ((int krw, int rp) e in defaultCashPerRP)
				{
					writer.WriteLine($"{e.krw},{e.rp}");
				}
			}

			
			InitializeComponent();

			SetRadioText();
		}

		private void radio_4900_CheckedChanged(object sender, EventArgs e)
		{
			selectedChargedCash = ChargedCash.a;
			update_whenRadioChanged();
		}

		private void radio_9900_CheckedChanged(object sender, EventArgs e)
		{
			selectedChargedCash = ChargedCash.b;
			update_whenRadioChanged();
		}

		private void radio_19900_CheckedChanged(object sender, EventArgs e)
		{
			selectedChargedCash = ChargedCash.c;
			update_whenRadioChanged();
		}

		private void radio_35000_CheckedChanged(object sender, EventArgs e)
		{
			selectedChargedCash = ChargedCash.d;
			update_whenRadioChanged();
		}

		private void radio_49900_CheckedChanged(object sender, EventArgs e)
		{
			selectedChargedCash = ChargedCash.e;
			update_whenRadioChanged();
		}

		private void radio_99000_CheckedChanged(object sender, EventArgs e)
		{
			selectedChargedCash = ChargedCash.f;
			update_whenRadioChanged();
		}

		public void update_whenRadioChanged()
		{
			string s = string.Format("{0:0.000}", CashPerRP);
			textBox_perRP.Text = s;

			textBox_InputRP_TextChanged(null, EventArgs.Empty);

			var ffo = new (double, Label)[] { (3250, label_ToKRW3250), (1820, label_ToKRW1820), (1350, label_ToKRW1350), (975, label_ToKRW975) };

			foreach ((double, Label) e in ffo)
			{
				string str = string.Format("{0:0}", CashPerRP * e.Item1) + " ¿ø";
				e.Item2.Text = str;
			}
		}

		private void textBox_InputRP_TextChanged(object sender, EventArgs e)
		{
			if (textBox_InputRP.Text != "")
			{
				string s = string.Format("{0:#,###.##}", CashPerRP * Double.Parse(textBox_InputRP.Text));
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

		private void button_SetAmount_Click(object sender, EventArgs e)
		{
			var newForm = new form_SetAmount(this);
			newForm.ShowDialog();
		}

		public void SetRadioText()
		{
			var radioArr = new RadioButton[] { radio_4900, radio_9900, radio_19900, radio_35000, radio_49900, radio_99000 };
			for (int i = 0; i < 6; i++)
			{
				string krwstr = string.Format("{0:#,###}", defaultCashPerRP[i].krw);
				string rpstr = string.Format("{0:#,###}", defaultCashPerRP[i].rp);

				string s = $"{krwstr}¿ø ({rpstr}RP)";
				radioArr[i].Text = s;
			}
		}

		public void SaveCashRP()
		{
			using var writer = new StreamWriter(Path.Combine(myFolder, myConfigFile));

			foreach ((int krw, int rp) e in defaultCashPerRP)
			{
				writer.WriteLine($"{e.krw},{e.rp}");
			}
		}
	}
}