#include "../include/Customer.h"
#include <iostream>
#include <sstream>

static int g_customerCounter = 2000;
static std::string genCustomerId() {
    ++g_customerCounter;
    std::ostringstream oss;
    oss << "C" << g_customerCounter;
    return oss.str();
}

Customer::Customer(const std::string &name_, const std::string &license_)
    : customerId(genCustomerId()), name(name_), licenseNumber(license_) {}

std::string Customer::getId() const { return customerId; }
std::string Customer::getName() const { return name; }

void Customer::showInfo() const {
    std::cout << customerId << " - " << name << " (License: " << licenseNumber << ")\n";
}
