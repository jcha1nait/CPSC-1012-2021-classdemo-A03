using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToObjects
{   
    //public access allows outside users access to the class
    //who is the "outside user"?
    // the outside user is anything NOT in the class
    public class IntroToObjects
    {
        //data members
        //  a data member is a piece of data
        //  the data needs to be a valid datatype
        //  Typically, these variables are private to the class
        private double _CashBills;
        private double _CashCoins;
        private string _DriverLicense;
        private string _BankCard;

        //Properties
        //  each data member that you wish to expose to the outside user
        //      will typically have its OWN property
        //  each property is public
        //  each property has the option of
        //      a) reading the private data member (get)
        //      b) assigning a value to the private data member (set)
        //          is the likely option that an outside user does not have access to
        //syntax:
        //  for a fully implemented property
        //  when to use:
        //      a) if you plan on saving the data to your own private data member
        //      b) if you have to do ANY programming before returning the private data member
        //          to the outside user
        //      C) if you have to do ANY programming before assigning the incoming data to
        //          you private data member (validation)
        //  public datatype propertyname
        //  {
        //      get { ..... }
        //      [set { .... }]
        //          on the set, your incoming data is referenced using the keyword: value
        //  }
        public string DriverLicense
        {
            get { return _DriverLicense; }
            set { _DriverLicense = value; }
        }

        //  for an auto implemented property
        //  when to use:
        //      if there is no additional processing needed for the data coming in or going out
        //  NOTE: when you use auto implemented properties you DO NOT create your own private
        //          data member
        //        instead, the system ON YOUR BEHALF will create a storage area for the data,
        //          will put the value in this area for you, will retrieve the data for you
        //  syntax:
        //      public datatype propertyname {get; set;]
        public string GasCard { get; set; }
        public string VisaCard { get; set; }

        //Full Implemented Property examples
        public double CashBills
        {
            get { return _CashBills; }
            set { _CashBills += value; }
        }

        public double CashCOins
        {
            get { return _CashCoins; }
            set { _CashCoins += value; }
        }

        public string BankCard
        {
            get { return _BankCard; }
            set { _BankCard = string.IsNullOrEmpty(value) ? null : value; }
        }
    }
}
