#include "connectcodes.h"
#include "ui_connectcodes.h"
#include "addwindow.h"
#include "deletewindow.h"

ConnectCodes::ConnectCodes(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::ConnectCodes)
{
    ui->setupUi(this);

    model=new QSqlTableModel(this,db);
    ui->DatabaseTableView->setModel(model);
    QSqlQueryModel *setquery1 = new QSqlQueryModel;
    setquery1->setQuery("Select * from Codes;");
    ui->DatabaseTableView->setModel(setquery1);
}
ConnectCodes::~ConnectCodes()
{
    delete ui;
}

void ConnectCodes::on_AddB_clicked()
{
    AdminWindow adminw;
    adminw.setModal(true);
    adminw.exec();
   // model->insertRow(model->rowCount());
}


void ConnectCodes::on_DeleteB_clicked()
{
    Deletewindow delet;
    delet.setModal(true);
    delet.exec();
}


void ConnectCodes::on_DatabaseTableView_clicked(const QModelIndex &index)
{
    row=index.row();
}


void ConnectCodes::on_UpdateTableB_clicked()
{
    model=new QSqlTableModel(this,db);
    ui->DatabaseTableView->setModel(model);
    QSqlQueryModel *setquery1 = new QSqlQueryModel;
    setquery1->setQuery("Select * from Codes;");
    ui->DatabaseTableView->setModel(setquery1);
}

