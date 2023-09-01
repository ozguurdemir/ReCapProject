using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
RentalManager rentalManager = new RentalManager(new EfRentalDal());
Rental rental = new Rental { Id = 1, CarId = 1, CustomerId = 1, RentDate=DateTime.Today, ReturnDate = DateTime.Today.AddDays(1) };
Rental rental1 = new Rental { Id = 2, CarId = 2, CustomerId = 2, RentDate = DateTime.Today.AddDays(6), 
    ReturnDate = DateTime.Today.AddDays(10) };
Rental rental2 = new Rental
{
    Id = 3,
    CarId = 2,
    CustomerId = 2,
    RentDate = DateTime.Today.AddDays(6),
    
};

var result1 = rentalManager.GetAll();

foreach (var rentals in result1.Data)
{
    Console.WriteLine(rentals.Id +" " +
        rentals.CarId + " " + 
        rentals.CustomerId + " " + 
        rentals.RentDate.Date.ToString("dd/MM/yy") + " " + 
        rentals.ReturnDate.Date.ToString("dd/MM/yy"));
}


var result = customerManager.GetAll();
foreach (var data in result.Data)
{
    Console.WriteLine(data.Id+" "+ data.CompanyName);
}


//GetCarsTest(carManager);
/*foreach (var car in carManager.GetCarDetails())
{
    Console.WriteLine(car.CarName+" " + car.ColorName + " " + car.BrandName);
}

static void GetCarsTest(CarManager carManager)
{
    foreach (var car in carManager.GetAllCars())
    {
        Console.WriteLine(car.ModelYear + " " + car.Description);
    }
}*/