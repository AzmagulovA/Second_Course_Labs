#include "myserver.h"

myserver::myserver(){}//конструктор

myserver::~myserver(){}

void myserver::startServer(){
    if(this->listen(QHostAddress::Any,5555))//адрес с которого запущен сервер и порт, с которого он будет общаться с сервером
    {
        qDebug()<<"Listening";

    }
    else{
        qDebug()<<"Not Listening";
    }
}
void myserver::incomingConnection(int socketDescriptor)
{
    socket=new QTcpSocket(this);//создание сокета через который будет проходить общение
    socket->setSocketDescriptor(socketDescriptor);//присвоение уникального номера сокету

    connect(socket,SIGNAL(readyRead()),this,SLOT(sockReady()));//описание связей
    connect(socket,SIGNAL(disconnected()),this,SLOT(sockDisc()));


    qDebug()<<socketDescriptor<<"Client connected";

    socket->write("You are connect");
    qDebug()<<"Send client connect status-Yes";
}

void myserver ::sockReady(){

}
void myserver::sockDisc()
{
    qDebug()<<"Disconnect";
    socket-> deleteLater();
}
