namespace UTMForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.Chromium = new CefSharp.WinForms.ChromiumWebBrowser();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Получить статус";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Ping",
            "Загрузка страницы УТМ",
            "Статус службы"});
            this.checkedListBox1.Location = new System.Drawing.Point(13, 68);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(165, 49);
            this.checkedListBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(13, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Получить статус службы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(11, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Перезагрузка ПК по IP";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 320);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 60);
            this.textBox2.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(12, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Загрузить страницу утм";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Chromium
            // 
            this.Chromium.ActivateBrowserOnCreation = false;
            this.Chromium.Location = new System.Drawing.Point(184, 12);
            this.Chromium.Name = "Chromium";
            this.Chromium.Size = new System.Drawing.Size(557, 426);
            this.Chromium.TabIndex = 10;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(13, 387);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 51);
            this.button7.TabIndex = 11;
            this.button7.Text = "Сброс и проверка другой УТМ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(13, 181);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(164, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "Перезагрузить Transport";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(11, 290);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(167, 24);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "192.168.77.14\tАО \"ЕЭК\"",
            "10.1.145.80\tЖар",
            "172.21.14.14\tИП Барабанова Светлана Сергеевна",
            "192.168.86.80\tИП Винокурова З. М.",
            "172.21.11.14\tИП Митяшина",
            "192.168.27.14\tООО \"Авиор\"",
            "192.168.50.15\tООО \"АйРан\"",
            "192.168.52.14\tООО \"Аккорд\"",
            "192.168.42.15\tООО \"Алнаир\"",
            "192.168.56.14\tООО \"Алькасар\"",
            "192.168.82.15\tООО \"Алькес",
            "192.168.2.14\tООО \"Алькор\"",
            "192.168.64.11\tООО \"Альянс\"",
            "192.168.78.14\tООО \"А-Приори\"",
            "192.168.51.0\tООО \"Арвена\"",
            "192.168.7.14\tООО \"АркаДа\"",
            "192.168.59.14\tООО \"Артель\"",
            "192.168.251.0\tООО \"АСТАРТА\"",
            "172.21.5.14\tООО \"АТЛАС ФУД\"",
            "192.168.11.14\tООО \"Белшир\"",
            "192.168.17.15\tООО \"Бизнес Старт\"",
            "192.168.111.14\tООО \"БРИГАНТИНА\"",
            "172.21.3.14\tООО \"БУРГЕР ХИРОУС\"",
            "172.21.13.14\tООО \"БУРГЕР ХИРОУС\"",
            "172.21.7.14\tООО \"БУРГЕР ХИРОУС\"",
            "192.168.20.14\tООО \"Ванкор\"",
            "192.168.113.14\tООО \"Варрон\"",
            "192.168.25.14\tООО \"Вейкар\"",
            "192.168.5.14\tООО \"Венигрет\"",
            "192.168.95.14\tООО \"Виолла\"",
            "192.168.249.98\tООО \"ВОЛНА\"",
            "192.168.251.138\tООО \"Галакс\"",
            "192.168.000.000\tООО \"Гуд-Мил\"",
            "192.168.74.15\tООО \"Десерт\"",
            "192.168.251.55\tООО \"ИДЕАЛ\"",
            "192.168.16.12\tООО \"ИНТ-Проджект\"",
            "192.168.32.14\tООО \"Ирис\" ",
            "192.168.46.14\tООО \"КАСКАД\"",
            "192.168.254.14\tООО \"Костер\"",
            "10.1.153.14\tООО \"КРУМНИЦА\"",
            "192.168.84.14\tООО \"Ла Бон Буфф\"",
            "192.168.251.36\tООО \"Лайн\" ",
            "192.168.40.15\tООО \"Лантер\"",
            "192.168.54.14\tООО \"ЛЕОН\"",
            "172.23.12.10\tООО \"ЛЕС\"",
            "192.168.13.14\tООО \"МАРСЕЛЬ\"",
            "192.168.17.14\tООО \"Мелида\"",
            "192.168.251.14\tООО \"МЕРКУРИЙ\"",
            "192.168.254.98\tООО \"МИНКАР\"",
            "192.168.91.14\tООО \"МОНМАРТ\"",
            "192.168.93.14\tООО \"Монтонико\"",
            "192.168.51.14\tООО \"Навои\"",
            "192.168.68.14\tООО \"Нома\"",
            "192.168.3.14\tООО \"Оазис\"",
            "192.168.34.14\tООО \"ОБЕДОВ\"",
            "192.168.43.14\tООО \"Олимп\"",
            "192.168.91.228\tООО \"Оникс\"",
            "192.168.4.14\tООО \"Опера\"",
            "192.168.50.14\tООО \"ОРИОНА\"",
            "10.1.128.14\tООО \"ПАНОРАМА-ПАРК\"",
            "192.168.60.14\tООО \"ПАРУС\"",
            "192.168.69.14\tООО \"Плов Бери Проджект\"",
            "192.168.90.14\tООО \"Премиум\"",
            "192.168.73.14\tООО \"ПРИНТ\"",
            "10.1.131.14\tООО \"Просперо\"",
            "192.168.40.12\tООО \"Пушкинский\"",
            "172.21.1.14\tООО \"РЕ-СЕТ\"",
            "172.21.3.16\tООО \"РЕ-СЕТ\"",
            "10.1.131.15\tООО \"Рестопаркинг\"",
            "192.168.89.14\tООО \"РИСОНТ\"",
            "192.168.20.15\tООО \"Самарканд\"",
            "192.168.112.14\tООО \"Самплов\"",
            "192.168.85.14\tООО \"Север\"",
            "192.168.24.14\tООО \"СоуНайс\"",
            "192.168.9.14\tООО \"ТАРВОС\"",
            "192.168.92.14\tООО \"Ташкент\"",
            "192.168.44.14\tООО \"Топчан\"",
            "192.168.94.14\tООО \"ТРИУМФ ТРЕЙД\"",
            "172.23.16.101\tООО \"Фалькон\" (веранда)",
            "172.23.11.10\tООО \"Фалькон\" (русский ресторан)",
            "192.168.33.15\tООО \"Фергана\"",
            "192.168.6.15\tООО \"ФЛОРА\"",
            "172.21.6.14\tООО \"ФО\"",
            "192.168.71.14\tООО \"ФУДМАСТЕР\"",
            "10.2.0.14\tООО \"ХОТ ДОГ БУЛЬДОГ\"",
            "10.2.0.119\tООО \"ХОТ ДОГ БУЛЬДОГ\"",
            "192.168.15.14\tООО \"ЧАЙХОНА САРАТОВ\"",
            "192.168.47.14\tООО \"Чайхона\"",
            "192.168.81.14\tООО \"Чайхона-Ростов\"",
            "192.168.21.14\tООО \"ЧАЙХОНА-СОЧИ\"",
            "172.21.10.14\tООО \"Черная Мамба\" (камергерский)",
            "192.168.1.15\tООО \"Шеллер\"",
            "192.168.40.14\tООО \"Шукран\"",
            "192.168.1.14\tООО \"ЭкономТехТорг\"",
            "192.168.14.14\tООО \"Эридан\"",
            "192.168.90.15\tООО «АЭРОФУДСИСТЕМ»",
            "192.168.72.14\tООО «Ланч»",
            "10.1.137.10\tООО «Фуд ловерс» ",
            "192.168.74.14\tООО ЛесАрт",
            "192.168.117.14\tТК \"Пайлтех\""});
            this.listBox1.Location = new System.Drawing.Point(748, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 420);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Тест";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Chromium);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UTM Fast controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private CefSharp.WinForms.ChromiumWebBrowser Chromium;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
    }
}

