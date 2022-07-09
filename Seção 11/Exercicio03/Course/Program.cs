using Course.Entities;
using Course.Entities.Exceptions;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation:  " + reservation.ToString());

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine("Reservation:  " + reservation.ToString());

                Console.WriteLine("Precione qualquer tecla para continuar.");
                Console.ReadKey();
            }
            catch (DomainException ex)
            {
                Console.WriteLine("Error in reservation: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }
    }
}
