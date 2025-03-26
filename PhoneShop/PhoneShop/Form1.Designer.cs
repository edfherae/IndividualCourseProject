using System.Data;
using Microsoft.EntityFrameworkCore;

namespace PhoneShop
{
    partial class PhoneShopForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneShopForm));
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			buttonAddToDB = new Button();
			buttonChooseImage = new Button();
			dateTimePickerYearOfRelease = new DateTimePicker();
			pictureBoxPhoneImage = new PictureBox();
			labelPhoto = new Label();
			labelYOR = new Label();
			comboBoxCountry = new ComboBox();
			labelCountry = new Label();
			comboBoxProducers = new ComboBox();
			labelProducer = new Label();
			textBoxModel = new TextBox();
			labelModel = new Label();
			tabPage2 = new TabPage();
			richTextBoxAdditionalCharacteristics = new RichTextBox();
			label8 = new Label();
			label7 = new Label();
			numericUpDownWeight = new NumericUpDown();
			groupBoxCommunicationGeneration = new GroupBox();
			radioButton5G = new RadioButton();
			radioButton4G = new RadioButton();
			label6 = new Label();
			comboBoxSimType = new ComboBox();
			labelPM = new Label();
			trackBarROM = new TrackBar();
			label5 = new Label();
			labelOM = new Label();
			label4 = new Label();
			trackBarRAM = new TrackBar();
			numericUpDownNumberOfCameras = new NumericUpDown();
			label3 = new Label();
			numericUpDownDiagonal = new NumericUpDown();
			labelDiagonal = new Label();
			tabPage3 = new TabPage();
			numericUpDownPoints = new NumericUpDown();
			textBoxPrice = new TextBox();
			panel1 = new Panel();
			maskedTextBoxDiscount = new MaskedTextBox();
			rbPromotionPoints = new RadioButton();
			maskedTextBoxPoints = new MaskedTextBox();
			rbPromotionDiscount = new RadioButton();
			checkBoxPromotion = new CheckBox();
			checkBoxPoints = new CheckBox();
			label9 = new Label();
			dateTimePickerWarrantyPeriodEnd = new DateTimePicker();
			label12 = new Label();
			labelWarrantyPeriod = new Label();
			numericUpDownWarrantyPeriod = new NumericUpDown();
			label11 = new Label();
			label10 = new Label();
			maskedTextBoxDateOfProduction = new MaskedTextBox();
			menuStrip1 = new MenuStrip();
			FileToolStripMenuItem = new ToolStripMenuItem();
			ttmiSave = new ToolStripMenuItem();
			ttmiLoad = new ToolStripMenuItem();
			ttmiQuit = new ToolStripMenuItem();
			AboutProgramToolStripMenuItem = new ToolStripMenuItem();
			buttonReloadDB = new Button();
			listBoxPhones = new ListBox();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxPhoneImage).BeginInit();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
			groupBoxCommunicationGeneration.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)trackBarROM).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBarRAM).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfCameras).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownDiagonal).BeginInit();
			tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownPoints).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownWarrantyPeriod).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.ImeMode = ImeMode.NoControl;
			tabControl1.Location = new Point(158, 25);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(639, 413);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(buttonAddToDB);
			tabPage1.Controls.Add(buttonChooseImage);
			tabPage1.Controls.Add(dateTimePickerYearOfRelease);
			tabPage1.Controls.Add(pictureBoxPhoneImage);
			tabPage1.Controls.Add(labelPhoto);
			tabPage1.Controls.Add(labelYOR);
			tabPage1.Controls.Add(comboBoxCountry);
			tabPage1.Controls.Add(labelCountry);
			tabPage1.Controls.Add(comboBoxProducers);
			tabPage1.Controls.Add(labelProducer);
			tabPage1.Controls.Add(textBoxModel);
			tabPage1.Controls.Add(labelModel);
			tabPage1.Location = new Point(4, 22);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3, 3, 3, 3);
			tabPage1.Size = new Size(631, 387);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Общие";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// buttonAddToDB
			// 
			buttonAddToDB.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			buttonAddToDB.Location = new Point(60, 308);
			buttonAddToDB.Name = "buttonAddToDB";
			buttonAddToDB.Size = new Size(141, 31);
			buttonAddToDB.TabIndex = 12;
			buttonAddToDB.Text = "Добавить в базу";
			buttonAddToDB.UseVisualStyleBackColor = true;
			buttonAddToDB.Click += buttonAddToDB_Click;
			// 
			// buttonChooseImage
			// 
			buttonChooseImage.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			buttonChooseImage.Location = new Point(389, 338);
			buttonChooseImage.Name = "buttonChooseImage";
			buttonChooseImage.Size = new Size(134, 30);
			buttonChooseImage.TabIndex = 11;
			buttonChooseImage.Text = "Выбрать фото";
			buttonChooseImage.UseVisualStyleBackColor = true;
			buttonChooseImage.Click += buttonChooseImage_Click;
			// 
			// dateTimePickerYearOfRelease
			// 
			dateTimePickerYearOfRelease.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			dateTimePickerYearOfRelease.Location = new Point(21, 233);
			dateTimePickerYearOfRelease.Name = "dateTimePickerYearOfRelease";
			dateTimePickerYearOfRelease.Size = new Size(211, 29);
			dateTimePickerYearOfRelease.TabIndex = 10;
			// 
			// pictureBoxPhoneImage
			// 
			pictureBoxPhoneImage.ErrorImage = (Image)resources.GetObject("pictureBoxPhoneImage.ErrorImage");
			pictureBoxPhoneImage.Image = (Image)resources.GetObject("pictureBoxPhoneImage.Image");
			pictureBoxPhoneImage.InitialImage = (Image)resources.GetObject("pictureBoxPhoneImage.InitialImage");
			pictureBoxPhoneImage.Location = new Point(320, 43);
			pictureBoxPhoneImage.Name = "pictureBoxPhoneImage";
			pictureBoxPhoneImage.Size = new Size(263, 280);
			pictureBoxPhoneImage.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxPhoneImage.TabIndex = 9;
			pictureBoxPhoneImage.TabStop = false;
			// 
			// labelPhoto
			// 
			labelPhoto.AutoSize = true;
			labelPhoto.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelPhoto.Location = new Point(422, 10);
			labelPhoto.Name = "labelPhoto";
			labelPhoto.Size = new Size(60, 30);
			labelPhoto.TabIndex = 8;
			labelPhoto.Text = "Фото";
			// 
			// labelYOR
			// 
			labelYOR.AutoSize = true;
			labelYOR.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelYOR.Location = new Point(21, 199);
			labelYOR.Name = "labelYOR";
			labelYOR.Size = new Size(94, 21);
			labelYOR.TabIndex = 6;
			labelYOR.Text = "Год выпуска";
			// 
			// comboBoxCountry
			// 
			comboBoxCountry.FormattingEnabled = true;
			comboBoxCountry.Location = new Point(21, 160);
			comboBoxCountry.Name = "comboBoxCountry";
			comboBoxCountry.Size = new Size(211, 20);
			comboBoxCountry.TabIndex = 5;
			// 
			// labelCountry
			// 
			labelCountry.AutoSize = true;
			labelCountry.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelCountry.Location = new Point(27, 133);
			labelCountry.Name = "labelCountry";
			labelCountry.Size = new Size(60, 21);
			labelCountry.TabIndex = 4;
			labelCountry.Text = "Страна";
			// 
			// comboBoxProducers
			// 
			comboBoxProducers.FormattingEnabled = true;
			comboBoxProducers.Location = new Point(22, 107);
			comboBoxProducers.Name = "comboBoxProducers";
			comboBoxProducers.Size = new Size(210, 20);
			comboBoxProducers.Sorted = true;
			comboBoxProducers.TabIndex = 3;
			// 
			// labelProducer
			// 
			labelProducer.AutoSize = true;
			labelProducer.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelProducer.Location = new Point(22, 79);
			labelProducer.Name = "labelProducer";
			labelProducer.Size = new Size(120, 21);
			labelProducer.TabIndex = 2;
			labelProducer.Text = "Производитель";
			// 
			// textBoxModel
			// 
			textBoxModel.Location = new Point(22, 48);
			textBoxModel.Name = "textBoxModel";
			textBoxModel.Size = new Size(210, 23);
			textBoxModel.TabIndex = 1;
			// 
			// labelModel
			// 
			labelModel.AutoSize = true;
			labelModel.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelModel.Location = new Point(24, 22);
			labelModel.Name = "labelModel";
			labelModel.Size = new Size(66, 21);
			labelModel.TabIndex = 0;
			labelModel.Text = "Модель";
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(richTextBoxAdditionalCharacteristics);
			tabPage2.Controls.Add(label8);
			tabPage2.Controls.Add(label7);
			tabPage2.Controls.Add(numericUpDownWeight);
			tabPage2.Controls.Add(groupBoxCommunicationGeneration);
			tabPage2.Controls.Add(label6);
			tabPage2.Controls.Add(comboBoxSimType);
			tabPage2.Controls.Add(labelPM);
			tabPage2.Controls.Add(trackBarROM);
			tabPage2.Controls.Add(label5);
			tabPage2.Controls.Add(labelOM);
			tabPage2.Controls.Add(label4);
			tabPage2.Controls.Add(trackBarRAM);
			tabPage2.Controls.Add(numericUpDownNumberOfCameras);
			tabPage2.Controls.Add(label3);
			tabPage2.Controls.Add(numericUpDownDiagonal);
			tabPage2.Controls.Add(labelDiagonal);
			tabPage2.Location = new Point(4, 30);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3, 3, 3, 3);
			tabPage2.Size = new Size(631, 379);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Технические";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// richTextBoxAdditionalCharacteristics
			// 
			richTextBoxAdditionalCharacteristics.Location = new Point(381, 63);
			richTextBoxAdditionalCharacteristics.Name = "richTextBoxAdditionalCharacteristics";
			richTextBoxAdditionalCharacteristics.Size = new Size(230, 318);
			richTextBoxAdditionalCharacteristics.TabIndex = 18;
			richTextBoxAdditionalCharacteristics.Text = "";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.FlatStyle = FlatStyle.Flat;
			label8.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label8.Location = new Point(434, 13);
			label8.Name = "label8";
			label8.Size = new Size(132, 42);
			label8.TabIndex = 16;
			label8.Text = "Дополнительные\r\nхарактеристики";
			label8.TextAlign = ContentAlignment.TopCenter;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label7.Location = new Point(243, 188);
			label7.Name = "label7";
			label7.Size = new Size(51, 21);
			label7.TabIndex = 15;
			label7.Text = "Вес, г.";
			// 
			// numericUpDownWeight
			// 
			numericUpDownWeight.BorderStyle = BorderStyle.FixedSingle;
			numericUpDownWeight.DecimalPlaces = 1;
			numericUpDownWeight.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDownWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
			numericUpDownWeight.Location = new Point(190, 212);
			numericUpDownWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			numericUpDownWeight.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
			numericUpDownWeight.Name = "numericUpDownWeight";
			numericUpDownWeight.Size = new Size(158, 29);
			numericUpDownWeight.TabIndex = 14;
			numericUpDownWeight.Value = new decimal(new int[] { 1, 0, 0, 65536 });
			// 
			// groupBoxCommunicationGeneration
			// 
			groupBoxCommunicationGeneration.Controls.Add(radioButton5G);
			groupBoxCommunicationGeneration.Controls.Add(radioButton4G);
			groupBoxCommunicationGeneration.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			groupBoxCommunicationGeneration.Location = new Point(14, 234);
			groupBoxCommunicationGeneration.Name = "groupBoxCommunicationGeneration";
			groupBoxCommunicationGeneration.Size = new Size(148, 122);
			groupBoxCommunicationGeneration.TabIndex = 13;
			groupBoxCommunicationGeneration.TabStop = false;
			groupBoxCommunicationGeneration.Text = "Поколение связи";
			// 
			// radioButton5G
			// 
			radioButton5G.AutoSize = true;
			radioButton5G.Location = new Point(9, 76);
			radioButton5G.Name = "radioButton5G";
			radioButton5G.Size = new Size(47, 25);
			radioButton5G.TabIndex = 1;
			radioButton5G.TabStop = true;
			radioButton5G.Text = "5G";
			radioButton5G.UseVisualStyleBackColor = true;
			// 
			// radioButton4G
			// 
			radioButton4G.AutoSize = true;
			radioButton4G.Location = new Point(9, 35);
			radioButton4G.Name = "radioButton4G";
			radioButton4G.Size = new Size(48, 25);
			radioButton4G.TabIndex = 0;
			radioButton4G.TabStop = true;
			radioButton4G.Text = "4G";
			radioButton4G.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label6.Location = new Point(31, 159);
			label6.Name = "label6";
			label6.Size = new Size(113, 21);
			label6.TabIndex = 12;
			label6.Text = "Тип сим-карты";
			// 
			// comboBoxSimType
			// 
			comboBoxSimType.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			comboBoxSimType.FormattingEnabled = true;
			comboBoxSimType.Location = new Point(17, 188);
			comboBoxSimType.Name = "comboBoxSimType";
			comboBoxSimType.Size = new Size(139, 29);
			comboBoxSimType.TabIndex = 11;
			// 
			// labelPM
			// 
			labelPM.AutoSize = true;
			labelPM.BackColor = SystemColors.Control;
			labelPM.Location = new Point(253, 161);
			labelPM.Name = "labelPM";
			labelPM.Size = new Size(34, 12);
			labelPM.TabIndex = 10;
			labelPM.Text = "16 Гб";
			// 
			// trackBarROM
			// 
			trackBarROM.LargeChange = 16;
			trackBarROM.Location = new Point(190, 130);
			trackBarROM.Maximum = 1024;
			trackBarROM.Minimum = 16;
			trackBarROM.Name = "trackBarROM";
			trackBarROM.Size = new Size(158, 45);
			trackBarROM.SmallChange = 16;
			trackBarROM.TabIndex = 9;
			trackBarROM.TickFrequency = 16;
			trackBarROM.Value = 16;
			trackBarROM.ValueChanged += trackBarPM_ValueChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label5.Location = new Point(190, 101);
			label5.Name = "label5";
			label5.Size = new Size(148, 21);
			label5.TabIndex = 8;
			label5.Text = "Постоянная память";
			// 
			// labelOM
			// 
			labelOM.AutoSize = true;
			labelOM.BackColor = SystemColors.Control;
			labelOM.Location = new Point(255, 75);
			labelOM.Name = "labelOM";
			labelOM.Size = new Size(27, 12);
			labelOM.TabIndex = 7;
			labelOM.Text = "1 Гб";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label4.Location = new Point(190, 13);
			label4.Name = "label4";
			label4.Size = new Size(158, 21);
			label4.TabIndex = 6;
			label4.Text = "Оперативная память";
			// 
			// trackBarRAM
			// 
			trackBarRAM.LargeChange = 2;
			trackBarRAM.Location = new Point(190, 42);
			trackBarRAM.Maximum = 16;
			trackBarRAM.Minimum = 1;
			trackBarRAM.Name = "trackBarRAM";
			trackBarRAM.Size = new Size(158, 45);
			trackBarRAM.TabIndex = 5;
			trackBarRAM.TickFrequency = 2;
			trackBarRAM.Value = 1;
			trackBarRAM.ValueChanged += trackBarOM_ValueChanged;
			// 
			// numericUpDownNumberOfCameras
			// 
			numericUpDownNumberOfCameras.BorderStyle = BorderStyle.FixedSingle;
			numericUpDownNumberOfCameras.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDownNumberOfCameras.Location = new Point(17, 112);
			numericUpDownNumberOfCameras.Name = "numericUpDownNumberOfCameras";
			numericUpDownNumberOfCameras.Size = new Size(139, 29);
			numericUpDownNumberOfCameras.TabIndex = 4;
			numericUpDownNumberOfCameras.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label3.Location = new Point(17, 83);
			label3.Name = "label3";
			label3.Size = new Size(139, 21);
			label3.TabIndex = 3;
			label3.Text = "Количество камер";
			// 
			// numericUpDownDiagonal
			// 
			numericUpDownDiagonal.BorderStyle = BorderStyle.FixedSingle;
			numericUpDownDiagonal.DecimalPlaces = 1;
			numericUpDownDiagonal.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDownDiagonal.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
			numericUpDownDiagonal.Location = new Point(17, 42);
			numericUpDownDiagonal.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			numericUpDownDiagonal.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownDiagonal.Name = "numericUpDownDiagonal";
			numericUpDownDiagonal.Size = new Size(139, 29);
			numericUpDownDiagonal.TabIndex = 2;
			numericUpDownDiagonal.Value = new decimal(new int[] { 5, 0, 0, 0 });
			// 
			// labelDiagonal
			// 
			labelDiagonal.AutoSize = true;
			labelDiagonal.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelDiagonal.Location = new Point(40, 14);
			labelDiagonal.Name = "labelDiagonal";
			labelDiagonal.Size = new Size(86, 21);
			labelDiagonal.TabIndex = 1;
			labelDiagonal.Text = "Диагональ";
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(numericUpDownPoints);
			tabPage3.Controls.Add(textBoxPrice);
			tabPage3.Controls.Add(panel1);
			tabPage3.Controls.Add(checkBoxPoints);
			tabPage3.Controls.Add(label9);
			tabPage3.Controls.Add(dateTimePickerWarrantyPeriodEnd);
			tabPage3.Controls.Add(label12);
			tabPage3.Controls.Add(labelWarrantyPeriod);
			tabPage3.Controls.Add(numericUpDownWarrantyPeriod);
			tabPage3.Controls.Add(label11);
			tabPage3.Controls.Add(label10);
			tabPage3.Controls.Add(maskedTextBoxDateOfProduction);
			tabPage3.Location = new Point(4, 30);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new Padding(3, 3, 3, 3);
			tabPage3.Size = new Size(631, 379);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Специальные";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// numericUpDownPoints
			// 
			numericUpDownPoints.BorderStyle = BorderStyle.FixedSingle;
			numericUpDownPoints.Enabled = false;
			numericUpDownPoints.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDownPoints.Increment = new decimal(new int[] { 10, 0, 0, 0 });
			numericUpDownPoints.Location = new Point(424, 149);
			numericUpDownPoints.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			numericUpDownPoints.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
			numericUpDownPoints.Name = "numericUpDownPoints";
			numericUpDownPoints.Size = new Size(64, 29);
			numericUpDownPoints.TabIndex = 26;
			numericUpDownPoints.TextAlign = HorizontalAlignment.Center;
			numericUpDownPoints.Value = new decimal(new int[] { 10, 0, 0, 0 });
			// 
			// textBoxPrice
			// 
			textBoxPrice.Location = new Point(424, 74);
			textBoxPrice.Name = "textBoxPrice";
			textBoxPrice.Size = new Size(100, 23);
			textBoxPrice.TabIndex = 27;
			textBoxPrice.KeyDown += textBoxPrice_KeyDown;
			textBoxPrice.Leave += textBoxPrice_Leave;
			// 
			// panel1
			// 
			panel1.Controls.Add(maskedTextBoxDiscount);
			panel1.Controls.Add(rbPromotionPoints);
			panel1.Controls.Add(maskedTextBoxPoints);
			panel1.Controls.Add(rbPromotionDiscount);
			panel1.Controls.Add(checkBoxPromotion);
			panel1.Location = new Point(397, 185);
			panel1.Name = "panel1";
			panel1.Size = new Size(200, 182);
			panel1.TabIndex = 25;
			// 
			// maskedTextBoxDiscount
			// 
			maskedTextBoxDiscount.Enabled = false;
			maskedTextBoxDiscount.Location = new Point(38, 70);
			maskedTextBoxDiscount.Mask = "00%";
			maskedTextBoxDiscount.Name = "maskedTextBoxDiscount";
			maskedTextBoxDiscount.Size = new Size(100, 23);
			maskedTextBoxDiscount.TabIndex = 25;
			// 
			// rbPromotionPoints
			// 
			rbPromotionPoints.AutoSize = true;
			rbPromotionPoints.Enabled = false;
			rbPromotionPoints.Location = new Point(38, 109);
			rbPromotionPoints.Name = "rbPromotionPoints";
			rbPromotionPoints.Size = new Size(58, 16);
			rbPromotionPoints.TabIndex = 24;
			rbPromotionPoints.Text = "Баллы";
			rbPromotionPoints.UseVisualStyleBackColor = true;
			// 
			// maskedTextBoxPoints
			// 
			maskedTextBoxPoints.Enabled = false;
			maskedTextBoxPoints.Location = new Point(38, 131);
			maskedTextBoxPoints.Mask = "00%";
			maskedTextBoxPoints.Name = "maskedTextBoxPoints";
			maskedTextBoxPoints.Size = new Size(100, 23);
			maskedTextBoxPoints.TabIndex = 26;
			// 
			// rbPromotionDiscount
			// 
			rbPromotionDiscount.AutoSize = true;
			rbPromotionDiscount.Enabled = false;
			rbPromotionDiscount.Location = new Point(38, 49);
			rbPromotionDiscount.Name = "rbPromotionDiscount";
			rbPromotionDiscount.Size = new Size(68, 16);
			rbPromotionDiscount.TabIndex = 23;
			rbPromotionDiscount.Text = "Скидка";
			rbPromotionDiscount.UseVisualStyleBackColor = true;
			// 
			// checkBoxPromotion
			// 
			checkBoxPromotion.AutoSize = true;
			checkBoxPromotion.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			checkBoxPromotion.Location = new Point(13, 17);
			checkBoxPromotion.Name = "checkBoxPromotion";
			checkBoxPromotion.Size = new Size(72, 25);
			checkBoxPromotion.TabIndex = 22;
			checkBoxPromotion.Text = "Акция";
			checkBoxPromotion.UseVisualStyleBackColor = true;
			checkBoxPromotion.CheckedChanged += checkBoxPromotion_CheckedChanged;
			// 
			// checkBoxPoints
			// 
			checkBoxPoints.AutoSize = true;
			checkBoxPoints.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			checkBoxPoints.Location = new Point(424, 114);
			checkBoxPoints.Name = "checkBoxPoints";
			checkBoxPoints.Size = new Size(73, 25);
			checkBoxPoints.TabIndex = 23;
			checkBoxPoints.Text = "Баллы";
			checkBoxPoints.UseVisualStyleBackColor = true;
			checkBoxPoints.CheckedChanged += checkBoxPoints_CheckedChanged;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label9.Location = new Point(424, 39);
			label9.Name = "label9";
			label9.Size = new Size(47, 21);
			label9.TabIndex = 19;
			label9.Text = "Цена";
			// 
			// dateTimePickerWarrantyPeriodEnd
			// 
			dateTimePickerWarrantyPeriodEnd.Location = new Point(53, 238);
			dateTimePickerWarrantyPeriodEnd.Name = "dateTimePickerWarrantyPeriodEnd";
			dateTimePickerWarrantyPeriodEnd.Size = new Size(200, 23);
			dateTimePickerWarrantyPeriodEnd.TabIndex = 18;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label12.Location = new Point(53, 197);
			label12.Name = "label12";
			label12.Size = new Size(192, 21);
			label12.TabIndex = 17;
			label12.Text = "Дата окончания гарантии";
			// 
			// labelWarrantyPeriod
			// 
			labelWarrantyPeriod.AutoSize = true;
			labelWarrantyPeriod.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelWarrantyPeriod.Location = new Point(135, 149);
			labelWarrantyPeriod.Name = "labelWarrantyPeriod";
			labelWarrantyPeriod.Size = new Size(34, 21);
			labelWarrantyPeriod.TabIndex = 16;
			labelWarrantyPeriod.Text = "год";
			// 
			// numericUpDownWarrantyPeriod
			// 
			numericUpDownWarrantyPeriod.BackColor = Color.White;
			numericUpDownWarrantyPeriod.BorderStyle = BorderStyle.FixedSingle;
			numericUpDownWarrantyPeriod.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDownWarrantyPeriod.Location = new Point(65, 147);
			numericUpDownWarrantyPeriod.Name = "numericUpDownWarrantyPeriod";
			numericUpDownWarrantyPeriod.Size = new Size(64, 29);
			numericUpDownWarrantyPeriod.TabIndex = 15;
			numericUpDownWarrantyPeriod.TextAlign = HorizontalAlignment.Center;
			numericUpDownWarrantyPeriod.UpDownAlign = LeftRightAlignment.Left;
			numericUpDownWarrantyPeriod.Value = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownWarrantyPeriod.ValueChanged += numericUpDownWarrantyPeriod_ValueChanged;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label11.Location = new Point(53, 114);
			label11.Name = "label11";
			label11.Size = new Size(138, 21);
			label11.TabIndex = 8;
			label11.Text = "Гарантийный срок";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label10.Location = new Point(53, 32);
			label10.Name = "label10";
			label10.Size = new Size(145, 21);
			label10.TabIndex = 7;
			label10.Text = "Дата производства";
			// 
			// maskedTextBoxDateOfProduction
			// 
			maskedTextBoxDateOfProduction.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			maskedTextBoxDateOfProduction.Location = new Point(53, 67);
			maskedTextBoxDateOfProduction.Mask = "00/00/0000";
			maskedTextBoxDateOfProduction.Name = "maskedTextBoxDateOfProduction";
			maskedTextBoxDateOfProduction.Size = new Size(145, 29);
			maskedTextBoxDateOfProduction.TabIndex = 0;
			maskedTextBoxDateOfProduction.ValidatingType = typeof(DateTime);
			maskedTextBoxDateOfProduction.KeyUp += maskedTextBoxYearOfProduction_KeyUp;
			maskedTextBoxDateOfProduction.Leave += maskedTextBoxYearOfProduction_Leave;
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = SystemColors.ControlLightLight;
			menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, AboutProgramToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 3;
			menuStrip1.Text = "menuStrip1";
			// 
			// FileToolStripMenuItem
			// 
			FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ttmiSave, ttmiLoad, ttmiQuit });
			FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			FileToolStripMenuItem.Size = new Size(46, 20);
			FileToolStripMenuItem.Text = "Файл";
			// 
			// ttmiSave
			// 
			ttmiSave.Name = "ttmiSave";
			ttmiSave.Size = new Size(132, 22);
			ttmiSave.Text = "Сохранить";
			ttmiSave.Click += ttmiSave_Click;
			// 
			// ttmiLoad
			// 
			ttmiLoad.Name = "ttmiLoad";
			ttmiLoad.Size = new Size(132, 22);
			ttmiLoad.Text = "Загрузить";
			ttmiLoad.Click += ttmiLoad_Click;
			// 
			// ttmiQuit
			// 
			ttmiQuit.Name = "ttmiQuit";
			ttmiQuit.Size = new Size(132, 22);
			ttmiQuit.Text = "Выйти";
			ttmiQuit.Click += ttmiQuit_Click;
			// 
			// AboutProgramToolStripMenuItem
			// 
			AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
			AboutProgramToolStripMenuItem.Size = new Size(90, 20);
			AboutProgramToolStripMenuItem.Text = "О программе";
			AboutProgramToolStripMenuItem.Click += AboutProgramToolStripMenuItem_Click;
			// 
			// buttonReloadDB
			// 
			buttonReloadDB.Location = new Point(11, 25);
			buttonReloadDB.Name = "buttonReloadDB";
			buttonReloadDB.Size = new Size(145, 18);
			buttonReloadDB.TabIndex = 5;
			buttonReloadDB.Text = "Обновить";
			buttonReloadDB.UseVisualStyleBackColor = true;
			buttonReloadDB.Click += buttonReloadDB_Click;
			// 
			// listBoxPhones
			// 
			listBoxPhones.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			listBoxPhones.FormattingEnabled = true;
			listBoxPhones.Location = new Point(11, 49);
			listBoxPhones.Name = "listBoxPhones";
			listBoxPhones.Size = new Size(145, 382);
			listBoxPhones.TabIndex = 6;
			listBoxPhones.DoubleClick += listBoxPhones_DoubleClick;
			// 
			// PhoneShopForm
			// 
			AutoScaleDimensions = new SizeF(6F, 12F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(800, 450);
			Controls.Add(listBoxPhones);
			Controls.Add(buttonReloadDB);
			Controls.Add(tabControl1);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Name = "PhoneShopForm";
			Text = "PhoneShop";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxPhoneImage).EndInit();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
			groupBoxCommunicationGeneration.ResumeLayout(false);
			groupBoxCommunicationGeneration.PerformLayout();
			((System.ComponentModel.ISupportInitialize)trackBarROM).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBarRAM).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfCameras).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownDiagonal).EndInit();
			tabPage3.ResumeLayout(false);
			tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownPoints).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownWarrantyPeriod).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem FileToolStripMenuItem;
		private ToolStripMenuItem AboutProgramToolStripMenuItem;
		private Label labelModel;
		private ComboBox comboBoxProducers;
		private Label labelProducer;
		private TextBox textBoxModel;
		private ComboBox comboBoxCountry;
		private Label labelCountry;
		private Label labelYOR;
		private PictureBox pictureBoxPhoneImage;
		private Label labelPhoto;
		private NumericUpDown numericUpDownDiagonal;
		private Label labelDiagonal;
		private NumericUpDown numericUpDownNumberOfCameras;
		private Label label3;
		private Label label4;
		private TrackBar trackBarRAM;
		private Label labelOM;
		private Label labelPM;
		private TrackBar trackBarROM;
		private Label label5;
		private ToolStripMenuItem ttmiSave;
		private ToolStripMenuItem ttmiLoad;
		private ToolStripMenuItem ttmiQuit;
		private Label label6;
		private ComboBox comboBoxSimType;
		private GroupBox groupBoxCommunicationGeneration;
		private RadioButton radioButton5G;
		private RadioButton radioButton4G;
		private Label label7;
		private NumericUpDown numericUpDownWeight;
		private RichTextBox richTextBoxAdditionalCharacteristics;
		private Label label8;
		private DateTimePicker dateTimePickerYearOfRelease;
		private MaskedTextBox maskedTextBoxDateOfProduction;
		private Label label10;
		private Label label11;
		private Label labelWarrantyPeriod;
		private NumericUpDown numericUpDownWarrantyPeriod;
		private Label label12;
		private CheckBox checkBoxPoints;
		private CheckBox checkBoxPromotion;
		private Label label9;
		private DateTimePicker dateTimePickerWarrantyPeriodEnd;
		private Panel panel1;
		private NumericUpDown numericUpDownPoints;
		private MaskedTextBox maskedTextBoxDiscount;
		private RadioButton rbPromotionPoints;
		private RadioButton rbPromotionDiscount;
		private TextBox textBoxPrice;
		private MaskedTextBox maskedTextBoxPoints;
		private Button buttonChooseImage;
		private Button buttonReloadDB;
		private Button buttonAddToDB;
		private ListBox listBoxPhones;
	}
}
