#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main(){

    string s0;
    string s1 {"Apple"};
    string s2 {"Banana"};
    string s3 {"Kiwi"};
    string s4 {"apple"};
    string s5 {s1};
    string s6 {s1, 0, 3};
    string s7 {10, 'X'};

    cout << s0 << endl; 
    cout << "Theres a string length of " + s0.length() << " here" << endl;

//initilaization
    cout <<"\nInitilization" << "\n----------------------------------------------------------" << endl;
    cout << "s1 is initialized to: " << s1 << endl; 
    cout << "s2 is initialized to: " << s2 << endl; 
    cout << "s3 is initialized to: " << s3 << endl; 
    cout << "s4 is initialized to: " << s4 << endl; 
    cout << "s5 is initialized to: " << s5 << endl; 
    cout << "s6 is initialized to: " << s6 << endl; 
    cout << "s7 is initialized to: " << s7 << endl; 

//Assignment
    cout << "\nAssignment" << "\n-------------------------------------------------------" << endl; 

    s1  = "Watermelon";
    cout << "s1 is now: " << s1 << endl;                                    //Watermelon

    s2 = s1;
    cout << "s2 is now: " << s1 << endl;                                    //assigning Watermelon to s2

    s3 = "Frank";
    cout << "s3 is now: " << s3 << endl; 

    s3[0] = 'C';                                                                    //string 3, the letter at the '0' index is replaced with 'C'
    cout << "s3 change first letter to 'C' :" << s3 << endl;
    s3.at(0) = 'P';
    cout << "s3 change first letter to 'P': " << s3 << endl; 

//substring
    cout << "\nSubstring" << "\n---------------------------------------------------------------------------" << endl;
    s1 = "This is a test";

    cout << s1.substr(0,4) << endl;     //this
    cout << s1.substr(5,2) << endl;    //is

//Erase
    cout << "\nErase" << "\n------------------------------------------------------------------------------" << endl;

    s1 = "This is a test";                                                      //this erases 5 indexes starting at 0, so the whole word "this"
    s1.erase(0,5);
    cout << "s1 is now: " << s1 << endl; 

//getline
    cout << "\nGetline" << "\n----------------------------------------------------------------------" << endl;

    string full_name{};

    cout << "Enter your full name: " ;
    getline(cin, full_name);

    cout << "Hello, " << full_name << endl; 

//find
    cout << "\nFind" << "\n-----------------------------------------" << endl;

    s1 = "The secret word is Boo";
    string word{}; 

    cout << "Enter the word to find: ";
    cin >> word;

    size_t position = s1.find(word);
        if(position != string::npos)
            cout << "Found " << word << " at position: " << position << endl;
        else
            cout << "Sorry, " << word << " not found" << endl; 

    cout << endl;
    return 0; 





}