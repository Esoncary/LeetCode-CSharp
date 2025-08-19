
#include <iostream>
#include <vector>
#include <numeric>
#include <algorithm>

using namespace std;
int getValueFromUser()
{
    cout << "Enter a interger\n";
    int input{};
    cin >> input;
    return input;
}
void printDouble(int value)
{
    cout << value << " Double is " << value * 2;
}
int main()
{
    int input{getValueFromUser()};
    printDouble(input);
    return 0;
}