// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
Car Skoda120 = new PersonalCar(5, PersonalCar.FuelType.gas, 50);
Car Felda = new PersonalCar(5, PersonalCar.FuelType.gas, 50);
Car Tatrofka = new FreightCar(25, FreightCar.FuelType.diesel, 150);

try
{
    Felda.Refuel(PersonalCar.FuelType.diesel, 32.22f);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    Tatrofka.Refuel(PersonalCar.FuelType.diesel, 32.22f);
    //Tatrofka.setFreight(85);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    Skoda120.Refuel(PersonalCar.FuelType.gas, 32.22f);
    Skoda120.addStation(1, 88.8);
    Skoda120.setStation(2);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Skoda120.setStation(1);
Console.WriteLine("Felda:\n"+Felda.ToString());
Console.WriteLine("Skoda 120:\n"+Skoda120.ToString());
Console.WriteLine("Tatrovka :\n" + Tatrofka.ToString());
