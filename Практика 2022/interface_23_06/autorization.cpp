#include "autorization.h"
#include "ui_autorization.h"
#include "connectcodes.h"
#include <QMessageBox>
#include <QMouseEvent>

Autorization::Autorization(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::Autorization)
{
    ui->setupUi(this);
     ui->label->setVisible(false);

    //db.setHostName("192.168.42.102");176.59.213.32
    //db.setDatabaseName("postgres");
   //   db.setUserName("postgres");
   //   db.setPassword("123");
  // db.setPort(5432);
    QSqlDatabase db = QSqlDatabase::addDatabase("QPSQL");
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
}

Autorization::~Autorization()
{
    delete ui;
}
void Autorization::closeEvent(QCloseEvent *event)
{
    QSqlQuery query(db);
    event->ignore();
    query.prepare("UPDATE Codes SET Online = Online - 1 where Code=:Code  " );  //"INSERT INTO Codes( Code, Maxonl,Online ) "
        query.bindValue( ":Code", ui->lineEdit->text() );
         query.exec();
    event->accept();
    event->accept();
}
void Autorization::on_ConnectB_clicked()
{
    if(ui->lineEdit->text()=="admin"){
         hide();
        ConnectCodes connectw;
        connectw.setModal(true);
        connectw.exec();
    }
    else{
        if(!ui->lineEdit->text().isNull()){
               QSqlQuery query(db);
               query.prepare("SELECT* FROM Codes  where Code=:Code");
               query.bindValue( ":Code", ui->lineEdit->text() );
               query.exec();
               query.first();
               if(!query.value(0).isNull()){
                    query.prepare( "Select * from Codes where Online<Maxonl and Code=:Code  " );   //"INSERT INTO Codes( Code, Maxonl,Online ) "
                    query.bindValue( ":Code", ui->lineEdit->text() );
                    query.exec();
                    query.first();
                    if(!query.value(0).isNull()){
                    query.prepare(  "UPDATE Codes SET Online = Online + 1 where Code=:Code  "  );  //"INSERT INTO Codes( Code, Maxonl,Online ) "
                    query.bindValue( ":Code", ui->lineEdit->text() );
                    query.exec();
                    ui->label->setVisible(true);
                    ui->label->setText("You are Connect! Сongratulations!");
                    ui->lineEdit->setReadOnly(true);
                    }
                    else{
                           ui->label->setVisible(true);
                           ui->label->setText("Too many connections. Connection rejected");}
                       }
                }
                else{
                    ui->label->setVisible(true);
                    ui->label->setText("There is no such code");
                }
        }
}


