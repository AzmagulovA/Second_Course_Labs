#include <QCoreApplication>
#include "myserver.h"
int main(int argc, char *argv[])
{
    QCoreApplication a(argc, argv);
    myserver Server;
Server.startServer();
    return a.exec();
}
