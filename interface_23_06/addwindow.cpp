#include "addwindow.h"
#include "ui_addwindow.h"



AdminWindow::AdminWindow(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::AdminWindow)
{
    ui->setupUi(this);


 ui->WarningLabel->setVisible(false);
}

AdminWindow::~AdminWindow()
{
    delete ui;
}

QString RandomStr(){
    QString str="";
    int chislo;
    for (int i=0;i<10;i++){
        chislo=rand()%26+65;
        str=str+(QChar)chislo;
    }

    return str;
}

void AdminWindow::on_RandomStrB_clicked()
{
    QString rcode=RandomStr();
    ui->CodeAddLineEdit->setText(rcode);

}


void AdminWindow::on_AddNewCodeB_clicked()
{

    QSqlQuery query(db);
    query.prepare(
            "SELECT* FROM Codes "
            "   where Code=:Code"
        );
        query.bindValue( ":Code", ui->CodeAddLineEdit->text() );
       query.exec();
       query.first();
    if(query.value(0).isNull()&&(ui->CodeAddLineEdit->text()!="admin")){
        query.prepare(
                "INSERT INTO Codes( Code, Maxonl,Online ) "
                "   VALUES( :Code, :Count,:Online )"
            );
            query.bindValue( ":Code", ui->CodeAddLineEdit->text() );
            query.bindValue( ":Count", ui->CountConnectLineEdit->text() );
               query.bindValue( ":Online", 0 );
             query.exec();
            ui->WarningLabel->setVisible(true);
            ui->WarningLabel->setText("Code is add");
    }
    else{

         ui->WarningLabel->setVisible(true);
         ui->WarningLabel->setText("This code is already there");
    }

}

