#pragma once
#include <vector>
#include <memory>
#include <string>

class Vehicle;
class Customer;
class Rental;

class RentalSystem {
    std::vector<std::shared_ptr<Vehicle>> vehicles;
    std::vector<Customer> customers;
    std::vector<Rental> rentals;
public:
    RentalSystem();
    ~RentalSystem();

    void addVehicle(std::shared_ptr<Vehicle> v);
    void addCustomer(const Customer &c);

    std::shared_ptr<Vehicle> findVehicleById(const std::string &id);
    std::vector<std::shared_ptr<Vehicle>> searchVehicles(const std::string &keyword);

    void listAvailableVehicles() const;
    void listAllVehicles() const;
    void listCustomers() const;
    void listRentals() const;

    bool rentVehicle(const std::string &vehicleId, const std::string &customerId, int days);
    bool returnVehicle(const std::string &vehicleId);
};
