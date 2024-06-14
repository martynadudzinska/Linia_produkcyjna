using System.Diagnostics;

namespace Linia_produkcyjna
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.login = new System.Windows.Forms.MaskedTextBox();
            this.enter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.MaskedTextBox();
            this.suwak = new System.Windows.Forms.TrackBar();
            this.timerPieczenie = new System.Windows.Forms.Timer(this.components);
            this.tort0 = new System.Windows.Forms.PictureBox();
            this.ciastko0 = new System.Windows.Forms.PictureBox();
            this.babeczka0 = new System.Windows.Forms.PictureBox();
            this.ciasto0 = new System.Windows.Forms.PictureBox();
            this.tort = new System.Windows.Forms.PictureBox();
            this.ciastko = new System.Windows.Forms.PictureBox();
            this.babeczka = new System.Windows.Forms.PictureBox();
            this.ciasto = new System.Windows.Forms.PictureBox();
            this.timerWybor = new System.Windows.Forms.Timer(this.components);
            this.tortspalony = new System.Windows.Forms.PictureBox();
            this.babeczkaspalona = new System.Windows.Forms.PictureBox();
            this.ciastkospalone = new System.Windows.Forms.PictureBox();
            this.ciastospalone = new System.Windows.Forms.PictureBox();
            this.obecnoscTxt = new System.Windows.Forms.TextBox();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.timerOdliczanie = new System.Windows.Forms.Timer(this.components);
            this.txtOdliczanie = new System.Windows.Forms.TextBox();
            this.timerPomocniczy = new System.Windows.Forms.Timer(this.components);
            this.timerObecnosc = new System.Windows.Forms.Timer(this.components);
            this.temperaturaTxt = new System.Windows.Forms.TextBox();
            this.timerTemperatura = new System.Windows.Forms.Timer(this.components);
            this.textInfo = new System.Windows.Forms.TextBox();
            this.textWiatrak = new System.Windows.Forms.TextBox();
            this.textWartości = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.zuzycieText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.suwak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tort0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciastko0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.babeczka0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciasto0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciastko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.babeczka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tortspalony)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.babeczkaspalona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciastkospalone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciastospalone)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AsciiOnly = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login.ForeColor = System.Drawing.Color.DarkRed;
            this.login.Location = new System.Drawing.Point(340, 186);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(218, 30);
            this.login.TabIndex = 3;
            this.login.Text = "login";
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Transparent;
            this.enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enter.ForeColor = System.Drawing.Color.DarkRed;
            this.enter.Location = new System.Drawing.Point(608, 217);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(109, 49);
            this.enter.TabIndex = 4;
            this.enter.Text = "Enter";
            this.enter.UseMnemonic = false;
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox1.Location = new System.Drawing.Point(205, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(495, 45);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Proszę wprowadzić login i hasło";
            // 
            // haslo
            // 
            this.haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslo.ForeColor = System.Drawing.Color.DarkRed;
            this.haslo.Location = new System.Drawing.Point(340, 279);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(218, 30);
            this.haslo.TabIndex = 7;
            this.haslo.Text = "hasło";
            this.haslo.UseSystemPasswordChar = true;
            // 
            // suwak
            // 
            this.suwak.AutoSize = false;
            this.suwak.BackColor = System.Drawing.Color.LavenderBlush;
            this.suwak.Location = new System.Drawing.Point(457, 306);
            this.suwak.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.suwak.Maximum = 3;
            this.suwak.Name = "suwak";
            this.suwak.Size = new System.Drawing.Size(202, 44);
            this.suwak.TabIndex = 9;
            this.suwak.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // timerPieczenie
            // 
            this.timerPieczenie.Interval = 38;
            this.timerPieczenie.Tick += new System.EventHandler(this.Pieczenie);
            // 
            // tort0
            // 
            this.tort0.BackColor = System.Drawing.Color.Transparent;
            this.tort0.Image = global::Linia_produkcyjna.Properties.Resources.machina;
            this.tort0.Location = new System.Drawing.Point(562, 235);
            this.tort0.Name = "tort0";
            this.tort0.Size = new System.Drawing.Size(58, 65);
            this.tort0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tort0.TabIndex = 10;
            this.tort0.TabStop = false;
            // 
            // ciastko0
            // 
            this.ciastko0.BackColor = System.Drawing.Color.Transparent;
            this.ciastko0.Image = global::Linia_produkcyjna.Properties.Resources.ciastko1;
            this.ciastko0.Location = new System.Drawing.Point(444, 249);
            this.ciastko0.Name = "ciastko0";
            this.ciastko0.Size = new System.Drawing.Size(55, 51);
            this.ciastko0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ciastko0.TabIndex = 11;
            this.ciastko0.TabStop = false;
            // 
            // babeczka0
            // 
            this.babeczka0.BackColor = System.Drawing.Color.Transparent;
            this.babeczka0.Image = global::Linia_produkcyjna.Properties.Resources.babeczka;
            this.babeczka0.Location = new System.Drawing.Point(505, 247);
            this.babeczka0.Name = "babeczka0";
            this.babeczka0.Size = new System.Drawing.Size(51, 53);
            this.babeczka0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.babeczka0.TabIndex = 12;
            this.babeczka0.TabStop = false;
            // 
            // ciasto0
            // 
            this.ciasto0.BackColor = System.Drawing.Color.Transparent;
            this.ciasto0.Image = global::Linia_produkcyjna.Properties.Resources.ciasto;
            this.ciasto0.Location = new System.Drawing.Point(626, 261);
            this.ciasto0.Name = "ciasto0";
            this.ciasto0.Size = new System.Drawing.Size(46, 39);
            this.ciasto0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ciasto0.TabIndex = 13;
            this.ciasto0.TabStop = false;
            // 
            // tort
            // 
            this.tort.BackColor = System.Drawing.Color.Transparent;
            this.tort.Image = global::Linia_produkcyjna.Properties.Resources.machina;
            this.tort.Location = new System.Drawing.Point(745, 84);
            this.tort.Name = "tort";
            this.tort.Size = new System.Drawing.Size(131, 127);
            this.tort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tort.TabIndex = 14;
            this.tort.TabStop = false;
            // 
            // ciastko
            // 
            this.ciastko.BackColor = System.Drawing.Color.Transparent;
            this.ciastko.Image = global::Linia_produkcyjna.Properties.Resources.ciastko1;
            this.ciastko.Location = new System.Drawing.Point(745, 186);
            this.ciastko.Name = "ciastko";
            this.ciastko.Size = new System.Drawing.Size(124, 102);
            this.ciastko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ciastko.TabIndex = 15;
            this.ciastko.TabStop = false;
            // 
            // babeczka
            // 
            this.babeczka.BackColor = System.Drawing.Color.Transparent;
            this.babeczka.Image = global::Linia_produkcyjna.Properties.Resources.babeczka;
            this.babeczka.Location = new System.Drawing.Point(723, 142);
            this.babeczka.Name = "babeczka";
            this.babeczka.Size = new System.Drawing.Size(88, 86);
            this.babeczka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.babeczka.TabIndex = 16;
            this.babeczka.TabStop = false;
            // 
            // ciasto
            // 
            this.ciasto.BackColor = System.Drawing.Color.Transparent;
            this.ciasto.Image = global::Linia_produkcyjna.Properties.Resources.ciasto;
            this.ciasto.Location = new System.Drawing.Point(716, 416);
            this.ciasto.Name = "ciasto";
            this.ciasto.Size = new System.Drawing.Size(95, 78);
            this.ciasto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ciasto.TabIndex = 17;
            this.ciasto.TabStop = false;
            // 
            // timerWybor
            // 
            this.timerWybor.Interval = 2000;
            this.timerWybor.Tick += new System.EventHandler(this.Wybor);
            // 
            // tortspalony
            // 
            this.tortspalony.BackColor = System.Drawing.Color.Transparent;
            this.tortspalony.Image = global::Linia_produkcyjna.Properties.Resources.tortspalony;
            this.tortspalony.Location = new System.Drawing.Point(626, 89);
            this.tortspalony.Name = "tortspalony";
            this.tortspalony.Size = new System.Drawing.Size(131, 127);
            this.tortspalony.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tortspalony.TabIndex = 18;
            this.tortspalony.TabStop = false;
            // 
            // babeczkaspalona
            // 
            this.babeczkaspalona.BackColor = System.Drawing.Color.Transparent;
            this.babeczkaspalona.Image = global::Linia_produkcyjna.Properties.Resources.babeczkaspalona;
            this.babeczkaspalona.Location = new System.Drawing.Point(564, 106);
            this.babeczkaspalona.Name = "babeczkaspalona";
            this.babeczkaspalona.Size = new System.Drawing.Size(88, 86);
            this.babeczkaspalona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.babeczkaspalona.TabIndex = 19;
            this.babeczkaspalona.TabStop = false;
            // 
            // ciastkospalone
            // 
            this.ciastkospalone.BackColor = System.Drawing.Color.Transparent;
            this.ciastkospalone.Image = global::Linia_produkcyjna.Properties.Resources.ciastkospalone;
            this.ciastkospalone.Location = new System.Drawing.Point(593, 142);
            this.ciastkospalone.Name = "ciastkospalone";
            this.ciastkospalone.Size = new System.Drawing.Size(124, 102);
            this.ciastkospalone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ciastkospalone.TabIndex = 20;
            this.ciastkospalone.TabStop = false;
            // 
            // ciastospalone
            // 
            this.ciastospalone.BackColor = System.Drawing.Color.Transparent;
            this.ciastospalone.Image = global::Linia_produkcyjna.Properties.Resources.ciastospalone;
            this.ciastospalone.Location = new System.Drawing.Point(716, 247);
            this.ciastospalone.Name = "ciastospalone";
            this.ciastospalone.Size = new System.Drawing.Size(95, 78);
            this.ciastospalone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ciastospalone.TabIndex = 21;
            this.ciastospalone.TabStop = false;
            // 
            // obecnoscTxt
            // 
            this.obecnoscTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(104)))), ((int)(((byte)(90)))));
            this.obecnoscTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.obecnoscTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obecnoscTxt.ForeColor = System.Drawing.Color.LavenderBlush;
            this.obecnoscTxt.Location = new System.Drawing.Point(12, 586);
            this.obecnoscTxt.Name = "obecnoscTxt";
            this.obecnoscTxt.ReadOnly = true;
            this.obecnoscTxt.Size = new System.Drawing.Size(577, 23);
            this.obecnoscTxt.TabIndex = 23;
            this.obecnoscTxt.Text = "Proszę potwierdzić obecność! Panel logowania włączy się za:";
            this.obecnoscTxt.Visible = false;
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(104)))), ((int)(((byte)(90)))));
            this.radioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton.Location = new System.Drawing.Point(745, 586);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(109, 26);
            this.radioButton.TabIndex = 24;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "Potwierdź";
            this.radioButton.UseVisualStyleBackColor = false;
            this.radioButton.CheckedChanged += new System.EventHandler(this.checkedRadio);
            // 
            // timerOdliczanie
            // 
            this.timerOdliczanie.Interval = 1000;
            this.timerOdliczanie.Tick += new System.EventHandler(this.Odliczanie);
            // 
            // txtOdliczanie
            // 
            this.txtOdliczanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(104)))), ((int)(((byte)(90)))));
            this.txtOdliczanie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOdliczanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOdliczanie.ForeColor = System.Drawing.Color.DarkRed;
            this.txtOdliczanie.Location = new System.Drawing.Point(626, 586);
            this.txtOdliczanie.Name = "txtOdliczanie";
            this.txtOdliczanie.ReadOnly = true;
            this.txtOdliczanie.Size = new System.Drawing.Size(68, 23);
            this.txtOdliczanie.TabIndex = 25;
            this.txtOdliczanie.Text = "00:30";
            // 
            // timerPomocniczy
            // 
            this.timerPomocniczy.Interval = 2000;
            this.timerPomocniczy.Tick += new System.EventHandler(this.pomocniczyFunkcja);
            // 
            // timerObecnosc
            // 
            this.timerObecnosc.Interval = 1000;
            this.timerObecnosc.Tick += new System.EventHandler(this.obecnoscFunkcja);
            // 
            // temperaturaTxt
            // 
            this.temperaturaTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(104)))), ((int)(((byte)(90)))));
            this.temperaturaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temperaturaTxt.ForeColor = System.Drawing.Color.LavenderBlush;
            this.temperaturaTxt.Location = new System.Drawing.Point(12, 39);
            this.temperaturaTxt.Name = "temperaturaTxt";
            this.temperaturaTxt.ReadOnly = true;
            this.temperaturaTxt.Size = new System.Drawing.Size(251, 30);
            this.temperaturaTxt.TabIndex = 26;
            this.temperaturaTxt.Text = "Temperatura pieca: ";
            // 
            // timerTemperatura
            // 
            this.timerTemperatura.Interval = 900;
            this.timerTemperatura.Tick += new System.EventHandler(this.temperaturaFunkcja);
            // 
            // textInfo
            // 
            this.textInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(104)))), ((int)(((byte)(90)))));
            this.textInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.textInfo.Location = new System.Drawing.Point(12, 10);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(445, 23);
            this.textInfo.TabIndex = 27;
            this.textInfo.Text = "Temperatura musi być w zakresie <180,220> !";
            // 
            // textWiatrak
            // 
            this.textWiatrak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(104)))), ((int)(((byte)(90)))));
            this.textWiatrak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textWiatrak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textWiatrak.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textWiatrak.Location = new System.Drawing.Point(502, 46);
            this.textWiatrak.Name = "textWiatrak";
            this.textWiatrak.ReadOnly = true;
            this.textWiatrak.Size = new System.Drawing.Size(100, 23);
            this.textWiatrak.TabIndex = 29;
            this.textWiatrak.Text = "Wiatrak: ";
            // 
            // textWartości
            // 
            this.textWartości.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(104)))), ((int)(((byte)(90)))));
            this.textWartości.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textWartości.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textWartości.Location = new System.Drawing.Point(608, 39);
            this.textWartości.Name = "textWartości";
            this.textWartości.ReadOnly = true;
            this.textWartości.Size = new System.Drawing.Size(246, 30);
            this.textWartości.TabIndex = 30;
            this.textWartości.Text = "-10       -20     -30      -40";
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(104)))), ((int)(((byte)(90)))));
            this.radioButton1.Location = new System.Drawing.Point(620, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 25);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Click += new System.EventHandler(this.wiatrak10);
            // 
            // radioButton2
            // 
            this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(104)))), ((int)(((byte)(90)))));
            this.radioButton2.Location = new System.Drawing.Point(685, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(32, 25);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Click += new System.EventHandler(this.wiatrak20);
            // 
            // radioButton3
            // 
            this.radioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(104)))), ((int)(((byte)(90)))));
            this.radioButton3.Location = new System.Drawing.Point(745, 8);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(26, 25);
            this.radioButton3.TabIndex = 33;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.Click += new System.EventHandler(this.wiatrak30);
            // 
            // radioButton4
            // 
            this.radioButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(104)))), ((int)(((byte)(90)))));
            this.radioButton4.Location = new System.Drawing.Point(810, 8);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(32, 25);
            this.radioButton4.TabIndex = 34;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.Click += new System.EventHandler(this.wiatrak40);
            // 
            // zuzycieText
            // 
            this.zuzycieText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(104)))), ((int)(((byte)(90)))));
            this.zuzycieText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zuzycieText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zuzycieText.ForeColor = System.Drawing.Color.LavenderBlush;
            this.zuzycieText.Location = new System.Drawing.Point(12, 589);
            this.zuzycieText.Name = "zuzycieText";
            this.zuzycieText.Size = new System.Drawing.Size(384, 23);
            this.zuzycieText.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Linia_produkcyjna.Properties.Resources.mlp60poprawione;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 631);
            this.Controls.Add(this.zuzycieText);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textWartości);
            this.Controls.Add(this.textWiatrak);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.temperaturaTxt);
            this.Controls.Add(this.txtOdliczanie);
            this.Controls.Add(this.radioButton);
            this.Controls.Add(this.obecnoscTxt);
            this.Controls.Add(this.ciastospalone);
            this.Controls.Add(this.ciastkospalone);
            this.Controls.Add(this.babeczkaspalona);
            this.Controls.Add(this.tortspalony);
            this.Controls.Add(this.ciasto);
            this.Controls.Add(this.babeczka);
            this.Controls.Add(this.ciastko);
            this.Controls.Add(this.tort);
            this.Controls.Add(this.ciasto0);
            this.Controls.Add(this.babeczka0);
            this.Controls.Add(this.ciastko0);
            this.Controls.Add(this.tort0);
            this.Controls.Add(this.suwak);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(954, 678);
            this.MinimumSize = new System.Drawing.Size(954, 678);
            this.Name = "Form1";
            this.Text = "Linia produkcyjna";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suwak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tort0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciastko0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.babeczka0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciasto0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciastko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.babeczka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tortspalony)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.babeczkaspalona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciastkospalone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciastospalone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox login;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox haslo;
        private System.Windows.Forms.TrackBar suwak;
        private System.Windows.Forms.Timer timerPieczenie;
        private System.Windows.Forms.PictureBox tort0;
        private System.Windows.Forms.PictureBox ciastko0;
        private System.Windows.Forms.PictureBox babeczka0;
        private System.Windows.Forms.PictureBox ciasto0;
        private System.Windows.Forms.PictureBox tort;
        private System.Windows.Forms.PictureBox ciastko;
        private System.Windows.Forms.PictureBox babeczka;
        private System.Windows.Forms.PictureBox ciasto;
        private System.Windows.Forms.Timer timerWybor;
        private System.Windows.Forms.PictureBox tortspalony;
        private System.Windows.Forms.PictureBox babeczkaspalona;
        private System.Windows.Forms.PictureBox ciastkospalone;
        private System.Windows.Forms.PictureBox ciastospalone;
        private System.Windows.Forms.TextBox obecnoscTxt;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.Timer timerOdliczanie;
        private System.Windows.Forms.TextBox txtOdliczanie;
        private System.Windows.Forms.Timer timerPomocniczy;
        private System.Windows.Forms.Timer timerObecnosc;
        private System.Windows.Forms.TextBox temperaturaTxt;
        private System.Windows.Forms.Timer timerTemperatura;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.TextBox textWiatrak;
        private System.Windows.Forms.TextBox textWartości;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox zuzycieText;
    }
}

