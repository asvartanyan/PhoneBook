using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace WindowsFormsApp1
{
    public class PaymentType
    {
        static public List<string> paymentType = new List<string> { "FullPayment", "PrefPayment" };
    }
    class Abonent
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string house { get; set; }
        public string apartment { get; set; }
        public string number { get; set; }
        public bool isPaired { get; set; }
        public string paymentType { get; set; }
        public string yearOfSet { get; set; }
        
        private string sortString { get; set; }
        public void SetSortString(string str)
        {
            sortString = str;
        }
        public string GetSortString()
        {
            return sortString;
        }
        public Abonent()
            {
            apartment = "";
            city = "";
           firstName = "";
            middleName = "";
           lastName = "";
           street = "";
          house = "";
            isPaired = false;
           number = "";
           yearOfSet = "";
          paymentType = "";
            sortString = "";
        }
        public List<string> CorrectInputValidation()
        {
            List<string> errorsInput = new List<string>();
            if (firstName == null)
            {
                errorsInput.Add("Field <firstName> is empty");
              
            }
            else if (IsLettersOnly(firstName))
            {
                errorsInput.Add("Field <firstName> contains numbers");
             
            }

            if (middleName == null)
            {
                errorsInput.Add("Field <middleName> is empty");
               
            }
            else if (IsLettersOnly(middleName))
            {
                errorsInput.Add("Field <middleName> contains numbers");
             
            }

            if (lastName == null)
            {
                errorsInput.Add("Field <lastName> is empty");
            
            }
            else if (IsLettersOnly(lastName))
            {
                errorsInput.Add("Field <lastName> contains numbers");
              
            }

            if (city == null)
            {
                errorsInput.Add("Field <city> is empty");
             
            }
            if (street == null)
            {
                errorsInput.Add("Field <street> is empty");
           
            }
            if (house == null)
            {
                errorsInput.Add("Field <house> is empty");
             
            }

            if (apartment == null)
            {
                errorsInput.Add("Field <apartment> is empty");
              
            }
            else if (IsDigitsOnly(apartment))
            {
                errorsInput.Add("Field <apartments> contains letters");
               
            }

            if (paymentType == null)
            {
                errorsInput.Add("Field <paymentType> is empty");
              
            }
            else if (IsLettersOnly(paymentType))
            {
                errorsInput.Add("Field <paymentType> contains numbers");
                
            }

            if (yearOfSet == null)
            {
                errorsInput.Add("Field <yearOfSet> is empty");
                
            }
            else if (IsDigitsOnly(yearOfSet))
            {
                errorsInput.Add("Field <yearOfSet> contains letters");
              
            }
            if (number == null)
            {
                errorsInput.Add("Field <number> is empty");
            
            }
            else if (IsDigitsOnly(number))
            {
                errorsInput.Add("Field <number> contains letters");
            
            }
            return errorsInput;
        }
        public List<string> CorrectInputValidation(bool isOkey)
        {
            List<string> errorsInput = new List<string>();
            if (firstName == null)
            {
                errorsInput.Add("Field <firstName> is empty");
                isOkey = false;
            }
            else if (IsLettersOnly(firstName))
            {
                errorsInput.Add("Field <firstName> contains numbers");
                isOkey = false;
            }

            if (middleName == null)
            {
                errorsInput.Add("Field <middleName> is empty");
                isOkey = false;
            }
            else if (IsLettersOnly(middleName))
            {
                errorsInput.Add("Field <middleName> contains numbers");
                isOkey = false;
            }

            if (lastName == null)
            {
                errorsInput.Add("Field <lastName> is empty");
                isOkey = false;
            }
            else if (IsLettersOnly(lastName))
            {
                errorsInput.Add("Field <lastName> contains numbers");
                isOkey = false;
            }

            if (city == null)
            {
                errorsInput.Add("Field <city> is empty");
                isOkey = false;
            }
            if (street == null)
            {
                errorsInput.Add("Field <street> is empty");
                isOkey = false;
            }
            if (house == null)
            {
                errorsInput.Add("Field <house> is empty");
                isOkey = false;
            }

            if (apartment == null)
            {
                errorsInput.Add("Field <apartment> is empty");
                isOkey = false;
            }
            else if (IsDigitsOnly(apartment))
            {
                errorsInput.Add("Field <apartments> contains letters");
                isOkey = false;
            }

            if (paymentType == null)
            {
                errorsInput.Add("Field <paymentType> is empty");
                isOkey = false;
            }
            else if (IsLettersOnly(paymentType))
            {
                errorsInput.Add("Field <paymentType> contains numbers");
                isOkey = false;
            }

            if (yearOfSet == null)
            {
                errorsInput.Add("Field <yearOfSet> is empty");
                isOkey = false;
            }
            else if (IsDigitsOnly(yearOfSet))
            {
                errorsInput.Add("Field <yearOfSet> contains letters");
                isOkey = false;
            }
            if (number == null)
            {
                errorsInput.Add("Field <number> is empty");
                isOkey = false;
            }
            else if (IsDigitsOnly(number))
            {
                errorsInput.Add("Field <number> contains letters");
                isOkey = false;
            }
            return errorsInput;
        }
        private bool IsLettersOnly(string str)
        {
            foreach (char c in str)
            {
                if ((c < '0' || c >'9'))
                    return false;
            }

            return true;
        }
        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if ((c > '0' || c < '9'))
                    return false;
            }

            return true;
        }
    }

    
}
