using Newtonsoft.Json;
using System.Text;

namespace PhoneShop
{
	public partial class PhoneShopForm : Form
	{
		public class Phone
		{
			public static string[] produsers = { "Samsung", "Apple", "Poco", "Huawei", "LG" };
			public static string[] simTypes = { "Mini-SIM", "Micro-SIM", "Nano-SIM", "ESIM" };
			public static string[] countries = { "Россия", "Украина", "Беларусь", "Камбоджа" };

			public string Model { get; set; }
			public string Producer { get; set; }
			public string Country { get; set; }
			public DateTime YearOfRelease { get; set; }
			public string? ImageLocation { get; set; }

			public double Diagonal { get; set; }
			public int NumberOfCameras { get; set; }
			public string SIMType { get; set; }
			public int CommunicationGeneration { get; set; }
			public int RAM { get; set; }
			public int ROM { get; set; }
			public double Weight { get; set; }
			public string? AdditionalCharacteristics { get; set; }

			public DateTime DateOfProduction { get; set; }
			public int WarrantyPeriod { get; set; }
			//public int Дата окончания
			public double Price { get; set; }
			public int? Points { get; set; }
			public int? PromotionDiscount { get; set; } //в процентах
			public int? PromotionPoints { get; set; } //в процентах
			public Phone() { }
			public Phone(PhoneShopForm form) // init Phone from Form
			{
				Model = form.textBoxModel.Text;
				Producer = form.comboBoxProducers.Text;
				Country = form.comboBoxCountry.Text;
				YearOfRelease = form.dateTimePickerYearOfRelease.Value;
				ImageLocation = form.pictureBoxPhoneImage.ImageLocation;

				Diagonal = (double)form.numericUpDownDiagonal.Value;
				NumberOfCameras = (int)form.numericUpDownNumberOfCameras.Value;
				SIMType = form.comboBoxSimType.Text;
				foreach (RadioButton rb in form.groupBoxCommunicationGeneration.Controls)
					if (rb.Checked)
						CommunicationGeneration = rb.Text[0];
				RAM = form.trackBarRAM.Value;
				ROM = form.trackBarROM.Value;
				Weight = (double)form.numericUpDownWeight.Value;
				AdditionalCharacteristics = form.richTextBoxAdditionalCharacteristics.Text;

				DateOfProduction = DateTime.Parse(form.maskedTextBoxDateOfProduction.Text);
				WarrantyPeriod = (int)form.numericUpDownWarrantyPeriod.Value;
				Price = double.Parse(form.textBoxPrice.Text);
				//сохранять значения чек боксов
				if (form.checkBoxPoints.Checked) Points = (int)form.numericUpDownPoints.Value;
				if (form.checkBoxPromotion.Checked)
				{
					PromotionDiscount = form.rbPromotionDiscount.Checked ? int.Parse(form.maskedTextBoxDiscount.Text) : null;
					PromotionPoints = form.rbPromotionDiscount.Checked ? int.Parse(form.maskedTextBoxPoints.Text) : null;
				}
			}

		}
		public PhoneShopForm()
		{
			InitializeComponent();
			comboBoxProducers.Items.AddRange(Phone.produsers);
			comboBoxSimType.Items.AddRange(Phone.simTypes);
			comboBoxCountry.Items.AddRange(Phone.countries);
		}
		public void FormFromPhone(Phone phone) // init Form from Phone
		{
			textBoxModel.Text = phone.Model;
			comboBoxProducers.Text = phone.Producer;
			comboBoxCountry.Text = phone.Country;
			dateTimePickerYearOfRelease.Value = phone.YearOfRelease;
			pictureBoxPhoneImage.ImageLocation = phone.ImageLocation;

			numericUpDownDiagonal.Value = (decimal)phone.Diagonal;
			numericUpDownNumberOfCameras.Value = (decimal)phone.NumberOfCameras;
			comboBoxSimType.Text = phone.SIMType;
			switch (phone.CommunicationGeneration)
			{
				case 4: { radioButton4G.Checked = true; break; }
				case 5: { radioButton5G.Checked = true; break; }
			}
			trackBarRAM.Value = phone.RAM;
			trackBarROM.Value = phone.ROM;
			numericUpDownWeight.Value = (decimal)phone.Weight;
			richTextBoxAdditionalCharacteristics.Text = phone.AdditionalCharacteristics;

			maskedTextBoxDateOfProduction.Text = phone.DateOfProduction.ToString("dd.MM.yyyy");
			numericUpDownWarrantyPeriod.Value = phone.WarrantyPeriod;
			textBoxPrice.Text = phone.Price.ToString();
			if (phone.Points != null) numericUpDownPoints.Value = (decimal)phone.Points;
			if (phone.PromotionDiscount != null) maskedTextBoxDiscount.Text = phone.PromotionDiscount.ToString();
			if (phone.PromotionPoints != null) maskedTextBoxPoints.Text = phone.PromotionPoints.ToString();
		}
		private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("сделай отдельную форму", "achtung");
		}

		private void trackBarOM_ValueChanged(object sender, EventArgs e)
		{
			labelOM.Text = $"{trackBarRAM.Value} Гб";
		}

		private void trackBarPM_ValueChanged(object sender, EventArgs e)
		{
			labelPM.Text = $"{trackBarROM.Value} Гб";
		}

		private void maskedTextBoxYearOfProduction_KeyUp(object sender, KeyEventArgs e)
		{
			//string[] day_month_year = maskedTextBoxYearOfProduction.Text.Split('.');
		}

		private void numericUpDownWarrantyPeriod_ValueChanged(object sender, EventArgs e)
		{
			labelWarrantyPeriod.Text = (numericUpDownWarrantyPeriod.Value == 0 || numericUpDownWarrantyPeriod.Value % 10 == 0) ? "лет" :
				numericUpDownWarrantyPeriod.Value == 1 ? "год " :
				numericUpDownWarrantyPeriod.Value < 5 ? "года" : "лет";
		}


		private void ttmiQuit_Click(object sender, EventArgs e)
		{
			Close();
		}

		//проверить поля на заполнение!!
		private void ttmiSave_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new() { DefaultExt = "json" };
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				Phone phone = new Phone(this);
				string json = Newtonsoft.Json.JsonConvert.SerializeObject(phone);
				FileStream fs = File.Create(sfd.FileName);
				fs.Write(Encoding.UTF8.GetBytes(json));
				fs.Close();
			}
			else return;
		}
		//только .json!!
		private void ttmiLoad_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new();
			Phone phone = new();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				//Object obj = JsonConvert.DeserializeObject(File.ReadAllText(ofd.FileName));
				FormFromPhone(JsonConvert.DeserializeObject<Phone>(File.ReadAllText(ofd.FileName)));
			}
		}

		private void maskedTextBoxYearOfProduction_Leave(object sender, EventArgs e)
		{
			//string[] day_month_year = maskedTextBoxYearOfProduction.Text.Split('.');
			DateTime date;
			if (!DateTime.TryParse(maskedTextBoxDateOfProduction.Text.AsSpan(), out date))
			{
				MessageBox.Show("Неправильный формат даты! Повторите снова.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				maskedTextBoxDateOfProduction.Text = "";
			}
			else if (date < dateTimePickerYearOfRelease.Value)
			{
				MessageBox.Show("Дата производства раньше даты выпуска! Повторите снова.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				maskedTextBoxDateOfProduction.Text = "";
			}

		}

		private void textBoxPrice_Leave(object sender, EventArgs e)
		{
			CheckPrice(textBoxPrice.Text);
		}

		private void textBoxPrice_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) CheckPrice(textBoxPrice.Text);
		}
		private bool CheckPrice(string value)
		{
			double price;
			if (!double.TryParse(value, out price))
			{
				MessageBox.Show("Введённое значение должно быть числом", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				textBoxPrice.Text = "";
				return false;
			}
			return true;
		}

		private void checkBoxPoints_CheckedChanged(object sender, EventArgs e)
		{
			numericUpDownPoints.Enabled = checkBoxPoints.Checked;
		}

		private void checkBoxPromotion_CheckedChanged(object sender, EventArgs e)
		{
			rbPromotionDiscount.Enabled = checkBoxPromotion.Checked;
			rbPromotionDiscount.Checked = false;

			rbPromotionPoints.Enabled = checkBoxPromotion.Checked;
			rbPromotionPoints.Checked = false;
		}

		private void buttonChooseImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new();
			if(ofd.ShowDialog() == DialogResult.OK)
			{
				this.pictureBoxPhoneImage.ImageLocation = ofd.FileName;
				pictureBoxPhoneImage.Refresh();
			}
		}
	}
}
