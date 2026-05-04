#pragma once
#include <string>
#include <iostream>

class Vehicle {
protected:
    std::string vehicleId;
    std::string brand;
    std::string model;
    double pricePerDay{0.0};
    bool available{true};
public:
    Vehicle() = default;
    Vehicle(const std::string &brand_, const std::string &model_, double pricePerDay_);
    virtual ~Vehicle();

    std::string getId() const;
    std::string getBrand() const;
    std::string getModel() const;
    double getPricePerDay() const;
    bool isAvailable() const;

    void rent();
    void returnVehicle();

    virtual void displayInfo() const;
    virtual std::string getType() const;
};
