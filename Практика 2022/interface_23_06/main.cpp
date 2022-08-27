#include "autorization.h"

#include <QApplication>
#include <connectcodes.h>
int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
  //  Autorization w;
   // w.show();
    ConnectCodes c;
    c.show();
    return a.exec();
}
