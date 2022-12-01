using System;

namespace RoomHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new("White", 69, 1);
            room1.IsAvailable = false;
            Room room2 = new("Black", 199, 2);

            Console.ForegroundColor = ConsoleColor.Green;
            Hotel hotel = new("Colotel");
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            Console.WriteLine("*******Room details:*******");
            Console.WriteLine(room1.ShowInfo());
            Console.WriteLine("---------------------------");
            Console.WriteLine(room2.ShowInfo());
            Console.WriteLine("===========================");

            string choise;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("***********Menu:***********");
                Console.WriteLine("[1] - Make a reservation\n[0] - Exit the program");
                Console.Write("Your choice: ");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("Enter the ID of the room you want to reserve:");
                            Console.ResetColor();
                            int num = Convert.ToInt32(Console.ReadLine());
                            if (num > 0 && num < 3)
                            {
                                hotel.MakeReservation(num);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("This ID does not have a room.");
                            }
                        }
                        catch (NotAvailableException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(ex.Message);
                        }
                        catch (NullReferenceException)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("The ID you entered is null!");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Unknown error!");
                        }
                        finally
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Thank you for choosing Colotel<3");
                        }
                        break;
                    default:
                        break;
                }
            } while (choise != "0");
        }
    }
}