// Structured Vehicle Rental System - small entrypoint

#include "include/RentalSystem.h"
#include "include/Car.h"
#include "include/Motorcycle.h"
#include "include/Truck.h"
#include "include/Customer.h"
#include <iostream>
#include <string>
#include <memory>

using namespace std;

static void populateSampleData(RentalSystem &sys)
{
    sys.addVehicle(make_shared<Car>("Toyota", "Corolla", 35.0, 4));
    sys.addVehicle(make_shared<Car>("Honda", "Civic", 38.0, 4));
    sys.addVehicle(make_shared<Motorcycle>("Yamaha", "MT-07", 25.0, 689));
    sys.addVehicle(make_shared<Truck>("Ford", "F-150", 80.0, 1.5));

    sys.addCustomer(Customer("Alice Johnson", "L-12345"));
    sys.addCustomer(Customer("Bob Smith", "L-98765"));
}

int main()
{
    RentalSystem system;
    populateSampleData(system);

    cout << "Sample data loaded. Run the compiled program and use the library files for development.\n";
    cout << "This project now uses headers in 'include/' and sources in 'src/'.\n";
    return 0;
}
