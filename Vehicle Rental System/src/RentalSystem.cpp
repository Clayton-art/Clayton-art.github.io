#include "../include/RentalSystem.h"
#include "../include/Vehicle.h"
#include "../include/Car.h"
#include "../include/Motorcycle.h"
#include "../include/Truck.h"
#include "../include/Customer.h"
#include "../include/Rental.h"
#include <algorithm>
#include <iostream>
#include <iomanip>

RentalSystem::RentalSystem() = default;
RentalSystem::~RentalSystem() = default;

void RentalSystem::addVehicle(std::shared_ptr<Vehicle> v) {
    vehicles.push_back(std::move(v));
}

void RentalSystem::addCustomer(const Customer &c) {
    customers.push_back(c);
}

std::shared_ptr<Vehicle> RentalSystem::findVehicleById(const std::string &id) {
    for (auto &v : vehicles) if (v->getId() == id) return v;
    return {};
}

std::vector<std::shared_ptr<Vehicle>> RentalSystem::searchVehicles(const std::string &keyword) {
    std::vector<std::shared_ptr<Vehicle>> res;
    std::string key = keyword;
    for (auto &c : key) c = tolower(c);
    for (auto &v : vehicles) {
        std::string combined = v->getId() + " " + v->getBrand() + " " + v->getModel() + " " + v->getType();
        std::string lower;
        lower.reserve(combined.size());
        for (char ch : combined) lower.push_back(tolower(ch));
        if (lower.find(key) != std::string::npos) res.push_back(v);
    }
    return res;
}

void RentalSystem::listAvailableVehicles() const {
    std::cout << "Available vehicles:\n";
    for (auto &v : vehicles) if (v->isAvailable()) v->displayInfo();
}

void RentalSystem::listAllVehicles() const {
    std::cout << "All vehicles:\n";
    for (auto &v : vehicles) v->displayInfo();
}

void RentalSystem::listCustomers() const {
    std::cout << "Customers:\n";
    for (auto &c : customers) c.showInfo();
}

void RentalSystem::listRentals() const {
    std::cout << "Rentals:\n";
    for (auto &r : rentals) r.printReceipt();
}

bool RentalSystem::rentVehicle(const std::string &vehicleId, const std::string &customerId, int days) {
    auto v = findVehicleById(vehicleId);
    if (!v) {
        std::cout << "Vehicle not found.\n";
        return false;
    }
    if (!v->isAvailable()) {
        std::cout << "Vehicle is currently not available.\n";
        return false;
    }
    auto it = std::find_if(customers.begin(), customers.end(), [&](const Customer &c){ return c.getId() == customerId; });
    if (it == customers.end()) {
        std::cout << "Customer not found.\n";
        return false;
    }
    v->rent();
    rentals.emplace_back(vehicleId, customerId, "Today", days, v->getPricePerDay());
    std::cout << "Vehicle rented successfully.\n";
    rentals.back().printReceipt();
    return true;
}

bool RentalSystem::returnVehicle(const std::string &vehicleId) {
    auto v = findVehicleById(vehicleId);
    if (!v) {
        std::cout << "Vehicle not found.\n";
        return false;
    }
    if (v->isAvailable()) {
        std::cout << "Vehicle is not currently rented.\n";
        return false;
    }
    v->returnVehicle();
    std::cout << "Vehicle returned and is now available.\n";
    return true;
}
