#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ComboBoxColumnsDemo
{
    public class ViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            this.PopulateData();
            _shipCities = CountryDetailsRepository.GetShipCities();
            CountryList = new List<string>(ShipCities.Keys);
            CityList = new List<ShipCityDetails>();

            CityList.Add(new ShipCityDetails() { ShipCityName = "Bergamo", ShipCityID = 101 });
            CityList.Add(new ShipCityDetails() { ShipCityName = "Graz", ShipCityID = 102 });
            CityList.Add(new ShipCityDetails() { ShipCityName = "Campinas", ShipCityID = 103 });
            CityList.Add(new ShipCityDetails() { ShipCityName = "Montréal", ShipCityID = 104 });
            CityList.Add(new ShipCityDetails() { ShipCityName = "Buenos Aires", ShipCityID = 105 });

            CityList.Add(new ShipCityDetails() { ShipCityName = "Aachen", ShipCityID = 106 });
            CityList.Add(new ShipCityDetails() { ShipCityName = "Cork", ShipCityID = 107 });
            CityList.Add(new ShipCityDetails() { ShipCityName = "Århus", ShipCityID = 108 });
            CityList.Add(new ShipCityDetails() { ShipCityName = "Lille", ShipCityID = 109 });
            CityList.Add(new ShipCityDetails() { ShipCityName = "Helsinki", ShipCityID = 110 });

      
        }
        
        private ObservableCollection<OrderDetails> _orderDatails;
        /// <summary>
        /// Gets or sets the orders details.
        /// </summary>
        /// <value>The orders details.</value>
        public ObservableCollection<OrderDetails> OrderDetails
        {
            get
            {
                return _orderDatails;
            }
            set
            {
                _orderDatails = value;
            }
        }

        Dictionary<string, ObservableCollection<ShipCityDetails>> _shipCities;
        /// <summary>
        /// Gets or sets the ship cities.
        /// </summary>
        /// <value>The ship cities.</value>
        public Dictionary<string, ObservableCollection<ShipCityDetails>> ShipCities
        {
            get
            {
                return _shipCities;
            }
            set
            {
                _shipCities = value;
            }
        }

        public List<string> CountryList { get; set; }
        public List<ShipCityDetails> CityList { get; set; }

        Random r = new Random();
        public void PopulateData()
        {
            _orderDatails = new ObservableCollection<OrderDetails>();
            _orderDatails.Add(new OrderDetails(1001, CustomerID[r.Next(15)], ProductName[r.Next(6)], 15, "Austria", 106));
            _orderDatails.Add(new OrderDetails(1002, CustomerID[r.Next(15)], ProductName[r.Next(6)], 20, "Belgium", 110));
            _orderDatails.Add(new OrderDetails(1003, CustomerID[r.Next(15)], ProductName[r.Next(6)], 25, "Brazil", 102));
            _orderDatails.Add(new OrderDetails(1004, CustomerID[r.Next(15)], ProductName[r.Next(6)], 20, "Canada", 104));
            _orderDatails.Add(new OrderDetails(1005, CustomerID[r.Next(15)], ProductName[r.Next(6)], 17, "Denmark", 101));
            _orderDatails.Add(new OrderDetails(1006, CustomerID[r.Next(15)], ProductName[r.Next(6)], 14, "Finland", 109));
            _orderDatails.Add(new OrderDetails(1007, CustomerID[r.Next(15)], ProductName[r.Next(6)], 11, "Italy", 108));
            _orderDatails.Add(new OrderDetails(1008, CustomerID[r.Next(15)], ProductName[r.Next(6)], 7, "US", 103));
            _orderDatails.Add(new OrderDetails(1009, CustomerID[r.Next(15)], ProductName[r.Next(6)], 5, "Belgium", 105));
            _orderDatails.Add(new OrderDetails(1010, CustomerID[r.Next(15)], ProductName[r.Next(6)], 3, "Brazil", 107));
           
        }
        string[] ProductName = new string[]
       {
            "Alice Mutton",
            "NuNuCa Nub-Nougat-Creme",
            "Boston Crab Meat",
            "Raclette Courdavault",
            "Wimmers gute Semmelknodel",
            "Konbu"
       };
        string[] CustomerID = new string[]
      {
            "ALFKI",
            "FRANS",
            "MEREP",
            "FOLKO",
            "SIMOB",
            "WARTH",
            "VAFFE",
            "FURIB",
            "SEVES",
            "LINOD",
            "RISCU",
            "PICCO",
            "BLONP",
            "WELLI",
            "FOLIG"
      };
    }
}
