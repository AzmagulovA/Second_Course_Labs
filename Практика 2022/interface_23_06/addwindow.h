#ifndef ADDWINDOW_H
#define ADDWINDOW_H

#include <QDialog>
#include <QSqlDatabase>
#include <QDebug>
#include <QSqlQuery>
#include <QSqlTableModel>
namespace Ui {
class AdminWindow;
}

class AdminWindow : public QDialog
{
    Q_OBJECT

public:
    explicit AdminWindow(QWidget *parent = nullptr);
    ~AdminWindow();

private slots:
    void on_RandomStrB_clicked();

    void on_AddNewCodeB_clicked();

private:
    Ui::AdminWindow *ui;
    QSqlDatabase db;

};

#endif // ADDWINDOW_H
