
namespace Демо
{
    partial class Склад
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Склад));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.номер = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.количество = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.название = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Склад";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вывод данных";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.номер,
            this.количество,
            this.название,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(684, 291);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // номер
            // 
            this.номер.Text = "№";
            this.номер.Width = 34;
            // 
            // количество
            // 
            this.количество.Text = "Название";
            this.количество.Width = 180;
            // 
            // название
            // 
            this.название.Text = "Кол-во";
            this.название.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Поставщик";
            this.columnHeader1.Width = 135;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "material_1.jpeg");
            this.imageList1.Images.SetKeyName(1, "material_2.jpeg");
            this.imageList1.Images.SetKeyName(2, "material_3.jpeg");
            this.imageList1.Images.SetKeyName(3, "material_4.jpeg");
            this.imageList1.Images.SetKeyName(4, "material_5.jpeg");
            this.imageList1.Images.SetKeyName(5, "material_6.jpeg");
            this.imageList1.Images.SetKeyName(6, "material_7.jpeg");
            this.imageList1.Images.SetKeyName(7, "material_8.jpeg");
            this.imageList1.Images.SetKeyName(8, "material_9.jpeg");
            this.imageList1.Images.SetKeyName(9, "material_10.jpeg");
            this.imageList1.Images.SetKeyName(10, "material_11.jpeg");
            this.imageList1.Images.SetKeyName(11, "material_12.jpeg");
            this.imageList1.Images.SetKeyName(12, "material_13.jpeg");
            this.imageList1.Images.SetKeyName(13, "material_14.jpeg");
            this.imageList1.Images.SetKeyName(14, "material_15.jpeg");
            this.imageList1.Images.SetKeyName(15, "material_16.jpeg");
            this.imageList1.Images.SetKeyName(16, "material_17.jpeg");
            this.imageList1.Images.SetKeyName(17, "material_18.jpeg");
            this.imageList1.Images.SetKeyName(18, "material_19.jpeg");
            this.imageList1.Images.SetKeyName(19, "material_20.jpeg");
            this.imageList1.Images.SetKeyName(20, "material_21.jpeg");
            this.imageList1.Images.SetKeyName(21, "material_22.jpeg");
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainUpDown2.Items.Add("Наименьшее кол-во");
            this.domainUpDown2.Items.Add("Наибольшее кол-во");
            this.domainUpDown2.Items.Add("Наименьшая единица измерения");
            this.domainUpDown2.Items.Add("Наибольшая единица измерения ");
            this.domainUpDown2.Location = new System.Drawing.Point(528, 12);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(168, 22);
            this.domainUpDown2.TabIndex = 5;
            this.domainUpDown2.Text = "Сортировка";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Единица измерения";
            this.columnHeader2.Width = 152;
            // 
            // Склад
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "Склад";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader номер;
        private System.Windows.Forms.ColumnHeader количество;
        private System.Windows.Forms.ColumnHeader название;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}