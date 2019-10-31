#include <iostream>

using namespace std;
int main ()
{
    cout << "Enter 10 integer" << endl;
    int n2,increments= 0,decrements = 0;
    

    for (int i = 0; i < 10; i++)
    {
        cin >> n2;
        if (n2 < 0 )
        {
        cout << "Enter a positive number" << endl;
            i--;
        }
        else if (n1 < n2)
        {
        increments++;
        n1=n2 ;
        }
        else if (n1 > n2)
        {
        decrements++;
        n1=n2 ;
        }
        n1=n2;
        
    }
    cout << "Has been " << increments << " increments, and " << decrements-1 
    <<" decrements" << endl;

    return 0;
}
