//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MediCar_Application.Models
//{
//    public class Cars
//    {
//        private List<Car> cars;
//        private List<Patient> patients;

//        // Cars constructor
//        public Cars()
//        {
//            cars = new List<Car>();
//            patients = new List<Patient>();
//            AddCar();
//            AddPatient();
//        }
//        public void AddCar()
//        {
//            AddCar("MediCar 1", Status.Availabe, "F4:B8:5E:6A:20:4A");
//            AddCar("MediCar 2", Status.Availabe, "00:1B:66:A3:A2:B4");
//            AddCar("MediCar 3", Status.Underway, "1234568");
//            AddCar("MediCar 4", Status.Error, "12343");
//            AddCar("MediCar 5", Status.Availabe, "20:20:05:17:10:70");
//            GetCars().ForEach(i => Console.Write("{0}\t", i));
//        }
//        public void AddCar(string aName, Status aStatus, string aBTAdress) 
//        {
//            Car aCar = new Car(aName, aStatus, aBTAdress);
//            Console.WriteLine(aCar);
//            cars.Add(aCar);
//        }
//        public void AddPatient()
//        {
//            AddPatient("P0235", "https://memes4brokendreams.com/Images/temp/mensen/joe.jpg", 10, 2, 2);
//            AddPatient("P8635", "https://memes4brokendreams.com/Images/temp/mensen/jenifer.jpg", 10, 5, 3);
//            AddPatient("P9235", "https://memes4brokendreams.com/Images/temp/mensen/John_Smith.jpg", 9, 1, 4);
//            AddPatient("P2055", "https://memes4brokendreams.com/Images/temp/mensen/Clarisa.jpg", 7, 5, 5, "MediCar 3");
//        }
//        public void AddPatient(string aName, string aPfp, int aRoom, int aBed, byte aBit)
//        {
//            Patient aPatient = new Patient(aName, aPfp, aRoom, aBed, aBit);
//            Console.WriteLine(aPatient);
//            patients.Add(aPatient);
//        }
//        public void AddPatient(string aName, string aPfp, int aRoom, int aBed, byte aBit, string aAssignedCar)
//        {
//            Patient aPatient = new Patient(aName, aPfp, aRoom, aBed, aBit, aAssignedCar);
//            Console.WriteLine(aPatient);
//            patients.Add(aPatient);
//        }

//        // return methods
//        public List<Car> GetCars()
//        {
//            return cars;
//        }
//        public List<Patient> GetPatients()
//        {
//            return patients;
//        }

//        // logging methods
//        public void ConsoleLog()
//        {
//            Console.WriteLine("cars ConsoleLog()");
//        }
//        public void ConsoleLog(string text)
//        {
//            Console.WriteLine("cars ConsoleLog():" + text);
//        }

//    }
//}
