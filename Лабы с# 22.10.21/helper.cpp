// helper.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>

using namespace std;

int akk(int m,int n) {
    if (m == 0) {
        return n + 1;

    }
    if ((m > 0) && (n == 0)) {
        return akk(m - 1, 1);
    }
    if ((m > 0) && (n > 0)) {
        return akk(m - 1, akk(m,n-1));
    }


}

int main()
{
    int m,n;
    cin >> m;
    cin >> n;
    
    cout << akk(m, n);
    
}

