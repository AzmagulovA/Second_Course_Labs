#include "deletewindow.h"
#include "ui_deletewindow.h"

Deletewindow::Deletewindow(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::Deletewindow)
{
    ui->setupUi(this);
     ui->label->setVisible(false);
}

Deletewindow::~Deletewindow()
{
    delete ui;
}

void Deletewindow::on_DeleteB_clicked()
{
    QSqlQuery query(db);
    query.prepare(
            "SELECT* FROM Codes "
            "   where Code=:Code"
        );
        query.bindValue( ":Code", ui->lineEdit->text() );
       query.exec();
       query.first();
    if(!query.value(0).isNull()){
        query.prepare("Delete from Codes where Code=:Code ");

            query.bindValue( ":Code", ui->lineEdit->text() );
             query.exec();
            ui->label->setVisible(true);
            ui->label->setText("Code is delete");
    }
    else{

         ui->label->setVisible(true);
         ui->label->setText("There is no such code");
    }
}

