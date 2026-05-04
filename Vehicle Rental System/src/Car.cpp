#include "../include/Car.h"
#include <iostream>

Car::Car(const std::string &brand, const std::string &model, double pricePerDay, int doors)
    : Vehicle(brand, model, pricePerDay), numberOfDoors(doors) {}

void Car::displayInfo() const {
    Vehicle::displayInfo();
    std::cout << "    (Car - " << numberOfDoors << " doors)\n";
}

std::string Car::getType() const { return "Car"; }
