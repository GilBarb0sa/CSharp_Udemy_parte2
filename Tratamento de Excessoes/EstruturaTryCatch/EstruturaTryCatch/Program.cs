using System;
using System.IO;
using EstruturaTryCatch.Entities;
using EstruturaTryCatch.Entities.Exceptions;

namespace EstruturaTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Teste do Finally para abrir arquivo
            //FileStream fs = null;
            //Uso do try, catch e finally para testar a abertura de um arquivo
            //try
            //{
            //    fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
            //    StreamReader sr = new StreamReader(fs);
            //    string line = sr.ReadLine();
            //    Console.WriteLine(line);
            //}
            //catch (FileNotFoundException e)
            //{
            //    Console.WriteLine(e.Message);               
            //}
            //finally
            //{
            //    if (fs != null)
            //    {
            //        fs.Close();
            //    }
            //}
            #endregion

            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format erro: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
