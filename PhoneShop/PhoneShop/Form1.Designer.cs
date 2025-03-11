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
			dateTimePickerYearOfRelease = new DateTimePicker();
			pictureBox1 = new PictureBox();
			labelPhoto = new Label();
			labelYOR = new Label();
			comboBoxCountry = new ComboBox();
			labelCountry = new Label();
			comboBoxProducers = new ComboBox();
			labelProducer = new Label();
			textBoxModel = new TextBox();
			labelModel = new Label();
			tabPage2 = new TabPage();
			richTextBox1 = new RichTextBox();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			numericUpDown3 = new NumericUpDown();
			groupBox1 = new GroupBox();
			radioButton5G = new RadioButton();
			radioButton4G = new RadioButton();
			label6 = new Label();
			comboBoxSimType = new ComboBox();
			labelPM = new Label();
			trackBarPM = new TrackBar();
			label5 = new Label();
			labelOM = new Label();
			label4 = new Label();
			trackBarOM = new TrackBar();
			numericUpDown2 = new NumericUpDown();
			label3 = new Label();
			numericUpDown1 = new NumericUpDown();
			labelDiagonal = new Label();
			tabPage3 = new TabPage();
			maskedTextBox1 = new MaskedTextBox();
			label1 = new Label();
			label2 = new Label();
			menuStrip1 = new MenuStrip();
			FileToolStripMenuItem = new ToolStripMenuItem();
			сохранитьToolStripMenuItem = new ToolStripMenuItem();
			загрузитьToolStripMenuItem = new ToolStripMenuItem();
			выйтиToolStripMenuItem = new ToolStripMenuItem();
			AboutProgramToolStripMenuItem = new ToolStripMenuItem();
			label10 = new Label();
			label11 = new Label();
			numericUpDownWarrantyPeriod = new NumericUpDown();
			labelWarrantyPeriod = new Label();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)trackBarPM).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBarOM).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			tabPage3.SuspendLayout();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownWarrantyPeriod).BeginInit();
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
			tabPage1.Controls.Add(dateTimePickerYearOfRelease);
			tabPage1.Controls.Add(pictureBox1);
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
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(631, 387);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Общие";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// dateTimePickerYearOfRelease
			// 
			dateTimePickerYearOfRelease.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			dateTimePickerYearOfRelease.Location = new Point(21, 221);
			dateTimePickerYearOfRelease.Name = "dateTimePickerYearOfRelease";
			dateTimePickerYearOfRelease.Size = new Size(211, 29);
			dateTimePickerYearOfRelease.TabIndex = 10;
			// 
			// pictureBox1
			// 
			pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
			pictureBox1.Location = new Point(307, 53);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(290, 310);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 9;
			pictureBox1.TabStop = false;
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
			labelYOR.Location = new Point(21, 187);
			labelYOR.Name = "labelYOR";
			labelYOR.Size = new Size(94, 21);
			labelYOR.TabIndex = 6;
			labelYOR.Text = "Год выпуска";
			// 
			// comboBoxCountry
			// 
			comboBoxCountry.FormattingEnabled = true;
			comboBoxCountry.Location = new Point(21, 148);
			comboBoxCountry.Name = "comboBoxCountry";
			comboBoxCountry.Size = new Size(211, 20);
			comboBoxCountry.TabIndex = 5;
			// 
			// labelCountry
			// 
			labelCountry.AutoSize = true;
			labelCountry.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelCountry.Location = new Point(27, 121);
			labelCountry.Name = "labelCountry";
			labelCountry.Size = new Size(60, 21);
			labelCountry.TabIndex = 4;
			labelCountry.Text = "Страна";
			// 
			// comboBoxProducers
			// 
			comboBoxProducers.FormattingEnabled = true;
			comboBoxProducers.Location = new Point(22, 95);
			comboBoxProducers.Name = "comboBoxProducers";
			comboBoxProducers.Size = new Size(210, 20);
			comboBoxProducers.Sorted = true;
			comboBoxProducers.TabIndex = 3;
			// 
			// labelProducer
			// 
			labelProducer.AutoSize = true;
			labelProducer.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelProducer.Location = new Point(22, 67);
			labelProducer.Name = "labelProducer";
			labelProducer.Size = new Size(120, 21);
			labelProducer.TabIndex = 2;
			labelProducer.Text = "Производитель";
			// 
			// textBoxModel
			// 
			textBoxModel.Location = new Point(22, 36);
			textBoxModel.Name = "textBoxModel";
			textBoxModel.Size = new Size(210, 23);
			textBoxModel.TabIndex = 1;
			// 
			// labelModel
			// 
			labelModel.AutoSize = true;
			labelModel.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelModel.Location = new Point(24, 10);
			labelModel.Name = "labelModel";
			labelModel.Size = new Size(66, 21);
			labelModel.TabIndex = 0;
			labelModel.Text = "Модель";
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(richTextBox1);
			tabPage2.Controls.Add(label9);
			tabPage2.Controls.Add(label8);
			tabPage2.Controls.Add(label7);
			tabPage2.Controls.Add(numericUpDown3);
			tabPage2.Controls.Add(groupBox1);
			tabPage2.Controls.Add(label6);
			tabPage2.Controls.Add(comboBoxSimType);
			tabPage2.Controls.Add(labelPM);
			tabPage2.Controls.Add(trackBarPM);
			tabPage2.Controls.Add(label5);
			tabPage2.Controls.Add(labelOM);
			tabPage2.Controls.Add(label4);
			tabPage2.Controls.Add(trackBarOM);
			tabPage2.Controls.Add(numericUpDown2);
			tabPage2.Controls.Add(label3);
			tabPage2.Controls.Add(numericUpDown1);
			tabPage2.Controls.Add(labelDiagonal);
			tabPage2.Location = new Point(4, 22);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(631, 387);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Технические";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(381, 63);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(230, 318);
			richTextBox1.TabIndex = 18;
			richTextBox1.Text = "";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(284, 125);
			label9.Name = "label9";
			label9.Size = new Size(40, 12);
			label9.TabIndex = 17;
			label9.Text = "label9";
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
			// numericUpDown3
			// 
			numericUpDown3.BorderStyle = BorderStyle.FixedSingle;
			numericUpDown3.DecimalPlaces = 1;
			numericUpDown3.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDown3.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
			numericUpDown3.Location = new Point(190, 212);
			numericUpDown3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
			numericUpDown3.Name = "numericUpDown3";
			numericUpDown3.Size = new Size(158, 29);
			numericUpDown3.TabIndex = 14;
			numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 65536 });
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(radioButton5G);
			groupBox1.Controls.Add(radioButton4G);
			groupBox1.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			groupBox1.Location = new Point(14, 234);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(148, 122);
			groupBox1.TabIndex = 13;
			groupBox1.TabStop = false;
			groupBox1.Text = "Поколение связи";
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
			label6.Location = new Point(17, 154);
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
			// trackBarPM
			// 
			trackBarPM.LargeChange = 16;
			trackBarPM.Location = new Point(190, 130);
			trackBarPM.Maximum = 1024;
			trackBarPM.Minimum = 16;
			trackBarPM.Name = "trackBarPM";
			trackBarPM.Size = new Size(158, 45);
			trackBarPM.SmallChange = 16;
			trackBarPM.TabIndex = 9;
			trackBarPM.TickFrequency = 16;
			trackBarPM.Value = 16;
			trackBarPM.ValueChanged += trackBarPM_ValueChanged;
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
			// trackBarOM
			// 
			trackBarOM.LargeChange = 2;
			trackBarOM.Location = new Point(190, 42);
			trackBarOM.Maximum = 16;
			trackBarOM.Minimum = 1;
			trackBarOM.Name = "trackBarOM";
			trackBarOM.Size = new Size(158, 45);
			trackBarOM.TabIndex = 5;
			trackBarOM.TickFrequency = 2;
			trackBarOM.Value = 1;
			trackBarOM.ValueChanged += trackBarOM_ValueChanged;
			// 
			// numericUpDown2
			// 
			numericUpDown2.BorderStyle = BorderStyle.FixedSingle;
			numericUpDown2.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDown2.Location = new Point(17, 112);
			numericUpDown2.Name = "numericUpDown2";
			numericUpDown2.Size = new Size(139, 29);
			numericUpDown2.TabIndex = 4;
			numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label3.Location = new Point(17, 79);
			label3.Name = "label3";
			label3.Size = new Size(139, 21);
			label3.TabIndex = 3;
			label3.Text = "Количество камер";
			// 
			// numericUpDown1
			// 
			numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
			numericUpDown1.DecimalPlaces = 1;
			numericUpDown1.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
			numericUpDown1.Location = new Point(17, 42);
			numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(139, 29);
			numericUpDown1.TabIndex = 2;
			numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
			// 
			// labelDiagonal
			// 
			labelDiagonal.AutoSize = true;
			labelDiagonal.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelDiagonal.Location = new Point(39, 13);
			labelDiagonal.Name = "labelDiagonal";
			labelDiagonal.Size = new Size(86, 21);
			labelDiagonal.TabIndex = 1;
			labelDiagonal.Text = "Диагональ";
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(labelWarrantyPeriod);
			tabPage3.Controls.Add(numericUpDownWarrantyPeriod);
			tabPage3.Controls.Add(label11);
			tabPage3.Controls.Add(label10);
			tabPage3.Controls.Add(maskedTextBox1);
			tabPage3.Location = new Point(4, 22);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new Padding(3);
			tabPage3.Size = new Size(631, 387);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Специальные";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// maskedTextBox1
			// 
			maskedTextBox1.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			maskedTextBox1.Location = new Point(17, 48);
			maskedTextBox1.Mask = "00/00/0000";
			maskedTextBox1.Name = "maskedTextBox1";
			maskedTextBox1.Size = new Size(145, 29);
			maskedTextBox1.TabIndex = 0;
			maskedTextBox1.ValidatingType = typeof(DateTime);
			maskedTextBox1.KeyUp += maskedTextBox1_KeyUp;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 86);
			label1.Name = "label1";
			label1.Size = new Size(116, 12);
			label1.TabIndex = 1;
			label1.Text = "строки из таблицы";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 46);
			label2.Name = "label2";
			label2.Size = new Size(95, 12);
			label2.TabIndex = 2;
			label2.Text = "строка поиска";
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
			menuStrip1.ItemClicked += menuStrip1_ItemClicked;
			// 
			// FileToolStripMenuItem
			// 
			FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, загрузитьToolStripMenuItem, выйтиToolStripMenuItem });
			FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			FileToolStripMenuItem.Size = new Size(46, 20);
			FileToolStripMenuItem.Text = "Файл";
			// 
			// сохранитьToolStripMenuItem
			// 
			сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			сохранитьToolStripMenuItem.Size = new Size(132, 22);
			сохранитьToolStripMenuItem.Text = "Сохранить";
			// 
			// загрузитьToolStripMenuItem
			// 
			загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
			загрузитьToolStripMenuItem.Size = new Size(132, 22);
			загрузитьToolStripMenuItem.Text = "Загрузить";
			// 
			// выйтиToolStripMenuItem
			// 
			выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
			выйтиToolStripMenuItem.Size = new Size(132, 22);
			выйтиToolStripMenuItem.Text = "Выйти";
			// 
			// AboutProgramToolStripMenuItem
			// 
			AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
			AboutProgramToolStripMenuItem.Size = new Size(90, 20);
			AboutProgramToolStripMenuItem.Text = "О программе";
			AboutProgramToolStripMenuItem.Click += AboutProgramToolStripMenuItem_Click;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label10.Location = new Point(17, 13);
			label10.Name = "label10";
			label10.Size = new Size(145, 21);
			label10.TabIndex = 7;
			label10.Text = "Дата производства";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label11.Location = new Point(17, 95);
			label11.Name = "label11";
			label11.Size = new Size(138, 21);
			label11.TabIndex = 8;
			label11.Text = "Гарантийный срок";
			// 
			// numericUpDownWarrantyPeriod
			// 
			numericUpDownWarrantyPeriod.BorderStyle = BorderStyle.FixedSingle;
			numericUpDownWarrantyPeriod.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDownWarrantyPeriod.Location = new Point(29, 128);
			numericUpDownWarrantyPeriod.Name = "numericUpDownWarrantyPeriod";
			numericUpDownWarrantyPeriod.Size = new Size(64, 29);
			numericUpDownWarrantyPeriod.TabIndex = 15;
			numericUpDownWarrantyPeriod.TextAlign = HorizontalAlignment.Center;
			numericUpDownWarrantyPeriod.UpDownAlign = LeftRightAlignment.Left;
			numericUpDownWarrantyPeriod.Value = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownWarrantyPeriod.ValueChanged += numericUpDownWarrantyPeriod_ValueChanged;
			// 
			// labelWarrantyPeriod
			// 
			labelWarrantyPeriod.AutoSize = true;
			labelWarrantyPeriod.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelWarrantyPeriod.Location = new Point(99, 130);
			labelWarrantyPeriod.Name = "labelWarrantyPeriod";
			labelWarrantyPeriod.Size = new Size(34, 21);
			labelWarrantyPeriod.TabIndex = 16;
			labelWarrantyPeriod.Text = "год";
			// 
			// PhoneShopForm
			// 
			AutoScaleDimensions = new SizeF(6F, 12F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(800, 450);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tabControl1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "PhoneShopForm";
			Text = "PhoneShop";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)trackBarPM).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBarOM).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			tabPage3.ResumeLayout(false);
			tabPage3.PerformLayout();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownWarrantyPeriod).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private Label label1;
		private Label label2;
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
		private PictureBox pictureBox1;
		private Label labelPhoto;
		private NumericUpDown numericUpDown1;
		private Label labelDiagonal;
		private NumericUpDown numericUpDown2;
		private Label label3;
		private Label label4;
		private TrackBar trackBarOM;
		private Label labelOM;
		private Label labelPM;
		private TrackBar trackBarPM;
		private Label label5;
		private ToolStripMenuItem сохранитьToolStripMenuItem;
		private ToolStripMenuItem загрузитьToolStripMenuItem;
		private ToolStripMenuItem выйтиToolStripMenuItem;
		private Label label6;
		private ComboBox comboBoxSimType;
		private GroupBox groupBox1;
		private RadioButton radioButton5G;
		private RadioButton radioButton4G;
		private Label label7;
		private NumericUpDown numericUpDown3;
		private RichTextBox richTextBox1;
		private Label label9;
		private Label label8;
		private DateTimePicker dateTimePickerYearOfRelease;
		private MaskedTextBox maskedTextBox1;
		private Label label10;
		private Label label11;
		private Label labelWarrantyPeriod;
		private NumericUpDown numericUpDownWarrantyPeriod;
	}
}
