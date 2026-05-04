#pragma once
#include "Vehicle.h"

class Car : public Vehicle {
    int numberOfDoors{4};
public:
    Car() = default;
    Car(const std::string &brand, const std::string &model, double pricePerDay, int doors);
    void displayInfo() const override;
    std::string getType() const override;
};
