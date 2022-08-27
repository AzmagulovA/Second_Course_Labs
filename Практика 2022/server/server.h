#ifndef SERVER_H
#define SERVER_H
#include <QTcpServer>
#include <QTcpSocket>
#include <QVector>
#include <QSqlDatabase>
#include <QSqlQuery>

class Server : public QTcpServer
{
    Q_OBJECT//
public:
    Server();
    QTcpSocket *socket;//создание сокета
private:
    QSqlDatabase db;
    QSqlQuery *query;
    QVector <QTcpSocket*> Sockets;//вектор для хранения сокетов
    QByteArray Data;//то, что будет путешествовать между клиентом и сервером
    void SendToClient(QString str);//функция передачи данных клиенту

public slots:
    void incomingConnection(qintptr socketDescriptor);//обработка новых подключений
    void slotReadyRead();//обработчик, полученных от клиента сообщений
};

#endif // SERVER_H
//запуск сервера->listen() ->создание клиентского сокета->подключение к серверу->connecttohost()->обработка подключения->incomingconnection
