#include "../include/Rental.h"
#include <sstream>
#include <iostream>
#include <iomanip>

static int g_rentalCounter = 3000;
static std::string genRentalId() {
    ++g_rentalCounter;
    std::ostringstream oss;
    oss << "R" << g_rentalCounter;
    return oss.str();
}

Rental::Rental(const std::string &vId, const std::string &cId, const std::string &outDate, int days, double pricePerDay)
    : rentalId(genRentalId()), vehicleId(vId), customerId(cId), dateOut(outDate) {
    std::ostringstream oss;
    oss << "After " << days << " day(s)";
    dateReturned = oss.str();
    calculateCost(pricePerDay, days);
}

void Rental::calculateCost(double pricePerDay, int days) {
    totalCost = pricePerDay * days;
}

void Rental::printReceipt() const {
    std::cout << "--- Rental Receipt ---\n";
    std::cout << "Rental ID: " << rentalId << "\n";
    std::cout << "Vehicle ID: " << vehicleId << "\n";
    std::cout << "Customer ID: " << customerId << "\n";
    std::cout << "Date Out: " << dateOut << "\n";
    std::cout << "Date Returned: " << dateReturned << "\n";
    std::cout << "Total Cost: $" << std::fixed << std::setprecision(2) << totalCost << "\n";
    std::cout << "----------------------\n";
}

std::string Rental::getVehicleId() const { return vehicleId; }
