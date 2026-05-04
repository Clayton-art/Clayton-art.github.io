#pragma once
#include "Vehicle.h"

class Motorcycle : public Vehicle {
    int engineCC{0};
public:
    Motorcycle() = default;
    Motorcycle(const std::string &brand, const std::string &model, double pricePerDay, int cc);
    void displayInfo() const override;
    std::string getType() const override;
};
