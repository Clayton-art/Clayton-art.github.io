#include "../include/Truck.h"
#include <iostream>

Truck::Truck(const std::string &brand, const std::string &model, double pricePerDay, double capacity)
    : Vehicle(brand, model, pricePerDay), loadCapacity(capacity) {}

void Truck::displayInfo() const {
    Vehicle::displayInfo();
    std::cout << "    (Truck - " << loadCapacity << " t)\n";
}

std::string Truck::getType() const { return "Truck"; }
