namespace MPPC.Client
{
    partial class mainPage
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
            this.numeCBox = new System.Windows.Forms.TextBox();
            this.locuriCBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.listaShow = new System.Windows.Forms.ListView();
            this.sId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sLocatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sNrSoldSeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sNrAvailableSeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listaArtist = new System.Windows.Forms.ListView();
            this.aId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aLocatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aOra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aNrAvailableSeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeCBox
            // 
            this.numeCBox.Location = new System.Drawing.Point(146, 230);
            this.numeCBox.Name = "numeCBox";
            this.numeCBox.Size = new System.Drawing.Size(100, 20);
            this.numeCBox.TabIndex = 0;
            // 
            // locuriCBox
            // 
            this.locuriCBox.Location = new System.Drawing.Point(146, 285);
            this.locuriCBox.Name = "locuriCBox";
            this.locuriCBox.Size = new System.Drawing.Size(100, 20);
            this.locuriCBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume cumparator:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Locuri dorite:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alege data sustinerii spectacolului:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cauta in functie de data:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generare bilet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(539, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cauta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listaShow
            // 
            this.listaShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sId,
            this.sArtist,
            this.sData,
            this.sLocatie,
            this.sNrSoldSeats,
            this.sNrAvailableSeats});
            this.listaShow.HideSelection = false;
            this.listaShow.Location = new System.Drawing.Point(12, 30);
            this.listaShow.Name = "listaShow";
            this.listaShow.Size = new System.Drawing.Size(364, 178);
            this.listaShow.TabIndex = 9;
            this.listaShow.UseCompatibleStateImageBehavior = false;
            this.listaShow.View = System.Windows.Forms.View.Details;
            // 
            // sId
            // 
            this.sId.Text = "Id";
            // 
            // sArtist
            // 
            this.sArtist.Text = "Artist";
            // 
            // sData
            // 
            this.sData.Text = "Data";
            // 
            // sLocatie
            // 
            this.sLocatie.Text = "Locatie";
            // 
            // sNrSoldSeats
            // 
            this.sNrSoldSeats.Text = "Loc. Vandute";
            // 
            // sNrAvailableSeats
            // 
            this.sNrAvailableSeats.Text = "loc. Posibile";
            // 
            // listaArtist
            // 
            this.listaArtist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.aId,
            this.aArtist,
            this.aLocatie,
            this.aOra,
            this.aNrAvailableSeats});
            this.listaArtist.HideSelection = false;
            this.listaArtist.Location = new System.Drawing.Point(454, 36);
            this.listaArtist.Name = "listaArtist";
            this.listaArtist.Size = new System.Drawing.Size(300, 148);
            this.listaArtist.TabIndex = 10;
            this.listaArtist.UseCompatibleStateImageBehavior = false;
            this.listaArtist.View = System.Windows.Forms.View.Details;
            // 
            // aId
            // 
            this.aId.Text = "Id";
            // 
            // aArtist
            // 
            this.aArtist.Text = "artist";
            // 
            // aLocatie
            // 
            this.aLocatie.Text = "locatie";
            // 
            // aOra
            // 
            this.aOra.Text = "ora";
            // 
            // aNrAvailableSeats
            // 
            this.aNrAvailableSeats.Text = "LocuriDisponibile";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listaArtist);
            this.Controls.Add(this.listaShow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locuriCBox);
            this.Controls.Add(this.numeCBox);
            this.Name = "mainPage";
            this.Text = "mainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeCBox;
        private System.Windows.Forms.TextBox locuriCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listaShow;
        private System.Windows.Forms.ColumnHeader sId;
        private System.Windows.Forms.ColumnHeader sArtist;
        private System.Windows.Forms.ColumnHeader sData;
        private System.Windows.Forms.ColumnHeader sLocatie;
        private System.Windows.Forms.ColumnHeader sNrSoldSeats;
        private System.Windows.Forms.ColumnHeader sNrAvailableSeats;
        private System.Windows.Forms.ListView listaArtist;
        private System.Windows.Forms.ColumnHeader aId;
        private System.Windows.Forms.ColumnHeader aArtist;
        private System.Windows.Forms.ColumnHeader aLocatie;
        private System.Windows.Forms.ColumnHeader aOra;
        private System.Windows.Forms.ColumnHeader aNrAvailableSeats;
        private System.Windows.Forms.Button button3;
    }
}