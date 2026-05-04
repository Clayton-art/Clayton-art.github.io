#pragma once
#include "Vehicle.h"

class Truck : public Vehicle {
    double loadCapacity{0.0};
public:
    Truck() = default;
    Truck(const std::string &brand, const std::string &model, double pricePerDay, double capacity);
    void displayInfo() const override;
    std::string getType() const override;
};
