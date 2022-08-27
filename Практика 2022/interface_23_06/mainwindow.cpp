#include "mainwindow.h"
#include "ui_mainwindow.h"

#include "connectcodes.h"
#include <QMessageBox>
MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);

//    socket = new QTcpSocket(this);
//    connect(socket,&QTcpSocket::readyRead,this,&MainWindow::slotReadyRead);
//    connect(socket,&QTcpSocket::disconnected,socket,&QTcpSocket::deleteLater);
//     socket->connectToHost("26.64.194.171",2323);// мой ip
}

MainWindow::~MainWindow()
{
    delete ui;
}


//Второй пример показывает как дать право читать таблицу time_zone в базе mysql пользователю myuser с машины 192.168.0.76
//с паролем mypassy:
//GRANT SELECT ON mysql.time_zone TO myuser@192.168.0.76 IDENTIFIED BY 'mypassy';

void MainWindow::on_ConnectB_clicked()
{


//    SendToServer(ui->ConnectionCodeLineEdit->text());
    if(!ui->ConnectionCodeLineEdit->displayText().isEmpty())
    {
        if(ui->ConnectionCodeLineEdit->displayText()=="admin"){//переход к окну администратора


            ConnectCodes c;
            c.setModal(true);
            c.exec();
        }
    }
}
//void MainWindow::SendToServer(QString str)
//{
//    Data.clear();
//  QDataStream out (&Data,QIODevice::WriteOnly);
//  out.setVersion(QDataStream::Qt_6_2);
//  out<<str;
//  socket->write(Data);
//}

//void MainWindow::slotReadyRead()
//{
//    QDataStream in(socket);
//    in.setVersion(QDataStream::Qt_6_2);
//    if(in.status()==QDataStream::Ok)
//    {


//        QString str;
//        in>>str;
//        ui->textBrowser->append(str);
//    }
//    else
//    {
//       ui->textBrowser->append("read error");
//    }
//}

