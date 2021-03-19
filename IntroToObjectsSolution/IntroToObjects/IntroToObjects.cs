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
        #region Data Members
        //data members
        //  a data member is a piece of data
        //  the data needs to be a valid datatype
        //  Typically, these variables are private to the class
        private double _CashBills;
        private double _CashCoins;
        private string _DriverLicense;
        private string _BankCard;
        #endregion

        #region Properties
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

        public double CashCoins
        {
            get { return _CashCoins; }
            set { _CashCoins += value; }
        }

        public string BankCard
        {
            get { return _BankCard; }
            set { _BankCard = string.IsNullOrEmpty(value) ? null : value; }
        }
        #endregion

        #region Constructor
        //Constructor

        //IF, your class definition DOES NOT have a coded constructor
        //  then the system will default ALL data member AND auto implemented
        //  properties to the natural default value of the data variable's datatype:
        //  numerics: 0, strings: null, bool: false and so on..

        //IF, you wish to assing non default system values to your data members
        //  and/or the auto implemented properties WHEN the instance of the class
        //  is created in your program THEN YOU MUST code your own constructor

        //IF, you HAVE/WANT to have multiple constructors, then YOU are responsible for
        // coding EACH AND EVERY constructor.

        //Purpose:
        //  assign values to the data member(s) and/or auto implemented properties
        //Syntax:
        //  public classname([list of parameters]) { ..... }

        //Important points:
        //  Note there is NO datatype between public and classname
        //  Note the name of this structure is the same as the class name

        // "Default" constructor
        // Recognize this constructor
        // It has no parameter list

        public IntroToObjects()
        {
            //If there is no code within the constructor, the variables
            //  of the class are assigned the system default values for their
            //  datatype

            //YOU COULD, assign your own default values in this constructor
            //
            //  a) you could use the property (instructor's preference)
            CashBills = 5.00;
            //  b) you could assign the value DIRECTLY to a private data member
            //      WARNING: if your property does any logic against the value 
            //               to be assigned to the data member, this WILL NOT HAPPEN
            //_CashBills = 5.00;
        }

        //"Greedy" Constructor
        //  it has a parameter list that generally has an parameter for EACH and EVERYTHING
        //      data member/auto implemented property in the class
        public IntroToObjects(int cashbills, int cashcoins, string driverlicense, string bankcard, string gascard, string visacard)
        {
            CashBills = cashbills;
            CashCoins = cashcoins;
            DriverLicense = driverlicense;
            BankCard = bankcard;
            GasCard = gascard;
            VisaCard = visacard;
        }
        #endregion

        #region Behaviours (aka Methods)
        //Behaviours generally will be
        //  a) actions not done in a property
        //  b) actions affecting multiple data members and/or auto implemented propeties

        //  a good habit in coding your behaviours is to use properties over data members
        public bool ExtractAmount(double amount)
        {
            bool valid = false;
            if (CashBills + CashCoins >= amount)
            {
                //logic to change cash bills and coins 
                if (amount < 5.00)
                {
                    CashCoins -= amount;
                }
                else
                {
                    CashBills -= amount;
                }
                valid = true;
            }

            return valid;
        }
        #endregion
    }
}
