#ifndef MYSERVER_H
#define MYSERVER_H

#include <QTcpServer>
#include <QTcpSocket>

class myserver:public QTcpServer//класс, унаследованный от QTcpServer
{
    Q_OBJECT//Является объектом(можем создавать слоты, сигналы к нему)
public:
    myserver();
    ~myserver();//деструктор

    QTcpSocket* socket;//динамическая переменная, отвечающая за сокеты
    QByteArray Data;//данные для передачи по сокету

public slots://методы
    void startServer();//запуск сервера
    void incomingConnection(int socketDescriptor);//где, socketDescriptor-уникальный номер подключения
    void sockReady();//готовность метода читать данные
    void sockDisc();//действия после отключения клиента от сокета


};

#endif // MYSERVER_H
