#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QMouseEvent>
MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
     //
    ui->setupUi(this);
    ui->label->setVisible(false);
    socket = new QTcpSocket(this);
    connect(socket,&QTcpSocket::readyRead,this,&MainWindow::slotReadyRead);
    connect(socket,&QTcpSocket::disconnected,socket,&QTcpSocket::deleteLater);
    socket->connectToHost("127.0.0.1",2323);
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::closeEvent(QCloseEvent *event)
{

    event->ignore();
 SendToServer('?'+ui->lineEdit->text());
  event->accept();
    event->accept();

}


void MainWindow::SendToServer(QString str)
{
    Data.clear();
  QDataStream out (&Data,QIODevice::WriteOnly);
  out.setVersion(QDataStream::Qt_6_2);
  out<<str;
  socket->write(Data);
}

void MainWindow::slotReadyRead()
{
    QDataStream in(socket);
     ui->label->setVisible(true);
    in.setVersion(QDataStream::Qt_6_2);
    if(in.status()==QDataStream::Ok)
    {
        QString str;
        in>>str;
        //ui->textBrowser->append(str);
        if(str=="You are Connect! Сongratulations!")
         {
            ui->lineEdit->setReadOnly(true);

            ui->pushButton_2->setEnabled(false);

        }

        ui->label->setText(str);

    }
    else
    {
      // ui->textBrowser->append("read error");
        ui->label->setText("read error");
    }
}


void MainWindow::on_pushButton_2_clicked()
{
        SendToServer(ui->lineEdit->text());
}

