#include "../include/Motorcycle.h"
#include <iostream>

Motorcycle::Motorcycle(const std::string &brand, const std::string &model, double pricePerDay, int cc)
    : Vehicle(brand, model, pricePerDay), engineCC(cc) {}

void Motorcycle::displayInfo() const {
    Vehicle::displayInfo();
    std::cout << "    (Motorcycle - " << engineCC << " cc)\n";
}

std::string Motorcycle::getType() const { return "Motorcycle"; }
