using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPPC.model;
using MPPC.services;


namespace Client
{
    public class ClientCtrl: IAppObserver
    {
        public event EventHandler<UserEventArgs> updateEvent; //ctrl calls it when it has received an update (manually defined custom delegate)
        private readonly IServices server;
        public ClientCtrl(IServices server)
        {
            this.server = server;
        }
        public Spectacol[] getAllShows()
        {
            return this.server.findAllShows();
        }


        public void ticketsSold(Spectacol selected, Bilet t)
        {
            this.server.ticketsSold(selected, t);
        }


        public void logout(Angajat usr)
        {
            Console.WriteLine("Ctrl logout");
            server.logout(usr, this);
        }

        public void login(Angajat usr)
        {
            Console.WriteLine("Ctrl login");
            Console.WriteLine(usr.Password);
            server.login(usr, this);
        }

        protected virtual void OnUserEvent(UserEventArgs e)
        {
            if (updateEvent == null) return;
            updateEvent(this, e);
            Console.WriteLine("Update Event called");
        }


        public void notifyTicketSold(Spectacol s) // CALLED BY SERVICE (this is a server random update) to refresh GUI
        {
            Console.WriteLine("Show updated" + s);
            UserEventArgs userArgs = new UserEventArgs(UpdateType.TICKETS_SOLD, s);
            OnUserEvent(userArgs);
        }
    }
}
