// Калькулятор множеств.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>

using namespace std;


bool ok;
int help;

int* create_arr(int s) {
    int* A = new int[s];
    for (int i = 0; i < s; i++) {
        ok = false;
        help = -1;
        while (ok == false) {
            cin >> help;
            while ((help < 0) || (help > 10)) {
                cout << "Введите целочисленное число из U" << endl;
                cin >> help;
            }
            A[i] = help;

            ok = true;
            for (int j = 0; j < i; j++) {
                if (A[i] == A[j]) {
                    ok = false;
                }
            }
            if (ok == false) {
                cout << "Элементы множества не могут повторяться. Повторите еще раз." << endl;
            }
        }
    }
    return A;

}
void print(int *A, int col) {
    
    for (int j = 0; j < col; j++) {
        if (A[j] == 0) {
            cout << A[j];
            if (j != col - 1) {
                cout << ", ";
            }
        }
        if (A[j] != NULL) {
            cout << A[j];
            if (j != col - 1) {
                cout << ", ";
            }
        }
    }
    cout << "}" << endl;

}
void printot(int* A, int col) {

    for (int j = 0; j < col; j++) {
       
        if (A[j] != -1) {
            cout << A[j];
            if (j != col - 1) {
                cout << ", ";
            }
        }
    }
    cout << "}" << endl;

}


int main()
{
   
    setlocale(LC_ALL, "rus");

  
    int col = 0;
    int col2 = 0;
    int Mn;
    int U[] = { 0,1,2,3,4,5,6,7,8,9 };
    int op = 0;
    bool prov;
    
  
    int* A;
    int* B;
    int* C;
    int restart=1;
    while (restart == 1) {
        while ((op <= 0) || (op > 5)) {
            cout << "______________________________________________"<<endl;
            cout << "Введите номер проводимой операции: " << endl;

            cout << "1)Отрицание" << endl;
            cout << "2)Пересечение" << endl;
            cout << "3)Объеденение" << endl;
            cout << "4)Разность" << endl;
            cout << "5)Симметрическая разность" << endl;
            cin >> op;

        }
        switch (op) {
           
                
        case 1:
            cout << "U={0,1,2,3,4,5,6,7,8,9}" << endl;
            while (col <= 0 || col > 10) {
                cout << "Введите количество элементов множества ";
                cin >> col;
            }
            cout << "Вводите элементы множества " << endl;
            A = create_arr(col);
            cout << "A: {";
            print(A, col);
            cout << "Результат: {";

            for (int i = 0; i < 10; i++) {
                prov = false;
                for (int j = 0; j < col; j++) {
                    if (U[i] == A[j]) {
                        prov = true;
                    }
                }
                if (prov != true) {
                    cout << U[i] << " ";
                }
            }
            cout << "}";
            cout << endl;
            col = 0;
            delete A;
            break;
        case 2:
            cout << "U={0,1,2,3,4,5,6,7,8,9}" << endl;
            while (col <= 0 || col > 10) {
                cout << "Введите количество элементов первого множества ";
                cin >> col;
            }
            cout << "Вводите элементы множества " << endl;
            A = create_arr(col);
            cout << "A: {";
            print(A, col);

            while (col2 <= 0 || col2 > 10) {
                cout << "Введите количество элементов второго множества ";
                cin >> col2;
            }
            cout << "Вводите элементы множества " << endl;
            B = create_arr(col2);
            cout << "B: {";

            print(B, col2);
            cout << "Результат: {";

            for (int i = 0; i < col; i++) {
                prov = false;
                for (int j = 0; j < col2; j++) {
                    if (A[i] == B[j]) {
                        prov = true;
                    }

                }
                if (prov == true) {
                    cout << A[i] << " ";
                }

            }

            cout << "}";
            cout << endl;
            col = 0;
            col2 = 0;
            delete A;
            delete B;
            break;

        case 3:
            cout << "U={0,1,2,3,4,5,6,7,8,9}" << endl;
            while (col <= 0 || col > 10) {
                cout << "Введите количество элементов первого множества ";
                cin >> col;
            }
            cout << "Вводите элементы множества " << endl;
            A = create_arr(col);
            cout << "A: {";
            print(A, col);

            while (col2 <= 0 || col2 > 10) {
                cout << "Введите количество элементов второго множества ";
                cin >> col2;
            }
            cout << "Вводите элементы множества " << endl;
            B = create_arr(col2);
            cout << "B: {";

            print(B, col2);
            cout << "Результат: {";
            C = new int[10];
            for (int i = 0; i < col; i++) {
                C[i] = A[i];

            }
            help = 0;
            for (int i = 0; i < col2; i++) {
                prov = false;
                for (int j = 0; j < col; j++) {
                    if (B[i] == A[j]) {
                        prov = true;
                    }


                }
                if (prov == false) {

                    C[col + help] = B[i];
                    help++;


                }

            }
            print(C, col + help);
            col = 0;
            col2 = 0;
            delete A;
            delete B;
            delete C;
            help = 0;
            break;
        case 4:
            cout << "U={0,1,2,3,4,5,6,7,8,9}" << endl;
            while (col <= 0 || col > 10) {
                cout << "Введите количество элементов первого множества ";
                cin >> col;
            }
            cout << "Вводите элементы множества " << endl;
            A = create_arr(col);
            cout << "A: {";
            print(A, col);
            while (col2 <= 0 || col2 > 10) {
                cout << "Введите количество элементов второго множества ";
                cin >> col2;
            }
            cout << "Вводите элементы множества " << endl;
            B = create_arr(col2);
            cout << "B: {";
            print(B, col2);
            C = new int[10];
            cout << "Результат: {";
            help = 0;
            for (int i = 0; i < col; i++) {
                prov = false;
                for (int j = 0; j < col2; j++) {
                    if (A[i] == B[j])
                    {
                        prov = true;
                    }
                }
                if (prov == false) {
                    C[help] = A[i];
                    help++;
                }
            }
            print(C, help);
            col = 0;
            col2 = 0;
            delete A;
            delete B;
            delete C;
            help = 0;
            break;
        case 5:
            cout << "U={0,1,2,3,4,5,6,7,8,9}" << endl;
            while (col <= 0 || col > 10) {
                cout << "Введите количество элементов первого множества ";
                cin >> col;
            }
            cout << "Вводите элементы множества " << endl;
            A = create_arr(col);
            cout << "A: {";
            print(A, col);

            while (col2 <= 0 || col2 > 10) {
                cout << "Введите количество элементов второго множества ";
                cin >> col2;
            }
            cout << "Вводите элементы множества " << endl;
            B = create_arr(col2);
            cout << "B: {";

            print(B, col2);
            cout << "Результат: {";
            C = new int[col + col2];
            for (int i = 0; i < col; i++) {
                C[i] = A[i];
            }
            for (int i = 0; i < col2; i++) {
                C[col + i] = B[i];
            }

            for (int i = 0; i < col; i++) {
                prov = false;
                for (int j = 0; j < col2; j++) {
                    if (A[i] == B[j])
                    {
                        prov = true;
                    }

                }
                if (prov == true) {
                    for (int k = 0; k < col + col2; k++) {
                        if (C[k] == A[i]) {
                            C[k] = -1;
                        }
                    }
                }

            }
            printot(C, col + col2);
            col = 0;
            col2 = 0;
            delete A;
            delete B;
            delete C;
            help = 0;
            break;
        };
        cout << "Для повтора нажмите 1" << endl;
        cin >> restart;
        op = 0;
    }

    
   
  
  
    system("pause");


  



}


