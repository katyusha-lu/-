
namespace Демо
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "picture.png");
            this.imageList1.Images.SetKeyName(1, "material_1.jpeg");
            this.imageList1.Images.SetKeyName(2, "material_2.jpeg");
            this.imageList1.Images.SetKeyName(3, "material_3.jpeg");
            this.imageList1.Images.SetKeyName(4, "material_4.jpeg");
            this.imageList1.Images.SetKeyName(5, "material_5.jpeg");
            this.imageList1.Images.SetKeyName(6, "material_6.jpeg");
            this.imageList1.Images.SetKeyName(7, "material_7.jpeg");
            this.imageList1.Images.SetKeyName(8, "material_8.jpeg");
            this.imageList1.Images.SetKeyName(9, "material_9.jpeg");
            this.imageList1.Images.SetKeyName(10, "material_10.jpeg");
            this.imageList1.Images.SetKeyName(11, "material_11.jpeg");
            this.imageList1.Images.SetKeyName(12, "material_12.jpeg");
            this.imageList1.Images.SetKeyName(13, "material_13.jpeg");
            this.imageList1.Images.SetKeyName(14, "material_14.jpeg");
            this.imageList1.Images.SetKeyName(15, "material_15.jpeg");
            this.imageList1.Images.SetKeyName(16, "material_16.jpeg");
            this.imageList1.Images.SetKeyName(17, "material_17.jpeg");
            this.imageList1.Images.SetKeyName(18, "material_18.jpeg");
            this.imageList1.Images.SetKeyName(19, "material_19.jpeg");
            this.imageList1.Images.SetKeyName(20, "material_20.jpeg");
            this.imageList1.Images.SetKeyName(21, "material_21.jpeg");
            this.imageList1.Images.SetKeyName(22, "material_22.jpeg");
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainUpDown2.Items.Add("По возрастанию");
            this.domainUpDown2.Items.Add("По убыванию ");
            this.domainUpDown2.Items.Add("Наименование");
            this.domainUpDown2.Items.Add("Остаток на складе ");
            this.domainUpDown2.Items.Add("Стоимость");
            this.domainUpDown2.Location = new System.Drawing.Point(339, 24);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(168, 22);
            this.domainUpDown2.TabIndex = 3;
            this.domainUpDown2.Text = "Сортировка";
            this.domainUpDown2.SelectedItemChanged += new System.EventHandler(this.domainUpDown2_SelectedItemChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(23, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 33);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Поиск";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(42, 71);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(479, 94);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(42, 187);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(479, 94);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(42, 301);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(479, 94);
            this.richTextBox3.TabIndex = 9;
            this.richTextBox3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(189, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Тип материала | Наименование";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(189, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тип материала | Наименование";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(189, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Тип материала | Наименование";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Демо.Properties.Resources.picture;
            this.pictureBox4.Location = new System.Drawing.Point(54, 321);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(82, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Демо.Properties.Resources.picture;
            this.pictureBox2.Location = new System.Drawing.Point(54, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Демо.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(54, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(510, 71);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 94);
            this.vScrollBar1.TabIndex = 13;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(510, 187);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 94);
            this.vScrollBar2.TabIndex = 14;
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(510, 301);
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(17, 94);
            this.vScrollBar3.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Все типы",
            "Резина 1x3",
            "Краска 2x3",
            "Резина 3x3",
            "Краска 1x4",
            "Резина 1x37",
            "Резина 2x0",
            "Резина 1x14",
            "Силикон 3x33",
            "Резина 3x22",
            "Резина 2x1",
            "Краска 1x2",
            "Резина 2x3",
            "Силикон 1x27",
            "Краска 3x14",
            "Краска 2x5",
            "Силикон 3x15",
            "Силикон 3x39",
            "Силикон 1x2",
            "Силикон 3x28",
            "Силикон 0x18",
            "Силикон 0x0",
            "Краска 3x31",
            "Резина 1x5",
            "Силикон 0x12",
            "Силикон 3x2",
            "Резина 1x9",
            "Краска 3x35",
            "Краска 2x31",
            "Резина 3x25",
            "Краска 4x0",
            "Краска 2x4",
            "Резина 1x0",
            "Краска 3x2",
            "Краска 3x0",
            "Краска 2x29",
            "Силикон 3x14",
            "Силикон 3x3",
            "Силикон 3x18",
            "Резина 3x37",
            "Краска 0x4",
            "Краска 2x1",
            "Резина 0x0",
            "Краска 4x3",
            "Резина 11x0",
            "Резина 0x2",
            "Краска 0x5",
            "Резина 3x2",
            "Силикон 1x22",
            "Краска 2x0",
            "Краска 0x2",
            "Силикон 2x2",
            "Резина 0x13",
            "Резина 0x78",
            "Краска 2x2",
            "Силикон 0x2",
            "Резина 0x10",
            "Резина 3x23",
            "Резина 2x35",
            "Силикон 0x3",
            "Резина 2x2",
            "Краска 0x3",
            "Резина 0x12",
            "Краска 3x27",
            "Резина 2x27",
            "Силикон 0x28",
            "Резина 1x1",
            "Резина 0x30",
            "Силикон 0x23",
            "Силикон 2x13",
            "Резина 0x3",
            "Краска 4x04",
            "Резина 1x32",
            "Силикон 1x1",
            "Резина 3x1",
            "Резина 0x65",
            "Силикон 0x11",
            "Краска 0x0",
            "Краска 2x24",
            "Краска 0x1",
            "Резина 3x38",
            "Резина 3x28",
            "Краска 3x18",
            "Силикон 0x1",
            "Краска 1x0",
            "Краска 3x1",
            "Силикон 3x0",
            "Силикон 3x35",
            "Краска 1x1",
            "Силикон 2x17",
            "Резина 0x1",
            "Силикон 3x1",
            "Силикон 2x1",
            "Резина 0x37",
            "Силикон 3x37",
            "Краска 5x0",
            "Резина 3x34",
            "Краска 3x13",
            "Краска 3x4",
            "Краска 1x3",
            "Краска 2x28"});
            this.listBox1.Location = new System.Drawing.Point(545, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 469);
            this.listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(667, 488);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.vScrollBar3);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.richTextBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

