using System;
using System.Collections.Generic;

namespace Reservations
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookedReservations = GetBookedReservations();
            DisplayReservations(bookedReservations);

            Console.WriteLine("Insert new booking start date: (yyyy-MM-dd)");

            string startDateString = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(startDateString, "yyyy-MM-dd", null);

            Console.WriteLine("Insert new booking end date: (yyyy-MM-dd)");
            string endDateString = Console.ReadLine();
            DateTime endDate = DateTime.ParseExact(endDateString, "yyyy-MM-dd", null);

            bool isNewReservationPossible = IsNewReservationPossible(startDate, endDate, bookedReservations);

            if (isNewReservationPossible)
            {
                Console.WriteLine("Reservation Booked");
            }
            else
            {
                Console.WriteLine("Select other booking dates");
            }

        }

        private static bool IsNewReservationPossible(DateTime startDate, DateTime endDate, List<Reservation> bookedReservations)
        {
            foreach (var bookedReservation in bookedReservations)
            {
                if (startDate.Date >= bookedReservation.From.Date && startDate.Date <= bookedReservation.To.Date
                || endDate.Date >= bookedReservation.From.Date && endDate.Date <= bookedReservation.To.Date)
                {
                    return false;
                }

                if (startDate.Date <= bookedReservation.From.Date && endDate.Date >= bookedReservation.To.Date)
                {
                    return false;
                }
            }

            return true;
        }

        private static void DisplayReservations(List<Reservation> bookedReservations)
        {
            Console.WriteLine("Booked reservations:");
            foreach (var bookedReservation in bookedReservations)
            {
                Console.WriteLine($"From: {bookedReservation.From.ToString("yyyy-MM-dd", null)},"
                                + $"To: {bookedReservation.From.ToString("yyyy-MM-dd", null)}");
            }
        }

        static List<Reservation> GetBookedReservations()
        {
            var reservations = new List<Reservation>()
            {
                new Reservation(new DateTime(2021, 6, 10), new DateTime(2021, 6, 12)),
                new Reservation(new DateTime(2021, 6, 19), new DateTime(2021, 6, 20)),
                new Reservation(new DateTime(2021, 6, 24), new DateTime(2021, 6, 24))
            };

            return reservations;

        }
    }
}
