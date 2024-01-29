#include <iostream>

using namespace std;
int main() {


	/*SPOOFER INTERFACE LOGIN*/
	using namespace std;
	int main(); {
		cout << "*****************************************" << endl;
		cout << "*                                       *" << endl;
		cout << "*   Thanks for using NEVA spoofer       *" << endl;
		cout << "*                                       *" << endl;
		cout << "*****************************************" << endl;

		//creating a password.
		int password;

		cout << "set the password you desire:";
		cin >> password;
		cout << "your password has been set, ";

		//asking password:
		int userpasswordtrial;
		cout << "please enter the password you choose: ";
		cin >> userpasswordtrial;

		if (userpasswordtrial == password)
			cout << "password is correct!";
		else
			cout << "password is incorrect!";
		return 0; }

};