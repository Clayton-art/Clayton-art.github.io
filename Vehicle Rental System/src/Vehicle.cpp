#include "../include/Vehicle.h"
#include <iomanip>
#include <sstream>

// simple id generator (module-local)
static int g_idCounter = 1000;
static std::string genId(const std::string &prefix) {
    ++g_idCounter;
    std::ostringstream oss;
    oss << prefix << g_idCounter;
    return oss.str();
}

Vehicle::Vehicle(const std::string &brand_, const std::string &model_, double pricePerDay_)
    : vehicleId(genId("V")), brand(brand_), model(model_), pricePerDay(pricePerDay_), available(true) {}

Vehicle::~Vehicle() = default;

std::string Vehicle::getId() const { return vehicleId; }
std::string Vehicle::getBrand() const { return brand; }
std::string Vehicle::getModel() const { return model; }
double Vehicle::getPricePerDay() const { return pricePerDay; }
bool Vehicle::isAvailable() const { return available; }

void Vehicle::rent() { available = false; }
void Vehicle::returnVehicle() { available = true; }

void Vehicle::displayInfo() const {
    std::cout << vehicleId << " " << getType() << " " << brand << " " << model << " $"
              << std::fixed << std::setprecision(2) << pricePerDay
              << (available ? " [Available]" : " [Rented]") << "\n";
}

std::string Vehicle::getType() const { return "Vehicle"; }
