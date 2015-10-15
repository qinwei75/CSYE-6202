using System;
using System.Text.RegularExpressions;

namespace HealthRecordApp
{
	public class HealthProfileHelper
	{
		public static bool ValidateFirstName(string firstName)
		{
            Regex r = new Regex("^[A-Z][a-zA-Z]*$");
            Match match = r.Match(firstName);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
		}

		public static bool ValidateLastName(string lastName)
		{
            Regex r = new Regex("^[A-Z][a-zA-Z]*$");
            Match match = r.Match(lastName);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		public static bool ValidateGender(string enteredGender, ref Gender patientGender)
		{
            if (enteredGender == "Male")
            {
                patientGender = 0;
                return true;
            }
            else if (enteredGender == "Female")
            {
                patientGender = 0;
                return true;
            }
            else {
                return false;
            }
		}

		public static bool ValidateDateOfBirth(string enteredDOB, ref DateTime patientDOB)
		{
            try {
                patientDOB = DateTime.Parse(enteredDOB);
                return true;
            }catch(Exception e)
            {
                return false;
            }
            
		}

		public static bool ValidateHeight(string heightInString, ref int patientHeight)
		{
            //0 is not allowed
            try { Convert.ToInt32(heightInString); }
            catch (Exception) { return false; }
            int h = Convert.ToInt32(heightInString);
            if (h > 0)
            {
                patientHeight = h;
                return true;
            }
            else
            {
                return false;
            }

            //Regex r = new Regex("^([1-9]+(\.[0-9]{2})?|0\.[1-9][0-9]|0\.0[1-9])$");
            //Match match = r.Match(heightInString);
            //if (match.Success)
            //{
            //    return true;
            //}
            //return false;
        }

		public static bool ValidateWeight(string weightInString, ref int patientWeight)
		{
            //0 is not allowed
            try { Convert.ToInt32(weightInString); }
            catch (Exception){ return false; }
            int w = Convert.ToInt32(weightInString);
            if (w > 0)
            {
                patientWeight = w;
                return true;
            }
            else {
                return false;
            }

            //Regex r = new Regex("^\+?[1-9][0-9]*$");
            //Match match = r.Match(weightInString);
            //if (match.Success)
            //{
            //    return true;
            //}

        }
	}
}
