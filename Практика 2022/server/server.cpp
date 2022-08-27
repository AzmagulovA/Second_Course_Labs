#include "server.h"
#include <QString>
Server::Server()
{
    QSqlDatabase db = QSqlDatabase::addDatabase("QPSQL");//подключение к бд
    db.setHostName("kashin.db.elephantsql.com");
    db.setDatabaseName("focxemsj");
    db.setUserName("focxemsj");
    db.setPassword("wq5cnUbBxKPhTnXtli78zqQFqiBltmQf");
   if(db.open()){
       qDebug(" db open");
   }
   else{
       qDebug("db notopen");
   }

    if(this->listen(QHostAddress::Any,2323))//запуск сервера
    {
        qDebug()<<"start";
    }
    else
    {
        qDebug()<<"error";
    }

}
void Server::incomingConnection(qintptr socketDescriptor)
{
    socket = new QTcpSocket;
    socket->setSocketDescriptor(socketDescriptor);
    connect(socket,&QTcpSocket::readyRead,this,&Server::slotReadyRead);
    connect(socket,&QTcpSocket::disconnected,socket,&QTcpSocket::deleteLater);
    Sockets.push_back(socket);//для каждого клиента создается соккет, который будет храниться в векторе
    qDebug()<<"Connection №"<<socketDescriptor;//сообщение о подключении клиента
}

void Server::slotReadyRead()
{
    socket =(QTcpSocket*)sender();
    QDataStream in(socket);//при помощи in работаем с данными, которые хранятся в сокете
    in.setVersion(QDataStream::Qt_6_2);
    if(in.status()==QDataStream::Ok)//если всё работает
    {
        QString str;
        in>>str;//ввод текста из in в str
        QSqlQuery query(db);
        if(str.at(0)=='?'){
            str.remove(0,1);
            qDebug()<<"Disconnect from code "<<str;
            query.prepare("UPDATE Codes SET Online = Online - 1 where Code=:Code  " );  //"INSERT INTO Codes( Code, Maxonl,Online ) "
            query.bindValue( ":Code", str );
            query.exec();
        }
        else{
        query.prepare("SELECT* FROM Codes  where Code=:Code");
        query.bindValue( ":Code", str );
        query.exec();
        query.first();
        QString stri;
        if(!query.value(0).isNull()){
             query.prepare( "Select * from Codes where Online<Maxonl and Code=:Code  " );   //"INSERT INTO Codes( Code, Maxonl,Online ) "
             query.bindValue( ":Code", str );
             query.exec();
             query.first();
             if(!query.value(0).isNull()){
             query.prepare(  "UPDATE Codes SET Online = Online + 1 where Code=:Code  "  );  //"INSERT INTO Codes( Code, Maxonl,Online ) "
             query.bindValue( ":Code", str );
             query.exec();
             qDebug()<<"Try connection to "<<str<<". Connection is established";
             stri="You are Connect! Сongratulations!";
             }
             else{
             qDebug()<<"Try connection to "<<str<<". Exceeded the number of available connections.";
             stri="Too many connections. Connection rejected";
             }
                }
         else{
              stri="There is no such code";
        }
     SendToClient(stri);
        }
}
    else
    {
        qDebug()<<"DataStream error";
    }
}

void Server::SendToClient(QString str){
Data.clear();//чистим массив
QDataStream out (&Data,QIODevice::WriteOnly);
out.setVersion(QDataStream::Qt_6_2);
out<<str;//ввод массива в data
socket->write(Data);
}
