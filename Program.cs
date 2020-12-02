using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevApp
{
    
    
    class Table : Timetable
    {
        private int tableID;//keeps table ID

        
        public Table(int id)
        {
            setTableID(id);
        }
        public void setTableID(int id)
        {
            tableID = id;
        }
        public int getTableID()
        {
            return tableID;
        }


    }
    class Timetable 
    {
        private bool[] timetableCheck = { true, true, true, true, true, true, true, true };//timetable specific hour check
        
        private reservationInformations[] resDataTable = { new reservationInformations(),
        new reservationInformations(), new reservationInformations(), new reservationInformations(),
        new reservationInformations(), new reservationInformations(), new reservationInformations(),
        new reservationInformations() };

        public void setTimetableCheck(int timeInterval, bool timeStatus)
        {
            timetableCheck[timeInterval] = timeStatus;
        }
        public bool getTimetableCheck(int timeInterval)
        {
            return timetableCheck[timeInterval];
        }
        public void setResDataTable(int timeInterval, string name, string totalPeople, string number, string mail)
        {
            resDataTable[timeInterval].setPersonName(name);
            resDataTable[timeInterval].setTotalPeople(totalPeople);
            resDataTable[timeInterval].setNumber(number);
            resDataTable[timeInterval].setMail(mail);

        }
        public reservationInformations getResDataTable(int timeInterval)
        {
            return resDataTable[timeInterval];
        }

    }


    public class reservationInformations
    {
        private string personName = "no name";
        private string totalPeople = "no number";
        private string number = "no number";
        private string mail = "no mail";

        public void setPersonName(string name)
        {
            personName = name;
        }
        public string getPersonName()
        {
            return personName;
        }

        public void setTotalPeople(string name)
        {
            totalPeople = name;
        }
        public string getTotalPeople()
        {
            return totalPeople;
        }

        public void setNumber(string name)
        {
            number = name;
        }
        public string getNumber()
        {
            return number;
        }

        public void setMail(string name)
        {
            mail = name;
        }
        public string getMail()
        {
            return mail;
        }
      


    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new adminCustomerSelection());
        }
    }
}
