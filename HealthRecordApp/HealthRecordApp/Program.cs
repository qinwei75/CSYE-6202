using System;

namespace HealthRecordApp
{
	class Program
	{
        static HealthProfile healthProfile = new HealthProfile();
        static void Main(string[] args)
		{
            
            Console.Write("Please enter patient's first name:");
            string firstname = Console.ReadLine();
            while (!HealthProfileHelper.ValidateFirstName(firstname))
            {
                Console.Write("Invalid first name. Please enter patient's first name:");
                firstname = Console.ReadLine();
            }

            Console.Write("Please enter patient's last name:");
            string lastname = Console.ReadLine();
            while (!HealthProfileHelper.ValidateLastName(lastname))
            {
                Console.Write("Invalid last name. Please enter patient's last name:");
                lastname = Console.ReadLine();
            }

            Gender patientGender = Gender.Unspecified;
            Console.Write("Please enter patient's gender (Unspecified/Male/Female):");
            string gender = Console.ReadLine();
            while (!HealthProfileHelper.ValidateGender(gender, ref patientGender))
            {
                Console.Write("Invalid gender. Please enter patient's gender (Unspecified/Male/Female):");
                gender = Console.ReadLine();
            }

            DateTime patientDOB = DateTime.Today;
            Console.Write("Please enter patient's date of birth:");
            string dob = Console.ReadLine();
            while (!HealthProfileHelper.ValidateDateOfBirth(dob, ref patientDOB))
            {
                Console.Write("Invalid date of birth. Please enter patient's date of birth:");
                dob = Console.ReadLine();
            }

            Console.Write("Please enter patient's height:");
            string h = Console.ReadLine();
            int patientHeight=0;
            while (!HealthProfileHelper.ValidateHeight(h, ref patientHeight))
            {
                Console.Write("Invalid hight. Please enter patient's height:");
                h = Console.ReadLine();
            }

            Console.Write("Please enter patient's weight:");
            string w = Console.ReadLine();
            int patientWeight=0;
            while (!HealthProfileHelper.ValidateWeight(w, ref patientWeight))
            {
                Console.Write("Invalid wight. Please enter patient's weight:");
                w = Console.ReadLine();
            }
            //set value
            healthProfile.FirstName = firstname;
            healthProfile.LastName = lastname;
            healthProfile.Gender = patientGender;
            healthProfile.DOB = patientDOB;
            healthProfile.HeightInInches = patientHeight;
            healthProfile.WeightInPounds = patientWeight;

            Console.WriteLine();
            Console.WriteLine();
            healthProfile.DisplayPatientProfile();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
	}
}
