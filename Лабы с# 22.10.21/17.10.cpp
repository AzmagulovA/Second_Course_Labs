// 17.10.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//



/*for (int i = 0; i < n; i++) {

}
for (int j = 0; j < n; j++) {

}
if () {

}
else {

}
cout << ;

cin >> ;

int gcd(int a, int b) {//Нахождение НОД
	if (a % b == 0) {
		return b;
	}
	return gcd(b, a % b);
}

int fac(int a){
if()


}
int fib(int a) {
	if (a == 0) {
		return 1;
	}
	if (a == 1) {
		return 1;
	}
	return fib(a - 1) +fib(a - 2);


}
*/
#include <iostream>

using namespace std;


int col(int mas1[], int x, int y, int num) {
	
	if (x > sizeof(mas1)/sizeof(int)) {
		return -1;
	}
	if (num > sizeof(mas1)/ sizeof(int)) {
		return 1;
	}
	if (y == mas1[y]) {
		
		
			x = 1;
			num++;
			col(mas1, x, num, num);
		
	}
	else {
		x++;

		col(mas1, x, mas1[y], num);
	}
	
}
int main()
{
	int n;
	cin >> n;
	int *mas1 = new int[n+1];
	for (int i = 1; i <= n; i++) {
	
		cin >> mas1[i];
	}
	int i;
	 i = col(mas1, 1, mas1[1],1);
	 
	if (i == -1) {
		cout << "Poor Polina";
	}
	else {
		cout << "She can do everything";
	}
}



