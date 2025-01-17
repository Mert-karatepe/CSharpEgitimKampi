﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text=db.Location.Count().ToString();
            lblSumCapacity.Text=db.Location.Sum(x=> x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x => (decimal)x.Capacity).ToString("0.00");
            lblAvgLocationPrice.Text=db.Location.Average(x=> (decimal)x.Price).ToString("0.00") + "₺";

            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text= db.Location.Where(X=> X.LocationId== lastCountryId).Select(y=> y.Country).FirstOrDefault();
            lblCappadociaLocationCapacity.Text=db.Location.Where(x=> x.City == "Kapadokya").Select(y=> y.Capacity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAvg.Text = db.Location.Where(x=> x.Country == "Türkiye").Average(y=> y.Capacity).ToString();  

            var romeGuideId = db.Location.Where(x=> x.City =="Roma Turistik").Select(y=> y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text=db.Guide.Where(x=> x.GuideId==romeGuideId).Select(y=> y.GuidName + " " + y.GuidSurname).FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x=> x.Capacity == maxCapacity).Select(y=> y.City).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x=> x.Price);
            lblMaxPriceLocation.Text= db.Location.Where(x=> x.Price == maxPrice).Select(y=> y.City).FirstOrDefault().ToString();

            var guideIdByNameAysegulCinar = db.Guide.Where(x => x.GuidName == "Ayşegül" && x.GuidSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCinarLocationCount.Text= db.Location.Where(x=> x.GuideId == guideIdByNameAysegulCinar).Count().ToString();
        }
    }
}
