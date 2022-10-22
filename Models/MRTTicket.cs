﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MRTOnlineTicketingSystem.Models {
    public class MRTTicket {

        double TotalAdult, TotalSenior, TotalDisable, TotalStudent;   
        public int Invoiceid { get; set; }

        [Display(Name = "Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Email")]
        public string CustomerEmail { get; set; }
        public int Userid { get; set; }
        public DateTime _PurchaseDateTime;
        [Display(Name ="Date & Time")]
        public DateTime PurchaseDateTime
        {
            get
            {
                return DateTime.Now;
            }
            set
            {
                _PurchaseDateTime = value;
            }
        }

        [Display(Name = "Adult")]
        public int Adult { get; set; }

        [Display(Name = "Senior Citizen")]
        public int SeniorCitizen { get; set; }

        [Display(Name = "Disable")]
        public int Disable { get; set; }

        [Display(Name = "Student")]
        public int Student { get; set; }

        [Required(ErrorMessage = " Please Select Station")]
        [Display(Name = "From")]
        public int CurrentLocationIndex { get; set; }

        [Required(ErrorMessage = "Please Select Station")]
        [Display(Name = "To")]
        public int DestinationLocationIndex { get; set; }
        [Required(ErrorMessage = "Please choose your ticket type")]
        [Display(Name = "Ticket Type")]
        public int TicketIndex { get; set; }

  
        public IDictionary<int, string> DictTicketType
        {
            get
            {
                return new Dictionary<int, string>()
                {
                    {1,"One Way"},
                    {2,"Two Way" }
                };
            }
            set
            {

            }
        }
        public IDictionary<int, string> DictStation
        {
            get
            {
                return new Dictionary<int, string>()
                {

                    {0, "Sungai Buloh"},
                    {1, "Kampung Selamat"},
                    {2, "Kwasa Damansara"},
                    {3, "Kwasa Sentral"},
                    {4, "Kota Damansara"},
                    {5, "Surian"},
                    {6, "Mutiara Damansara"},
                    {7, "Bandar Utama"},
                    {8, "Taman Tun Dr Ismail"},
                    {9, "Phileo Damansara" },
                    {10,"Pusat Bandar Raya Damansara"},
                    {11,"Semantan" },
                    {12,"Muzium Negara"},
                    {13,"Pasar Seni"},
                    {14,"Merdeka"},
                    {15,"Bukit Bintang"},
                    {16,"Tun Razak Exchange"},
                    {17,"Cochrane"},
                    {18,"Maluri"},
                    {19,"Taman Pertama"},
                    {20,"Taman Midah"},
                    {21,"Taman Mutiara"},
                    {22,"Taman Connaught"},
                    {23,"Taman Suntex"},
                    {24,"Sri Jaya" },
                    {25,"Bandar Tun Hussein Onn" },
                    {26, "Batu Sebelas Cheras" },
                    {27,"Bukit Dukung"},
                    {28,"Sungai Jernih"},
                    {29,"Stadium Kajang" },
                    {30,"Kajang"}

                };
            }

            set { }
        }

        public double adultAmount
        {
            get
            {

                double TicketRates = rates[CurrentLocationIndex, DestinationLocationIndex];
                TotalAdult = Adult * TicketRates;
                TotalAdult = Math.Round(TotalAdult, 2);
                return TotalAdult;
            }
        }

        public double SeniortAmount
        {
            get
            {
                double TicketRates = rates[CurrentLocationIndex, DestinationLocationIndex];
                double DiscountRates = TicketRates * 0.5;
                TotalSenior = SeniorCitizen * DiscountRates;
                TotalSenior = Math.Round(TotalSenior, 2);


                return TotalSenior;
            }
        }

        public double StudenttAmount
        {
            get
            {

                double TicketRates = rates[CurrentLocationIndex, DestinationLocationIndex];
                double DiscountRates = TicketRates * 0.6;
                TotalStudent = Student * DiscountRates;
                TotalStudent = Math.Round(TotalStudent,2);
                return TotalStudent;
            }
        }
        public double DisableAmount
        {
            get
            {

                double TicketRates = rates[CurrentLocationIndex, DestinationLocationIndex];
                double DiscountRates = TicketRates * 0.4;
                TotalDisable = Disable * DiscountRates;
                TotalDisable = Math.Round(TotalDisable, 2);
                return TotalDisable;
            }
        }
        public string _TotalAmount;
        [Display(Name ="Total Amount")]
        public string TotalAmount
        {
            get
            {
                double total = (TotalAdult + TotalSenior + TotalDisable + TotalStudent) * TicketIndex;
                total = Math.Round(total, 2);
                return "RM "+total;
            }
            set
            {
                _TotalAmount = value;
            }
          
        }

        public string CheckRate
        {
            get
            {
                double rate = rates[CurrentLocationIndex, DestinationLocationIndex];
                string TicketRates = "RM " + rate;
                return TicketRates;
            }
        }
  
        

        public static double[,] rates = {
            {0.80,1.20,1.80,2.00,2.60,2.70,3.10,3.30,3.20,3.50,3.30,3.40,3.10,3.20,3.30,3.40,3.50,3.60,3.70,3.90,4.00,4.10,4.30,4.50,4.60,4.80,4.80,5.00,5.30,5.40,5.50 },
            {1.20,0.80,1.50,1.80,2.30,2.70,2.80,3.10,3.40,3.30,3.70,3.30,3.70,3.80,3.20,3.30,3.40,3.50,3.60,3.80,3.90,4.00,4.20,4.40,4.50,4.60,4.70,4.90,5.20,5.20,5.40 },
            {1.80,1.50,0.80,1.10,1.80,2.10,2.60,2.60,3.00,3.20,3.30,3.50,3.40,3.50,3.60,3.70,3.20,3.30,3.40,3.50,3.60,3.80,3.90,4.10,4.30,4.40,4.50,4.60,4.90,5.00,5.10 },
            {2.00,1.80,1.10,0.80,1.60,1.90,2.30,2.60,2.80,3.00,3.10,3.30,3.80,3.40,3.40,3.60,3.80,3.20,3.30,3.40,3.50,3.70,3.80,4.00,4.10,4.30,4.40,4.50,4.80,4.90,5.00 },
            {2.60,2.30,1.80,1.60,0.80,1.30,1.80,2.00,2.40,2.80,3.00,3.20,3.30,3.50,3.60,3.20,3.40,3.60,3.70,3.20,3.20,3.40,3.50,3.70,3.90,4.00,4.10,4.30,4.60,4.60,4.80 },
            {2.70,2.70,2.10,1.90,1.30,0.80,1.30,1.70,2.00,2.40,2.70,2.90,3.10,3.30,3.40,3.60,3.80,3.40,3.50,3.70,3.80,3.20,3.40,3.60,3.70,3.90,4.00,4.10,4.40,4.50,4.60 },
            {3.10,2.80,2.60,2.30,1.80,1.30,0.80,1.30,1.70,2.00,2.60,2.80,3.20,3.40,3.10,3.30,3.50,3.70,3.20,3.50,3.60,3.80,3.20,3.40,3.60,3.70,3.80,3.90,4.20,4.30,4.40 },
            {3.30,3.10,2.60,2.60,2.00,1.70,1.30,0.80,1.30,1.70,2.20,2.50,2.90,3.10,3.20,3.40,3.20,3.40,3.60,3.30,3.40,3.60,3.80,3.30,3.40,3.60,3.60,3.80,4.10,4.20,4.30 },
            {3.20,3.40,3.00,2.80,2.40,2.00,1.70,1.30,0.80,1.20,1.80,2.10,2.80,2.80,2.90,3.10,3.40,3.10,3.30,3.60,3.70,3.40,3.60,3.80,3.20,3.40,3.50,3.60,3.90,4.00,4.10 },
            {3.50,3.30,3.20,3.00,2.80,2.40,2.00,1.70,1.20,0.80,1.60,1.80,2.50,2.70,2.60,2.80,3.10,3.30,3.10,3.30,3.50,3.70,3.40,3.60,3.80,3.20,3.30,3.50,3.80,3.90,4.00 },
            {3.30,3.70,3.30,3.10,3.00,2.70,2.60,2.20,1.80,1.60,0.80,1.10,1.80,2.10,2.20,2.50,2.80,2.80,3.00,3.30,3.50,3.30,3.50,3.30,3.50,3.70,3.80,3.20,3.50,3.60,3.70 },
            {3.40,3.30,3.50,3.30,3.20,2.90,2.80,2.50,2.10,1.80,1.10,0.80,1.70,1.90,2.00,2.30,2.60,2.60,2.80,3.10,3.30,3.10,3.40,3.70,3.30,3.50,3.60,3.10,3.40,3.50,3.60 },
            {3.10,3.70,3.40,3.80,3.30,3.10,3.20,2.90,2.80,2.50,1.80,1.70,0.80,1.20,1.30,1.60,1.90,2.10,2.30,2.70,2.70,3.00,3.30,3.20,3.40,3.70,3.20,3.50,3.10,3.20,3.30 },
            {3.20,3.80,3.50,3.40,3.50,3.30,3.40,3.10,2.80,2.70,2.10,1.90,1.20,0.80,1.00,1.30,1.70,1.80,2.10,2.50,2.70,2.80,3.00,3.50,3.30,3.50,3.60,3.30,3.70,3.80,3.20 },
            {3.30,3.20,3.60,3.40,3.60,3.40,3.10,3.20,2.90,2.60,2.20,2.00,1.30,1.00,0.80,1.10,1.50,1.80,1.90,2.30,2.50,2.60,2.90,3.30,3.20,3.40,3.50,3.80,3.60,3.70,3.20 },
            {3.40,3.30,3.70,3.60,3.20,3.60,3.30,3.40,3.10,2.80,2.50,2.30,1.60,1.30,1.10,0.80,1.20,1.50,1.80,2.10,2.30,2.60,2.70,3.10,3.40,3.20,3.30,3.60,3.50,3.60,3.80 },
            {3.50,3.40,3.20,3.80,3.40,3.80,3.50,3.20,3.40,3.10,2.80,2.60,1.90,1.70,1.50,1.20,0.80,1.10,1.40,1.80,1.90,2.30,2.70,2.90,3.10,3.40,3.10,3.40,3.30,3.40,3.60 },
            {3.60,3.50,3.30,3.20,3.60,3.40,3.70,3.40,3.10,3.30,2.80,2.60,2.10,1.80,1.80,1.50,1.10,0.80,1.10,1.50,1.80,2.10,2.40,2.60,2.90,3.20,3.30,3.20,3.70,3.30,3.40 },
            {3.70,3.60,3.40,3.30,3.70,3.50,3.20,3.60,3.30,3.10,3.00,2.80,2.30,2.10,1.90,1.80,1.40,1.10,0.80,1.30,1.50,1.80,2.20,2.70,2.70,3.00,3.20,3.10,3.60,3.70,3.30 },
            {3.90,3.80,3.50,3.40,3.20,3.70,3.50,3.30,3.60,3.30,3.30,3.10,2.70,2.50,2.30,2.10,1.80,1.50,1.30,0.80,1.10,1.50,1.80,2.30,2.60,2.70,2.80,3.20,3.30,3.40,3.60 },
            {4.00,3.90,3.60,3.50,3.20,3.80,3.60,3.40,3.70,3.50,3.50,3.30,2.70,2.70,2.50,2.30,1.90,1.80,1.50,1.10,0.80,1.30,1.70,2.10,2.40,2.80,2.70,3.00,3.10,3.30,3.50 },
            {4.10,4.00,3.80,3.70,3.40,3.20,3.80,3.60,3.40,3.70,3.30,3.10,3.00,2.80,2.60,2.60,2.30,2.10,1.80,1.50,1.30,0.80,1.20,1.80,2.00,2.40,2.60,2.70,3.30,3.40,3.20 },
            {4.30,4.20,3.90,3.80,3.50,3.40,3.20,3.80,3.60,3.40,3.50,3.40,3.30,3.00,2.90,2.70,2.70,2.40,2.20,1.80,1.70,1.20,0.80,1.40,1.80,2.00,2.20,2.60,3.00,3.10,3.40 },
            {4.50,4.40,4.10,4.00,3.70,3.60,3.40,3.30,3.80,3.60,3.30,3.70,3.20,3.50,3.30,3.10,2.90,2.60,2.70,2.30,2.10,1.80,1.40,0.80,1.20,1.60,1.80,2.10,2.60,2.70,3.00 },
            {4.60,4.50,4.30,4.10,3.90,3.70,3.60,3.40,3.20,3.80,3.50,3.30,3.40,3.30,3.20,3.40,3.10,2.90,2.70,2.60,2.40,2.00,1.80,1.20,0.80,1.30,1.50,1.80,2.50,2.70,2.70 },
            {4.80,4.60,4.40,4.30,4.00,3.90,3.70,3.60,3.40,3.20,3.70,3.50,3.70,3.50,3.40,3.20,3.40,3.20,3.00,2.70,2.80,2.40,2.00,1.60,1.30,0.80,1.10,1.50,2.20,2.30,2.70 },
            {4.80,4.70,4.50,4.40,4.10,4.00,3.80,3.60,3.50,3.30,3.80,3.60,3.20,3.60,3.50,3.30,3.10,3.30,3.20,2.80,2.70,2.60,2.20,1.80,1.50,1.10,0.80,1.30,2.00,2.20,2.50 },
            {5.00,4.90,4.60,4.50,4.30,4.10,3.90,3.80,3.60,3.50,3.20,3.10,3.50,3.30,3.80,3.60,3.40,3.20,3.10,3.20,3.00,2.70,2.60,2.10,1.80,1.50,1.30,0.80,1.70,1.80,2.10 },
            {5.30,5.20,4.90,4.80,4.60,4.40,4.20,4.10,3.90,3.80,3.50,3.40,3.10,3.70,3.60,3.50,3.30,3.70,3.60,3.30,3.10,3.30,3.00,2.60,2.50,2.20,2.00,1.70,0.80,1.10,1.40 },
            {5.40,5.20,5.00,4.90,4.60,4.50,4.30,4.20,4.00,3.90,3.60,3.50,3.20,3.80,3.70,3.60,3.40,3.30,3.70,3.40,3.30,3.40,3.10,2.70,2.70,2.30,2.20,1.80,1.10,0.80,1.20 },
            {5.50,5.40,5.10,5.00,4.80,4.60,4.40,4.30,4.10,4.00,3.70,3.60,3.30,3.20,3.20,3.80,3.60,3.40,3.30,3.60,3.50,3.20,3.40,3.00,2.70,2.70,2.50,2.10,1.40,1.20,0.80 }
        };
   
    }
}
