using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevApp
{
    static public class globalData 
    {

        private readonly static Table[] newTable =  { new Table(0) , new Table(1) , new Table(2) , new Table(3), new Table(4) };
        private static int selectedTable = 0; // handling data for selected table ID 
        private static int selectedTime = 0; // handling data for selected Time İnterval
        public static int getTableID(int id)
        {
            return newTable[id].getTableID();
        }
        public static void setTimetableCheck(int id, int timeInterval, bool timeStatus)
        {
            newTable[id].setTimetableCheck(timeInterval, timeStatus);
        }
        public static bool getTimetableCheck(int id, int timeInterval)
        {
            return newTable[id].getTimetableCheck(timeInterval);
        }

        public static  void setSelectedTable(int id)
        {
            selectedTable = id;
        }
        public static int getSelectedTable()
        {
            return selectedTable;
        }
        public static void setSelectedTime(int id)
        {
            selectedTime = id;
        }
        public static int getSelectedTime()
        {
            return selectedTime;
        }

        //persona data
        public static void setResData(int id, int timeInterval, string name, string totalPeople, string number, string mail)
        {
            newTable[id].setResDataTable(timeInterval, name, totalPeople, number, mail);
        }
        public static reservationInformations getResData(int id, int timeInterval)
        {
            return newTable[id].getResDataTable(timeInterval);
        }

    }

}
