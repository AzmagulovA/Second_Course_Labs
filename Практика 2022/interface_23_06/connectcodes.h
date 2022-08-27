#ifndef CONNECTCODES_H
#define CONNECTCODES_H

#include <QDialog>
#include <QSqlDatabase>
#include <QDebug>
#include <QSqlQuery>
#include <QSqlTableModel>

namespace Ui {
class ConnectCodes;
}

class ConnectCodes : public QDialog
{
    Q_OBJECT

public:
    explicit ConnectCodes(QWidget *parent = nullptr);
    ~ConnectCodes();

private slots:
    void on_AddB_clicked();

    void on_DeleteB_clicked();

    void on_DatabaseTableView_clicked(const QModelIndex &index);

    void on_UpdateTableB_clicked();

private:
    Ui::ConnectCodes *ui;
    QSqlDatabase db;
    QSqlQuery *query;
    QSqlTableModel *model;
    int row;
};

#endif // CONNECTCODES_H
