using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectGUI {
    class RentalCollection : Persistable {
        protected List<Rental> rentals;

        public RentalCollection()
            : base() { rentals = new List<Rental>(); } // call parent default constructor


        public void PopulateWithActiveRentals() {
            string queryString = "SELECT ID FROM Rental WHERE DateReturned = ''";
            List<Object> rentalIDs = getValues(queryString);
            foreach (Object element in rentalIDs) {
                Rental r = new Rental();
                r.Populate((int)((object[])element)[0]);
                rentals.Add(r);
            }

        }

        public List<Rental> GetBikeList() {
            return rentals;
        }

        
        public void PrintAll() {
            
            foreach(Rental rental in rentals){
                rental.Print();
            }
        } 
    }
}
