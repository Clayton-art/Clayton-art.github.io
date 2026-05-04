#pragma once
#include <string>

class Customer {
    std::string customerId;
    std::string name;
    std::string licenseNumber;
public:
    Customer() = default;
    Customer(const std::string &name_, const std::string &license_);
    std::string getId() const;
    std::string getName() const;
    void showInfo() const;
};
