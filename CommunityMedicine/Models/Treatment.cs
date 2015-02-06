using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityMedicine.Models
{
    public class Treatment
    {
        public int TreatmentId { set; get; }
        public string PatientVoterId { set; get; }
        public string Observation { set; get; }
        public DateTime Date { set; get; }
        public int DoctorId { set; get; }
        public int DeseaseId { set; get; }
        public int DoseId { set; get; }
        public int MealType { set; get; }
        public double Quantity { set; get; }
        public string Note { set; get; }
    }
}