using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DISample2.Controllers
{
    [Route("api/[controller]")]
    public class SalesController : Controller
    {
        private List<SalesPerson> myStaff = new List<SalesPerson>();

        public List<SalesPerson> GetSales()
        {

            SalesPerson fred = new SalesPerson();
            fred.PersonName = "Fred Johnson";
            fred.PersonTitle = "Sales Manager";
            fred.ImageURL = "http://blog.backdropexpress.com/wp-content/uploads/2013/01/businessman-headshot.jpg";
            fred.CurrentQuota = 2000000.00;
            fred.CurrentSales = 1300000.00;

            myStaff.Add(fred);

            SalesPerson Sarah = new SalesPerson();
            Sarah.PersonName = "Sarah Clark";
            Sarah.PersonTitle = "Sales Director";
            Sarah.ImageURL = "https://s-media-cache-ak0.pinimg.com/236x/d7/ff/a9/d7ffa9d7cf53e5c3afe1e3c164411681.jpg";
            Sarah.CurrentQuota = 3500000.00;
            Sarah.CurrentSales = 1450000.00;

            myStaff.Add(Sarah);

            SalesPerson John = new SalesPerson();
            John.PersonName = "John Lanningham";
            John.PersonTitle = "Sales Manager";
            John.ImageURL = "http://www.menstoppingviolence.org/wp-content/uploads/2012/03/Harold_Jr__headshot_006_2.jpg";
            John.CurrentQuota = 2500000.00;
            John.CurrentSales = 1800000.00;

            myStaff.Add(John);

            SalesPerson Sheila = new SalesPerson();
            Sheila.PersonName = "Sheila Rogers";
            Sheila.PersonTitle = "Sales Manager";
            Sheila.ImageURL = "http://www.karinalouise.com/wp-content/gallery/corporate/dsc_6952.jpg";
            Sheila.CurrentQuota = 2500000.00;
            Sheila.CurrentSales = 1250000.00;

            myStaff.Add(Sheila);

            SalesPerson Jimmy = new SalesPerson();
            Jimmy.PersonName = "Jimmy Contraflip";
            Jimmy.PersonTitle = "Sales Manager";
            Jimmy.ImageURL = "http://www.granitestudios.com/blog/wp-content/uploads/2012/02/Headshot_sm1.jpg";
            Jimmy.CurrentQuota = 1500000.00;
            Jimmy.CurrentSales = 8050000.00;

            myStaff.Add(Jimmy);


            return myStaff;
        }


    }


    public class SalesPerson
    {
        public string PersonName
        {
            get { return m_PersonName; }
            set { m_PersonName = value; }
        }

        private string m_PersonName;
        public string PersonTitle
        {
            get { return m_PersonTitle; }
            set { m_PersonTitle = value; }
        }

        private string m_PersonTitle;

        public string ImageURL
        {
            get { return m_ImageURL; }
            set { m_ImageURL = value; }
        }

        private string m_ImageURL;

        public Double CurrentSales
        {
            get { return m_CurrentSales; }
            set { m_CurrentSales = value; }
        }
        private Double m_CurrentSales;

        public Double CurrentQuota
        {
            get { return m_CurrentQuota; }
            set { m_CurrentQuota = value; }
        }
        private Double m_CurrentQuota;
    }

}