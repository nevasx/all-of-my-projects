#include <iostream>
#include <thread>
#include <chrono>

int main() {
    std::cout << "                                    *****************************************" << std::endl;
    std::cout << "                                    *                                       *" << std::endl;
    std::cout << "                                    *   Thanks for using NEVA spoofer       *" << std::endl;
    std::cout << "                                    *                                       *" << std::endl;
    std::cout << "                                    *****************************************" << std::endl;

    // Creating a password.
    int password;

    std::cout << std::endl << "Please set the password you desire: ";
    std::cin >> password;
    std::cout << std::endl << "Your password has been set!";

    // Asking for the password:
    int userPasswordTrial;
    std::cout << " Please enter the password you chose: ";
    std::cin >> userPasswordTrial;

    if (userPasswordTrial != password) {
        std::cout << "Password is incorrect!";
        return 1; // Exit the program
    }
    else {
        std::cout << "Password is correct!";
    }

    /* Choose Spoof Option */

    int option1;
    int option = 1; // Set to 1 to choose Option1
    std::cout << std::endl << std::endl << "Please write '1' to choose 'Option1' and press Enter: " << std::endl;
    std::cin >> option1;

    if (option1 == option) {
        std::cout << std::endl << std::endl << "Spoofing Process (DO NOT EXIT PROGRAM UNTIL IT CLOSES BY ITSELF)" << std::endl << std::endl;

        // Get the current time
        auto startTime = std::chrono::high_resolution_clock::now();

        while (std::chrono::duration_cast<std::chrono::seconds>(std::chrono::high_resolution_clock::now() - startTime).count() < 5) {
            std::cout << "CLEANING TRACES" << std::flush;
            for (int j = 0; j < 3; ++j) {
                std::this_thread::sleep_for(std::chrono::seconds(1)); // Wait for 1 second
                std::cout << "." << std::flush;
                std::this_thread::sleep_for(std::chrono::seconds(1)); // Wait for 1 second
                std::cout << "\b\b\b   \b\b\b" << std::flush; // Clear blinking dots
            }
        }

        std::cout << std::endl;

        // Simulate serial number change
        std::cout << "Changing computer serial numbers..." << std::endl;
        // Your code to change serial numbers goes here
        std::cout << "Serial numbers changed successfully!" << std::endl;
    }
    {
        std::cout << "PROCCESS COMPLETED! THANK YOU FOR CHOOSING US.";
    }

    return 0;
}
