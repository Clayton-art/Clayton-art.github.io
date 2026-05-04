#pragma once
#include <string>

class Rental {
    std::string rentalId;
    std::string vehicleId;
    std::string customerId;
    std::string dateOut;
    std::string dateReturned;
    double totalCost{0.0};
public:
    Rental() = default;
    Rental(const std::string &vId, const std::string &cId, const std::string &outDate, int days, double pricePerDay);
    void calculateCost(double pricePerDay, int days);
    void printReceipt() const;
    std::string getVehicleId() const;
};
