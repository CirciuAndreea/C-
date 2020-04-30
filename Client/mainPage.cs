using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPPC.model;
using MPPC.services;
using Client;
using System.Data.SqlClient;


namespace MPPC.Client
{
    public partial class mainPage : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet set = new DataSet();
        ClientCtrl ctrl;
        LoginPage loginWindow;
        private readonly IList<Spectacol> showData; // removed readonly to be able to remove and add an element each update
        private Angajat CurrentUser { get; set; }
        public event EventHandler<UserEventArgs> updateEvent; //ctrl calls it when it has received an update

        public mainPage(Angajat client, ClientCtrl ct, LoginPage loginPage)
        {
            InitializeComponent();
            this.ctrl = ct;
            showData = ctrl.getAllShows().ToList<Spectacol>();
            PopulateShowTable();
            this.loginWindow = loginPage;

            this.CurrentUser = client;
            ctrl.updateEvent += userUpdate;
        }
        protected virtual void OnUserEvent(UserEventArgs e)
        {
            if (updateEvent == null) return;
            updateEvent(this, e);
            Console.WriteLine("Update Event called");
        }
        public void logout()
        {
            Console.WriteLine("Ctrl logout");
            ctrl.logout(CurrentUser);
            CurrentUser = null;
            ctrl.updateEvent -= userUpdate;
            loginWindow.Enabled = true;
        }
        private void PopulateArtistTable(string data)
        {
            listaArtist.Items.Clear();
            foreach (Spectacol s in showData.ToList<Spectacol>())
            {
                if (s.Data.ToShortDateString() == data)
                {
                    var row = new string[] { s.Id.ToString(), s.ArtistName, s.Localitate.ToString(), s.Data.ToShortTimeString(), s.Nr_loc_disponibile.ToString() };
                    var lvi = new ListViewItem(row);
                    listaArtist.Items.Add(lvi);

                }
            }
        }
        private void PopulateShowTable()
        {
            listaShow.Items.Clear();
            foreach (Spectacol s in showData.ToList<Spectacol>())
            {
                var row = new string[] {s.Id.ToString(),s.ArtistName, s.Data.ToShortDateString(),
                s.Localitate,s.Nr_loc_vandute.ToString(),s.Nr_loc_disponibile.ToString()};
                var lvi = new ListViewItem(row);
                if (s.Nr_loc_disponibile == 0)
                    lvi.BackColor = Color.Red;
                listaShow.Items.Add(lvi);
            }

        }
        public void userUpdate(object sender, UserEventArgs e)
        {

            if (e.UserEventType == UpdateType.TICKETS_SOLD)
            {
                String showInfo = e.Data.ToString();

                Spectacol showUpdated = (Spectacol)e.Data;
                foreach (Spectacol s in showData)
                {
                    if (s.Id == showUpdated.Id)
                    {
                        showData.Remove(s);
                        break;
                    }
                }
                showData.Add(showUpdated);

                Console.WriteLine("[MainWindow] Updated Meci " + showInfo);
                listaShow.BeginInvoke(new UpdateListViewCallback(this.updateListView), new Object[] { listaShow, showData });
            }
        }
        private void updateListView(ListView listView, IList<Spectacol> newData)
        {
            listView.Items.Clear();

            foreach (Spectacol s in newData.ToList<Spectacol>())
            {
                var row = new string[] {s.Id.ToString(), s.ArtistName,s.Data.ToShortDateString(), s.Localitate,
                s.Nr_loc_vandute.ToString(),s.Nr_loc_disponibile.ToString()};
                var lvi = new ListViewItem(row);
                if (s.Nr_loc_disponibile == 0)
                    lvi.BackColor = Color.Red;
                listView.Items.Add(lvi);

            }
        }
        public delegate void UpdateListViewCallback(ListView list, IList<Spectacol> data);


        private void button1_Click(object sender, EventArgs e)
        {
            if (numeCBox.Text != null && locuriCBox.Text != null && listaShow.SelectedItems.Count == 1)
            {
                try
                {
                    int nrLocuri = int.Parse(locuriCBox.Text);
                    int idShow = int.Parse(listaShow.SelectedItems[0].SubItems[0].Text);
                    int locuriDisp = int.Parse(listaShow.SelectedItems[0].SubItems[4].Text);
                    if (locuriDisp >= nrLocuri)
                    {
                        Spectacol s = new Spectacol() { Id = idShow };
                        string numeC = numeCBox.Text;
                        Bilet t = new Bilet() { LocuriDorite=nrLocuri,  NumeCumparator = numeC ,IDSpectacol=idShow};
                        this.ctrl.ticketsSold(s, t);
                    }
                    else
                        MessageBox.Show("Nu avem suficiente locuri libere!");
                    numeCBox.Clear();
                    locuriCBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ati introdus gresit datele in campul de locuri dorite!");
                }
            }
            else
            {
                MessageBox.Show("Va rugam completati toate campurile si selectati un spectacol din lista");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dataTime = dateTimePicker1.Value.Date;
            PopulateArtistTable(dataTime.ToShortDateString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.logout();
            this.Close();
        }
    }
}
